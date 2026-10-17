using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NF94C0FDDEB14BED4C490489D414CF12563EBA49E3FAB783549B36A9AF704E667;

internal static class Helpers
{
	[DebuggerDisplay("Lazy GetSceneEditorHudLayout")]
	internal sealed class tableReader_37bb8aaa7583459d985d00a9d82fea9e_Lazy<TInputBuffer> : GetSceneEditorHudLayout, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GetSceneEditorHudLayout);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_37bb8aaa7583459d985d00a9d82fea9e_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}
	}

	[DebuggerDisplay("Progressive GetSceneEditorHudLayout")]
	internal sealed class tableReader_37bb8aaa7583459d985d00a9d82fea9e_Progressive<TInputBuffer> : GetSceneEditorHudLayout, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GetSceneEditorHudLayout);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_37bb8aaa7583459d985d00a9d82fea9e_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}
	}

	[DebuggerDisplay("Greedy GetSceneEditorHudLayout")]
	internal sealed class tableReader_37bb8aaa7583459d985d00a9d82fea9e_Greedy<TInputBuffer> : GetSceneEditorHudLayout, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GetSceneEditorHudLayout);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_37bb8aaa7583459d985d00a9d82fea9e_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var _);
			OnFlatSharpDeserialized(__CtorContext);
		}
	}

	[DebuggerDisplay("GreedyMutable GetSceneEditorHudLayout")]
	internal sealed class tableReader_37bb8aaa7583459d985d00a9d82fea9e_GreedyMutable<TInputBuffer> : GetSceneEditorHudLayout, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GetSceneEditorHudLayout);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_37bb8aaa7583459d985d00a9d82fea9e_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var _);
			OnFlatSharpDeserialized(__CtorContext);
		}
	}

	private static class tableMetadata_e5e63bff98d6480eb1ab031410756b1c
	{
	}

	internal static int GetMaxSize(GetSceneEditorHudLayout value)
	{
		return 12;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, GetSceneEditorHudLayout value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(4, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[4];
		int num4 = num2 - num;
		context.Offset -= 4 - num4;
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)num3, 0);
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)num4, 2);
		int num5 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num5, num);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_37bb8aaa7583459d985d00a9d82fea9e_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_37bb8aaa7583459d985d00a9d82fea9e_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_37bb8aaa7583459d985d00a9d82fea9e_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_37bb8aaa7583459d985d00a9d82fea9e_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_37bb8aaa7583459d985d00a9d82fea9e_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_37bb8aaa7583459d985d00a9d82fea9e_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_37bb8aaa7583459d985d00a9d82fea9e_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_37bb8aaa7583459d985d00a9d82fea9e_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
