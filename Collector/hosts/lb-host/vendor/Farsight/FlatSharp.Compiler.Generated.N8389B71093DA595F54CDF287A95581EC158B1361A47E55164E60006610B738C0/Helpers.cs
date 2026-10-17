using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB;
using FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85;
using FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335;
using FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N8389B71093DA595F54CDF287A95581EC158B1361A47E55164E60006610B738C0;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SetControllerCameraConfig")]
	internal sealed class tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Lazy<TInputBuffer> : SetControllerCameraConfig, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetControllerCameraConfig);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override bool Enabled
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

		public override bool DollyEnabled
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

		public override int Slot
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

		public override float StickDeadzone
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

		public override float LookDeadzone
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

		public override float LookSpeed
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

		public override float FreeMoveSpeed
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

		public override ControllerButton BlueTeamButton
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

		public override ControllerButton RedTeamButton
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

		public override ControllerButton ChampionSlot1Button
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

		public override ControllerButton ChampionSlot2Button
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

		public override ControllerButton ChampionSlot3Button
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

		public override ControllerButton ChampionSlot4Button
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

		public override ControllerButton ChampionSlot5Button
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

		public override bool MoveSmoothing
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

		public override float BuildupSeconds
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

		public override float FalloffSeconds
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

		public override float DirectedMoveSpeed
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

		public override IList<float>? FalloffCurveX
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

		public override IList<float>? FalloffCurveY
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

		public override IList<float>? BuildupCurveX
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

		public override IList<float>? BuildupCurveY
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

		public override bool ChordMoveHold
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

		public override ControllerButton CaptureButton
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

		public override ControllerButton PreviewToggleButton
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

		public override ControllerButton PreviewStopButton
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

		public override ControllerButton PlayheadBackButton
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

		public override ControllerButton PlayheadForwardButton
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

		public override ControllerButton SpeedFasterButton
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

		public override ControllerButton SpeedSlowerButton
		{
			get
			{
				return ReadIndex29Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerStick MoveStick
		{
			get
			{
				return ReadIndex30Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerStick LookStick
		{
			get
			{
				return ReadIndex31Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertMoveX
		{
			get
			{
				return ReadIndex32Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertMoveY
		{
			get
			{
				return ReadIndex33Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertLookX
		{
			get
			{
				return ReadIndex34Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertLookY
		{
			get
			{
				return ReadIndex35Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool SwapTriggers
		{
			get
			{
				return ReadIndex36Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ZoomSpeed
		{
			get
			{
				return ReadIndex37Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton JumpNearestButton
		{
			get
			{
				return ReadIndex38Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton JumpNearestDirectionButton
		{
			get
			{
				return ReadIndex39Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton RollLeftButton
		{
			get
			{
				return ReadIndex40Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton RollRightButton
		{
			get
			{
				return ReadIndex41Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool RelativeFreeMovement
		{
			get
			{
				return ReadIndex42Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return ControllerButton.LeftShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return ControllerButton.RightShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return ControllerButton.DPadUp;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return ControllerButton.DPadLeft;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return ControllerButton.DPadRight;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return ControllerButton.DPadDown;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return ControllerButton.FaceSouth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 1f;
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
				return 2f;
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
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.FalloffCurveX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.FalloffCurveY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.BuildupCurveX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.BuildupCurveY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return ControllerButton.FaceSouth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return ControllerButton.Menu;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return ControllerButton.FaceEast;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return ControllerButton.DPadLeft;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return ControllerButton.DPadRight;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return ControllerButton.DPadUp;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex29Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 29);
			if (num == 0)
			{
				return ControllerButton.DPadDown;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerStick ReadIndex30Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 30);
			if (num == 0)
			{
				return ControllerStick.LeftStick;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerStick ReadIndex31Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 31);
			if (num == 0)
			{
				return ControllerStick.RightStick;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex32Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 32);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex33Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 33);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex34Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 34);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex35Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 35);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex36Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 36);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex37Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 37);
			if (num == 0)
			{
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex38Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 38);
			if (num == 0)
			{
				return ControllerButton.FaceWest;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex39Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 39);
			if (num == 0)
			{
				return ControllerButton.FaceNorth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex40Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 40);
			if (num == 0)
			{
				return ControllerButton.LeftShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex41Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 41);
			if (num == 0)
			{
				return ControllerButton.RightShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex42Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 42);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive SetControllerCameraConfig")]
	internal sealed class tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Progressive<TInputBuffer> : SetControllerCameraConfig, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private bool __index0Value;

		private bool __index1Value;

		private int __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private ControllerButton __index7Value;

		private byte __mask1;

		private ControllerButton __index8Value;

		private ControllerButton __index9Value;

		private ControllerButton __index10Value;

		private ControllerButton __index11Value;

		private ControllerButton __index12Value;

		private ControllerButton __index13Value;

		private bool __index14Value;

		private float __index15Value;

		private byte __mask2;

		private float __index16Value;

		private float __index17Value;

		private IList<float>? __index18Value;

		private IList<float>? __index19Value;

		private IList<float>? __index20Value;

		private IList<float>? __index21Value;

		private bool __index22Value;

		private ControllerButton __index23Value;

		private byte __mask3;

		private ControllerButton __index24Value;

		private ControllerButton __index25Value;

		private ControllerButton __index26Value;

		private ControllerButton __index27Value;

		private ControllerButton __index28Value;

		private ControllerButton __index29Value;

		private ControllerStick __index30Value;

		private ControllerStick __index31Value;

		private byte __mask4;

		private bool __index32Value;

		private bool __index33Value;

		private bool __index34Value;

		private bool __index35Value;

		private bool __index36Value;

		private float __index37Value;

		private ControllerButton __index38Value;

		private ControllerButton __index39Value;

		private byte __mask5;

		private ControllerButton __index40Value;

		private ControllerButton __index41Value;

		private bool __index42Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetControllerCameraConfig);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override bool Enabled
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

		public override bool DollyEnabled
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

		public override int Slot
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

		public override float StickDeadzone
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

		public override float LookDeadzone
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

		public override float LookSpeed
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

		public override float FreeMoveSpeed
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

		public override ControllerButton BlueTeamButton
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

		public override ControllerButton RedTeamButton
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

		public override ControllerButton ChampionSlot1Button
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

		public override ControllerButton ChampionSlot2Button
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

		public override ControllerButton ChampionSlot3Button
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

		public override ControllerButton ChampionSlot4Button
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

		public override ControllerButton ChampionSlot5Button
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

		public override bool MoveSmoothing
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

		public override float BuildupSeconds
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

		public override float FalloffSeconds
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

		public override float DirectedMoveSpeed
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

		public override IList<float>? FalloffCurveX
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

		public override IList<float>? FalloffCurveY
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

		public override IList<float>? BuildupCurveX
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

		public override IList<float>? BuildupCurveY
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

		public override bool ChordMoveHold
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

		public override ControllerButton CaptureButton
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

		public override ControllerButton PreviewToggleButton
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

		public override ControllerButton PreviewStopButton
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

		public override ControllerButton PlayheadBackButton
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

		public override ControllerButton PlayheadForwardButton
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

		public override ControllerButton SpeedFasterButton
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

		public override ControllerButton SpeedSlowerButton
		{
			get
			{
				if ((__mask3 & 0x20) == 0)
				{
					__index29Value = ReadIndex29Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 32);
				}
				return __index29Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerStick MoveStick
		{
			get
			{
				if ((__mask3 & 0x40) == 0)
				{
					__index30Value = ReadIndex30Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 64);
				}
				return __index30Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerStick LookStick
		{
			get
			{
				if ((__mask3 & 0x80) == 0)
				{
					__index31Value = ReadIndex31Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 128);
				}
				return __index31Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertMoveX
		{
			get
			{
				if ((__mask4 & 1) == 0)
				{
					__index32Value = ReadIndex32Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 1);
				}
				return __index32Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertMoveY
		{
			get
			{
				if ((__mask4 & 2) == 0)
				{
					__index33Value = ReadIndex33Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 2);
				}
				return __index33Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertLookX
		{
			get
			{
				if ((__mask4 & 4) == 0)
				{
					__index34Value = ReadIndex34Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 4);
				}
				return __index34Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertLookY
		{
			get
			{
				if ((__mask4 & 8) == 0)
				{
					__index35Value = ReadIndex35Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 8);
				}
				return __index35Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool SwapTriggers
		{
			get
			{
				if ((__mask4 & 0x10) == 0)
				{
					__index36Value = ReadIndex36Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 16);
				}
				return __index36Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ZoomSpeed
		{
			get
			{
				if ((__mask4 & 0x20) == 0)
				{
					__index37Value = ReadIndex37Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 32);
				}
				return __index37Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton JumpNearestButton
		{
			get
			{
				if ((__mask4 & 0x40) == 0)
				{
					__index38Value = ReadIndex38Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 64);
				}
				return __index38Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton JumpNearestDirectionButton
		{
			get
			{
				if ((__mask4 & 0x80) == 0)
				{
					__index39Value = ReadIndex39Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 128);
				}
				return __index39Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton RollLeftButton
		{
			get
			{
				if ((__mask5 & 1) == 0)
				{
					__index40Value = ReadIndex40Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 1);
				}
				return __index40Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton RollRightButton
		{
			get
			{
				if ((__mask5 & 2) == 0)
				{
					__index41Value = ReadIndex41Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 2);
				}
				return __index41Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool RelativeFreeMovement
		{
			get
			{
				if ((__mask5 & 4) == 0)
				{
					__index42Value = ReadIndex42Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 4);
				}
				return __index42Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return ControllerButton.LeftShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return ControllerButton.RightShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return ControllerButton.DPadUp;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return ControllerButton.DPadLeft;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return ControllerButton.DPadRight;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return ControllerButton.DPadDown;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return ControllerButton.FaceSouth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 1f;
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
				return 2f;
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
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.FalloffCurveX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.FalloffCurveY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.BuildupCurveX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.BuildupCurveY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return ControllerButton.FaceSouth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return ControllerButton.Menu;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return ControllerButton.FaceEast;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return ControllerButton.DPadLeft;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return ControllerButton.DPadRight;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return ControllerButton.DPadUp;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex29Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 29);
			if (num == 0)
			{
				return ControllerButton.DPadDown;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerStick ReadIndex30Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 30);
			if (num == 0)
			{
				return ControllerStick.LeftStick;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerStick ReadIndex31Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 31);
			if (num == 0)
			{
				return ControllerStick.RightStick;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex32Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 32);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex33Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 33);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex34Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 34);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex35Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 35);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex36Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 36);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex37Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 37);
			if (num == 0)
			{
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex38Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 38);
			if (num == 0)
			{
				return ControllerButton.FaceWest;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex39Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 39);
			if (num == 0)
			{
				return ControllerButton.FaceNorth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex40Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 40);
			if (num == 0)
			{
				return ControllerButton.LeftShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex41Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 41);
			if (num == 0)
			{
				return ControllerButton.RightShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex42Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 42);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy SetControllerCameraConfig")]
	internal sealed class tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Greedy<TInputBuffer> : SetControllerCameraConfig, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private bool __index0Value;

		private bool __index1Value;

		private int __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private ControllerButton __index7Value;

		private ControllerButton __index8Value;

		private ControllerButton __index9Value;

		private ControllerButton __index10Value;

		private ControllerButton __index11Value;

		private ControllerButton __index12Value;

		private ControllerButton __index13Value;

		private bool __index14Value;

		private float __index15Value;

		private float __index16Value;

		private float __index17Value;

		private IList<float>? __index18Value;

		private IList<float>? __index19Value;

		private IList<float>? __index20Value;

		private IList<float>? __index21Value;

		private bool __index22Value;

		private ControllerButton __index23Value;

		private ControllerButton __index24Value;

		private ControllerButton __index25Value;

		private ControllerButton __index26Value;

		private ControllerButton __index27Value;

		private ControllerButton __index28Value;

		private ControllerButton __index29Value;

		private ControllerStick __index30Value;

		private ControllerStick __index31Value;

		private bool __index32Value;

		private bool __index33Value;

		private bool __index34Value;

		private bool __index35Value;

		private bool __index36Value;

		private float __index37Value;

		private ControllerButton __index38Value;

		private ControllerButton __index39Value;

		private ControllerButton __index40Value;

		private ControllerButton __index41Value;

		private bool __index42Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetControllerCameraConfig);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override bool Enabled
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

		public override bool DollyEnabled
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

		public override int Slot
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

		public override float StickDeadzone
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

		public override float LookDeadzone
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

		public override float LookSpeed
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

		public override float FreeMoveSpeed
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

		public override ControllerButton BlueTeamButton
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

		public override ControllerButton RedTeamButton
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

		public override ControllerButton ChampionSlot1Button
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

		public override ControllerButton ChampionSlot2Button
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

		public override ControllerButton ChampionSlot3Button
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

		public override ControllerButton ChampionSlot4Button
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

		public override ControllerButton ChampionSlot5Button
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

		public override bool MoveSmoothing
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

		public override float BuildupSeconds
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

		public override float FalloffSeconds
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

		public override float DirectedMoveSpeed
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

		public override IList<float>? FalloffCurveX
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

		public override IList<float>? FalloffCurveY
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

		public override IList<float>? BuildupCurveX
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

		public override IList<float>? BuildupCurveY
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

		public override bool ChordMoveHold
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

		public override ControllerButton CaptureButton
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

		public override ControllerButton PreviewToggleButton
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

		public override ControllerButton PreviewStopButton
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

		public override ControllerButton PlayheadBackButton
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

		public override ControllerButton PlayheadForwardButton
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

		public override ControllerButton SpeedFasterButton
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

		public override ControllerButton SpeedSlowerButton
		{
			get
			{
				return __index29Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerStick MoveStick
		{
			get
			{
				return __index30Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerStick LookStick
		{
			get
			{
				return __index31Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertMoveX
		{
			get
			{
				return __index32Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertMoveY
		{
			get
			{
				return __index33Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertLookX
		{
			get
			{
				return __index34Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool InvertLookY
		{
			get
			{
				return __index35Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool SwapTriggers
		{
			get
			{
				return __index36Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override float ZoomSpeed
		{
			get
			{
				return __index37Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton JumpNearestButton
		{
			get
			{
				return __index38Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton JumpNearestDirectionButton
		{
			get
			{
				return __index39Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton RollLeftButton
		{
			get
			{
				return __index40Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override ControllerButton RollRightButton
		{
			get
			{
				return __index41Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override bool RelativeFreeMovement
		{
			get
			{
				return __index42Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
			__index29Value = ReadIndex29Value(buffer, offset, item, remainingDepth);
			__index30Value = ReadIndex30Value(buffer, offset, item, remainingDepth);
			__index31Value = ReadIndex31Value(buffer, offset, item, remainingDepth);
			__index32Value = ReadIndex32Value(buffer, offset, item, remainingDepth);
			__index33Value = ReadIndex33Value(buffer, offset, item, remainingDepth);
			__index34Value = ReadIndex34Value(buffer, offset, item, remainingDepth);
			__index35Value = ReadIndex35Value(buffer, offset, item, remainingDepth);
			__index36Value = ReadIndex36Value(buffer, offset, item, remainingDepth);
			__index37Value = ReadIndex37Value(buffer, offset, item, remainingDepth);
			__index38Value = ReadIndex38Value(buffer, offset, item, remainingDepth);
			__index39Value = ReadIndex39Value(buffer, offset, item, remainingDepth);
			__index40Value = ReadIndex40Value(buffer, offset, item, remainingDepth);
			__index41Value = ReadIndex41Value(buffer, offset, item, remainingDepth);
			__index42Value = ReadIndex42Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return ControllerButton.LeftShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return ControllerButton.RightShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return ControllerButton.DPadUp;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return ControllerButton.DPadLeft;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return ControllerButton.DPadRight;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return ControllerButton.DPadDown;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return ControllerButton.FaceSouth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 1f;
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
				return 2f;
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
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.FalloffCurveX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.FalloffCurveY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.BuildupCurveX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.BuildupCurveY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return ControllerButton.FaceSouth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return ControllerButton.Menu;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return ControllerButton.FaceEast;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return ControllerButton.DPadLeft;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return ControllerButton.DPadRight;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return ControllerButton.DPadUp;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex29Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 29);
			if (num == 0)
			{
				return ControllerButton.DPadDown;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerStick ReadIndex30Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 30);
			if (num == 0)
			{
				return ControllerStick.LeftStick;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerStick ReadIndex31Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 31);
			if (num == 0)
			{
				return ControllerStick.RightStick;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex32Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 32);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex33Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 33);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex34Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 34);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex35Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 35);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex36Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 36);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex37Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 37);
			if (num == 0)
			{
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex38Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 38);
			if (num == 0)
			{
				return ControllerButton.FaceWest;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex39Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 39);
			if (num == 0)
			{
				return ControllerButton.FaceNorth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex40Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 40);
			if (num == 0)
			{
				return ControllerButton.LeftShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex41Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 41);
			if (num == 0)
			{
				return ControllerButton.RightShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex42Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 42);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable SetControllerCameraConfig")]
	internal sealed class tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_GreedyMutable<TInputBuffer> : SetControllerCameraConfig, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private bool __index0Value;

		private bool __index1Value;

		private int __index2Value;

		private float __index3Value;

		private float __index4Value;

		private float __index5Value;

		private float __index6Value;

		private ControllerButton __index7Value;

		private ControllerButton __index8Value;

		private ControllerButton __index9Value;

		private ControllerButton __index10Value;

		private ControllerButton __index11Value;

		private ControllerButton __index12Value;

		private ControllerButton __index13Value;

		private bool __index14Value;

		private float __index15Value;

		private float __index16Value;

		private float __index17Value;

		private IList<float>? __index18Value;

		private IList<float>? __index19Value;

		private IList<float>? __index20Value;

		private IList<float>? __index21Value;

		private bool __index22Value;

		private ControllerButton __index23Value;

		private ControllerButton __index24Value;

		private ControllerButton __index25Value;

		private ControllerButton __index26Value;

		private ControllerButton __index27Value;

		private ControllerButton __index28Value;

		private ControllerButton __index29Value;

		private ControllerStick __index30Value;

		private ControllerStick __index31Value;

		private bool __index32Value;

		private bool __index33Value;

		private bool __index34Value;

		private bool __index35Value;

		private bool __index36Value;

		private float __index37Value;

		private ControllerButton __index38Value;

		private ControllerButton __index39Value;

		private ControllerButton __index40Value;

		private ControllerButton __index41Value;

		private bool __index42Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetControllerCameraConfig);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override bool Enabled
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

		public override bool DollyEnabled
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

		public override int Slot
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

		public override float StickDeadzone
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

		public override float LookDeadzone
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

		public override float LookSpeed
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

		public override float FreeMoveSpeed
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

		public override ControllerButton BlueTeamButton
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

		public override ControllerButton RedTeamButton
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

		public override ControllerButton ChampionSlot1Button
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

		public override ControllerButton ChampionSlot2Button
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

		public override ControllerButton ChampionSlot3Button
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

		public override ControllerButton ChampionSlot4Button
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

		public override ControllerButton ChampionSlot5Button
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

		public override bool MoveSmoothing
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

		public override float BuildupSeconds
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

		public override float FalloffSeconds
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

		public override float DirectedMoveSpeed
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

		public override IList<float>? FalloffCurveX
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

		public override IList<float>? FalloffCurveY
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

		public override IList<float>? BuildupCurveX
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

		public override IList<float>? BuildupCurveY
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

		public override bool ChordMoveHold
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

		public override ControllerButton CaptureButton
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

		public override ControllerButton PreviewToggleButton
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

		public override ControllerButton PreviewStopButton
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

		public override ControllerButton PlayheadBackButton
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

		public override ControllerButton PlayheadForwardButton
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

		public override ControllerButton SpeedFasterButton
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

		public override ControllerButton SpeedSlowerButton
		{
			get
			{
				return __index29Value;
			}
			set
			{
				__index29Value = value;
			}
		}

		public override ControllerStick MoveStick
		{
			get
			{
				return __index30Value;
			}
			set
			{
				__index30Value = value;
			}
		}

		public override ControllerStick LookStick
		{
			get
			{
				return __index31Value;
			}
			set
			{
				__index31Value = value;
			}
		}

		public override bool InvertMoveX
		{
			get
			{
				return __index32Value;
			}
			set
			{
				__index32Value = value;
			}
		}

		public override bool InvertMoveY
		{
			get
			{
				return __index33Value;
			}
			set
			{
				__index33Value = value;
			}
		}

		public override bool InvertLookX
		{
			get
			{
				return __index34Value;
			}
			set
			{
				__index34Value = value;
			}
		}

		public override bool InvertLookY
		{
			get
			{
				return __index35Value;
			}
			set
			{
				__index35Value = value;
			}
		}

		public override bool SwapTriggers
		{
			get
			{
				return __index36Value;
			}
			set
			{
				__index36Value = value;
			}
		}

		public override float ZoomSpeed
		{
			get
			{
				return __index37Value;
			}
			set
			{
				__index37Value = value;
			}
		}

		public override ControllerButton JumpNearestButton
		{
			get
			{
				return __index38Value;
			}
			set
			{
				__index38Value = value;
			}
		}

		public override ControllerButton JumpNearestDirectionButton
		{
			get
			{
				return __index39Value;
			}
			set
			{
				__index39Value = value;
			}
		}

		public override ControllerButton RollLeftButton
		{
			get
			{
				return __index40Value;
			}
			set
			{
				__index40Value = value;
			}
		}

		public override ControllerButton RollRightButton
		{
			get
			{
				return __index41Value;
			}
			set
			{
				__index41Value = value;
			}
		}

		public override bool RelativeFreeMovement
		{
			get
			{
				return __index42Value;
			}
			set
			{
				__index42Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
			__index29Value = ReadIndex29Value(buffer, offset, item, remainingDepth);
			__index30Value = ReadIndex30Value(buffer, offset, item, remainingDepth);
			__index31Value = ReadIndex31Value(buffer, offset, item, remainingDepth);
			__index32Value = ReadIndex32Value(buffer, offset, item, remainingDepth);
			__index33Value = ReadIndex33Value(buffer, offset, item, remainingDepth);
			__index34Value = ReadIndex34Value(buffer, offset, item, remainingDepth);
			__index35Value = ReadIndex35Value(buffer, offset, item, remainingDepth);
			__index36Value = ReadIndex36Value(buffer, offset, item, remainingDepth);
			__index37Value = ReadIndex37Value(buffer, offset, item, remainingDepth);
			__index38Value = ReadIndex38Value(buffer, offset, item, remainingDepth);
			__index39Value = ReadIndex39Value(buffer, offset, item, remainingDepth);
			__index40Value = ReadIndex40Value(buffer, offset, item, remainingDepth);
			__index41Value = ReadIndex41Value(buffer, offset, item, remainingDepth);
			__index42Value = ReadIndex42Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static int ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return ControllerButton.LeftShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return ControllerButton.RightShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return ControllerButton.DPadUp;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return ControllerButton.DPadLeft;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return ControllerButton.DPadRight;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return ControllerButton.DPadDown;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return ControllerButton.FaceSouth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 1f;
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
				return 2f;
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
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex18Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 18);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.FalloffCurveX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex19Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 19);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.FalloffCurveY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex20Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 20);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.BuildupCurveX);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex21Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 21);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_ba6aab45c44444aeb54e65f77da3aa42.BuildupCurveY);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex22Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 22);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex23Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 23);
			if (num == 0)
			{
				return ControllerButton.FaceSouth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex24Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 24);
			if (num == 0)
			{
				return ControllerButton.Menu;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex25Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 25);
			if (num == 0)
			{
				return ControllerButton.FaceEast;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex26Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 26);
			if (num == 0)
			{
				return ControllerButton.DPadLeft;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex27Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 27);
			if (num == 0)
			{
				return ControllerButton.DPadRight;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex28Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 28);
			if (num == 0)
			{
				return ControllerButton.DPadUp;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex29Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 29);
			if (num == 0)
			{
				return ControllerButton.DPadDown;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerStick ReadIndex30Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 30);
			if (num == 0)
			{
				return ControllerStick.LeftStick;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerStick ReadIndex31Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 31);
			if (num == 0)
			{
				return ControllerStick.RightStick;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex32Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 32);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex33Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 33);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex34Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 34);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex35Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 35);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex36Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 36);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex37Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 37);
			if (num == 0)
			{
				return 1f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex38Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 38);
			if (num == 0)
			{
				return ControllerButton.FaceWest;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex39Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 39);
			if (num == 0)
			{
				return ControllerButton.FaceNorth;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex40Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 40);
			if (num == 0)
			{
				return ControllerButton.LeftShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ControllerButton ReadIndex41Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 41);
			if (num == 0)
			{
				return ControllerButton.RightShoulder;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex42Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 42);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_ba6aab45c44444aeb54e65f77da3aa42
	{
		public static readonly TableFieldContext Enabled = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.Enabled", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext DollyEnabled = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.DollyEnabled", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Slot = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.Slot", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext StickDeadzone = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.StickDeadzone", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext LookDeadzone = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.LookDeadzone", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext LookSpeed = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.LookSpeed", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FreeMoveSpeed = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.FreeMoveSpeed", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BlueTeamButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.BlueTeamButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext RedTeamButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.RedTeamButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ChampionSlot1Button = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.ChampionSlot1Button", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ChampionSlot2Button = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.ChampionSlot2Button", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ChampionSlot3Button = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.ChampionSlot3Button", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ChampionSlot4Button = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.ChampionSlot4Button", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ChampionSlot5Button = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.ChampionSlot5Button", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext MoveSmoothing = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.MoveSmoothing", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BuildupSeconds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.BuildupSeconds", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FalloffSeconds = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.FalloffSeconds", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext DirectedMoveSpeed = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.DirectedMoveSpeed", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FalloffCurveX = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.FalloffCurveX", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FalloffCurveY = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.FalloffCurveY", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BuildupCurveX = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.BuildupCurveX", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BuildupCurveY = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.BuildupCurveY", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ChordMoveHold = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.ChordMoveHold", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext CaptureButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.CaptureButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PreviewToggleButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.PreviewToggleButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PreviewStopButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.PreviewStopButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PlayheadBackButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.PlayheadBackButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PlayheadForwardButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.PlayheadForwardButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SpeedFasterButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.SpeedFasterButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SpeedSlowerButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.SpeedSlowerButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext MoveStick = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.MoveStick", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext LookStick = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.LookStick", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext InvertMoveX = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.InvertMoveX", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext InvertMoveY = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.InvertMoveY", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext InvertLookX = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.InvertLookX", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext InvertLookY = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.InvertLookY", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext SwapTriggers = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.SwapTriggers", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ZoomSpeed = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.ZoomSpeed", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext JumpNearestButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.JumpNearestButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext JumpNearestDirectionButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.JumpNearestDirectionButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext RollLeftButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.RollLeftButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext RollRightButton = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.RollRightButton", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext RelativeFreeMovement = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetControllerCameraConfig.RelativeFreeMovement", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SetControllerCameraConfig value)
	{
		int num = 219;
		IList<float> falloffCurveX = value.FalloffCurveX;
		if (falloffCurveX != null)
		{
			num += FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.GetMaxSize(falloffCurveX);
		}
		IList<float> falloffCurveY = value.FalloffCurveY;
		if (falloffCurveY != null)
		{
			num += FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.GetMaxSize(falloffCurveY);
		}
		IList<float> buildupCurveX = value.BuildupCurveX;
		if (buildupCurveX != null)
		{
			num += FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.GetMaxSize(buildupCurveX);
		}
		IList<float> buildupCurveY = value.BuildupCurveY;
		if (buildupCurveY != null)
		{
			num += FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.GetMaxSize(buildupCurveY);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SetControllerCameraConfig value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(125, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[90];
		bool enabled = value.Enabled;
		bool dollyEnabled = value.DollyEnabled;
		int slot = value.Slot;
		float stickDeadzone = value.StickDeadzone;
		float lookDeadzone = value.LookDeadzone;
		float lookSpeed = value.LookSpeed;
		float freeMoveSpeed = value.FreeMoveSpeed;
		ControllerButton blueTeamButton = value.BlueTeamButton;
		ControllerButton redTeamButton = value.RedTeamButton;
		ControllerButton championSlot1Button = value.ChampionSlot1Button;
		ControllerButton championSlot2Button = value.ChampionSlot2Button;
		ControllerButton championSlot3Button = value.ChampionSlot3Button;
		ControllerButton championSlot4Button = value.ChampionSlot4Button;
		ControllerButton championSlot5Button = value.ChampionSlot5Button;
		bool moveSmoothing = value.MoveSmoothing;
		float buildupSeconds = value.BuildupSeconds;
		float falloffSeconds = value.FalloffSeconds;
		float directedMoveSpeed = value.DirectedMoveSpeed;
		IList<float> falloffCurveX = value.FalloffCurveX;
		IList<float> falloffCurveY = value.FalloffCurveY;
		IList<float> buildupCurveX = value.BuildupCurveX;
		IList<float> buildupCurveY = value.BuildupCurveY;
		bool chordMoveHold = value.ChordMoveHold;
		ControllerButton captureButton = value.CaptureButton;
		ControllerButton previewToggleButton = value.PreviewToggleButton;
		ControllerButton previewStopButton = value.PreviewStopButton;
		ControllerButton playheadBackButton = value.PlayheadBackButton;
		ControllerButton playheadForwardButton = value.PlayheadForwardButton;
		ControllerButton speedFasterButton = value.SpeedFasterButton;
		ControllerButton speedSlowerButton = value.SpeedSlowerButton;
		ControllerStick moveStick = value.MoveStick;
		ControllerStick lookStick = value.LookStick;
		bool invertMoveX = value.InvertMoveX;
		bool invertMoveY = value.InvertMoveY;
		bool invertLookX = value.InvertLookX;
		bool invertLookY = value.InvertLookY;
		bool swapTriggers = value.SwapTriggers;
		float zoomSpeed = value.ZoomSpeed;
		ControllerButton jumpNearestButton = value.JumpNearestButton;
		ControllerButton jumpNearestDirectionButton = value.JumpNearestDirectionButton;
		ControllerButton rollLeftButton = value.RollLeftButton;
		ControllerButton rollRightButton = value.RollRightButton;
		bool relativeFreeMovement = value.RelativeFreeMovement;
		int num4 = num;
		if (zoomSpeed != 1f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, zoomSpeed, num4);
			if (80 > num3)
			{
				num3 = 80;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 78);
		int num5 = num;
		if (buildupCurveY != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (48 > num3)
			{
				num3 = 48;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 46);
		int num6 = num;
		if (buildupCurveX != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (46 > num3)
			{
				num3 = 46;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 44);
		int num7 = num;
		if (falloffCurveY != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			if (44 > num3)
			{
				num3 = 44;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 42);
		int num8 = num;
		if (falloffCurveX != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			if (42 > num3)
			{
				num3 = 42;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 40);
		int num9 = num;
		if (directedMoveSpeed != 1f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, directedMoveSpeed, num9);
			if (40 > num3)
			{
				num3 = 40;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 38);
		int num10 = num;
		if (falloffSeconds != 2f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, falloffSeconds, num10);
			if (38 > num3)
			{
				num3 = 38;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 36);
		int num11 = num;
		if (buildupSeconds != 1f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num11 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, buildupSeconds, num11);
			if (36 > num3)
			{
				num3 = 36;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 34);
		int num12 = num;
		if (freeMoveSpeed != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num12 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, freeMoveSpeed, num12);
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 16);
		int num13 = num;
		if (lookSpeed != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num13 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, lookSpeed, num13);
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)(num13 - num), 14);
		int num14 = num;
		if (lookDeadzone != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num14 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, lookDeadzone, num14);
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)(num14 - num), 12);
		int num15 = num;
		if (stickDeadzone != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num15 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, stickDeadzone, num15);
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span14 = span2;
		spanWriter.WriteUShort(span14, (ushort)(num15 - num), 10);
		int num16 = num;
		if (slot != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num16 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N1E4AF840DA947508D3AF090D2CC25201F558B3154B0351D91A6670A9ABEA40CB.Helpers.Serialize(spanWriter, span, slot, num16);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span15 = span2;
		spanWriter.WriteUShort(span15, (ushort)(num16 - num), 8);
		int num17 = num;
		if (relativeFreeMovement)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num17 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, relativeFreeMovement, num17);
			num3 = 90;
		}
		Span<byte> span16 = span2;
		spanWriter.WriteUShort(span16, (ushort)(num17 - num), 88);
		int num18 = num;
		if (rollRightButton != ControllerButton.RightShoulder)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num18 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, rollRightButton, num18);
			if (88 > num3)
			{
				num3 = 88;
			}
		}
		Span<byte> span17 = span2;
		spanWriter.WriteUShort(span17, (ushort)(num18 - num), 86);
		int num19 = num;
		if (rollLeftButton != ControllerButton.LeftShoulder)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num19 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, rollLeftButton, num19);
			if (86 > num3)
			{
				num3 = 86;
			}
		}
		Span<byte> span18 = span2;
		spanWriter.WriteUShort(span18, (ushort)(num19 - num), 84);
		int num20 = num;
		if (jumpNearestDirectionButton != ControllerButton.FaceNorth)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num20 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, jumpNearestDirectionButton, num20);
			if (84 > num3)
			{
				num3 = 84;
			}
		}
		Span<byte> span19 = span2;
		spanWriter.WriteUShort(span19, (ushort)(num20 - num), 82);
		int num21 = num;
		if (jumpNearestButton != ControllerButton.FaceWest)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num21 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, jumpNearestButton, num21);
			if (82 > num3)
			{
				num3 = 82;
			}
		}
		Span<byte> span20 = span2;
		spanWriter.WriteUShort(span20, (ushort)(num21 - num), 80);
		int num22 = num;
		if (swapTriggers)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num22 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, swapTriggers, num22);
			if (78 > num3)
			{
				num3 = 78;
			}
		}
		Span<byte> span21 = span2;
		spanWriter.WriteUShort(span21, (ushort)(num22 - num), 76);
		int num23 = num;
		if (invertLookY)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num23 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, invertLookY, num23);
			if (76 > num3)
			{
				num3 = 76;
			}
		}
		Span<byte> span22 = span2;
		spanWriter.WriteUShort(span22, (ushort)(num23 - num), 74);
		int num24 = num;
		if (invertLookX)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num24 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, invertLookX, num24);
			if (74 > num3)
			{
				num3 = 74;
			}
		}
		Span<byte> span23 = span2;
		spanWriter.WriteUShort(span23, (ushort)(num24 - num), 72);
		int num25 = num;
		if (invertMoveY)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num25 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, invertMoveY, num25);
			if (72 > num3)
			{
				num3 = 72;
			}
		}
		Span<byte> span24 = span2;
		spanWriter.WriteUShort(span24, (ushort)(num25 - num), 70);
		int num26 = num;
		if (invertMoveX)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num26 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, invertMoveX, num26);
			if (70 > num3)
			{
				num3 = 70;
			}
		}
		Span<byte> span25 = span2;
		spanWriter.WriteUShort(span25, (ushort)(num26 - num), 68);
		int num27 = num;
		if (lookStick != ControllerStick.RightStick)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num27 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335.Helpers.Serialize(spanWriter, span, lookStick, num27);
			if (68 > num3)
			{
				num3 = 68;
			}
		}
		Span<byte> span26 = span2;
		spanWriter.WriteUShort(span26, (ushort)(num27 - num), 66);
		int num28 = num;
		if (moveStick != ControllerStick.LeftStick)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num28 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NC6149A24420CABE683B3053E9239FD719A9BFE7F80567E06E563BE9F5FD2B335.Helpers.Serialize(spanWriter, span, moveStick, num28);
			if (66 > num3)
			{
				num3 = 66;
			}
		}
		Span<byte> span27 = span2;
		spanWriter.WriteUShort(span27, (ushort)(num28 - num), 64);
		int num29 = num;
		if (speedSlowerButton != ControllerButton.DPadDown)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num29 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, speedSlowerButton, num29);
			if (64 > num3)
			{
				num3 = 64;
			}
		}
		Span<byte> span28 = span2;
		spanWriter.WriteUShort(span28, (ushort)(num29 - num), 62);
		int num30 = num;
		if (speedFasterButton != ControllerButton.DPadUp)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num30 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, speedFasterButton, num30);
			if (62 > num3)
			{
				num3 = 62;
			}
		}
		Span<byte> span29 = span2;
		spanWriter.WriteUShort(span29, (ushort)(num30 - num), 60);
		int num31 = num;
		if (playheadForwardButton != ControllerButton.DPadRight)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num31 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, playheadForwardButton, num31);
			if (60 > num3)
			{
				num3 = 60;
			}
		}
		Span<byte> span30 = span2;
		spanWriter.WriteUShort(span30, (ushort)(num31 - num), 58);
		int num32 = num;
		if (playheadBackButton != ControllerButton.DPadLeft)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num32 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, playheadBackButton, num32);
			if (58 > num3)
			{
				num3 = 58;
			}
		}
		Span<byte> span31 = span2;
		spanWriter.WriteUShort(span31, (ushort)(num32 - num), 56);
		int num33 = num;
		if (previewStopButton != ControllerButton.FaceEast)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num33 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, previewStopButton, num33);
			if (56 > num3)
			{
				num3 = 56;
			}
		}
		Span<byte> span32 = span2;
		spanWriter.WriteUShort(span32, (ushort)(num33 - num), 54);
		int num34 = num;
		if (previewToggleButton != ControllerButton.Menu)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num34 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, previewToggleButton, num34);
			if (54 > num3)
			{
				num3 = 54;
			}
		}
		Span<byte> span33 = span2;
		spanWriter.WriteUShort(span33, (ushort)(num34 - num), 52);
		int num35 = num;
		if (captureButton != ControllerButton.FaceSouth)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num35 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, captureButton, num35);
			if (52 > num3)
			{
				num3 = 52;
			}
		}
		Span<byte> span34 = span2;
		spanWriter.WriteUShort(span34, (ushort)(num35 - num), 50);
		int num36 = num;
		if (chordMoveHold)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num36 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, chordMoveHold, num36);
			if (50 > num3)
			{
				num3 = 50;
			}
		}
		Span<byte> span35 = span2;
		spanWriter.WriteUShort(span35, (ushort)(num36 - num), 48);
		int num37 = num;
		if (moveSmoothing)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num37 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, moveSmoothing, num37);
			if (34 > num3)
			{
				num3 = 34;
			}
		}
		Span<byte> span36 = span2;
		spanWriter.WriteUShort(span36, (ushort)(num37 - num), 32);
		int num38 = num;
		if (championSlot5Button != ControllerButton.FaceSouth)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num38 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, championSlot5Button, num38);
			if (32 > num3)
			{
				num3 = 32;
			}
		}
		Span<byte> span37 = span2;
		spanWriter.WriteUShort(span37, (ushort)(num38 - num), 30);
		int num39 = num;
		if (championSlot4Button != ControllerButton.DPadDown)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num39 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, championSlot4Button, num39);
			if (30 > num3)
			{
				num3 = 30;
			}
		}
		Span<byte> span38 = span2;
		spanWriter.WriteUShort(span38, (ushort)(num39 - num), 28);
		int num40 = num;
		if (championSlot3Button != ControllerButton.DPadRight)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num40 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, championSlot3Button, num40);
			if (28 > num3)
			{
				num3 = 28;
			}
		}
		Span<byte> span39 = span2;
		spanWriter.WriteUShort(span39, (ushort)(num40 - num), 26);
		int num41 = num;
		if (championSlot2Button != ControllerButton.DPadLeft)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num41 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, championSlot2Button, num41);
			if (26 > num3)
			{
				num3 = 26;
			}
		}
		Span<byte> span40 = span2;
		spanWriter.WriteUShort(span40, (ushort)(num41 - num), 24);
		int num42 = num;
		if (championSlot1Button != ControllerButton.DPadUp)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num42 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, championSlot1Button, num42);
			if (24 > num3)
			{
				num3 = 24;
			}
		}
		Span<byte> span41 = span2;
		spanWriter.WriteUShort(span41, (ushort)(num42 - num), 22);
		int num43 = num;
		if (redTeamButton != ControllerButton.RightShoulder)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num43 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, redTeamButton, num43);
			if (22 > num3)
			{
				num3 = 22;
			}
		}
		Span<byte> span42 = span2;
		spanWriter.WriteUShort(span42, (ushort)(num43 - num), 20);
		int num44 = num;
		if (blueTeamButton != ControllerButton.LeftShoulder)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num44 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N69D7F7623B4239C15F836C7E1A1A7E004095053C6DEE9E02CBF0F71C1ABC2D85.Helpers.Serialize(spanWriter, span, blueTeamButton, num44);
			if (20 > num3)
			{
				num3 = 20;
			}
		}
		Span<byte> span43 = span2;
		spanWriter.WriteUShort(span43, (ushort)(num44 - num), 18);
		int num45 = num;
		if (dollyEnabled)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num45 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, dollyEnabled, num45);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span44 = span2;
		spanWriter.WriteUShort(span44, (ushort)(num45 - num), 6);
		int num46 = num;
		if (enabled)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num46 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, enabled, num46);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span45 = span2;
		spanWriter.WriteUShort(span45, (ushort)(num46 - num), 4);
		int num47 = num2 - num;
		context.Offset -= 125 - num47;
		Span<byte> span46 = span2;
		spanWriter.WriteUShort(span46, (ushort)num3, 0);
		Span<byte> span47 = span2;
		spanWriter.WriteUShort(span47, (ushort)num47, 2);
		int num48 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num48, num);
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Serialize(spanWriter, span, buildupCurveY, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Serialize(spanWriter, span, buildupCurveX, num6, context);
		}
		if (num7 != num)
		{
			FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Serialize(spanWriter, span, falloffCurveY, num7, context);
		}
		if (num8 != num)
		{
			FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Serialize(spanWriter, span, falloffCurveX, num8, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_9a3bef6d540a48ea87f8ee26ac57c81f_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
