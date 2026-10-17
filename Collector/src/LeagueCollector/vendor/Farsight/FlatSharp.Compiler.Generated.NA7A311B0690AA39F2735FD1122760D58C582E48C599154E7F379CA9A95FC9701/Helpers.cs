using System;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N0B14296B19AF182C1B2C8F8044D07E7F174FF991333AA347012E787D92AB2046;
using FlatSharp.Compiler.Generated.N23C2CEF26C0097F5F439C74DCB1B18DD01DB9B6CE9A819213364551F87D40BBF;
using FlatSharp.Compiler.Generated.N39092260AD9FFB8D55257AC7D9CF6905DE333F049D1E7303E7268EE4048C0F46;
using FlatSharp.Compiler.Generated.N3FEF93A7D6A1909E8EF4477ED3592B7F87067320B01952A9CC6C4F60B6B9AE22;
using FlatSharp.Compiler.Generated.N59C2F58A4BF25EA13737D104B507C6F626F4C62B90930D9573C2A8D0767984F9;
using FlatSharp.Compiler.Generated.N5F011D720117327CF23779F510E3CFEE2353C717C2CC780AF9D76899B0D0E60E;
using FlatSharp.Compiler.Generated.N6172649086EC14C6089E03C944425DF3B8E9DB51F14F283B17C21EE5988F2658;
using FlatSharp.Compiler.Generated.N7A011B6A8B2F3AD3E3AD0D334BE4CB0763646E05D9F53C4379B0B460BA318942;
using FlatSharp.Compiler.Generated.N99CE9F67480DAA96B92F550FCCCFF6BFCA59B3319800D16CBB985150A108BCC2;
using FlatSharp.Compiler.Generated.NA5223763E8C9713992E0FDC851839AA7C7F15A6F2DF823F7B38C1A0FB0AB4040;
using FlatSharp.Compiler.Generated.NC833D87BCA5B387661E5B1FAD3359D3BFFA0DA2215E557597D6443DD5D120A46;
using FlatSharp.Compiler.Generated.ND0302BF1516C72BECC7F630294FBA2C7C3B8E069F73BF23BFFC5F1DE236D0259;
using FlatSharp.Compiler.Generated.ND1D255C96EB2D5DFB7F8BBD98E8E03B34477EE652138E184E896BA79E92611B0;
using FlatSharp.Compiler.Generated.NDB64B3D55210AE4EB049160D71FC052CE79A97A0BEF60D42CB5A46DD21E12985;
using FlatSharp.Compiler.Generated.NE65112868DC65E7CD29590129C91123F59F8B054CDBC0C40191A7BB7CDBA3CDE;
using FlatSharp.Compiler.Generated.NE943CA05B67B2DAB66293C7C88464A33A3531EABE2DE1A7255EB54F337E4F62E;
using FlatSharp.Compiler.Generated.NECA310474EFE10AB83E0714327849C76F302474567AE823F7286B38542B22F71;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NA7A311B0690AA39F2735FD1122760D58C582E48C599154E7F379CA9A95FC9701;

