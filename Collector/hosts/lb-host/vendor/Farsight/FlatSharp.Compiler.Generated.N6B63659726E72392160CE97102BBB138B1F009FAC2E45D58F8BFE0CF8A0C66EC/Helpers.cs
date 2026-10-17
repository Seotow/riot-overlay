using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N6B63659726E72392160CE97102BBB138B1F009FAC2E45D58F8BFE0CF8A0C66EC;

internal static class Helpers
{
	[DebuggerDisplay("Lazy CharacterStats")]
	internal sealed class tableReader_58c870b402cc4395beb845171c095e01_Lazy<TInputBuffer> : CharacterStats, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CharacterStats);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override float AttackSpeedMod
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

		public override float PercentAttackSpeedMod
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

		public override float PercentMultiplicativeAttackSpeedMod
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

		public override float BaseAttackDamage
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

		public override float FlatPhysicalDamageMod
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

		public override float PercentPhysicalDamageMod
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

		public override float Crit
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

		public override float CritDamageMultiplier
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

		public override float AttackRange
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

		public override float FlatMagicDamageMod
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

		public override float PercentMagicDamageMod
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

		public override float AbilityHasteMod
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

		public override float PhysicalLethality
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

		public override float FlatArmorPenetration
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

		public override float PercentArmorPenetration
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

		public override float PercentBonusArmorPenetration
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

		public override float MagicLethality
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

		public override float FlatMagicPenetration
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

		public override float PercentMagicPenetration
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

		public override float PercentBonusMagicPenetration
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

		public override float PercentLifeStealMod
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

		public override float PercentSpellVampMod
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

		public override float PercentPhysicalVamp
		{
			get
			{
				return ReadIndex22Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float PercentOmnivampMod
		{
			get
			{
				return ReadIndex23Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Armor
		{
			get
			{
				return ReadIndex24Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float BonusArmor
		{
			get
			{
				return ReadIndex25Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float SpellBlock
		{
			get
			{
				return ReadIndex26Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float BonusSpellBlock
		{
			get
			{
				return ReadIndex27Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float FlatMagicReduction
		{
			get
			{
				return ReadIndex28Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float PercentMagicReduction
		{
			get
			{
				return ReadIndex29Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float HpRegenRate
		{
			get
			{
				return ReadIndex30Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ParRegenRate
		{
			get
			{
				return ReadIndex31Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float PercentCcReduction
		{
			get
			{
				return ReadIndex32Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_58c870b402cc4395beb845171c095e01_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static float ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static float ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex29Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 29);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex30Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 30);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex31Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 31);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex32Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 32);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive CharacterStats")]
	internal sealed class tableReader_58c870b402cc4395beb845171c095e01_Progressive<TInputBuffer> : CharacterStats, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private float __index0Value;

		private float __index1Value;

		private float __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private float __index7Value;

		private byte __mask1;

		private float __index8Value;

		private float __index9Value;

		private float __index10Value;

		private float __index11Value;

		private float __index12Value;

		private float __index13Value;

		private float __index14Value;

		private float __index15Value;

		private byte __mask2;

		private float __index16Value;

		private float __index17Value;

		private float __index18Value;

		private float __index19Value;

		private float __index20Value;

		private float __index21Value;

		private float __index22Value;

		private float __index23Value;

		private byte __mask3;

		private float __index24Value;

		private float __index25Value;

		private float __index26Value;

		private float __index27Value;

		private float __index28Value;

		private float __index29Value;

		private float __index30Value;

		private float __index31Value;

		private byte __mask4;

		private float __index32Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CharacterStats);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override float AttackSpeedMod
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

		public override float PercentAttackSpeedMod
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

		public override float PercentMultiplicativeAttackSpeedMod
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

		public override float BaseAttackDamage
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

		public override float FlatPhysicalDamageMod
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

		public override float PercentPhysicalDamageMod
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

		public override float Crit
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

		public override float CritDamageMultiplier
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

		public override float AttackRange
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

		public override float FlatMagicDamageMod
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

		public override float PercentMagicDamageMod
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

		public override float AbilityHasteMod
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

		public override float PhysicalLethality
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

		public override float FlatArmorPenetration
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

		public override float PercentArmorPenetration
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

		public override float PercentBonusArmorPenetration
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

		public override float MagicLethality
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

		public override float FlatMagicPenetration
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

		public override float PercentMagicPenetration
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

		public override float PercentBonusMagicPenetration
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

		public override float PercentLifeStealMod
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

		public override float PercentSpellVampMod
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

		public override float PercentPhysicalVamp
		{
			get
			{
				if ((__mask2 & 0x40) == 0)
				{
					__index22Value = ReadIndex22Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 64);
				}
				return __index22Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float PercentOmnivampMod
		{
			get
			{
				if ((__mask2 & 0x80) == 0)
				{
					__index23Value = ReadIndex23Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 128);
				}
				return __index23Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Armor
		{
			get
			{
				if ((__mask3 & 1) == 0)
				{
					__index24Value = ReadIndex24Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 1);
				}
				return __index24Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float BonusArmor
		{
			get
			{
				if ((__mask3 & 2) == 0)
				{
					__index25Value = ReadIndex25Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 2);
				}
				return __index25Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float SpellBlock
		{
			get
			{
				if ((__mask3 & 4) == 0)
				{
					__index26Value = ReadIndex26Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 4);
				}
				return __index26Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float BonusSpellBlock
		{
			get
			{
				if ((__mask3 & 8) == 0)
				{
					__index27Value = ReadIndex27Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 8);
				}
				return __index27Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float FlatMagicReduction
		{
			get
			{
				if ((__mask3 & 0x10) == 0)
				{
					__index28Value = ReadIndex28Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 16);
				}
				return __index28Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float PercentMagicReduction
		{
			get
			{
				if ((__mask3 & 0x20) == 0)
				{
					__index29Value = ReadIndex29Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 32);
				}
				return __index29Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float HpRegenRate
		{
			get
			{
				if ((__mask3 & 0x40) == 0)
				{
					__index30Value = ReadIndex30Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 64);
				}
				return __index30Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ParRegenRate
		{
			get
			{
				if ((__mask3 & 0x80) == 0)
				{
					__index31Value = ReadIndex31Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 128);
				}
				return __index31Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float PercentCcReduction
		{
			get
			{
				if ((__mask4 & 1) == 0)
				{
					__index32Value = ReadIndex32Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 1);
				}
				return __index32Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_58c870b402cc4395beb845171c095e01_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static float ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static float ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex29Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 29);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex30Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 30);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex31Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 31);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex32Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 32);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy CharacterStats")]
	internal sealed class tableReader_58c870b402cc4395beb845171c095e01_Greedy<TInputBuffer> : CharacterStats, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private float __index0Value;

		private float __index1Value;

		private float __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private float __index7Value;

		private float __index8Value;

		private float __index9Value;

		private float __index10Value;

		private float __index11Value;

		private float __index12Value;

		private float __index13Value;

		private float __index14Value;

		private float __index15Value;

		private float __index16Value;

		private float __index17Value;

		private float __index18Value;

		private float __index19Value;

		private float __index20Value;

		private float __index21Value;

		private float __index22Value;

		private float __index23Value;

		private float __index24Value;

		private float __index25Value;

		private float __index26Value;

		private float __index27Value;

		private float __index28Value;

		private float __index29Value;

		private float __index30Value;

		private float __index31Value;

		private float __index32Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CharacterStats);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override float AttackSpeedMod
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

		public override float PercentAttackSpeedMod
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

		public override float PercentMultiplicativeAttackSpeedMod
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

		public override float BaseAttackDamage
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

		public override float FlatPhysicalDamageMod
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

		public override float PercentPhysicalDamageMod
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

		public override float Crit
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

		public override float CritDamageMultiplier
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

		public override float AttackRange
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

		public override float FlatMagicDamageMod
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

		public override float PercentMagicDamageMod
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

		public override float AbilityHasteMod
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

		public override float PhysicalLethality
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

		public override float FlatArmorPenetration
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

		public override float PercentArmorPenetration
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

		public override float PercentBonusArmorPenetration
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

		public override float MagicLethality
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

		public override float FlatMagicPenetration
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

		public override float PercentMagicPenetration
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

		public override float PercentBonusMagicPenetration
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

		public override float PercentLifeStealMod
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

		public override float PercentSpellVampMod
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

		public override float PercentPhysicalVamp
		{
			get
			{
				return __index22Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float PercentOmnivampMod
		{
			get
			{
				return __index23Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Armor
		{
			get
			{
				return __index24Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float BonusArmor
		{
			get
			{
				return __index25Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float SpellBlock
		{
			get
			{
				return __index26Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float BonusSpellBlock
		{
			get
			{
				return __index27Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float FlatMagicReduction
		{
			get
			{
				return __index28Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float PercentMagicReduction
		{
			get
			{
				return __index29Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float HpRegenRate
		{
			get
			{
				return __index30Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ParRegenRate
		{
			get
			{
				return __index31Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float PercentCcReduction
		{
			get
			{
				return __index32Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_58c870b402cc4395beb845171c095e01_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
			__index22Value = ReadIndex22Value(buffer, offset, item, remainingDepth);
			__index23Value = ReadIndex23Value(buffer, offset, item, remainingDepth);
			__index24Value = ReadIndex24Value(buffer, offset, item, remainingDepth);
			__index25Value = ReadIndex25Value(buffer, offset, item, remainingDepth);
			__index26Value = ReadIndex26Value(buffer, offset, item, remainingDepth);
			__index27Value = ReadIndex27Value(buffer, offset, item, remainingDepth);
			__index28Value = ReadIndex28Value(buffer, offset, item, remainingDepth);
			__index29Value = ReadIndex29Value(buffer, offset, item, remainingDepth);
			__index30Value = ReadIndex30Value(buffer, offset, item, remainingDepth);
			__index31Value = ReadIndex31Value(buffer, offset, item, remainingDepth);
			__index32Value = ReadIndex32Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static float ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static float ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex29Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 29);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex30Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 30);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex31Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 31);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex32Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 32);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable CharacterStats")]
	internal sealed class tableReader_58c870b402cc4395beb845171c095e01_GreedyMutable<TInputBuffer> : CharacterStats, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private float __index0Value;

		private float __index1Value;

		private float __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private float __index7Value;

		private float __index8Value;

		private float __index9Value;

		private float __index10Value;

		private float __index11Value;

		private float __index12Value;

		private float __index13Value;

		private float __index14Value;

		private float __index15Value;

		private float __index16Value;

		private float __index17Value;

		private float __index18Value;

		private float __index19Value;

		private float __index20Value;

		private float __index21Value;

		private float __index22Value;

		private float __index23Value;

		private float __index24Value;

		private float __index25Value;

		private float __index26Value;

		private float __index27Value;

		private float __index28Value;

		private float __index29Value;

		private float __index30Value;

		private float __index31Value;

		private float __index32Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CharacterStats);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override float AttackSpeedMod
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

		public override float PercentAttackSpeedMod
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

		public override float PercentMultiplicativeAttackSpeedMod
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

		public override float BaseAttackDamage
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

		public override float FlatPhysicalDamageMod
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

		public override float PercentPhysicalDamageMod
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

		public override float Crit
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

		public override float CritDamageMultiplier
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

		public override float AttackRange
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

		public override float FlatMagicDamageMod
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

		public override float PercentMagicDamageMod
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

		public override float AbilityHasteMod
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

		public override float PhysicalLethality
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

		public override float FlatArmorPenetration
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

		public override float PercentArmorPenetration
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

		public override float PercentBonusArmorPenetration
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

		public override float MagicLethality
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

		public override float FlatMagicPenetration
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

		public override float PercentMagicPenetration
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

		public override float PercentBonusMagicPenetration
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

		public override float PercentLifeStealMod
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

		public override float PercentSpellVampMod
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

		public override float PercentPhysicalVamp
		{
			get
			{
				return __index22Value;
			}
			set
			{
				__index22Value = value;
			}
		}

		public override float PercentOmnivampMod
		{
			get
			{
				return __index23Value;
			}
			set
			{
				__index23Value = value;
			}
		}

		public override float Armor
		{
			get
			{
				return __index24Value;
			}
			set
			{
				__index24Value = value;
			}
		}

		public override float BonusArmor
		{
			get
			{
				return __index25Value;
			}
			set
			{
				__index25Value = value;
			}
		}

		public override float SpellBlock
		{
			get
			{
				return __index26Value;
			}
			set
			{
				__index26Value = value;
			}
		}

		public override float BonusSpellBlock
		{
			get
			{
				return __index27Value;
			}
			set
			{
				__index27Value = value;
			}
		}

		public override float FlatMagicReduction
		{
			get
			{
				return __index28Value;
			}
			set
			{
				__index28Value = value;
			}
		}

		public override float PercentMagicReduction
		{
			get
			{
				return __index29Value;
			}
			set
			{
				__index29Value = value;
			}
		}

		public override float HpRegenRate
		{
			get
			{
				return __index30Value;
			}
			set
			{
				__index30Value = value;
			}
		}

		public override float ParRegenRate
		{
			get
			{
				return __index31Value;
			}
			set
			{
				__index31Value = value;
			}
		}

		public override float PercentCcReduction
		{
			get
			{
				return __index32Value;
			}
			set
			{
				__index32Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_58c870b402cc4395beb845171c095e01_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
			__index22Value = ReadIndex22Value(buffer, offset, item, remainingDepth);
			__index23Value = ReadIndex23Value(buffer, offset, item, remainingDepth);
			__index24Value = ReadIndex24Value(buffer, offset, item, remainingDepth);
			__index25Value = ReadIndex25Value(buffer, offset, item, remainingDepth);
			__index26Value = ReadIndex26Value(buffer, offset, item, remainingDepth);
			__index27Value = ReadIndex27Value(buffer, offset, item, remainingDepth);
			__index28Value = ReadIndex28Value(buffer, offset, item, remainingDepth);
			__index29Value = ReadIndex29Value(buffer, offset, item, remainingDepth);
			__index30Value = ReadIndex30Value(buffer, offset, item, remainingDepth);
			__index31Value = ReadIndex31Value(buffer, offset, item, remainingDepth);
			__index32Value = ReadIndex32Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static float ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static float ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex29Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 29);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex30Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 30);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex31Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 31);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex32Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 32);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_0bed93d319494e9889b1796e35d552a4
	{
		public static readonly TableFieldContext AttackSpeedMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.AttackSpeedMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentAttackSpeedMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentAttackSpeedMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentMultiplicativeAttackSpeedMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentMultiplicativeAttackSpeedMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BaseAttackDamage = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.BaseAttackDamage", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FlatPhysicalDamageMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.FlatPhysicalDamageMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentPhysicalDamageMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentPhysicalDamageMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Crit = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.Crit", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext CritDamageMultiplier = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.CritDamageMultiplier", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AttackRange = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.AttackRange", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FlatMagicDamageMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.FlatMagicDamageMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentMagicDamageMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentMagicDamageMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AbilityHasteMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.AbilityHasteMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PhysicalLethality = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PhysicalLethality", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FlatArmorPenetration = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.FlatArmorPenetration", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentArmorPenetration = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentArmorPenetration", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentBonusArmorPenetration = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentBonusArmorPenetration", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext MagicLethality = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.MagicLethality", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FlatMagicPenetration = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.FlatMagicPenetration", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentMagicPenetration = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentMagicPenetration", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentBonusMagicPenetration = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentBonusMagicPenetration", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentLifeStealMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentLifeStealMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentSpellVampMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentSpellVampMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentPhysicalVamp = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentPhysicalVamp", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentOmnivampMod = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentOmnivampMod", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Armor = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.Armor", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BonusArmor = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.BonusArmor", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SpellBlock = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.SpellBlock", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BonusSpellBlock = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.BonusSpellBlock", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FlatMagicReduction = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.FlatMagicReduction", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentMagicReduction = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentMagicReduction", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext HpRegenRate = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.HpRegenRate", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ParRegenRate = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.ParRegenRate", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PercentCcReduction = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.CharacterStats.PercentCcReduction", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(CharacterStats value)
	{
		return 309;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CharacterStats value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(235, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[70];
		float attackSpeedMod = value.AttackSpeedMod;
		float percentAttackSpeedMod = value.PercentAttackSpeedMod;
		float percentMultiplicativeAttackSpeedMod = value.PercentMultiplicativeAttackSpeedMod;
		float baseAttackDamage = value.BaseAttackDamage;
		float flatPhysicalDamageMod = value.FlatPhysicalDamageMod;
		float percentPhysicalDamageMod = value.PercentPhysicalDamageMod;
		float crit = value.Crit;
		float critDamageMultiplier = value.CritDamageMultiplier;
		float attackRange = value.AttackRange;
		float flatMagicDamageMod = value.FlatMagicDamageMod;
		float percentMagicDamageMod = value.PercentMagicDamageMod;
		float abilityHasteMod = value.AbilityHasteMod;
		float physicalLethality = value.PhysicalLethality;
		float flatArmorPenetration = value.FlatArmorPenetration;
		float percentArmorPenetration = value.PercentArmorPenetration;
		float percentBonusArmorPenetration = value.PercentBonusArmorPenetration;
		float magicLethality = value.MagicLethality;
		float flatMagicPenetration = value.FlatMagicPenetration;
		float percentMagicPenetration = value.PercentMagicPenetration;
		float percentBonusMagicPenetration = value.PercentBonusMagicPenetration;
		float percentLifeStealMod = value.PercentLifeStealMod;
		float percentSpellVampMod = value.PercentSpellVampMod;
		float percentPhysicalVamp = value.PercentPhysicalVamp;
		float percentOmnivampMod = value.PercentOmnivampMod;
		float armor = value.Armor;
		float bonusArmor = value.BonusArmor;
		float spellBlock = value.SpellBlock;
		float bonusSpellBlock = value.BonusSpellBlock;
		float flatMagicReduction = value.FlatMagicReduction;
		float percentMagicReduction = value.PercentMagicReduction;
		float hpRegenRate = value.HpRegenRate;
		float parRegenRate = value.ParRegenRate;
		float percentCcReduction = value.PercentCcReduction;
		int num4 = num;
		if (percentCcReduction != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentCcReduction, num4);
			num3 = 70;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 68);
		int num5 = num;
		if (parRegenRate != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, parRegenRate, num5);
			if (68 > num3)
			{
				num3 = 68;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 66);
		int num6 = num;
		if (hpRegenRate != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, hpRegenRate, num6);
			if (66 > num3)
			{
				num3 = 66;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 64);
		int num7 = num;
		if (percentMagicReduction != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentMagicReduction, num7);
			if (64 > num3)
			{
				num3 = 64;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 62);
		int num8 = num;
		if (flatMagicReduction != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, flatMagicReduction, num8);
			if (62 > num3)
			{
				num3 = 62;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 60);
		int num9 = num;
		if (bonusSpellBlock != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, bonusSpellBlock, num9);
			if (60 > num3)
			{
				num3 = 60;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 58);
		int num10 = num;
		if (spellBlock != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, spellBlock, num10);
			if (58 > num3)
			{
				num3 = 58;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 56);
		int num11 = num;
		if (bonusArmor != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num11 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, bonusArmor, num11);
			if (56 > num3)
			{
				num3 = 56;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 54);
		int num12 = num;
		if (armor != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num12 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, armor, num12);
			if (54 > num3)
			{
				num3 = 54;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 52);
		int num13 = num;
		if (percentOmnivampMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num13 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentOmnivampMod, num13);
			if (52 > num3)
			{
				num3 = 52;
			}
		}
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)(num13 - num), 50);
		int num14 = num;
		if (percentPhysicalVamp != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num14 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentPhysicalVamp, num14);
			if (50 > num3)
			{
				num3 = 50;
			}
		}
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)(num14 - num), 48);
		int num15 = num;
		if (percentSpellVampMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num15 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentSpellVampMod, num15);
			if (48 > num3)
			{
				num3 = 48;
			}
		}
		Span<byte> span14 = span2;
		spanWriter.WriteUShort(span14, (ushort)(num15 - num), 46);
		int num16 = num;
		if (percentLifeStealMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num16 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentLifeStealMod, num16);
			if (46 > num3)
			{
				num3 = 46;
			}
		}
		Span<byte> span15 = span2;
		spanWriter.WriteUShort(span15, (ushort)(num16 - num), 44);
		int num17 = num;
		if (percentBonusMagicPenetration != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num17 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentBonusMagicPenetration, num17);
			if (44 > num3)
			{
				num3 = 44;
			}
		}
		Span<byte> span16 = span2;
		spanWriter.WriteUShort(span16, (ushort)(num17 - num), 42);
		int num18 = num;
		if (percentMagicPenetration != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num18 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentMagicPenetration, num18);
			if (42 > num3)
			{
				num3 = 42;
			}
		}
		Span<byte> span17 = span2;
		spanWriter.WriteUShort(span17, (ushort)(num18 - num), 40);
		int num19 = num;
		if (flatMagicPenetration != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num19 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, flatMagicPenetration, num19);
			if (40 > num3)
			{
				num3 = 40;
			}
		}
		Span<byte> span18 = span2;
		spanWriter.WriteUShort(span18, (ushort)(num19 - num), 38);
		int num20 = num;
		if (magicLethality != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num20 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, magicLethality, num20);
			if (38 > num3)
			{
				num3 = 38;
			}
		}
		Span<byte> span19 = span2;
		spanWriter.WriteUShort(span19, (ushort)(num20 - num), 36);
		int num21 = num;
		if (percentBonusArmorPenetration != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num21 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentBonusArmorPenetration, num21);
			if (36 > num3)
			{
				num3 = 36;
			}
		}
		Span<byte> span20 = span2;
		spanWriter.WriteUShort(span20, (ushort)(num21 - num), 34);
		int num22 = num;
		if (percentArmorPenetration != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num22 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentArmorPenetration, num22);
			if (34 > num3)
			{
				num3 = 34;
			}
		}
		Span<byte> span21 = span2;
		spanWriter.WriteUShort(span21, (ushort)(num22 - num), 32);
		int num23 = num;
		if (flatArmorPenetration != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num23 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, flatArmorPenetration, num23);
			if (32 > num3)
			{
				num3 = 32;
			}
		}
		Span<byte> span22 = span2;
		spanWriter.WriteUShort(span22, (ushort)(num23 - num), 30);
		int num24 = num;
		if (physicalLethality != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num24 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, physicalLethality, num24);
			if (30 > num3)
			{
				num3 = 30;
			}
		}
		Span<byte> span23 = span2;
		spanWriter.WriteUShort(span23, (ushort)(num24 - num), 28);
		int num25 = num;
		if (abilityHasteMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num25 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, abilityHasteMod, num25);
			if (28 > num3)
			{
				num3 = 28;
			}
		}
		Span<byte> span24 = span2;
		spanWriter.WriteUShort(span24, (ushort)(num25 - num), 26);
		int num26 = num;
		if (percentMagicDamageMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num26 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentMagicDamageMod, num26);
			if (26 > num3)
			{
				num3 = 26;
			}
		}
		Span<byte> span25 = span2;
		spanWriter.WriteUShort(span25, (ushort)(num26 - num), 24);
		int num27 = num;
		if (flatMagicDamageMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num27 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, flatMagicDamageMod, num27);
			if (24 > num3)
			{
				num3 = 24;
			}
		}
		Span<byte> span26 = span2;
		spanWriter.WriteUShort(span26, (ushort)(num27 - num), 22);
		int num28 = num;
		if (attackRange != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num28 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, attackRange, num28);
			if (22 > num3)
			{
				num3 = 22;
			}
		}
		Span<byte> span27 = span2;
		spanWriter.WriteUShort(span27, (ushort)(num28 - num), 20);
		int num29 = num;
		if (critDamageMultiplier != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num29 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, critDamageMultiplier, num29);
			if (20 > num3)
			{
				num3 = 20;
			}
		}
		Span<byte> span28 = span2;
		spanWriter.WriteUShort(span28, (ushort)(num29 - num), 18);
		int num30 = num;
		if (crit != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num30 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, crit, num30);
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span29 = span2;
		spanWriter.WriteUShort(span29, (ushort)(num30 - num), 16);
		int num31 = num;
		if (percentPhysicalDamageMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num31 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentPhysicalDamageMod, num31);
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span30 = span2;
		spanWriter.WriteUShort(span30, (ushort)(num31 - num), 14);
		int num32 = num;
		if (flatPhysicalDamageMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num32 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, flatPhysicalDamageMod, num32);
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span31 = span2;
		spanWriter.WriteUShort(span31, (ushort)(num32 - num), 12);
		int num33 = num;
		if (baseAttackDamage != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num33 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, baseAttackDamage, num33);
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span32 = span2;
		spanWriter.WriteUShort(span32, (ushort)(num33 - num), 10);
		int num34 = num;
		if (percentMultiplicativeAttackSpeedMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num34 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentMultiplicativeAttackSpeedMod, num34);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span33 = span2;
		spanWriter.WriteUShort(span33, (ushort)(num34 - num), 8);
		int num35 = num;
		if (percentAttackSpeedMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num35 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, percentAttackSpeedMod, num35);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span34 = span2;
		spanWriter.WriteUShort(span34, (ushort)(num35 - num), 6);
		int num36 = num;
		if (attackSpeedMod != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num36 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, attackSpeedMod, num36);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span35 = span2;
		spanWriter.WriteUShort(span35, (ushort)(num36 - num), 4);
		int num37 = num2 - num;
		context.Offset -= 235 - num37;
		Span<byte> span36 = span2;
		spanWriter.WriteUShort(span36, (ushort)num3, 0);
		Span<byte> span37 = span2;
		spanWriter.WriteUShort(span37, (ushort)num37, 2);
		int num38 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num38, num);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_58c870b402cc4395beb845171c095e01_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_58c870b402cc4395beb845171c095e01_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_58c870b402cc4395beb845171c095e01_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_58c870b402cc4395beb845171c095e01_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_58c870b402cc4395beb845171c095e01_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_58c870b402cc4395beb845171c095e01_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_58c870b402cc4395beb845171c095e01_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_58c870b402cc4395beb845171c095e01_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
