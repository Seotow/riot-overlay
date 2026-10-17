using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using FlatSharp.Compiler.Generated.N6A6B0E479B063354DAC88EEB4024310FB767386C3B7C666FA4216EFF45283D3B;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62;
using FlatSharp.Compiler.Generated.NC58BA8EEB05FB5E1675E2F85AB8425CF63235A29014A36E26FFEEB1CE6CBCD82;
using FlatSharp.Compiler.Generated.NCE0F4068FA188EEC14561388C518850186CD1B13A9948277C3EA7B679000D227;
using FlatSharp.Compiler.Generated.NEE6E587F7BC3C9F36F40F93A875A3FCE5D37DB20A14D0B9DA7344EDBD6D28D82;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NF498DAD23117C3EE4094D7C217F705E1F5342DD4A91E922B1A6BE9C43B410260;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SequenceState")]
	internal sealed class tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Lazy<TInputBuffer> : SequenceState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SequenceState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override string? SequenceId
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

		public override IList<SequenceClipState>? Clips
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

		public override IList<uint>? BrokenBindings
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

		public override IList<string>? FiredMarkers
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

		public override IList<SeqProperty>? DrivableProperties
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

		public override CameraHold Camera
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
		private static IList<SequenceClipState>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCE0F4068FA188EEC14561388C518850186CD1B13A9948277C3EA7B679000D227.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.Clips);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<uint>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC58BA8EEB05FB5E1675E2F85AB8425CF63235A29014A36E26FFEEB1CE6CBCD82.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.BrokenBindings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<string>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.FiredMarkers);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SeqProperty>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NEE6E587F7BC3C9F36F40F93A875A3FCE5D37DB20A14D0B9DA7344EDBD6D28D82.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.DrivableProperties);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraHold ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return CameraHold.Idle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N6A6B0E479B063354DAC88EEB4024310FB767386C3B7C666FA4216EFF45283D3B.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive SequenceState")]
	internal sealed class tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Progressive<TInputBuffer> : SequenceState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		private byte __mask0;

		private string? __index0Value;

		private IList<SequenceClipState>? __index1Value;

		private IList<uint>? __index2Value;

		private IList<string>? __index3Value;

		private IList<SeqProperty>? __index4Value;

		private CameraHold __index5Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SequenceState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override string? SequenceId
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

		public override IList<SequenceClipState>? Clips
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

		public override IList<uint>? BrokenBindings
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

		public override IList<string>? FiredMarkers
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

		public override IList<SeqProperty>? DrivableProperties
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

		public override CameraHold Camera
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
		private static IList<SequenceClipState>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCE0F4068FA188EEC14561388C518850186CD1B13A9948277C3EA7B679000D227.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.Clips);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<uint>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC58BA8EEB05FB5E1675E2F85AB8425CF63235A29014A36E26FFEEB1CE6CBCD82.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.BrokenBindings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<string>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.FiredMarkers);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SeqProperty>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NEE6E587F7BC3C9F36F40F93A875A3FCE5D37DB20A14D0B9DA7344EDBD6D28D82.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.DrivableProperties);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraHold ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return CameraHold.Idle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N6A6B0E479B063354DAC88EEB4024310FB767386C3B7C666FA4216EFF45283D3B.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy SequenceState")]
	internal sealed class tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Greedy<TInputBuffer> : SequenceState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private string? __index0Value;

		private IList<SequenceClipState>? __index1Value;

		private IList<uint>? __index2Value;

		private IList<string>? __index3Value;

		private IList<SeqProperty>? __index4Value;

		private CameraHold __index5Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SequenceState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override string? SequenceId
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

		public override IList<SequenceClipState>? Clips
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

		public override IList<uint>? BrokenBindings
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

		public override IList<string>? FiredMarkers
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

		public override IList<SeqProperty>? DrivableProperties
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

		public override CameraHold Camera
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
		private static IList<SequenceClipState>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCE0F4068FA188EEC14561388C518850186CD1B13A9948277C3EA7B679000D227.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.Clips);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<uint>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC58BA8EEB05FB5E1675E2F85AB8425CF63235A29014A36E26FFEEB1CE6CBCD82.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.BrokenBindings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<string>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.FiredMarkers);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SeqProperty>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NEE6E587F7BC3C9F36F40F93A875A3FCE5D37DB20A14D0B9DA7344EDBD6D28D82.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.DrivableProperties);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraHold ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return CameraHold.Idle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N6A6B0E479B063354DAC88EEB4024310FB767386C3B7C666FA4216EFF45283D3B.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable SequenceState")]
	internal sealed class tableReader_ff38dc1d1cb543a9839ac6964f77a30e_GreedyMutable<TInputBuffer> : SequenceState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private string? __index0Value;

		private IList<SequenceClipState>? __index1Value;

		private IList<uint>? __index2Value;

		private IList<string>? __index3Value;

		private IList<SeqProperty>? __index4Value;

		private CameraHold __index5Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SequenceState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override string? SequenceId
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

		public override IList<SequenceClipState>? Clips
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

		public override IList<uint>? BrokenBindings
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

		public override IList<string>? FiredMarkers
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

		public override IList<SeqProperty>? DrivableProperties
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

		public override CameraHold Camera
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_ff38dc1d1cb543a9839ac6964f77a30e_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
		private static IList<SequenceClipState>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCE0F4068FA188EEC14561388C518850186CD1B13A9948277C3EA7B679000D227.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.Clips);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<uint>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC58BA8EEB05FB5E1675E2F85AB8425CF63235A29014A36E26FFEEB1CE6CBCD82.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.BrokenBindings);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<string>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.FiredMarkers);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SeqProperty>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NEE6E587F7BC3C9F36F40F93A875A3FCE5D37DB20A14D0B9DA7344EDBD6D28D82.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.DrivableProperties);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraHold ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return CameraHold.Idle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N6A6B0E479B063354DAC88EEB4024310FB767386C3B7C666FA4216EFF45283D3B.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_8d8d7b721f3a40ef978373d6c07b0402
	{
		public static readonly TableFieldContext SequenceId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.SequenceState.SequenceId", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Clips = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.SequenceState.Clips", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BrokenBindings = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.SequenceState.BrokenBindings", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FiredMarkers = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.SequenceState.FiredMarkers", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext DrivableProperties = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.SequenceState.DrivableProperties", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Camera = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Sequencer.SequenceState.Camera", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SequenceState value)
	{
		int num = 60;
		string sequenceId = value.SequenceId;
		if (sequenceId != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(sequenceId);
		}
		IList<SequenceClipState> clips = value.Clips;
		if (clips != null)
		{
			num += FlatSharp.Compiler.Generated.NCE0F4068FA188EEC14561388C518850186CD1B13A9948277C3EA7B679000D227.Helpers.GetMaxSize(clips);
		}
		IList<uint> brokenBindings = value.BrokenBindings;
		if (brokenBindings != null)
		{
			num += FlatSharp.Compiler.Generated.NC58BA8EEB05FB5E1675E2F85AB8425CF63235A29014A36E26FFEEB1CE6CBCD82.Helpers.GetMaxSize(brokenBindings);
		}
		IList<string> firedMarkers = value.FiredMarkers;
		if (firedMarkers != null)
		{
			num += FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.GetMaxSize(firedMarkers);
		}
		IList<SeqProperty> drivableProperties = value.DrivableProperties;
		if (drivableProperties != null)
		{
			num += FlatSharp.Compiler.Generated.NEE6E587F7BC3C9F36F40F93A875A3FCE5D37DB20A14D0B9DA7344EDBD6D28D82.Helpers.GetMaxSize(drivableProperties);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SequenceState value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(40, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[16];
		string sequenceId = value.SequenceId;
		IList<SequenceClipState> clips = value.Clips;
		IList<uint> brokenBindings = value.BrokenBindings;
		IList<string> firedMarkers = value.FiredMarkers;
		IList<SeqProperty> drivableProperties = value.DrivableProperties;
		CameraHold camera = value.Camera;
		int num4 = num;
		if (drivableProperties != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 12);
		int num5 = num;
		if (firedMarkers != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 10);
		int num6 = num;
		if (brokenBindings != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 8);
		int num7 = num;
		if (clips != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 6);
		int num8 = num;
		if (sequenceId != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 4);
		int num9 = num;
		if (camera != CameraHold.Idle)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num9 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N6A6B0E479B063354DAC88EEB4024310FB767386C3B7C666FA4216EFF45283D3B.Helpers.Serialize(spanWriter, span, camera, num9);
			num3 = 16;
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 14);
		int num10 = num2 - num;
		context.Offset -= 40 - num10;
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)num3, 0);
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)num10, 2);
		int num11 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num11, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NEE6E587F7BC3C9F36F40F93A875A3FCE5D37DB20A14D0B9DA7344EDBD6D28D82.Helpers.Serialize(spanWriter, span, drivableProperties, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.NA877967FDEF65B5ED29FA12AD5046634A6B8239F428E5D77BF513D4524DB0B62.Helpers.Serialize(spanWriter, span, firedMarkers, num5, context, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.FiredMarkers);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.NC58BA8EEB05FB5E1675E2F85AB8425CF63235A29014A36E26FFEEB1CE6CBCD82.Helpers.Serialize(spanWriter, span, brokenBindings, num6, context);
		}
		if (num7 != num)
		{
			FlatSharp.Compiler.Generated.NCE0F4068FA188EEC14561388C518850186CD1B13A9948277C3EA7B679000D227.Helpers.Serialize(spanWriter, span, clips, num7, context);
		}
		if (num8 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, sequenceId, num8, context, tableMetadata_8d8d7b721f3a40ef978373d6c07b0402.SequenceId);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_ff38dc1d1cb543a9839ac6964f77a30e_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_ff38dc1d1cb543a9839ac6964f77a30e_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_ff38dc1d1cb543a9839ac6964f77a30e_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
