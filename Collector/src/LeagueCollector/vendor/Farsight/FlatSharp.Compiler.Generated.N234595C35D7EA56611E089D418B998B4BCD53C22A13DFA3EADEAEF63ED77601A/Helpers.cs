using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245;
using FlatSharp.Compiler.Generated.N7F49058AC2F2F728E245616486DC7E1272E4E2FAFDDEB5CF5BD1F52035DDD710;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N234595C35D7EA56611E089D418B998B4BCD53C22A13DFA3EADEAEF63ED77601A;

internal static class Helpers
{
	[DebuggerDisplay("Lazy StreamTextureCreateSDPOffer")]
	internal sealed class tableReader_1f5ea307c70f4c348f7ccc429df23339_Lazy<TInputBuffer> : StreamTextureCreateSDPOffer, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StreamTextureCreateSDPOffer);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override AssetIdentifier? Ident
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

		public override IList<IceServer>? IceServers
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
		public tableReader_1f5ea307c70f4c348f7ccc429df23339_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Commands.StreamTextureCreateSDPOffer.Ident");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_Lazy(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<IceServer>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7F49058AC2F2F728E245616486DC7E1272E4E2FAFDDEB5CF5BD1F52035DDD710.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_ee31c9c290dd4d838a5c442dc6d91c64.IceServers);
		}
	}

	[DebuggerDisplay("Progressive StreamTextureCreateSDPOffer")]
	internal sealed class tableReader_1f5ea307c70f4c348f7ccc429df23339_Progressive<TInputBuffer> : StreamTextureCreateSDPOffer, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private AssetIdentifier? __index0Value;

		private IList<IceServer>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StreamTextureCreateSDPOffer);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override AssetIdentifier? Ident
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

		public override IList<IceServer>? IceServers
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
		public tableReader_1f5ea307c70f4c348f7ccc429df23339_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Commands.StreamTextureCreateSDPOffer.Ident");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_Progressive(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<IceServer>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7F49058AC2F2F728E245616486DC7E1272E4E2FAFDDEB5CF5BD1F52035DDD710.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_ee31c9c290dd4d838a5c442dc6d91c64.IceServers);
		}
	}

	[DebuggerDisplay("Greedy StreamTextureCreateSDPOffer")]
	internal sealed class tableReader_1f5ea307c70f4c348f7ccc429df23339_Greedy<TInputBuffer> : StreamTextureCreateSDPOffer, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private AssetIdentifier? __index0Value;

		private IList<IceServer>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StreamTextureCreateSDPOffer);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override AssetIdentifier? Ident
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

		public override IList<IceServer>? IceServers
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
		public tableReader_1f5ea307c70f4c348f7ccc429df23339_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Commands.StreamTextureCreateSDPOffer.Ident");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_Greedy(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<IceServer>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7F49058AC2F2F728E245616486DC7E1272E4E2FAFDDEB5CF5BD1F52035DDD710.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_ee31c9c290dd4d838a5c442dc6d91c64.IceServers);
		}
	}

	[DebuggerDisplay("GreedyMutable StreamTextureCreateSDPOffer")]
	internal sealed class tableReader_1f5ea307c70f4c348f7ccc429df23339_GreedyMutable<TInputBuffer> : StreamTextureCreateSDPOffer, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private AssetIdentifier? __index0Value;

		private IList<IceServer>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StreamTextureCreateSDPOffer);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override AssetIdentifier? Ident
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

		public override IList<IceServer>? IceServers
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
		public tableReader_1f5ea307c70f4c348f7ccc429df23339_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Commands.StreamTextureCreateSDPOffer.Ident");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_GreedyMutable(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<IceServer>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7F49058AC2F2F728E245616486DC7E1272E4E2FAFDDEB5CF5BD1F52035DDD710.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_ee31c9c290dd4d838a5c442dc6d91c64.IceServers);
		}
	}

	private static class tableMetadata_ee31c9c290dd4d838a5c442dc6d91c64
	{
		public static readonly TableFieldContext Ident = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StreamTextureCreateSDPOffer.Ident", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext IceServers = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StreamTextureCreateSDPOffer.IceServers", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(StreamTextureCreateSDPOffer value)
	{
		int num = 33;
		AssetIdentifier? ident = value.Ident;
		if (ident.HasValue)
		{
			num += FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.GetMaxSize(ident);
		}
		IList<IceServer> iceServers = value.IceServers;
		if (iceServers != null)
		{
			num += FlatSharp.Compiler.Generated.N7F49058AC2F2F728E245616486DC7E1272E4E2FAFDDEB5CF5BD1F52035DDD710.Helpers.GetMaxSize(iceServers);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, StreamTextureCreateSDPOffer value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(19, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[10];
		AssetIdentifier? ident = value.Ident;
		IList<IceServer> iceServers = value.IceServers;
		int num4 = num;
		if (iceServers != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 10;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 8);
		int num5 = num;
		if (ident.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 6);
		int num6 = num;
		if (ident.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num6 = num2;
			num2++;
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 4);
		int num7 = num2 - num;
		context.Offset -= 19 - num7;
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num3, 0);
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num7, 2);
		int num8 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num8, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N7F49058AC2F2F728E245616486DC7E1272E4E2FAFDDEB5CF5BD1F52035DDD710.Helpers.Serialize(spanWriter, span, iceServers, num4, context);
		}
		if (num6 != num)
		{
			(int, int) offset2 = (num6, num5);
			FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Serialize(spanWriter, span, ident, ref offset2, context, tableMetadata_ee31c9c290dd4d838a5c442dc6d91c64.Ident);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_1f5ea307c70f4c348f7ccc429df23339_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_1f5ea307c70f4c348f7ccc429df23339_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_1f5ea307c70f4c348f7ccc429df23339_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_1f5ea307c70f4c348f7ccc429df23339_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_1f5ea307c70f4c348f7ccc429df23339_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_1f5ea307c70f4c348f7ccc429df23339_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_1f5ea307c70f4c348f7ccc429df23339_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_1f5ea307c70f4c348f7ccc429df23339_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
