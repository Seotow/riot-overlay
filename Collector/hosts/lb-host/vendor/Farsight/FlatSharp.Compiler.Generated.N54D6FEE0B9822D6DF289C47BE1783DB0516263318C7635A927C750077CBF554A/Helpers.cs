using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N650EBC788D9EDAB6E2D89AD8BD4F2F570CE4E26DFEAFE9641ADD222C39E47F6F;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N54D6FEE0B9822D6DF289C47BE1783DB0516263318C7635A927C750077CBF554A;

internal static class Helpers
{
	[DebuggerDisplay("Lazy OffsetDump")]
	internal sealed class tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Lazy<TInputBuffer> : OffsetDump, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(OffsetDump);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<OffsetEntry>? Entries
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
		public tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<OffsetEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N650EBC788D9EDAB6E2D89AD8BD4F2F570CE4E26DFEAFE9641ADD222C39E47F6F.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_e24cd996a6ec4347bc05469e3615c889.Entries);
		}
	}

	[DebuggerDisplay("Progressive OffsetDump")]
	internal sealed class tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Progressive<TInputBuffer> : OffsetDump, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private IList<OffsetEntry>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(OffsetDump);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<OffsetEntry>? Entries
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
		public tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<OffsetEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N650EBC788D9EDAB6E2D89AD8BD4F2F570CE4E26DFEAFE9641ADD222C39E47F6F.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_e24cd996a6ec4347bc05469e3615c889.Entries);
		}
	}

	[DebuggerDisplay("Greedy OffsetDump")]
	internal sealed class tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Greedy<TInputBuffer> : OffsetDump, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<OffsetEntry>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(OffsetDump);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<OffsetEntry>? Entries
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
		public tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<OffsetEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N650EBC788D9EDAB6E2D89AD8BD4F2F570CE4E26DFEAFE9641ADD222C39E47F6F.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_e24cd996a6ec4347bc05469e3615c889.Entries);
		}
	}

	[DebuggerDisplay("GreedyMutable OffsetDump")]
	internal sealed class tableReader_30e91487e8524dbfa27a2ec84a4b50a7_GreedyMutable<TInputBuffer> : OffsetDump, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<OffsetEntry>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(OffsetDump);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<OffsetEntry>? Entries
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
		public tableReader_30e91487e8524dbfa27a2ec84a4b50a7_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<OffsetEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N650EBC788D9EDAB6E2D89AD8BD4F2F570CE4E26DFEAFE9641ADD222C39E47F6F.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_e24cd996a6ec4347bc05469e3615c889.Entries);
		}
	}

	private static class tableMetadata_e24cd996a6ec4347bc05469e3615c889
	{
		public static readonly TableFieldContext Entries = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.OffsetDump.Entries", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(OffsetDump value)
	{
		int num = 21;
		IList<OffsetEntry> entries = value.Entries;
		if (entries != null)
		{
			num += FlatSharp.Compiler.Generated.N650EBC788D9EDAB6E2D89AD8BD4F2F570CE4E26DFEAFE9641ADD222C39E47F6F.Helpers.GetMaxSize(entries);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, OffsetDump value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		IList<OffsetEntry> entries = value.Entries;
		int num4 = num;
		if (entries != null)
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
			FlatSharp.Compiler.Generated.N650EBC788D9EDAB6E2D89AD8BD4F2F570CE4E26DFEAFE9641ADD222C39E47F6F.Helpers.Serialize(spanWriter, span, entries, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_30e91487e8524dbfa27a2ec84a4b50a7_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_30e91487e8524dbfa27a2ec84a4b50a7_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_30e91487e8524dbfa27a2ec84a4b50a7_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
