using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Entity;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N2BE949B829EBAAF98AD4594D221CEEB8E39B97C5883BD7823BD81E92AEF14B57;
using FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;
using FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E;
using FlatSharp.Compiler.Generated.NE93170A9F7099B77564121421C3A95C135BC51238E9C25736DA9CA5C5EFC1873;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N7A011B6A8B2F3AD3E3AD0D334BE4CB0763646E05D9F53C4379B0B460BA318942;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SceneEntityChanged")]
	internal sealed class tableReader_f6469243c85442c28facba12e835b949_Lazy<TInputBuffer> : SceneEntityChanged, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneEntityChanged);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override EntityEventKind Kind
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

		public override ulong EntityId
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

		public override uint SceneId
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

		public override IList<Component>? ChangedComponents
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
		public tableReader_f6469243c85442c28facba12e835b949_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EntityEventKind ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return EntityEventKind.Created;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2BE949B829EBAAF98AD4594D221CEEB8E39B97C5883BD7823BD81E92AEF14B57.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Component>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 3);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 4);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityChanged.ChangedComponents");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.NE93170A9F7099B77564121421C3A95C135BC51238E9C25736DA9CA5C5EFC1873.Helpers.Parse_Lazy(buffer, ref offset2, remainingDepth, tableMetadata_9a6d0c04b459457e8b4f7c459e6496cf.ChangedComponents);
		}
	}

	[DebuggerDisplay("Progressive SceneEntityChanged")]
	internal sealed class tableReader_f6469243c85442c28facba12e835b949_Progressive<TInputBuffer> : SceneEntityChanged, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		private byte __mask0;

		private EntityEventKind __index0Value;

		private ulong __index1Value;

		private uint __index2Value;

		private IList<Component>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneEntityChanged);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override EntityEventKind Kind
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

		public override ulong EntityId
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

		public override uint SceneId
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

		public override IList<Component>? ChangedComponents
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
		public tableReader_f6469243c85442c28facba12e835b949_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EntityEventKind ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return EntityEventKind.Created;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2BE949B829EBAAF98AD4594D221CEEB8E39B97C5883BD7823BD81E92AEF14B57.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Component>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 3);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 4);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityChanged.ChangedComponents");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.NE93170A9F7099B77564121421C3A95C135BC51238E9C25736DA9CA5C5EFC1873.Helpers.Parse_Progressive(buffer, ref offset2, remainingDepth, tableMetadata_9a6d0c04b459457e8b4f7c459e6496cf.ChangedComponents);
		}
	}

	[DebuggerDisplay("Greedy SceneEntityChanged")]
	internal sealed class tableReader_f6469243c85442c28facba12e835b949_Greedy<TInputBuffer> : SceneEntityChanged, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private EntityEventKind __index0Value;

		private ulong __index1Value;

		private uint __index2Value;

		private IList<Component>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneEntityChanged);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override EntityEventKind Kind
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

		public override ulong EntityId
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

		public override uint SceneId
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

		public override IList<Component>? ChangedComponents
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
		public tableReader_f6469243c85442c28facba12e835b949_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EntityEventKind ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return EntityEventKind.Created;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2BE949B829EBAAF98AD4594D221CEEB8E39B97C5883BD7823BD81E92AEF14B57.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Component>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 3);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 4);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityChanged.ChangedComponents");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.NE93170A9F7099B77564121421C3A95C135BC51238E9C25736DA9CA5C5EFC1873.Helpers.Parse_Greedy(buffer, ref offset2, remainingDepth, tableMetadata_9a6d0c04b459457e8b4f7c459e6496cf.ChangedComponents);
		}
	}

	[DebuggerDisplay("GreedyMutable SceneEntityChanged")]
	internal sealed class tableReader_f6469243c85442c28facba12e835b949_GreedyMutable<TInputBuffer> : SceneEntityChanged, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private EntityEventKind __index0Value;

		private ulong __index1Value;

		private uint __index2Value;

		private IList<Component>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneEntityChanged);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override EntityEventKind Kind
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

		public override ulong EntityId
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

		public override uint SceneId
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

		public override IList<Component>? ChangedComponents
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
		public tableReader_f6469243c85442c28facba12e835b949_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static EntityEventKind ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return EntityEventKind.Created;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2BE949B829EBAAF98AD4594D221CEEB8E39B97C5883BD7823BD81E92AEF14B57.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Component>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 3);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 4);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityChanged.ChangedComponents");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.NE93170A9F7099B77564121421C3A95C135BC51238E9C25736DA9CA5C5EFC1873.Helpers.Parse_GreedyMutable(buffer, ref offset2, remainingDepth, tableMetadata_9a6d0c04b459457e8b4f7c459e6496cf.ChangedComponents);
		}
	}

	private static class tableMetadata_9a6d0c04b459457e8b4f7c459e6496cf
	{
		public static readonly TableFieldContext Kind = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityChanged.Kind", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext EntityId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityChanged.EntityId", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SceneId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityChanged.SceneId", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ChangedComponents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneEntityChanged.ChangedComponents", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SceneEntityChanged value)
	{
		int num = 59;
		IList<Component> changedComponents = value.ChangedComponents;
		if (changedComponents != null)
		{
			num += FlatSharp.Compiler.Generated.NE93170A9F7099B77564121421C3A95C135BC51238E9C25736DA9CA5C5EFC1873.Helpers.GetMaxSize(changedComponents);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SceneEntityChanged value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(41, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[14];
		EntityEventKind kind = value.Kind;
		ulong entityId = value.EntityId;
		uint sceneId = value.SceneId;
		IList<Component> changedComponents = value.ChangedComponents;
		int num4 = num;
		if (entityId != 0L)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 8);
			num4 = num2;
			num2 += 8;
			FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Serialize(spanWriter, span, entityId, num4);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 6);
		int num5 = num;
		if (changedComponents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 10);
		int num6 = num;
		if (changedComponents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			num3 = 14;
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 12);
		int num7 = num;
		if (sceneId != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span, sceneId, num7);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 8);
		int num8 = num;
		if (kind != EntityEventKind.Created)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num8 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N2BE949B829EBAAF98AD4594D221CEEB8E39B97C5883BD7823BD81E92AEF14B57.Helpers.Serialize(spanWriter, span, kind, num8);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 4);
		int num9 = num2 - num;
		context.Offset -= 41 - num9;
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)num3, 0);
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)num9, 2);
		int num10 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num10, num);
		if (num5 != num)
		{
			(int, int) offset2 = (num5, num6);
			FlatSharp.Compiler.Generated.NE93170A9F7099B77564121421C3A95C135BC51238E9C25736DA9CA5C5EFC1873.Helpers.Serialize(spanWriter, span, changedComponents, ref offset2, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_f6469243c85442c28facba12e835b949_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_f6469243c85442c28facba12e835b949_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_f6469243c85442c28facba12e835b949_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_f6469243c85442c28facba12e835b949_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_f6469243c85442c28facba12e835b949_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_f6469243c85442c28facba12e835b949_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_f6469243c85442c28facba12e835b949_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_f6469243c85442c28facba12e835b949_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
