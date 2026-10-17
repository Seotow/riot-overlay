using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.NCE72279C81AC4DE6F64D1E4037E2E011CDF358D709339EFCB945876DD444F1B2;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N6F230B522BBBF1144BE2700AF745FECA8A0194777CEEF1E529BF92BCFC5586C1;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SetCinematicPropEditor")]
	internal sealed class tableReader_27c3215d3230440a832bce16bdc50f58_Lazy<TInputBuffer> : SetCinematicPropEditor, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCinematicPropEditor);

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

		public override ulong Generation
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

		public override float Playhead
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

		public override IList<CinematicPropPath>? Paths
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
		public tableReader_27c3215d3230440a832bce16bdc50f58_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static ulong ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static IList<CinematicPropPath>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCE72279C81AC4DE6F64D1E4037E2E011CDF358D709339EFCB945876DD444F1B2.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_d41a7d66c99d494caa684d3c8ae971a8.Paths);
		}
	}

	[DebuggerDisplay("Progressive SetCinematicPropEditor")]
	internal sealed class tableReader_27c3215d3230440a832bce16bdc50f58_Progressive<TInputBuffer> : SetCinematicPropEditor, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private bool __index0Value;

		private ulong __index1Value;

		private float __index2Value;

		private IList<CinematicPropPath>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCinematicPropEditor);

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

		public override ulong Generation
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

		public override float Playhead
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

		public override IList<CinematicPropPath>? Paths
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
		public tableReader_27c3215d3230440a832bce16bdc50f58_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static ulong ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static IList<CinematicPropPath>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCE72279C81AC4DE6F64D1E4037E2E011CDF358D709339EFCB945876DD444F1B2.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_d41a7d66c99d494caa684d3c8ae971a8.Paths);
		}
	}

	[DebuggerDisplay("Greedy SetCinematicPropEditor")]
	internal sealed class tableReader_27c3215d3230440a832bce16bdc50f58_Greedy<TInputBuffer> : SetCinematicPropEditor, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private bool __index0Value;

		private ulong __index1Value;

		private float __index2Value;

		private IList<CinematicPropPath>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCinematicPropEditor);

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

		public override ulong Generation
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

		public override float Playhead
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

		public override IList<CinematicPropPath>? Paths
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
		public tableReader_27c3215d3230440a832bce16bdc50f58_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
		private static bool ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static ulong ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static IList<CinematicPropPath>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCE72279C81AC4DE6F64D1E4037E2E011CDF358D709339EFCB945876DD444F1B2.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_d41a7d66c99d494caa684d3c8ae971a8.Paths);
		}
	}

	[DebuggerDisplay("GreedyMutable SetCinematicPropEditor")]
	internal sealed class tableReader_27c3215d3230440a832bce16bdc50f58_GreedyMutable<TInputBuffer> : SetCinematicPropEditor, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private bool __index0Value;

		private ulong __index1Value;

		private float __index2Value;

		private IList<CinematicPropPath>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SetCinematicPropEditor);

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

		public override ulong Generation
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

		public override float Playhead
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

		public override IList<CinematicPropPath>? Paths
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
		public tableReader_27c3215d3230440a832bce16bdc50f58_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
		private static bool ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static ulong ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static float ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static IList<CinematicPropPath>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCE72279C81AC4DE6F64D1E4037E2E011CDF358D709339EFCB945876DD444F1B2.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_d41a7d66c99d494caa684d3c8ae971a8.Paths);
		}
	}

	private static class tableMetadata_d41a7d66c99d494caa684d3c8ae971a8
	{
		public static readonly TableFieldContext Enabled = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetCinematicPropEditor.Enabled", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Generation = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetCinematicPropEditor.Generation", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Playhead = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetCinematicPropEditor.Playhead", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Paths = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.SetCinematicPropEditor.Paths", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SetCinematicPropEditor value)
	{
		int num = 50;
		IList<CinematicPropPath> paths = value.Paths;
		if (paths != null)
		{
			num += FlatSharp.Compiler.Generated.NCE72279C81AC4DE6F64D1E4037E2E011CDF358D709339EFCB945876DD444F1B2.Helpers.GetMaxSize(paths);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SetCinematicPropEditor value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(34, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[12];
		bool enabled = value.Enabled;
		ulong generation = value.Generation;
		float playhead = value.Playhead;
		IList<CinematicPropPath> paths = value.Paths;
		int num4 = num;
		if (generation != 0L)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 8);
			num4 = num2;
			num2 += 8;
			FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Serialize(spanWriter, span, generation, num4);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 6);
		int num5 = num;
		if (paths != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			num3 = 12;
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 10);
		int num6 = num;
		if (playhead != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, playhead, num6);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 8);
		int num7 = num;
		if (enabled)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num7 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, enabled, num7);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 4);
		int num8 = num2 - num;
		context.Offset -= 34 - num8;
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num3, 0);
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)num8, 2);
		int num9 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num9, num);
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.NCE72279C81AC4DE6F64D1E4037E2E011CDF358D709339EFCB945876DD444F1B2.Helpers.Serialize(spanWriter, span, paths, num5, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_27c3215d3230440a832bce16bdc50f58_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_27c3215d3230440a832bce16bdc50f58_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_27c3215d3230440a832bce16bdc50f58_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_27c3215d3230440a832bce16bdc50f58_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_27c3215d3230440a832bce16bdc50f58_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_27c3215d3230440a832bce16bdc50f58_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_27c3215d3230440a832bce16bdc50f58_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_27c3215d3230440a832bce16bdc50f58_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
