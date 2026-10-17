using System;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N003654B2E8EADADCD891498481C30E3CDDB031BC014F1DFE764DBD581F6DADFC;
using FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E;
using FlatSharp.Compiler.Generated.N0FEB2E2363B843DCA0037C1E228284BEEB9F117E2D9DB58FF389295F75D2A0D3;
using FlatSharp.Compiler.Generated.N26F6EB02F24B2EFD941A0E76ED8C70ED78A322EFDAFB03D6FB77A546D6C39A84;
using FlatSharp.Compiler.Generated.N2A4534CA3C83ABFAEFD2A6642DF3AA522045FE899A9726C352CBC8A9D3A2BBCE;
using FlatSharp.Compiler.Generated.N2F748710073015AD90DEF8CFC016DA3C822CE91A50073135BADC523755873BC5;
using FlatSharp.Compiler.Generated.N3302846FBCBCE3B2663B4AE0CD1F20316EAF3C4E33CEBD0C39936E6057B295C1;
using FlatSharp.Compiler.Generated.N39343B822C3682C562E94A71175CEA86535583CC206B2DE4924C48191EC5CBB5;
using FlatSharp.Compiler.Generated.N4F4A94348236B11245D200CC8BB60A503D3A6C9802A39BEC1306DAEE7FE468C8;
using FlatSharp.Compiler.Generated.N52D063E4078DD85F2B556C332BED3587CCE610F5B109817C229949F7CBD27190;
using FlatSharp.Compiler.Generated.N54D6FEE0B9822D6DF289C47BE1783DB0516263318C7635A927C750077CBF554A;
using FlatSharp.Compiler.Generated.N576C1C1B358553BA4B13C0A6F201E0A77CC1F1D515332E3BDDEDDAE870397E72;
using FlatSharp.Compiler.Generated.N5A62E255BAC1F9E6F5CD3C97007C5B3320564F61A8AA92CB4FD519948679AB1B;
using FlatSharp.Compiler.Generated.N61FACEEA95AF19E1C146330D0DCEBFA6C8D3DB25E3F0EFB85A8A4EA8C426D943;
using FlatSharp.Compiler.Generated.N679253576350E11F70F24D185080861DBD8C2DFB1DB06BC64625078138620359;
using FlatSharp.Compiler.Generated.N81A08736A43B2F327DD6B5F457CEA3F720E3D5E99BFCE3637741E3AC5C88CC6C;
using FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E;
using FlatSharp.Compiler.Generated.N86F2C50B3C976B336DD7A77FBE9E2304BA281DE9D89A066FECB4324C5E5728F4;
using FlatSharp.Compiler.Generated.N95C01A9FAFCFC685FCD90E1CCBB647E3470759EE2FB44EA0C59344BB370F51F9;
using FlatSharp.Compiler.Generated.N993E8B2AB124F4242D40F3827448F71C32B2D4A22A0EC4BB39E9926CE3404BAF;
using FlatSharp.Compiler.Generated.N9A0588C7E018AF9D8FA10A14D1EAFA548365E45EC6BCAA40329C863EB423D1A0;
using FlatSharp.Compiler.Generated.N9AD05E4D97D94D2DEC2F387CFC2EFC1E8F480F97D451E1CC213AE580074BB25F;
using FlatSharp.Compiler.Generated.NAC401F771CF4A3EEFDC685D2E845064E01B32DF9315CFD37818F3B2F8A9F64DC;
using FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F;
using FlatSharp.Compiler.Generated.NCBEC89A41797E7AE41F0F3030E2FD9DA6D4187B65C34BC70873DDE10599F1611;
using FlatSharp.Compiler.Generated.NCDBE697B2E25C1CD9BC27A648AF7C957224BB01EAB41EBD30AF604902E1A3C2B;
using FlatSharp.Compiler.Generated.ND2ED2E42252B34D21BB5F5789F1B8937BCD17FFB818A2EE218491ECC5DAB9EDD;
using FlatSharp.Compiler.Generated.ND6D8395394E711F9DA22C8A200A94FFA855F4F19C7D507E2D34285B290B7591C;
using FlatSharp.Compiler.Generated.NE1D0DB9C9F1EDB8240FC15F7F3010F6028F435FEDCFD4B55EBE6B30E3A709353;
using FlatSharp.Compiler.Generated.NE33AC25A95FD575A1A21C6C59FE1BE385DDA890F3BCEFB8A36C1B1F54FBDF787;
using FlatSharp.Compiler.Generated.NE530B66FB68DC3051712B81F48F8086BE8AD02AC4861356F318A7F912955FB91;
using FlatSharp.Compiler.Generated.NE8C978FA0CCF73D17CD777938E9399B008688071A0BD0C715EE51C0334118389;
using FlatSharp.Compiler.Generated.NF0726B59E773E9898F0E74CD287CAAF80C3155124C3A0EB84D87188DEB12799B;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N8BBDD146C9710F113F15C05C3EE6C68AE8207861AA7C27B3B19A42FEAB85D55C;

