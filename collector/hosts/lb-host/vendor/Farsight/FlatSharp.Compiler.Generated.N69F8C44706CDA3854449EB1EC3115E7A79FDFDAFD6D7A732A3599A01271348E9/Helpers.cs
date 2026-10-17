using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.NBABB3A7C5EDCFED4CA181418A5022BA1B472A2D0DCCC4A8A040AEC9112834221;
using FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N69F8C44706CDA3854449EB1EC3115E7A79FDFDAFD6D7A732A3599A01271348E9;

internal static class Helpers
{
	[DebuggerDisplay("Lazy AuthenticationVerify")]
	internal sealed class tableReader_502716574ee143cdaef792e5ae13a4be_Lazy<TInputBuffer> : AuthenticationVerify, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AuthenticationVerify);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<ulong>? FeatureBits
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

		public override required EdDSASig Sig
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
		public tableReader_502716574ee143cdaef792e5ae13a4be_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_4b457e306495441985682c414225de43.FeatureBits);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EdDSASig ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.AuthenticationVerify.Sig");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NBABB3A7C5EDCFED4CA181418A5022BA1B472A2D0DCCC4A8A040AEC9112834221.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive AuthenticationVerify")]
	internal sealed class tableReader_502716574ee143cdaef792e5ae13a4be_Progressive<TInputBuffer> : AuthenticationVerify, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private IList<ulong>? __index0Value;

		private EdDSASig __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AuthenticationVerify);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<ulong>? FeatureBits
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

		public override required EdDSASig Sig
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
		public tableReader_502716574ee143cdaef792e5ae13a4be_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_4b457e306495441985682c414225de43.FeatureBits);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EdDSASig ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.AuthenticationVerify.Sig");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NBABB3A7C5EDCFED4CA181418A5022BA1B472A2D0DCCC4A8A040AEC9112834221.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy AuthenticationVerify")]
	internal sealed class tableReader_502716574ee143cdaef792e5ae13a4be_Greedy<TInputBuffer> : AuthenticationVerify, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<ulong>? __index0Value;

		private EdDSASig __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AuthenticationVerify);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<ulong>? FeatureBits
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

		public override required EdDSASig Sig
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
		public tableReader_502716574ee143cdaef792e5ae13a4be_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_4b457e306495441985682c414225de43.FeatureBits);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EdDSASig ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.AuthenticationVerify.Sig");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NBABB3A7C5EDCFED4CA181418A5022BA1B472A2D0DCCC4A8A040AEC9112834221.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable AuthenticationVerify")]
	internal sealed class tableReader_502716574ee143cdaef792e5ae13a4be_GreedyMutable<TInputBuffer> : AuthenticationVerify, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<ulong>? __index0Value;

		private EdDSASig __index1Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AuthenticationVerify);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<ulong>? FeatureBits
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

		public override required EdDSASig Sig
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
		public tableReader_502716574ee143cdaef792e5ae13a4be_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ulong>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_4b457e306495441985682c414225de43.FeatureBits);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EdDSASig ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.AuthenticationVerify.Sig");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NBABB3A7C5EDCFED4CA181418A5022BA1B472A2D0DCCC4A8A040AEC9112834221.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_4b457e306495441985682c414225de43
	{
		public static readonly TableFieldContext FeatureBits = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.AuthenticationVerify.FeatureBits", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Sig = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.AuthenticationVerify.Sig", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(AuthenticationVerify value)
	{
		int num = 87;
		IList<ulong> featureBits = value.FeatureBits;
		if (featureBits != null)
		{
			num += FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.GetMaxSize(featureBits);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AuthenticationVerify value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(75, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 8;
		Span<byte> span2 = stackalloc byte[8];
		IList<ulong> featureBits = value.FeatureBits;
		EdDSASig sig = value.Sig;
		int num4 = num;
		if (featureBits != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 4);
		int num5 = num;
		num2 += SerializationHelpers.GetAlignmentError(num2, 1);
		num5 = num2;
		num2 += 64;
		FlatSharp.Compiler.Generated.NBABB3A7C5EDCFED4CA181418A5022BA1B472A2D0DCCC4A8A040AEC9112834221.Helpers.Serialize(spanWriter, span, sig, num5);
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 6);
		int num6 = num2 - num;
		context.Offset -= 75 - num6;
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)num3, 0);
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num6, 2);
		int num7 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num7, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NDE52D662B5A93C33926F2EF0FD6532C66D3C094343A1E5133FA68FF987719D55.Helpers.Serialize(spanWriter, span, featureBits, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_502716574ee143cdaef792e5ae13a4be_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_502716574ee143cdaef792e5ae13a4be_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_502716574ee143cdaef792e5ae13a4be_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_502716574ee143cdaef792e5ae13a4be_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_502716574ee143cdaef792e5ae13a4be_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_502716574ee143cdaef792e5ae13a4be_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_502716574ee143cdaef792e5ae13a4be_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_502716574ee143cdaef792e5ae13a4be_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
