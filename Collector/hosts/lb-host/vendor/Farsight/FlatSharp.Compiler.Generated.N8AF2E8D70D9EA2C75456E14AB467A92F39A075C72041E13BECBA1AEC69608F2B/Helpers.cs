using System;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N647F5A319B660E95DC63BC2923992ACCEAD171F4D488F805FA796F378B518101;
using FlatSharp.Compiler.Generated.NF7FD7BF67DA12F6B852F7FE36BB1A353C3D84DE35AEF2D56609FD6B5F75FE141;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N8AF2E8D70D9EA2C75456E14AB467A92F39A075C72041E13BECBA1AEC69608F2B;

internal static class Helpers
{
	internal static int GetMaxSize(CameraPreviewLayout value)
	{
		byte discriminator = value.Discriminator;
		switch (discriminator)
		{
		case 1:
			return 7 + FlatSharp.Compiler.Generated.NF7FD7BF67DA12F6B852F7FE36BB1A353C3D84DE35AEF2D56609FD6B5F75FE141.Helpers.GetMaxSize(value.Item1);
		case 2:
			return 7 + FlatSharp.Compiler.Generated.N647F5A319B660E95DC63BC2923992ACCEAD171F4D488F805FA796F378B518101.Helpers.GetMaxSize(value.Item2);
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewLayout>(discriminator);
			return 0;
		}
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CameraPreviewLayout value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		byte discriminator = value.Discriminator;
		spanWriter.WriteByte(span, discriminator, offset.offset0);
		switch (discriminator)
		{
		case 1:
		{
			int item2 = offset.offset1;
			FlatSharp.Compiler.Generated.NF7FD7BF67DA12F6B852F7FE36BB1A353C3D84DE35AEF2D56609FD6B5F75FE141.Helpers.Serialize(spanWriter, span, value.Item1, item2, context);
			break;
		}
		case 2:
		{
			int item = offset.offset1;
			FlatSharp.Compiler.Generated.N647F5A319B660E95DC63BC2923992ACCEAD171F4D488F805FA796F378B518101.Helpers.Serialize(spanWriter, span, value.Item2, item, context);
			break;
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewLayout>(discriminator);
			break;
		}
	}

	internal static CameraPreviewLayout Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new CameraPreviewLayout(FlatSharp.Compiler.Generated.NF7FD7BF67DA12F6B852F7FE36BB1A353C3D84DE35AEF2D56609FD6B5F75FE141.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 2:
			return new CameraPreviewLayout(FlatSharp.Compiler.Generated.N647F5A319B660E95DC63BC2923992ACCEAD171F4D488F805FA796F378B518101.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewLayout>(b);
			return default;
		}
	}

	internal static CameraPreviewLayout Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new CameraPreviewLayout(FlatSharp.Compiler.Generated.NF7FD7BF67DA12F6B852F7FE36BB1A353C3D84DE35AEF2D56609FD6B5F75FE141.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 2:
			return new CameraPreviewLayout(FlatSharp.Compiler.Generated.N647F5A319B660E95DC63BC2923992ACCEAD171F4D488F805FA796F378B518101.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewLayout>(b);
			return default;
		}
	}

	internal static CameraPreviewLayout Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new CameraPreviewLayout(FlatSharp.Compiler.Generated.NF7FD7BF67DA12F6B852F7FE36BB1A353C3D84DE35AEF2D56609FD6B5F75FE141.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 2:
			return new CameraPreviewLayout(FlatSharp.Compiler.Generated.N647F5A319B660E95DC63BC2923992ACCEAD171F4D488F805FA796F378B518101.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewLayout>(b);
			return default;
		}
	}

	internal static CameraPreviewLayout Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new CameraPreviewLayout(FlatSharp.Compiler.Generated.NF7FD7BF67DA12F6B852F7FE36BB1A353C3D84DE35AEF2D56609FD6B5F75FE141.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 2:
			return new CameraPreviewLayout(FlatSharp.Compiler.Generated.N647F5A319B660E95DC63BC2923992ACCEAD171F4D488F805FA796F378B518101.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewLayout>(b);
			return default;
		}
	}
}
