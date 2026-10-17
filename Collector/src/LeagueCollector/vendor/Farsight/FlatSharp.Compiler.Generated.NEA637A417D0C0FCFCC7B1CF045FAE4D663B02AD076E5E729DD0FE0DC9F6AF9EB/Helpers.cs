using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N2AA3AB3686E20CAA191DD297F6C82AA68B71CA63FE3505094AB6F9ECB8ED273D;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NEA637A417D0C0FCFCC7B1CF045FAE4D663B02AD076E5E729DD0FE0DC9F6AF9EB;

internal static class Helpers
{
	[DebuggerDisplay("Lazy ReplayFile")]
	internal sealed class tableReader_a54654c50ae94dbbaf36997af0205b03_Lazy<TInputBuffer> : ReplayFile, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ReplayFile);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<GameInfo>? Snapshots
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a54654c50ae94dbbaf36997af0205b03_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<GameInfo>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2AA3AB3686E20CAA191DD297F6C82AA68B71CA63FE3505094AB6F9ECB8ED273D.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_ff911aabc0d045fab56af734b563673f.Snapshots);
		}
	}

	[DebuggerDisplay("Progressive ReplayFile")]
	internal sealed class tableReader_a54654c50ae94dbbaf36997af0205b03_Progressive<TInputBuffer> : ReplayFile, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private IList<GameInfo>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ReplayFile);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<GameInfo>? Snapshots
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a54654c50ae94dbbaf36997af0205b03_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<GameInfo>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2AA3AB3686E20CAA191DD297F6C82AA68B71CA63FE3505094AB6F9ECB8ED273D.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_ff911aabc0d045fab56af734b563673f.Snapshots);
		}
	}

	[DebuggerDisplay("Greedy ReplayFile")]
	internal sealed class tableReader_a54654c50ae94dbbaf36997af0205b03_Greedy<TInputBuffer> : ReplayFile, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<GameInfo>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ReplayFile);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<GameInfo>? Snapshots
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a54654c50ae94dbbaf36997af0205b03_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<GameInfo>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2AA3AB3686E20CAA191DD297F6C82AA68B71CA63FE3505094AB6F9ECB8ED273D.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_ff911aabc0d045fab56af734b563673f.Snapshots);
		}
	}

	[DebuggerDisplay("GreedyMutable ReplayFile")]
	internal sealed class tableReader_a54654c50ae94dbbaf36997af0205b03_GreedyMutable<TInputBuffer> : ReplayFile, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<GameInfo>? __index0Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ReplayFile);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<GameInfo>? Snapshots
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a54654c50ae94dbbaf36997af0205b03_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<GameInfo>? ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2AA3AB3686E20CAA191DD297F6C82AA68B71CA63FE3505094AB6F9ECB8ED273D.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_ff911aabc0d045fab56af734b563673f.Snapshots);
		}
	}

	private static class tableMetadata_ff911aabc0d045fab56af734b563673f
	{
		public static readonly TableFieldContext Snapshots = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.ReplayFile.Snapshots", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(ReplayFile value)
	{
		int num = 21;
		IList<GameInfo> snapshots = value.Snapshots;
		if (snapshots != null)
		{
			num += FlatSharp.Compiler.Generated.N2AA3AB3686E20CAA191DD297F6C82AA68B71CA63FE3505094AB6F9ECB8ED273D.Helpers.GetMaxSize(snapshots);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, ReplayFile value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(11, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[6];
		IList<GameInfo> snapshots = value.Snapshots;
		int num4 = num;
		if (snapshots != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 6;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 4);
		int num5 = num2 - num;
		context.Offset -= 11 - num5;
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)num3, 0);
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)num5, 2);
		int num6 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num6, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N2AA3AB3686E20CAA191DD297F6C82AA68B71CA63FE3505094AB6F9ECB8ED273D.Helpers.Serialize(spanWriter, span, snapshots, num4, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a54654c50ae94dbbaf36997af0205b03_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a54654c50ae94dbbaf36997af0205b03_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a54654c50ae94dbbaf36997af0205b03_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a54654c50ae94dbbaf36997af0205b03_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a54654c50ae94dbbaf36997af0205b03_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a54654c50ae94dbbaf36997af0205b03_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a54654c50ae94dbbaf36997af0205b03_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a54654c50ae94dbbaf36997af0205b03_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
