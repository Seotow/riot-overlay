using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NFA5E7B1DD862DDB3CF175AA108B527972C45FC0B933DAE74792276846A17768D;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N9A0588C7E018AF9D8FA10A14D1EAFA548365E45EC6BCAA40329C863EB423D1A0;

internal static class Helpers
{
	[DebuggerDisplay("Lazy ObjectAddressDump")]
	internal sealed class tableReader_57baf65169514b399cbd4ba765ca0fb8_Lazy<TInputBuffer> : ObjectAddressDump, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ObjectAddressDump);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<ObjectAddressEntry>? Entries
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
		public tableReader_57baf65169514b399cbd4ba765ca0fb8_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ObjectAddressEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFA5E7B1DD862DDB3CF175AA108B527972C45FC0B933DAE74792276846A17768D.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_c366f9b49d76452daa0489bb1e4c31d4.Entries);
		}
	}

	[DebuggerDisplay("Progressive ObjectAddressDump")]
	internal sealed class tableReader_57baf65169514b399cbd4ba765ca0fb8_Progressive<TInputBuffer> : ObjectAddressDump, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private IList<ObjectAddressEntry>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ObjectAddressDump);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<ObjectAddressEntry>? Entries
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
		public tableReader_57baf65169514b399cbd4ba765ca0fb8_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ObjectAddressEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFA5E7B1DD862DDB3CF175AA108B527972C45FC0B933DAE74792276846A17768D.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_c366f9b49d76452daa0489bb1e4c31d4.Entries);
		}
	}

	[DebuggerDisplay("Greedy ObjectAddressDump")]
	internal sealed class tableReader_57baf65169514b399cbd4ba765ca0fb8_Greedy<TInputBuffer> : ObjectAddressDump, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<ObjectAddressEntry>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ObjectAddressDump);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<ObjectAddressEntry>? Entries
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
		public tableReader_57baf65169514b399cbd4ba765ca0fb8_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ObjectAddressEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFA5E7B1DD862DDB3CF175AA108B527972C45FC0B933DAE74792276846A17768D.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_c366f9b49d76452daa0489bb1e4c31d4.Entries);
		}
	}

	[DebuggerDisplay("GreedyMutable ObjectAddressDump")]
	internal sealed class tableReader_57baf65169514b399cbd4ba765ca0fb8_GreedyMutable<TInputBuffer> : ObjectAddressDump, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<ObjectAddressEntry>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ObjectAddressDump);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<ObjectAddressEntry>? Entries
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
		public tableReader_57baf65169514b399cbd4ba765ca0fb8_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ObjectAddressEntry>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFA5E7B1DD862DDB3CF175AA108B527972C45FC0B933DAE74792276846A17768D.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_c366f9b49d76452daa0489bb1e4c31d4.Entries);
		}
	}

	private static class tableMetadata_c366f9b49d76452daa0489bb1e4c31d4
	{
		public static readonly TableFieldContext Entries = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.ObjectAddressDump.Entries", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(ObjectAddressDump value)
	{
		int num = 21;
		IList<ObjectAddressEntry> entries = value.Entries;
		if (entries != null)
		{
			num += FlatSharp.Compiler.Generated.NFA5E7B1DD862DDB3CF175AA108B527972C45FC0B933DAE74792276846A17768D.Helpers.GetMaxSize(entries);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, ObjectAddressDump value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		IList<ObjectAddressEntry> entries = value.Entries;
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
			FlatSharp.Compiler.Generated.NFA5E7B1DD862DDB3CF175AA108B527972C45FC0B933DAE74792276846A17768D.Helpers.Serialize(spanWriter, span, entries, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_57baf65169514b399cbd4ba765ca0fb8_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_57baf65169514b399cbd4ba765ca0fb8_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_57baf65169514b399cbd4ba765ca0fb8_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_57baf65169514b399cbd4ba765ca0fb8_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_57baf65169514b399cbd4ba765ca0fb8_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_57baf65169514b399cbd4ba765ca0fb8_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_57baf65169514b399cbd4ba765ca0fb8_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_57baf65169514b399cbd4ba765ca0fb8_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
