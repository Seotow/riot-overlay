using System;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp.Compiler.Generated.N0E8BE41C014BEDA7170D52DF6BFF9D47C366F712224B9EE97715CF1BB3FF6DEF;
using FlatSharp.Compiler.Generated.N11BDFB110B0C663C92CA2111B8AEDA2B3D491ED4C86D2C48EBD45BA9F3487431;
using FlatSharp.Compiler.Generated.N1CE29980970708520611434CAE77FA847B3634B8909E0FA0EBA980ED85EFB7AA;
using FlatSharp.Compiler.Generated.N3C8250741D846A6C951661E38F59B91E9EBA3C1639B3F6ABAF9B0E174B0BE78D;
using FlatSharp.Compiler.Generated.N442B6423A519349ECAAD43B6A755ECF9FC6F5820A0427C3DC888DF71DB2BDF68;
using FlatSharp.Compiler.Generated.N559C64490EB42C80A2F10A30999A9652C39CE5656F47946E81274887B3E4825E;
using FlatSharp.Compiler.Generated.N723B83EBF9F923C095BAC53C6D757C39546F7BEA4A60F67CD2820C84BB0A9AF4;
using FlatSharp.Compiler.Generated.N89C289FBD8995A154A152A7DEE8D4E991E03F6DE0BC52462C0B160C99156A1AB;
using FlatSharp.Compiler.Generated.N8E2EE111B17D167C3AA9409339E6F552A05447E1856A692CA97E493CBD8373D3;
using FlatSharp.Compiler.Generated.NE37AD1DA144DBCF43F76A308F2BAD88A305C92BE9484E5D9223A7184009954C3;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.ND0FC3ABBD6A762E619D3E4BD7A1716BA78A3C93D12EA9174BE338CC162CE16E9;

