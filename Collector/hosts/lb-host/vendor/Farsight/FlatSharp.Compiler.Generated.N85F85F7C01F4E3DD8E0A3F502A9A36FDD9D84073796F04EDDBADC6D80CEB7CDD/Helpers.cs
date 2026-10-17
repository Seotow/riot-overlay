using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB;
using FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N85F85F7C01F4E3DD8E0A3F502A9A36FDD9D84073796F04EDDBADC6D80CEB7CDD;

internal static class Helpers
{
	[DebuggerDisplay("Lazy AnimationPoseNode")]
	internal sealed class tableReader_9cc585a028b04798a1ca579fe85d5f13_Lazy<TInputBuffer> : AnimationPoseNode, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationPoseNode);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override int Contribution
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

		public override int From
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

		public override int To
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

		public override float Alpha
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

		public override IList<AnimationJointWeight>? JointAlphas
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

		public override IList<AnimationJointWeight>? SampleWeights
		{
			get
			{
				return ReadIndex5Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool Spherical
		{
			get
			{
				return ReadIndex6Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_9cc585a028b04798a1ca579fe85d5f13_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_35b39f0b1f2d4a1ca8c40ff4995847d2.JointAlphas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationJointWeight>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_35b39f0b1f2d4a1ca8c40ff4995847d2.SampleWeights);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive AnimationPoseNode")]
	internal sealed class tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer> : AnimationPoseNode, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		private byte __mask0;

		private int __index0Value;

		private int __index1Value;

		private int __index2Value;

		private float __index3Value;

		private IList<AnimationJointWeight>? __index4Value;

		private IList<AnimationJointWeight>? __index5Value;

		private bool __index6Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationPoseNode);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override int Contribution
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

		public override int From
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

		public override int To
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

		public override float Alpha
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

		public override IList<AnimationJointWeight>? JointAlphas
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

		public override IList<AnimationJointWeight>? SampleWeights
		{
			get
			{
				if ((__mask0 & 0x20) == 0)
				{
					__index5Value = ReadIndex5Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 32);
				}
				return __index5Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool Spherical
		{
			get
			{
				if ((__mask0 & 0x40) == 0)
				{
					__index6Value = ReadIndex6Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 64);
				}
				return __index6Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_35b39f0b1f2d4a1ca8c40ff4995847d2.JointAlphas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationJointWeight>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_35b39f0b1f2d4a1ca8c40ff4995847d2.SampleWeights);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy AnimationPoseNode")]
	internal sealed class tableReader_9cc585a028b04798a1ca579fe85d5f13_Greedy<TInputBuffer> : AnimationPoseNode, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private int __index0Value;

		private int __index1Value;

		private int __index2Value;

		private float __index3Value;

		private IList<AnimationJointWeight>? __index4Value;

		private IList<AnimationJointWeight>? __index5Value;

		private bool __index6Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationPoseNode);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override int Contribution
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

		public override int From
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

		public override int To
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

		public override float Alpha
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

		public override IList<AnimationJointWeight>? JointAlphas
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

		public override IList<AnimationJointWeight>? SampleWeights
		{
			get
			{
				return __index5Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool Spherical
		{
			get
			{
				return __index6Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_9cc585a028b04798a1ca579fe85d5f13_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_35b39f0b1f2d4a1ca8c40ff4995847d2.JointAlphas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationJointWeight>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_35b39f0b1f2d4a1ca8c40ff4995847d2.SampleWeights);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable AnimationPoseNode")]
	internal sealed class tableReader_9cc585a028b04798a1ca579fe85d5f13_GreedyMutable<TInputBuffer> : AnimationPoseNode, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private int __index0Value;

		private int __index1Value;

		private int __index2Value;

		private float __index3Value;

		private IList<AnimationJointWeight>? __index4Value;

		private IList<AnimationJointWeight>? __index5Value;

		private bool __index6Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AnimationPoseNode);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override int Contribution
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

		public override int From
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

		public override int To
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

		public override float Alpha
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

		public override IList<AnimationJointWeight>? JointAlphas
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

		public override IList<AnimationJointWeight>? SampleWeights
		{
			get
			{
				return __index5Value;
			}
			set
			{
				__index5Value = value;
			}
		}

		public override bool Spherical
		{
			get
			{
				return __index6Value;
			}
			set
			{
				__index6Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_9cc585a028b04798a1ca579fe85d5f13_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return -1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
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
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_35b39f0b1f2d4a1ca8c40ff4995847d2.JointAlphas);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationJointWeight>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_35b39f0b1f2d4a1ca8c40ff4995847d2.SampleWeights);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_35b39f0b1f2d4a1ca8c40ff4995847d2
	{
		public static readonly TableFieldContext Contribution = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationPoseNode.Contribution", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext From = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationPoseNode.From", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext To = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationPoseNode.To", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Alpha = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationPoseNode.Alpha", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext JointAlphas = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationPoseNode.JointAlphas", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SampleWeights = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationPoseNode.SampleWeights", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Spherical = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.AnimationPoseNode.Spherical", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(AnimationPoseNode value)
	{
		int num = 69;
		IList<AnimationJointWeight> jointAlphas = value.JointAlphas;
		if (jointAlphas != null)
		{
			num += FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.GetMaxSize(jointAlphas);
		}
		IList<AnimationJointWeight> sampleWeights = value.SampleWeights;
		if (sampleWeights != null)
		{
			num += FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.GetMaxSize(sampleWeights);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AnimationPoseNode value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(47, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[18];
		int contribution = value.Contribution;
		int num4 = value.From;
		int to = value.To;
		float alpha = value.Alpha;
		IList<AnimationJointWeight> jointAlphas = value.JointAlphas;
		IList<AnimationJointWeight> sampleWeights = value.SampleWeights;
		bool spherical = value.Spherical;
		int num5 = num;
		if (sampleWeights != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num5 - num), 14);
		int num6 = num;
		if (jointAlphas != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num6 - num), 12);
		int num7 = num;
		if (alpha != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, alpha, num7);
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num7 - num), 10);
		int num8 = num;
		if (to != -1)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, to, num8);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num8 - num), 8);
		int num9 = num;
		if (num4 != -1)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, num4, num9);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num9 - num), 6);
		int num10 = num;
		if (contribution != -1)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, contribution, num10);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num10 - num), 4);
		int num11 = num;
		if (spherical)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num11 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, spherical, num11);
			num3 = 18;
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num11 - num), 16);
		int num12 = num2 - num;
		context.Offset -= 47 - num12;
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)num3, 0);
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)num12, 2);
		int num13 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num13, num);
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Serialize(spanWriter, span, sampleWeights, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.N4E2A080640302FC54724798718A19EC6610BD44DB70840A294C1492E0022D9ED.Helpers.Serialize(spanWriter, span, jointAlphas, num6, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9cc585a028b04798a1ca579fe85d5f13_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9cc585a028b04798a1ca579fe85d5f13_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9cc585a028b04798a1ca579fe85d5f13_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9cc585a028b04798a1ca579fe85d5f13_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9cc585a028b04798a1ca579fe85d5f13_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9cc585a028b04798a1ca579fe85d5f13_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9cc585a028b04798a1ca579fe85d5f13_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
