using System;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N0230832F4125DAE6E19C2DEDF8E65E3295549D2BC6C8D6DCA58269DD99C50734;
using FlatSharp.Compiler.Generated.N1087C7BBE897D60D5114078C7FF778BA37BC612673B0664E09465992350BF286;
using FlatSharp.Compiler.Generated.N10B9A7CE752DAFBF3AEC3FD70F796B1D45F41F8328A0CADB1BFAC19B7E6BCD08;
using FlatSharp.Compiler.Generated.N1C46CB7C0B7D4C7E9C3BE0EEFC4E6A608780F614410AEA00290E28A86ED2450A;
using FlatSharp.Compiler.Generated.N382B6BC9015371139B0300AC122617234FE2FD9D71789064418D8BE78E86FDC3;
using FlatSharp.Compiler.Generated.N3FAC0DE37C40A7BF0E0E1FD7E6147977E3E4D6D448C3C34734CF79F750495E0B;
using FlatSharp.Compiler.Generated.N42F9C72ED78A2086DDE0E40D2EA961063BCBFBD68F4BF038D887A6351FE85AEE;
using FlatSharp.Compiler.Generated.N4504EA84A6C3AD560466002F55CF08D80B0870998C7D8A71BE9E42602810AB4F;
using FlatSharp.Compiler.Generated.N461C25481BE10137F2E8E51623BDE0B9934B11B6AF2D5F09BA9C1C880C83EECF;
using FlatSharp.Compiler.Generated.N537633F8E7ED7717A7FE82F5305571C9020A071A43F573ED229EA26496D61CD7;
using FlatSharp.Compiler.Generated.N59B9B8244DDC70799FDB84F5EC1AFD9FFB363D91A6FA161BDB03B96062F80F91;
using FlatSharp.Compiler.Generated.N94184DCDC20856FBE0CFD5BBDD550892414DA09601F69B4B47AFFC8A56F821C0;
using FlatSharp.Compiler.Generated.N9F6F0D8004E79D5C4CD4CA62F219512F8FF33C45C6C97F63E0DFEA8A57D00EDC;
using FlatSharp.Compiler.Generated.NA2C9FCAFE1C080311BDA16CCA3940BC4157C7F9C96557BE8E0770E3C0CB18562;
using FlatSharp.Compiler.Generated.NB499B3F57D752590B2A9034FB81E41DF2056924F65285E1A97138023B952867D;
using FlatSharp.Compiler.Generated.NC1486A5C833B5B0752323EEFFF2431AB58C1E8C7E024E836086365352DE9FE44;
using FlatSharp.Compiler.Generated.NF887C5836C47DB7F02BE4F66B963E4A233A863D39741BB34C28D444FD080F679;
using FlatSharp.Compiler.Generated.NFB1608956CFCF07F0A8B210A3D4F5BD977D5DBE9D8A985B453F8C55AE7A0BAF0;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N24093915935F05E78C89CDA6E52CB640E1487D4E5C0277B6B0B64502779D9C32;

