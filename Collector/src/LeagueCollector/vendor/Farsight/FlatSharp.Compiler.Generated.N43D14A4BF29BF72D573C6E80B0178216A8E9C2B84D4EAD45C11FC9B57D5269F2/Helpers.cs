using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NCEC2F0D05AF9395C0164E24CE39F678726CFF591F05937761313B185A9B82299;
using FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N43D14A4BF29BF72D573C6E80B0178216A8E9C2B84D4EAD45C11FC9B57D5269F2;

internal static class Helpers
{
	[DebuggerDisplay("Lazy Xform")]
	internal sealed class structReader_d0338497dcb04ac994e54a0ea4a4b509_Lazy<TInputBuffer> : Xform, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Xform);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override Vector3 Position
		{
			get
			{
				return ReadIndex0Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override Vector3 Scale
		{
			get
			{
				return ReadIndex1Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override Vector4 Rotation
		{
			get
			{
				return ReadIndex2Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_d0338497dcb04ac994e54a0ea4a4b509_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3 ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3 ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset + 12, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector4 ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NCEC2F0D05AF9395C0164E24CE39F678726CFF591F05937761313B185A9B82299.Helpers.Parse(buffer, offset + 24, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive Xform")]
	internal sealed class structReader_d0338497dcb04ac994e54a0ea4a4b509_Progressive<TInputBuffer> : Xform, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private byte __mask0;

		private Vector3 __index0Value;

		private Vector3 __index1Value;

		private Vector4 __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Xform);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override Vector3 Position
		{
			get
			{
				if ((__mask0 & 1) == 0)
				{
					__index0Value = ReadIndex0Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 1);
				}
				return __index0Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override Vector3 Scale
		{
			get
			{
				if ((__mask0 & 2) == 0)
				{
					__index1Value = ReadIndex1Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 2);
				}
				return __index1Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override Vector4 Rotation
		{
			get
			{
				if ((__mask0 & 4) == 0)
				{
					__index2Value = ReadIndex2Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 4);
				}
				return __index2Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_d0338497dcb04ac994e54a0ea4a4b509_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3 ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3 ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset + 12, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector4 ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NCEC2F0D05AF9395C0164E24CE39F678726CFF591F05937761313B185A9B82299.Helpers.Parse(buffer, offset + 24, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy Xform")]
	internal sealed class structReader_d0338497dcb04ac994e54a0ea4a4b509_Greedy<TInputBuffer> : Xform, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private Vector3 __index0Value;

		private Vector3 __index1Value;

		private Vector4 __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Xform);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override Vector3 Position
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

		public override Vector3 Scale
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

		public override Vector4 Rotation
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_d0338497dcb04ac994e54a0ea4a4b509_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__index0Value = ReadIndex0Value(buffer, offset, default, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, default, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, default, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3 ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3 ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset + 12, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector4 ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NCEC2F0D05AF9395C0164E24CE39F678726CFF591F05937761313B185A9B82299.Helpers.Parse(buffer, offset + 24, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable Xform")]
	internal sealed class structReader_d0338497dcb04ac994e54a0ea4a4b509_GreedyMutable<TInputBuffer> : Xform, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private Vector3 __index0Value;

		private Vector3 __index1Value;

		private Vector4 __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Xform);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override Vector3 Position
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

		public override Vector3 Scale
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

		public override Vector4 Rotation
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_d0338497dcb04ac994e54a0ea4a4b509_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__index0Value = ReadIndex0Value(buffer, offset, default, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, default, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, default, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3 ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3 ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Parse(buffer, offset + 12, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector4 ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NCEC2F0D05AF9395C0164E24CE39F678726CFF591F05937761313B185A9B82299.Helpers.Parse(buffer, offset + 24, remainingDepth);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(Xform value)
	{
		return 43;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Xform value, int offset) where TSpanWriter : ISpanWriter
	{
		Span<byte> span2 = span.Slice(offset, 40);
		if (value == null)
		{
			span2.Clear();
			return;
		}
		FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Serialize(spanWriter, span2, value.Position, 0);
		FlatSharp.Compiler.Generated.NFF70312A85F3FF4CF405F39CEE8F59B3D4ABEE9FB59DF8413E03A4DAB0607BEA.Helpers.Serialize(spanWriter, span2, value.Scale, 12);
		FlatSharp.Compiler.Generated.NCEC2F0D05AF9395C0164E24CE39F678726CFF591F05937761313B185A9B82299.Helpers.Serialize(spanWriter, span2, value.Rotation, 24);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_d0338497dcb04ac994e54a0ea4a4b509_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_d0338497dcb04ac994e54a0ea4a4b509_Lazy<TInputBuffer>(buffer, offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_d0338497dcb04ac994e54a0ea4a4b509_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_d0338497dcb04ac994e54a0ea4a4b509_Progressive<TInputBuffer>(buffer, offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_d0338497dcb04ac994e54a0ea4a4b509_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_d0338497dcb04ac994e54a0ea4a4b509_Greedy<TInputBuffer>(buffer, offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_d0338497dcb04ac994e54a0ea4a4b509_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_d0338497dcb04ac994e54a0ea4a4b509_GreedyMutable<TInputBuffer>(buffer, offset, remainingDepth);
	}
}
