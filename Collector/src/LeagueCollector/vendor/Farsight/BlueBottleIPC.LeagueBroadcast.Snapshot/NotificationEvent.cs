using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferStruct]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.NotificationEvent")]
public class NotificationEvent
{
	public class __Type_Vector : IEnumerable<byte>, IEnumerable
	{
		private readonly NotificationEvent item;

		public int Count => 64;

		public byte this[int index]
		{
			get
			{
				NotificationEvent notificationEvent = item;
				return index switch
				{
					0 => notificationEvent.__flatsharp__Type_0, 
					1 => notificationEvent.__flatsharp__Type_1, 
					2 => notificationEvent.__flatsharp__Type_2, 
					3 => notificationEvent.__flatsharp__Type_3, 
					4 => notificationEvent.__flatsharp__Type_4, 
					5 => notificationEvent.__flatsharp__Type_5, 
					6 => notificationEvent.__flatsharp__Type_6, 
					7 => notificationEvent.__flatsharp__Type_7, 
					8 => notificationEvent.__flatsharp__Type_8, 
					9 => notificationEvent.__flatsharp__Type_9, 
					10 => notificationEvent.__flatsharp__Type_10, 
					11 => notificationEvent.__flatsharp__Type_11, 
					12 => notificationEvent.__flatsharp__Type_12, 
					13 => notificationEvent.__flatsharp__Type_13, 
					14 => notificationEvent.__flatsharp__Type_14, 
					15 => notificationEvent.__flatsharp__Type_15, 
					16 => notificationEvent.__flatsharp__Type_16, 
					17 => notificationEvent.__flatsharp__Type_17, 
					18 => notificationEvent.__flatsharp__Type_18, 
					19 => notificationEvent.__flatsharp__Type_19, 
					20 => notificationEvent.__flatsharp__Type_20, 
					21 => notificationEvent.__flatsharp__Type_21, 
					22 => notificationEvent.__flatsharp__Type_22, 
					23 => notificationEvent.__flatsharp__Type_23, 
					24 => notificationEvent.__flatsharp__Type_24, 
					25 => notificationEvent.__flatsharp__Type_25, 
					26 => notificationEvent.__flatsharp__Type_26, 
					27 => notificationEvent.__flatsharp__Type_27, 
					28 => notificationEvent.__flatsharp__Type_28, 
					29 => notificationEvent.__flatsharp__Type_29, 
					30 => notificationEvent.__flatsharp__Type_30, 
					31 => notificationEvent.__flatsharp__Type_31, 
					32 => notificationEvent.__flatsharp__Type_32, 
					33 => notificationEvent.__flatsharp__Type_33, 
					34 => notificationEvent.__flatsharp__Type_34, 
					35 => notificationEvent.__flatsharp__Type_35, 
					36 => notificationEvent.__flatsharp__Type_36, 
					37 => notificationEvent.__flatsharp__Type_37, 
					38 => notificationEvent.__flatsharp__Type_38, 
					39 => notificationEvent.__flatsharp__Type_39, 
					40 => notificationEvent.__flatsharp__Type_40, 
					41 => notificationEvent.__flatsharp__Type_41, 
					42 => notificationEvent.__flatsharp__Type_42, 
					43 => notificationEvent.__flatsharp__Type_43, 
					44 => notificationEvent.__flatsharp__Type_44, 
					45 => notificationEvent.__flatsharp__Type_45, 
					46 => notificationEvent.__flatsharp__Type_46, 
					47 => notificationEvent.__flatsharp__Type_47, 
					48 => notificationEvent.__flatsharp__Type_48, 
					49 => notificationEvent.__flatsharp__Type_49, 
					50 => notificationEvent.__flatsharp__Type_50, 
					51 => notificationEvent.__flatsharp__Type_51, 
					52 => notificationEvent.__flatsharp__Type_52, 
					53 => notificationEvent.__flatsharp__Type_53, 
					54 => notificationEvent.__flatsharp__Type_54, 
					55 => notificationEvent.__flatsharp__Type_55, 
					56 => notificationEvent.__flatsharp__Type_56, 
					57 => notificationEvent.__flatsharp__Type_57, 
					58 => notificationEvent.__flatsharp__Type_58, 
					59 => notificationEvent.__flatsharp__Type_59, 
					60 => notificationEvent.__flatsharp__Type_60, 
					61 => notificationEvent.__flatsharp__Type_61, 
					62 => notificationEvent.__flatsharp__Type_62, 
					63 => notificationEvent.__flatsharp__Type_63, 
					_ => FSThrow.IndexOutOfRange<byte>(), 
				};
			}
			set
			{
				NotificationEvent notificationEvent = item;
				switch (index)
				{
				case 0:
					notificationEvent.__flatsharp__Type_0 = value;
					break;
				case 1:
					notificationEvent.__flatsharp__Type_1 = value;
					break;
				case 2:
					notificationEvent.__flatsharp__Type_2 = value;
					break;
				case 3:
					notificationEvent.__flatsharp__Type_3 = value;
					break;
				case 4:
					notificationEvent.__flatsharp__Type_4 = value;
					break;
				case 5:
					notificationEvent.__flatsharp__Type_5 = value;
					break;
				case 6:
					notificationEvent.__flatsharp__Type_6 = value;
					break;
				case 7:
					notificationEvent.__flatsharp__Type_7 = value;
					break;
				case 8:
					notificationEvent.__flatsharp__Type_8 = value;
					break;
				case 9:
					notificationEvent.__flatsharp__Type_9 = value;
					break;
				case 10:
					notificationEvent.__flatsharp__Type_10 = value;
					break;
				case 11:
					notificationEvent.__flatsharp__Type_11 = value;
					break;
				case 12:
					notificationEvent.__flatsharp__Type_12 = value;
					break;
				case 13:
					notificationEvent.__flatsharp__Type_13 = value;
					break;
				case 14:
					notificationEvent.__flatsharp__Type_14 = value;
					break;
				case 15:
					notificationEvent.__flatsharp__Type_15 = value;
					break;
				case 16:
					notificationEvent.__flatsharp__Type_16 = value;
					break;
				case 17:
					notificationEvent.__flatsharp__Type_17 = value;
					break;
				case 18:
					notificationEvent.__flatsharp__Type_18 = value;
					break;
				case 19:
					notificationEvent.__flatsharp__Type_19 = value;
					break;
				case 20:
					notificationEvent.__flatsharp__Type_20 = value;
					break;
				case 21:
					notificationEvent.__flatsharp__Type_21 = value;
					break;
				case 22:
					notificationEvent.__flatsharp__Type_22 = value;
					break;
				case 23:
					notificationEvent.__flatsharp__Type_23 = value;
					break;
				case 24:
					notificationEvent.__flatsharp__Type_24 = value;
					break;
				case 25:
					notificationEvent.__flatsharp__Type_25 = value;
					break;
				case 26:
					notificationEvent.__flatsharp__Type_26 = value;
					break;
				case 27:
					notificationEvent.__flatsharp__Type_27 = value;
					break;
				case 28:
					notificationEvent.__flatsharp__Type_28 = value;
					break;
				case 29:
					notificationEvent.__flatsharp__Type_29 = value;
					break;
				case 30:
					notificationEvent.__flatsharp__Type_30 = value;
					break;
				case 31:
					notificationEvent.__flatsharp__Type_31 = value;
					break;
				case 32:
					notificationEvent.__flatsharp__Type_32 = value;
					break;
				case 33:
					notificationEvent.__flatsharp__Type_33 = value;
					break;
				case 34:
					notificationEvent.__flatsharp__Type_34 = value;
					break;
				case 35:
					notificationEvent.__flatsharp__Type_35 = value;
					break;
				case 36:
					notificationEvent.__flatsharp__Type_36 = value;
					break;
				case 37:
					notificationEvent.__flatsharp__Type_37 = value;
					break;
				case 38:
					notificationEvent.__flatsharp__Type_38 = value;
					break;
				case 39:
					notificationEvent.__flatsharp__Type_39 = value;
					break;
				case 40:
					notificationEvent.__flatsharp__Type_40 = value;
					break;
				case 41:
					notificationEvent.__flatsharp__Type_41 = value;
					break;
				case 42:
					notificationEvent.__flatsharp__Type_42 = value;
					break;
				case 43:
					notificationEvent.__flatsharp__Type_43 = value;
					break;
				case 44:
					notificationEvent.__flatsharp__Type_44 = value;
					break;
				case 45:
					notificationEvent.__flatsharp__Type_45 = value;
					break;
				case 46:
					notificationEvent.__flatsharp__Type_46 = value;
					break;
				case 47:
					notificationEvent.__flatsharp__Type_47 = value;
					break;
				case 48:
					notificationEvent.__flatsharp__Type_48 = value;
					break;
				case 49:
					notificationEvent.__flatsharp__Type_49 = value;
					break;
				case 50:
					notificationEvent.__flatsharp__Type_50 = value;
					break;
				case 51:
					notificationEvent.__flatsharp__Type_51 = value;
					break;
				case 52:
					notificationEvent.__flatsharp__Type_52 = value;
					break;
				case 53:
					notificationEvent.__flatsharp__Type_53 = value;
					break;
				case 54:
					notificationEvent.__flatsharp__Type_54 = value;
					break;
				case 55:
					notificationEvent.__flatsharp__Type_55 = value;
					break;
				case 56:
					notificationEvent.__flatsharp__Type_56 = value;
					break;
				case 57:
					notificationEvent.__flatsharp__Type_57 = value;
					break;
				case 58:
					notificationEvent.__flatsharp__Type_58 = value;
					break;
				case 59:
					notificationEvent.__flatsharp__Type_59 = value;
					break;
				case 60:
					notificationEvent.__flatsharp__Type_60 = value;
					break;
				case 61:
					notificationEvent.__flatsharp__Type_61 = value;
					break;
				case 62:
					notificationEvent.__flatsharp__Type_62 = value;
					break;
				case 63:
					notificationEvent.__flatsharp__Type_63 = value;
					break;
				default:
					FSThrow.IndexOutOfRange();
					break;
				}
			}
		}

