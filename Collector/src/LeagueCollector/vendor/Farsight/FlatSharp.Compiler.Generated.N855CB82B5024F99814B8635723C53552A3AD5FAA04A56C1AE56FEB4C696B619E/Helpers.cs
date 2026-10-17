using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N7003BDB4A925BB1309AF013DECD63AD310F5D213A8577A69E3ED0F6EB48BB07D;
using FlatSharp.Compiler.Generated.NB41C533C707F816EFB68D9AD13A4FCEB22D06B5C835A1E631F58158D93B2C51C;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N855CB82B5024F99814B8635723C53552A3AD5FAA04A56C1AE56FEB4C696B619E;

internal static class Helpers
{
	[DebuggerDisplay("Lazy StrokeSyncCurrent")]
	internal sealed class tableReader_b836fa991a404b31bec4689e01d93b49_Lazy<TInputBuffer> : StrokeSyncCurrent, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncCurrent);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<CompletedStroke>? CompletedStrokes
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

		public override IList<StrokeSyncBeginRemote>? InProgressStrokes
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
		public tableReader_b836fa991a404b31bec4689e01d93b49_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CompletedStroke>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB41C533C707F816EFB68D9AD13A4FCEB22D06B5C835A1E631F58158D93B2C51C.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_d9217c90f7ab476091e33fbfbd627372.CompletedStrokes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<StrokeSyncBeginRemote>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7003BDB4A925BB1309AF013DECD63AD310F5D213A8577A69E3ED0F6EB48BB07D.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_d9217c90f7ab476091e33fbfbd627372.InProgressStrokes);
		}
	}

	[DebuggerDisplay("Progressive StrokeSyncCurrent")]
	internal sealed class tableReader_b836fa991a404b31bec4689e01d93b49_Progressive<TInputBuffer> : StrokeSyncCurrent, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private IList<CompletedStroke>? __index0Value;

		private IList<StrokeSyncBeginRemote>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncCurrent);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<CompletedStroke>? CompletedStrokes
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

		public override IList<StrokeSyncBeginRemote>? InProgressStrokes
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
		public tableReader_b836fa991a404b31bec4689e01d93b49_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CompletedStroke>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB41C533C707F816EFB68D9AD13A4FCEB22D06B5C835A1E631F58158D93B2C51C.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_d9217c90f7ab476091e33fbfbd627372.CompletedStrokes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<StrokeSyncBeginRemote>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7003BDB4A925BB1309AF013DECD63AD310F5D213A8577A69E3ED0F6EB48BB07D.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_d9217c90f7ab476091e33fbfbd627372.InProgressStrokes);
		}
	}

	[DebuggerDisplay("Greedy StrokeSyncCurrent")]
	internal sealed class tableReader_b836fa991a404b31bec4689e01d93b49_Greedy<TInputBuffer> : StrokeSyncCurrent, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<CompletedStroke>? __index0Value;

		private IList<StrokeSyncBeginRemote>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncCurrent);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<CompletedStroke>? CompletedStrokes
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

		public override IList<StrokeSyncBeginRemote>? InProgressStrokes
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
		public tableReader_b836fa991a404b31bec4689e01d93b49_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CompletedStroke>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB41C533C707F816EFB68D9AD13A4FCEB22D06B5C835A1E631F58158D93B2C51C.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_d9217c90f7ab476091e33fbfbd627372.CompletedStrokes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<StrokeSyncBeginRemote>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7003BDB4A925BB1309AF013DECD63AD310F5D213A8577A69E3ED0F6EB48BB07D.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_d9217c90f7ab476091e33fbfbd627372.InProgressStrokes);
		}
	}

	[DebuggerDisplay("GreedyMutable StrokeSyncCurrent")]
	internal sealed class tableReader_b836fa991a404b31bec4689e01d93b49_GreedyMutable<TInputBuffer> : StrokeSyncCurrent, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<CompletedStroke>? __index0Value;

		private IList<StrokeSyncBeginRemote>? __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncCurrent);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<CompletedStroke>? CompletedStrokes
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

		public override IList<StrokeSyncBeginRemote>? InProgressStrokes
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
		public tableReader_b836fa991a404b31bec4689e01d93b49_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CompletedStroke>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB41C533C707F816EFB68D9AD13A4FCEB22D06B5C835A1E631F58158D93B2C51C.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_d9217c90f7ab476091e33fbfbd627372.CompletedStrokes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<StrokeSyncBeginRemote>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7003BDB4A925BB1309AF013DECD63AD310F5D213A8577A69E3ED0F6EB48BB07D.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_d9217c90f7ab476091e33fbfbd627372.InProgressStrokes);
		}
	}

	private static class tableMetadata_d9217c90f7ab476091e33fbfbd627372
	{
		public static readonly TableFieldContext CompletedStrokes = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncCurrent.CompletedStrokes", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext InProgressStrokes = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncCurrent.InProgressStrokes", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(StrokeSyncCurrent value)
	{
		int num = 30;
		IList<CompletedStroke> completedStrokes = value.CompletedStrokes;
		if (completedStrokes != null)
		{
			num += FlatSharp.Compiler.Generated.NB41C533C707F816EFB68D9AD13A4FCEB22D06B5C835A1E631F58158D93B2C51C.Helpers.GetMaxSize(completedStrokes);
		}
		IList<StrokeSyncBeginRemote> inProgressStrokes = value.InProgressStrokes;
		if (inProgressStrokes != null)
		{
			num += FlatSharp.Compiler.Generated.N7003BDB4A925BB1309AF013DECD63AD310F5D213A8577A69E3ED0F6EB48BB07D.Helpers.GetMaxSize(inProgressStrokes);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, StrokeSyncCurrent value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(18, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[8];
		IList<CompletedStroke> completedStrokes = value.CompletedStrokes;
		IList<StrokeSyncBeginRemote> inProgressStrokes = value.InProgressStrokes;
		int num4 = num;
		if (inProgressStrokes != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 8;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 6);
		int num5 = num;
		if (completedStrokes != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 4);
		int num6 = num2 - num;
		context.Offset -= 18 - num6;
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)num3, 0);
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num6, 2);
		int num7 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num7, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N7003BDB4A925BB1309AF013DECD63AD310F5D213A8577A69E3ED0F6EB48BB07D.Helpers.Serialize(spanWriter, span, inProgressStrokes, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.NB41C533C707F816EFB68D9AD13A4FCEB22D06B5C835A1E631F58158D93B2C51C.Helpers.Serialize(spanWriter, span, completedStrokes, num5, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b836fa991a404b31bec4689e01d93b49_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_b836fa991a404b31bec4689e01d93b49_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b836fa991a404b31bec4689e01d93b49_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_b836fa991a404b31bec4689e01d93b49_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b836fa991a404b31bec4689e01d93b49_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_b836fa991a404b31bec4689e01d93b49_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b836fa991a404b31bec4689e01d93b49_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_b836fa991a404b31bec4689e01d93b49_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
