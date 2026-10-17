using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N3FED263F69F3A17D1EC89200C766335591F8A541CF115B0D7E8F82E9F52AF150;
using FlatSharp.Compiler.Generated.N5E4A31A45558D8C1288CB7447C28AFD57BA3990216295ACC598129730E727AA2;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.N84965F1012D4A2C838BF71996D8ADBB9BE3DA431C0E20CD360485A207F083F15;
using FlatSharp.Compiler.Generated.N9A54CFF2F33AD8D3E3BF288E231D93F45414F58AE61CF14B3CB7D5B44ED7F949;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N5BEF05EB41A477416E7B04EAE6AF475A256A0E07F11F303C0F2AB29C27FCE326;

internal static class Helpers
{
	[DebuggerDisplay("Lazy CameraPreviewOutputDefinition")]
	internal sealed class tableReader_c136adea98334a1fb24063814f8b2c56_Lazy<TInputBuffer> : CameraPreviewOutputDefinition, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewOutputDefinition);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required string Id
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

		public override CameraPreviewOutputDestination Destination
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

		public override CameraPreviewLayout? Layout
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

		public override CameraPreviewBorderStyle? Border
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

		public override CameraPreviewTransition? Transition
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c136adea98334a1fb24063814f8b2c56_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Id");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewOutputDestination ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return CameraPreviewOutputDestination.InGame;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5E4A31A45558D8C1288CB7447C28AFD57BA3990216295ACC598129730E727AA2.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewLayout? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Layout");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N3FED263F69F3A17D1EC89200C766335591F8A541CF115B0D7E8F82E9F52AF150.Helpers.Parse_Lazy(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewBorderStyle? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N84965F1012D4A2C838BF71996D8ADBB9BE3DA431C0E20CD360485A207F083F15.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewTransition? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9A54CFF2F33AD8D3E3BF288E231D93F45414F58AE61CF14B3CB7D5B44ED7F949.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive CameraPreviewOutputDefinition")]
	internal sealed class tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer> : CameraPreviewOutputDefinition, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		private byte __mask0;

		private string __index0Value;

		private CameraPreviewOutputDestination __index1Value;

		private CameraPreviewLayout? __index2Value;

		private CameraPreviewBorderStyle? __index4Value;

		private CameraPreviewTransition? __index5Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewOutputDefinition);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required string Id
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

		public override CameraPreviewOutputDestination Destination
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

		public override CameraPreviewLayout? Layout
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

		public override CameraPreviewBorderStyle? Border
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

		public override CameraPreviewTransition? Transition
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c136adea98334a1fb24063814f8b2c56_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			__index0Value = null;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Id");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewOutputDestination ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return CameraPreviewOutputDestination.InGame;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5E4A31A45558D8C1288CB7447C28AFD57BA3990216295ACC598129730E727AA2.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewLayout? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Layout");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N3FED263F69F3A17D1EC89200C766335591F8A541CF115B0D7E8F82E9F52AF150.Helpers.Parse_Progressive(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewBorderStyle? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N84965F1012D4A2C838BF71996D8ADBB9BE3DA431C0E20CD360485A207F083F15.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewTransition? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9A54CFF2F33AD8D3E3BF288E231D93F45414F58AE61CF14B3CB7D5B44ED7F949.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy CameraPreviewOutputDefinition")]
	internal sealed class tableReader_c136adea98334a1fb24063814f8b2c56_Greedy<TInputBuffer> : CameraPreviewOutputDefinition, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private string __index0Value;

		private CameraPreviewOutputDestination __index1Value;

		private CameraPreviewLayout? __index2Value;

		private CameraPreviewBorderStyle? __index4Value;

		private CameraPreviewTransition? __index5Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewOutputDefinition);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required string Id
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

		public override CameraPreviewOutputDestination Destination
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

		public override CameraPreviewLayout? Layout
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

		public override CameraPreviewBorderStyle? Border
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

		public override CameraPreviewTransition? Transition
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c136adea98334a1fb24063814f8b2c56_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Id");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewOutputDestination ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return CameraPreviewOutputDestination.InGame;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5E4A31A45558D8C1288CB7447C28AFD57BA3990216295ACC598129730E727AA2.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewLayout? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Layout");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N3FED263F69F3A17D1EC89200C766335591F8A541CF115B0D7E8F82E9F52AF150.Helpers.Parse_Greedy(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewBorderStyle? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N84965F1012D4A2C838BF71996D8ADBB9BE3DA431C0E20CD360485A207F083F15.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewTransition? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9A54CFF2F33AD8D3E3BF288E231D93F45414F58AE61CF14B3CB7D5B44ED7F949.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable CameraPreviewOutputDefinition")]
	internal sealed class tableReader_c136adea98334a1fb24063814f8b2c56_GreedyMutable<TInputBuffer> : CameraPreviewOutputDefinition, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private string __index0Value;

		private CameraPreviewOutputDestination __index1Value;

		private CameraPreviewLayout? __index2Value;

		private CameraPreviewBorderStyle? __index4Value;

		private CameraPreviewTransition? __index5Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CameraPreviewOutputDefinition);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required string Id
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

		public override CameraPreviewOutputDestination Destination
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

		public override CameraPreviewLayout? Layout
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

		public override CameraPreviewBorderStyle? Border
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

		public override CameraPreviewTransition? Transition
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c136adea98334a1fb24063814f8b2c56_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Id");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewOutputDestination ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return CameraPreviewOutputDestination.InGame;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5E4A31A45558D8C1288CB7447C28AFD57BA3990216295ACC598129730E727AA2.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewLayout? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
				FSThrow.InvalidData_UnionOnlyPartiallyPresent("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Layout");
			}
			(int, int) offset2 = (num + offset, num3 + offset);
			return FlatSharp.Compiler.Generated.N3FED263F69F3A17D1EC89200C766335591F8A541CF115B0D7E8F82E9F52AF150.Helpers.Parse_GreedyMutable(buffer, ref offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewBorderStyle? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N84965F1012D4A2C838BF71996D8ADBB9BE3DA431C0E20CD360485A207F083F15.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static CameraPreviewTransition? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9A54CFF2F33AD8D3E3BF288E231D93F45414F58AE61CF14B3CB7D5B44ED7F949.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_afc8e45416924a86b67750cb72909bbc
	{
		public static readonly TableFieldContext Id = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Id", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Destination = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Destination", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Layout = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Layout", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Border = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Border", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Transition = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Transition", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(CameraPreviewOutputDefinition value)
	{
		int num = 54;
		string id = value.Id;
		if (id != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(id);
		}
		CameraPreviewLayout? layout = value.Layout;
		if (layout.HasValue)
		{
			num += FlatSharp.Compiler.Generated.N3FED263F69F3A17D1EC89200C766335591F8A541CF115B0D7E8F82E9F52AF150.Helpers.GetMaxSize(layout);
		}
		CameraPreviewBorderStyle border = value.Border;
		if (border != null)
		{
			num += FlatSharp.Compiler.Generated.N84965F1012D4A2C838BF71996D8ADBB9BE3DA431C0E20CD360485A207F083F15.Helpers.GetMaxSize(border);
		}
		CameraPreviewTransition transition = value.Transition;
		if (transition != null)
		{
			num += FlatSharp.Compiler.Generated.N9A54CFF2F33AD8D3E3BF288E231D93F45414F58AE61CF14B3CB7D5B44ED7F949.Helpers.GetMaxSize(transition);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CameraPreviewOutputDefinition value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(34, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 6;
		Span<byte> span2 = stackalloc byte[16];
		string id = value.Id;
		CameraPreviewOutputDestination destination = value.Destination;
		CameraPreviewLayout? layout = value.Layout;
		CameraPreviewBorderStyle border = value.Border;
		CameraPreviewTransition transition = value.Transition;
		int num4 = num;
		if (transition != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 16;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 14);
		int num5 = num;
		if (border != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 12);
		int num6 = num;
		if (layout.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 10);
		int num7 = num;
		if (id != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.CameraPreviewOutputDefinition.Id");
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 4);
		int num8 = num;
		if (layout.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num8 = num2;
			num2++;
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 8);
		int num9 = num;
		if (destination != CameraPreviewOutputDestination.InGame)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num9 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N5E4A31A45558D8C1288CB7447C28AFD57BA3990216295ACC598129730E727AA2.Helpers.Serialize(spanWriter, span, destination, num9);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 6);
		int num10 = num2 - num;
		context.Offset -= 34 - num10;
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)num3, 0);
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)num10, 2);
		int num11 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num11, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N9A54CFF2F33AD8D3E3BF288E231D93F45414F58AE61CF14B3CB7D5B44ED7F949.Helpers.Serialize(spanWriter, span, transition, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N84965F1012D4A2C838BF71996D8ADBB9BE3DA431C0E20CD360485A207F083F15.Helpers.Serialize(spanWriter, span, border, num5, context);
		}
		if (num7 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, id, num7, context, tableMetadata_afc8e45416924a86b67750cb72909bbc.Id);
		}
		if (num8 != num)
		{
			(int, int) offset2 = (num8, num6);
			FlatSharp.Compiler.Generated.N3FED263F69F3A17D1EC89200C766335591F8A541CF115B0D7E8F82E9F52AF150.Helpers.Serialize(spanWriter, span, layout, ref offset2, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c136adea98334a1fb24063814f8b2c56_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c136adea98334a1fb24063814f8b2c56_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c136adea98334a1fb24063814f8b2c56_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c136adea98334a1fb24063814f8b2c56_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c136adea98334a1fb24063814f8b2c56_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c136adea98334a1fb24063814f8b2c56_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c136adea98334a1fb24063814f8b2c56_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
