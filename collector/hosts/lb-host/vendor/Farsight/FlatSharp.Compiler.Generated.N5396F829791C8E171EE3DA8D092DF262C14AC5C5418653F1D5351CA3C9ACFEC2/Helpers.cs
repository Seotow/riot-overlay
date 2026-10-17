using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75;
using FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Compiler.Generated.ND947104E7969952557C54C9055CF59C7471A6BF89368F407490E5EB3993416BD;
using FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C;
using FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321;
using FlatSharp.Compiler.Generated.NE5FB5D353CD36AB32D6886A5CFB0E8F43D17A9228E2F60EE662CF13134802372;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N5396F829791C8E171EE3DA8D092DF262C14AC5C5418653F1D5351CA3C9ACFEC2;

internal static class Helpers
{
	[DebuggerDisplay("Lazy StrokeDrawComplete")]
	internal sealed class tableReader_b48bcacf989241fbb5f9045d6737e924_Lazy<TInputBuffer> : StrokeDrawComplete, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeDrawComplete);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required string StrokeId
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

		public override required ColorRGBA Color
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

		public override float Width
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

		public override StrokeLayer Layer
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

		public override StrokeTipStyle StartTip
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

		public override StrokeTipStyle EndTip
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

		public override StrokeLineStyle LineStyle
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

		public override float VanishTime
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

		public override StrokeTimeMode TimeMode
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

		public override required IList<Vector3> Points
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

		public override IList<float>? PointGameTimes
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

		public override bool IsArea
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

		public override bool HasOutline
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

		public override ColorRGBA? FillColor
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

		public override float RevealDuration
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

		public override uint AnchorNetworkId
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_b48bcacf989241fbb5f9045d6737e924_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.StrokeId");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ColorRGBA ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Color");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
		private static StrokeLayer ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return StrokeLayer.underEverything;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTipStyle ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return StrokeTipStyle.circle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTipStyle ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return StrokeTipStyle.circle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeLineStyle ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return StrokeLineStyle.solid;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE5FB5D353CD36AB32D6886A5CFB0E8F43D17A9228E2F60EE662CF13134802372.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTimeMode ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return StrokeTimeMode.wallClock;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND947104E7969952557C54C9055CF59C7471A6BF89368F407490E5EB3993416BD.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Vector3> ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Points");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_8af99f495acf40769211120e1bdcfbd0.Points);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_8af99f495acf40769211120e1bdcfbd0.PointGameTimes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ColorRGBA? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive StrokeDrawComplete")]
	internal sealed class tableReader_b48bcacf989241fbb5f9045d6737e924_Progressive<TInputBuffer> : StrokeDrawComplete, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private string __index0Value;

		private ColorRGBA __index1Value;

		private float __index2Value;

		private StrokeLayer __index3Value;

		private StrokeTipStyle __index4Value;

		private StrokeTipStyle __index5Value;

		private StrokeLineStyle __index6Value;

		private float __index7Value;

		private byte __mask1;

		private StrokeTimeMode __index8Value;

		private IList<Vector3> __index9Value;

		private IList<float>? __index10Value;

		private bool __index11Value;

		private bool __index12Value;

		private ColorRGBA? __index13Value;

		private float __index14Value;

		private uint __index15Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeDrawComplete);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required string StrokeId
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

		public override required ColorRGBA Color
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

		public override float Width
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

		public override StrokeLayer Layer
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

		public override StrokeTipStyle StartTip
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

		public override StrokeTipStyle EndTip
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

		public override StrokeLineStyle LineStyle
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

		public override float VanishTime
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

		public override StrokeTimeMode TimeMode
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

		public override required IList<Vector3> Points
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

		public override IList<float>? PointGameTimes
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

		public override bool IsArea
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

		public override bool HasOutline
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

		public override ColorRGBA? FillColor
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

		public override float RevealDuration
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

		public override uint AnchorNetworkId
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_b48bcacf989241fbb5f9045d6737e924_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			__index0Value = null;
			__index1Value = null;
			__index9Value = null;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.StrokeId");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ColorRGBA ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Color");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
		private static StrokeLayer ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return StrokeLayer.underEverything;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTipStyle ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return StrokeTipStyle.circle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTipStyle ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return StrokeTipStyle.circle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeLineStyle ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return StrokeLineStyle.solid;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE5FB5D353CD36AB32D6886A5CFB0E8F43D17A9228E2F60EE662CF13134802372.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTimeMode ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return StrokeTimeMode.wallClock;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND947104E7969952557C54C9055CF59C7471A6BF89368F407490E5EB3993416BD.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Vector3> ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Points");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_8af99f495acf40769211120e1bdcfbd0.Points);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_8af99f495acf40769211120e1bdcfbd0.PointGameTimes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ColorRGBA? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy StrokeDrawComplete")]
	internal sealed class tableReader_b48bcacf989241fbb5f9045d6737e924_Greedy<TInputBuffer> : StrokeDrawComplete, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private string __index0Value;

		private ColorRGBA __index1Value;

		private float __index2Value;

		private StrokeLayer __index3Value;

		private StrokeTipStyle __index4Value;

		private StrokeTipStyle __index5Value;

		private StrokeLineStyle __index6Value;

		private float __index7Value;

		private StrokeTimeMode __index8Value;

		private IList<Vector3> __index9Value;

		private IList<float>? __index10Value;

		private bool __index11Value;

		private bool __index12Value;

		private ColorRGBA? __index13Value;

		private float __index14Value;

		private uint __index15Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeDrawComplete);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required string StrokeId
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

		public override required ColorRGBA Color
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

		public override float Width
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

		public override StrokeLayer Layer
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

		public override StrokeTipStyle StartTip
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

		public override StrokeTipStyle EndTip
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

		public override StrokeLineStyle LineStyle
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

		public override float VanishTime
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

		public override StrokeTimeMode TimeMode
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

		public override required IList<Vector3> Points
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

		public override IList<float>? PointGameTimes
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

		public override bool IsArea
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

		public override bool HasOutline
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

		public override ColorRGBA? FillColor
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

		public override float RevealDuration
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

		public override uint AnchorNetworkId
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_b48bcacf989241fbb5f9045d6737e924_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.StrokeId");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ColorRGBA ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Color");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
		private static StrokeLayer ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return StrokeLayer.underEverything;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTipStyle ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return StrokeTipStyle.circle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTipStyle ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return StrokeTipStyle.circle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeLineStyle ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return StrokeLineStyle.solid;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE5FB5D353CD36AB32D6886A5CFB0E8F43D17A9228E2F60EE662CF13134802372.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTimeMode ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return StrokeTimeMode.wallClock;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND947104E7969952557C54C9055CF59C7471A6BF89368F407490E5EB3993416BD.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Vector3> ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Points");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_8af99f495acf40769211120e1bdcfbd0.Points);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_8af99f495acf40769211120e1bdcfbd0.PointGameTimes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ColorRGBA? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable StrokeDrawComplete")]
	internal sealed class tableReader_b48bcacf989241fbb5f9045d6737e924_GreedyMutable<TInputBuffer> : StrokeDrawComplete, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private string __index0Value;

		private ColorRGBA __index1Value;

		private float __index2Value;

		private StrokeLayer __index3Value;

		private StrokeTipStyle __index4Value;

		private StrokeTipStyle __index5Value;

		private StrokeLineStyle __index6Value;

		private float __index7Value;

		private StrokeTimeMode __index8Value;

		private IList<Vector3> __index9Value;

		private IList<float>? __index10Value;

		private bool __index11Value;

		private bool __index12Value;

		private ColorRGBA? __index13Value;

		private float __index14Value;

		private uint __index15Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeDrawComplete);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required string StrokeId
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

		public override required ColorRGBA Color
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

		public override float Width
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

		public override StrokeLayer Layer
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

		public override StrokeTipStyle StartTip
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

		public override StrokeTipStyle EndTip
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

		public override StrokeLineStyle LineStyle
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

		public override float VanishTime
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

		public override StrokeTimeMode TimeMode
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

		public override required IList<Vector3> Points
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

		public override IList<float>? PointGameTimes
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

		public override bool IsArea
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

		public override bool HasOutline
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

		public override ColorRGBA? FillColor
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

		public override float RevealDuration
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

		public override uint AnchorNetworkId
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_b48bcacf989241fbb5f9045d6737e924_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.StrokeId");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ColorRGBA ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Color");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
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
		private static StrokeLayer ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return StrokeLayer.underEverything;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTipStyle ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return StrokeTipStyle.circle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTipStyle ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return StrokeTipStyle.circle;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeLineStyle ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return StrokeLineStyle.solid;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE5FB5D353CD36AB32D6886A5CFB0E8F43D17A9228E2F60EE662CF13134802372.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static StrokeTimeMode ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return StrokeTimeMode.wallClock;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND947104E7969952557C54C9055CF59C7471A6BF89368F407490E5EB3993416BD.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Vector3> ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Points");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_8af99f495acf40769211120e1bdcfbd0.Points);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_8af99f495acf40769211120e1bdcfbd0.PointGameTimes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ColorRGBA? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static uint ReadIndex15Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 15);
			if (num == 0)
			{
				return 0u;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_8af99f495acf40769211120e1bdcfbd0
	{
		public static readonly TableFieldContext StrokeId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.StrokeId", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Color = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Color", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Width = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Width", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Layer = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Layer", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext StartTip = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.StartTip", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext EndTip = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.EndTip", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext LineStyle = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.LineStyle", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext VanishTime = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.VanishTime", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext TimeMode = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.TimeMode", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Points = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Points", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PointGameTimes = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.PointGameTimes", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext IsArea = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.IsArea", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext HasOutline = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.HasOutline", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FillColor = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.FillColor", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext RevealDuration = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.RevealDuration", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AnchorNetworkId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.AnchorNetworkId", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(StrokeDrawComplete value)
	{
		int num = 108;
		string strokeId = value.StrokeId;
		if (strokeId != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(strokeId);
		}
		IList<Vector3> points = value.Points;
		if (points != null)
		{
			num += FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.GetMaxSize(points);
		}
		IList<float> pointGameTimes = value.PointGameTimes;
		if (pointGameTimes != null)
		{
			num += FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.GetMaxSize(pointGameTimes);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, StrokeDrawComplete value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(68, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 24;
		Span<byte> span2 = stackalloc byte[36];
		string strokeId = value.StrokeId;
		ColorRGBA color = value.Color;
		float width = value.Width;
		StrokeLayer layer = value.Layer;
		StrokeTipStyle startTip = value.StartTip;
		StrokeTipStyle endTip = value.EndTip;
		StrokeLineStyle lineStyle = value.LineStyle;
		float vanishTime = value.VanishTime;
		StrokeTimeMode timeMode = value.TimeMode;
		IList<Vector3> points = value.Points;
		IList<float> pointGameTimes = value.PointGameTimes;
		bool isArea = value.IsArea;
		bool hasOutline = value.HasOutline;
		ColorRGBA fillColor = value.FillColor;
		float revealDuration = value.RevealDuration;
		uint anchorNetworkId = value.AnchorNetworkId;
		int num4 = num;
		if (anchorNetworkId != 0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.N545AE763FCB09A83BCE26918943ECB13F299E8BBD30EBC1FE03FA871EC94C291.Helpers.Serialize(spanWriter, span, anchorNetworkId, num4);
			num3 = 36;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 34);
		int num5 = num;
		if (revealDuration != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, revealDuration, num5);
			if (34 > num3)
			{
				num3 = 34;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 32);
		int num6 = num;
		if (pointGameTimes != null)
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
		if (points != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Points");
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 22);
		int num8 = num;
		if (vanishTime != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, vanishTime, num8);
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 18);
		int num9 = num;
		if (width != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, width, num9);
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 8);
		int num10 = num;
		if (strokeId != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.StrokeId");
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 4);
		int num11 = num;
		if (hasOutline)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num11 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, hasOutline, num11);
			if (30 > num3)
			{
				num3 = 30;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 28);
		int num12 = num;
		if (isArea)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num12 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, isArea, num12);
			if (28 > num3)
			{
				num3 = 28;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 26);
		int num13 = num;
		if (timeMode != StrokeTimeMode.wallClock)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num13 = num2;
			num2++;
			FlatSharp.Compiler.Generated.ND947104E7969952557C54C9055CF59C7471A6BF89368F407490E5EB3993416BD.Helpers.Serialize(spanWriter, span, timeMode, num13);
		}
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)(num13 - num), 20);
		int num14 = num;
		if (lineStyle != StrokeLineStyle.solid)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num14 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NE5FB5D353CD36AB32D6886A5CFB0E8F43D17A9228E2F60EE662CF13134802372.Helpers.Serialize(spanWriter, span, lineStyle, num14);
		}
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)(num14 - num), 16);
		int num15 = num;
		if (endTip != StrokeTipStyle.circle)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num15 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683.Helpers.Serialize(spanWriter, span, endTip, num15);
		}
		Span<byte> span14 = span2;
		spanWriter.WriteUShort(span14, (ushort)(num15 - num), 14);
		int num16 = num;
		if (startTip != StrokeTipStyle.circle)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num16 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N183B497E2FC90F44BF860220B75326E99B071BDCCD30205867FC9C6B38D29683.Helpers.Serialize(spanWriter, span, startTip, num16);
		}
		Span<byte> span15 = span2;
		spanWriter.WriteUShort(span15, (ushort)(num16 - num), 12);
		int num17 = num;
		if (layer != StrokeLayer.underEverything)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num17 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NE4543F7A17A19BDAC3E8E48B10B4F31871AB3F40EC192119FBE1F38F18BF4321.Helpers.Serialize(spanWriter, span, layer, num17);
		}
		Span<byte> span16 = span2;
		spanWriter.WriteUShort(span16, (ushort)(num17 - num), 10);
		int num18 = num;
		if (fillColor != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num18 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C.Helpers.Serialize(spanWriter, span, fillColor, num18);
			if (32 > num3)
			{
				num3 = 32;
			}
		}
		Span<byte> span17 = span2;
		spanWriter.WriteUShort(span17, (ushort)(num18 - num), 30);
		int num19 = num;
		if (color != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num19 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NE03A1C6FD2C31895C4CBF963A3A420E127B1535902426F1DCC1926916FEC2B2C.Helpers.Serialize(spanWriter, span, color, num19);
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeDrawComplete.Color");
		}
		Span<byte> span18 = span2;
		spanWriter.WriteUShort(span18, (ushort)(num19 - num), 6);
		int num20 = num2 - num;
		context.Offset -= 68 - num20;
		Span<byte> span19 = span2;
		spanWriter.WriteUShort(span19, (ushort)num3, 0);
		Span<byte> span20 = span2;
		spanWriter.WriteUShort(span20, (ushort)num20, 2);
		int num21 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num21, num);
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Serialize(spanWriter, span, pointGameTimes, num6, context);
		}
		if (num7 != num)
		{
			FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.Serialize(spanWriter, span, points, num7, context);
		}
		if (num10 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, strokeId, num10, context, tableMetadata_8af99f495acf40769211120e1bdcfbd0.StrokeId);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b48bcacf989241fbb5f9045d6737e924_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_b48bcacf989241fbb5f9045d6737e924_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b48bcacf989241fbb5f9045d6737e924_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_b48bcacf989241fbb5f9045d6737e924_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b48bcacf989241fbb5f9045d6737e924_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_b48bcacf989241fbb5f9045d6737e924_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b48bcacf989241fbb5f9045d6737e924_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_b48bcacf989241fbb5f9045d6737e924_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