internal static class Helpers
{
	internal static int GetMaxSize(SceneCommand value)
	{
		byte discriminator = value.Discriminator;
		switch (discriminator)
		{
		case 1:
			return 7 + FlatSharp.Compiler.Generated.N9F6F0D8004E79D5C4CD4CA62F219512F8FF33C45C6C97F63E0DFEA8A57D00EDC.Helpers.GetMaxSize(value.Item1);
		case 2:
			return 7 + FlatSharp.Compiler.Generated.NC1486A5C833B5B0752323EEFFF2431AB58C1E8C7E024E836086365352DE9FE44.Helpers.GetMaxSize(value.Item2);
		case 3:
			return 7 + FlatSharp.Compiler.Generated.NB499B3F57D752590B2A9034FB81E41DF2056924F65285E1A97138023B952867D.Helpers.GetMaxSize(value.Item3);
		case 4:
			return 7 + FlatSharp.Compiler.Generated.N10B9A7CE752DAFBF3AEC3FD70F796B1D45F41F8328A0CADB1BFAC19B7E6BCD08.Helpers.GetMaxSize(value.Item4);
		case 5:
			return 7 + FlatSharp.Compiler.Generated.NA2C9FCAFE1C080311BDA16CCA3940BC4157C7F9C96557BE8E0770E3C0CB18562.Helpers.GetMaxSize(value.Item5);
		case 6:
			return 7 + FlatSharp.Compiler.Generated.N42F9C72ED78A2086DDE0E40D2EA961063BCBFBD68F4BF038D887A6351FE85AEE.Helpers.GetMaxSize(value.Item6);
		case 7:
			return 7 + FlatSharp.Compiler.Generated.N382B6BC9015371139B0300AC122617234FE2FD9D71789064418D8BE78E86FDC3.Helpers.GetMaxSize(value.Item7);
		case 8:
			return 7 + FlatSharp.Compiler.Generated.N461C25481BE10137F2E8E51623BDE0B9934B11B6AF2D5F09BA9C1C880C83EECF.Helpers.GetMaxSize(value.Item8);
		case 9:
			return 7 + FlatSharp.Compiler.Generated.N537633F8E7ED7717A7FE82F5305571C9020A071A43F573ED229EA26496D61CD7.Helpers.GetMaxSize(value.Item9);
		case 10:
			return 7 + FlatSharp.Compiler.Generated.NFB1608956CFCF07F0A8B210A3D4F5BD977D5DBE9D8A985B453F8C55AE7A0BAF0.Helpers.GetMaxSize(value.Item10);
		case 11:
			return 7 + FlatSharp.Compiler.Generated.N0230832F4125DAE6E19C2DEDF8E65E3295549D2BC6C8D6DCA58269DD99C50734.Helpers.GetMaxSize(value.Item11);
		case 12:
			return 7 + FlatSharp.Compiler.Generated.N4504EA84A6C3AD560466002F55CF08D80B0870998C7D8A71BE9E42602810AB4F.Helpers.GetMaxSize(value.Item12);
		case 13:
			return 7 + FlatSharp.Compiler.Generated.N59B9B8244DDC70799FDB84F5EC1AFD9FFB363D91A6FA161BDB03B96062F80F91.Helpers.GetMaxSize(value.Item13);
		case 14:
			return 7 + FlatSharp.Compiler.Generated.N1C46CB7C0B7D4C7E9C3BE0EEFC4E6A608780F614410AEA00290E28A86ED2450A.Helpers.GetMaxSize(value.Item14);
		case 15:
			return 7 + FlatSharp.Compiler.Generated.N94184DCDC20856FBE0CFD5BBDD550892414DA09601F69B4B47AFFC8A56F821C0.Helpers.GetMaxSize(value.Item15);
		case 16:
			return 7 + FlatSharp.Compiler.Generated.NF887C5836C47DB7F02BE4F66B963E4A233A863D39741BB34C28D444FD080F679.Helpers.GetMaxSize(value.Item16);
		case 17:
			return 7 + FlatSharp.Compiler.Generated.N3FAC0DE37C40A7BF0E0E1FD7E6147977E3E4D6D448C3C34734CF79F750495E0B.Helpers.GetMaxSize(value.Item17);
		case 18:
			return 7 + FlatSharp.Compiler.Generated.N1087C7BBE897D60D5114078C7FF778BA37BC612673B0664E09465992350BF286.Helpers.GetMaxSize(value.Item18);
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneCommand>(discriminator);
			return 0;
		}
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SceneCommand value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		byte discriminator = value.Discriminator;
		spanWriter.WriteByte(span, discriminator, offset.offset0);
		switch (discriminator)
		{
		case 1:
		{
			int item18 = offset.offset1;
			FlatSharp.Compiler.Generated.N9F6F0D8004E79D5C4CD4CA62F219512F8FF33C45C6C97F63E0DFEA8A57D00EDC.Helpers.Serialize(spanWriter, span, value.Item1, item18, context);
			break;
		}
		case 2:
		{
			int item17 = offset.offset1;
			FlatSharp.Compiler.Generated.NC1486A5C833B5B0752323EEFFF2431AB58C1E8C7E024E836086365352DE9FE44.Helpers.Serialize(spanWriter, span, value.Item2, item17, context);
			break;
		}
		case 3:
		{
			int item16 = offset.offset1;
			FlatSharp.Compiler.Generated.NB499B3F57D752590B2A9034FB81E41DF2056924F65285E1A97138023B952867D.Helpers.Serialize(spanWriter, span, value.Item3, item16, context);
			break;
		}
		case 4:
		{
			int item15 = offset.offset1;
			FlatSharp.Compiler.Generated.N10B9A7CE752DAFBF3AEC3FD70F796B1D45F41F8328A0CADB1BFAC19B7E6BCD08.Helpers.Serialize(spanWriter, span, value.Item4, item15, context);
			break;
		}
		case 5:
		{
			int item14 = offset.offset1;
			FlatSharp.Compiler.Generated.NA2C9FCAFE1C080311BDA16CCA3940BC4157C7F9C96557BE8E0770E3C0CB18562.Helpers.Serialize(spanWriter, span, value.Item5, item14, context);
			break;
		}
		case 6:
		{
			int item13 = offset.offset1;
			FlatSharp.Compiler.Generated.N42F9C72ED78A2086DDE0E40D2EA961063BCBFBD68F4BF038D887A6351FE85AEE.Helpers.Serialize(spanWriter, span, value.Item6, item13, context);
			break;
		}
		case 7:
		{
			int item12 = offset.offset1;
			FlatSharp.Compiler.Generated.N382B6BC9015371139B0300AC122617234FE2FD9D71789064418D8BE78E86FDC3.Helpers.Serialize(spanWriter, span, value.Item7, item12, context);
			break;
		}
		case 8:
		{
			int item11 = offset.offset1;
			FlatSharp.Compiler.Generated.N461C25481BE10137F2E8E51623BDE0B9934B11B6AF2D5F09BA9C1C880C83EECF.Helpers.Serialize(spanWriter, span, value.Item8, item11, context);
			break;
		}
		case 9:
		{
			int item10 = offset.offset1;
			FlatSharp.Compiler.Generated.N537633F8E7ED7717A7FE82F5305571C9020A071A43F573ED229EA26496D61CD7.Helpers.Serialize(spanWriter, span, value.Item9, item10, context);
			break;
		}
		case 10:
		{
			int item9 = offset.offset1;
			FlatSharp.Compiler.Generated.NFB1608956CFCF07F0A8B210A3D4F5BD977D5DBE9D8A985B453F8C55AE7A0BAF0.Helpers.Serialize(spanWriter, span, value.Item10, item9, context);
			break;
		}
		case 11:
		{
			int item8 = offset.offset1;
			FlatSharp.Compiler.Generated.N0230832F4125DAE6E19C2DEDF8E65E3295549D2BC6C8D6DCA58269DD99C50734.Helpers.Serialize(spanWriter, span, value.Item11, item8, context);
			break;
		}
		case 12:
		{
			int item7 = offset.offset1;
			FlatSharp.Compiler.Generated.N4504EA84A6C3AD560466002F55CF08D80B0870998C7D8A71BE9E42602810AB4F.Helpers.Serialize(spanWriter, span, value.Item12, item7, context);
			break;
		}
		case 13:
		{
			int item6 = offset.offset1;
			FlatSharp.Compiler.Generated.N59B9B8244DDC70799FDB84F5EC1AFD9FFB363D91A6FA161BDB03B96062F80F91.Helpers.Serialize(spanWriter, span, value.Item13, item6, context);
			break;
		}
		case 14:
		{
			int item5 = offset.offset1;
			FlatSharp.Compiler.Generated.N1C46CB7C0B7D4C7E9C3BE0EEFC4E6A608780F614410AEA00290E28A86ED2450A.Helpers.Serialize(spanWriter, span, value.Item14, item5, context);
			break;
		}
		case 15:
		{
			int item4 = offset.offset1;
			FlatSharp.Compiler.Generated.N94184DCDC20856FBE0CFD5BBDD550892414DA09601F69B4B47AFFC8A56F821C0.Helpers.Serialize(spanWriter, span, value.Item15, item4, context);
			break;
		}
		case 16:
		{
			int item3 = offset.offset1;
			FlatSharp.Compiler.Generated.NF887C5836C47DB7F02BE4F66B963E4A233A863D39741BB34C28D444FD080F679.Helpers.Serialize(spanWriter, span, value.Item16, item3, context);
			break;
		}
		case 17:
		{
			int item2 = offset.offset1;
			FlatSharp.Compiler.Generated.N3FAC0DE37C40A7BF0E0E1FD7E6147977E3E4D6D448C3C34734CF79F750495E0B.Helpers.Serialize(spanWriter, span, value.Item17, item2, context);
			break;
		}
		case 18:
		{
			int item = offset.offset1;
			FlatSharp.Compiler.Generated.N1087C7BBE897D60D5114078C7FF778BA37BC612673B0664E09465992350BF286.Helpers.Serialize(spanWriter, span, value.Item18, item, context);
			break;
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneCommand>(discriminator);
			break;
		}
	}

	internal static SceneCommand Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new SceneCommand(FlatSharp.Compiler.Generated.N9F6F0D8004E79D5C4CD4CA62F219512F8FF33C45C6C97F63E0DFEA8A57D00EDC.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 2:
			return new SceneCommand(FlatSharp.Compiler.Generated.NC1486A5C833B5B0752323EEFFF2431AB58C1E8C7E024E836086365352DE9FE44.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 3:
			return new SceneCommand(FlatSharp.Compiler.Generated.NB499B3F57D752590B2A9034FB81E41DF2056924F65285E1A97138023B952867D.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 4:
			return new SceneCommand(FlatSharp.Compiler.Generated.N10B9A7CE752DAFBF3AEC3FD70F796B1D45F41F8328A0CADB1BFAC19B7E6BCD08.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 5:
			return new SceneCommand(FlatSharp.Compiler.Generated.NA2C9FCAFE1C080311BDA16CCA3940BC4157C7F9C96557BE8E0770E3C0CB18562.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 6:
			return new SceneCommand(FlatSharp.Compiler.Generated.N42F9C72ED78A2086DDE0E40D2EA961063BCBFBD68F4BF038D887A6351FE85AEE.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 7:
			return new SceneCommand(FlatSharp.Compiler.Generated.N382B6BC9015371139B0300AC122617234FE2FD9D71789064418D8BE78E86FDC3.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 8:
			return new SceneCommand(FlatSharp.Compiler.Generated.N461C25481BE10137F2E8E51623BDE0B9934B11B6AF2D5F09BA9C1C880C83EECF.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 9:
			return new SceneCommand(FlatSharp.Compiler.Generated.N537633F8E7ED7717A7FE82F5305571C9020A071A43F573ED229EA26496D61CD7.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 10:
			return new SceneCommand(FlatSharp.Compiler.Generated.NFB1608956CFCF07F0A8B210A3D4F5BD977D5DBE9D8A985B453F8C55AE7A0BAF0.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 11:
			return new SceneCommand(FlatSharp.Compiler.Generated.N0230832F4125DAE6E19C2DEDF8E65E3295549D2BC6C8D6DCA58269DD99C50734.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 12:
			return new SceneCommand(FlatSharp.Compiler.Generated.N4504EA84A6C3AD560466002F55CF08D80B0870998C7D8A71BE9E42602810AB4F.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 13:
			return new SceneCommand(FlatSharp.Compiler.Generated.N59B9B8244DDC70799FDB84F5EC1AFD9FFB363D91A6FA161BDB03B96062F80F91.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 14:
			return new SceneCommand(FlatSharp.Compiler.Generated.N1C46CB7C0B7D4C7E9C3BE0EEFC4E6A608780F614410AEA00290E28A86ED2450A.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 15:
			return new SceneCommand(FlatSharp.Compiler.Generated.N94184DCDC20856FBE0CFD5BBDD550892414DA09601F69B4B47AFFC8A56F821C0.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 16:
			return new SceneCommand(FlatSharp.Compiler.Generated.NF887C5836C47DB7F02BE4F66B963E4A233A863D39741BB34C28D444FD080F679.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 17:
			return new SceneCommand(FlatSharp.Compiler.Generated.N3FAC0DE37C40A7BF0E0E1FD7E6147977E3E4D6D448C3C34734CF79F750495E0B.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 18:
			return new SceneCommand(FlatSharp.Compiler.Generated.N1087C7BBE897D60D5114078C7FF778BA37BC612673B0664E09465992350BF286.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneCommand>(b);
			return default;
		}
	}

	internal static SceneCommand Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new SceneCommand(FlatSharp.Compiler.Generated.N9F6F0D8004E79D5C4CD4CA62F219512F8FF33C45C6C97F63E0DFEA8A57D00EDC.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 2:
			return new SceneCommand(FlatSharp.Compiler.Generated.NC1486A5C833B5B0752323EEFFF2431AB58C1E8C7E024E836086365352DE9FE44.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 3:
			return new SceneCommand(FlatSharp.Compiler.Generated.NB499B3F57D752590B2A9034FB81E41DF2056924F65285E1A97138023B952867D.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 4:
			return new SceneCommand(FlatSharp.Compiler.Generated.N10B9A7CE752DAFBF3AEC3FD70F796B1D45F41F8328A0CADB1BFAC19B7E6BCD08.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 5:
			return new SceneCommand(FlatSharp.Compiler.Generated.NA2C9FCAFE1C080311BDA16CCA3940BC4157C7F9C96557BE8E0770E3C0CB18562.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 6:
			return new SceneCommand(FlatSharp.Compiler.Generated.N42F9C72ED78A2086DDE0E40D2EA961063BCBFBD68F4BF038D887A6351FE85AEE.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 7:
			return new SceneCommand(FlatSharp.Compiler.Generated.N382B6BC9015371139B0300AC122617234FE2FD9D71789064418D8BE78E86FDC3.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 8:
			return new SceneCommand(FlatSharp.Compiler.Generated.N461C25481BE10137F2E8E51623BDE0B9934B11B6AF2D5F09BA9C1C880C83EECF.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 9:
			return new SceneCommand(FlatSharp.Compiler.Generated.N537633F8E7ED7717A7FE82F5305571C9020A071A43F573ED229EA26496D61CD7.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 10:
			return new SceneCommand(FlatSharp.Compiler.Generated.NFB1608956CFCF07F0A8B210A3D4F5BD977D5DBE9D8A985B453F8C55AE7A0BAF0.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 11:
			return new SceneCommand(FlatSharp.Compiler.Generated.N0230832F4125DAE6E19C2DEDF8E65E3295549D2BC6C8D6DCA58269DD99C50734.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 12:
			return new SceneCommand(FlatSharp.Compiler.Generated.N4504EA84A6C3AD560466002F55CF08D80B0870998C7D8A71BE9E42602810AB4F.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 13:
			return new SceneCommand(FlatSharp.Compiler.Generated.N59B9B8244DDC70799FDB84F5EC1AFD9FFB363D91A6FA161BDB03B96062F80F91.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 14:
			return new SceneCommand(FlatSharp.Compiler.Generated.N1C46CB7C0B7D4C7E9C3BE0EEFC4E6A608780F614410AEA00290E28A86ED2450A.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 15:
			return new SceneCommand(FlatSharp.Compiler.Generated.N94184DCDC20856FBE0CFD5BBDD550892414DA09601F69B4B47AFFC8A56F821C0.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 16:
			return new SceneCommand(FlatSharp.Compiler.Generated.NF887C5836C47DB7F02BE4F66B963E4A233A863D39741BB34C28D444FD080F679.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 17:
			return new SceneCommand(FlatSharp.Compiler.Generated.N3FAC0DE37C40A7BF0E0E1FD7E6147977E3E4D6D448C3C34734CF79F750495E0B.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 18:
			return new SceneCommand(FlatSharp.Compiler.Generated.N1087C7BBE897D60D5114078C7FF778BA37BC612673B0664E09465992350BF286.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneCommand>(b);
			return default;
		}
	}

	internal static SceneCommand Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new SceneCommand(FlatSharp.Compiler.Generated.N9F6F0D8004E79D5C4CD4CA62F219512F8FF33C45C6C97F63E0DFEA8A57D00EDC.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 2:
			return new SceneCommand(FlatSharp.Compiler.Generated.NC1486A5C833B5B0752323EEFFF2431AB58C1E8C7E024E836086365352DE9FE44.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 3:
			return new SceneCommand(FlatSharp.Compiler.Generated.NB499B3F57D752590B2A9034FB81E41DF2056924F65285E1A97138023B952867D.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 4:
			return new SceneCommand(FlatSharp.Compiler.Generated.N10B9A7CE752DAFBF3AEC3FD70F796B1D45F41F8328A0CADB1BFAC19B7E6BCD08.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 5:
			return new SceneCommand(FlatSharp.Compiler.Generated.NA2C9FCAFE1C080311BDA16CCA3940BC4157C7F9C96557BE8E0770E3C0CB18562.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 6:
			return new SceneCommand(FlatSharp.Compiler.Generated.N42F9C72ED78A2086DDE0E40D2EA961063BCBFBD68F4BF038D887A6351FE85AEE.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 7:
			return new SceneCommand(FlatSharp.Compiler.Generated.N382B6BC9015371139B0300AC122617234FE2FD9D71789064418D8BE78E86FDC3.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 8:
			return new SceneCommand(FlatSharp.Compiler.Generated.N461C25481BE10137F2E8E51623BDE0B9934B11B6AF2D5F09BA9C1C880C83EECF.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 9:
			return new SceneCommand(FlatSharp.Compiler.Generated.N537633F8E7ED7717A7FE82F5305571C9020A071A43F573ED229EA26496D61CD7.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 10:
			return new SceneCommand(FlatSharp.Compiler.Generated.NFB1608956CFCF07F0A8B210A3D4F5BD977D5DBE9D8A985B453F8C55AE7A0BAF0.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 11:
			return new SceneCommand(FlatSharp.Compiler.Generated.N0230832F4125DAE6E19C2DEDF8E65E3295549D2BC6C8D6DCA58269DD99C50734.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 12:
			return new SceneCommand(FlatSharp.Compiler.Generated.N4504EA84A6C3AD560466002F55CF08D80B0870998C7D8A71BE9E42602810AB4F.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 13:
			return new SceneCommand(FlatSharp.Compiler.Generated.N59B9B8244DDC70799FDB84F5EC1AFD9FFB363D91A6FA161BDB03B96062F80F91.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 14:
			return new SceneCommand(FlatSharp.Compiler.Generated.N1C46CB7C0B7D4C7E9C3BE0EEFC4E6A608780F614410AEA00290E28A86ED2450A.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 15:
			return new SceneCommand(FlatSharp.Compiler.Generated.N94184DCDC20856FBE0CFD5BBDD550892414DA09601F69B4B47AFFC8A56F821C0.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 16:
			return new SceneCommand(FlatSharp.Compiler.Generated.NF887C5836C47DB7F02BE4F66B963E4A233A863D39741BB34C28D444FD080F679.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 17:
			return new SceneCommand(FlatSharp.Compiler.Generated.N3FAC0DE37C40A7BF0E0E1FD7E6147977E3E4D6D448C3C34734CF79F750495E0B.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 18:
			return new SceneCommand(FlatSharp.Compiler.Generated.N1087C7BBE897D60D5114078C7FF778BA37BC612673B0664E09465992350BF286.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneCommand>(b);
			return default;
		}
	}

	internal static SceneCommand Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new SceneCommand(FlatSharp.Compiler.Generated.N9F6F0D8004E79D5C4CD4CA62F219512F8FF33C45C6C97F63E0DFEA8A57D00EDC.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 2:
			return new SceneCommand(FlatSharp.Compiler.Generated.NC1486A5C833B5B0752323EEFFF2431AB58C1E8C7E024E836086365352DE9FE44.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 3:
			return new SceneCommand(FlatSharp.Compiler.Generated.NB499B3F57D752590B2A9034FB81E41DF2056924F65285E1A97138023B952867D.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 4:
			return new SceneCommand(FlatSharp.Compiler.Generated.N10B9A7CE752DAFBF3AEC3FD70F796B1D45F41F8328A0CADB1BFAC19B7E6BCD08.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 5:
			return new SceneCommand(FlatSharp.Compiler.Generated.NA2C9FCAFE1C080311BDA16CCA3940BC4157C7F9C96557BE8E0770E3C0CB18562.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 6:
			return new SceneCommand(FlatSharp.Compiler.Generated.N42F9C72ED78A2086DDE0E40D2EA961063BCBFBD68F4BF038D887A6351FE85AEE.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 7:
			return new SceneCommand(FlatSharp.Compiler.Generated.N382B6BC9015371139B0300AC122617234FE2FD9D71789064418D8BE78E86FDC3.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 8:
			return new SceneCommand(FlatSharp.Compiler.Generated.N461C25481BE10137F2E8E51623BDE0B9934B11B6AF2D5F09BA9C1C880C83EECF.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 9:
			return new SceneCommand(FlatSharp.Compiler.Generated.N537633F8E7ED7717A7FE82F5305571C9020A071A43F573ED229EA26496D61CD7.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 10:
			return new SceneCommand(FlatSharp.Compiler.Generated.NFB1608956CFCF07F0A8B210A3D4F5BD977D5DBE9D8A985B453F8C55AE7A0BAF0.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 11:
			return new SceneCommand(FlatSharp.Compiler.Generated.N0230832F4125DAE6E19C2DEDF8E65E3295549D2BC6C8D6DCA58269DD99C50734.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 12:
			return new SceneCommand(FlatSharp.Compiler.Generated.N4504EA84A6C3AD560466002F55CF08D80B0870998C7D8A71BE9E42602810AB4F.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 13:
			return new SceneCommand(FlatSharp.Compiler.Generated.N59B9B8244DDC70799FDB84F5EC1AFD9FFB363D91A6FA161BDB03B96062F80F91.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 14:
			return new SceneCommand(FlatSharp.Compiler.Generated.N1C46CB7C0B7D4C7E9C3BE0EEFC4E6A608780F614410AEA00290E28A86ED2450A.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 15:
			return new SceneCommand(FlatSharp.Compiler.Generated.N94184DCDC20856FBE0CFD5BBDD550892414DA09601F69B4B47AFFC8A56F821C0.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 16:
			return new SceneCommand(FlatSharp.Compiler.Generated.NF887C5836C47DB7F02BE4F66B963E4A233A863D39741BB34C28D444FD080F679.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 17:
			return new SceneCommand(FlatSharp.Compiler.Generated.N3FAC0DE37C40A7BF0E0E1FD7E6147977E3E4D6D448C3C34734CF79F750495E0B.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 18:
			return new SceneCommand(FlatSharp.Compiler.Generated.N1087C7BBE897D60D5114078C7FF778BA37BC612673B0664E09465992350BF286.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneCommand>(b);
			return default;
		}
	}
}
