using System;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5;
using FlatSharp.Compiler.Generated.N04B2A1B1357643980AAC3189D37CF6540BDE25C78C88F9C0641FEC6C6EE4FBE6;
using FlatSharp.Compiler.Generated.N05612B7F730FEC53FECDBB4339C75F8C1B8FFFA5962C618B39B51CFEA72CB10F;
using FlatSharp.Compiler.Generated.N0588F3A69073E87EB926FDD5201F55DB33F601848099958C6B593ED0B9B7B2E8;
using FlatSharp.Compiler.Generated.N14BD5C8B2926D6F761D43D3BBF8DB7045DD6450AF072F0E49BD41C9003DBB4DD;
using FlatSharp.Compiler.Generated.N16B7695805C45D7C581986875404A73107BADE366E27B8D8CA82A7D603D9E91D;
using FlatSharp.Compiler.Generated.N1A7259827D08365F08E55C52D4D87027AD1A390E599A4C4B55BE823EC5441722;
using FlatSharp.Compiler.Generated.N1C5D572B7DC7CB94A904CBE7340450B1C86A3A90FC4DB1A1E3C9B4FB1BFF925B;
using FlatSharp.Compiler.Generated.N26F5B7244C1C5F6E5BACECE0211C908523B81887BFC89F546FCB2A8DA09D7C44;
using FlatSharp.Compiler.Generated.N2D1B95A937F1ED1F9DF42D7469F44F68E550690A2B0A4EA36E9CDFEE3EEA8141;
using FlatSharp.Compiler.Generated.N2EEB82336954C241BE9ED013CA87E4E103C1DC7F4F48D94ED4D9A7BB8296FB8E;
using FlatSharp.Compiler.Generated.N49DF7D67528E5F140C70F9D65A8E3CB96FF5343F525000B7F4213FA1ABCD263F;
using FlatSharp.Compiler.Generated.N4E2FD9F10DFE642110D2D048AD575A7B15705BF87C62DE1D05926DD7BBD5BE1E;
using FlatSharp.Compiler.Generated.N5396F829791C8E171EE3DA8D092DF262C14AC5C5418653F1D5351CA3C9ACFEC2;
using FlatSharp.Compiler.Generated.N5B5CA176CFEA19EF3CE59972DE3915DD84ABDEB8372471A1C4A445A289C46FD9;
using FlatSharp.Compiler.Generated.N5E1C5B4B68CC1F337CD76FF55AE365E0D39EA2DD6B33DFC731A18C03BD6F5C07;
using FlatSharp.Compiler.Generated.N6354A2ADA00B0F3FA09EB21BCC13DA0A603AB78E792080E7A75F79F1C33820ED;
using FlatSharp.Compiler.Generated.N69A49CFCBB5CFD213E768753BFC4DF9F21929ADF0256D20CB90C5C49B921DF29;
using FlatSharp.Compiler.Generated.N737C4E71164ACA2F804B938A9669AB13CE523CFB92C612BBFFCF77D2CCF07EA6;
using FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E;
using FlatSharp.Compiler.Generated.N85DEC74C14811CF4C7B6B0B4D7AE3CC4C8C1C2952B6DC44BDD4C8DDB0551B31A;
using FlatSharp.Compiler.Generated.N9364A1092EC606FB157179C98A0847A32AFCCC7B40ACB692F911D3697FC7D973;
using FlatSharp.Compiler.Generated.N9AC8EBE7A31E1C456BA677771AB5E24F29076FDD91A054D89D1C1315B66E9997;
using FlatSharp.Compiler.Generated.N9AFBBB23CF06BC8B948FB67E1753681F5CFD8AA3139A6E41ABA97AFB3A613F22;
using FlatSharp.Compiler.Generated.NAA39CC811B56DF1EB778C653FB896A9970E0588C5A05D19A797A2017F1A9F388;
using FlatSharp.Compiler.Generated.NC2FA737BA5A7BD8D4DF7945CA65733BDFA74D062FFC2B97BB9940B75520E7389;
using FlatSharp.Compiler.Generated.NC38BDD8138EB0091B775564B160FBDE8D527B7718A0B3CBAB4EB610A462D4A83;
using FlatSharp.Compiler.Generated.NC8D9F93CF72E31FD7385D8827613382FFA9ABD34FED03863F6CA615EF19351FB;
using FlatSharp.Compiler.Generated.NDCF9F15ADD56DB80A5A2C48EF79993DDD88D0ED9C475C70859631EFC694ADF0D;
using FlatSharp.Compiler.Generated.NDF24175BA83B4EC463BEAF75D8525B05B237208C8DC1B0A52BBB42F918DF67D6;
using FlatSharp.Compiler.Generated.NE886E825C9FB6A796372424284068CFBFC2AF734D5A3D5DF506EFCB20B17BF4B;
using FlatSharp.Compiler.Generated.NE8FE21482E7457B5C798E43933F8DCA470CE0C29DAB4687AD7728F99494CB110;
using FlatSharp.Compiler.Generated.NECB13F3A0DAA1E01364779FE0682C27B2FA94567618DD5B9B845D16CD16AE1A0;
using FlatSharp.Compiler.Generated.NFE7C58792E9D91F2107E1720B9829B1887CA65017B1233EFCF5B59665B5ACC54;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N33A46280AD6A39199F144532F1B2B4B3289530A1286BF624B13CC410E3FAEA0B;