internal static class Helpers
{
	internal static int GetMaxSize(SceneEvent value)
	{
		byte discriminator = value.Discriminator;
		switch (discriminator)
		{
		case 1:
			return 7 + FlatSharp.Compiler.Generated.ND0302BF1516C72BECC7F630294FBA2C7C3B8E069F73BF23BFFC5F1DE236D0259.Helpers.GetMaxSize(value.Item1);
		case 2:
			return 7 + FlatSharp.Compiler.Generated.NE65112868DC65E7CD29590129C91123F59F8B054CDBC0C40191A7BB7CDBA3CDE.Helpers.GetMaxSize(value.Item2);
		case 3:
			return 7 + FlatSharp.Compiler.Generated.N59C2F58A4BF25EA13737D104B507C6F626F4C62B90930D9573C2A8D0767984F9.Helpers.GetMaxSize(value.Item3);
		case 4:
			return 7 + FlatSharp.Compiler.Generated.N5F011D720117327CF23779F510E3CFEE2353C717C2CC780AF9D76899B0D0E60E.Helpers.GetMaxSize(value.Item4);
		case 5:
			return 7 + FlatSharp.Compiler.Generated.NECA310474EFE10AB83E0714327849C76F302474567AE823F7286B38542B22F71.Helpers.GetMaxSize(value.Item5);
		case 6:
			return 7 + FlatSharp.Compiler.Generated.N0B14296B19AF182C1B2C8F8044D07E7F174FF991333AA347012E787D92AB2046.Helpers.GetMaxSize(value.Item6);
		case 7:
			return 7 + FlatSharp.Compiler.Generated.NC833D87BCA5B387661E5B1FAD3359D3BFFA0DA2215E557597D6443DD5D120A46.Helpers.GetMaxSize(value.Item7);
		case 8:
			return 7 + FlatSharp.Compiler.Generated.NE943CA05B67B2DAB66293C7C88464A33A3531EABE2DE1A7255EB54F337E4F62E.Helpers.GetMaxSize(value.Item8);
		case 9:
			return 7 + FlatSharp.Compiler.Generated.N7A011B6A8B2F3AD3E3AD0D334BE4CB0763646E05D9F53C4379B0B460BA318942.Helpers.GetMaxSize(value.Item9);
		case 10:
			return 7 + FlatSharp.Compiler.Generated.ND1D255C96EB2D5DFB7F8BBD98E8E03B34477EE652138E184E896BA79E92611B0.Helpers.GetMaxSize(value.Item10);
		case 11:
			return 7 + FlatSharp.Compiler.Generated.N39092260AD9FFB8D55257AC7D9CF6905DE333F049D1E7303E7268EE4048C0F46.Helpers.GetMaxSize(value.Item11);
		case 12:
			return 7 + FlatSharp.Compiler.Generated.N6172649086EC14C6089E03C944425DF3B8E9DB51F14F283B17C21EE5988F2658.Helpers.GetMaxSize(value.Item12);
		case 13:
			return 7 + FlatSharp.Compiler.Generated.N3FEF93A7D6A1909E8EF4477ED3592B7F87067320B01952A9CC6C4F60B6B9AE22.Helpers.GetMaxSize(value.Item13);
		case 14:
			return 7 + FlatSharp.Compiler.Generated.N99CE9F67480DAA96B92F550FCCCFF6BFCA59B3319800D16CBB985150A108BCC2.Helpers.GetMaxSize(value.Item14);
		case 15:
			return 7 + FlatSharp.Compiler.Generated.NDB64B3D55210AE4EB049160D71FC052CE79A97A0BEF60D42CB5A46DD21E12985.Helpers.GetMaxSize(value.Item15);
		case 16:
			return 7 + FlatSharp.Compiler.Generated.NA5223763E8C9713992E0FDC851839AA7C7F15A6F2DF823F7B38C1A0FB0AB4040.Helpers.GetMaxSize(value.Item16);
		case 17:
			return 7 + FlatSharp.Compiler.Generated.N23C2CEF26C0097F5F439C74DCB1B18DD01DB9B6CE9A819213364551F87D40BBF.Helpers.GetMaxSize(value.Item17);
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneEvent>(discriminator);
			return 0;
		}
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SceneEvent value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		byte discriminator = value.Discriminator;
		spanWriter.WriteByte(span, discriminator, offset.offset0);
		switch (discriminator)
		{
		case 1:
		{
			int item17 = offset.offset1;
			FlatSharp.Compiler.Generated.ND0302BF1516C72BECC7F630294FBA2C7C3B8E069F73BF23BFFC5F1DE236D0259.Helpers.Serialize(spanWriter, span, value.Item1, item17, context);
			break;
		}
		case 2:
		{
			int item16 = offset.offset1;
			FlatSharp.Compiler.Generated.NE65112868DC65E7CD29590129C91123F59F8B054CDBC0C40191A7BB7CDBA3CDE.Helpers.Serialize(spanWriter, span, value.Item2, item16, context);
			break;
		}
		case 3:
		{
			int item15 = offset.offset1;
			FlatSharp.Compiler.Generated.N59C2F58A4BF25EA13737D104B507C6F626F4C62B90930D9573C2A8D0767984F9.Helpers.Serialize(spanWriter, span, value.Item3, item15, context);
			break;
		}
		case 4:
		{
			int item14 = offset.offset1;
			FlatSharp.Compiler.Generated.N5F011D720117327CF23779F510E3CFEE2353C717C2CC780AF9D76899B0D0E60E.Helpers.Serialize(spanWriter, span, value.Item4, item14, context);
			break;
		}
		case 5:
		{
			int item13 = offset.offset1;
			FlatSharp.Compiler.Generated.NECA310474EFE10AB83E0714327849C76F302474567AE823F7286B38542B22F71.Helpers.Serialize(spanWriter, span, value.Item5, item13, context);
			break;
		}
		case 6:
		{
			int item12 = offset.offset1;
			FlatSharp.Compiler.Generated.N0B14296B19AF182C1B2C8F8044D07E7F174FF991333AA347012E787D92AB2046.Helpers.Serialize(spanWriter, span, value.Item6, item12, context);
			break;
		}
		case 7:
		{
			int item11 = offset.offset1;
			FlatSharp.Compiler.Generated.NC833D87BCA5B387661E5B1FAD3359D3BFFA0DA2215E557597D6443DD5D120A46.Helpers.Serialize(spanWriter, span, value.Item7, item11, context);
			break;
		}
		case 8:
		{
			int item10 = offset.offset1;
			FlatSharp.Compiler.Generated.NE943CA05B67B2DAB66293C7C88464A33A3531EABE2DE1A7255EB54F337E4F62E.Helpers.Serialize(spanWriter, span, value.Item8, item10, context);
			break;
		}
		case 9:
		{
			int item9 = offset.offset1;
			FlatSharp.Compiler.Generated.N7A011B6A8B2F3AD3E3AD0D334BE4CB0763646E05D9F53C4379B0B460BA318942.Helpers.Serialize(spanWriter, span, value.Item9, item9, context);
			break;
		}
		case 10:
		{
			int item8 = offset.offset1;
			FlatSharp.Compiler.Generated.ND1D255C96EB2D5DFB7F8BBD98E8E03B34477EE652138E184E896BA79E92611B0.Helpers.Serialize(spanWriter, span, value.Item10, item8, context);
			break;
		}
		case 11:
		{
			int item7 = offset.offset1;
			FlatSharp.Compiler.Generated.N39092260AD9FFB8D55257AC7D9CF6905DE333F049D1E7303E7268EE4048C0F46.Helpers.Serialize(spanWriter, span, value.Item11, item7, context);
			break;
		}
		case 12:
		{
			int item6 = offset.offset1;
			FlatSharp.Compiler.Generated.N6172649086EC14C6089E03C944425DF3B8E9DB51F14F283B17C21EE5988F2658.Helpers.Serialize(spanWriter, span, value.Item12, item6, context);
			break;
		}
		case 13:
		{
			int item5 = offset.offset1;
			FlatSharp.Compiler.Generated.N3FEF93A7D6A1909E8EF4477ED3592B7F87067320B01952A9CC6C4F60B6B9AE22.Helpers.Serialize(spanWriter, span, value.Item13, item5, context);
			break;
		}
		case 14:
		{
			int item4 = offset.offset1;
			FlatSharp.Compiler.Generated.N99CE9F67480DAA96B92F550FCCCFF6BFCA59B3319800D16CBB985150A108BCC2.Helpers.Serialize(spanWriter, span, value.Item14, item4, context);
			break;
		}
		case 15:
		{
			int item3 = offset.offset1;
			FlatSharp.Compiler.Generated.NDB64B3D55210AE4EB049160D71FC052CE79A97A0BEF60D42CB5A46DD21E12985.Helpers.Serialize(spanWriter, span, value.Item15, item3, context);
			break;
		}
		case 16:
		{
			int item2 = offset.offset1;
			FlatSharp.Compiler.Generated.NA5223763E8C9713992E0FDC851839AA7C7F15A6F2DF823F7B38C1A0FB0AB4040.Helpers.Serialize(spanWriter, span, value.Item16, item2, context);
			break;
		}
		case 17:
		{
			int item = offset.offset1;
			FlatSharp.Compiler.Generated.N23C2CEF26C0097F5F439C74DCB1B18DD01DB9B6CE9A819213364551F87D40BBF.Helpers.Serialize(spanWriter, span, value.Item17, item, context);
			break;
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneEvent>(discriminator);
			break;
		}
	}

	internal static SceneEvent Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new SceneEvent(FlatSharp.Compiler.Generated.ND0302BF1516C72BECC7F630294FBA2C7C3B8E069F73BF23BFFC5F1DE236D0259.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 2:
			return new SceneEvent(FlatSharp.Compiler.Generated.NE65112868DC65E7CD29590129C91123F59F8B054CDBC0C40191A7BB7CDBA3CDE.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 3:
			return new SceneEvent(FlatSharp.Compiler.Generated.N59C2F58A4BF25EA13737D104B507C6F626F4C62B90930D9573C2A8D0767984F9.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 4:
			return new SceneEvent(FlatSharp.Compiler.Generated.N5F011D720117327CF23779F510E3CFEE2353C717C2CC780AF9D76899B0D0E60E.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 5:
			return new SceneEvent(FlatSharp.Compiler.Generated.NECA310474EFE10AB83E0714327849C76F302474567AE823F7286B38542B22F71.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 6:
			return new SceneEvent(FlatSharp.Compiler.Generated.N0B14296B19AF182C1B2C8F8044D07E7F174FF991333AA347012E787D92AB2046.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 7:
			return new SceneEvent(FlatSharp.Compiler.Generated.NC833D87BCA5B387661E5B1FAD3359D3BFFA0DA2215E557597D6443DD5D120A46.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 8:
			return new SceneEvent(FlatSharp.Compiler.Generated.NE943CA05B67B2DAB66293C7C88464A33A3531EABE2DE1A7255EB54F337E4F62E.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 9:
			return new SceneEvent(FlatSharp.Compiler.Generated.N7A011B6A8B2F3AD3E3AD0D334BE4CB0763646E05D9F53C4379B0B460BA318942.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 10:
			return new SceneEvent(FlatSharp.Compiler.Generated.ND1D255C96EB2D5DFB7F8BBD98E8E03B34477EE652138E184E896BA79E92611B0.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 11:
			return new SceneEvent(FlatSharp.Compiler.Generated.N39092260AD9FFB8D55257AC7D9CF6905DE333F049D1E7303E7268EE4048C0F46.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 12:
			return new SceneEvent(FlatSharp.Compiler.Generated.N6172649086EC14C6089E03C944425DF3B8E9DB51F14F283B17C21EE5988F2658.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 13:
			return new SceneEvent(FlatSharp.Compiler.Generated.N3FEF93A7D6A1909E8EF4477ED3592B7F87067320B01952A9CC6C4F60B6B9AE22.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 14:
			return new SceneEvent(FlatSharp.Compiler.Generated.N99CE9F67480DAA96B92F550FCCCFF6BFCA59B3319800D16CBB985150A108BCC2.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 15:
			return new SceneEvent(FlatSharp.Compiler.Generated.NDB64B3D55210AE4EB049160D71FC052CE79A97A0BEF60D42CB5A46DD21E12985.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 16:
			return new SceneEvent(FlatSharp.Compiler.Generated.NA5223763E8C9713992E0FDC851839AA7C7F15A6F2DF823F7B38C1A0FB0AB4040.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 17:
			return new SceneEvent(FlatSharp.Compiler.Generated.N23C2CEF26C0097F5F439C74DCB1B18DD01DB9B6CE9A819213364551F87D40BBF.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneEvent>(b);
			return default;
		}
	}

	internal static SceneEvent Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new SceneEvent(FlatSharp.Compiler.Generated.ND0302BF1516C72BECC7F630294FBA2C7C3B8E069F73BF23BFFC5F1DE236D0259.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 2:
			return new SceneEvent(FlatSharp.Compiler.Generated.NE65112868DC65E7CD29590129C91123F59F8B054CDBC0C40191A7BB7CDBA3CDE.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 3:
			return new SceneEvent(FlatSharp.Compiler.Generated.N59C2F58A4BF25EA13737D104B507C6F626F4C62B90930D9573C2A8D0767984F9.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 4:
			return new SceneEvent(FlatSharp.Compiler.Generated.N5F011D720117327CF23779F510E3CFEE2353C717C2CC780AF9D76899B0D0E60E.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 5:
			return new SceneEvent(FlatSharp.Compiler.Generated.NECA310474EFE10AB83E0714327849C76F302474567AE823F7286B38542B22F71.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 6:
			return new SceneEvent(FlatSharp.Compiler.Generated.N0B14296B19AF182C1B2C8F8044D07E7F174FF991333AA347012E787D92AB2046.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 7:
			return new SceneEvent(FlatSharp.Compiler.Generated.NC833D87BCA5B387661E5B1FAD3359D3BFFA0DA2215E557597D6443DD5D120A46.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 8:
			return new SceneEvent(FlatSharp.Compiler.Generated.NE943CA05B67B2DAB66293C7C88464A33A3531EABE2DE1A7255EB54F337E4F62E.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 9:
			return new SceneEvent(FlatSharp.Compiler.Generated.N7A011B6A8B2F3AD3E3AD0D334BE4CB0763646E05D9F53C4379B0B460BA318942.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 10:
			return new SceneEvent(FlatSharp.Compiler.Generated.ND1D255C96EB2D5DFB7F8BBD98E8E03B34477EE652138E184E896BA79E92611B0.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 11:
			return new SceneEvent(FlatSharp.Compiler.Generated.N39092260AD9FFB8D55257AC7D9CF6905DE333F049D1E7303E7268EE4048C0F46.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 12:
			return new SceneEvent(FlatSharp.Compiler.Generated.N6172649086EC14C6089E03C944425DF3B8E9DB51F14F283B17C21EE5988F2658.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 13:
			return new SceneEvent(FlatSharp.Compiler.Generated.N3FEF93A7D6A1909E8EF4477ED3592B7F87067320B01952A9CC6C4F60B6B9AE22.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 14:
			return new SceneEvent(FlatSharp.Compiler.Generated.N99CE9F67480DAA96B92F550FCCCFF6BFCA59B3319800D16CBB985150A108BCC2.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 15:
			return new SceneEvent(FlatSharp.Compiler.Generated.NDB64B3D55210AE4EB049160D71FC052CE79A97A0BEF60D42CB5A46DD21E12985.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 16:
			return new SceneEvent(FlatSharp.Compiler.Generated.NA5223763E8C9713992E0FDC851839AA7C7F15A6F2DF823F7B38C1A0FB0AB4040.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 17:
			return new SceneEvent(FlatSharp.Compiler.Generated.N23C2CEF26C0097F5F439C74DCB1B18DD01DB9B6CE9A819213364551F87D40BBF.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneEvent>(b);
			return default;
		}
	}

	internal static SceneEvent Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new SceneEvent(FlatSharp.Compiler.Generated.ND0302BF1516C72BECC7F630294FBA2C7C3B8E069F73BF23BFFC5F1DE236D0259.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 2:
			return new SceneEvent(FlatSharp.Compiler.Generated.NE65112868DC65E7CD29590129C91123F59F8B054CDBC0C40191A7BB7CDBA3CDE.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 3:
			return new SceneEvent(FlatSharp.Compiler.Generated.N59C2F58A4BF25EA13737D104B507C6F626F4C62B90930D9573C2A8D0767984F9.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 4:
			return new SceneEvent(FlatSharp.Compiler.Generated.N5F011D720117327CF23779F510E3CFEE2353C717C2CC780AF9D76899B0D0E60E.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 5:
			return new SceneEvent(FlatSharp.Compiler.Generated.NECA310474EFE10AB83E0714327849C76F302474567AE823F7286B38542B22F71.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 6:
			return new SceneEvent(FlatSharp.Compiler.Generated.N0B14296B19AF182C1B2C8F8044D07E7F174FF991333AA347012E787D92AB2046.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 7:
			return new SceneEvent(FlatSharp.Compiler.Generated.NC833D87BCA5B387661E5B1FAD3359D3BFFA0DA2215E557597D6443DD5D120A46.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 8:
			return new SceneEvent(FlatSharp.Compiler.Generated.NE943CA05B67B2DAB66293C7C88464A33A3531EABE2DE1A7255EB54F337E4F62E.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 9:
			return new SceneEvent(FlatSharp.Compiler.Generated.N7A011B6A8B2F3AD3E3AD0D334BE4CB0763646E05D9F53C4379B0B460BA318942.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 10:
			return new SceneEvent(FlatSharp.Compiler.Generated.ND1D255C96EB2D5DFB7F8BBD98E8E03B34477EE652138E184E896BA79E92611B0.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 11:
			return new SceneEvent(FlatSharp.Compiler.Generated.N39092260AD9FFB8D55257AC7D9CF6905DE333F049D1E7303E7268EE4048C0F46.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 12:
			return new SceneEvent(FlatSharp.Compiler.Generated.N6172649086EC14C6089E03C944425DF3B8E9DB51F14F283B17C21EE5988F2658.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 13:
			return new SceneEvent(FlatSharp.Compiler.Generated.N3FEF93A7D6A1909E8EF4477ED3592B7F87067320B01952A9CC6C4F60B6B9AE22.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 14:
			return new SceneEvent(FlatSharp.Compiler.Generated.N99CE9F67480DAA96B92F550FCCCFF6BFCA59B3319800D16CBB985150A108BCC2.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 15:
			return new SceneEvent(FlatSharp.Compiler.Generated.NDB64B3D55210AE4EB049160D71FC052CE79A97A0BEF60D42CB5A46DD21E12985.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 16:
			return new SceneEvent(FlatSharp.Compiler.Generated.NA5223763E8C9713992E0FDC851839AA7C7F15A6F2DF823F7B38C1A0FB0AB4040.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 17:
			return new SceneEvent(FlatSharp.Compiler.Generated.N23C2CEF26C0097F5F439C74DCB1B18DD01DB9B6CE9A819213364551F87D40BBF.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneEvent>(b);
			return default;
		}
	}

	internal static SceneEvent Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new SceneEvent(FlatSharp.Compiler.Generated.ND0302BF1516C72BECC7F630294FBA2C7C3B8E069F73BF23BFFC5F1DE236D0259.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 2:
			return new SceneEvent(FlatSharp.Compiler.Generated.NE65112868DC65E7CD29590129C91123F59F8B054CDBC0C40191A7BB7CDBA3CDE.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 3:
			return new SceneEvent(FlatSharp.Compiler.Generated.N59C2F58A4BF25EA13737D104B507C6F626F4C62B90930D9573C2A8D0767984F9.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 4:
			return new SceneEvent(FlatSharp.Compiler.Generated.N5F011D720117327CF23779F510E3CFEE2353C717C2CC780AF9D76899B0D0E60E.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 5:
			return new SceneEvent(FlatSharp.Compiler.Generated.NECA310474EFE10AB83E0714327849C76F302474567AE823F7286B38542B22F71.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 6:
			return new SceneEvent(FlatSharp.Compiler.Generated.N0B14296B19AF182C1B2C8F8044D07E7F174FF991333AA347012E787D92AB2046.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 7:
			return new SceneEvent(FlatSharp.Compiler.Generated.NC833D87BCA5B387661E5B1FAD3359D3BFFA0DA2215E557597D6443DD5D120A46.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 8:
			return new SceneEvent(FlatSharp.Compiler.Generated.NE943CA05B67B2DAB66293C7C88464A33A3531EABE2DE1A7255EB54F337E4F62E.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 9:
			return new SceneEvent(FlatSharp.Compiler.Generated.N7A011B6A8B2F3AD3E3AD0D334BE4CB0763646E05D9F53C4379B0B460BA318942.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 10:
			return new SceneEvent(FlatSharp.Compiler.Generated.ND1D255C96EB2D5DFB7F8BBD98E8E03B34477EE652138E184E896BA79E92611B0.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 11:
			return new SceneEvent(FlatSharp.Compiler.Generated.N39092260AD9FFB8D55257AC7D9CF6905DE333F049D1E7303E7268EE4048C0F46.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 12:
			return new SceneEvent(FlatSharp.Compiler.Generated.N6172649086EC14C6089E03C944425DF3B8E9DB51F14F283B17C21EE5988F2658.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 13:
			return new SceneEvent(FlatSharp.Compiler.Generated.N3FEF93A7D6A1909E8EF4477ED3592B7F87067320B01952A9CC6C4F60B6B9AE22.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 14:
			return new SceneEvent(FlatSharp.Compiler.Generated.N99CE9F67480DAA96B92F550FCCCFF6BFCA59B3319800D16CBB985150A108BCC2.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 15:
			return new SceneEvent(FlatSharp.Compiler.Generated.NDB64B3D55210AE4EB049160D71FC052CE79A97A0BEF60D42CB5A46DD21E12985.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 16:
			return new SceneEvent(FlatSharp.Compiler.Generated.NA5223763E8C9713992E0FDC851839AA7C7F15A6F2DF823F7B38C1A0FB0AB4040.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 17:
			return new SceneEvent(FlatSharp.Compiler.Generated.N23C2CEF26C0097F5F439C74DCB1B18DD01DB9B6CE9A819213364551F87D40BBF.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneEvent>(b);
			return default;
		}
	}
}