internal static class Helpers
{
	internal static int GetMaxSize(ResponseKind value)
	{
		byte discriminator = value.Discriminator;
		switch (discriminator)
		{
		case 1:
			return 7 + FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.GetMaxSize(value.Item1);
		case 2:
			return 7 + FlatSharp.Compiler.Generated.N81A08736A43B2F327DD6B5F457CEA3F720E3D5E99BFCE3637741E3AC5C88CC6C.Helpers.GetMaxSize(value.Item2);
		case 3:
			return 7 + FlatSharp.Compiler.Generated.N2A4534CA3C83ABFAEFD2A6642DF3AA522045FE899A9726C352CBC8A9D3A2BBCE.Helpers.GetMaxSize(value.Item3);
		case 4:
			return 7 + FlatSharp.Compiler.Generated.N5A62E255BAC1F9E6F5CD3C97007C5B3320564F61A8AA92CB4FD519948679AB1B.Helpers.GetMaxSize(value.Item4);
		case 5:
			return 7 + FlatSharp.Compiler.Generated.NCBEC89A41797E7AE41F0F3030E2FD9DA6D4187B65C34BC70873DDE10599F1611.Helpers.GetMaxSize(value.Item5);
		case 6:
			return 7 + FlatSharp.Compiler.Generated.N52D063E4078DD85F2B556C332BED3587CCE610F5B109817C229949F7CBD27190.Helpers.GetMaxSize(value.Item6);
		case 7:
			return 7 + FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.GetMaxSize(value.Item7);
		case 8:
			return 7 + FlatSharp.Compiler.Generated.N3302846FBCBCE3B2663B4AE0CD1F20316EAF3C4E33CEBD0C39936E6057B295C1.Helpers.GetMaxSize(value.Item8);
		case 9:
			return 7 + FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.GetMaxSize(value.Item9);
		case 10:
			return 7 + FlatSharp.Compiler.Generated.N95C01A9FAFCFC685FCD90E1CCBB647E3470759EE2FB44EA0C59344BB370F51F9.Helpers.GetMaxSize(value.Item10);
		case 11:
			return 7 + FlatSharp.Compiler.Generated.N39343B822C3682C562E94A71175CEA86535583CC206B2DE4924C48191EC5CBB5.Helpers.GetMaxSize(value.Item11);
		case 12:
			return 7 + FlatSharp.Compiler.Generated.NE530B66FB68DC3051712B81F48F8086BE8AD02AC4861356F318A7F912955FB91.Helpers.GetMaxSize(value.Item12);
		case 13:
			return 7 + FlatSharp.Compiler.Generated.N003654B2E8EADADCD891498481C30E3CDDB031BC014F1DFE764DBD581F6DADFC.Helpers.GetMaxSize(value.Item13);
		case 14:
			return 7 + FlatSharp.Compiler.Generated.N9AD05E4D97D94D2DEC2F387CFC2EFC1E8F480F97D451E1CC213AE580074BB25F.Helpers.GetMaxSize(value.Item14);
		case 15:
			return 7 + FlatSharp.Compiler.Generated.N54D6FEE0B9822D6DF289C47BE1783DB0516263318C7635A927C750077CBF554A.Helpers.GetMaxSize(value.Item15);
		case 16:
			return 7 + FlatSharp.Compiler.Generated.N9A0588C7E018AF9D8FA10A14D1EAFA548365E45EC6BCAA40329C863EB423D1A0.Helpers.GetMaxSize(value.Item16);
		case 17:
			return 7 + FlatSharp.Compiler.Generated.ND6D8395394E711F9DA22C8A200A94FFA855F4F19C7D507E2D34285B290B7591C.Helpers.GetMaxSize(value.Item17);
		case 18:
			return 7 + FlatSharp.Compiler.Generated.N2F748710073015AD90DEF8CFC016DA3C822CE91A50073135BADC523755873BC5.Helpers.GetMaxSize(value.Item18);
		case 19:
			return 7 + FlatSharp.Compiler.Generated.N86F2C50B3C976B336DD7A77FBE9E2304BA281DE9D89A066FECB4324C5E5728F4.Helpers.GetMaxSize(value.Item19);
		case 20:
			return 7 + FlatSharp.Compiler.Generated.NE33AC25A95FD575A1A21C6C59FE1BE385DDA890F3BCEFB8A36C1B1F54FBDF787.Helpers.GetMaxSize(value.Item20);
		case 21:
			return 7 + FlatSharp.Compiler.Generated.N576C1C1B358553BA4B13C0A6F201E0A77CC1F1D515332E3BDDEDDAE870397E72.Helpers.GetMaxSize(value.Item21);
		case 22:
			return 7 + FlatSharp.Compiler.Generated.N61FACEEA95AF19E1C146330D0DCEBFA6C8D3DB25E3F0EFB85A8A4EA8C426D943.Helpers.GetMaxSize(value.Item22);
		case 23:
			return 7 + FlatSharp.Compiler.Generated.N4F4A94348236B11245D200CC8BB60A503D3A6C9802A39BEC1306DAEE7FE468C8.Helpers.GetMaxSize(value.Item23);
		case 24:
			return 7 + FlatSharp.Compiler.Generated.NF0726B59E773E9898F0E74CD287CAAF80C3155124C3A0EB84D87188DEB12799B.Helpers.GetMaxSize(value.Item24);
		case 25:
			return 7 + FlatSharp.Compiler.Generated.ND2ED2E42252B34D21BB5F5789F1B8937BCD17FFB818A2EE218491ECC5DAB9EDD.Helpers.GetMaxSize(value.Item25);
		case 26:
			return 7 + FlatSharp.Compiler.Generated.N26F6EB02F24B2EFD941A0E76ED8C70ED78A322EFDAFB03D6FB77A546D6C39A84.Helpers.GetMaxSize(value.Item26);
		case 27:
			return 7 + FlatSharp.Compiler.Generated.NE1D0DB9C9F1EDB8240FC15F7F3010F6028F435FEDCFD4B55EBE6B30E3A709353.Helpers.GetMaxSize(value.Item27);
		case 28:
			return 7 + FlatSharp.Compiler.Generated.N993E8B2AB124F4242D40F3827448F71C32B2D4A22A0EC4BB39E9926CE3404BAF.Helpers.GetMaxSize(value.Item28);
		case 29:
			return 7 + FlatSharp.Compiler.Generated.NCDBE697B2E25C1CD9BC27A648AF7C957224BB01EAB41EBD30AF604902E1A3C2B.Helpers.GetMaxSize(value.Item29);
		case 30:
			return 7 + FlatSharp.Compiler.Generated.N0FEB2E2363B843DCA0037C1E228284BEEB9F117E2D9DB58FF389295F75D2A0D3.Helpers.GetMaxSize(value.Item30);
		case 31:
			return 7 + FlatSharp.Compiler.Generated.NAC401F771CF4A3EEFDC685D2E845064E01B32DF9315CFD37818F3B2F8A9F64DC.Helpers.GetMaxSize(value.Item31);
		case 32:
			return 7 + FlatSharp.Compiler.Generated.N679253576350E11F70F24D185080861DBD8C2DFB1DB06BC64625078138620359.Helpers.GetMaxSize(value.Item32);
		case 33:
			return 7 + FlatSharp.Compiler.Generated.NE8C978FA0CCF73D17CD777938E9399B008688071A0BD0C715EE51C0334118389.Helpers.GetMaxSize(value.Item33);
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<ResponseKind>(discriminator);
			return 0;
		}
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, ResponseKind value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		byte discriminator = value.Discriminator;
		spanWriter.WriteByte(span, discriminator, offset.offset0);
		switch (discriminator)
		{
		case 1:
		{
			int item33 = offset.offset1;
			FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Serialize(spanWriter, span, value.Item1, item33, context);
			break;
		}
		case 2:
		{
			int item32 = offset.offset1;
			FlatSharp.Compiler.Generated.N81A08736A43B2F327DD6B5F457CEA3F720E3D5E99BFCE3637741E3AC5C88CC6C.Helpers.Serialize(spanWriter, span, value.Item2, item32, context);
			break;
		}
		case 3:
		{
			int item31 = offset.offset1;
			FlatSharp.Compiler.Generated.N2A4534CA3C83ABFAEFD2A6642DF3AA522045FE899A9726C352CBC8A9D3A2BBCE.Helpers.Serialize(spanWriter, span, value.Item3, item31, context);
			break;
		}
		case 4:
		{
			int item30 = offset.offset1;
			FlatSharp.Compiler.Generated.N5A62E255BAC1F9E6F5CD3C97007C5B3320564F61A8AA92CB4FD519948679AB1B.Helpers.Serialize(spanWriter, span, value.Item4, item30, context);
			break;
		}
		case 5:
		{
			int item29 = offset.offset1;
			FlatSharp.Compiler.Generated.NCBEC89A41797E7AE41F0F3030E2FD9DA6D4187B65C34BC70873DDE10599F1611.Helpers.Serialize(spanWriter, span, value.Item5, item29, context);
			break;
		}
		case 6:
		{
			int item28 = offset.offset1;
			FlatSharp.Compiler.Generated.N52D063E4078DD85F2B556C332BED3587CCE610F5B109817C229949F7CBD27190.Helpers.Serialize(spanWriter, span, value.Item6, item28, context);
			break;
		}
		case 7:
		{
			int item27 = offset.offset1;
			FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Serialize(spanWriter, span, value.Item7, item27, context);
			break;
		}
		case 8:
		{
			int item26 = offset.offset1;
			FlatSharp.Compiler.Generated.N3302846FBCBCE3B2663B4AE0CD1F20316EAF3C4E33CEBD0C39936E6057B295C1.Helpers.Serialize(spanWriter, span, value.Item8, item26, context);
			break;
		}
		case 9:
		{
			int item25 = offset.offset1;
			FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.Serialize(spanWriter, span, value.Item9, item25, context);
			break;
		}
		case 10:
		{
			int item24 = offset.offset1;
			FlatSharp.Compiler.Generated.N95C01A9FAFCFC685FCD90E1CCBB647E3470759EE2FB44EA0C59344BB370F51F9.Helpers.Serialize(spanWriter, span, value.Item10, item24, context);
			break;
		}
		case 11:
		{
			int item23 = offset.offset1;
			FlatSharp.Compiler.Generated.N39343B822C3682C562E94A71175CEA86535583CC206B2DE4924C48191EC5CBB5.Helpers.Serialize(spanWriter, span, value.Item11, item23, context);
			break;
		}
		case 12:
		{
			int item22 = offset.offset1;
			FlatSharp.Compiler.Generated.NE530B66FB68DC3051712B81F48F8086BE8AD02AC4861356F318A7F912955FB91.Helpers.Serialize(spanWriter, span, value.Item12, item22, context);
			break;
		}
		case 13:
		{
			int item21 = offset.offset1;
			FlatSharp.Compiler.Generated.N003654B2E8EADADCD891498481C30E3CDDB031BC014F1DFE764DBD581F6DADFC.Helpers.Serialize(spanWriter, span, value.Item13, item21, context);
			break;
		}
		case 14:
		{
			int item20 = offset.offset1;
			FlatSharp.Compiler.Generated.N9AD05E4D97D94D2DEC2F387CFC2EFC1E8F480F97D451E1CC213AE580074BB25F.Helpers.Serialize(spanWriter, span, value.Item14, item20, context);
			break;
		}
		case 15:
		{
			int item19 = offset.offset1;
			FlatSharp.Compiler.Generated.N54D6FEE0B9822D6DF289C47BE1783DB0516263318C7635A927C750077CBF554A.Helpers.Serialize(spanWriter, span, value.Item15, item19, context);
			break;
		}
		case 16:
		{
			int item18 = offset.offset1;
			FlatSharp.Compiler.Generated.N9A0588C7E018AF9D8FA10A14D1EAFA548365E45EC6BCAA40329C863EB423D1A0.Helpers.Serialize(spanWriter, span, value.Item16, item18, context);
			break;
		}
		case 17:
		{
			int item17 = offset.offset1;
			FlatSharp.Compiler.Generated.ND6D8395394E711F9DA22C8A200A94FFA855F4F19C7D507E2D34285B290B7591C.Helpers.Serialize(spanWriter, span, value.Item17, item17, context);
			break;
		}
		case 18:
		{
			int item16 = offset.offset1;
			FlatSharp.Compiler.Generated.N2F748710073015AD90DEF8CFC016DA3C822CE91A50073135BADC523755873BC5.Helpers.Serialize(spanWriter, span, value.Item18, item16, context);
			break;
		}
		case 19:
		{
			int item15 = offset.offset1;
			FlatSharp.Compiler.Generated.N86F2C50B3C976B336DD7A77FBE9E2304BA281DE9D89A066FECB4324C5E5728F4.Helpers.Serialize(spanWriter, span, value.Item19, item15, context);
			break;
		}
		case 20:
		{
			int item14 = offset.offset1;
			FlatSharp.Compiler.Generated.NE33AC25A95FD575A1A21C6C59FE1BE385DDA890F3BCEFB8A36C1B1F54FBDF787.Helpers.Serialize(spanWriter, span, value.Item20, item14, context);
			break;
		}
		case 21:
		{
			int item13 = offset.offset1;
			FlatSharp.Compiler.Generated.N576C1C1B358553BA4B13C0A6F201E0A77CC1F1D515332E3BDDEDDAE870397E72.Helpers.Serialize(spanWriter, span, value.Item21, item13, context);
			break;
		}
		case 22:
		{
			int item12 = offset.offset1;
			FlatSharp.Compiler.Generated.N61FACEEA95AF19E1C146330D0DCEBFA6C8D3DB25E3F0EFB85A8A4EA8C426D943.Helpers.Serialize(spanWriter, span, value.Item22, item12, context);
			break;
		}
		case 23:
		{
			int item11 = offset.offset1;
			FlatSharp.Compiler.Generated.N4F4A94348236B11245D200CC8BB60A503D3A6C9802A39BEC1306DAEE7FE468C8.Helpers.Serialize(spanWriter, span, value.Item23, item11, context);
			break;
		}
		case 24:
		{
			int item10 = offset.offset1;
			FlatSharp.Compiler.Generated.NF0726B59E773E9898F0E74CD287CAAF80C3155124C3A0EB84D87188DEB12799B.Helpers.Serialize(spanWriter, span, value.Item24, item10, context);
			break;
		}
		case 25:
		{
			int item9 = offset.offset1;
			FlatSharp.Compiler.Generated.ND2ED2E42252B34D21BB5F5789F1B8937BCD17FFB818A2EE218491ECC5DAB9EDD.Helpers.Serialize(spanWriter, span, value.Item25, item9, context);
			break;
		}
		case 26:
		{
			int item8 = offset.offset1;
			FlatSharp.Compiler.Generated.N26F6EB02F24B2EFD941A0E76ED8C70ED78A322EFDAFB03D6FB77A546D6C39A84.Helpers.Serialize(spanWriter, span, value.Item26, item8, context);
			break;
		}
		case 27:
		{
			int item7 = offset.offset1;
			FlatSharp.Compiler.Generated.NE1D0DB9C9F1EDB8240FC15F7F3010F6028F435FEDCFD4B55EBE6B30E3A709353.Helpers.Serialize(spanWriter, span, value.Item27, item7, context);
			break;
		}
		case 28:
		{
			int item6 = offset.offset1;
			FlatSharp.Compiler.Generated.N993E8B2AB124F4242D40F3827448F71C32B2D4A22A0EC4BB39E9926CE3404BAF.Helpers.Serialize(spanWriter, span, value.Item28, item6, context);
			break;
		}
		case 29:
		{
			int item5 = offset.offset1;
			FlatSharp.Compiler.Generated.NCDBE697B2E25C1CD9BC27A648AF7C957224BB01EAB41EBD30AF604902E1A3C2B.Helpers.Serialize(spanWriter, span, value.Item29, item5, context);
			break;
		}
		case 30:
		{
			int item4 = offset.offset1;
			FlatSharp.Compiler.Generated.N0FEB2E2363B843DCA0037C1E228284BEEB9F117E2D9DB58FF389295F75D2A0D3.Helpers.Serialize(spanWriter, span, value.Item30, item4, context);
			break;
		}
		case 31:
		{
			int item3 = offset.offset1;
			FlatSharp.Compiler.Generated.NAC401F771CF4A3EEFDC685D2E845064E01B32DF9315CFD37818F3B2F8A9F64DC.Helpers.Serialize(spanWriter, span, value.Item31, item3, context);
			break;
		}
		case 32:
		{
			int item2 = offset.offset1;
			FlatSharp.Compiler.Generated.N679253576350E11F70F24D185080861DBD8C2DFB1DB06BC64625078138620359.Helpers.Serialize(spanWriter, span, value.Item32, item2, context);
			break;
		}
		case 33:
		{
			int item = offset.offset1;
			FlatSharp.Compiler.Generated.NE8C978FA0CCF73D17CD777938E9399B008688071A0BD0C715EE51C0334118389.Helpers.Serialize(spanWriter, span, value.Item33, item, context);
			break;
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<ResponseKind>(discriminator);
			break;
		}
	}

	internal static ResponseKind Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new ResponseKind(FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 2:
			return new ResponseKind(FlatSharp.Compiler.Generated.N81A08736A43B2F327DD6B5F457CEA3F720E3D5E99BFCE3637741E3AC5C88CC6C.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 3:
			return new ResponseKind(FlatSharp.Compiler.Generated.N2A4534CA3C83ABFAEFD2A6642DF3AA522045FE899A9726C352CBC8A9D3A2BBCE.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 4:
			return new ResponseKind(FlatSharp.Compiler.Generated.N5A62E255BAC1F9E6F5CD3C97007C5B3320564F61A8AA92CB4FD519948679AB1B.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 5:
			return new ResponseKind(FlatSharp.Compiler.Generated.NCBEC89A41797E7AE41F0F3030E2FD9DA6D4187B65C34BC70873DDE10599F1611.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 6:
			return new ResponseKind(FlatSharp.Compiler.Generated.N52D063E4078DD85F2B556C332BED3587CCE610F5B109817C229949F7CBD27190.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 7:
			return new ResponseKind(FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 8:
			return new ResponseKind(FlatSharp.Compiler.Generated.N3302846FBCBCE3B2663B4AE0CD1F20316EAF3C4E33CEBD0C39936E6057B295C1.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 9:
			return new ResponseKind(FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 10:
			return new ResponseKind(FlatSharp.Compiler.Generated.N95C01A9FAFCFC685FCD90E1CCBB647E3470759EE2FB44EA0C59344BB370F51F9.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 11:
			return new ResponseKind(FlatSharp.Compiler.Generated.N39343B822C3682C562E94A71175CEA86535583CC206B2DE4924C48191EC5CBB5.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 12:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE530B66FB68DC3051712B81F48F8086BE8AD02AC4861356F318A7F912955FB91.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 13:
			return new ResponseKind(FlatSharp.Compiler.Generated.N003654B2E8EADADCD891498481C30E3CDDB031BC014F1DFE764DBD581F6DADFC.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 14:
			return new ResponseKind(FlatSharp.Compiler.Generated.N9AD05E4D97D94D2DEC2F387CFC2EFC1E8F480F97D451E1CC213AE580074BB25F.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 15:
			return new ResponseKind(FlatSharp.Compiler.Generated.N54D6FEE0B9822D6DF289C47BE1783DB0516263318C7635A927C750077CBF554A.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 16:
			return new ResponseKind(FlatSharp.Compiler.Generated.N9A0588C7E018AF9D8FA10A14D1EAFA548365E45EC6BCAA40329C863EB423D1A0.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 17:
			return new ResponseKind(FlatSharp.Compiler.Generated.ND6D8395394E711F9DA22C8A200A94FFA855F4F19C7D507E2D34285B290B7591C.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 18:
			return new ResponseKind(FlatSharp.Compiler.Generated.N2F748710073015AD90DEF8CFC016DA3C822CE91A50073135BADC523755873BC5.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 19:
			return new ResponseKind(FlatSharp.Compiler.Generated.N86F2C50B3C976B336DD7A77FBE9E2304BA281DE9D89A066FECB4324C5E5728F4.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 20:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE33AC25A95FD575A1A21C6C59FE1BE385DDA890F3BCEFB8A36C1B1F54FBDF787.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 21:
			return new ResponseKind(FlatSharp.Compiler.Generated.N576C1C1B358553BA4B13C0A6F201E0A77CC1F1D515332E3BDDEDDAE870397E72.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 22:
			return new ResponseKind(FlatSharp.Compiler.Generated.N61FACEEA95AF19E1C146330D0DCEBFA6C8D3DB25E3F0EFB85A8A4EA8C426D943.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 23:
			return new ResponseKind(FlatSharp.Compiler.Generated.N4F4A94348236B11245D200CC8BB60A503D3A6C9802A39BEC1306DAEE7FE468C8.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 24:
			return new ResponseKind(FlatSharp.Compiler.Generated.NF0726B59E773E9898F0E74CD287CAAF80C3155124C3A0EB84D87188DEB12799B.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 25:
			return new ResponseKind(FlatSharp.Compiler.Generated.ND2ED2E42252B34D21BB5F5789F1B8937BCD17FFB818A2EE218491ECC5DAB9EDD.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 26:
			return new ResponseKind(FlatSharp.Compiler.Generated.N26F6EB02F24B2EFD941A0E76ED8C70ED78A322EFDAFB03D6FB77A546D6C39A84.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 27:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE1D0DB9C9F1EDB8240FC15F7F3010F6028F435FEDCFD4B55EBE6B30E3A709353.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 28:
			return new ResponseKind(FlatSharp.Compiler.Generated.N993E8B2AB124F4242D40F3827448F71C32B2D4A22A0EC4BB39E9926CE3404BAF.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 29:
			return new ResponseKind(FlatSharp.Compiler.Generated.NCDBE697B2E25C1CD9BC27A648AF7C957224BB01EAB41EBD30AF604902E1A3C2B.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 30:
			return new ResponseKind(FlatSharp.Compiler.Generated.N0FEB2E2363B843DCA0037C1E228284BEEB9F117E2D9DB58FF389295F75D2A0D3.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 31:
			return new ResponseKind(FlatSharp.Compiler.Generated.NAC401F771CF4A3EEFDC685D2E845064E01B32DF9315CFD37818F3B2F8A9F64DC.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 32:
			return new ResponseKind(FlatSharp.Compiler.Generated.N679253576350E11F70F24D185080861DBD8C2DFB1DB06BC64625078138620359.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 33:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE8C978FA0CCF73D17CD777938E9399B008688071A0BD0C715EE51C0334118389.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<ResponseKind>(b);
			return default;
		}
	}

	internal static ResponseKind Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new ResponseKind(FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 2:
			return new ResponseKind(FlatSharp.Compiler.Generated.N81A08736A43B2F327DD6B5F457CEA3F720E3D5E99BFCE3637741E3AC5C88CC6C.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 3:
			return new ResponseKind(FlatSharp.Compiler.Generated.N2A4534CA3C83ABFAEFD2A6642DF3AA522045FE899A9726C352CBC8A9D3A2BBCE.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 4:
			return new ResponseKind(FlatSharp.Compiler.Generated.N5A62E255BAC1F9E6F5CD3C97007C5B3320564F61A8AA92CB4FD519948679AB1B.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 5:
			return new ResponseKind(FlatSharp.Compiler.Generated.NCBEC89A41797E7AE41F0F3030E2FD9DA6D4187B65C34BC70873DDE10599F1611.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 6:
			return new ResponseKind(FlatSharp.Compiler.Generated.N52D063E4078DD85F2B556C332BED3587CCE610F5B109817C229949F7CBD27190.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 7:
			return new ResponseKind(FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 8:
			return new ResponseKind(FlatSharp.Compiler.Generated.N3302846FBCBCE3B2663B4AE0CD1F20316EAF3C4E33CEBD0C39936E6057B295C1.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 9:
			return new ResponseKind(FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 10:
			return new ResponseKind(FlatSharp.Compiler.Generated.N95C01A9FAFCFC685FCD90E1CCBB647E3470759EE2FB44EA0C59344BB370F51F9.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 11:
			return new ResponseKind(FlatSharp.Compiler.Generated.N39343B822C3682C562E94A71175CEA86535583CC206B2DE4924C48191EC5CBB5.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 12:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE530B66FB68DC3051712B81F48F8086BE8AD02AC4861356F318A7F912955FB91.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 13:
			return new ResponseKind(FlatSharp.Compiler.Generated.N003654B2E8EADADCD891498481C30E3CDDB031BC014F1DFE764DBD581F6DADFC.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 14:
			return new ResponseKind(FlatSharp.Compiler.Generated.N9AD05E4D97D94D2DEC2F387CFC2EFC1E8F480F97D451E1CC213AE580074BB25F.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 15:
			return new ResponseKind(FlatSharp.Compiler.Generated.N54D6FEE0B9822D6DF289C47BE1783DB0516263318C7635A927C750077CBF554A.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 16:
			return new ResponseKind(FlatSharp.Compiler.Generated.N9A0588C7E018AF9D8FA10A14D1EAFA548365E45EC6BCAA40329C863EB423D1A0.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 17:
			return new ResponseKind(FlatSharp.Compiler.Generated.ND6D8395394E711F9DA22C8A200A94FFA855F4F19C7D507E2D34285B290B7591C.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 18:
			return new ResponseKind(FlatSharp.Compiler.Generated.N2F748710073015AD90DEF8CFC016DA3C822CE91A50073135BADC523755873BC5.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 19:
			return new ResponseKind(FlatSharp.Compiler.Generated.N86F2C50B3C976B336DD7A77FBE9E2304BA281DE9D89A066FECB4324C5E5728F4.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 20:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE33AC25A95FD575A1A21C6C59FE1BE385DDA890F3BCEFB8A36C1B1F54FBDF787.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 21:
			return new ResponseKind(FlatSharp.Compiler.Generated.N576C1C1B358553BA4B13C0A6F201E0A77CC1F1D515332E3BDDEDDAE870397E72.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 22:
			return new ResponseKind(FlatSharp.Compiler.Generated.N61FACEEA95AF19E1C146330D0DCEBFA6C8D3DB25E3F0EFB85A8A4EA8C426D943.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 23:
			return new ResponseKind(FlatSharp.Compiler.Generated.N4F4A94348236B11245D200CC8BB60A503D3A6C9802A39BEC1306DAEE7FE468C8.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 24:
			return new ResponseKind(FlatSharp.Compiler.Generated.NF0726B59E773E9898F0E74CD287CAAF80C3155124C3A0EB84D87188DEB12799B.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 25:
			return new ResponseKind(FlatSharp.Compiler.Generated.ND2ED2E42252B34D21BB5F5789F1B8937BCD17FFB818A2EE218491ECC5DAB9EDD.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 26:
			return new ResponseKind(FlatSharp.Compiler.Generated.N26F6EB02F24B2EFD941A0E76ED8C70ED78A322EFDAFB03D6FB77A546D6C39A84.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 27:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE1D0DB9C9F1EDB8240FC15F7F3010F6028F435FEDCFD4B55EBE6B30E3A709353.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 28:
			return new ResponseKind(FlatSharp.Compiler.Generated.N993E8B2AB124F4242D40F3827448F71C32B2D4A22A0EC4BB39E9926CE3404BAF.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 29:
			return new ResponseKind(FlatSharp.Compiler.Generated.NCDBE697B2E25C1CD9BC27A648AF7C957224BB01EAB41EBD30AF604902E1A3C2B.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 30:
			return new ResponseKind(FlatSharp.Compiler.Generated.N0FEB2E2363B843DCA0037C1E228284BEEB9F117E2D9DB58FF389295F75D2A0D3.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 31:
			return new ResponseKind(FlatSharp.Compiler.Generated.NAC401F771CF4A3EEFDC685D2E845064E01B32DF9315CFD37818F3B2F8A9F64DC.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 32:
			return new ResponseKind(FlatSharp.Compiler.Generated.N679253576350E11F70F24D185080861DBD8C2DFB1DB06BC64625078138620359.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 33:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE8C978FA0CCF73D17CD777938E9399B008688071A0BD0C715EE51C0334118389.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<ResponseKind>(b);
			return default;
		}
	}

	internal static ResponseKind Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new ResponseKind(FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 2:
			return new ResponseKind(FlatSharp.Compiler.Generated.N81A08736A43B2F327DD6B5F457CEA3F720E3D5E99BFCE3637741E3AC5C88CC6C.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 3:
			return new ResponseKind(FlatSharp.Compiler.Generated.N2A4534CA3C83ABFAEFD2A6642DF3AA522045FE899A9726C352CBC8A9D3A2BBCE.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 4:
			return new ResponseKind(FlatSharp.Compiler.Generated.N5A62E255BAC1F9E6F5CD3C97007C5B3320564F61A8AA92CB4FD519948679AB1B.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 5:
			return new ResponseKind(FlatSharp.Compiler.Generated.NCBEC89A41797E7AE41F0F3030E2FD9DA6D4187B65C34BC70873DDE10599F1611.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 6:
			return new ResponseKind(FlatSharp.Compiler.Generated.N52D063E4078DD85F2B556C332BED3587CCE610F5B109817C229949F7CBD27190.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 7:
			return new ResponseKind(FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 8:
			return new ResponseKind(FlatSharp.Compiler.Generated.N3302846FBCBCE3B2663B4AE0CD1F20316EAF3C4E33CEBD0C39936E6057B295C1.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 9:
			return new ResponseKind(FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 10:
			return new ResponseKind(FlatSharp.Compiler.Generated.N95C01A9FAFCFC685FCD90E1CCBB647E3470759EE2FB44EA0C59344BB370F51F9.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 11:
			return new ResponseKind(FlatSharp.Compiler.Generated.N39343B822C3682C562E94A71175CEA86535583CC206B2DE4924C48191EC5CBB5.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 12:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE530B66FB68DC3051712B81F48F8086BE8AD02AC4861356F318A7F912955FB91.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 13:
			return new ResponseKind(FlatSharp.Compiler.Generated.N003654B2E8EADADCD891498481C30E3CDDB031BC014F1DFE764DBD581F6DADFC.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 14:
			return new ResponseKind(FlatSharp.Compiler.Generated.N9AD05E4D97D94D2DEC2F387CFC2EFC1E8F480F97D451E1CC213AE580074BB25F.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 15:
			return new ResponseKind(FlatSharp.Compiler.Generated.N54D6FEE0B9822D6DF289C47BE1783DB0516263318C7635A927C750077CBF554A.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 16:
			return new ResponseKind(FlatSharp.Compiler.Generated.N9A0588C7E018AF9D8FA10A14D1EAFA548365E45EC6BCAA40329C863EB423D1A0.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 17:
			return new ResponseKind(FlatSharp.Compiler.Generated.ND6D8395394E711F9DA22C8A200A94FFA855F4F19C7D507E2D34285B290B7591C.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 18:
			return new ResponseKind(FlatSharp.Compiler.Generated.N2F748710073015AD90DEF8CFC016DA3C822CE91A50073135BADC523755873BC5.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 19:
			return new ResponseKind(FlatSharp.Compiler.Generated.N86F2C50B3C976B336DD7A77FBE9E2304BA281DE9D89A066FECB4324C5E5728F4.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 20:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE33AC25A95FD575A1A21C6C59FE1BE385DDA890F3BCEFB8A36C1B1F54FBDF787.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 21:
			return new ResponseKind(FlatSharp.Compiler.Generated.N576C1C1B358553BA4B13C0A6F201E0A77CC1F1D515332E3BDDEDDAE870397E72.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 22:
			return new ResponseKind(FlatSharp.Compiler.Generated.N61FACEEA95AF19E1C146330D0DCEBFA6C8D3DB25E3F0EFB85A8A4EA8C426D943.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 23:
			return new ResponseKind(FlatSharp.Compiler.Generated.N4F4A94348236B11245D200CC8BB60A503D3A6C9802A39BEC1306DAEE7FE468C8.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 24:
			return new ResponseKind(FlatSharp.Compiler.Generated.NF0726B59E773E9898F0E74CD287CAAF80C3155124C3A0EB84D87188DEB12799B.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 25:
			return new ResponseKind(FlatSharp.Compiler.Generated.ND2ED2E42252B34D21BB5F5789F1B8937BCD17FFB818A2EE218491ECC5DAB9EDD.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 26:
			return new ResponseKind(FlatSharp.Compiler.Generated.N26F6EB02F24B2EFD941A0E76ED8C70ED78A322EFDAFB03D6FB77A546D6C39A84.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 27:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE1D0DB9C9F1EDB8240FC15F7F3010F6028F435FEDCFD4B55EBE6B30E3A709353.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 28:
			return new ResponseKind(FlatSharp.Compiler.Generated.N993E8B2AB124F4242D40F3827448F71C32B2D4A22A0EC4BB39E9926CE3404BAF.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 29:
			return new ResponseKind(FlatSharp.Compiler.Generated.NCDBE697B2E25C1CD9BC27A648AF7C957224BB01EAB41EBD30AF604902E1A3C2B.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 30:
			return new ResponseKind(FlatSharp.Compiler.Generated.N0FEB2E2363B843DCA0037C1E228284BEEB9F117E2D9DB58FF389295F75D2A0D3.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 31:
			return new ResponseKind(FlatSharp.Compiler.Generated.NAC401F771CF4A3EEFDC685D2E845064E01B32DF9315CFD37818F3B2F8A9F64DC.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 32:
			return new ResponseKind(FlatSharp.Compiler.Generated.N679253576350E11F70F24D185080861DBD8C2DFB1DB06BC64625078138620359.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 33:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE8C978FA0CCF73D17CD777938E9399B008688071A0BD0C715EE51C0334118389.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<ResponseKind>(b);
			return default;
		}
	}

	internal static ResponseKind Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new ResponseKind(FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 2:
			return new ResponseKind(FlatSharp.Compiler.Generated.N81A08736A43B2F327DD6B5F457CEA3F720E3D5E99BFCE3637741E3AC5C88CC6C.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 3:
			return new ResponseKind(FlatSharp.Compiler.Generated.N2A4534CA3C83ABFAEFD2A6642DF3AA522045FE899A9726C352CBC8A9D3A2BBCE.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 4:
			return new ResponseKind(FlatSharp.Compiler.Generated.N5A62E255BAC1F9E6F5CD3C97007C5B3320564F61A8AA92CB4FD519948679AB1B.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 5:
			return new ResponseKind(FlatSharp.Compiler.Generated.NCBEC89A41797E7AE41F0F3030E2FD9DA6D4187B65C34BC70873DDE10599F1611.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 6:
			return new ResponseKind(FlatSharp.Compiler.Generated.N52D063E4078DD85F2B556C332BED3587CCE610F5B109817C229949F7CBD27190.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 7:
			return new ResponseKind(FlatSharp.Compiler.Generated.N023CDD7C46A20C4DF49619F0352732CA596E04E335F3853D66F3ABD311C3767E.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 8:
			return new ResponseKind(FlatSharp.Compiler.Generated.N3302846FBCBCE3B2663B4AE0CD1F20316EAF3C4E33CEBD0C39936E6057B295C1.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 9:
			return new ResponseKind(FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 10:
			return new ResponseKind(FlatSharp.Compiler.Generated.N95C01A9FAFCFC685FCD90E1CCBB647E3470759EE2FB44EA0C59344BB370F51F9.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 11:
			return new ResponseKind(FlatSharp.Compiler.Generated.N39343B822C3682C562E94A71175CEA86535583CC206B2DE4924C48191EC5CBB5.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 12:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE530B66FB68DC3051712B81F48F8086BE8AD02AC4861356F318A7F912955FB91.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 13:
			return new ResponseKind(FlatSharp.Compiler.Generated.N003654B2E8EADADCD891498481C30E3CDDB031BC014F1DFE764DBD581F6DADFC.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 14:
			return new ResponseKind(FlatSharp.Compiler.Generated.N9AD05E4D97D94D2DEC2F387CFC2EFC1E8F480F97D451E1CC213AE580074BB25F.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 15:
			return new ResponseKind(FlatSharp.Compiler.Generated.N54D6FEE0B9822D6DF289C47BE1783DB0516263318C7635A927C750077CBF554A.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 16:
			return new ResponseKind(FlatSharp.Compiler.Generated.N9A0588C7E018AF9D8FA10A14D1EAFA548365E45EC6BCAA40329C863EB423D1A0.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 17:
			return new ResponseKind(FlatSharp.Compiler.Generated.ND6D8395394E711F9DA22C8A200A94FFA855F4F19C7D507E2D34285B290B7591C.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 18:
			return new ResponseKind(FlatSharp.Compiler.Generated.N2F748710073015AD90DEF8CFC016DA3C822CE91A50073135BADC523755873BC5.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 19:
			return new ResponseKind(FlatSharp.Compiler.Generated.N86F2C50B3C976B336DD7A77FBE9E2304BA281DE9D89A066FECB4324C5E5728F4.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 20:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE33AC25A95FD575A1A21C6C59FE1BE385DDA890F3BCEFB8A36C1B1F54FBDF787.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 21:
			return new ResponseKind(FlatSharp.Compiler.Generated.N576C1C1B358553BA4B13C0A6F201E0A77CC1F1D515332E3BDDEDDAE870397E72.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 22:
			return new ResponseKind(FlatSharp.Compiler.Generated.N61FACEEA95AF19E1C146330D0DCEBFA6C8D3DB25E3F0EFB85A8A4EA8C426D943.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 23:
			return new ResponseKind(FlatSharp.Compiler.Generated.N4F4A94348236B11245D200CC8BB60A503D3A6C9802A39BEC1306DAEE7FE468C8.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 24:
			return new ResponseKind(FlatSharp.Compiler.Generated.NF0726B59E773E9898F0E74CD287CAAF80C3155124C3A0EB84D87188DEB12799B.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 25:
			return new ResponseKind(FlatSharp.Compiler.Generated.ND2ED2E42252B34D21BB5F5789F1B8937BCD17FFB818A2EE218491ECC5DAB9EDD.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 26:
			return new ResponseKind(FlatSharp.Compiler.Generated.N26F6EB02F24B2EFD941A0E76ED8C70ED78A322EFDAFB03D6FB77A546D6C39A84.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 27:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE1D0DB9C9F1EDB8240FC15F7F3010F6028F435FEDCFD4B55EBE6B30E3A709353.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 28:
			return new ResponseKind(FlatSharp.Compiler.Generated.N993E8B2AB124F4242D40F3827448F71C32B2D4A22A0EC4BB39E9926CE3404BAF.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 29:
			return new ResponseKind(FlatSharp.Compiler.Generated.NCDBE697B2E25C1CD9BC27A648AF7C957224BB01EAB41EBD30AF604902E1A3C2B.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 30:
			return new ResponseKind(FlatSharp.Compiler.Generated.N0FEB2E2363B843DCA0037C1E228284BEEB9F117E2D9DB58FF389295F75D2A0D3.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 31:
			return new ResponseKind(FlatSharp.Compiler.Generated.NAC401F771CF4A3EEFDC685D2E845064E01B32DF9315CFD37818F3B2F8A9F64DC.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 32:
			return new ResponseKind(FlatSharp.Compiler.Generated.N679253576350E11F70F24D185080861DBD8C2DFB1DB06BC64625078138620359.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 33:
			return new ResponseKind(FlatSharp.Compiler.Generated.NE8C978FA0CCF73D17CD777938E9399B008688071A0BD0C715EE51C0334118389.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<ResponseKind>(b);
			return default;
		}
	}
}
