using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.N49E1F27A0EDB17CE3C853C970D7607703B8E745E0F1C010EA56CD9C11363919E;
using FlatSharp.Compiler.Generated.N7F36FB8B0A7FF3302243F0C4AA7542A428A3EF893B137876A4CA4081DE01AA97;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N1FA056D5DB287BB0CE58AA570D08AB14A6CD5484918CE0C3810B407FDD18869A;

internal static class Helpers
{
	[DebuggerDisplay("Lazy CameraPreviewDirectorController")]
	internal sealed class tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Lazy<TInputBuffer> : CameraPreviewDirectorController, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewDirectorController);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<CameraPreviewDirectorTarget>? Targets
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

		public override float Padding
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

		public override float MinimumDistance
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

		public override float MaximumDistance
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

		public override float TargetHeight
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

		public override bool OverrideTargetHeight
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

		public override float VerticalFovDegrees
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

		public override float DeadZoneWidth
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

		public override float DeadZoneHeight
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

		public override float SoftZoneWidth
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

		public override float SoftZoneHeight
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

		public override float HardZoneWidth
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

		public override float HardZoneHeight
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

		public override float SoftZoneDwellSeconds
		{
			get
			{
				return ReadIndex13Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float TargetAdmissionSeconds
		{
			get
			{
				return ReadIndex14Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float MinimumReframeDurationSeconds
		{
			get
			{
				return ReadIndex15Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float MaximumReframeDurationSeconds
		{
			get
			{
				return ReadIndex16Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float CutThresholdViewports
		{
			get
			{
				return ReadIndex17Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool AllowCuts
		{
			get
			{
				return ReadIndex18Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ZoomInDelaySeconds
		{
			get
			{
				return ReadIndex19Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ZoomInStepRatio
		{
			get
			{
				return ReadIndex20Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Urgency
		{
			get
			{
				return ReadIndex21Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float LocalStoryMaximumDistance
		{
			get
			{
				return ReadIndex22Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float LocalStorySwitchSeconds
		{
			get
			{
				return ReadIndex23Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float LocalEngagementRadius
		{
			get
			{
				return ReadIndex24Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ActiveReplanSeconds
		{
			get
			{
				return ReadIndex25Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float CompositionZoneWidth
		{
			get
			{
				return ReadIndex26Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float CompositionZoneHeight
		{
			get
			{
				return ReadIndex27Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override CameraPreviewProjectileFollowMode ProjectileFollowMode
		{
			get
			{
				return ReadIndex28Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewDirectorTarget>? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7F36FB8B0A7FF3302243F0C4AA7542A428A3EF893B137876A4CA4081DE01AA97.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_de1197a5d21a47388a51735bd2e5354e.Targets);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 450f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 1600f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 15000f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0.54f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0.48f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0.78f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0.72f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return 0.93f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return 0.88f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return 0.35f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0.18f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0.65f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return 1.8f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 1.75f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 6f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 1.18f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return 7000f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return 0.6f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return 2500f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return 0.12f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return 0.68f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return 0.62f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewProjectileFollowMode ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return CameraPreviewProjectileFollowMode.Off;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N49E1F27A0EDB17CE3C853C970D7607703B8E745E0F1C010EA56CD9C11363919E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive CameraPreviewDirectorController")]
	internal sealed class tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Progressive<TInputBuffer> : CameraPreviewDirectorController, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private IList<CameraPreviewDirectorTarget>? __index0Value;

		private float __index1Value;

		private float __index2Value;

		private float __index3Value;

		private float __index4Value;

		private bool __index5Value;

		private float __index6Value;

		private float __index7Value;

		private byte __mask1;

		private float __index8Value;

		private float __index9Value;

		private float __index10Value;

		private float __index11Value;

		private float __index12Value;

		private float __index13Value;

		private float __index14Value;

		private float __index15Value;

		private byte __mask2;

		private float __index16Value;

		private float __index17Value;

		private bool __index18Value;

		private float __index19Value;

		private float __index20Value;

		private float __index21Value;

		private float __index22Value;

		private float __index23Value;

		private byte __mask3;

		private float __index24Value;

		private float __index25Value;

		private float __index26Value;

		private float __index27Value;

		private CameraPreviewProjectileFollowMode __index28Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewDirectorController);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<CameraPreviewDirectorTarget>? Targets
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

		public override float Padding
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

		public override float MinimumDistance
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

		public override float MaximumDistance
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

		public override float TargetHeight
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

		public override bool OverrideTargetHeight
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

		public override float VerticalFovDegrees
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

		public override float DeadZoneWidth
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

		public override float DeadZoneHeight
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

		public override float SoftZoneWidth
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

		public override float SoftZoneHeight
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

		public override float HardZoneWidth
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

		public override float HardZoneHeight
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

		public override float SoftZoneDwellSeconds
		{
			get
			{
				if ((__mask1 & 0x20) == 0)
				{
					__index13Value = ReadIndex13Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 32);
				}
				return __index13Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float TargetAdmissionSeconds
		{
			get
			{
				if ((__mask1 & 0x40) == 0)
				{
					__index14Value = ReadIndex14Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 64);
				}
				return __index14Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float MinimumReframeDurationSeconds
		{
			get
			{
				if ((__mask1 & 0x80) == 0)
				{
					__index15Value = ReadIndex15Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 128);
				}
				return __index15Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float MaximumReframeDurationSeconds
		{
			get
			{
				if ((__mask2 & 1) == 0)
				{
					__index16Value = ReadIndex16Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 1);
				}
				return __index16Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float CutThresholdViewports
		{
			get
			{
				if ((__mask2 & 2) == 0)
				{
					__index17Value = ReadIndex17Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 2);
				}
				return __index17Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool AllowCuts
		{
			get
			{
				if ((__mask2 & 4) == 0)
				{
					__index18Value = ReadIndex18Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 4);
				}
				return __index18Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ZoomInDelaySeconds
		{
			get
			{
				if ((__mask2 & 8) == 0)
				{
					__index19Value = ReadIndex19Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 8);
				}
				return __index19Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ZoomInStepRatio
		{
			get
			{
				if ((__mask2 & 0x10) == 0)
				{
					__index20Value = ReadIndex20Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 16);
				}
				return __index20Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Urgency
		{
			get
			{
				if ((__mask2 & 0x20) == 0)
				{
					__index21Value = ReadIndex21Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 32);
				}
				return __index21Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float LocalStoryMaximumDistance
		{
			get
			{
				if ((__mask2 & 0x40) == 0)
				{
					__index22Value = ReadIndex22Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 64);
				}
				return __index22Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float LocalStorySwitchSeconds
		{
			get
			{
				if ((__mask2 & 0x80) == 0)
				{
					__index23Value = ReadIndex23Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 128);
				}
				return __index23Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float LocalEngagementRadius
		{
			get
			{
				if ((__mask3 & 1) == 0)
				{
					__index24Value = ReadIndex24Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 1);
				}
				return __index24Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ActiveReplanSeconds
		{
			get
			{
				if ((__mask3 & 2) == 0)
				{
					__index25Value = ReadIndex25Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 2);
				}
				return __index25Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float CompositionZoneWidth
		{
			get
			{
				if ((__mask3 & 4) == 0)
				{
					__index26Value = ReadIndex26Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 4);
				}
				return __index26Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float CompositionZoneHeight
		{
			get
			{
				if ((__mask3 & 8) == 0)
				{
					__index27Value = ReadIndex27Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 8);
				}
				return __index27Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override CameraPreviewProjectileFollowMode ProjectileFollowMode
		{
			get
			{
				if ((__mask3 & 0x10) == 0)
				{
					__index28Value = ReadIndex28Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 16);
				}
				return __index28Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewDirectorTarget>? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7F36FB8B0A7FF3302243F0C4AA7542A428A3EF893B137876A4CA4081DE01AA97.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_de1197a5d21a47388a51735bd2e5354e.Targets);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 450f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 1600f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 15000f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0.54f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0.48f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0.78f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0.72f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return 0.93f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return 0.88f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return 0.35f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0.18f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0.65f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return 1.8f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 1.75f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 6f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 1.18f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return 7000f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return 0.6f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return 2500f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return 0.12f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return 0.68f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return 0.62f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewProjectileFollowMode ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return CameraPreviewProjectileFollowMode.Off;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N49E1F27A0EDB17CE3C853C970D7607703B8E745E0F1C010EA56CD9C11363919E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy CameraPreviewDirectorController")]
	internal sealed class tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Greedy<TInputBuffer> : CameraPreviewDirectorController, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<CameraPreviewDirectorTarget>? __index0Value;

		private float __index1Value;

		private float __index2Value;

		private float __index3Value;

		private float __index4Value;

		private bool __index5Value;

		private float __index6Value;

		private float __index7Value;

		private float __index8Value;

		private float __index9Value;

		private float __index10Value;

		private float __index11Value;

		private float __index12Value;

		private float __index13Value;

		private float __index14Value;

		private float __index15Value;

		private float __index16Value;

		private float __index17Value;

		private bool __index18Value;

		private float __index19Value;

		private float __index20Value;

		private float __index21Value;

		private float __index22Value;

		private float __index23Value;

		private float __index24Value;

		private float __index25Value;

		private float __index26Value;

		private float __index27Value;

		private CameraPreviewProjectileFollowMode __index28Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewDirectorController);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<CameraPreviewDirectorTarget>? Targets
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

		public override float Padding
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

		public override float MinimumDistance
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

		public override float MaximumDistance
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

		public override float TargetHeight
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

		public override bool OverrideTargetHeight
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

		public override float VerticalFovDegrees
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

		public override float DeadZoneWidth
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

		public override float DeadZoneHeight
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

		public override float SoftZoneWidth
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

		public override float SoftZoneHeight
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

		public override float HardZoneWidth
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

		public override float HardZoneHeight
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

		public override float SoftZoneDwellSeconds
		{
			get
			{
				return __index13Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float TargetAdmissionSeconds
		{
			get
			{
				return __index14Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float MinimumReframeDurationSeconds
		{
			get
			{
				return __index15Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float MaximumReframeDurationSeconds
		{
			get
			{
				return __index16Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float CutThresholdViewports
		{
			get
			{
				return __index17Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool AllowCuts
		{
			get
			{
				return __index18Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ZoomInDelaySeconds
		{
			get
			{
				return __index19Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ZoomInStepRatio
		{
			get
			{
				return __index20Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float Urgency
		{
			get
			{
				return __index21Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float LocalStoryMaximumDistance
		{
			get
			{
				return __index22Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float LocalStorySwitchSeconds
		{
			get
			{
				return __index23Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float LocalEngagementRadius
		{
			get
			{
				return __index24Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ActiveReplanSeconds
		{
			get
			{
				return __index25Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float CompositionZoneWidth
		{
			get
			{
				return __index26Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float CompositionZoneHeight
		{
			get
			{
				return __index27Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override CameraPreviewProjectileFollowMode ProjectileFollowMode
		{
			get
			{
				return __index28Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTableGeneric.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, item, remainingDepth);
			__index8Value = ReadIndex8Value(buffer, offset, item, remainingDepth);
			__index9Value = ReadIndex9Value(buffer, offset, item, remainingDepth);
			__index10Value = ReadIndex10Value(buffer, offset, item, remainingDepth);
			__index11Value = ReadIndex11Value(buffer, offset, item, remainingDepth);
			__index12Value = ReadIndex12Value(buffer, offset, item, remainingDepth);
			__index13Value = ReadIndex13Value(buffer, offset, item, remainingDepth);
			__index14Value = ReadIndex14Value(buffer, offset, item, remainingDepth);
			__index15Value = ReadIndex15Value(buffer, offset, item, remainingDepth);
			__index16Value = ReadIndex16Value(buffer, offset, item, remainingDepth);
			__index17Value = ReadIndex17Value(buffer, offset, item, remainingDepth);
			__index18Value = ReadIndex18Value(buffer, offset, item, remainingDepth);
			__index19Value = ReadIndex19Value(buffer, offset, item, remainingDepth);
			__index20Value = ReadIndex20Value(buffer, offset, item, remainingDepth);
			__index21Value = ReadIndex21Value(buffer, offset, item, remainingDepth);
			__index22Value = ReadIndex22Value(buffer, offset, item, remainingDepth);
			__index23Value = ReadIndex23Value(buffer, offset, item, remainingDepth);
			__index24Value = ReadIndex24Value(buffer, offset, item, remainingDepth);
			__index25Value = ReadIndex25Value(buffer, offset, item, remainingDepth);
			__index26Value = ReadIndex26Value(buffer, offset, item, remainingDepth);
			__index27Value = ReadIndex27Value(buffer, offset, item, remainingDepth);
			__index28Value = ReadIndex28Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewDirectorTarget>? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7F36FB8B0A7FF3302243F0C4AA7542A428A3EF893B137876A4CA4081DE01AA97.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_de1197a5d21a47388a51735bd2e5354e.Targets);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 450f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 1600f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 15000f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0.54f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0.48f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0.78f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0.72f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return 0.93f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return 0.88f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return 0.35f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0.18f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0.65f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return 1.8f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 1.75f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 6f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 1.18f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return 7000f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return 0.6f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return 2500f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return 0.12f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return 0.68f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return 0.62f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewProjectileFollowMode ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return CameraPreviewProjectileFollowMode.Off;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N49E1F27A0EDB17CE3C853C970D7607703B8E745E0F1C010EA56CD9C11363919E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable CameraPreviewDirectorController")]
	internal sealed class tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_GreedyMutable<TInputBuffer> : CameraPreviewDirectorController, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<CameraPreviewDirectorTarget>? __index0Value;

		private float __index1Value;

		private float __index2Value;

		private float __index3Value;

		private float __index4Value;

		private bool __index5Value;

		private float __index6Value;

		private float __index7Value;

		private float __index8Value;

		private float __index9Value;

		private float __index10Value;

		private float __index11Value;

		private float __index12Value;

		private float __index13Value;

		private float __index14Value;

		private float __index15Value;

		private float __index16Value;

		private float __index17Value;

		private bool __index18Value;

		private float __index19Value;

		private float __index20Value;

		private float __index21Value;

		private float __index22Value;

		private float __index23Value;

		private float __index24Value;

		private float __index25Value;

		private float __index26Value;

		private float __index27Value;

		private CameraPreviewProjectileFollowMode __index28Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewDirectorController);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<CameraPreviewDirectorTarget>? Targets
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

		public override float Padding
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

		public override float MinimumDistance
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

		public override float MaximumDistance
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

		public override float TargetHeight
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

		public override bool OverrideTargetHeight
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

		public override float VerticalFovDegrees
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

		public override float DeadZoneWidth
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

		public override float DeadZoneHeight
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

		public override float SoftZoneWidth
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

		public override float SoftZoneHeight
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

		public override float HardZoneWidth
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

		public override float HardZoneHeight
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

		public override float SoftZoneDwellSeconds
		{
			get
			{
				return __index13Value;
			}
			set
			{
				__index13Value = value;
			}
		}

		public override float TargetAdmissionSeconds
		{
			get
			{
				return __index14Value;
			}
			set
			{
				__index14Value = value;
			}
		}

		public override float MinimumReframeDurationSeconds
		{
			get
			{
				return __index15Value;
			}
			set
			{
				__index15Value = value;
			}
		}

		public override float MaximumReframeDurationSeconds
		{
			get
			{
				return __index16Value;
			}
			set
			{
				__index16Value = value;
			}
		}

		public override float CutThresholdViewports
		{
			get
			{
				return __index17Value;
			}
			set
			{
				__index17Value = value;
			}
		}

		public override bool AllowCuts
		{
			get
			{
				return __index18Value;
			}
			set
			{
				__index18Value = value;
			}
		}

		public override float ZoomInDelaySeconds
		{
			get
			{
				return __index19Value;
			}
			set
			{
				__index19Value = value;
			}
		}

		public override float ZoomInStepRatio
		{
			get
			{
				return __index20Value;
			}
			set
			{
				__index20Value = value;
			}
		}

		public override float Urgency
		{
			get
			{
				return __index21Value;
			}
			set
			{
				__index21Value = value;
			}
		}

		public override float LocalStoryMaximumDistance
		{
			get
			{
				return __index22Value;
			}
			set
			{
				__index22Value = value;
			}
		}

		public override float LocalStorySwitchSeconds
		{
			get
			{
				return __index23Value;
			}
			set
			{
				__index23Value = value;
			}
		}

		public override float LocalEngagementRadius
		{
			get
			{
				return __index24Value;
			}
			set
			{
				__index24Value = value;
			}
		}

		public override float ActiveReplanSeconds
		{
			get
			{
				return __index25Value;
			}
			set
			{
				__index25Value = value;
			}
		}

		public override float CompositionZoneWidth
		{
			get
			{
				return __index26Value;
			}
			set
			{
				__index26Value = value;
			}
		}

		public override float CompositionZoneHeight
		{
			get
			{
				return __index27Value;
			}
			set
			{
				__index27Value = value;
			}
		}

		public override CameraPreviewProjectileFollowMode ProjectileFollowMode
		{
			get
			{
				return __index28Value;
			}
			set
			{
				__index28Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTableGeneric.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, item, remainingDepth);
			__index8Value = ReadIndex8Value(buffer, offset, item, remainingDepth);
			__index9Value = ReadIndex9Value(buffer, offset, item, remainingDepth);
			__index10Value = ReadIndex10Value(buffer, offset, item, remainingDepth);
			__index11Value = ReadIndex11Value(buffer, offset, item, remainingDepth);
			__index12Value = ReadIndex12Value(buffer, offset, item, remainingDepth);
			__index13Value = ReadIndex13Value(buffer, offset, item, remainingDepth);
			__index14Value = ReadIndex14Value(buffer, offset, item, remainingDepth);
			__index15Value = ReadIndex15Value(buffer, offset, item, remainingDepth);
			__index16Value = ReadIndex16Value(buffer, offset, item, remainingDepth);
			__index17Value = ReadIndex17Value(buffer, offset, item, remainingDepth);
			__index18Value = ReadIndex18Value(buffer, offset, item, remainingDepth);
			__index19Value = ReadIndex19Value(buffer, offset, item, remainingDepth);
			__index20Value = ReadIndex20Value(buffer, offset, item, remainingDepth);
			__index21Value = ReadIndex21Value(buffer, offset, item, remainingDepth);
			__index22Value = ReadIndex22Value(buffer, offset, item, remainingDepth);
			__index23Value = ReadIndex23Value(buffer, offset, item, remainingDepth);
			__index24Value = ReadIndex24Value(buffer, offset, item, remainingDepth);
			__index25Value = ReadIndex25Value(buffer, offset, item, remainingDepth);
			__index26Value = ReadIndex26Value(buffer, offset, item, remainingDepth);
			__index27Value = ReadIndex27Value(buffer, offset, item, remainingDepth);
			__index28Value = ReadIndex28Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CameraPreviewDirectorTarget>? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7F36FB8B0A7FF3302243F0C4AA7542A428A3EF893B137876A4CA4081DE01AA97.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_de1197a5d21a47388a51735bd2e5354e.Targets);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 450f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 1600f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 15000f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0.54f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return 0.48f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return 0.78f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return 0.72f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return 0.93f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return 0.88f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return 0.35f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0.18f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0.65f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex16Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 16);
			if (num == 0)
			{
				return 1.8f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex17Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 17);
			if (num == 0)
			{
				return 1.75f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return true;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return 6f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return 1.18f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return 7000f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return 0.6f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return 2500f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return 0.12f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return 0.68f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return 0.62f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewProjectileFollowMode ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return CameraPreviewProjectileFollowMode.Off;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N49E1F27A0EDB17CE3C853C970D7607703B8E745E0F1C010EA56CD9C11363919E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_de1197a5d21a47388a51735bd2e5354e
	{
		public static readonly TableFieldContext Targets = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.Targets", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Padding = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.Padding", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext MinimumDistance = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.MinimumDistance", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext MaximumDistance = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.MaximumDistance", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext TargetHeight = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.TargetHeight", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext OverrideTargetHeight = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.OverrideTargetHeight", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext VerticalFovDegrees = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.VerticalFovDegrees", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext DeadZoneWidth = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.DeadZoneWidth", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext DeadZoneHeight = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.DeadZoneHeight", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SoftZoneWidth = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.SoftZoneWidth", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SoftZoneHeight = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.SoftZoneHeight", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext HardZoneWidth = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.HardZoneWidth", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext HardZoneHeight = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.HardZoneHeight", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SoftZoneDwellSeconds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.SoftZoneDwellSeconds", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext TargetAdmissionSeconds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.TargetAdmissionSeconds", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext MinimumReframeDurationSeconds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.MinimumReframeDurationSeconds", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext MaximumReframeDurationSeconds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.MaximumReframeDurationSeconds", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext CutThresholdViewports = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.CutThresholdViewports", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AllowCuts = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.AllowCuts", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ZoomInDelaySeconds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.ZoomInDelaySeconds", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ZoomInStepRatio = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.ZoomInStepRatio", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Urgency = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.Urgency", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext LocalStoryMaximumDistance = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.LocalStoryMaximumDistance", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext LocalStorySwitchSeconds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.LocalStorySwitchSeconds", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext LocalEngagementRadius = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.LocalEngagementRadius", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ActiveReplanSeconds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.ActiveReplanSeconds", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext CompositionZoneWidth = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.CompositionZoneWidth", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext CompositionZoneHeight = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.CompositionZoneHeight", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ProjectileFollowMode = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewDirectorController.ProjectileFollowMode", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(CameraPreviewDirectorController value)
	{
		int num = 255;
		IList<CameraPreviewDirectorTarget> targets = value.Targets;
		if (targets != null)
		{
			num += FlatSharp.Compiler.Generated.N7F36FB8B0A7FF3302243F0C4AA7542A428A3EF893B137876A4CA4081DE01AA97.Helpers.GetMaxSize(targets);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CameraPreviewDirectorController value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(189, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[62];
		IList<CameraPreviewDirectorTarget> targets = value.Targets;
		float padding = value.Padding;
		float minimumDistance = value.MinimumDistance;
		float maximumDistance = value.MaximumDistance;
		float targetHeight = value.TargetHeight;
		bool overrideTargetHeight = value.OverrideTargetHeight;
		float verticalFovDegrees = value.VerticalFovDegrees;
		float deadZoneWidth = value.DeadZoneWidth;
		float deadZoneHeight = value.DeadZoneHeight;
		float softZoneWidth = value.SoftZoneWidth;
		float softZoneHeight = value.SoftZoneHeight;
		float hardZoneWidth = value.HardZoneWidth;
		float hardZoneHeight = value.HardZoneHeight;
		float softZoneDwellSeconds = value.SoftZoneDwellSeconds;
		float targetAdmissionSeconds = value.TargetAdmissionSeconds;
		float minimumReframeDurationSeconds = value.MinimumReframeDurationSeconds;
		float maximumReframeDurationSeconds = value.MaximumReframeDurationSeconds;
		float cutThresholdViewports = value.CutThresholdViewports;
		bool allowCuts = value.AllowCuts;
		float zoomInDelaySeconds = value.ZoomInDelaySeconds;
		float zoomInStepRatio = value.ZoomInStepRatio;
		float urgency = value.Urgency;
		float localStoryMaximumDistance = value.LocalStoryMaximumDistance;
		float localStorySwitchSeconds = value.LocalStorySwitchSeconds;
		float localEngagementRadius = value.LocalEngagementRadius;
		float activeReplanSeconds = value.ActiveReplanSeconds;
		float compositionZoneWidth = value.CompositionZoneWidth;
		float compositionZoneHeight = value.CompositionZoneHeight;
		CameraPreviewProjectileFollowMode projectileFollowMode = value.ProjectileFollowMode;
		int num4 = num;
		if (compositionZoneHeight != 0.62f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, compositionZoneHeight, num4);
			if (60 > num3)
			{
				num3 = 60;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 58);
		int num5 = num;
		if (compositionZoneWidth != 0.68f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, compositionZoneWidth, num5);
			if (58 > num3)
			{
				num3 = 58;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 56);
		int num6 = num;
		if (activeReplanSeconds != 0.12f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, activeReplanSeconds, num6);
			if (56 > num3)
			{
				num3 = 56;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 54);
		int num7 = num;
		if (localEngagementRadius != 2500f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, localEngagementRadius, num7);
			if (54 > num3)
			{
				num3 = 54;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 52);
		int num8 = num;
		if (localStorySwitchSeconds != 0.6f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, localStorySwitchSeconds, num8);
			if (52 > num3)
			{
				num3 = 52;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 50);
		int num9 = num;
		if (localStoryMaximumDistance != 7000f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, localStoryMaximumDistance, num9);
			if (50 > num3)
			{
				num3 = 50;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 48);
		int num10 = num;
		if (urgency != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, urgency, num10);
			if (48 > num3)
			{
				num3 = 48;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 46);
		int num11 = num;
		if (zoomInStepRatio != 1.18f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num11 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, zoomInStepRatio, num11);
			if (46 > num3)
			{
				num3 = 46;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 44);
		int num12 = num;
		if (zoomInDelaySeconds != 6f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num12 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, zoomInDelaySeconds, num12);
			if (44 > num3)
			{
				num3 = 44;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 42);
		int num13 = num;
		if (cutThresholdViewports != 1.75f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num13 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, cutThresholdViewports, num13);
			if (40 > num3)
			{
				num3 = 40;
			}
		}
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)(num13 - num), 38);
		int num14 = num;
		if (maximumReframeDurationSeconds != 1.8f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num14 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, maximumReframeDurationSeconds, num14);
			if (38 > num3)
			{
				num3 = 38;
			}
		}
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)(num14 - num), 36);
		int num15 = num;
		if (minimumReframeDurationSeconds != 0.65f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num15 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, minimumReframeDurationSeconds, num15);
			if (36 > num3)
			{
				num3 = 36;
			}
		}
		Span<byte> span14 = span2;
		spanWriter.WriteUShort(span14, (ushort)(num15 - num), 34);
		int num16 = num;
		if (targetAdmissionSeconds != 0.18f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num16 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, targetAdmissionSeconds, num16);
			if (34 > num3)
			{
				num3 = 34;
			}
		}
		Span<byte> span15 = span2;
		spanWriter.WriteUShort(span15, (ushort)(num16 - num), 32);
		int num17 = num;
		if (softZoneDwellSeconds != 0.35f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num17 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, softZoneDwellSeconds, num17);
			if (32 > num3)
			{
				num3 = 32;
			}
		}
		Span<byte> span16 = span2;
		spanWriter.WriteUShort(span16, (ushort)(num17 - num), 30);
		int num18 = num;
		if (hardZoneHeight != 0.88f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num18 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, hardZoneHeight, num18);
			if (30 > num3)
			{
				num3 = 30;
			}
		}
		Span<byte> span17 = span2;
		spanWriter.WriteUShort(span17, (ushort)(num18 - num), 28);
		int num19 = num;
		if (hardZoneWidth != 0.93f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num19 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, hardZoneWidth, num19);
			if (28 > num3)
			{
				num3 = 28;
			}
		}
		Span<byte> span18 = span2;
		spanWriter.WriteUShort(span18, (ushort)(num19 - num), 26);
		int num20 = num;
		if (softZoneHeight != 0.72f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num20 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, softZoneHeight, num20);
			if (26 > num3)
			{
				num3 = 26;
			}
		}
		Span<byte> span19 = span2;
		spanWriter.WriteUShort(span19, (ushort)(num20 - num), 24);
		int num21 = num;
		if (softZoneWidth != 0.78f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num21 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, softZoneWidth, num21);
			if (24 > num3)
			{
				num3 = 24;
			}
		}
		Span<byte> span20 = span2;
		spanWriter.WriteUShort(span20, (ushort)(num21 - num), 22);
		int num22 = num;
		if (deadZoneHeight != 0.48f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num22 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, deadZoneHeight, num22);
			if (22 > num3)
			{
				num3 = 22;
			}
		}
		Span<byte> span21 = span2;
		spanWriter.WriteUShort(span21, (ushort)(num22 - num), 20);
		int num23 = num;
		if (deadZoneWidth != 0.54f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num23 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, deadZoneWidth, num23);
			if (20 > num3)
			{
				num3 = 20;
			}
		}
		Span<byte> span22 = span2;
		spanWriter.WriteUShort(span22, (ushort)(num23 - num), 18);
		int num24 = num;
		if (verticalFovDegrees != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num24 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, verticalFovDegrees, num24);
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span23 = span2;
		spanWriter.WriteUShort(span23, (ushort)(num24 - num), 16);
		int num25 = num;
		if (targetHeight != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num25 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, targetHeight, num25);
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span24 = span2;
		spanWriter.WriteUShort(span24, (ushort)(num25 - num), 12);
		int num26 = num;
		if (maximumDistance != 15000f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num26 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, maximumDistance, num26);
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span25 = span2;
		spanWriter.WriteUShort(span25, (ushort)(num26 - num), 10);
		int num27 = num;
		if (minimumDistance != 1600f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num27 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, minimumDistance, num27);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span26 = span2;
		spanWriter.WriteUShort(span26, (ushort)(num27 - num), 8);
		int num28 = num;
		if (padding != 450f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num28 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, padding, num28);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span27 = span2;
		spanWriter.WriteUShort(span27, (ushort)(num28 - num), 6);
		int num29 = num;
		if (targets != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num29 = num2;
			num2 += 4;
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span28 = span2;
		spanWriter.WriteUShort(span28, (ushort)(num29 - num), 4);
		int num30 = num;
		if (projectileFollowMode != CameraPreviewProjectileFollowMode.Off)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num30 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N49E1F27A0EDB17CE3C853C970D7607703B8E745E0F1C010EA56CD9C11363919E.Helpers.Serialize(spanWriter, span, projectileFollowMode, num30);
			num3 = 62;
		}
		Span<byte> span29 = span2;
		spanWriter.WriteUShort(span29, (ushort)(num30 - num), 60);
		int num31 = num;
		if (!allowCuts)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num31 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, allowCuts, num31);
			if (42 > num3)
			{
				num3 = 42;
			}
		}
		Span<byte> span30 = span2;
		spanWriter.WriteUShort(span30, (ushort)(num31 - num), 40);
		int num32 = num;
		if (!overrideTargetHeight)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num32 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, overrideTargetHeight, num32);
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span31 = span2;
		spanWriter.WriteUShort(span31, (ushort)(num32 - num), 14);
		int num33 = num2 - num;
		context.Offset -= 189 - num33;
		Span<byte> span32 = span2;
		spanWriter.WriteUShort(span32, (ushort)num3, 0);
		Span<byte> span33 = span2;
		spanWriter.WriteUShort(span33, (ushort)num33, 2);
		int num34 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num34, num);
		if (num29 != num)
		{
			FlatSharp.Compiler.Generated.N7F36FB8B0A7FF3302243F0C4AA7542A428A3EF893B137876A4CA4081DE01AA97.Helpers.Serialize(spanWriter, span, targets, num29, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c7b7a6c1c4c74924b6f19e4efe1ddd28_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
