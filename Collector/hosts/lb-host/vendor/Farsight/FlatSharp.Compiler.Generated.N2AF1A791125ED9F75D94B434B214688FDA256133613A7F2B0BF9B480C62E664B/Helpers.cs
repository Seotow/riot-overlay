using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N8BBDD146C9710F113F15C05C3EE6C68AE8207861AA7C27B3B19A42FEAB85D55C;
using FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N2AF1A791125ED9F75D94B434B214688FDA256133613A7F2B0BF9B480C62E664B;

internal static class Helpers
{
	[DebuggerDisplay("Lazy Response")]
	internal sealed class tableReader_da6be882fa124c51937673efe2fb3f6e_Lazy<TInputBuffer> : Response, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Response);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required ResponseKind Data
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

		public override ulong RequestId
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
		public tableReader_da6be882fa124c51937673efe2fb3f6e_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ResponseKind ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.Response.Data");
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Snapshot.Response.Data");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N8BBDD146C9710F113F15C05C3EE6C68AE8207861AA7C27B3B19A42FEAB85D55C.Helpers.Parse_Lazy(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive Response")]
	internal sealed class tableReader_da6be882fa124c51937673efe2fb3f6e_Progressive<TInputBuffer> : Response, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private ResponseKind __index0Value;

		private ulong __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Response);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required ResponseKind Data
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

		public override ulong RequestId
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
		public tableReader_da6be882fa124c51937673efe2fb3f6e_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ResponseKind ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.Response.Data");
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Snapshot.Response.Data");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N8BBDD146C9710F113F15C05C3EE6C68AE8207861AA7C27B3B19A42FEAB85D55C.Helpers.Parse_Progressive(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy Response")]
	internal sealed class tableReader_da6be882fa124c51937673efe2fb3f6e_Greedy<TInputBuffer> : Response, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private ResponseKind __index0Value;

		private ulong __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Response);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required ResponseKind Data
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

		public override ulong RequestId
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
		public tableReader_da6be882fa124c51937673efe2fb3f6e_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ResponseKind ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.Response.Data");
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Snapshot.Response.Data");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N8BBDD146C9710F113F15C05C3EE6C68AE8207861AA7C27B3B19A42FEAB85D55C.Helpers.Parse_Greedy(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable Response")]
	internal sealed class tableReader_da6be882fa124c51937673efe2fb3f6e_GreedyMutable<TInputBuffer> : Response, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private ResponseKind __index0Value;

		private ulong __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Response);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required ResponseKind Data
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

		public override ulong RequestId
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
		public tableReader_da6be882fa124c51937673efe2fb3f6e_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ResponseKind ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.Response.Data");
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Snapshot.Response.Data");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N8BBDD146C9710F113F15C05C3EE6C68AE8207861AA7C27B3B19A42FEAB85D55C.Helpers.Parse_GreedyMutable(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_7fd7aecfb3f640cca248508eb2012150
	{
		public static readonly TableFieldContext Data = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Response.Data", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext RequestId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.Response.RequestId", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(Response value)
	{
		ResponseKind data = value.Data;
		return 41 + FlatSharp.Compiler.Generated.N8BBDD146C9710F113F15C05C3EE6C68AE8207861AA7C27B3B19A42FEAB85D55C.Helpers.GetMaxSize(data);
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Response value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(27, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 6;
		Span<byte> span2 = stackalloc byte[10];
		ResponseKind data = value.Data;
		ulong requestId = value.RequestId;
		int num4 = num;
		if (requestId != 0L)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 8);
			num4 = num2;
			num2 += 8;
			FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Serialize(spanWriter, span, requestId, num4);
			num3 = 10;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 8);
		int num5 = num;
		num2 += SerializationHelpers.GetAlignmentError(num2, 4);
		num5 = num2;
		num2 += 4;
		if (8 > num3)
		{
			num3 = 8;
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 6);
		int num6 = num;
		num2 += SerializationHelpers.GetAlignmentError(num2, 1);
		num6 = num2;
		num2++;
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 4);
		int num7 = num2 - num;
		context.Offset -= 27 - num7;
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num3, 0);
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num7, 2);
		int num8 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num8, num);
		if (num6 != num)
		{
			(int, int) offset2 = (num6, num5);
			FlatSharp.Compiler.Generated.N8BBDD146C9710F113F15C05C3EE6C68AE8207861AA7C27B3B19A42FEAB85D55C.Helpers.Serialize(spanWriter, span, data, ref offset2, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_da6be882fa124c51937673efe2fb3f6e_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_da6be882fa124c51937673efe2fb3f6e_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_da6be882fa124c51937673efe2fb3f6e_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_da6be882fa124c51937673efe2fb3f6e_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_da6be882fa124c51937673efe2fb3f6e_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_da6be882fa124c51937673efe2fb3f6e_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_da6be882fa124c51937673efe2fb3f6e_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_da6be882fa124c51937673efe2fb3f6e_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
