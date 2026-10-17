using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NADDCFD1EDEF26C49B891D05E111BB3852F849AF522EDCD0CBB2916B1D2B9AE57;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N3302846FBCBCE3B2663B4AE0CD1F20316EAF3C4E33CEBD0C39936E6057B295C1;

internal static class Helpers
{
	[DebuggerDisplay("Lazy StrokeSyncEvents")]
	internal sealed class tableReader_673167474b9744639fa5821f248c0e5c_Lazy<TInputBuffer> : StrokeSyncEvents, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncEvents);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<StrokeSyncEvent>? Events
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
		public tableReader_673167474b9744639fa5821f248c0e5c_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<StrokeSyncEvent>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NADDCFD1EDEF26C49B891D05E111BB3852F849AF522EDCD0CBB2916B1D2B9AE57.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_217a29d26c4945fcb46da58b57aeaf95.Events);
		}
	}

	[DebuggerDisplay("Progressive StrokeSyncEvents")]
	internal sealed class tableReader_673167474b9744639fa5821f248c0e5c_Progressive<TInputBuffer> : StrokeSyncEvents, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private IList<StrokeSyncEvent>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncEvents);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<StrokeSyncEvent>? Events
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
		public tableReader_673167474b9744639fa5821f248c0e5c_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<StrokeSyncEvent>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NADDCFD1EDEF26C49B891D05E111BB3852F849AF522EDCD0CBB2916B1D2B9AE57.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_217a29d26c4945fcb46da58b57aeaf95.Events);
		}
	}

	[DebuggerDisplay("Greedy StrokeSyncEvents")]
	internal sealed class tableReader_673167474b9744639fa5821f248c0e5c_Greedy<TInputBuffer> : StrokeSyncEvents, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<StrokeSyncEvent>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncEvents);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<StrokeSyncEvent>? Events
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
		public tableReader_673167474b9744639fa5821f248c0e5c_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<StrokeSyncEvent>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NADDCFD1EDEF26C49B891D05E111BB3852F849AF522EDCD0CBB2916B1D2B9AE57.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_217a29d26c4945fcb46da58b57aeaf95.Events);
		}
	}

	[DebuggerDisplay("GreedyMutable StrokeSyncEvents")]
	internal sealed class tableReader_673167474b9744639fa5821f248c0e5c_GreedyMutable<TInputBuffer> : StrokeSyncEvents, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<StrokeSyncEvent>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncEvents);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<StrokeSyncEvent>? Events
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
		public tableReader_673167474b9744639fa5821f248c0e5c_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<StrokeSyncEvent>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NADDCFD1EDEF26C49B891D05E111BB3852F849AF522EDCD0CBB2916B1D2B9AE57.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_217a29d26c4945fcb46da58b57aeaf95.Events);
		}
	}

	private static class tableMetadata_217a29d26c4945fcb46da58b57aeaf95
	{
		public static readonly TableFieldContext Events = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.StrokeSyncEvents.Events", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(StrokeSyncEvents value)
	{
		int num = 21;
		IList<StrokeSyncEvent> events = value.Events;
		if (events != null)
		{
			num += FlatSharp.Compiler.Generated.NADDCFD1EDEF26C49B891D05E111BB3852F849AF522EDCD0CBB2916B1D2B9AE57.Helpers.GetMaxSize(events);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, StrokeSyncEvents value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		IList<StrokeSyncEvent> events = value.Events;
		int num4 = num;
		if (events != null)
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
			FlatSharp.Compiler.Generated.NADDCFD1EDEF26C49B891D05E111BB3852F849AF522EDCD0CBB2916B1D2B9AE57.Helpers.Serialize(spanWriter, span, events, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_673167474b9744639fa5821f248c0e5c_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_673167474b9744639fa5821f248c0e5c_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_673167474b9744639fa5821f248c0e5c_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_673167474b9744639fa5821f248c0e5c_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_673167474b9744639fa5821f248c0e5c_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_673167474b9744639fa5821f248c0e5c_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_673167474b9744639fa5821f248c0e5c_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_673167474b9744639fa5821f248c0e5c_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
