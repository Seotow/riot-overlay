using System;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.N90AE9307D2820B1B96732B03FD831D62047EDAA40B4794042C56D8CF374F3EE6;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N42DA1EEA183F24DBE911A87BEA641D42F4F864E6E6B0686B319E1BDFC7096ABD;

internal static class Helpers
{
	internal static int GetMaxSize(AssetIdentifier value)
	{
		byte discriminator = value.Discriminator;
		switch (discriminator)
		{
		case 1:
			return 7 + FlatSharp.Compiler.Generated.N90AE9307D2820B1B96732B03FD831D62047EDAA40B4794042C56D8CF374F3EE6.Helpers.GetMaxSize(value.Item1);
		case 2:
			return 7 + FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(value.Item2);
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<AssetIdentifier>(discriminator);
			return 0;
		}
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AssetIdentifier value, ref (int offset0, int offset1) offset, SerializationContext context, TableFieldContext fieldContext) where TSpanWriter : ISpanWriter
	{
		byte discriminator = value.Discriminator;
		spanWriter.WriteByte(span, discriminator, offset.offset0);
		switch (discriminator)
		{
		case 1:
		{
			int item2 = offset.offset1;
			FlatSharp.Compiler.Generated.N90AE9307D2820B1B96732B03FD831D62047EDAA40B4794042C56D8CF374F3EE6.Helpers.Serialize(spanWriter, span, value.Item1, item2, context);
			break;
		}
		case 2:
		{
			int item = offset.offset1;
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, value.Item2, item, context, fieldContext);
			break;
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<AssetIdentifier>(discriminator);
			break;
		}
	}

	internal static AssetIdentifier Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new AssetIdentifier(FlatSharp.Compiler.Generated.N90AE9307D2820B1B96732B03FD831D62047EDAA40B4794042C56D8CF374F3EE6.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 2:
			return new AssetIdentifier(FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<AssetIdentifier>(b);
			return default;
		}
	}

	internal static AssetIdentifier Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new AssetIdentifier(FlatSharp.Compiler.Generated.N90AE9307D2820B1B96732B03FD831D62047EDAA40B4794042C56D8CF374F3EE6.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 2:
			return new AssetIdentifier(FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<AssetIdentifier>(b);
			return default;
		}
	}

	internal static AssetIdentifier Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new AssetIdentifier(FlatSharp.Compiler.Generated.N90AE9307D2820B1B96732B03FD831D62047EDAA40B4794042C56D8CF374F3EE6.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 2:
			return new AssetIdentifier(FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<AssetIdentifier>(b);
			return default;
		}
	}

	internal static AssetIdentifier Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new AssetIdentifier(FlatSharp.Compiler.Generated.N90AE9307D2820B1B96732B03FD831D62047EDAA40B4794042C56D8CF374F3EE6.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 2:
			return new AssetIdentifier(FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<AssetIdentifier>(b);
			return default;
		}
	}
}
