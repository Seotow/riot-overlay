using System;
using System.Diagnostics.CodeAnalysis;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NE64E6E244E5B5A103B2AFFF0A7914CDEFE55D1E98BF2A3055BCCBE8B2E95A05B;

internal class Serializer : IGeneratedSerializer<EntitySnapshot>
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

	public void Write<TSpanWriter>(TSpanWriter writer, Span<byte> target, EntitySnapshot root, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		context.Offset = 4;
		Helpers.Serialize(writer, target, root, 0, context);
	}

	public int GetMaxSize(EntitySnapshot root)
	{
		return 0 + Helpers.GetMaxSize(root);
	}

	public EntitySnapshot ParseGreedy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_Greedy(buffer, args.Offset, args.DepthLimit);
	}

	public EntitySnapshot ParseGreedyMutable<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_GreedyMutable(buffer, args.Offset, args.DepthLimit);
	}

	public EntitySnapshot ParseProgressive<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_Progressive(buffer, args.Offset, args.DepthLimit);
	}

	public EntitySnapshot ParseLazy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments args) where TInputBuffer : IInputBuffer
	{
		return Helpers.Parse_Lazy(buffer, args.Offset, args.DepthLimit);
	}

	EntitySnapshot IGeneratedSerializer<EntitySnapshot>.ParseLazy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseLazy(buffer, in arguments);
	}

	EntitySnapshot IGeneratedSerializer<EntitySnapshot>.ParseProgressive<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseProgressive(buffer, in arguments);
	}

	EntitySnapshot IGeneratedSerializer<EntitySnapshot>.ParseGreedy<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseGreedy(buffer, in arguments);
	}

	EntitySnapshot IGeneratedSerializer<EntitySnapshot>.ParseGreedyMutable<TInputBuffer>(TInputBuffer buffer, in GeneratedSerializerParseArguments arguments)
	{
		return ParseGreedyMutable(buffer, in arguments);
	}
}
