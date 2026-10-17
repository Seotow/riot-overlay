using System;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.WebSockets;
using System.Text.Json;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;

namespace IndependentCollector;

public static class Program
{
    public static async Task<int> Main(string[] args)
    {
        if (args.Contains("--help"))
        {
            Console.WriteLine("IndependentCollector --identity --pid PID\n" +
                "IndependentCollector --pid PID --profile FILE [--heroes 0x...,0x...] [--allow-unverified-profile] [--port 18801] [--interval 100] [--record NEW_FILE]\n" +
                "IndependentCollector --fixture FILE --profile FIXTURE_PROFILE [--port 18801] [--record NEW_FILE]\n" +
                "Experimental: no BlueBottle authentication, no lblib; no verified game parity or automatic object discovery.");
            return 0;
        }
        Options options;
        try { options = Options.Parse(args); }
        catch (Exception error) when (error is ArgumentException or FormatException or OverflowException)
        {
            Console.Error.WriteLine("Invalid options. Use --help."); return 2;
        }
        if (options.Identity)
        {
            try
            {
                Console.WriteLine(JsonSerializer.Serialize(TargetIdentity.Measure(options.ProcessId!.Value), Hub.Json));
                return 0;
            }
            catch (ReaderException error)
            {
                Console.Error.WriteLine(JsonSerializer.Serialize(new { error = error.Code, message = error.Message }, Hub.Json));
                return 3;
            }
            catch (Exception error)
            {
                Console.Error.WriteLine(JsonSerializer.Serialize(new { error = "identity_unavailable", category = error.GetType().Name }, Hub.Json));
                return 3;
            }
        }
        Recording recorder;
        try { recorder = new Recording(options.Record); }
        catch (Exception error) when (error is IOException or UnauthorizedAccessException or ArgumentException)
        {
            Console.Error.WriteLine(JsonSerializer.Serialize(new { error = "recording_open_failed",
                message = "Cannot create a new recording file; existing files are never overwritten", category = error.GetType().Name }, Hub.Json));
            return 2;
        }
        using var recording = recorder;
        var builder = WebApplication.CreateBuilder(new WebApplicationOptions { Args = [], ContentRootPath = AppContext.BaseDirectory });
        builder.Logging.ClearProviders();
        builder.WebHost.ConfigureKestrel(server => { server.Listen(IPAddress.Loopback, options.Port); server.Limits.MaxRequestBodySize = 4096; });
        builder.Services.AddSingleton(options);
        builder.Services.AddSingleton(recording);
        builder.Services.AddSingleton<Hub>();
        builder.Services.AddHostedService<Worker>();
        var app = builder.Build();
        app.Use(async (context, next) =>
        {
            string host = context.Request.Host.Host, origin = context.Request.Headers.Origin.ToString();
            bool localOrigin = origin.Length == 0 || Uri.TryCreate(origin, UriKind.Absolute, out var uri) &&
                uri.Scheme == "http" && (uri.Host == "127.0.0.1" || uri.Host == "localhost") && uri.Port == options.Port;
            if ((host != "127.0.0.1" && host != "localhost") || !localOrigin) { context.Response.StatusCode = 403; return; }
            context.Response.Headers.CacheControl = "no-store";
            context.Response.Headers.XContentTypeOptions = "nosniff";
            await next(context);
        });
        app.UseWebSockets(new WebSocketOptions { KeepAliveInterval = TimeSpan.FromSeconds(20) });
        app.MapGet("/api/status", (Hub hub) => Results.Json(hub.Status(), Hub.Json));
        app.MapGet("/api/snapshot", (Hub hub) =>
        {
            var frame = hub.Latest();
            if (frame.Json == null) return (IResult)Results.NoContent();
            if (frame.Stale) return Results.Json(new { error = "snapshot_stale" }, statusCode: 503);
            return Results.Bytes(frame.Json, "application/json");
        });
        app.MapGet("/ws", Stream);
        app.MapGet("/", () => Results.Text("IndependentCollector experimental. /api/status /api/snapshot /ws\nNo automatic object discovery or verified LB parity.\n"));
        Console.WriteLine($"IndependentCollector: http://127.0.0.1:{options.Port}/ | mode={(options.Fixture != null ? "synthetic-fixture" : "Windows-memory")}");
        await app.RunAsync();
        return 0;
    }

    private static async Task Stream(HttpContext context, Hub hub)
    {
        if (!context.WebSockets.IsWebSocketRequest) { context.Response.StatusCode = 400; return; }
        Hub.Subscription subscription;
        try { subscription = hub.Subscribe(); }
        catch (InvalidOperationException) { context.Response.StatusCode = 503; return; }
        using (subscription)
        using (var socket = await context.WebSockets.AcceptWebSocketAsync())
        using (var stop = CancellationTokenSource.CreateLinkedTokenSource(context.RequestAborted))
        {
            async Task Send()
            {
                await foreach (var frame in subscription.Reader.ReadAllAsync(stop.Token))
                {
                    using var timeout = CancellationTokenSource.CreateLinkedTokenSource(stop.Token);
                    timeout.CancelAfter(TimeSpan.FromSeconds(5));
                    await socket.SendAsync(frame.AsMemory(), WebSocketMessageType.Text, true, timeout.Token);
                }
            }
            async Task Receive()
            {
                var result = await socket.ReceiveAsync(new byte[1024].AsMemory(), stop.Token);
                await socket.CloseOutputAsync(result.MessageType == WebSocketMessageType.Close ?
                    WebSocketCloseStatus.NormalClosure : WebSocketCloseStatus.PolicyViolation,
                    result.MessageType == WebSocketMessageType.Close ? "Closed" : "Read-only stream", stop.Token);
            }
            Task sending = Send(), receiving = Receive();
            try { await Task.WhenAny(sending, receiving); }
            finally
            {
                stop.Cancel();
                try { await Task.WhenAll(sending, receiving); }
                catch (Exception error) when (error is OperationCanceledException or WebSocketException or IOException) { }
            }
        }
    }
}
