using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797;
using FlatSharp.Compiler.Generated.N458C622320A99A91A1C595A76A0234AC9B81530EBB97A198CB9D8C4B1FAEAEAE;
using FlatSharp.Compiler.Generated.N8C1BE97D73CE1CA3945B9615A74F60AD0FC89A493EEE87D606F8CBC96FE79C4E;
using FlatSharp.Compiler.Generated.NC317D04C31680DABBDFF5D09FF684F6B370B2B8BE89F64B855B7FE227F4CDF94;
using FlatSharp.Compiler.Generated.NE2E38BB1398B3E91EA2650EE9182665155AE39AB13FA5ACE38604521C29868F1;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N23B76832F8041F4B7E75B821F9D7EE35C12C991B8208D0C437B1457AE9524A28;

internal static class Helpers
{
	[DebuggerDisplay("Lazy AnimationState")]
	internal sealed class tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Lazy<TInputBuffer> : AnimationState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override ushort Version
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

		public override AnimationStateStatus Status
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

		public override IList<AnimationContribution>? Contributions
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

		public override IList<AnimationPoseNode>? Poses
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

		public override IList<AnimationTrackState>? Tracks
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
		public tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ushort ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AnimationStateStatus ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return AnimationStateStatus.Unavailable;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE2E38BB1398B3E91EA2650EE9182665155AE39AB13FA5ACE38604521C29868F1.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationContribution>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC317D04C31680DABBDFF5D09FF684F6B370B2B8BE89F64B855B7FE227F4CDF94.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Contributions);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationPoseNode>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8C1BE97D73CE1CA3945B9615A74F60AD0FC89A493EEE87D606F8CBC96FE79C4E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Poses);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationTrackState>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N458C622320A99A91A1C595A76A0234AC9B81530EBB97A198CB9D8C4B1FAEAEAE.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Tracks);
		}
	}

	[DebuggerDisplay("Progressive AnimationState")]
	internal sealed class tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Progressive<TInputBuffer> : AnimationState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		private byte __mask0;

		private ushort __index0Value;

		private AnimationStateStatus __index1Value;

		private IList<AnimationContribution>? __index2Value;

		private IList<AnimationPoseNode>? __index3Value;

		private IList<AnimationTrackState>? __index4Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override ushort Version
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

		public override AnimationStateStatus Status
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

		public override IList<AnimationContribution>? Contributions
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

		public override IList<AnimationPoseNode>? Poses
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

		public override IList<AnimationTrackState>? Tracks
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
		public tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ushort ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AnimationStateStatus ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return AnimationStateStatus.Unavailable;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE2E38BB1398B3E91EA2650EE9182665155AE39AB13FA5ACE38604521C29868F1.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationContribution>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC317D04C31680DABBDFF5D09FF684F6B370B2B8BE89F64B855B7FE227F4CDF94.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Contributions);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationPoseNode>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8C1BE97D73CE1CA3945B9615A74F60AD0FC89A493EEE87D606F8CBC96FE79C4E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Poses);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationTrackState>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N458C622320A99A91A1C595A76A0234AC9B81530EBB97A198CB9D8C4B1FAEAEAE.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Tracks);
		}
	}

	[DebuggerDisplay("Greedy AnimationState")]
	internal sealed class tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Greedy<TInputBuffer> : AnimationState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private ushort __index0Value;

		private AnimationStateStatus __index1Value;

		private IList<AnimationContribution>? __index2Value;

		private IList<AnimationPoseNode>? __index3Value;

		private IList<AnimationTrackState>? __index4Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override ushort Version
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

		public override AnimationStateStatus Status
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

		public override IList<AnimationContribution>? Contributions
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

		public override IList<AnimationPoseNode>? Poses
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

		public override IList<AnimationTrackState>? Tracks
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
		public tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
		private static ushort ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AnimationStateStatus ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return AnimationStateStatus.Unavailable;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE2E38BB1398B3E91EA2650EE9182665155AE39AB13FA5ACE38604521C29868F1.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationContribution>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC317D04C31680DABBDFF5D09FF684F6B370B2B8BE89F64B855B7FE227F4CDF94.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Contributions);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationPoseNode>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8C1BE97D73CE1CA3945B9615A74F60AD0FC89A493EEE87D606F8CBC96FE79C4E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Poses);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationTrackState>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N458C622320A99A91A1C595A76A0234AC9B81530EBB97A198CB9D8C4B1FAEAEAE.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Tracks);
		}
	}

	[DebuggerDisplay("GreedyMutable AnimationState")]
	internal sealed class tableReader_eaedc153ab094e2995f5bf5c8bbceaee_GreedyMutable<TInputBuffer> : AnimationState, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private ushort __index0Value;

		private AnimationStateStatus __index1Value;

		private IList<AnimationContribution>? __index2Value;

		private IList<AnimationPoseNode>? __index3Value;

		private IList<AnimationTrackState>? __index4Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationState);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override ushort Version
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

		public override AnimationStateStatus Status
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

		public override IList<AnimationContribution>? Contributions
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

		public override IList<AnimationPoseNode>? Poses
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

		public override IList<AnimationTrackState>? Tracks
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
		public tableReader_eaedc153ab094e2995f5bf5c8bbceaee_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
		private static ushort ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AnimationStateStatus ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return AnimationStateStatus.Unavailable;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE2E38BB1398B3E91EA2650EE9182665155AE39AB13FA5ACE38604521C29868F1.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationContribution>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC317D04C31680DABBDFF5D09FF684F6B370B2B8BE89F64B855B7FE227F4CDF94.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Contributions);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationPoseNode>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8C1BE97D73CE1CA3945B9615A74F60AD0FC89A493EEE87D606F8CBC96FE79C4E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Poses);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationTrackState>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N458C622320A99A91A1C595A76A0234AC9B81530EBB97A198CB9D8C4B1FAEAEAE.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_5d739abb404b405193679f2bc8d8fd69.Tracks);
		}
	}

	private static class tableMetadata_5d739abb404b405193679f2bc8d8fd69
	{
		public static readonly TableFieldContext Version = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationState.Version", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Status = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationState.Status", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Contributions = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationState.Contributions", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Poses = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationState.Poses", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Tracks = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationState.Tracks", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(AnimationState value)
	{
		int num = 47;
		IList<AnimationContribution> contributions = value.Contributions;
		if (contributions != null)
		{
			num += FlatSharp.Compiler.Generated.NC317D04C31680DABBDFF5D09FF684F6B370B2B8BE89F64B855B7FE227F4CDF94.Helpers.GetMaxSize(contributions);
		}
		IList<AnimationPoseNode> poses = value.Poses;
		if (poses != null)
		{
			num += FlatSharp.Compiler.Generated.N8C1BE97D73CE1CA3945B9615A74F60AD0FC89A493EEE87D606F8CBC96FE79C4E.Helpers.GetMaxSize(poses);
		}
		IList<AnimationTrackState> tracks = value.Tracks;
		if (tracks != null)
		{
			num += FlatSharp.Compiler.Generated.N458C622320A99A91A1C595A76A0234AC9B81530EBB97A198CB9D8C4B1FAEAEAE.Helpers.GetMaxSize(tracks);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AnimationState value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(29, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[14];
		ushort version = value.Version;
		AnimationStateStatus status = value.Status;
		IList<AnimationContribution> contributions = value.Contributions;
		IList<AnimationPoseNode> poses = value.Poses;
		IList<AnimationTrackState> tracks = value.Tracks;
		int num4 = num;
		if (tracks != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 14;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 12);
		int num5 = num;
		if (poses != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 10);
		int num6 = num;
		if (contributions != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 8);
		int num7 = num;
		if (version != 1)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 2);
			num7 = num2;
			num2 += 2;
			FlatSharp.Compiler.Generated.N0AFFB983BCD73E3E4397419443518E0C3146D1C306BE83ED1DC16963F22F2797.Helpers.Serialize(spanWriter, span, version, num7);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 4);
		int num8 = num;
		if (status != AnimationStateStatus.Unavailable)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num8 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NE2E38BB1398B3E91EA2650EE9182665155AE39AB13FA5ACE38604521C29868F1.Helpers.Serialize(spanWriter, span, status, num8);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 6);
		int num9 = num2 - num;
		context.Offset -= 29 - num9;
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)num3, 0);
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)num9, 2);
		int num10 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num10, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N458C622320A99A91A1C595A76A0234AC9B81530EBB97A198CB9D8C4B1FAEAEAE.Helpers.Serialize(spanWriter, span, tracks, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N8C1BE97D73CE1CA3945B9615A74F60AD0FC89A493EEE87D606F8CBC96FE79C4E.Helpers.Serialize(spanWriter, span, poses, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.NC317D04C31680DABBDFF5D09FF684F6B370B2B8BE89F64B855B7FE227F4CDF94.Helpers.Serialize(spanWriter, span, contributions, num6, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_eaedc153ab094e2995f5bf5c8bbceaee_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_eaedc153ab094e2995f5bf5c8bbceaee_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_eaedc153ab094e2995f5bf5c8bbceaee_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