internal static class Helpers
{
	internal static int GetMaxSize(DrawingCommand value)
	{
		byte discriminator = value.Discriminator;
		switch (discriminator)
		{
		case 1:
			return 7 + FlatSharp.Compiler.Generated.N1C5D572B7DC7CB94A904CBE7340450B1C86A3A90FC4DB1A1E3C9B4FB1BFF925B.Helpers.GetMaxSize(value.Item1);
		case 2:
			return 7 + FlatSharp.Compiler.Generated.N5E1C5B4B68CC1F337CD76FF55AE365E0D39EA2DD6B33DFC731A18C03BD6F5C07.Helpers.GetMaxSize(value.Item2);
		case 3:
			return 7 + FlatSharp.Compiler.Generated.N16B7695805C45D7C581986875404A73107BADE366E27B8D8CA82A7D603D9E91D.Helpers.GetMaxSize(value.Item3);
		case 4:
			return 7 + FlatSharp.Compiler.Generated.NE8FE21482E7457B5C798E43933F8DCA470CE0C29DAB4687AD7728F99494CB110.Helpers.GetMaxSize(value.Item4);
		case 5:
			return 7 + FlatSharp.Compiler.Generated.NECB13F3A0DAA1E01364779FE0682C27B2FA94567618DD5B9B845D16CD16AE1A0.Helpers.GetMaxSize(value.Item5);
		case 6:
			return 7 + FlatSharp.Compiler.Generated.N49DF7D67528E5F140C70F9D65A8E3CB96FF5343F525000B7F4213FA1ABCD263F.Helpers.GetMaxSize(value.Item6);
		case 7:
			return 7 + FlatSharp.Compiler.Generated.N4E2FD9F10DFE642110D2D048AD575A7B15705BF87C62DE1D05926DD7BBD5BE1E.Helpers.GetMaxSize(value.Item7);
		case 8:
			return 7 + FlatSharp.Compiler.Generated.NAA39CC811B56DF1EB778C653FB896A9970E0588C5A05D19A797A2017F1A9F388.Helpers.GetMaxSize(value.Item8);
		case 9:
			return 7 + FlatSharp.Compiler.Generated.N9AC8EBE7A31E1C456BA677771AB5E24F29076FDD91A054D89D1C1315B66E9997.Helpers.GetMaxSize(value.Item9);
		case 10:
			return 7 + FlatSharp.Compiler.Generated.N2EEB82336954C241BE9ED013CA87E4E103C1DC7F4F48D94ED4D9A7BB8296FB8E.Helpers.GetMaxSize(value.Item10);
		case 11:
			return 7 + FlatSharp.Compiler.Generated.N69A49CFCBB5CFD213E768753BFC4DF9F21929ADF0256D20CB90C5C49B921DF29.Helpers.GetMaxSize(value.Item11);
		case 12:
			return 7 + FlatSharp.Compiler.Generated.NC38BDD8138EB0091B775564B160FBDE8D527B7718A0B3CBAB4EB610A462D4A83.Helpers.GetMaxSize(value.Item12);
		case 13:
			return 7 + FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.GetMaxSize(value.Item13);
		case 14:
			return 7 + FlatSharp.Compiler.Generated.NFE7C58792E9D91F2107E1720B9829B1887CA65017B1233EFCF5B59665B5ACC54.Helpers.GetMaxSize(value.Item14);
		case 15:
			return 7 + FlatSharp.Compiler.Generated.N1A7259827D08365F08E55C52D4D87027AD1A390E599A4C4B55BE823EC5441722.Helpers.GetMaxSize(value.Item15);
		case 16:
			return 7 + FlatSharp.Compiler.Generated.N5B5CA176CFEA19EF3CE59972DE3915DD84ABDEB8372471A1C4A445A289C46FD9.Helpers.GetMaxSize(value.Item16);
		case 17:
			return 7 + FlatSharp.Compiler.Generated.N737C4E71164ACA2F804B938A9669AB13CE523CFB92C612BBFFCF77D2CCF07EA6.Helpers.GetMaxSize(value.Item17);
		case 18:
			return 7 + FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.GetMaxSize(value.Item18);
		case 19:
			return 7 + FlatSharp.Compiler.Generated.N85DEC74C14811CF4C7B6B0B4D7AE3CC4C8C1C2952B6DC44BDD4C8DDB0551B31A.Helpers.GetMaxSize(value.Item19);
		case 20:
			return 7 + FlatSharp.Compiler.Generated.NDCF9F15ADD56DB80A5A2C48EF79993DDD88D0ED9C475C70859631EFC694ADF0D.Helpers.GetMaxSize(value.Item20);
		case 21:
			return 7 + FlatSharp.Compiler.Generated.N04B2A1B1357643980AAC3189D37CF6540BDE25C78C88F9C0641FEC6C6EE4FBE6.Helpers.GetMaxSize(value.Item21);
		case 22:
			return 7 + FlatSharp.Compiler.Generated.N9AFBBB23CF06BC8B948FB67E1753681F5CFD8AA3139A6E41ABA97AFB3A613F22.Helpers.GetMaxSize(value.Item22);
		case 23:
			return 7 + FlatSharp.Compiler.Generated.N05612B7F730FEC53FECDBB4339C75F8C1B8FFFA5962C618B39B51CFEA72CB10F.Helpers.GetMaxSize(value.Item23);
		case 24:
			return 7 + FlatSharp.Compiler.Generated.N5396F829791C8E171EE3DA8D092DF262C14AC5C5418653F1D5351CA3C9ACFEC2.Helpers.GetMaxSize(value.Item24);
		case 25:
			return 7 + FlatSharp.Compiler.Generated.NE886E825C9FB6A796372424284068CFBFC2AF734D5A3D5DF506EFCB20B17BF4B.Helpers.GetMaxSize(value.Item25);
		case 26:
			return 7 + FlatSharp.Compiler.Generated.NC8D9F93CF72E31FD7385D8827613382FFA9ABD34FED03863F6CA615EF19351FB.Helpers.GetMaxSize(value.Item26);
		case 27:
			return 7 + FlatSharp.Compiler.Generated.N2D1B95A937F1ED1F9DF42D7469F44F68E550690A2B0A4EA36E9CDFEE3EEA8141.Helpers.GetMaxSize(value.Item27);
		case 28:
			return 7 + FlatSharp.Compiler.Generated.N0588F3A69073E87EB926FDD5201F55DB33F601848099958C6B593ED0B9B7B2E8.Helpers.GetMaxSize(value.Item28);
		case 29:
			return 7 + FlatSharp.Compiler.Generated.N26F5B7244C1C5F6E5BACECE0211C908523B81887BFC89F546FCB2A8DA09D7C44.Helpers.GetMaxSize(value.Item29);
		case 30:
			return 7 + FlatSharp.Compiler.Generated.N6354A2ADA00B0F3FA09EB21BCC13DA0A603AB78E792080E7A75F79F1C33820ED.Helpers.GetMaxSize(value.Item30);
		case 31:
			return 7 + FlatSharp.Compiler.Generated.NDF24175BA83B4EC463BEAF75D8525B05B237208C8DC1B0A52BBB42F918DF67D6.Helpers.GetMaxSize(value.Item31);
		case 32:
			return 7 + FlatSharp.Compiler.Generated.NC2FA737BA5A7BD8D4DF7945CA65733BDFA74D062FFC2B97BB9940B75520E7389.Helpers.GetMaxSize(value.Item32);
		case 33:
			return 7 + FlatSharp.Compiler.Generated.N14BD5C8B2926D6F761D43D3BBF8DB7045DD6450AF072F0E49BD41C9003DBB4DD.Helpers.GetMaxSize(value.Item33);
		case 34:
			return 7 + FlatSharp.Compiler.Generated.N9364A1092EC606FB157179C98A0847A32AFCCC7B40ACB692F911D3697FC7D973.Helpers.GetMaxSize(value.Item34);
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<DrawingCommand>(discriminator);
			return 0;
		}
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, DrawingCommand value, ref (int offset0, int offset1) offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		byte discriminator = value.Discriminator;
		spanWriter.WriteByte(span, discriminator, offset.offset0);
		switch (discriminator)
		{
		case 1:
		{
			int item34 = offset.offset1;
			FlatSharp.Compiler.Generated.N1C5D572B7DC7CB94A904CBE7340450B1C86A3A90FC4DB1A1E3C9B4FB1BFF925B.Helpers.Serialize(spanWriter, span, value.Item1, item34, context);
			break;
		}
		case 2:
		{
			int item33 = offset.offset1;
			FlatSharp.Compiler.Generated.N5E1C5B4B68CC1F337CD76FF55AE365E0D39EA2DD6B33DFC731A18C03BD6F5C07.Helpers.Serialize(spanWriter, span, value.Item2, item33, context);
			break;
		}
		case 3:
		{
			int item32 = offset.offset1;
			FlatSharp.Compiler.Generated.N16B7695805C45D7C581986875404A73107BADE366E27B8D8CA82A7D603D9E91D.Helpers.Serialize(spanWriter, span, value.Item3, item32, context);
			break;
		}
		case 4:
		{
			int item31 = offset.offset1;
			FlatSharp.Compiler.Generated.NE8FE21482E7457B5C798E43933F8DCA470CE0C29DAB4687AD7728F99494CB110.Helpers.Serialize(spanWriter, span, value.Item4, item31, context);
			break;
		}
		case 5:
		{
			int item30 = offset.offset1;
			FlatSharp.Compiler.Generated.NECB13F3A0DAA1E01364779FE0682C27B2FA94567618DD5B9B845D16CD16AE1A0.Helpers.Serialize(spanWriter, span, value.Item5, item30, context);
			break;
		}
		case 6:
		{
			int item29 = offset.offset1;
			FlatSharp.Compiler.Generated.N49DF7D67528E5F140C70F9D65A8E3CB96FF5343F525000B7F4213FA1ABCD263F.Helpers.Serialize(spanWriter, span, value.Item6, item29, context);
			break;
		}
		case 7:
		{
			int item28 = offset.offset1;
			FlatSharp.Compiler.Generated.N4E2FD9F10DFE642110D2D048AD575A7B15705BF87C62DE1D05926DD7BBD5BE1E.Helpers.Serialize(spanWriter, span, value.Item7, item28, context);
			break;
		}
		case 8:
		{
			int item27 = offset.offset1;
			FlatSharp.Compiler.Generated.NAA39CC811B56DF1EB778C653FB896A9970E0588C5A05D19A797A2017F1A9F388.Helpers.Serialize(spanWriter, span, value.Item8, item27, context);
			break;
		}
		case 9:
		{
			int item26 = offset.offset1;
			FlatSharp.Compiler.Generated.N9AC8EBE7A31E1C456BA677771AB5E24F29076FDD91A054D89D1C1315B66E9997.Helpers.Serialize(spanWriter, span, value.Item9, item26, context);
			break;
		}
		case 10:
		{
			int item25 = offset.offset1;
			FlatSharp.Compiler.Generated.N2EEB82336954C241BE9ED013CA87E4E103C1DC7F4F48D94ED4D9A7BB8296FB8E.Helpers.Serialize(spanWriter, span, value.Item10, item25, context);
			break;
		}
		case 11:
		{
			int item24 = offset.offset1;
			FlatSharp.Compiler.Generated.N69A49CFCBB5CFD213E768753BFC4DF9F21929ADF0256D20CB90C5C49B921DF29.Helpers.Serialize(spanWriter, span, value.Item11, item24, context);
			break;
		}
		case 12:
		{
			int item23 = offset.offset1;
			FlatSharp.Compiler.Generated.NC38BDD8138EB0091B775564B160FBDE8D527B7718A0B3CBAB4EB610A462D4A83.Helpers.Serialize(spanWriter, span, value.Item12, item23, context);
			break;
		}
		case 13:
		{
			int item22 = offset.offset1;
			FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Serialize(spanWriter, span, value.Item13, item22, context);
			break;
		}
		case 14:
		{
			int item21 = offset.offset1;
			FlatSharp.Compiler.Generated.NFE7C58792E9D91F2107E1720B9829B1887CA65017B1233EFCF5B59665B5ACC54.Helpers.Serialize(spanWriter, span, value.Item14, item21, context);
			break;
		}
		case 15:
		{
			int item20 = offset.offset1;
			FlatSharp.Compiler.Generated.N1A7259827D08365F08E55C52D4D87027AD1A390E599A4C4B55BE823EC5441722.Helpers.Serialize(spanWriter, span, value.Item15, item20, context);
			break;
		}
		case 16:
		{
			int item19 = offset.offset1;
			FlatSharp.Compiler.Generated.N5B5CA176CFEA19EF3CE59972DE3915DD84ABDEB8372471A1C4A445A289C46FD9.Helpers.Serialize(spanWriter, span, value.Item16, item19, context);
			break;
		}
		case 17:
		{
			int item18 = offset.offset1;
			FlatSharp.Compiler.Generated.N737C4E71164ACA2F804B938A9669AB13CE523CFB92C612BBFFCF77D2CCF07EA6.Helpers.Serialize(spanWriter, span, value.Item17, item18, context);
			break;
		}
		case 18:
		{
			int item17 = offset.offset1;
			FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.Serialize(spanWriter, span, value.Item18, item17, context);
			break;
		}
		case 19:
		{
			int item16 = offset.offset1;
			FlatSharp.Compiler.Generated.N85DEC74C14811CF4C7B6B0B4D7AE3CC4C8C1C2952B6DC44BDD4C8DDB0551B31A.Helpers.Serialize(spanWriter, span, value.Item19, item16, context);
			break;
		}
		case 20:
		{
			int item15 = offset.offset1;
			FlatSharp.Compiler.Generated.NDCF9F15ADD56DB80A5A2C48EF79993DDD88D0ED9C475C70859631EFC694ADF0D.Helpers.Serialize(spanWriter, span, value.Item20, item15, context);
			break;
		}
		case 21:
		{
			int item14 = offset.offset1;
			FlatSharp.Compiler.Generated.N04B2A1B1357643980AAC3189D37CF6540BDE25C78C88F9C0641FEC6C6EE4FBE6.Helpers.Serialize(spanWriter, span, value.Item21, item14, context);
			break;
		}
		case 22:
		{
			int item13 = offset.offset1;
			FlatSharp.Compiler.Generated.N9AFBBB23CF06BC8B948FB67E1753681F5CFD8AA3139A6E41ABA97AFB3A613F22.Helpers.Serialize(spanWriter, span, value.Item22, item13, context);
			break;
		}
		case 23:
		{
			int item12 = offset.offset1;
			FlatSharp.Compiler.Generated.N05612B7F730FEC53FECDBB4339C75F8C1B8FFFA5962C618B39B51CFEA72CB10F.Helpers.Serialize(spanWriter, span, value.Item23, item12, context);
			break;
		}
		case 24:
		{
			int item11 = offset.offset1;
			FlatSharp.Compiler.Generated.N5396F829791C8E171EE3DA8D092DF262C14AC5C5418653F1D5351CA3C9ACFEC2.Helpers.Serialize(spanWriter, span, value.Item24, item11, context);
			break;
		}
		case 25:
		{
			int item10 = offset.offset1;
			FlatSharp.Compiler.Generated.NE886E825C9FB6A796372424284068CFBFC2AF734D5A3D5DF506EFCB20B17BF4B.Helpers.Serialize(spanWriter, span, value.Item25, item10, context);
			break;
		}
		case 26:
		{
			int item9 = offset.offset1;
			FlatSharp.Compiler.Generated.NC8D9F93CF72E31FD7385D8827613382FFA9ABD34FED03863F6CA615EF19351FB.Helpers.Serialize(spanWriter, span, value.Item26, item9, context);
			break;
		}
		case 27:
		{
			int item8 = offset.offset1;
			FlatSharp.Compiler.Generated.N2D1B95A937F1ED1F9DF42D7469F44F68E550690A2B0A4EA36E9CDFEE3EEA8141.Helpers.Serialize(spanWriter, span, value.Item27, item8, context);
			break;
		}
		case 28:
		{
			int item7 = offset.offset1;
			FlatSharp.Compiler.Generated.N0588F3A69073E87EB926FDD5201F55DB33F601848099958C6B593ED0B9B7B2E8.Helpers.Serialize(spanWriter, span, value.Item28, item7, context);
			break;
		}
		case 29:
		{
			int item6 = offset.offset1;
			FlatSharp.Compiler.Generated.N26F5B7244C1C5F6E5BACECE0211C908523B81887BFC89F546FCB2A8DA09D7C44.Helpers.Serialize(spanWriter, span, value.Item29, item6, context);
			break;
		}
		case 30:
		{
			int item5 = offset.offset1;
			FlatSharp.Compiler.Generated.N6354A2ADA00B0F3FA09EB21BCC13DA0A603AB78E792080E7A75F79F1C33820ED.Helpers.Serialize(spanWriter, span, value.Item30, item5, context);
			break;
		}
		case 31:
		{
			int item4 = offset.offset1;
			FlatSharp.Compiler.Generated.NDF24175BA83B4EC463BEAF75D8525B05B237208C8DC1B0A52BBB42F918DF67D6.Helpers.Serialize(spanWriter, span, value.Item31, item4, context);
			break;
		}
		case 32:
		{
			int item3 = offset.offset1;
			FlatSharp.Compiler.Generated.NC2FA737BA5A7BD8D4DF7945CA65733BDFA74D062FFC2B97BB9940B75520E7389.Helpers.Serialize(spanWriter, span, value.Item32, item3, context);
			break;
		}
		case 33:
		{
			int item2 = offset.offset1;
			FlatSharp.Compiler.Generated.N14BD5C8B2926D6F761D43D3BBF8DB7045DD6450AF072F0E49BD41C9003DBB4DD.Helpers.Serialize(spanWriter, span, value.Item33, item2, context);
			break;
		}
		case 34:
		{
			int item = offset.offset1;
			FlatSharp.Compiler.Generated.N9364A1092EC606FB157179C98A0847A32AFCCC7B40ACB692F911D3697FC7D973.Helpers.Serialize(spanWriter, span, value.Item34, item, context);
			break;
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<DrawingCommand>(discriminator);
			break;
		}
	}

	internal static DrawingCommand Parse_Lazy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N1C5D572B7DC7CB94A904CBE7340450B1C86A3A90FC4DB1A1E3C9B4FB1BFF925B.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 2:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5E1C5B4B68CC1F337CD76FF55AE365E0D39EA2DD6B33DFC731A18C03BD6F5C07.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 3:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N16B7695805C45D7C581986875404A73107BADE366E27B8D8CA82A7D603D9E91D.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 4:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NE8FE21482E7457B5C798E43933F8DCA470CE0C29DAB4687AD7728F99494CB110.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 5:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NECB13F3A0DAA1E01364779FE0682C27B2FA94567618DD5B9B845D16CD16AE1A0.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 6:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N49DF7D67528E5F140C70F9D65A8E3CB96FF5343F525000B7F4213FA1ABCD263F.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 7:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N4E2FD9F10DFE642110D2D048AD575A7B15705BF87C62DE1D05926DD7BBD5BE1E.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 8:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NAA39CC811B56DF1EB778C653FB896A9970E0588C5A05D19A797A2017F1A9F388.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 9:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9AC8EBE7A31E1C456BA677771AB5E24F29076FDD91A054D89D1C1315B66E9997.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 10:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N2EEB82336954C241BE9ED013CA87E4E103C1DC7F4F48D94ED4D9A7BB8296FB8E.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 11:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N69A49CFCBB5CFD213E768753BFC4DF9F21929ADF0256D20CB90C5C49B921DF29.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 12:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC38BDD8138EB0091B775564B160FBDE8D527B7718A0B3CBAB4EB610A462D4A83.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 13:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 14:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NFE7C58792E9D91F2107E1720B9829B1887CA65017B1233EFCF5B59665B5ACC54.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 15:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N1A7259827D08365F08E55C52D4D87027AD1A390E599A4C4B55BE823EC5441722.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 16:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5B5CA176CFEA19EF3CE59972DE3915DD84ABDEB8372471A1C4A445A289C46FD9.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 17:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N737C4E71164ACA2F804B938A9669AB13CE523CFB92C612BBFFCF77D2CCF07EA6.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 18:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 19:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N85DEC74C14811CF4C7B6B0B4D7AE3CC4C8C1C2952B6DC44BDD4C8DDB0551B31A.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 20:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NDCF9F15ADD56DB80A5A2C48EF79993DDD88D0ED9C475C70859631EFC694ADF0D.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 21:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N04B2A1B1357643980AAC3189D37CF6540BDE25C78C88F9C0641FEC6C6EE4FBE6.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 22:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9AFBBB23CF06BC8B948FB67E1753681F5CFD8AA3139A6E41ABA97AFB3A613F22.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 23:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N05612B7F730FEC53FECDBB4339C75F8C1B8FFFA5962C618B39B51CFEA72CB10F.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 24:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5396F829791C8E171EE3DA8D092DF262C14AC5C5418653F1D5351CA3C9ACFEC2.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 25:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NE886E825C9FB6A796372424284068CFBFC2AF734D5A3D5DF506EFCB20B17BF4B.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 26:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC8D9F93CF72E31FD7385D8827613382FFA9ABD34FED03863F6CA615EF19351FB.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 27:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N2D1B95A937F1ED1F9DF42D7469F44F68E550690A2B0A4EA36E9CDFEE3EEA8141.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 28:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N0588F3A69073E87EB926FDD5201F55DB33F601848099958C6B593ED0B9B7B2E8.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 29:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N26F5B7244C1C5F6E5BACECE0211C908523B81887BFC89F546FCB2A8DA09D7C44.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 30:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N6354A2ADA00B0F3FA09EB21BCC13DA0A603AB78E792080E7A75F79F1C33820ED.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 31:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NDF24175BA83B4EC463BEAF75D8525B05B237208C8DC1B0A52BBB42F918DF67D6.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 32:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC2FA737BA5A7BD8D4DF7945CA65733BDFA74D062FFC2B97BB9940B75520E7389.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 33:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N14BD5C8B2926D6F761D43D3BBF8DB7045DD6450AF072F0E49BD41C9003DBB4DD.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		case 34:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9364A1092EC606FB157179C98A0847A32AFCCC7B40ACB692F911D3697FC7D973.Helpers.Parse_Lazy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<DrawingCommand>(b);
			return default;
		}
	}

	internal static DrawingCommand Parse_Progressive<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N1C5D572B7DC7CB94A904CBE7340450B1C86A3A90FC4DB1A1E3C9B4FB1BFF925B.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 2:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5E1C5B4B68CC1F337CD76FF55AE365E0D39EA2DD6B33DFC731A18C03BD6F5C07.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 3:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N16B7695805C45D7C581986875404A73107BADE366E27B8D8CA82A7D603D9E91D.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 4:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NE8FE21482E7457B5C798E43933F8DCA470CE0C29DAB4687AD7728F99494CB110.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 5:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NECB13F3A0DAA1E01364779FE0682C27B2FA94567618DD5B9B845D16CD16AE1A0.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 6:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N49DF7D67528E5F140C70F9D65A8E3CB96FF5343F525000B7F4213FA1ABCD263F.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 7:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N4E2FD9F10DFE642110D2D048AD575A7B15705BF87C62DE1D05926DD7BBD5BE1E.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 8:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NAA39CC811B56DF1EB778C653FB896A9970E0588C5A05D19A797A2017F1A9F388.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 9:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9AC8EBE7A31E1C456BA677771AB5E24F29076FDD91A054D89D1C1315B66E9997.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 10:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N2EEB82336954C241BE9ED013CA87E4E103C1DC7F4F48D94ED4D9A7BB8296FB8E.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 11:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N69A49CFCBB5CFD213E768753BFC4DF9F21929ADF0256D20CB90C5C49B921DF29.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 12:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC38BDD8138EB0091B775564B160FBDE8D527B7718A0B3CBAB4EB610A462D4A83.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 13:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 14:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NFE7C58792E9D91F2107E1720B9829B1887CA65017B1233EFCF5B59665B5ACC54.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 15:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N1A7259827D08365F08E55C52D4D87027AD1A390E599A4C4B55BE823EC5441722.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 16:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5B5CA176CFEA19EF3CE59972DE3915DD84ABDEB8372471A1C4A445A289C46FD9.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 17:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N737C4E71164ACA2F804B938A9669AB13CE523CFB92C612BBFFCF77D2CCF07EA6.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 18:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 19:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N85DEC74C14811CF4C7B6B0B4D7AE3CC4C8C1C2952B6DC44BDD4C8DDB0551B31A.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 20:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NDCF9F15ADD56DB80A5A2C48EF79993DDD88D0ED9C475C70859631EFC694ADF0D.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 21:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N04B2A1B1357643980AAC3189D37CF6540BDE25C78C88F9C0641FEC6C6EE4FBE6.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 22:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9AFBBB23CF06BC8B948FB67E1753681F5CFD8AA3139A6E41ABA97AFB3A613F22.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 23:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N05612B7F730FEC53FECDBB4339C75F8C1B8FFFA5962C618B39B51CFEA72CB10F.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 24:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5396F829791C8E171EE3DA8D092DF262C14AC5C5418653F1D5351CA3C9ACFEC2.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 25:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NE886E825C9FB6A796372424284068CFBFC2AF734D5A3D5DF506EFCB20B17BF4B.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 26:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC8D9F93CF72E31FD7385D8827613382FFA9ABD34FED03863F6CA615EF19351FB.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 27:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N2D1B95A937F1ED1F9DF42D7469F44F68E550690A2B0A4EA36E9CDFEE3EEA8141.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 28:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N0588F3A69073E87EB926FDD5201F55DB33F601848099958C6B593ED0B9B7B2E8.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 29:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N26F5B7244C1C5F6E5BACECE0211C908523B81887BFC89F546FCB2A8DA09D7C44.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 30:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N6354A2ADA00B0F3FA09EB21BCC13DA0A603AB78E792080E7A75F79F1C33820ED.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 31:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NDF24175BA83B4EC463BEAF75D8525B05B237208C8DC1B0A52BBB42F918DF67D6.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 32:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC2FA737BA5A7BD8D4DF7945CA65733BDFA74D062FFC2B97BB9940B75520E7389.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 33:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N14BD5C8B2926D6F761D43D3BBF8DB7045DD6450AF072F0E49BD41C9003DBB4DD.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		case 34:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9364A1092EC606FB157179C98A0847A32AFCCC7B40ACB692F911D3697FC7D973.Helpers.Parse_Progressive(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<DrawingCommand>(b);
			return default;
		}
	}

	internal static DrawingCommand Parse_Greedy<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N1C5D572B7DC7CB94A904CBE7340450B1C86A3A90FC4DB1A1E3C9B4FB1BFF925B.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 2:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5E1C5B4B68CC1F337CD76FF55AE365E0D39EA2DD6B33DFC731A18C03BD6F5C07.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 3:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N16B7695805C45D7C581986875404A73107BADE366E27B8D8CA82A7D603D9E91D.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 4:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NE8FE21482E7457B5C798E43933F8DCA470CE0C29DAB4687AD7728F99494CB110.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 5:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NECB13F3A0DAA1E01364779FE0682C27B2FA94567618DD5B9B845D16CD16AE1A0.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 6:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N49DF7D67528E5F140C70F9D65A8E3CB96FF5343F525000B7F4213FA1ABCD263F.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 7:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N4E2FD9F10DFE642110D2D048AD575A7B15705BF87C62DE1D05926DD7BBD5BE1E.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 8:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NAA39CC811B56DF1EB778C653FB896A9970E0588C5A05D19A797A2017F1A9F388.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 9:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9AC8EBE7A31E1C456BA677771AB5E24F29076FDD91A054D89D1C1315B66E9997.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 10:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N2EEB82336954C241BE9ED013CA87E4E103C1DC7F4F48D94ED4D9A7BB8296FB8E.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 11:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N69A49CFCBB5CFD213E768753BFC4DF9F21929ADF0256D20CB90C5C49B921DF29.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 12:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC38BDD8138EB0091B775564B160FBDE8D527B7718A0B3CBAB4EB610A462D4A83.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 13:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 14:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NFE7C58792E9D91F2107E1720B9829B1887CA65017B1233EFCF5B59665B5ACC54.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 15:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N1A7259827D08365F08E55C52D4D87027AD1A390E599A4C4B55BE823EC5441722.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 16:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5B5CA176CFEA19EF3CE59972DE3915DD84ABDEB8372471A1C4A445A289C46FD9.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 17:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N737C4E71164ACA2F804B938A9669AB13CE523CFB92C612BBFFCF77D2CCF07EA6.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 18:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 19:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N85DEC74C14811CF4C7B6B0B4D7AE3CC4C8C1C2952B6DC44BDD4C8DDB0551B31A.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 20:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NDCF9F15ADD56DB80A5A2C48EF79993DDD88D0ED9C475C70859631EFC694ADF0D.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 21:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N04B2A1B1357643980AAC3189D37CF6540BDE25C78C88F9C0641FEC6C6EE4FBE6.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 22:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9AFBBB23CF06BC8B948FB67E1753681F5CFD8AA3139A6E41ABA97AFB3A613F22.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 23:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N05612B7F730FEC53FECDBB4339C75F8C1B8FFFA5962C618B39B51CFEA72CB10F.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 24:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5396F829791C8E171EE3DA8D092DF262C14AC5C5418653F1D5351CA3C9ACFEC2.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 25:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NE886E825C9FB6A796372424284068CFBFC2AF734D5A3D5DF506EFCB20B17BF4B.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 26:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC8D9F93CF72E31FD7385D8827613382FFA9ABD34FED03863F6CA615EF19351FB.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 27:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N2D1B95A937F1ED1F9DF42D7469F44F68E550690A2B0A4EA36E9CDFEE3EEA8141.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 28:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N0588F3A69073E87EB926FDD5201F55DB33F601848099958C6B593ED0B9B7B2E8.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 29:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N26F5B7244C1C5F6E5BACECE0211C908523B81887BFC89F546FCB2A8DA09D7C44.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 30:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N6354A2ADA00B0F3FA09EB21BCC13DA0A603AB78E792080E7A75F79F1C33820ED.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 31:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NDF24175BA83B4EC463BEAF75D8525B05B237208C8DC1B0A52BBB42F918DF67D6.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 32:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC2FA737BA5A7BD8D4DF7945CA65733BDFA74D062FFC2B97BB9940B75520E7389.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 33:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N14BD5C8B2926D6F761D43D3BBF8DB7045DD6450AF072F0E49BD41C9003DBB4DD.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		case 34:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9364A1092EC606FB157179C98A0847A32AFCCC7B40ACB692F911D3697FC7D973.Helpers.Parse_Greedy(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<DrawingCommand>(b);
			return default;
		}
	}

	internal static DrawingCommand Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, ref (int offset0, int offset1) offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		byte b = buffer.ReadByte(offset.offset0);
		int item = offset.offset1;
		switch (b)
		{
		case 1:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N1C5D572B7DC7CB94A904CBE7340450B1C86A3A90FC4DB1A1E3C9B4FB1BFF925B.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 2:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5E1C5B4B68CC1F337CD76FF55AE365E0D39EA2DD6B33DFC731A18C03BD6F5C07.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 3:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N16B7695805C45D7C581986875404A73107BADE366E27B8D8CA82A7D603D9E91D.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 4:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NE8FE21482E7457B5C798E43933F8DCA470CE0C29DAB4687AD7728F99494CB110.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 5:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NECB13F3A0DAA1E01364779FE0682C27B2FA94567618DD5B9B845D16CD16AE1A0.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 6:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N49DF7D67528E5F140C70F9D65A8E3CB96FF5343F525000B7F4213FA1ABCD263F.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 7:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N4E2FD9F10DFE642110D2D048AD575A7B15705BF87C62DE1D05926DD7BBD5BE1E.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 8:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NAA39CC811B56DF1EB778C653FB896A9970E0588C5A05D19A797A2017F1A9F388.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 9:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9AC8EBE7A31E1C456BA677771AB5E24F29076FDD91A054D89D1C1315B66E9997.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 10:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N2EEB82336954C241BE9ED013CA87E4E103C1DC7F4F48D94ED4D9A7BB8296FB8E.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 11:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N69A49CFCBB5CFD213E768753BFC4DF9F21929ADF0256D20CB90C5C49B921DF29.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 12:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC38BDD8138EB0091B775564B160FBDE8D527B7718A0B3CBAB4EB610A462D4A83.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 13:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N019847E8E25C20AF1F45BD04EBDAE12ACF40CFF58D0E61D2A831634C123360A5.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 14:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NFE7C58792E9D91F2107E1720B9829B1887CA65017B1233EFCF5B59665B5ACC54.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 15:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N1A7259827D08365F08E55C52D4D87027AD1A390E599A4C4B55BE823EC5441722.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 16:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5B5CA176CFEA19EF3CE59972DE3915DD84ABDEB8372471A1C4A445A289C46FD9.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 17:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N737C4E71164ACA2F804B938A9669AB13CE523CFB92C612BBFFCF77D2CCF07EA6.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 18:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 19:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N85DEC74C14811CF4C7B6B0B4D7AE3CC4C8C1C2952B6DC44BDD4C8DDB0551B31A.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 20:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NDCF9F15ADD56DB80A5A2C48EF79993DDD88D0ED9C475C70859631EFC694ADF0D.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 21:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N04B2A1B1357643980AAC3189D37CF6540BDE25C78C88F9C0641FEC6C6EE4FBE6.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 22:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9AFBBB23CF06BC8B948FB67E1753681F5CFD8AA3139A6E41ABA97AFB3A613F22.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 23:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N05612B7F730FEC53FECDBB4339C75F8C1B8FFFA5962C618B39B51CFEA72CB10F.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 24:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N5396F829791C8E171EE3DA8D092DF262C14AC5C5418653F1D5351CA3C9ACFEC2.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 25:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NE886E825C9FB6A796372424284068CFBFC2AF734D5A3D5DF506EFCB20B17BF4B.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 26:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC8D9F93CF72E31FD7385D8827613382FFA9ABD34FED03863F6CA615EF19351FB.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 27:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N2D1B95A937F1ED1F9DF42D7469F44F68E550690A2B0A4EA36E9CDFEE3EEA8141.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 28:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N0588F3A69073E87EB926FDD5201F55DB33F601848099958C6B593ED0B9B7B2E8.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 29:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N26F5B7244C1C5F6E5BACECE0211C908523B81887BFC89F546FCB2A8DA09D7C44.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 30:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N6354A2ADA00B0F3FA09EB21BCC13DA0A603AB78E792080E7A75F79F1C33820ED.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 31:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NDF24175BA83B4EC463BEAF75D8525B05B237208C8DC1B0A52BBB42F918DF67D6.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 32:
			return new DrawingCommand(FlatSharp.Compiler.Generated.NC2FA737BA5A7BD8D4DF7945CA65733BDFA74D062FFC2B97BB9940B75520E7389.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 33:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N14BD5C8B2926D6F761D43D3BBF8DB7045DD6450AF072F0E49BD41C9003DBB4DD.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		case 34:
			return new DrawingCommand(FlatSharp.Compiler.Generated.N9364A1092EC606FB157179C98A0847A32AFCCC7B40ACB692F911D3697FC7D973.Helpers.Parse_GreedyMutable(buffer, item, remainingDepth));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<DrawingCommand>(b);
			return default;
		}
	}
}
