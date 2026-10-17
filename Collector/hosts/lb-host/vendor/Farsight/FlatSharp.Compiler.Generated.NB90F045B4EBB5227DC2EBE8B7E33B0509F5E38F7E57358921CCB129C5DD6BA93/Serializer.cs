using System;
using System.Diagnostics.CodeAnalysis;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NB90F045B4EBB5227DC2EBE8B7E33B0509F5E38F7E57358921CCB129C5DD6BA93;

internal class Serializer : IGeneratedSerializer<SetComponent>
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

	public void Write<TSpanWriter>(TSpanWriter writer, Span<byte> target, SetComponent root, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		context.Offset = 4;
		Helpers.Serialize(writer, target, root, 0, context);
	}

	public int GetMaxSize(SetComponent root)
	{
		return 0 + Helpers.GetMaxSize(root);
	}

	public SetComponent ParseGreedy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_Greedy(buffer, args.Offset, args.DepthLimit);
	}

	public SetComponent ParseGreedyMutable<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_GreedyMutable(buffer, args.Offset, args.DepthLimit);
	}

	public SetComponent ParseProgressive<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_Progressive(buffer, args.Offset, args.DepthLimit);
	}

	public SetComponent ParseLazy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_Lazy(buffer, args.Offset, args.DepthLimit);
	}

	SetComponent IGeneratedSerializer<SetComponent>.ParseLazy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseLazy(buffer, in arguments);
	}

	SetComponent IGeneratedSerializer<SetComponent>.ParseProgressive<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseProgressive(buffer, in arguments);
	}

	SetComponent IGeneratedSerializer<SetComponent>.ParseGreedy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseGreedy(buffer, in arguments);
	}

	SetComponent IGeneratedSerializer<SetComponent>.ParseGreedyMutable<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseGreedyMutable(buffer, in arguments);
	}
}
