using System.Security.Cryptography;
using System.Text.Json;
using System.Text.RegularExpressions;
using Amazon;
using Amazon.S3;
using Amazon.S3.Model;
using Farsight.Utils;
using Farsight.Web;

namespace LeagueCollector;

public sealed class NativeLibraryFetcher(CollectorOptions options, BlueBottleAuth auth) : IGameLibFetcher
{
    private Version? lastRequestedVersion;
    private const string Bucket = "bb-lb-libs";
    private static readonly Regex Name = new(@"^lblib-(\d+\.\d+\.\d+)-(\d+\.\d+\.\d+)\.dll$", RegexOptions.CultureInvariant);
    public async Task UpdateOrResetLib(Version desiredVersion, string fileLocation, DateTime? fileCreatedAt = null, CancellationToken? cancellationToken = null)
    {
        lastRequestedVersion = desiredVersion;
        var ct = cancellationToken ?? CancellationToken.None;
        var metaPath = fileLocation + ".version.json";
        if (!options.UpdateLib && File.Exists(fileLocation) && File.Exists(metaPath))
        {
            var meta = JsonSerializer.Deserialize<LibraryMetadata>(await File.ReadAllTextAsync(metaPath, ct), CollectorHub.Json)!;
            if (new Version(meta.MinVersion) < desiredVersion && desiredVersion < new Version(meta.MaxVersion))
            {
                var sha = Convert.ToHexStringLower(SHA256.HashData(await File.ReadAllBytesAsync(fileLocation, ct)));
                if (sha != meta.Sha256) throw new InvalidDataException("native_library_hash_mismatch");
                DllValidator.Validate(fileLocation);
                return;
            }
        }
        // A bounded validation must not silently replace the pinned DLL when
        // metadata/version is incompatible. Updating requires explicit opt-in.
        if (!options.UpdateLib) throw new InvalidOperationException("native_library_version_unavailable");
        using var s3 = new AmazonS3Client(await auth.Credentials(ct), RegionEndpoint.EUCentral1);
        string? continuation = null;
        var candidates = new List<(string Key, Version Min, Version Max)>();
        do
        {
            var response = await s3.ListObjectsV2Async(new ListObjectsV2Request { BucketName = Bucket, Prefix = "lblib-", ContinuationToken = continuation }, ct);
            foreach (var obj in response.S3Objects ?? [])
            {
                var m = Name.Match(obj.Key);
                if (!m.Success) continue;
                var min = new Version(m.Groups[1].Value); var max = new Version(m.Groups[2].Value);
                if (min < desiredVersion && desiredVersion < max) candidates.Add((obj.Key, min, max));
            }
            continuation = response.IsTruncated == true ? response.NextContinuationToken : null;
        } while (continuation != null);
        var selected = candidates.OrderByDescending(c => c.Min).ThenByDescending(c => c.Max).FirstOrDefault();
        if (selected.Key == null) throw new InvalidOperationException("native_library_version_unavailable");
        string temp = fileLocation + "." + Guid.NewGuid().ToString("N") + ".partial";
        try
        {
            using var response = await s3.GetObjectAsync(Bucket, selected.Key, ct);
            if (response.ContentLength > 128 * 1024 * 1024) throw new InvalidDataException("native_library_too_large");
            await using (var file = File.Create(temp)) await response.ResponseStream.CopyToAsync(file, ct);
            if (new FileInfo(temp).Length > 128 * 1024 * 1024) throw new InvalidDataException("native_library_too_large");
            DllValidator.Validate(temp);
            var meta = new LibraryMetadata(selected.Key, selected.Min.ToString(), selected.Max.ToString(), Convert.ToHexStringLower(SHA256.HashData(await File.ReadAllBytesAsync(temp, ct))));
            File.Move(temp, fileLocation, true);
            await File.WriteAllTextAsync(metaPath, JsonSerializer.Serialize(meta, CollectorHub.Json), ct);
        }
        finally { if (File.Exists(temp)) File.Delete(temp); }
    }

    public Task UpdateFileIfOutdated(LibVersionInfo currentVersionInfo, string fileLocation, DateTime? fileCreatedAt = null, CancellationToken? cancellationToken = null) =>
        new NativeLibraryFetcher(options with { UpdateLib = true }, auth).UpdateOrResetLib(
            lastRequestedVersion ?? throw new InvalidOperationException("game_version_required_for_update"), fileLocation, fileCreatedAt, cancellationToken);
    public sealed record LibraryMetadata(string Key, string MinVersion, string MaxVersion, string Sha256);
}
