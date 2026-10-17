using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NFE7C58792E9D91F2107E1720B9829B1887CA65017B1233EFCF5B59665B5ACC54;

internal static class Helpers
{
	[DebuggerDisplay("Lazy StrokeSyncPointsRemote")]
	internal sealed class tableReader_92939a4a1e37462ebeddc6686c337749_Lazy<TInputBuffer> : StrokeSyncPointsRemote, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncPointsRemote);

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

		public override required IList<Vector3> Points
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

		public override IList<float>? PointGameTimes
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

		public override IList<float>? Pressures
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
		public tableReader_92939a4a1e37462ebeddc6686c337749_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.StrokeId");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Vector3> ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.Points");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.Points);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.PointGameTimes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.Pressures);
		}
	}

	[DebuggerDisplay("Progressive StrokeSyncPointsRemote")]
	internal sealed class tableReader_92939a4a1e37462ebeddc6686c337749_Progressive<TInputBuffer> : StrokeSyncPointsRemote, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private string __index0Value;

		private IList<Vector3> __index1Value;

		private IList<float>? __index2Value;

		private IList<float>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncPointsRemote);

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

		public override required IList<Vector3> Points
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

		public override IList<float>? PointGameTimes
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

		public override IList<float>? Pressures
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
		public tableReader_92939a4a1e37462ebeddc6686c337749_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			__index0Value = null;
			__index1Value = null;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.StrokeId");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Vector3> ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.Points");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.Points);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.PointGameTimes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.Pressures);
		}
	}

	[DebuggerDisplay("Greedy StrokeSyncPointsRemote")]
	internal sealed class tableReader_92939a4a1e37462ebeddc6686c337749_Greedy<TInputBuffer> : StrokeSyncPointsRemote, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private string __index0Value;

		private IList<Vector3> __index1Value;

		private IList<float>? __index2Value;

		private IList<float>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncPointsRemote);

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

		public override required IList<Vector3> Points
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

		public override IList<float>? PointGameTimes
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

		public override IList<float>? Pressures
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
		public tableReader_92939a4a1e37462ebeddc6686c337749_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.StrokeId");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Vector3> ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.Points");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.Points);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.PointGameTimes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.Pressures);
		}
	}

	[DebuggerDisplay("GreedyMutable StrokeSyncPointsRemote")]
	internal sealed class tableReader_92939a4a1e37462ebeddc6686c337749_GreedyMutable<TInputBuffer> : StrokeSyncPointsRemote, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private string __index0Value;

		private IList<Vector3> __index1Value;

		private IList<float>? __index2Value;

		private IList<float>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(StrokeSyncPointsRemote);

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

		public override required IList<Vector3> Points
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

		public override IList<float>? PointGameTimes
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

		public override IList<float>? Pressures
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
		public tableReader_92939a4a1e37462ebeddc6686c337749_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.StrokeId");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Vector3> ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.Points");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.Points);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.PointGameTimes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<float>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_e79197585bbc49528d3ff974c1de0978.Pressures);
		}
	}

	private static class tableMetadata_e79197585bbc49528d3ff974c1de0978
	{
		public static readonly TableFieldContext StrokeId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.StrokeId", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Points = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.Points", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PointGameTimes = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.PointGameTimes", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Pressures = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.Pressures", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(StrokeSyncPointsRemote value)
	{
		int num = 48;
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
		IList<float> pressures = value.Pressures;
		if (pressures != null)
		{
			num += FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.GetMaxSize(pressures);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, StrokeSyncPointsRemote value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(32, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 8;
		Span<byte> span2 = stackalloc byte[12];
		string strokeId = value.StrokeId;
		IList<Vector3> points = value.Points;
		IList<float> pointGameTimes = value.PointGameTimes;
		IList<float> pressures = value.Pressures;
		int num4 = num;
		if (pressures != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 12;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 10);
		int num5 = num;
		if (pointGameTimes != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 8);
		int num6 = num;
		if (points != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.Points");
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 6);
		int num7 = num;
		if (strokeId != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Commands.StrokeSyncPointsRemote.StrokeId");
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 4);
		int num8 = num2 - num;
		context.Offset -= 32 - num8;
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num3, 0);
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)num8, 2);
		int num9 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num9, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Serialize(spanWriter, span, pressures, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.NC73D26B0A22898B482D1D636A3B9DC1BE8503690F02B934A2962E9EBCF6FD04E.Helpers.Serialize(spanWriter, span, pointGameTimes, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.N480BF96ED1B6EAB9862C8200E95EC1A9A2DCE9B493F4BE0E5CE4802F7A44BA75.Helpers.Serialize(spanWriter, span, points, num6, context);
		}
		if (num7 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, strokeId, num7, context, tableMetadata_e79197585bbc49528d3ff974c1de0978.StrokeId);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_92939a4a1e37462ebeddc6686c337749_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_92939a4a1e37462ebeddc6686c337749_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_92939a4a1e37462ebeddc6686c337749_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_92939a4a1e37462ebeddc6686c337749_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_92939a4a1e37462ebeddc6686c337749_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_92939a4a1e37462ebeddc6686c337749_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_92939a4a1e37462ebeddc6686c337749_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_92939a4a1e37462ebeddc6686c337749_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
