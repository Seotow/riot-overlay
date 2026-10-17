using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Entity;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Compiler.Generated.NF0F5809FE9A86F27BF245EFF1432E32F6E84230801E4D289D9FB67F26A6E79EB;
using FlatSharp.Compiler.Generated.NF3A4CF95196BBD7102F27A90B7BDABD54B9BF4F42F9C973A9120CA70AED5C267;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N11BDFB110B0C663C92CA2111B8AEDA2B3D491ED4C86D2C48EBD45BA9F3487431;

internal static class Helpers
{
	[DebuggerDisplay("Lazy ComponentMeshRenderer")]
	internal sealed class tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Lazy<TInputBuffer> : ComponentMeshRenderer, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ComponentMeshRenderer);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override AssetIdentifier? Model
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

		public override AssetIdentifier? OverrideTexture
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

		public override string? AnimationName
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

		public override float AnimationTime
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

		public override float AnimationSpeed
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

		public override bool AnimationLoop
		{
			get
			{
				return ReadIndex7Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool AnimationPlaying
		{
			get
			{
				return ReadIndex8Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool StateMachineEnabled
		{
			get
			{
				return ReadIndex9Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override string? EntryState
		{
			get
			{
				return ReadIndex10Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<AnimationStateDefinition>? AnimationStates
		{
			get
			{
				return ReadIndex11Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<AnimationTransitionDefinition>? AnimationTransitions
		{
			get
			{
				return ReadIndex12Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.Model");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_Lazy(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 2);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 3);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.OverrideTexture");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_Lazy(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationStateDefinition>? ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF0F5809FE9A86F27BF245EFF1432E32F6E84230801E4D289D9FB67F26A6E79EB.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.AnimationStates);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationTransitionDefinition>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF3A4CF95196BBD7102F27A90B7BDABD54B9BF4F42F9C973A9120CA70AED5C267.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.AnimationTransitions);
		}
	}

	[DebuggerDisplay("Progressive ComponentMeshRenderer")]
	internal sealed class tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Progressive<TInputBuffer> : ComponentMeshRenderer, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private AssetIdentifier? __index0Value;

		private AssetIdentifier? __index2Value;

		private string? __index4Value;

		private float __index5Value;

		private float __index6Value;

		private bool __index7Value;

		private byte __mask1;

		private bool __index8Value;

		private bool __index9Value;

		private string? __index10Value;

		private IList<AnimationStateDefinition>? __index11Value;

		private IList<AnimationTransitionDefinition>? __index12Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ComponentMeshRenderer);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override AssetIdentifier? Model
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

		public override AssetIdentifier? OverrideTexture
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

		public override string? AnimationName
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

		public override float AnimationTime
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

		public override float AnimationSpeed
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

		public override bool AnimationLoop
		{
			get
			{
				if ((__mask0 & 0x80) == 0)
				{
					__index7Value = ReadIndex7Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 128);
				}
				return __index7Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool AnimationPlaying
		{
			get
			{
				if ((__mask1 & 1) == 0)
				{
					__index8Value = ReadIndex8Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 1);
				}
				return __index8Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool StateMachineEnabled
		{
			get
			{
				if ((__mask1 & 2) == 0)
				{
					__index9Value = ReadIndex9Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 2);
				}
				return __index9Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override string? EntryState
		{
			get
			{
				if ((__mask1 & 4) == 0)
				{
					__index10Value = ReadIndex10Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 4);
				}
				return __index10Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<AnimationStateDefinition>? AnimationStates
		{
			get
			{
				if ((__mask1 & 8) == 0)
				{
					__index11Value = ReadIndex11Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 8);
				}
				return __index11Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<AnimationTransitionDefinition>? AnimationTransitions
		{
			get
			{
				if ((__mask1 & 0x10) == 0)
				{
					__index12Value = ReadIndex12Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 16);
				}
				return __index12Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.Model");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_Progressive(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 2);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 3);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.OverrideTexture");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_Progressive(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationStateDefinition>? ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF0F5809FE9A86F27BF245EFF1432E32F6E84230801E4D289D9FB67F26A6E79EB.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.AnimationStates);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationTransitionDefinition>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF3A4CF95196BBD7102F27A90B7BDABD54B9BF4F42F9C973A9120CA70AED5C267.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.AnimationTransitions);
		}
	}

	[DebuggerDisplay("Greedy ComponentMeshRenderer")]
	internal sealed class tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Greedy<TInputBuffer> : ComponentMeshRenderer, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private AssetIdentifier? __index0Value;

		private AssetIdentifier? __index2Value;

		private string? __index4Value;

		private float __index5Value;

		private float __index6Value;

		private bool __index7Value;

		private bool __index8Value;

		private bool __index9Value;

		private string? __index10Value;

		private IList<AnimationStateDefinition>? __index11Value;

		private IList<AnimationTransitionDefinition>? __index12Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ComponentMeshRenderer);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override AssetIdentifier? Model
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

		public override AssetIdentifier? OverrideTexture
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

		public override string? AnimationName
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

		public override float AnimationTime
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

		public override float AnimationSpeed
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

		public override bool AnimationLoop
		{
			get
			{
				return __index7Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool AnimationPlaying
		{
			get
			{
				return __index8Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool StateMachineEnabled
		{
			get
			{
				return __index9Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override string? EntryState
		{
			get
			{
				return __index10Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<AnimationStateDefinition>? AnimationStates
		{
			get
			{
				return __index11Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<AnimationTransitionDefinition>? AnimationTransitions
		{
			get
			{
				return __index12Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTableGeneric.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, item, remainingDepth);
			__index8Value = ReadIndex8Value(buffer, offset, item, remainingDepth);
			__index9Value = ReadIndex9Value(buffer, offset, item, remainingDepth);
			__index10Value = ReadIndex10Value(buffer, offset, item, remainingDepth);
			__index11Value = ReadIndex11Value(buffer, offset, item, remainingDepth);
			__index12Value = ReadIndex12Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.Model");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_Greedy(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 2);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 3);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.OverrideTexture");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_Greedy(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationStateDefinition>? ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF0F5809FE9A86F27BF245EFF1432E32F6E84230801E4D289D9FB67F26A6E79EB.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.AnimationStates);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationTransitionDefinition>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF3A4CF95196BBD7102F27A90B7BDABD54B9BF4F42F9C973A9120CA70AED5C267.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.AnimationTransitions);
		}
	}

	[DebuggerDisplay("GreedyMutable ComponentMeshRenderer")]
	internal sealed class tableReader_08ae17e5f3e54189afd5bf14f73e43f7_GreedyMutable<TInputBuffer> : ComponentMeshRenderer, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private AssetIdentifier? __index0Value;

		private AssetIdentifier? __index2Value;

		private string? __index4Value;

		private float __index5Value;

		private float __index6Value;

		private bool __index7Value;

		private bool __index8Value;

		private bool __index9Value;

		private string? __index10Value;

		private IList<AnimationStateDefinition>? __index11Value;

		private IList<AnimationTransitionDefinition>? __index12Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ComponentMeshRenderer);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override AssetIdentifier? Model
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

		public override AssetIdentifier? OverrideTexture
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

		public override string? AnimationName
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

		public override float AnimationTime
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

		public override float AnimationSpeed
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

		public override bool AnimationLoop
		{
			get
			{
				return __index7Value;
			}
			set
			{
				__index7Value = value;
			}
		}

		public override bool AnimationPlaying
		{
			get
			{
				return __index8Value;
			}
			set
			{
				__index8Value = value;
			}
		}

		public override bool StateMachineEnabled
		{
			get
			{
				return __index9Value;
			}
			set
			{
				__index9Value = value;
			}
		}

		public override string? EntryState
		{
			get
			{
				return __index10Value;
			}
			set
			{
				__index10Value = value;
			}
		}

		public override IList<AnimationStateDefinition>? AnimationStates
		{
			get
			{
				return __index11Value;
			}
			set
			{
				__index11Value = value;
			}
		}

		public override IList<AnimationTransitionDefinition>? AnimationTransitions
		{
			get
			{
				return __index12Value;
			}
			set
			{
				__index12Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_08ae17e5f3e54189afd5bf14f73e43f7_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTableGeneric.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, item, remainingDepth);
			__index8Value = ReadIndex8Value(buffer, offset, item, remainingDepth);
			__index9Value = ReadIndex9Value(buffer, offset, item, remainingDepth);
			__index10Value = ReadIndex10Value(buffer, offset, item, remainingDepth);
			__index11Value = ReadIndex11Value(buffer, offset, item, remainingDepth);
			__index12Value = ReadIndex12Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.Model");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_GreedyMutable(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static AssetIdentifier? ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			bool flag = false;
			int num = vtable.OffsetOf(buffer, 2);
			bool flag2 = num == 0;
			int num2 = 1 & (flag2 ? 1 : 0);
			flag |= flag2;
			int num3 = vtable.OffsetOf(buffer, 3);
			bool flag3 = num3 == 0;
			int num4 = num2 & (flag3 ? 1 : 0);
			flag |= flag3;
			if (num4 != 0)
			{
				return null;
			}
			if (flag)
			{
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.OverrideTexture");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Parse_GreedyMutable(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationStateDefinition>? ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF0F5809FE9A86F27BF245EFF1432E32F6E84230801E4D289D9FB67F26A6E79EB.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.AnimationStates);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AnimationTransitionDefinition>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF3A4CF95196BBD7102F27A90B7BDABD54B9BF4F42F9C973A9120CA70AED5C267.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.AnimationTransitions);
		}
	}

	private static class tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2
	{
		public static readonly TableFieldContext Model = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.Model", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext OverrideTexture = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.OverrideTexture", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AnimationName = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.AnimationName", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AnimationTime = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.AnimationTime", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AnimationSpeed = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.AnimationSpeed", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AnimationLoop = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.AnimationLoop", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AnimationPlaying = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.AnimationPlaying", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext StateMachineEnabled = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.StateMachineEnabled", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext EntryState = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.EntryState", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AnimationStates = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.AnimationStates", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AnimationTransitions = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Entity.ComponentMeshRenderer.AnimationTransitions", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(ComponentMeshRenderer value)
	{
		int num = 99;
		AssetIdentifier? model = value.Model;
		if (model.HasValue)
		{
			num += FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.GetMaxSize(model);
		}
		AssetIdentifier? overrideTexture = value.OverrideTexture;
		if (overrideTexture.HasValue)
		{
			num += FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.GetMaxSize(overrideTexture);
		}
		string animationName = value.AnimationName;
		if (animationName != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(animationName);
		}
		string entryState = value.EntryState;
		if (entryState != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(entryState);
		}
		IList<AnimationStateDefinition> animationStates = value.AnimationStates;
		if (animationStates != null)
		{
			num += FlatSharp.Compiler.Generated.NF0F5809FE9A86F27BF245EFF1432E32F6E84230801E4D289D9FB67F26A6E79EB.Helpers.GetMaxSize(animationStates);
		}
		IList<AnimationTransitionDefinition> animationTransitions = value.AnimationTransitions;
		if (animationTransitions != null)
		{
			num += FlatSharp.Compiler.Generated.NF3A4CF95196BBD7102F27A90B7BDABD54B9BF4F42F9C973A9120CA70AED5C267.Helpers.GetMaxSize(animationTransitions);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, ComponentMeshRenderer value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(65, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[30];
		AssetIdentifier? model = value.Model;
		AssetIdentifier? overrideTexture = value.OverrideTexture;
		string animationName = value.AnimationName;
		float animationTime = value.AnimationTime;
		float animationSpeed = value.AnimationSpeed;
		bool animationLoop = value.AnimationLoop;
		bool animationPlaying = value.AnimationPlaying;
		bool stateMachineEnabled = value.StateMachineEnabled;
		string entryState = value.EntryState;
		IList<AnimationStateDefinition> animationStates = value.AnimationStates;
		IList<AnimationTransitionDefinition> animationTransitions = value.AnimationTransitions;
		int num4 = num;
		if (animationTransitions != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 30;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 28);
		int num5 = num;
		if (animationStates != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (28 > num3)
			{
				num3 = 28;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 26);
		int num6 = num;
		if (entryState != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (26 > num3)
			{
				num3 = 26;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 24);
		int num7 = num;
		if (animationSpeed != 1f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, animationSpeed, num7);
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 16);
		int num8 = num;
		if (animationTime != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, animationTime, num8);
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 14);
		int num9 = num;
		if (animationName != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 12);
		int num10 = num;
		if (overrideTexture.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 10);
		int num11 = num;
		if (model.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num11 = num2;
			num2 += 4;
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 6);
		int num12 = num;
		if (stateMachineEnabled)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num12 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, stateMachineEnabled, num12);
			if (24 > num3)
			{
				num3 = 24;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 22);
		int num13 = num;
		if (!animationPlaying)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num13 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, animationPlaying, num13);
			if (22 > num3)
			{
				num3 = 22;
			}
		}
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)(num13 - num), 20);
		int num14 = num;
		if (!animationLoop)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num14 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, animationLoop, num14);
			if (20 > num3)
			{
				num3 = 20;
			}
		}
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)(num14 - num), 18);
		int num15 = num;
		if (overrideTexture.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num15 = num2;
			num2++;
		}
		Span<byte> span14 = span2;
		spanWriter.WriteUShort(span14, (ushort)(num15 - num), 8);
		int num16 = num;
		if (model.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num16 = num2;
			num2++;
		}
		Span<byte> span15 = span2;
		spanWriter.WriteUShort(span15, (ushort)(num16 - num), 4);
		int num17 = num2 - num;
		context.Offset -= 65 - num17;
		Span<byte> span16 = span2;
		spanWriter.WriteUShort(span16, (ushort)num3, 0);
		Span<byte> span17 = span2;
		spanWriter.WriteUShort(span17, (ushort)num17, 2);
		int num18 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num18, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NF3A4CF95196BBD7102F27A90B7BDABD54B9BF4F42F9C973A9120CA70AED5C267.Helpers.Serialize(spanWriter, span, animationTransitions, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.NF0F5809FE9A86F27BF245EFF1432E32F6E84230801E4D289D9FB67F26A6E79EB.Helpers.Serialize(spanWriter, span, animationStates, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, entryState, num6, context, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.EntryState);
		}
		if (num9 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, animationName, num9, context, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.AnimationName);
		}
		if (num15 != num)
		{
			(int, int) offset2 = (num15, num10);
			FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Serialize(spanWriter, span, overrideTexture, ref offset2, context, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.OverrideTexture);
		}
		if (num16 != num)
		{
			(int, int) offset3 = (num16, num11);
			FlatSharp.Compiler.Generated.N26297B70E7DC14FBD37AADDD3C27B92331A03FE60CC517F305A9A12522DE3245.Helpers.Serialize(spanWriter, span, model, ref offset3, context, tableMetadata_5cf7618381b34c6fa817cd8e3301d1f2.Model);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_08ae17e5f3e54189afd5bf14f73e43f7_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_08ae17e5f3e54189afd5bf14f73e43f7_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_08ae17e5f3e54189afd5bf14f73e43f7_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
