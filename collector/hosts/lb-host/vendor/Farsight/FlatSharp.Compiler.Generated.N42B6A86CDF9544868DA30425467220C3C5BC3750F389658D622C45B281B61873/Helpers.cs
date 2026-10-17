using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A;
using FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB;
using FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;
using FlatSharp.Compiler.Generated.N6B63659726E72392160CE97102BBB138B1F009FAC2E45D58F8BFE0CF8A0C66EC;
using FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54;
using FlatSharp.Compiler.Generated.NAA27A09FECA849BD7156BB91850E529E3ACD19F4F8C6D751D4175AA2651D435F;
using FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B;
using FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F;
using FlatSharp.Compiler.Generated.NCB9A05B20B7639A9A58B77F9C00C0571BB27E6890B624889D9DCDA22D0460C4C;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Compiler.Generated.NEF88E318D74773E248F3B5DC745DB08D7035C1A26A00128363EF6497481C464D;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N42B6A86CDF9544868DA30425467220C3C5BC3750F389658D622C45B281B61873;

internal static class Helpers
{
	[DebuggerDisplay("Lazy AIHeroClient")]
	internal sealed class tableReader_2616b691b4e642c4821991dddba45d45_Lazy<TInputBuffer> : AIHeroClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AIHeroClient);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required ObjectInfo Info
		{
			get
			{
				return ReadIndex0Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override required AIClient Common
		{
			get
			{
				return ReadIndex1Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override uint HeroIndex
		{
			get
			{
				return ReadIndex2Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float RespawnTime
		{
			get
			{
				return ReadIndex3Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Gold
		{
			get
			{
				return ReadIndex4Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float TotalGold
		{
			get
			{
				return ReadIndex5Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float GoldGivenOnDeath
		{
			get
			{
				return ReadIndex6Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Experience
		{
			get
			{
				return ReadIndex7Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Resource
		{
			get
			{
				return ReadIndex8Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float MaxResource
		{
			get
			{
				return ReadIndex9Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override byte ResourceType
		{
			get
			{
				return ReadIndex10Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float VisionScore
		{
			get
			{
				return ReadIndex11Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Spell>? Spells
		{
			get
			{
				return ReadIndex12Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Item>? Items
		{
			get
			{
				return ReadIndex13Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Perk>? Perks
		{
			get
			{
				return ReadIndex14Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Bone>? Bones
		{
			get
			{
				return ReadIndex15Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override CharacterStats? CharacterStats
		{
			get
			{
				return ReadIndex16Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int LaneMinionKills
		{
			get
			{
				return ReadIndex17Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int NeutralMinionKills
		{
			get
			{
				return ReadIndex18Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int Kills
		{
			get
			{
				return ReadIndex19Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int Deaths
		{
			get
			{
				return ReadIndex20Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int Assists
		{
			get
			{
				return ReadIndex21Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_2616b691b4e642c4821991dddba45d45_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ObjectInfo ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Info");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIClient ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Spell>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NAA27A09FECA849BD7156BB91850E529E3ACD19F4F8C6D751D4175AA2651D435F.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Spells);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Item>? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NEF88E318D74773E248F3B5DC745DB08D7035C1A26A00128363EF6497481C464D.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Items);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Perk>? ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCB9A05B20B7639A9A58B77F9C00C0571BB27E6890B624889D9DCDA22D0460C4C.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Perks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Bone>? ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Bones);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CharacterStats? ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N6B63659726E72392160CE97102BBB138B1F009FAC2E45D58F8BFE0CF8A0C66EC.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive AIHeroClient")]
	internal sealed class tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer> : AIHeroClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private ObjectInfo __index0Value;

		private AIClient __index1Value;

		private uint __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private float __index7Value;

		private byte __mask1;

		private float __index8Value;

		private float __index9Value;

		private byte __index10Value;

		private float __index11Value;

		private IList<Spell>? __index12Value;

		private IList<Item>? __index13Value;

		private IList<Perk>? __index14Value;

		private IList<Bone>? __index15Value;

		private byte __mask2;

		private CharacterStats? __index16Value;

		private int __index17Value;

		private int __index18Value;

		private int __index19Value;

		private int __index20Value;

		private int __index21Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AIHeroClient);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required ObjectInfo Info
		{
			get
			{
				if ((__mask0 & 1) == 0)
				{
					__index0Value = ReadIndex0Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 1);
				}
				return __index0Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override required AIClient Common
		{
			get
			{
				if ((__mask0 & 2) == 0)
				{
					__index1Value = ReadIndex1Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 2);
				}
				return __index1Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override uint HeroIndex
		{
			get
			{
				if ((__mask0 & 4) == 0)
				{
					__index2Value = ReadIndex2Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 4);
				}
				return __index2Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float RespawnTime
		{
			get
			{
				if ((__mask0 & 8) == 0)
				{
					__index3Value = ReadIndex3Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 8);
				}
				return __index3Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Gold
		{
			get
			{
				if ((__mask0 & 0x10) == 0)
				{
					__index4Value = ReadIndex4Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 16);
				}
				return __index4Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float TotalGold
		{
			get
			{
				if ((__mask0 & 0x20) == 0)
				{
					__index5Value = ReadIndex5Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 32);
				}
				return __index5Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float GoldGivenOnDeath
		{
			get
			{
				if ((__mask0 & 0x40) == 0)
				{
					__index6Value = ReadIndex6Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 64);
				}
				return __index6Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Experience
		{
			get
			{
				if ((__mask0 & 0x80) == 0)
				{
					__index7Value = ReadIndex7Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 128);
				}
				return __index7Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Resource
		{
			get
			{
				if ((__mask1 & 1) == 0)
				{
					__index8Value = ReadIndex8Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 1);
				}
				return __index8Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float MaxResource
		{
			get
			{
				if ((__mask1 & 2) == 0)
				{
					__index9Value = ReadIndex9Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 2);
				}
				return __index9Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override byte ResourceType
		{
			get
			{
				if ((__mask1 & 4) == 0)
				{
					__index10Value = ReadIndex10Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 4);
				}
				return __index10Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float VisionScore
		{
			get
			{
				if ((__mask1 & 8) == 0)
				{
					__index11Value = ReadIndex11Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 8);
				}
				return __index11Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Spell>? Spells
		{
			get
			{
				if ((__mask1 & 0x10) == 0)
				{
					__index12Value = ReadIndex12Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 16);
				}
				return __index12Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Item>? Items
		{
			get
			{
				if ((__mask1 & 0x20) == 0)
				{
					__index13Value = ReadIndex13Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 32);
				}
				return __index13Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Perk>? Perks
		{
			get
			{
				if ((__mask1 & 0x40) == 0)
				{
					__index14Value = ReadIndex14Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 64);
				}
				return __index14Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Bone>? Bones
		{
			get
			{
				if ((__mask1 & 0x80) == 0)
				{
					__index15Value = ReadIndex15Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 128);
				}
				return __index15Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override CharacterStats? CharacterStats
		{
			get
			{
				if ((__mask2 & 1) == 0)
				{
					__index16Value = ReadIndex16Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 1);
				}
				return __index16Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int LaneMinionKills
		{
			get
			{
				if ((__mask2 & 2) == 0)
				{
					__index17Value = ReadIndex17Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 2);
				}
				return __index17Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int NeutralMinionKills
		{
			get
			{
				if ((__mask2 & 4) == 0)
				{
					__index18Value = ReadIndex18Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 4);
				}
				return __index18Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int Kills
		{
			get
			{
				if ((__mask2 & 8) == 0)
				{
					__index19Value = ReadIndex19Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 8);
				}
				return __index19Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int Deaths
		{
			get
			{
				if ((__mask2 & 0x10) == 0)
				{
					__index20Value = ReadIndex20Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 16);
				}
				return __index20Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int Assists
		{
			get
			{
				if ((__mask2 & 0x20) == 0)
				{
					__index21Value = ReadIndex21Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 32);
				}
				return __index21Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_2616b691b4e642c4821991dddba45d45_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			__index0Value = null;
			__index1Value = null;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ObjectInfo ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Info");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIClient ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Spell>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NAA27A09FECA849BD7156BB91850E529E3ACD19F4F8C6D751D4175AA2651D435F.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Spells);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Item>? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NEF88E318D74773E248F3B5DC745DB08D7035C1A26A00128363EF6497481C464D.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Items);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Perk>? ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCB9A05B20B7639A9A58B77F9C00C0571BB27E6890B624889D9DCDA22D0460C4C.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Perks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Bone>? ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Bones);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CharacterStats? ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N6B63659726E72392160CE97102BBB138B1F009FAC2E45D58F8BFE0CF8A0C66EC.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy AIHeroClient")]
	internal sealed class tableReader_2616b691b4e642c4821991dddba45d45_Greedy<TInputBuffer> : AIHeroClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private ObjectInfo __index0Value;

		private AIClient __index1Value;

		private uint __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private float __index7Value;

		private float __index8Value;

		private float __index9Value;

		private byte __index10Value;

		private float __index11Value;

		private IList<Spell>? __index12Value;

		private IList<Item>? __index13Value;

		private IList<Perk>? __index14Value;

		private IList<Bone>? __index15Value;

		private CharacterStats? __index16Value;

		private int __index17Value;

		private int __index18Value;

		private int __index19Value;

		private int __index20Value;

		private int __index21Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AIHeroClient);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required ObjectInfo Info
		{
			get
			{
				return __index0Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override required AIClient Common
		{
			get
			{
				return __index1Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override uint HeroIndex
		{
			get
			{
				return __index2Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float RespawnTime
		{
			get
			{
				return __index3Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Gold
		{
			get
			{
				return __index4Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float TotalGold
		{
			get
			{
				return __index5Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float GoldGivenOnDeath
		{
			get
			{
				return __index6Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Experience
		{
			get
			{
				return __index7Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Resource
		{
			get
			{
				return __index8Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float MaxResource
		{
			get
			{
				return __index9Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override byte ResourceType
		{
			get
			{
				return __index10Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float VisionScore
		{
			get
			{
				return __index11Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Spell>? Spells
		{
			get
			{
				return __index12Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Item>? Items
		{
			get
			{
				return __index13Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Perk>? Perks
		{
			get
			{
				return __index14Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<Bone>? Bones
		{
			get
			{
				return __index15Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override CharacterStats? CharacterStats
		{
			get
			{
				return __index16Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int LaneMinionKills
		{
			get
			{
				return __index17Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int NeutralMinionKills
		{
			get
			{
				return __index18Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int Kills
		{
			get
			{
				return __index19Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int Deaths
		{
			get
			{
				return __index20Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override int Assists
		{
			get
			{
				return __index21Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_2616b691b4e642c4821991dddba45d45_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTableGeneric.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, item, remainingDepth);
			__index8Value = ReadIndex8Value(buffer, offset, item, remainingDepth);
			__index9Value = ReadIndex9Value(buffer, offset, item, remainingDepth);
			__index10Value = ReadIndex10Value(buffer, offset, item, remainingDepth);
			__index11Value = ReadIndex11Value(buffer, offset, item, remainingDepth);
			__index12Value = ReadIndex12Value(buffer, offset, item, remainingDepth);
			__index13Value = ReadIndex13Value(buffer, offset, item, remainingDepth);
			__index14Value = ReadIndex14Value(buffer, offset, item, remainingDepth);
			__index15Value = ReadIndex15Value(buffer, offset, item, remainingDepth);
			__index16Value = ReadIndex16Value(buffer, offset, item, remainingDepth);
			__index17Value = ReadIndex17Value(buffer, offset, item, remainingDepth);
			__index18Value = ReadIndex18Value(buffer, offset, item, remainingDepth);
			__index19Value = ReadIndex19Value(buffer, offset, item, remainingDepth);
			__index20Value = ReadIndex20Value(buffer, offset, item, remainingDepth);
			__index21Value = ReadIndex21Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ObjectInfo ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Info");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIClient ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Spell>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NAA27A09FECA849BD7156BB91850E529E3ACD19F4F8C6D751D4175AA2651D435F.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Spells);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Item>? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NEF88E318D74773E248F3B5DC745DB08D7035C1A26A00128363EF6497481C464D.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Items);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Perk>? ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCB9A05B20B7639A9A58B77F9C00C0571BB27E6890B624889D9DCDA22D0460C4C.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Perks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Bone>? ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Bones);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CharacterStats? ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N6B63659726E72392160CE97102BBB138B1F009FAC2E45D58F8BFE0CF8A0C66EC.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable AIHeroClient")]
	internal sealed class tableReader_2616b691b4e642c4821991dddba45d45_GreedyMutable<TInputBuffer> : AIHeroClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private ObjectInfo __index0Value;

		private AIClient __index1Value;

		private uint __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private float __index7Value;

		private float __index8Value;

		private float __index9Value;

		private byte __index10Value;

		private float __index11Value;

		private IList<Spell>? __index12Value;

		private IList<Item>? __index13Value;

		private IList<Perk>? __index14Value;

		private IList<Bone>? __index15Value;

		private CharacterStats? __index16Value;

		private int __index17Value;

		private int __index18Value;

		private int __index19Value;

		private int __index20Value;

		private int __index21Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AIHeroClient);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required ObjectInfo Info
		{
			get
			{
				return __index0Value;
			}
			set
			{
				__index0Value = value;
			}
		}

		public override required AIClient Common
		{
			get
			{
				return __index1Value;
			}
			set
			{
				__index1Value = value;
			}
		}

		public override uint HeroIndex
		{
			get
			{
				return __index2Value;
			}
			set
			{
				__index2Value = value;
			}
		}

		public override float RespawnTime
		{
			get
			{
				return __index3Value;
			}
			set
			{
				__index3Value = value;
			}
		}

		public override float Gold
		{
			get
			{
				return __index4Value;
			}
			set
			{
				__index4Value = value;
			}
		}

		public override float TotalGold
		{
			get
			{
				return __index5Value;
			}
			set
			{
				__index5Value = value;
			}
		}

		public override float GoldGivenOnDeath
		{
			get
			{
				return __index6Value;
			}
			set
			{
				__index6Value = value;
			}
		}

		public override float Experience
		{
			get
			{
				return __index7Value;
			}
			set
			{
				__index7Value = value;
			}
		}

		public override float Resource
		{
			get
			{
				return __index8Value;
			}
			set
			{
				__index8Value = value;
			}
		}

		public override float MaxResource
		{
			get
			{
				return __index9Value;
			}
			set
			{
				__index9Value = value;
			}
		}

		public override byte ResourceType
		{
			get
			{
				return __index10Value;
			}
			set
			{
				__index10Value = value;
			}
		}

		public override float VisionScore
		{
			get
			{
				return __index11Value;
			}
			set
			{
				__index11Value = value;
			}
		}

		public override IList<Spell>? Spells
		{
			get
			{
				return __index12Value;
			}
			set
			{
				__index12Value = value;
			}
		}

		public override IList<Item>? Items
		{
			get
			{
				return __index13Value;
			}
			set
			{
				__index13Value = value;
			}
		}

		public override IList<Perk>? Perks
		{
			get
			{
				return __index14Value;
			}
			set
			{
				__index14Value = value;
			}
		}

		public override IList<Bone>? Bones
		{
			get
			{
				return __index15Value;
			}
			set
			{
				__index15Value = value;
			}
		}

		public override CharacterStats? CharacterStats
		{
			get
			{
				return __index16Value;
			}
			set
			{
				__index16Value = value;
			}
		}

		public override int LaneMinionKills
		{
			get
			{
				return __index17Value;
			}
			set
			{
				__index17Value = value;
			}
		}

		public override int NeutralMinionKills
		{
			get
			{
				return __index18Value;
			}
			set
			{
				__index18Value = value;
			}
		}

		public override int Kills
		{
			get
			{
				return __index19Value;
			}
			set
			{
				__index19Value = value;
			}
		}

		public override int Deaths
		{
			get
			{
				return __index20Value;
			}
			set
			{
				__index20Value = value;
			}
		}

		public override int Assists
		{
			get
			{
				return __index21Value;
			}
			set
			{
				__index21Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_2616b691b4e642c4821991dddba45d45_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTableGeneric.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, item, remainingDepth);
			__index8Value = ReadIndex8Value(buffer, offset, item, remainingDepth);
			__index9Value = ReadIndex9Value(buffer, offset, item, remainingDepth);
			__index10Value = ReadIndex10Value(buffer, offset, item, remainingDepth);
			__index11Value = ReadIndex11Value(buffer, offset, item, remainingDepth);
			__index12Value = ReadIndex12Value(buffer, offset, item, remainingDepth);
			__index13Value = ReadIndex13Value(buffer, offset, item, remainingDepth);
			__index14Value = ReadIndex14Value(buffer, offset, item, remainingDepth);
			__index15Value = ReadIndex15Value(buffer, offset, item, remainingDepth);
			__index16Value = ReadIndex16Value(buffer, offset, item, remainingDepth);
			__index17Value = ReadIndex17Value(buffer, offset, item, remainingDepth);
			__index18Value = ReadIndex18Value(buffer, offset, item, remainingDepth);
			__index19Value = ReadIndex19Value(buffer, offset, item, remainingDepth);
			__index20Value = ReadIndex20Value(buffer, offset, item, remainingDepth);
			__index21Value = ReadIndex21Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ObjectInfo ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Info");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIClient ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Spell>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NAA27A09FECA849BD7156BB91850E529E3ACD19F4F8C6D751D4175AA2651D435F.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Spells);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Item>? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NEF88E318D74773E248F3B5DC745DB08D7035C1A26A00128363EF6497481C464D.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Items);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Perk>? ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCB9A05B20B7639A9A58B77F9C00C0571BB27E6890B624889D9DCDA22D0460C4C.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Perks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Bone>? ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_2278fc1e1dc14152812152f58042b308.Bones);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CharacterStats? ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N6B63659726E72392160CE97102BBB138B1F009FAC2E45D58F8BFE0CF8A0C66EC.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_2278fc1e1dc14152812152f58042b308
	{
		public static readonly TableFieldContext Info = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Info", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Common = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Common", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext HeroIndex = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.HeroIndex", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext RespawnTime = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.RespawnTime", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Gold = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Gold", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext TotalGold = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.TotalGold", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext GoldGivenOnDeath = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.GoldGivenOnDeath", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Experience = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Experience", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Resource = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Resource", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext MaxResource = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.MaxResource", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ResourceType = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.ResourceType", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext VisionScore = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.VisionScore", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Spells = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Spells", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Items = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Items", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Perks = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Perks", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Bones = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Bones", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext CharacterStats = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.CharacterStats", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext LaneMinionKills = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.LaneMinionKills", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext NeutralMinionKills = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.NeutralMinionKills", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Kills = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Kills", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Deaths = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Deaths", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Assists = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Assists", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(AIHeroClient value)
	{
		int num = 204;
		ObjectInfo info = value.Info;
		if ((object)info != null)
		{
			num += FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.GetMaxSize(info);
		}
		AIClient common = value.Common;
		if (common != null)
		{
			num += FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.GetMaxSize(common);
		}
		IList<Spell> spells = value.Spells;
		if (spells != null)
		{
			num += FlatSharp.Compiler.Generated.NAA27A09FECA849BD7156BB91850E529E3ACD19F4F8C6D751D4175AA2651D435F.Helpers.GetMaxSize(spells);
		}
		IList<Item> items = value.Items;
		if (items != null)
		{
			num += FlatSharp.Compiler.Generated.NEF88E318D74773E248F3B5DC745DB08D7035C1A26A00128363EF6497481C464D.Helpers.GetMaxSize(items);
		}
		IList<Perk> perks = value.Perks;
		if (perks != null)
		{
			num += FlatSharp.Compiler.Generated.NCB9A05B20B7639A9A58B77F9C00C0571BB27E6890B624889D9DCDA22D0460C4C.Helpers.GetMaxSize(perks);
		}
		IList<Bone> bones = value.Bones;
		if (bones != null)
		{
			num += FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.GetMaxSize(bones);
		}
		CharacterStats characterStats = value.CharacterStats;
		if (characterStats != null)
		{
			num += FlatSharp.Compiler.Generated.N6B63659726E72392160CE97102BBB138B1F009FAC2E45D58F8BFE0CF8A0C66EC.Helpers.GetMaxSize(characterStats);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AIHeroClient value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(152, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 8;
		Span<byte> span2 = stackalloc byte[48];
		ObjectInfo info = value.Info;
		AIClient common = value.Common;
		uint heroIndex = value.HeroIndex;
		float respawnTime = value.RespawnTime;
		float gold = value.Gold;
		float totalGold = value.TotalGold;
		float goldGivenOnDeath = value.GoldGivenOnDeath;
		float experience = value.Experience;
		float resource = value.Resource;
		float maxResource = value.MaxResource;
		byte resourceType = value.ResourceType;
		float visionScore = value.VisionScore;
		IList<Spell> spells = value.Spells;
		IList<Item> items = value.Items;
		IList<Perk> perks = value.Perks;
		IList<Bone> bones = value.Bones;
		CharacterStats characterStats = value.CharacterStats;
		int laneMinionKills = value.LaneMinionKills;
		int neutralMinionKills = value.NeutralMinionKills;
		int kills = value.Kills;
		int deaths = value.Deaths;
		int assists = value.Assists;
		int num4 = num;
		if (assists != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, assists, num4);
			num3 = 48;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 46);
		int num5 = num;
		if (deaths != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, deaths, num5);
			if (46 > num3)
			{
				num3 = 46;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 44);
		int num6 = num;
		if (kills != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, kills, num6);
			if (44 > num3)
			{
				num3 = 44;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 42);
		int num7 = num;
		if (neutralMinionKills != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, neutralMinionKills, num7);
			if (42 > num3)
			{
				num3 = 42;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 40);
		int num8 = num;
		if (laneMinionKills != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, laneMinionKills, num8);
			if (40 > num3)
			{
				num3 = 40;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 38);
		int num9 = num;
		if (characterStats != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			if (38 > num3)
			{
				num3 = 38;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 36);
		int num10 = num;
		if (bones != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
			if (36 > num3)
			{
				num3 = 36;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 34);
		int num11 = num;
		if (perks != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num11 = num2;
			num2 += 4;
			if (34 > num3)
			{
				num3 = 34;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 32);
		int num12 = num;
		if (items != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num12 = num2;
			num2 += 4;
			if (32 > num3)
			{
				num3 = 32;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 30);
		int num13 = num;
		if (spells != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num13 = num2;
			num2 += 4;
			if (30 > num3)
			{
				num3 = 30;
			}
		}
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)(num13 - num), 28);
		int num14 = num;
		if (visionScore != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num14 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, visionScore, num14);
			if (28 > num3)
			{
				num3 = 28;
			}
		}
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)(num14 - num), 26);
		int num15 = num;
		if (maxResource != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num15 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, maxResource, num15);
			if (24 > num3)
			{
				num3 = 24;
			}
		}
		Span<byte> span14 = span2;
		spanWriter.WriteUShort(span14, (ushort)(num15 - num), 22);
		int num16 = num;
		if (resource != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num16 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, resource, num16);
			if (22 > num3)
			{
				num3 = 22;
			}
		}
		Span<byte> span15 = span2;
		spanWriter.WriteUShort(span15, (ushort)(num16 - num), 20);
		int num17 = num;
		if (experience != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num17 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, experience, num17);
			if (20 > num3)
			{
				num3 = 20;
			}
		}
		Span<byte> span16 = span2;
		spanWriter.WriteUShort(span16, (ushort)(num17 - num), 18);
		int num18 = num;
		if (goldGivenOnDeath != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num18 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, goldGivenOnDeath, num18);
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span17 = span2;
		spanWriter.WriteUShort(span17, (ushort)(num18 - num), 16);
		int num19 = num;
		if (totalGold != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num19 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, totalGold, num19);
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span18 = span2;
		spanWriter.WriteUShort(span18, (ushort)(num19 - num), 14);
		int num20 = num;
		if (gold != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num20 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, gold, num20);
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span19 = span2;
		spanWriter.WriteUShort(span19, (ushort)(num20 - num), 12);
		int num21 = num;
		if (respawnTime != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num21 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, respawnTime, num21);
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span20 = span2;
		spanWriter.WriteUShort(span20, (ushort)(num21 - num), 10);
		int num22 = num;
		if (heroIndex != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num22 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span, heroIndex, num22);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span21 = span2;
		spanWriter.WriteUShort(span21, (ushort)(num22 - num), 8);
		int num23 = num;
		if (common != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num23 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Common");
		}
		Span<byte> span22 = span2;
		spanWriter.WriteUShort(span22, (ushort)(num23 - num), 6);
		int num24 = num;
		if ((object)info != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num24 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIHeroClient.Info");
		}
		Span<byte> span23 = span2;
		spanWriter.WriteUShort(span23, (ushort)(num24 - num), 4);
		int num25 = num;
		if (resourceType != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num25 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span, resourceType, num25);
			if (26 > num3)
			{
				num3 = 26;
			}
		}
		Span<byte> span24 = span2;
		spanWriter.WriteUShort(span24, (ushort)(num25 - num), 24);
		int num26 = num2 - num;
		context.Offset -= 152 - num26;
		Span<byte> span25 = span2;
		spanWriter.WriteUShort(span25, (ushort)num3, 0);
		Span<byte> span26 = span2;
		spanWriter.WriteUShort(span26, (ushort)num26, 2);
		int num27 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num27, num);
		if (num9 != num)
		{
			FlatSharp.Compiler.Generated.N6B63659726E72392160CE97102BBB138B1F009FAC2E45D58F8BFE0CF8A0C66EC.Helpers.Serialize(spanWriter, span, characterStats, num9, context);
		}
		if (num10 != num)
		{
			FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.Serialize(spanWriter, span, bones, num10, context);
		}
		if (num11 != num)
		{
			FlatSharp.Compiler.Generated.NCB9A05B20B7639A9A58B77F9C00C0571BB27E6890B624889D9DCDA22D0460C4C.Helpers.Serialize(spanWriter, span, perks, num11, context);
		}
		if (num12 != num)
		{
			FlatSharp.Compiler.Generated.NEF88E318D74773E248F3B5DC745DB08D7035C1A26A00128363EF6497481C464D.Helpers.Serialize(spanWriter, span, items, num12, context);
		}
		if (num13 != num)
		{
			FlatSharp.Compiler.Generated.NAA27A09FECA849BD7156BB91850E529E3ACD19F4F8C6D751D4175AA2651D435F.Helpers.Serialize(spanWriter, span, spells, num13, context);
		}
		if (num23 != num)
		{
			FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Serialize(spanWriter, span, common, num23, context);
		}
		if (num24 != num)
		{
			FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Serialize(spanWriter, span, info, num24, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_2616b691b4e642c4821991dddba45d45_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_2616b691b4e642c4821991dddba45d45_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_2616b691b4e642c4821991dddba45d45_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_2616b691b4e642c4821991dddba45d45_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_2616b691b4e642c4821991dddba45d45_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_2616b691b4e642c4821991dddba45d45_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_2616b691b4e642c4821991dddba45d45_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
