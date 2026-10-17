using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A;
using FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54;
using FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F;
using FlatSharp.Compiler.Generated.NFF189ABB865665A0F89AA3FEB083BA228D7F0B633D16B74B3AD68B3FD86563F6;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N5867525DCCF5EE4F97804CC2B1C8847B92BD786B7860871AEA9A05526F9EC1B9;

internal static class Helpers
{
	[DebuggerDisplay("Lazy AIMinionClient")]
	internal sealed class tableReader_8d8fedf7623248ff853123763aa3ef2d_Lazy<TInputBuffer> : AIMinionClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AIMinionClient);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required ObjectInfo Info
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

		public override required AIClient Common
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

		public override AIMinionClientTypeInfo TypeInfo
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

		public override IList<Bone>? Bones
		{
			get
			{
				return ReadIndex3Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_8d8fedf7623248ff853123763aa3ef2d_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ObjectInfo ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Info");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIClient ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIMinionClientTypeInfo ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return (AIMinionClientTypeInfo)0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFF189ABB865665A0F89AA3FEB083BA228D7F0B633D16B74B3AD68B3FD86563F6.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Bone>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7441513a11804cb7ab3df5cbe5a4f203.Bones);
		}
	}

	[DebuggerDisplay("Progressive AIMinionClient")]
	internal sealed class tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer> : AIMinionClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private ObjectInfo __index0Value;

		private AIClient __index1Value;

		private AIMinionClientTypeInfo __index2Value;

		private IList<Bone>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AIMinionClient);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required ObjectInfo Info
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

		public override required AIClient Common
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

		public override AIMinionClientTypeInfo TypeInfo
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

		public override IList<Bone>? Bones
		{
			get
			{
				if ((__mask0 & 8) == 0)
				{
					__index3Value = ReadIndex3Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 8);
				}
				return __index3Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			__index0Value = null;
			__index1Value = null;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ObjectInfo ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Info");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIClient ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIMinionClientTypeInfo ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return (AIMinionClientTypeInfo)0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFF189ABB865665A0F89AA3FEB083BA228D7F0B633D16B74B3AD68B3FD86563F6.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Bone>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7441513a11804cb7ab3df5cbe5a4f203.Bones);
		}
	}

	[DebuggerDisplay("Greedy AIMinionClient")]
	internal sealed class tableReader_8d8fedf7623248ff853123763aa3ef2d_Greedy<TInputBuffer> : AIMinionClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private ObjectInfo __index0Value;

		private AIClient __index1Value;

		private AIMinionClientTypeInfo __index2Value;

		private IList<Bone>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AIMinionClient);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required ObjectInfo Info
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

		public override required AIClient Common
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

		public override AIMinionClientTypeInfo TypeInfo
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

		public override IList<Bone>? Bones
		{
			get
			{
				return __index3Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_8d8fedf7623248ff853123763aa3ef2d_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ObjectInfo ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Info");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIClient ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIMinionClientTypeInfo ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return (AIMinionClientTypeInfo)0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFF189ABB865665A0F89AA3FEB083BA228D7F0B633D16B74B3AD68B3FD86563F6.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Bone>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7441513a11804cb7ab3df5cbe5a4f203.Bones);
		}
	}

	[DebuggerDisplay("GreedyMutable AIMinionClient")]
	internal sealed class tableReader_8d8fedf7623248ff853123763aa3ef2d_GreedyMutable<TInputBuffer> : AIMinionClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private ObjectInfo __index0Value;

		private AIClient __index1Value;

		private AIMinionClientTypeInfo __index2Value;

		private IList<Bone>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AIMinionClient);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required ObjectInfo Info
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

		public override required AIClient Common
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

		public override AIMinionClientTypeInfo TypeInfo
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

		public override IList<Bone>? Bones
		{
			get
			{
				return __index3Value;
			}
			set
			{
				__index3Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_8d8fedf7623248ff853123763aa3ef2d_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ObjectInfo ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Info");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIClient ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AIMinionClientTypeInfo ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return (AIMinionClientTypeInfo)0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFF189ABB865665A0F89AA3FEB083BA228D7F0B633D16B74B3AD68B3FD86563F6.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Bone>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7441513a11804cb7ab3df5cbe5a4f203.Bones);
		}
	}

	private static class tableMetadata_7441513a11804cb7ab3df5cbe5a4f203
	{
		public static readonly TableFieldContext Info = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Info", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Common = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Common", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext TypeInfo = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.TypeInfo", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Bones = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Bones", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(AIMinionClient value)
	{
		int num = 42;
		ObjectInfo info = value.Info;
		if ((object)info != null)
		{
			num += FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.GetMaxSize(info);
		}
		AIClient common = value.Common;
		if (common != null)
		{
			num += FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.GetMaxSize(common);
		}
		IList<Bone> bones = value.Bones;
		if (bones != null)
		{
			num += FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.GetMaxSize(bones);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AIMinionClient value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(26, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 8;
		Span<byte> span2 = stackalloc byte[12];
		ObjectInfo info = value.Info;
		AIClient common = value.Common;
		AIMinionClientTypeInfo typeInfo = value.TypeInfo;
		IList<Bone> bones = value.Bones;
		int num4 = num;
		if (bones != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 12;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 10);
		int num5 = num;
		if (common != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Common");
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 6);
		int num6 = num;
		if ((object)info != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AIMinionClient.Info");
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 4);
		int num7 = num;
		if (typeInfo != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num7 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NFF189ABB865665A0F89AA3FEB083BA228D7F0B633D16B74B3AD68B3FD86563F6.Helpers.Serialize(spanWriter, span, typeInfo, num7);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 8);
		int num8 = num2 - num;
		context.Offset -= 26 - num8;
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num3, 0);
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)num8, 2);
		int num9 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num9, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NC3DE283979E9B993AF75B626AE77EA955D33ED7E601BA991BBDBE99F2183894F.Helpers.Serialize(spanWriter, span, bones, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Serialize(spanWriter, span, common, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Serialize(spanWriter, span, info, num6, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8d8fedf7623248ff853123763aa3ef2d_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8d8fedf7623248ff853123763aa3ef2d_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8d8fedf7623248ff853123763aa3ef2d_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8d8fedf7623248ff853123763aa3ef2d_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8d8fedf7623248ff853123763aa3ef2d_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_8d8fedf7623248ff853123763aa3ef2d_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_8d8fedf7623248ff853123763aa3ef2d_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