internal static class Helpers
{
	internal static int GetMaxSize(Component value)
	{
		byte discriminator = value.Discriminator;
		switch (discriminator)
		{
		case 1:
			return 7 + FlatSharp.Compiler.Generated.N89C289FBD8995A154A152A7DEE8D4E991E03F6DE0BC52462C0B160C99156A1AB.Helpers.GetMaxSize(value.Item1);
		case 2:
			return 7 + FlatSharp.Compiler.Generated.N8E2EE111B17D167C3AA9409339E6F552A05447E1856A692CA97E493CBD8373D3.Helpers.GetMaxSize(value.Item2);
		case 3:
			return 7 + FlatSharp.Compiler.Generated.N0E8BE41C014BEDA7170D52DF6BFF9D47C366F712224B9EE97715CF1BB3FF6DEF.Helpers.GetMaxSize(value.Item3);
		case 4:
			return 7 + FlatSharp.Compiler.Generated.N442B6423A519349ECAAD43B6A755ECF9FC6F5820A0427C3DC888DF71DB2BDF68.Helpers.GetMaxSize(value.Item4);
		case 5:
			return 7 + FlatSharp.Compiler.Generated.N11BDFB110B0C663C92CA2111B8AEDA2B3D491ED4C86D2C48EBD45BA9F3487431.Helpers.GetMaxSize(value.Item5);
		case 6:
			return 7 + FlatSharp.Compiler.Generated.NE37AD1DA144DBCF43F76A308F2BAD88A305C92BE9484E5D9223A7184009954C3.Helpers.GetMaxSize(value.Item6);
		case 7:
			return 7 + FlatSharp.Compiler.Generated.N1CE29980970708520611434CAE77FA847B3634B8909E0FA0EBA980ED85EFB7AA.Helpers.GetMaxSize(value.Item7);
		case 8:
			return 7 + FlatSharp.Compiler.Generated.N723B83EBF9F923C095BAC53C6D757C39546F7BEA4A60F67CD2820C84BB0A9AF4.Helpers.GetMaxSize(value.Item8);
		case 9:
			return 7 + FlatSharp.Compiler.Generated.N559C64490EB42C80A2F10A30999A9652C39CE5656F47946E81274887B3E4825E.Helpers.GetMaxSize(value.Item9);
		case 10:
			return 7 + FlatSharp.Compiler.Generated.N3C8250741D846A6C951661E38F59B91E9EBA3C1639B3F6ABAF9B0E174B0BE78D.Helpers.GetMaxSize(value.Item10);
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<Component>(discriminator);
			return 0;
		}
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Component value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		byte discriminator = value.Discriminator;
		spanWriter.WriteByte(span, discriminator, offset.offset0);
		switch (discriminator)
		{
		case 1:
		{
			int item10 = offset.offset1;
			FlatSharp.Compiler.Generated.N89C289FBD8995A154A152A7DEE8D4E991E03F6DE0BC52462C0B160C99156A1AB.Helpers.Serialize(spanWriter, span, value.Item1, item10, context);
			break;
		}
		case 2:
		{
			int item9 = offset.offset1;
			FlatSharp.Compiler.Generated.N8E2EE111B17D167C3AA9409339E6F552A05447E1856A692CA97E493CBD8373D3.Helpers.Serialize(spanWriter, span, value.Item2, item9, context);
			break;
		}
		case 3:
		{
			int item8 = offset.offset1;
			FlatSharp.Compiler.Generated.N0E8BE41C014BEDA7170D52DF6BFF9D47C366F712224B9EE97715CF1BB3FF6DEF.Helpers.Serialize(spanWriter, span, value.Item3, item8, context);
			break;
		}
		case 4:
		{
			int item7 = offset.offset1;
			FlatSharp.Compiler.Generated.N442B6423A519349ECAAD43B6A755ECF9FC6F5820A0427C3DC888DF71DB2BDF68.Helpers.Serialize(spanWriter, span, value.Item4, item7, context);
			break;
		}
		case 5:
		{
			int item6 = offset.offset1;
			FlatSharp.Compiler.Generated.N11BDFB110B0C663C92CA2111B8AEDA2B3D491ED4C86D2C48EBD45BA9F3487431.Helpers.Serialize(spanWriter, span, value.Item5, item6, context);
			break;
		}
		case 6:
		{
			int item5 = offset.offset1;
			FlatSharp.Compiler.Generated.NE37AD1DA144DBCF43F76A308F2BAD88A305C92BE9484E5D9223A7184009954C3.Helpers.Serialize(spanWriter, span, value.Item6, item5, context);
			break;
		}
		case 7:
		{
			int item4 = offset.offset1;
			FlatSharp.Compiler.Generated.N1CE29980970708520611434CAE77FA847B3634B8909E0FA0EBA980ED85EFB7AA.Helpers.Serialize(spanWriter, span, value.Item7, item4, context);
			break;
		}
		case 8:
		{
			int item3 = offset.offset1;
			FlatSharp.Compiler.Generated.N723B83EBF9F923C095BAC53C6D757C39546F7BEA4A60F67CD2820C84BB0A9AF4.Helpers.Serialize(spanWriter, span, value.Item8, item3, context);
			break;
		}
		case 9:
		{
			int item2 = offset.offset1;
			FlatSharp.Compiler.Generated.N559C64490EB42C80A2F10A30999A9652C39CE5656F47946E81274887B3E4825E.Helpers.Serialize(spanWriter, span, value.Item9, item2, context);
			break;
		}
		case 10:
		{
			int item = offset.offset1;
			FlatSharp.Compiler.Generated.N3C8250741D846A6C951661E38F59B91E9EBA3C1639B3F6ABAF9B0E174B0BE78D.Helpers.Serialize(spanWriter, span, value.Item10, item, context);
			break;
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<Component>(discriminator);
			break;
		}
	}

	internal static Component Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new Component(FlatSharp.Compiler.Generated.N89C289FBD8995A154A152A7DEE8D4E991E03F6DE0BC52462C0B160C99156A1AB.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 2:
			return new Component(FlatSharp.Compiler.Generated.N8E2EE111B17D167C3AA9409339E6F552A05447E1856A692CA97E493CBD8373D3.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 3:
			return new Component(FlatSharp.Compiler.Generated.N0E8BE41C014BEDA7170D52DF6BFF9D47C366F712224B9EE97715CF1BB3FF6DEF.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 4:
			return new Component(FlatSharp.Compiler.Generated.N442B6423A519349ECAAD43B6A755ECF9FC6F5820A0427C3DC888DF71DB2BDF68.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 5:
			return new Component(FlatSharp.Compiler.Generated.N11BDFB110B0C663C92CA2111B8AEDA2B3D491ED4C86D2C48EBD45BA9F3487431.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 6:
			return new Component(FlatSharp.Compiler.Generated.NE37AD1DA144DBCF43F76A308F2BAD88A305C92BE9484E5D9223A7184009954C3.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 7:
			return new Component(FlatSharp.Compiler.Generated.N1CE29980970708520611434CAE77FA847B3634B8909E0FA0EBA980ED85EFB7AA.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 8:
			return new Component(FlatSharp.Compiler.Generated.N723B83EBF9F923C095BAC53C6D757C39546F7BEA4A60F67CD2820C84BB0A9AF4.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 9:
			return new Component(FlatSharp.Compiler.Generated.N559C64490EB42C80A2F10A30999A9652C39CE5656F47946E81274887B3E4825E.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 10:
			return new Component(FlatSharp.Compiler.Generated.N3C8250741D846A6C951661E38F59B91E9EBA3C1639B3F6ABAF9B0E174B0BE78D.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<Component>(b);
			return default;
		}
	}

	internal static Component Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new Component(FlatSharp.Compiler.Generated.N89C289FBD8995A154A152A7DEE8D4E991E03F6DE0BC52462C0B160C99156A1AB.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 2:
			return new Component(FlatSharp.Compiler.Generated.N8E2EE111B17D167C3AA9409339E6F552A05447E1856A692CA97E493CBD8373D3.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 3:
			return new Component(FlatSharp.Compiler.Generated.N0E8BE41C014BEDA7170D52DF6BFF9D47C366F712224B9EE97715CF1BB3FF6DEF.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 4:
			return new Component(FlatSharp.Compiler.Generated.N442B6423A519349ECAAD43B6A755ECF9FC6F5820A0427C3DC888DF71DB2BDF68.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 5:
			return new Component(FlatSharp.Compiler.Generated.N11BDFB110B0C663C92CA2111B8AEDA2B3D491ED4C86D2C48EBD45BA9F3487431.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 6:
			return new Component(FlatSharp.Compiler.Generated.NE37AD1DA144DBCF43F76A308F2BAD88A305C92BE9484E5D9223A7184009954C3.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 7:
			return new Component(FlatSharp.Compiler.Generated.N1CE29980970708520611434CAE77FA847B3634B8909E0FA0EBA980ED85EFB7AA.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 8:
			return new Component(FlatSharp.Compiler.Generated.N723B83EBF9F923C095BAC53C6D757C39546F7BEA4A60F67CD2820C84BB0A9AF4.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 9:
			return new Component(FlatSharp.Compiler.Generated.N559C64490EB42C80A2F10A30999A9652C39CE5656F47946E81274887B3E4825E.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 10:
			return new Component(FlatSharp.Compiler.Generated.N3C8250741D846A6C951661E38F59B91E9EBA3C1639B3F6ABAF9B0E174B0BE78D.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<Component>(b);
			return default;
		}
	}

	internal static Component Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new Component(FlatSharp.Compiler.Generated.N89C289FBD8995A154A152A7DEE8D4E991E03F6DE0BC52462C0B160C99156A1AB.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 2:
			return new Component(FlatSharp.Compiler.Generated.N8E2EE111B17D167C3AA9409339E6F552A05447E1856A692CA97E493CBD8373D3.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 3:
			return new Component(FlatSharp.Compiler.Generated.N0E8BE41C014BEDA7170D52DF6BFF9D47C366F712224B9EE97715CF1BB3FF6DEF.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 4:
			return new Component(FlatSharp.Compiler.Generated.N442B6423A519349ECAAD43B6A755ECF9FC6F5820A0427C3DC888DF71DB2BDF68.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 5:
			return new Component(FlatSharp.Compiler.Generated.N11BDFB110B0C663C92CA2111B8AEDA2B3D491ED4C86D2C48EBD45BA9F3487431.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 6:
			return new Component(FlatSharp.Compiler.Generated.NE37AD1DA144DBCF43F76A308F2BAD88A305C92BE9484E5D9223A7184009954C3.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 7:
			return new Component(FlatSharp.Compiler.Generated.N1CE29980970708520611434CAE77FA847B3634B8909E0FA0EBA980ED85EFB7AA.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 8:
			return new Component(FlatSharp.Compiler.Generated.N723B83EBF9F923C095BAC53C6D757C39546F7BEA4A60F67CD2820C84BB0A9AF4.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 9:
			return new Component(FlatSharp.Compiler.Generated.N559C64490EB42C80A2F10A30999A9652C39CE5656F47946E81274887B3E4825E.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 10:
			return new Component(FlatSharp.Compiler.Generated.N3C8250741D846A6C951661E38F59B91E9EBA3C1639B3F6ABAF9B0E174B0BE78D.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<Component>(b);
			return default;
		}
	}

	internal static Component Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new Component(FlatSharp.Compiler.Generated.N89C289FBD8995A154A152A7DEE8D4E991E03F6DE0BC52462C0B160C99156A1AB.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 2:
			return new Component(FlatSharp.Compiler.Generated.N8E2EE111B17D167C3AA9409339E6F552A05447E1856A692CA97E493CBD8373D3.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 3:
			return new Component(FlatSharp.Compiler.Generated.N0E8BE41C014BEDA7170D52DF6BFF9D47C366F712224B9EE97715CF1BB3FF6DEF.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 4:
			return new Component(FlatSharp.Compiler.Generated.N442B6423A519349ECAAD43B6A755ECF9FC6F5820A0427C3DC888DF71DB2BDF68.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 5:
			return new Component(FlatSharp.Compiler.Generated.N11BDFB110B0C663C92CA2111B8AEDA2B3D491ED4C86D2C48EBD45BA9F3487431.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 6:
			return new Component(FlatSharp.Compiler.Generated.NE37AD1DA144DBCF43F76A308F2BAD88A305C92BE9484E5D9223A7184009954C3.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 7:
			return new Component(FlatSharp.Compiler.Generated.N1CE29980970708520611434CAE77FA847B3634B8909E0FA0EBA980ED85EFB7AA.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 8:
			return new Component(FlatSharp.Compiler.Generated.N723B83EBF9F923C095BAC53C6D757C39546F7BEA4A60F67CD2820C84BB0A9AF4.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 9:
			return new Component(FlatSharp.Compiler.Generated.N559C64490EB42C80A2F10A30999A9652C39CE5656F47946E81274887B3E4825E.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 10:
			return new Component(FlatSharp.Compiler.Generated.N3C8250741D846A6C951661E38F59B91E9EBA3C1639B3F6ABAF9B0E174B0BE78D.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<Component>(b);
			return default;
		}
	}
}