		public __Type_Vector(NotificationEvent item)
		{
			this.item = item;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public IEnumerator<byte> GetEnumerator()
		{
			NotificationEvent thisItem = item;
			yield return thisItem.__flatsharp__Type_0;
			yield return thisItem.__flatsharp__Type_1;
			yield return thisItem.__flatsharp__Type_2;
			yield return thisItem.__flatsharp__Type_3;
			yield return thisItem.__flatsharp__Type_4;
			yield return thisItem.__flatsharp__Type_5;
			yield return thisItem.__flatsharp__Type_6;
			yield return thisItem.__flatsharp__Type_7;
			yield return thisItem.__flatsharp__Type_8;
			yield return thisItem.__flatsharp__Type_9;
			yield return thisItem.__flatsharp__Type_10;
			yield return thisItem.__flatsharp__Type_11;
			yield return thisItem.__flatsharp__Type_12;
			yield return thisItem.__flatsharp__Type_13;
			yield return thisItem.__flatsharp__Type_14;
			yield return thisItem.__flatsharp__Type_15;
			yield return thisItem.__flatsharp__Type_16;
			yield return thisItem.__flatsharp__Type_17;
			yield return thisItem.__flatsharp__Type_18;
			yield return thisItem.__flatsharp__Type_19;
			yield return thisItem.__flatsharp__Type_20;
			yield return thisItem.__flatsharp__Type_21;
			yield return thisItem.__flatsharp__Type_22;
			yield return thisItem.__flatsharp__Type_23;
			yield return thisItem.__flatsharp__Type_24;
			yield return thisItem.__flatsharp__Type_25;
			yield return thisItem.__flatsharp__Type_26;
			yield return thisItem.__flatsharp__Type_27;
			yield return thisItem.__flatsharp__Type_28;
			yield return thisItem.__flatsharp__Type_29;
			yield return thisItem.__flatsharp__Type_30;
			yield return thisItem.__flatsharp__Type_31;
			yield return thisItem.__flatsharp__Type_32;
			yield return thisItem.__flatsharp__Type_33;
			yield return thisItem.__flatsharp__Type_34;
			yield return thisItem.__flatsharp__Type_35;
			yield return thisItem.__flatsharp__Type_36;
			yield return thisItem.__flatsharp__Type_37;
			yield return thisItem.__flatsharp__Type_38;
			yield return thisItem.__flatsharp__Type_39;
			yield return thisItem.__flatsharp__Type_40;
			yield return thisItem.__flatsharp__Type_41;
			yield return thisItem.__flatsharp__Type_42;
			yield return thisItem.__flatsharp__Type_43;
			yield return thisItem.__flatsharp__Type_44;
			yield return thisItem.__flatsharp__Type_45;
			yield return thisItem.__flatsharp__Type_46;
			yield return thisItem.__flatsharp__Type_47;
			yield return thisItem.__flatsharp__Type_48;
			yield return thisItem.__flatsharp__Type_49;
			yield return thisItem.__flatsharp__Type_50;
			yield return thisItem.__flatsharp__Type_51;
			yield return thisItem.__flatsharp__Type_52;
			yield return thisItem.__flatsharp__Type_53;
			yield return thisItem.__flatsharp__Type_54;
			yield return thisItem.__flatsharp__Type_55;
			yield return thisItem.__flatsharp__Type_56;
			yield return thisItem.__flatsharp__Type_57;
			yield return thisItem.__flatsharp__Type_58;
			yield return thisItem.__flatsharp__Type_59;
			yield return thisItem.__flatsharp__Type_60;
			yield return thisItem.__flatsharp__Type_61;
			yield return thisItem.__flatsharp__Type_62;
			yield return thisItem.__flatsharp__Type_63;
		}

		public void CopyFrom(ReadOnlySpan<byte> source)
		{
			NotificationEvent notificationEvent = item;
			ReadOnlySpan<byte> readOnlySpan = source;
			notificationEvent.__flatsharp__Type_63 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[63]);
			notificationEvent.__flatsharp__Type_62 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[62]);
			notificationEvent.__flatsharp__Type_61 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[61]);
			notificationEvent.__flatsharp__Type_60 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[60]);
			notificationEvent.__flatsharp__Type_59 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[59]);
			notificationEvent.__flatsharp__Type_58 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[58]);
			notificationEvent.__flatsharp__Type_57 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[57]);
			notificationEvent.__flatsharp__Type_56 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[56]);
			notificationEvent.__flatsharp__Type_55 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[55]);
			notificationEvent.__flatsharp__Type_54 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[54]);
			notificationEvent.__flatsharp__Type_53 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[53]);
			notificationEvent.__flatsharp__Type_52 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[52]);
			notificationEvent.__flatsharp__Type_51 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[51]);
			notificationEvent.__flatsharp__Type_50 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[50]);
			notificationEvent.__flatsharp__Type_49 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[49]);
			notificationEvent.__flatsharp__Type_48 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[48]);
			notificationEvent.__flatsharp__Type_47 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[47]);
			notificationEvent.__flatsharp__Type_46 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[46]);
			notificationEvent.__flatsharp__Type_45 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[45]);
			notificationEvent.__flatsharp__Type_44 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[44]);
			notificationEvent.__flatsharp__Type_43 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[43]);
			notificationEvent.__flatsharp__Type_42 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[42]);
			notificationEvent.__flatsharp__Type_41 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[41]);
			notificationEvent.__flatsharp__Type_40 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[40]);
			notificationEvent.__flatsharp__Type_39 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[39]);
			notificationEvent.__flatsharp__Type_38 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[38]);
			notificationEvent.__flatsharp__Type_37 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[37]);
			notificationEvent.__flatsharp__Type_36 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[36]);
			notificationEvent.__flatsharp__Type_35 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[35]);
			notificationEvent.__flatsharp__Type_34 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[34]);
			notificationEvent.__flatsharp__Type_33 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[33]);
			notificationEvent.__flatsharp__Type_32 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[32]);
			notificationEvent.__flatsharp__Type_31 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[31]);
			notificationEvent.__flatsharp__Type_30 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[30]);
			notificationEvent.__flatsharp__Type_29 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[29]);
			notificationEvent.__flatsharp__Type_28 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[28]);
			notificationEvent.__flatsharp__Type_27 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[27]);
			notificationEvent.__flatsharp__Type_26 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[26]);
			notificationEvent.__flatsharp__Type_25 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[25]);
			notificationEvent.__flatsharp__Type_24 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[24]);
			notificationEvent.__flatsharp__Type_23 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[23]);
			notificationEvent.__flatsharp__Type_22 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[22]);
			notificationEvent.__flatsharp__Type_21 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[21]);
			notificationEvent.__flatsharp__Type_20 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[20]);
			notificationEvent.__flatsharp__Type_19 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[19]);
			notificationEvent.__flatsharp__Type_18 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[18]);
			notificationEvent.__flatsharp__Type_17 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[17]);
			notificationEvent.__flatsharp__Type_16 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[16]);
			notificationEvent.__flatsharp__Type_15 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[15]);
			notificationEvent.__flatsharp__Type_14 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[14]);
			notificationEvent.__flatsharp__Type_13 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[13]);
			notificationEvent.__flatsharp__Type_12 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[12]);
			notificationEvent.__flatsharp__Type_11 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[11]);
			notificationEvent.__flatsharp__Type_10 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[10]);
			notificationEvent.__flatsharp__Type_9 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[9]);
			notificationEvent.__flatsharp__Type_8 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[8]);
			notificationEvent.__flatsharp__Type_7 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[7]);
			notificationEvent.__flatsharp__Type_6 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[6]);
			notificationEvent.__flatsharp__Type_5 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[5]);
			notificationEvent.__flatsharp__Type_4 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[4]);
			notificationEvent.__flatsharp__Type_3 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[3]);
			notificationEvent.__flatsharp__Type_2 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[2]);
			notificationEvent.__flatsharp__Type_1 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[1]);
			notificationEvent.__flatsharp__Type_0 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[0]);
		}

		public void CopyFrom(IReadOnlyList<byte> source)
		{
			NotificationEvent notificationEvent = item;
			notificationEvent.__flatsharp__Type_63 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[63]);
			notificationEvent.__flatsharp__Type_62 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[62]);
			notificationEvent.__flatsharp__Type_61 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[61]);
			notificationEvent.__flatsharp__Type_60 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[60]);
			notificationEvent.__flatsharp__Type_59 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[59]);
			notificationEvent.__flatsharp__Type_58 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[58]);
			notificationEvent.__flatsharp__Type_57 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[57]);
			notificationEvent.__flatsharp__Type_56 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[56]);
			notificationEvent.__flatsharp__Type_55 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[55]);
			notificationEvent.__flatsharp__Type_54 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[54]);
			notificationEvent.__flatsharp__Type_53 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[53]);
			notificationEvent.__flatsharp__Type_52 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[52]);
			notificationEvent.__flatsharp__Type_51 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[51]);
			notificationEvent.__flatsharp__Type_50 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[50]);
			notificationEvent.__flatsharp__Type_49 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[49]);
			notificationEvent.__flatsharp__Type_48 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[48]);
			notificationEvent.__flatsharp__Type_47 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[47]);
			notificationEvent.__flatsharp__Type_46 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[46]);
			notificationEvent.__flatsharp__Type_45 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[45]);
			notificationEvent.__flatsharp__Type_44 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[44]);
			notificationEvent.__flatsharp__Type_43 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[43]);
			notificationEvent.__flatsharp__Type_42 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[42]);
			notificationEvent.__flatsharp__Type_41 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[41]);
			notificationEvent.__flatsharp__Type_40 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[40]);
			notificationEvent.__flatsharp__Type_39 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[39]);
			notificationEvent.__flatsharp__Type_38 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[38]);
			notificationEvent.__flatsharp__Type_37 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[37]);
			notificationEvent.__flatsharp__Type_36 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[36]);
			notificationEvent.__flatsharp__Type_35 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[35]);
			notificationEvent.__flatsharp__Type_34 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[34]);
			notificationEvent.__flatsharp__Type_33 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[33]);
			notificationEvent.__flatsharp__Type_32 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[32]);
			notificationEvent.__flatsharp__Type_31 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[31]);
			notificationEvent.__flatsharp__Type_30 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[30]);
			notificationEvent.__flatsharp__Type_29 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[29]);
			notificationEvent.__flatsharp__Type_28 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[28]);
			notificationEvent.__flatsharp__Type_27 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[27]);
			notificationEvent.__flatsharp__Type_26 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[26]);
			notificationEvent.__flatsharp__Type_25 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[25]);
			notificationEvent.__flatsharp__Type_24 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[24]);
			notificationEvent.__flatsharp__Type_23 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[23]);
			notificationEvent.__flatsharp__Type_22 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[22]);
			notificationEvent.__flatsharp__Type_21 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[21]);
			notificationEvent.__flatsharp__Type_20 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[20]);
			notificationEvent.__flatsharp__Type_19 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[19]);
			notificationEvent.__flatsharp__Type_18 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[18]);
			notificationEvent.__flatsharp__Type_17 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[17]);
			notificationEvent.__flatsharp__Type_16 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[16]);
			notificationEvent.__flatsharp__Type_15 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[15]);
			notificationEvent.__flatsharp__Type_14 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[14]);
			notificationEvent.__flatsharp__Type_13 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[13]);
			notificationEvent.__flatsharp__Type_12 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[12]);
			notificationEvent.__flatsharp__Type_11 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[11]);
			notificationEvent.__flatsharp__Type_10 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[10]);
			notificationEvent.__flatsharp__Type_9 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[9]);
			notificationEvent.__flatsharp__Type_8 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[8]);
			notificationEvent.__flatsharp__Type_7 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[7]);
			notificationEvent.__flatsharp__Type_6 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[6]);
			notificationEvent.__flatsharp__Type_5 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[5]);
			notificationEvent.__flatsharp__Type_4 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[4]);
			notificationEvent.__flatsharp__Type_3 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[3]);
			notificationEvent.__flatsharp__Type_2 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[2]);
			notificationEvent.__flatsharp__Type_1 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[1]);
			notificationEvent.__flatsharp__Type_0 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[0]);
		}
	}

	private __Type_Vector? __Type;

	[FlatBufferItem(0)]
	public virtual float GameTime { get; set; }

	[FlatBufferItem(1)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[0]")]
	protected virtual byte __flatsharp__Type_0 { get; set; }

	[FlatBufferItem(2)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[1]")]
	protected virtual byte __flatsharp__Type_1 { get; set; }

	[FlatBufferItem(3)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[2]")]
	protected virtual byte __flatsharp__Type_2 { get; set; }

	[FlatBufferItem(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[3]")]
	protected virtual byte __flatsharp__Type_3 { get; set; }

	[FlatBufferItem(5)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[4]")]
	protected virtual byte __flatsharp__Type_4 { get; set; }

	[FlatBufferItem(6)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[5]")]
	protected virtual byte __flatsharp__Type_5 { get; set; }

	[FlatBufferItem(7)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[6]")]
	protected virtual byte __flatsharp__Type_6 { get; set; }

	[FlatBufferItem(8)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[7]")]
	protected virtual byte __flatsharp__Type_7 { get; set; }

	[FlatBufferItem(9)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[8]")]
	protected virtual byte __flatsharp__Type_8 { get; set; }

	[FlatBufferItem(10)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[9]")]
	protected virtual byte __flatsharp__Type_9 { get; set; }

	[FlatBufferItem(11)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[10]")]
	protected virtual byte __flatsharp__Type_10 { get; set; }

	[FlatBufferItem(12)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[11]")]
	protected virtual byte __flatsharp__Type_11 { get; set; }

	[FlatBufferItem(13)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[12]")]
	protected virtual byte __flatsharp__Type_12 { get; set; }

	[FlatBufferItem(14)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[13]")]
	protected virtual byte __flatsharp__Type_13 { get; set; }

	[FlatBufferItem(15)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[14]")]
	protected virtual byte __flatsharp__Type_14 { get; set; }

	[FlatBufferItem(16)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[15]")]
	protected virtual byte __flatsharp__Type_15 { get; set; }

	[FlatBufferItem(17)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[16]")]
	protected virtual byte __flatsharp__Type_16 { get; set; }

	[FlatBufferItem(18)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[17]")]
	protected virtual byte __flatsharp__Type_17 { get; set; }

	[FlatBufferItem(19)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[18]")]
	protected virtual byte __flatsharp__Type_18 { get; set; }

	[FlatBufferItem(20)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[19]")]
	protected virtual byte __flatsharp__Type_19 { get; set; }

	[FlatBufferItem(21)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[20]")]
	protected virtual byte __flatsharp__Type_20 { get; set; }

	[FlatBufferItem(22)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[21]")]
	protected virtual byte __flatsharp__Type_21 { get; set; }

	[FlatBufferItem(23)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[22]")]
	protected virtual byte __flatsharp__Type_22 { get; set; }

	[FlatBufferItem(24)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[23]")]
	protected virtual byte __flatsharp__Type_23 { get; set; }

	[FlatBufferItem(25)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[24]")]
	protected virtual byte __flatsharp__Type_24 { get; set; }

	[FlatBufferItem(26)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[25]")]
	protected virtual byte __flatsharp__Type_25 { get; set; }

	[FlatBufferItem(27)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[26]")]
	protected virtual byte __flatsharp__Type_26 { get; set; }

	[FlatBufferItem(28)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[27]")]
	protected virtual byte __flatsharp__Type_27 { get; set; }

	[FlatBufferItem(29)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[28]")]
	protected virtual byte __flatsharp__Type_28 { get; set; }

	[FlatBufferItem(30)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[29]")]
	protected virtual byte __flatsharp__Type_29 { get; set; }

	[FlatBufferItem(31)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[30]")]
	protected virtual byte __flatsharp__Type_30 { get; set; }

	[FlatBufferItem(32)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[31]")]
	protected virtual byte __flatsharp__Type_31 { get; set; }

	[FlatBufferItem(33)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[32]")]
	protected virtual byte __flatsharp__Type_32 { get; set; }

	[FlatBufferItem(34)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[33]")]
	protected virtual byte __flatsharp__Type_33 { get; set; }

	[FlatBufferItem(35)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[34]")]
	protected virtual byte __flatsharp__Type_34 { get; set; }

	[FlatBufferItem(36)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[35]")]
	protected virtual byte __flatsharp__Type_35 { get; set; }

	[FlatBufferItem(37)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[36]")]
	protected virtual byte __flatsharp__Type_36 { get; set; }

	[FlatBufferItem(38)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[37]")]
	protected virtual byte __flatsharp__Type_37 { get; set; }

	[FlatBufferItem(39)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[38]")]
	protected virtual byte __flatsharp__Type_38 { get; set; }

	[FlatBufferItem(40)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[39]")]
	protected virtual byte __flatsharp__Type_39 { get; set; }

	[FlatBufferItem(41)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[40]")]
	protected virtual byte __flatsharp__Type_40 { get; set; }

	[FlatBufferItem(42)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[41]")]
	protected virtual byte __flatsharp__Type_41 { get; set; }

	[FlatBufferItem(43)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[42]")]
	protected virtual byte __flatsharp__Type_42 { get; set; }

	[FlatBufferItem(44)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[43]")]
	protected virtual byte __flatsharp__Type_43 { get; set; }

	[FlatBufferItem(45)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[44]")]
	protected virtual byte __flatsharp__Type_44 { get; set; }

	[FlatBufferItem(46)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[45]")]
	protected virtual byte __flatsharp__Type_45 { get; set; }

	[FlatBufferItem(47)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[46]")]
	protected virtual byte __flatsharp__Type_46 { get; set; }

	[FlatBufferItem(48)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[47]")]
	protected virtual byte __flatsharp__Type_47 { get; set; }

	[FlatBufferItem(49)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[48]")]
	protected virtual byte __flatsharp__Type_48 { get; set; }

	[FlatBufferItem(50)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[49]")]
	protected virtual byte __flatsharp__Type_49 { get; set; }

	[FlatBufferItem(51)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[50]")]
	protected virtual byte __flatsharp__Type_50 { get; set; }

	[FlatBufferItem(52)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[51]")]
	protected virtual byte __flatsharp__Type_51 { get; set; }

	[FlatBufferItem(53)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[52]")]
	protected virtual byte __flatsharp__Type_52 { get; set; }

	[FlatBufferItem(54)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[53]")]
	protected virtual byte __flatsharp__Type_53 { get; set; }

	[FlatBufferItem(55)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[54]")]
	protected virtual byte __flatsharp__Type_54 { get; set; }

	[FlatBufferItem(56)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[55]")]
	protected virtual byte __flatsharp__Type_55 { get; set; }

	[FlatBufferItem(57)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[56]")]
	protected virtual byte __flatsharp__Type_56 { get; set; }

	[FlatBufferItem(58)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[57]")]
	protected virtual byte __flatsharp__Type_57 { get; set; }

	[FlatBufferItem(59)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[58]")]
	protected virtual byte __flatsharp__Type_58 { get; set; }

	[FlatBufferItem(60)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[59]")]
	protected virtual byte __flatsharp__Type_59 { get; set; }

	[FlatBufferItem(61)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[60]")]
	protected virtual byte __flatsharp__Type_60 { get; set; }

	[FlatBufferItem(62)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[61]")]
	protected virtual byte __flatsharp__Type_61 { get; set; }

	[FlatBufferItem(63)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[62]")]
	protected virtual byte __flatsharp__Type_62 { get; set; }

	[FlatBufferItem(64)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "Type[63]")]
	protected virtual byte __flatsharp__Type_63 { get; set; }

	public __Type_Vector Type => __Type ?? (__Type = new __Type_Vector(this));

	static NotificationEvent()
	{
	}

	public NotificationEvent()
	{
	}

	protected NotificationEvent(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public NotificationEvent(NotificationEvent source)
	{
		GameTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameTime);
		__flatsharp__Type_0 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_0);
		__flatsharp__Type_1 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_1);
		__flatsharp__Type_2 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_2);
		__flatsharp__Type_3 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_3);
		__flatsharp__Type_4 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_4);
		__flatsharp__Type_5 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_5);
		__flatsharp__Type_6 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_6);
		__flatsharp__Type_7 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_7);
		__flatsharp__Type_8 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_8);
		__flatsharp__Type_9 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_9);
		__flatsharp__Type_10 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_10);
		__flatsharp__Type_11 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_11);
		__flatsharp__Type_12 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_12);
		__flatsharp__Type_13 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_13);
		__flatsharp__Type_14 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_14);
		__flatsharp__Type_15 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_15);
		__flatsharp__Type_16 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_16);
		__flatsharp__Type_17 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_17);
		__flatsharp__Type_18 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_18);
		__flatsharp__Type_19 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_19);
		__flatsharp__Type_20 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_20);
		__flatsharp__Type_21 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_21);
		__flatsharp__Type_22 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_22);
		__flatsharp__Type_23 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_23);
		__flatsharp__Type_24 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_24);
		__flatsharp__Type_25 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_25);
		__flatsharp__Type_26 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_26);
		__flatsharp__Type_27 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_27);
		__flatsharp__Type_28 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_28);
		__flatsharp__Type_29 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_29);
		__flatsharp__Type_30 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_30);
		__flatsharp__Type_31 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_31);
		__flatsharp__Type_32 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_32);
		__flatsharp__Type_33 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_33);
		__flatsharp__Type_34 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_34);
		__flatsharp__Type_35 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_35);
		__flatsharp__Type_36 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_36);
		__flatsharp__Type_37 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_37);
		__flatsharp__Type_38 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_38);
		__flatsharp__Type_39 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_39);
		__flatsharp__Type_40 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_40);
		__flatsharp__Type_41 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_41);
		__flatsharp__Type_42 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_42);
		__flatsharp__Type_43 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_43);
		__flatsharp__Type_44 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_44);
		__flatsharp__Type_45 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_45);
		__flatsharp__Type_46 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_46);
		__flatsharp__Type_47 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_47);
		__flatsharp__Type_48 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_48);
		__flatsharp__Type_49 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_49);
		__flatsharp__Type_50 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_50);
		__flatsharp__Type_51 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_51);
		__flatsharp__Type_52 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_52);
		__flatsharp__Type_53 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_53);
		__flatsharp__Type_54 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_54);
		__flatsharp__Type_55 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_55);
		__flatsharp__Type_56 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_56);
		__flatsharp__Type_57 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_57);
		__flatsharp__Type_58 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_58);
		__flatsharp__Type_59 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_59);
		__flatsharp__Type_60 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_60);
		__flatsharp__Type_61 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_61);
		__flatsharp__Type_62 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_62);
		__flatsharp__Type_63 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__Type_63);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
