using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797;
using FlatSharp.Compiler.Generated.N1E72B6587B7C01FD60DC9D6B042A9198862A69615CB1559A02E09DB41E0C2B65;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.N85F4A922125BF53EB83B0638C608992B9F317AAC31B591F3458D0E8AC2F6D1D4;
using FlatSharp.Compiler.Generated.NA996C1DC7EED409BD99FE94669492223E3AAF09FFAB150EF6C8218E255311785;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N595B2E7502315F086AB3B99B5188C6C3E700643C4AF9D2D7D33F3C1719C53D87;

internal static class Helpers
{
	[DebuggerDisplay("Lazy Sequence")]
	internal sealed class tableReader_22d035cb5faa41a9b7e1e235a016abd0_Lazy<TInputBuffer> : Sequence, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Sequence);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override ushort SchemaVersion
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

		public override required string Id
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

		public override string? Name
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

		public override string? SceneName
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

		public override float FrameRate
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

		public override IList<Binding>? Bindings
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

		public override IList<Clip>? Clips
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

		public override IList<Exposed>? Exposed
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_22d035cb5faa41a9b7e1e235a016abd0_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ushort ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 2;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.Id");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 60f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Binding>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N85F4A922125BF53EB83B0638C608992B9F317AAC31B591F3458D0E8AC2F6D1D4.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Bindings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Clip>? ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E72B6587B7C01FD60DC9D6B042A9198862A69615CB1559A02E09DB41E0C2B65.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Clips);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Exposed>? ReadIndex7Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA996C1DC7EED409BD99FE94669492223E3AAF09FFAB150EF6C8218E255311785.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Exposed);
		}
	}

	[DebuggerDisplay("Progressive Sequence")]
	internal sealed class tableReader_22d035cb5faa41a9b7e1e235a016abd0_Progressive<TInputBuffer> : Sequence, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		private byte __mask0;

		private ushort __index0Value;

		private string __index1Value;

		private string? __index2Value;

		private string? __index3Value;

		private float __index4Value;

		private IList<Binding>? __index5Value;

		private IList<Clip>? __index6Value;

		private IList<Exposed>? __index7Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Sequence);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override ushort SchemaVersion
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

		public override required string Id
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

		public override string? Name
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

		public override string? SceneName
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

		public override float FrameRate
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

		public override IList<Binding>? Bindings
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

		public override IList<Clip>? Clips
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

		public override IList<Exposed>? Exposed
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_22d035cb5faa41a9b7e1e235a016abd0_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			__index1Value = null;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ushort ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 2;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.Id");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 60f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Binding>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N85F4A922125BF53EB83B0638C608992B9F317AAC31B591F3458D0E8AC2F6D1D4.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Bindings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Clip>? ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E72B6587B7C01FD60DC9D6B042A9198862A69615CB1559A02E09DB41E0C2B65.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Clips);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Exposed>? ReadIndex7Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA996C1DC7EED409BD99FE94669492223E3AAF09FFAB150EF6C8218E255311785.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Exposed);
		}
	}

	[DebuggerDisplay("Greedy Sequence")]
	internal sealed class tableReader_22d035cb5faa41a9b7e1e235a016abd0_Greedy<TInputBuffer> : Sequence, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private ushort __index0Value;

		private string __index1Value;

		private string? __index2Value;

		private string? __index3Value;

		private float __index4Value;

		private IList<Binding>? __index5Value;

		private IList<Clip>? __index6Value;

		private IList<Exposed>? __index7Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Sequence);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override ushort SchemaVersion
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

		public override required string Id
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

		public override string? Name
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

		public override string? SceneName
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

		public override float FrameRate
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

		public override IList<Binding>? Bindings
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

		public override IList<Clip>? Clips
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

		public override IList<Exposed>? Exposed
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_22d035cb5faa41a9b7e1e235a016abd0_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ushort ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 2;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.Id");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 60f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Binding>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N85F4A922125BF53EB83B0638C608992B9F317AAC31B591F3458D0E8AC2F6D1D4.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Bindings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Clip>? ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E72B6587B7C01FD60DC9D6B042A9198862A69615CB1559A02E09DB41E0C2B65.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Clips);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Exposed>? ReadIndex7Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA996C1DC7EED409BD99FE94669492223E3AAF09FFAB150EF6C8218E255311785.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Exposed);
		}
	}

	[DebuggerDisplay("GreedyMutable Sequence")]
	internal sealed class tableReader_22d035cb5faa41a9b7e1e235a016abd0_GreedyMutable<TInputBuffer> : Sequence, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private ushort __index0Value;

		private string __index1Value;

		private string? __index2Value;

		private string? __index3Value;

		private float __index4Value;

		private IList<Binding>? __index5Value;

		private IList<Clip>? __index6Value;

		private IList<Exposed>? __index7Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Sequence);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override ushort SchemaVersion
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

		public override required string Id
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

		public override string? Name
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

		public override string? SceneName
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

		public override float FrameRate
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

		public override IList<Binding>? Bindings
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

		public override IList<Clip>? Clips
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

		public override IList<Exposed>? Exposed
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_22d035cb5faa41a9b7e1e235a016abd0_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ushort ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 2;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.Id");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 60f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Binding>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N85F4A922125BF53EB83B0638C608992B9F317AAC31B591F3458D0E8AC2F6D1D4.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Bindings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Clip>? ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E72B6587B7C01FD60DC9D6B042A9198862A69615CB1559A02E09DB41E0C2B65.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Clips);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Exposed>? ReadIndex7Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA996C1DC7EED409BD99FE94669492223E3AAF09FFAB150EF6C8218E255311785.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Exposed);
		}
	}

	private static class tableMetadata_b5e46728cb064364ae7f393d78b9d57b
	{
		public static readonly TableFieldContext SchemaVersion = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.SchemaVersion", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Id = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.Id", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Name = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.Name", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SceneName = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.SceneName", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FrameRate = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.FrameRate", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Bindings = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.Bindings", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Clips = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.Clips", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Exposed = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.Exposed", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(Sequence value)
	{
		int num = 80;
		string id = value.Id;
		if (id != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(id);
		}
		string name = value.Name;
		if (name != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(name);
		}
		string sceneName = value.SceneName;
		if (sceneName != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(sceneName);
		}
		IList<Binding> bindings = value.Bindings;
		if (bindings != null)
		{
			num += FlatSharp.Compiler.Generated.N85F4A922125BF53EB83B0638C608992B9F317AAC31B591F3458D0E8AC2F6D1D4.Helpers.GetMaxSize(bindings);
		}
		IList<Clip> clips = value.Clips;
		if (clips != null)
		{
			num += FlatSharp.Compiler.Generated.N1E72B6587B7C01FD60DC9D6B042A9198862A69615CB1559A02E09DB41E0C2B65.Helpers.GetMaxSize(clips);
		}
		IList<Exposed> exposed = value.Exposed;
		if (exposed != null)
		{
			num += FlatSharp.Compiler.Generated.NA996C1DC7EED409BD99FE94669492223E3AAF09FFAB150EF6C8218E255311785.Helpers.GetMaxSize(exposed);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Sequence value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(56, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 8;
		Span<byte> span2 = stackalloc byte[20];
		ushort schemaVersion = value.SchemaVersion;
		string id = value.Id;
		string name = value.Name;
		string sceneName = value.SceneName;
		float frameRate = value.FrameRate;
		IList<Binding> bindings = value.Bindings;
		IList<Clip> clips = value.Clips;
		IList<Exposed> exposed = value.Exposed;
		int num4 = num;
		if (exposed != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 20;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 18);
		int num5 = num;
		if (clips != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 16);
		int num6 = num;
		if (bindings != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 14);
		int num7 = num;
		if (frameRate != 60f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, frameRate, num7);
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 12);
		int num8 = num;
		if (sceneName != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 10);
		int num9 = num;
		if (name != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 8);
		int num10 = num;
		if (id != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Sequencer.Sequence.Id");
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 6);
		int num11 = num;
		if (schemaVersion != 2)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 2);
			num11 = num2;
			num2 += 2;
			FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Serialize(spanWriter, span, schemaVersion, num11);
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 4);
		int num12 = num2 - num;
		context.Offset -= 56 - num12;
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)num3, 0);
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)num12, 2);
		int num13 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num13, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NA996C1DC7EED409BD99FE94669492223E3AAF09FFAB150EF6C8218E255311785.Helpers.Serialize(spanWriter, span, exposed, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N1E72B6587B7C01FD60DC9D6B042A9198862A69615CB1559A02E09DB41E0C2B65.Helpers.Serialize(spanWriter, span, clips, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.N85F4A922125BF53EB83B0638C608992B9F317AAC31B591F3458D0E8AC2F6D1D4.Helpers.Serialize(spanWriter, span, bindings, num6, context);
		}
		if (num8 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, sceneName, num8, context, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.SceneName);
		}
		if (num9 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, name, num9, context, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Name);
		}
		if (num10 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, id, num10, context, tableMetadata_b5e46728cb064364ae7f393d78b9d57b.Id);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_22d035cb5faa41a9b7e1e235a016abd0_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_22d035cb5faa41a9b7e1e235a016abd0_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_22d035cb5faa41a9b7e1e235a016abd0_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_22d035cb5faa41a9b7e1e235a016abd0_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_22d035cb5faa41a9b7e1e235a016abd0_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_22d035cb5faa41a9b7e1e235a016abd0_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_22d035cb5faa41a9b7e1e235a016abd0_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_22d035cb5faa41a9b7e1e235a016abd0_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
