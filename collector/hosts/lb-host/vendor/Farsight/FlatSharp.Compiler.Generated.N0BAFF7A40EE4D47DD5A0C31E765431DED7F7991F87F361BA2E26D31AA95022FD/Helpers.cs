using System;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N45406B94047B36163EBB04E4D4C69EF518ABF40F78C0298DD2506338B742C444;
using FlatSharp.Compiler.Generated.N9514B035D2A9A46AB45D2C02FA0548FE6DA5395AF705F6E4B8527BC899221A64;
using FlatSharp.Compiler.Generated.NAEC6202509BBCBF7D8A8581B5BE75F3B6CFA6BF617528B5DFCC29FF3351E436B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N0BAFF7A40EE4D47DD5A0C31E765431DED7F7991F87F361BA2E26D31AA95022FD;

internal static class Helpers
{
	internal static int GetMaxSize(CameraPreviewController value)
	{
		byte discriminator = value.Discriminator;
		switch (discriminator)
		{
		case 1:
			return 7 + FlatSharp.Compiler.Generated.N45406B94047B36163EBB04E4D4C69EF518ABF40F78C0298DD2506338B742C444.Helpers.GetMaxSize(value.Item1);
		case 2:
			return 7 + FlatSharp.Compiler.Generated.N9514B035D2A9A46AB45D2C02FA0548FE6DA5395AF705F6E4B8527BC899221A64.Helpers.GetMaxSize(value.Item2);
		case 3:
			return 7 + FlatSharp.Compiler.Generated.NAEC6202509BBCBF7D8A8581B5BE75F3B6CFA6BF617528B5DFCC29FF3351E436B.Helpers.GetMaxSize(value.Item3);
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewController>(discriminator);
			return 0;
		}
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CameraPreviewController value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		byte discriminator = value.Discriminator;
		spanWriter.WriteByte(span, discriminator, offset.offset0);
		switch (discriminator)
		{
		case 1:
		{
			int item3 = offset.offset1;
			FlatSharp.Compiler.Generated.N45406B94047B36163EBB04E4D4C69EF518ABF40F78C0298DD2506338B742C444.Helpers.Serialize(spanWriter, span, value.Item1, item3, context);
			break;
		}
		case 2:
		{
			int item2 = offset.offset1;
			FlatSharp.Compiler.Generated.N9514B035D2A9A46AB45D2C02FA0548FE6DA5395AF705F6E4B8527BC899221A64.Helpers.Serialize(spanWriter, span, value.Item2, item2, context);
			break;
		}
		case 3:
		{
			int item = offset.offset1;
			FlatSharp.Compiler.Generated.NAEC6202509BBCBF7D8A8581B5BE75F3B6CFA6BF617528B5DFCC29FF3351E436B.Helpers.Serialize(spanWriter, span, value.Item3, item, context);
			break;
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewController>(discriminator);
			break;
		}
	}

	internal static CameraPreviewController Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.N45406B94047B36163EBB04E4D4C69EF518ABF40F78C0298DD2506338B742C444.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 2:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.N9514B035D2A9A46AB45D2C02FA0548FE6DA5395AF705F6E4B8527BC899221A64.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 3:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.NAEC6202509BBCBF7D8A8581B5BE75F3B6CFA6BF617528B5DFCC29FF3351E436B.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewController>(b);
			return default;
		}
	}

	internal static CameraPreviewController Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.N45406B94047B36163EBB04E4D4C69EF518ABF40F78C0298DD2506338B742C444.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 2:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.N9514B035D2A9A46AB45D2C02FA0548FE6DA5395AF705F6E4B8527BC899221A64.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 3:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.NAEC6202509BBCBF7D8A8581B5BE75F3B6CFA6BF617528B5DFCC29FF3351E436B.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewController>(b);
			return default;
		}
	}

	internal static CameraPreviewController Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.N45406B94047B36163EBB04E4D4C69EF518ABF40F78C0298DD2506338B742C444.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 2:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.N9514B035D2A9A46AB45D2C02FA0548FE6DA5395AF705F6E4B8527BC899221A64.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 3:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.NAEC6202509BBCBF7D8A8581B5BE75F3B6CFA6BF617528B5DFCC29FF3351E436B.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewController>(b);
			return default;
		}
	}

	internal static CameraPreviewController Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.N45406B94047B36163EBB04E4D4C69EF518ABF40F78C0298DD2506338B742C444.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 2:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.N9514B035D2A9A46AB45D2C02FA0548FE6DA5395AF705F6E4B8527BC899221A64.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 3:
			return new CameraPreviewController(FlatSharp.Compiler.Generated.NAEC6202509BBCBF7D8A8581B5BE75F3B6CFA6BF617528B5DFCC29FF3351E436B.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewController>(b);
			return default;
		}
	}
}
