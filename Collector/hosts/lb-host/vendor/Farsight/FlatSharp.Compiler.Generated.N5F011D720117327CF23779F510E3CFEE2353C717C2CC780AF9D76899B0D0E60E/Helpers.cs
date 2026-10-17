using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.NE8B2AF825C6CAD46E1A26D2EF7094F10E54B165FEDD3D49DC6867D008A8386A2;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N5F011D720117327CF23779F510E3CFEE2353C717C2CC780AF9D76899B0D0E60E;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SceneList")]
	internal sealed class tableReader_8c6055a880b846bd962e63dca5e3fee3_Lazy<TInputBuffer> : SceneList, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneList);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<SceneDescriptor>? Scenes
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
		public tableReader_8c6055a880b846bd962e63dca5e3fee3_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SceneDescriptor>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE8B2AF825C6CAD46E1A26D2EF7094F10E54B165FEDD3D49DC6867D008A8386A2.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_675a733931064e2f9e2f03de68605fc0.Scenes);
		}
	}

	[DebuggerDisplay("Progressive SceneList")]
	internal sealed class tableReader_8c6055a880b846bd962e63dca5e3fee3_Progressive<TInputBuffer> : SceneList, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private IList<SceneDescriptor>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneList);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<SceneDescriptor>? Scenes
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
		public tableReader_8c6055a880b846bd962e63dca5e3fee3_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SceneDescriptor>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE8B2AF825C6CAD46E1A26D2EF7094F10E54B165FEDD3D49DC6867D008A8386A2.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_675a733931064e2f9e2f03de68605fc0.Scenes);
		}
	}

	[DebuggerDisplay("Greedy SceneList")]
	internal sealed class tableReader_8c6055a880b846bd962e63dca5e3fee3_Greedy<TInputBuffer> : SceneList, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<SceneDescriptor>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneList);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<SceneDescriptor>? Scenes
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
		public tableReader_8c6055a880b846bd962e63dca5e3fee3_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SceneDescriptor>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE8B2AF825C6CAD46E1A26D2EF7094F10E54B165FEDD3D49DC6867D008A8386A2.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_675a733931064e2f9e2f03de68605fc0.Scenes);
		}
	}

	[DebuggerDisplay("GreedyMutable SceneList")]
	internal sealed class tableReader_8c6055a880b846bd962e63dca5e3fee3_GreedyMutable<TInputBuffer> : SceneList, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<SceneDescriptor>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneList);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<SceneDescriptor>? Scenes
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
		public tableReader_8c6055a880b846bd962e63dca5e3fee3_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<SceneDescriptor>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE8B2AF825C6CAD46E1A26D2EF7094F10E54B165FEDD3D49DC6867D008A8386A2.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_675a733931064e2f9e2f03de68605fc0.Scenes);
		}
	}

	private static class tableMetadata_675a733931064e2f9e2f03de68605fc0
	{
		public static readonly TableFieldContext Scenes = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneList.Scenes", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SceneList value)
	{
		int num = 21;
		IList<SceneDescriptor> scenes = value.Scenes;
		if (scenes != null)
		{
			num += FlatSharp.Compiler.Generated.NE8B2AF825C6CAD46E1A26D2EF7094F10E54B165FEDD3D49DC6867D008A8386A2.Helpers.GetMaxSize(scenes);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SceneList value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		IList<SceneDescriptor> scenes = value.Scenes;
		int num4 = num;
		if (scenes != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
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
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NE8B2AF825C6CAD46E1A26D2EF7094F10E54B165FEDD3D49DC6867D008A8386A2.Helpers.Serialize(spanWriter, span, scenes, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8c6055a880b846bd962e63dca5e3fee3_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8c6055a880b846bd962e63dca5e3fee3_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8c6055a880b846bd962e63dca5e3fee3_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8c6055a880b846bd962e63dca5e3fee3_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8c6055a880b846bd962e63dca5e3fee3_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8c6055a880b846bd962e63dca5e3fee3_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8c6055a880b846bd962e63dca5e3fee3_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8c6055a880b846bd962e63dca5e3fee3_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
