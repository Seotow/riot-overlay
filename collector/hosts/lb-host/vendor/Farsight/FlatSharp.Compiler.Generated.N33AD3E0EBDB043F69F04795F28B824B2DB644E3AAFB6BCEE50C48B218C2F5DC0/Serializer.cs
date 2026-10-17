using System;
using System.Diagnostics.CodeAnalysis;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N33AD3E0EBDB043F69F04795F28B824B2DB644E3AAFB6BCEE50C48B218C2F5DC0;

internal class Serializer : IGeneratedSerializer<ScriptVariableSnapshot>
{
	[ExcludeFromCodeCoverage]
	public void __AotHelper()
	{
		Write<ISpanWriter>(null, new byte[10], null, null);
		Write<SpanWriter>(default, new byte[10], null, null);
		ParseLazy<IInputBuffer>(null, default(GeneratedSerializerParseArguments));
		ParseLazy<MemoryInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseLazy<ReadOnlyMemoryInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseLazy<ArrayInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseLazy<ArraySegmentInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseProgressive<IInputBuffer>(null, default(GeneratedSerializerParseArguments));
		ParseProgressive<MemoryInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseProgressive<ReadOnlyMemoryInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseProgressive<ArrayInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseProgressive<ArraySegmentInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseGreedy<IInputBuffer>(null, default(GeneratedSerializerParseArguments));
		ParseGreedy<MemoryInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseGreedy<ReadOnlyMemoryInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseGreedy<ArrayInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseGreedy<ArraySegmentInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseGreedyMutable<IInputBuffer>(null, default(GeneratedSerializerParseArguments));
		ParseGreedyMutable<MemoryInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseGreedyMutable<ReadOnlyMemoryInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseGreedyMutable<ArrayInputBuffer>(default, default(GeneratedSerializerParseArguments));
		ParseGreedyMutable<ArraySegmentInputBuffer>(default, default(GeneratedSerializerParseArguments));
		FSThrow.InvalidOperation_AotHelper();
	}

	[ExcludeFromCodeCoverage]
	public Serializer()
	{
		FlatSharpInternal.AssertFlatSharpRuntimeVersionMatches("7.9.0");
	}

	public void Write<TSpanWriter>(TSpanWriter writer, Span<byte> target, ScriptVariableSnapshot root, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		context.Offset = 4;
		Helpers.Serialize(writer, target, root, 0, context);
	}

	public int GetMaxSize(ScriptVariableSnapshot root)
	{
		return 0 + Helpers.GetMaxSize(root);
	}

	public ScriptVariableSnapshot ParseGreedy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_Greedy(buffer, args.Offset, args.DepthLimit);
	}

	public ScriptVariableSnapshot ParseGreedyMutable<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_GreedyMutable(buffer, args.Offset, args.DepthLimit);
	}

	public ScriptVariableSnapshot ParseProgressive<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_Progressive(buffer, args.Offset, args.DepthLimit);
	}

	public ScriptVariableSnapshot ParseLazy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_Lazy(buffer, args.Offset, args.DepthLimit);
	}

	ScriptVariableSnapshot IGeneratedSerializer<ScriptVariableSnapshot>.ParseLazy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseLazy(buffer, in arguments);
	}

	ScriptVariableSnapshot IGeneratedSerializer<ScriptVariableSnapshot>.ParseProgressive<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseProgressive(buffer, in arguments);
	}

	ScriptVariableSnapshot IGeneratedSerializer<ScriptVariableSnapshot>.ParseGreedy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseGreedy(buffer, in arguments);
	}

	ScriptVariableSnapshot IGeneratedSerializer<ScriptVariableSnapshot>.ParseGreedyMutable<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseGreedyMutable(buffer, in arguments);
	}
}
