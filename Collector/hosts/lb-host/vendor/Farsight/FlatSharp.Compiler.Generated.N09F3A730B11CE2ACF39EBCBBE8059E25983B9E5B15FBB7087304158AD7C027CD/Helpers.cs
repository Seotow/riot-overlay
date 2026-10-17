using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N09F3A730B11CE2ACF39EBCBBE8059E25983B9E5B15FBB7087304158AD7C027CD;

internal static class Helpers
{
	[DebuggerDisplay("Lazy Spell")]
	internal sealed class tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Lazy<TInputBuffer> : Spell, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Spell);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override string? Name
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

		public override string? Icon
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

		public override float ReadyAt
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

		public override float MaxCooldown
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

		public override float AmmoReadyAt
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

		public override float AmmoCooldown
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

		public override float InitAtTime
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

		public override ushort Index
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

		public override byte Level
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

		public override byte AmmoCount
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

		public override float Cooldown
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

		public override bool IsToggled
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static ushort ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static bool ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive Spell")]
	internal sealed class tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer> : Spell, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private string? __index0Value;

		private string? __index1Value;

		private float __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private ushort __index7Value;

		private byte __mask1;

		private byte __index8Value;

		private byte __index9Value;

		private float __index10Value;

		private bool __index11Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Spell);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override string? Name
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

		public override string? Icon
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

		public override float ReadyAt
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

		public override float MaxCooldown
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

		public override float AmmoReadyAt
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

		public override float AmmoCooldown
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

		public override float InitAtTime
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

		public override ushort Index
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

		public override byte Level
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

		public override byte AmmoCount
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

		public override float Cooldown
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

		public override bool IsToggled
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static ushort ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static bool ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy Spell")]
	internal sealed class tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Greedy<TInputBuffer> : Spell, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private string? __index0Value;

		private string? __index1Value;

		private float __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private ushort __index7Value;

		private byte __index8Value;

		private byte __index9Value;

		private float __index10Value;

		private bool __index11Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Spell);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override string? Name
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

		public override string? Icon
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

		public override float ReadyAt
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

		public override float MaxCooldown
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

		public override float AmmoReadyAt
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

		public override float AmmoCooldown
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

		public override float InitAtTime
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

		public override ushort Index
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

		public override byte Level
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

		public override byte AmmoCount
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

		public override float Cooldown
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

		public override bool IsToggled
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static ushort ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static bool ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable Spell")]
	internal sealed class tableReader_e4ee032ba57540b3b3f1ae65891d4c73_GreedyMutable<TInputBuffer> : Spell, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private string? __index0Value;

		private string? __index1Value;

		private float __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private ushort __index7Value;

		private byte __index8Value;

		private byte __index9Value;

		private float __index10Value;

		private bool __index11Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Spell);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override string? Name
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

		public override string? Icon
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

		public override float ReadyAt
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

		public override float MaxCooldown
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

		public override float AmmoReadyAt
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

		public override float AmmoCooldown
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

		public override float InitAtTime
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

		public override ushort Index
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

		public override byte Level
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

		public override byte AmmoCount
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

		public override float Cooldown
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

		public override bool IsToggled
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_e4ee032ba57540b3b3f1ae65891d4c73_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static ushort ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static bool ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_fe4a0b2d094445cdb25f24938df9765e
	{
		public static readonly TableFieldContext Name = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.Name", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Icon = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.Icon", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ReadyAt = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.ReadyAt", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext MaxCooldown = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.MaxCooldown", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AmmoReadyAt = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.AmmoReadyAt", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AmmoCooldown = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.AmmoCooldown", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext InitAtTime = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.InitAtTime", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Index = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.Index", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Level = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.Level", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AmmoCount = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.AmmoCount", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Cooldown = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.Cooldown", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext IsToggled = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Spell.IsToggled", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(Spell value)
	{
		int num = 98;
		string name = value.Name;
		if (name != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(name);
		}
		string icon = value.Icon;
		if (icon != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(icon);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Spell value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(66, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[28];
		string name = value.Name;
		string icon = value.Icon;
		float readyAt = value.ReadyAt;
		float maxCooldown = value.MaxCooldown;
		float ammoReadyAt = value.AmmoReadyAt;
		float ammoCooldown = value.AmmoCooldown;
		float initAtTime = value.InitAtTime;
		ushort index = value.Index;
		byte level = value.Level;
		byte ammoCount = value.AmmoCount;
		float cooldown = value.Cooldown;
		bool isToggled = value.IsToggled;
		int num4 = num;
		if (cooldown != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, cooldown, num4);
			if (26 > num3)
			{
				num3 = 26;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 24);
		int num5 = num;
		if (initAtTime != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, initAtTime, num5);
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 16);
		int num6 = num;
		if (ammoCooldown != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, ammoCooldown, num6);
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 14);
		int num7 = num;
		if (ammoReadyAt != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, ammoReadyAt, num7);
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 12);
		int num8 = num;
		if (maxCooldown != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, maxCooldown, num8);
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 10);
		int num9 = num;
		if (readyAt != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, readyAt, num9);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 8);
		int num10 = num;
		if (icon != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 6);
		int num11 = num;
		if (name != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num11 = num2;
			num2 += 4;
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 4);
		int num12 = num;
		if (index != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 2);
			num12 = num2;
			num2 += 2;
			FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Serialize(spanWriter, span, index, num12);
			if (20 > num3)
			{
				num3 = 20;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 18);
		int num13 = num;
		if (isToggled)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num13 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, isToggled, num13);
			num3 = 28;
		}
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)(num13 - num), 26);
		int num14 = num;
		if (ammoCount != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num14 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span, ammoCount, num14);
			if (24 > num3)
			{
				num3 = 24;
			}
		}
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)(num14 - num), 22);
		int num15 = num;
		if (level != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num15 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span, level, num15);
			if (22 > num3)
			{
				num3 = 22;
			}
		}
		Span<byte> span14 = span2;
		spanWriter.WriteUShort(span14, (ushort)(num15 - num), 20);
		int num16 = num2 - num;
		context.Offset -= 66 - num16;
		Span<byte> span15 = span2;
		spanWriter.WriteUShort(span15, (ushort)num3, 0);
		Span<byte> span16 = span2;
		spanWriter.WriteUShort(span16, (ushort)num16, 2);
		int num17 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num17, num);
		if (num10 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, icon, num10, context, tableMetadata_fe4a0b2d094445cdb25f24938df9765e.Icon);
		}
		if (num11 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, name, num11, context, tableMetadata_fe4a0b2d094445cdb25f24938df9765e.Name);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_e4ee032ba57540b3b3f1ae65891d4c73_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_e4ee032ba57540b3b3f1ae65891d4c73_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_e4ee032ba57540b3b3f1ae65891d4c73_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
