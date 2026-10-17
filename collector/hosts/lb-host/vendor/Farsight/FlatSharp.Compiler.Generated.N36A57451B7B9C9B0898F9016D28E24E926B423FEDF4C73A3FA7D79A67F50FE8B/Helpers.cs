using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N8D78EAE95BA2F98575A05B7C9107FD572AF046273579BD04BB93094F6AFDB702;
using FlatSharp.Compiler.Generated.NDFB464E70F6B4839BFE8C093C7E57F472D3186F7EB6AF6A26F256E34DEE8A6C1;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N36A57451B7B9C9B0898F9016D28E24E926B423FEDF4C73A3FA7D79A67F50FE8B;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SetGizmoState")]
	internal sealed class tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Lazy<TInputBuffer> : SetGizmoState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetGizmoState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override GizmoModeChange Mode
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

		public override GizmoSpaceChange Space
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GizmoModeChange ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return GizmoModeChange.Keep;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDFB464E70F6B4839BFE8C093C7E57F472D3186F7EB6AF6A26F256E34DEE8A6C1.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GizmoSpaceChange ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return GizmoSpaceChange.Keep;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8D78EAE95BA2F98575A05B7C9107FD572AF046273579BD04BB93094F6AFDB702.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive SetGizmoState")]
	internal sealed class tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Progressive<TInputBuffer> : SetGizmoState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private GizmoModeChange __index0Value;

		private GizmoSpaceChange __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetGizmoState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override GizmoModeChange Mode
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

		public override GizmoSpaceChange Space
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GizmoModeChange ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return GizmoModeChange.Keep;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDFB464E70F6B4839BFE8C093C7E57F472D3186F7EB6AF6A26F256E34DEE8A6C1.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GizmoSpaceChange ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return GizmoSpaceChange.Keep;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8D78EAE95BA2F98575A05B7C9107FD572AF046273579BD04BB93094F6AFDB702.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy SetGizmoState")]
	internal sealed class tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Greedy<TInputBuffer> : SetGizmoState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private GizmoModeChange __index0Value;

		private GizmoSpaceChange __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetGizmoState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override GizmoModeChange Mode
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

		public override GizmoSpaceChange Space
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GizmoModeChange ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return GizmoModeChange.Keep;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDFB464E70F6B4839BFE8C093C7E57F472D3186F7EB6AF6A26F256E34DEE8A6C1.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GizmoSpaceChange ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return GizmoSpaceChange.Keep;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8D78EAE95BA2F98575A05B7C9107FD572AF046273579BD04BB93094F6AFDB702.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable SetGizmoState")]
	internal sealed class tableReader_a05c18abfeda4f5c8e9c782102ae1a80_GreedyMutable<TInputBuffer> : SetGizmoState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private GizmoModeChange __index0Value;

		private GizmoSpaceChange __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetGizmoState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override GizmoModeChange Mode
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

		public override GizmoSpaceChange Space
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a05c18abfeda4f5c8e9c782102ae1a80_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GizmoModeChange ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return GizmoModeChange.Keep;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDFB464E70F6B4839BFE8C093C7E57F472D3186F7EB6AF6A26F256E34DEE8A6C1.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GizmoSpaceChange ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return GizmoSpaceChange.Keep;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8D78EAE95BA2F98575A05B7C9107FD572AF046273579BD04BB93094F6AFDB702.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_62817143eec94f168f00196f3b6b8c76
	{
		public static readonly TableFieldContext Mode = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetGizmoState.Mode", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Space = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetGizmoState.Space", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SetGizmoState value)
	{
		return 18;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SetGizmoState value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(6, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[8];
		GizmoModeChange mode = value.Mode;
		GizmoSpaceChange space = value.Space;
		int num4 = num;
		if (space != GizmoSpaceChange.Keep)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num4 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N8D78EAE95BA2F98575A05B7C9107FD572AF046273579BD04BB93094F6AFDB702.Helpers.Serialize(spanWriter, span, space, num4);
			num3 = 8;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 6);
		int num5 = num;
		if (mode != GizmoModeChange.Keep)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num5 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NDFB464E70F6B4839BFE8C093C7E57F472D3186F7EB6AF6A26F256E34DEE8A6C1.Helpers.Serialize(spanWriter, span, mode, num5);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 4);
		int num6 = num2 - num;
		context.Offset -= 6 - num6;
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)num3, 0);
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num6, 2);
		int num7 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num7, num);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a05c18abfeda4f5c8e9c782102ae1a80_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a05c18abfeda4f5c8e9c782102ae1a80_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a05c18abfeda4f5c8e9c782102ae1a80_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
