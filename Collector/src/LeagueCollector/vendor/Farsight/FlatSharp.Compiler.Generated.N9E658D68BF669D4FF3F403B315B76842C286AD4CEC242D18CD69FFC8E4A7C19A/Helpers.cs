using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A;
using FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54;
using FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N9E658D68BF669D4FF3F403B315B76842C286AD4CEC242D18CD69FFC8E4A7C19A;

internal static class Helpers
{
	[DebuggerDisplay("Lazy AITurretClient")]
	internal sealed class tableReader_cf68f355d6844fa981032c3111f4eeed_Lazy<TInputBuffer> : AITurretClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AITurretClient);

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

		public override sbyte PlateCount
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

		public override sbyte MaxPlateCount
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
		public tableReader_cf68f355d6844fa981032c3111f4eeed_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Info");
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static sbyte ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static sbyte ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive AITurretClient")]
	internal sealed class tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer> : AITurretClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private ObjectInfo __index0Value;

		private AIClient __index1Value;

		private sbyte __index2Value;

		private sbyte __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AITurretClient);

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

		public override sbyte PlateCount
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

		public override sbyte MaxPlateCount
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
		public tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Info");
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static sbyte ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static sbyte ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy AITurretClient")]
	internal sealed class tableReader_cf68f355d6844fa981032c3111f4eeed_Greedy<TInputBuffer> : AITurretClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private ObjectInfo __index0Value;

		private AIClient __index1Value;

		private sbyte __index2Value;

		private sbyte __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AITurretClient);

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

		public override sbyte PlateCount
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

		public override sbyte MaxPlateCount
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
		public tableReader_cf68f355d6844fa981032c3111f4eeed_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Info");
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static sbyte ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static sbyte ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable AITurretClient")]
	internal sealed class tableReader_cf68f355d6844fa981032c3111f4eeed_GreedyMutable<TInputBuffer> : AITurretClient, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private ObjectInfo __index0Value;

		private AIClient __index1Value;

		private sbyte __index2Value;

		private sbyte __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AITurretClient);

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

		public override sbyte PlateCount
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

		public override sbyte MaxPlateCount
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
		public tableReader_cf68f355d6844fa981032c3111f4eeed_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Info");
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Common");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static sbyte ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static sbyte ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_a10f1659595f43d9acc5075b0bf546e9
	{
		public static readonly TableFieldContext Info = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Info", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Common = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Common", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PlateCount = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.PlateCount", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext MaxPlateCount = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.MaxPlateCount", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(AITurretClient value)
	{
		int num = 36;
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
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AITurretClient value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(20, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 8;
		Span<byte> span2 = stackalloc byte[12];
		ObjectInfo info = value.Info;
		AIClient common = value.Common;
		sbyte plateCount = value.PlateCount;
		sbyte maxPlateCount = value.MaxPlateCount;
		int num4 = num;
		if (common != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Common");
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 6);
		int num5 = num;
		if ((object)info != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Snapshot.AITurretClient.Info");
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 4);
		int num6 = num;
		if (maxPlateCount != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num6 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Serialize(spanWriter, span, maxPlateCount, num6);
			num3 = 12;
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 10);
		int num7 = num;
		if (plateCount != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num7 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NF791D2E6738D8D71C1ED7ED9BDD6F7BD5F9764E8D74B3B291F9458C27ED6DFDB.Helpers.Serialize(spanWriter, span, plateCount, num7);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 8);
		int num8 = num2 - num;
		context.Offset -= 20 - num8;
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num3, 0);
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)num8, 2);
		int num9 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num9, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N0AB31769837D7E1AD9510971A8588D17ECF82462B8A462B47FAC6EFADF955B0A.Helpers.Serialize(spanWriter, span, common, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N9B36DBA80037657A9E2433F37F167BFF0285ABF059C9BCD536759F47D0A25D54.Helpers.Serialize(spanWriter, span, info, num5, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_cf68f355d6844fa981032c3111f4eeed_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_cf68f355d6844fa981032c3111f4eeed_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_cf68f355d6844fa981032c3111f4eeed_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_cf68f355d6844fa981032c3111f4eeed_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_cf68f355d6844fa981032c3111f4eeed_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_cf68f355d6844fa981032c3111f4eeed_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_cf68f355d6844fa981032c3111f4eeed_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
