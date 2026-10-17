using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;
using FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N2B56B73082175DA2C5035E07A23FB6365491AC33F926C67E4D15FA0E3AC4286E;

internal static class Helpers
{
	[DebuggerDisplay("Lazy Perk")]
	internal sealed class structReader_17c3293f79cf4ebbba438492e8352b4f_Lazy<TInputBuffer> : Perk, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Perk);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override uint Id
		{
			get
			{
				return ReadIndex0Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override double Value
		{
			get
			{
				return ReadIndex1Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override double StatModValue
		{
			get
			{
				return ReadIndex2Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_17c3293f79cf4ebbba438492e8352b4f_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset + 8, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset + 16, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive Perk")]
	internal sealed class structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer> : Perk, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private byte __mask0;

		private uint __index0Value;

		private double __index1Value;

		private double __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Perk);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override uint Id
		{
			get
			{
				if ((__mask0 & 1) == 0)
				{
					__index0Value = ReadIndex0Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 1);
				}
				return __index0Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override double Value
		{
			get
			{
				if ((__mask0 & 2) == 0)
				{
					__index1Value = ReadIndex1Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 2);
				}
				return __index1Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override double StatModValue
		{
			get
			{
				if ((__mask0 & 4) == 0)
				{
					__index2Value = ReadIndex2Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 4);
				}
				return __index2Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset + 8, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset + 16, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy Perk")]
	internal sealed class structReader_17c3293f79cf4ebbba438492e8352b4f_Greedy<TInputBuffer> : Perk, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private uint __index0Value;

		private double __index1Value;

		private double __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Perk);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override uint Id
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

		public override double Value
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

		public override double StatModValue
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_17c3293f79cf4ebbba438492e8352b4f_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__index0Value = ReadIndex0Value(buffer, offset, default, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, default, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, default, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset + 8, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset + 16, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable Perk")]
	internal sealed class structReader_17c3293f79cf4ebbba438492e8352b4f_GreedyMutable<TInputBuffer> : Perk, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private uint __index0Value;

		private double __index1Value;

		private double __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Perk);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override uint Id
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

		public override double Value
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

		public override double StatModValue
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_17c3293f79cf4ebbba438492e8352b4f_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__index0Value = ReadIndex0Value(buffer, offset, default, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, default, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, default, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset + 8, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset + 16, remainingDepth);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(Perk value)
	{
		return 31;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Perk value, int offset) where TSpanWriter : ISpanWriter
	{
		Span<byte> span2 = span.Slice(offset, 24);
		if (value == null)
		{
			span2.Clear();
			return;
		}
		FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span2, value.Id, 0);
		FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Serialize(spanWriter, span2, value.Value, 8);
		FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Serialize(spanWriter, span2, value.StatModValue, 16);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_17c3293f79cf4ebbba438492e8352b4f_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_17c3293f79cf4ebbba438492e8352b4f_Lazy<TInputBuffer>(buffer, offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_17c3293f79cf4ebbba438492e8352b4f_Progressive<TInputBuffer>(buffer, offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_17c3293f79cf4ebbba438492e8352b4f_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_17c3293f79cf4ebbba438492e8352b4f_Greedy<TInputBuffer>(buffer, offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_17c3293f79cf4ebbba438492e8352b4f_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_17c3293f79cf4ebbba438492e8352b4f_GreedyMutable<TInputBuffer>(buffer, offset, remainingDepth);
	}
}
