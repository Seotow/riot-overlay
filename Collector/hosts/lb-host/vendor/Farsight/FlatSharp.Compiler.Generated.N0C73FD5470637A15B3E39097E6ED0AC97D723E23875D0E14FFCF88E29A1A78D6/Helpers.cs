using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.NE9FB5DE3FA84F6FAEB78EB77D9B02586F88CCB0167C83B8BE2EFA90820BFCD33;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N0C73FD5470637A15B3E39097E6ED0AC97D723E23875D0E14FFCF88E29A1A78D6;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SceneAction")]
	internal sealed class tableReader_910934a869fd4a879861ba2e778e735a_Lazy<TInputBuffer> : SceneAction, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneAction);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override SceneCommand? Command
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
		public tableReader_910934a869fd4a879861ba2e778e735a_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SceneCommand? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 0);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 1);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Scene.SceneAction.Command");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.NE9FB5DE3FA84F6FAEB78EB77D9B02586F88CCB0167C83B8BE2EFA90820BFCD33.Helpers.Parse_Lazy(buffer, ref offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive SceneAction")]
	internal sealed class tableReader_910934a869fd4a879861ba2e778e735a_Progressive<TInputBuffer> : SceneAction, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private SceneCommand? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneAction);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override SceneCommand? Command
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
		public tableReader_910934a869fd4a879861ba2e778e735a_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SceneCommand? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 0);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 1);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Scene.SceneAction.Command");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.NE9FB5DE3FA84F6FAEB78EB77D9B02586F88CCB0167C83B8BE2EFA90820BFCD33.Helpers.Parse_Progressive(buffer, ref offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy SceneAction")]
	internal sealed class tableReader_910934a869fd4a879861ba2e778e735a_Greedy<TInputBuffer> : SceneAction, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private SceneCommand? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneAction);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override SceneCommand? Command
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
		public tableReader_910934a869fd4a879861ba2e778e735a_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SceneCommand? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 0);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 1);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Scene.SceneAction.Command");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.NE9FB5DE3FA84F6FAEB78EB77D9B02586F88CCB0167C83B8BE2EFA90820BFCD33.Helpers.Parse_Greedy(buffer, ref offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable SceneAction")]
	internal sealed class tableReader_910934a869fd4a879861ba2e778e735a_GreedyMutable<TInputBuffer> : SceneAction, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private SceneCommand? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneAction);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override SceneCommand? Command
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
		public tableReader_910934a869fd4a879861ba2e778e735a_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SceneCommand? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 0);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 1);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Scene.SceneAction.Command");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.NE9FB5DE3FA84F6FAEB78EB77D9B02586F88CCB0167C83B8BE2EFA90820BFCD33.Helpers.Parse_GreedyMutable(buffer, ref offset2, remainingDepth);
		}
	}

	private static class tableMetadata_8176d6a1619b4422add9179dc7413327
	{
		public static readonly TableFieldContext Command = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneAction.Command", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SceneAction value)
	{
		int num = 24;
		SceneCommand? command = value.Command;
		if (command.HasValue)
		{
			num += FlatSharp.Compiler.Generated.NE9FB5DE3FA84F6FAEB78EB77D9B02586F88CCB0167C83B8BE2EFA90820BFCD33.Helpers.GetMaxSize(command);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SceneAction value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(12, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[8];
		SceneCommand? command = value.Command;
		int num4 = num;
		if (command.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 8;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 6);
		int num5 = num;
		if (command.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num5 = num2;
			num2++;
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 4);
		int num6 = num2 - num;
		context.Offset -= 12 - num6;
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)num3, 0);
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num6, 2);
		int num7 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num7, num);
		if (num5 != num)
		{
			(int, int) offset2 = (num5, num4);
			FlatSharp.Compiler.Generated.NE9FB5DE3FA84F6FAEB78EB77D9B02586F88CCB0167C83B8BE2EFA90820BFCD33.Helpers.Serialize(spanWriter, span, command, ref offset2, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_910934a869fd4a879861ba2e778e735a_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_910934a869fd4a879861ba2e778e735a_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_910934a869fd4a879861ba2e778e735a_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_910934a869fd4a879861ba2e778e735a_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_910934a869fd4a879861ba2e778e735a_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_910934a869fd4a879861ba2e778e735a_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_910934a869fd4a879861ba2e778e735a_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_910934a869fd4a879861ba2e778e735a_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
