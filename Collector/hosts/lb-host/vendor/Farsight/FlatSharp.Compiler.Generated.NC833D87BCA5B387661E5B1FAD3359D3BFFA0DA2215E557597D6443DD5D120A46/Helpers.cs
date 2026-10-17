using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;
using FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC833D87BCA5B387661E5B1FAD3359D3BFFA0DA2215E557597D6443DD5D120A46;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SceneEntitiesRemoved")]
	internal sealed class tableReader_49c76249ffc1422ab29769deeb123dfa_Lazy<TInputBuffer> : SceneEntitiesRemoved, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneEntitiesRemoved);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override uint SceneId
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

		public override IList<ulong>? LocalIds
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

		public override IList<ulong>? ReparentedIds
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_49c76249ffc1422ab29769deeb123dfa_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_c8e200affc19431e8a9b825e7328f3b6.LocalIds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_c8e200affc19431e8a9b825e7328f3b6.ReparentedIds);
		}
	}

	[DebuggerDisplay("Progressive SceneEntitiesRemoved")]
	internal sealed class tableReader_49c76249ffc1422ab29769deeb123dfa_Progressive<TInputBuffer> : SceneEntitiesRemoved, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private uint __index0Value;

		private IList<ulong>? __index1Value;

		private IList<ulong>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneEntitiesRemoved);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override uint SceneId
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

		public override IList<ulong>? LocalIds
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

		public override IList<ulong>? ReparentedIds
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_49c76249ffc1422ab29769deeb123dfa_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_c8e200affc19431e8a9b825e7328f3b6.LocalIds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_c8e200affc19431e8a9b825e7328f3b6.ReparentedIds);
		}
	}

	[DebuggerDisplay("Greedy SceneEntitiesRemoved")]
	internal sealed class tableReader_49c76249ffc1422ab29769deeb123dfa_Greedy<TInputBuffer> : SceneEntitiesRemoved, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private uint __index0Value;

		private IList<ulong>? __index1Value;

		private IList<ulong>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneEntitiesRemoved);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override uint SceneId
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

		public override IList<ulong>? LocalIds
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

		public override IList<ulong>? ReparentedIds
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
		public tableReader_49c76249ffc1422ab29769deeb123dfa_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_c8e200affc19431e8a9b825e7328f3b6.LocalIds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_c8e200affc19431e8a9b825e7328f3b6.ReparentedIds);
		}
	}

	[DebuggerDisplay("GreedyMutable SceneEntitiesRemoved")]
	internal sealed class tableReader_49c76249ffc1422ab29769deeb123dfa_GreedyMutable<TInputBuffer> : SceneEntitiesRemoved, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private uint __index0Value;

		private IList<ulong>? __index1Value;

		private IList<ulong>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneEntitiesRemoved);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override uint SceneId
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

		public override IList<ulong>? LocalIds
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

		public override IList<ulong>? ReparentedIds
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
		public tableReader_49c76249ffc1422ab29769deeb123dfa_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_c8e200affc19431e8a9b825e7328f3b6.LocalIds);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_c8e200affc19431e8a9b825e7328f3b6.ReparentedIds);
		}
	}

	private static class tableMetadata_c8e200affc19431e8a9b825e7328f3b6
	{
		public static readonly TableFieldContext SceneId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntitiesRemoved.SceneId", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext LocalIds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntitiesRemoved.LocalIds", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ReparentedIds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntitiesRemoved.ReparentedIds", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SceneEntitiesRemoved value)
	{
		int num = 39;
		IList<ulong> localIds = value.LocalIds;
		if (localIds != null)
		{
			num += FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.GetMaxSize(localIds);
		}
		IList<ulong> reparentedIds = value.ReparentedIds;
		if (reparentedIds != null)
		{
			num += FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.GetMaxSize(reparentedIds);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SceneEntitiesRemoved value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(25, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[10];
		uint sceneId = value.SceneId;
		IList<ulong> localIds = value.LocalIds;
		IList<ulong> reparentedIds = value.ReparentedIds;
		int num4 = num;
		if (reparentedIds != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 10;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 8);
		int num5 = num;
		if (localIds != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 6);
		int num6 = num;
		if (sceneId != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span, sceneId, num6);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 4);
		int num7 = num2 - num;
		context.Offset -= 25 - num7;
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num3, 0);
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num7, 2);
		int num8 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num8, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Serialize(spanWriter, span, reparentedIds, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Serialize(spanWriter, span, localIds, num5, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_49c76249ffc1422ab29769deeb123dfa_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_49c76249ffc1422ab29769deeb123dfa_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_49c76249ffc1422ab29769deeb123dfa_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_49c76249ffc1422ab29769deeb123dfa_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_49c76249ffc1422ab29769deeb123dfa_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_49c76249ffc1422ab29769deeb123dfa_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_49c76249ffc1422ab29769deeb123dfa_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_49c76249ffc1422ab29769deeb123dfa_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
