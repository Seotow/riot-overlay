using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N3FAC0DE37C40A7BF0E0E1FD7E6147977E3E4D6D448C3C34734CF79F750495E0B;

internal static class Helpers
{
	[DebuggerDisplay("Lazy ScriptListRequest")]
	internal sealed class tableReader_e17f318954334a4ab7506d9598413c22_Lazy<TInputBuffer> : ScriptListRequest, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ScriptListRequest);

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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_e17f318954334a4ab7506d9598413c22_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
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
	}

	[DebuggerDisplay("Progressive ScriptListRequest")]
	internal sealed class tableReader_e17f318954334a4ab7506d9598413c22_Progressive<TInputBuffer> : ScriptListRequest, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private uint __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ScriptListRequest);

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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_e17f318954334a4ab7506d9598413c22_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
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
	}

	[DebuggerDisplay("Greedy ScriptListRequest")]
	internal sealed class tableReader_e17f318954334a4ab7506d9598413c22_Greedy<TInputBuffer> : ScriptListRequest, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private uint __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ScriptListRequest);

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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_e17f318954334a4ab7506d9598413c22_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
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
	}

	[DebuggerDisplay("GreedyMutable ScriptListRequest")]
	internal sealed class tableReader_e17f318954334a4ab7506d9598413c22_GreedyMutable<TInputBuffer> : ScriptListRequest, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private uint __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ScriptListRequest);

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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_e17f318954334a4ab7506d9598413c22_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
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
	}

	private static class tableMetadata_2cc72d72e4d7450d8a0c8adfa77d1192
	{
		public static readonly TableFieldContext SceneId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.ScriptListRequest.SceneId", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(ScriptListRequest value)
	{
		return 21;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, ScriptListRequest value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		uint sceneId = value.SceneId;
		int num4 = num;
		if (sceneId != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span, sceneId, num4);
			num3 = 6;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 4);
		int num5 = num2 - num;
		context.Offset -= 11 - num5;
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)num3, 0);
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)num5, 2);
		int num6 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num6, num);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_e17f318954334a4ab7506d9598413c22_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_e17f318954334a4ab7506d9598413c22_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_e17f318954334a4ab7506d9598413c22_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_e17f318954334a4ab7506d9598413c22_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_e17f318954334a4ab7506d9598413c22_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_e17f318954334a4ab7506d9598413c22_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_e17f318954334a4ab7506d9598413c22_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_e17f318954334a4ab7506d9598413c22_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
