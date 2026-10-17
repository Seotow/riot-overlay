using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB;
using FlatSharp.Compiler.Generated.N4149239C240B1BD81498B04FF9306967E78220A12725136220080F4E0B7059E7;
using FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED;
using FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N068A51452BC03E9A61AA9651462FB44A7C98ADC708958D44880A6A0B5EE68D7D;

internal static class Helpers
{
	[DebuggerDisplay("Lazy AnimationTrackState")]
	internal sealed class tableReader_f4f70b1a744b4b80af8c2266c2d05876_Lazy<TInputBuffer> : AnimationTrackState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationTrackState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override uint Track
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

		public override int Root
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

		public override float Weight
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

		public override AnimationBlendMode BlendMode
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

		public override IList<AnimationJointWeight>? JointWeights
		{
			get
			{
				return ReadIndex4Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_f4f70b1a744b4b80af8c2266c2d05876_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AnimationBlendMode ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return AnimationBlendMode.Normal;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4149239C240B1BD81498B04FF9306967E78220A12725136220080F4E0B7059E7.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationJointWeight>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_f3faff022f4a4b89a8e35898cf6781e6.JointWeights);
		}
	}

	[DebuggerDisplay("Progressive AnimationTrackState")]
	internal sealed class tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer> : AnimationTrackState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		private byte __mask0;

		private uint __index0Value;

		private int __index1Value;

		private float __index2Value;

		private AnimationBlendMode __index3Value;

		private IList<AnimationJointWeight>? __index4Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationTrackState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override uint Track
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

		public override int Root
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

		public override float Weight
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

		public override AnimationBlendMode BlendMode
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

		public override IList<AnimationJointWeight>? JointWeights
		{
			get
			{
				if ((__mask0 & 0x10) == 0)
				{
					__index4Value = ReadIndex4Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 16);
				}
				return __index4Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AnimationBlendMode ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return AnimationBlendMode.Normal;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4149239C240B1BD81498B04FF9306967E78220A12725136220080F4E0B7059E7.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationJointWeight>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_f3faff022f4a4b89a8e35898cf6781e6.JointWeights);
		}
	}

	[DebuggerDisplay("Greedy AnimationTrackState")]
	internal sealed class tableReader_f4f70b1a744b4b80af8c2266c2d05876_Greedy<TInputBuffer> : AnimationTrackState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private uint __index0Value;

		private int __index1Value;

		private float __index2Value;

		private AnimationBlendMode __index3Value;

		private IList<AnimationJointWeight>? __index4Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationTrackState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override uint Track
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

		public override int Root
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

		public override float Weight
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

		public override AnimationBlendMode BlendMode
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

		public override IList<AnimationJointWeight>? JointWeights
		{
			get
			{
				return __index4Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_f4f70b1a744b4b80af8c2266c2d05876_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AnimationBlendMode ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return AnimationBlendMode.Normal;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4149239C240B1BD81498B04FF9306967E78220A12725136220080F4E0B7059E7.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationJointWeight>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_f3faff022f4a4b89a8e35898cf6781e6.JointWeights);
		}
	}

	[DebuggerDisplay("GreedyMutable AnimationTrackState")]
	internal sealed class tableReader_f4f70b1a744b4b80af8c2266c2d05876_GreedyMutable<TInputBuffer> : AnimationTrackState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private uint __index0Value;

		private int __index1Value;

		private float __index2Value;

		private AnimationBlendMode __index3Value;

		private IList<AnimationJointWeight>? __index4Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationTrackState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override uint Track
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

		public override int Root
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

		public override float Weight
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

		public override AnimationBlendMode BlendMode
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

		public override IList<AnimationJointWeight>? JointWeights
		{
			get
			{
				return __index4Value;
			}
			set
			{
				__index4Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_f4f70b1a744b4b80af8c2266c2d05876_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AnimationBlendMode ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return AnimationBlendMode.Normal;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4149239C240B1BD81498B04FF9306967E78220A12725136220080F4E0B7059E7.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationJointWeight>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_f3faff022f4a4b89a8e35898cf6781e6.JointWeights);
		}
	}

	private static class tableMetadata_f3faff022f4a4b89a8e35898cf6781e6
	{
		public static readonly TableFieldContext Track = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationTrackState.Track", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Root = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationTrackState.Root", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Weight = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationTrackState.Weight", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BlendMode = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationTrackState.BlendMode", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext JointWeights = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationTrackState.JointWeights", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(AnimationTrackState value)
	{
		int num = 51;
		IList<AnimationJointWeight> jointWeights = value.JointWeights;
		if (jointWeights != null)
		{
			num += FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.GetMaxSize(jointWeights);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AnimationTrackState value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(33, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[14];
		uint track = value.Track;
		int root = value.Root;
		float weight = value.Weight;
		AnimationBlendMode blendMode = value.BlendMode;
		IList<AnimationJointWeight> jointWeights = value.JointWeights;
		int num4 = num;
		if (jointWeights != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 14;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 12);
		int num5 = num;
		if (weight != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, weight, num5);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 8);
		int num6 = num;
		if (root != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, root, num6);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 6);
		int num7 = num;
		if (track != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span, track, num7);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 4);
		int num8 = num;
		if (blendMode != AnimationBlendMode.Normal)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num8 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N4149239C240B1BD81498B04FF9306967E78220A12725136220080F4E0B7059E7.Helpers.Serialize(spanWriter, span, blendMode, num8);
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 10);
		int num9 = num2 - num;
		context.Offset -= 33 - num9;
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)num3, 0);
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)num9, 2);
		int num10 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num10, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Serialize(spanWriter, span, jointWeights, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_f4f70b1a744b4b80af8c2266c2d05876_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_f4f70b1a744b4b80af8c2266c2d05876_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_f4f70b1a744b4b80af8c2266c2d05876_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_f4f70b1a744b4b80af8c2266c2d05876_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_f4f70b1a744b4b80af8c2266c2d05876_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_f4f70b1a744b4b80af8c2266c2d05876_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_f4f70b1a744b4b80af8c2266c2d05876_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
