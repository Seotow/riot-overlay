using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E;
using FlatSharp.Compiler.Generated.N9FEEBA7C103BFD63B28D762AAAAD1261F91BD44B4E73C2C538FAC8C51339DFA8;
using FlatSharp.Compiler.Generated.NA75F0CAD5D5C5BE9BCC75D506E6DC1FC75A718AA088F117B5E413E48F9732140;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NECA310474EFE10AB83E0714327849C76F302474567AE823F7286B38542B22F71;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SceneSnapshot")]
	internal sealed class tableReader_b99c4d1b637e483f8ab1672e72f651e5_Lazy<TInputBuffer> : SceneSnapshot, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneSnapshot);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required SceneDescriptor Scene
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

		public override IList<EntitySnapshot>? Entities
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

		public override IList<ScriptAssetSnapshot>? Scripts
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_b99c4d1b637e483f8ab1672e72f651e5_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SceneDescriptor ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Scene.SceneSnapshot.Scene");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<EntitySnapshot>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9FEEBA7C103BFD63B28D762AAAAD1261F91BD44B4E73C2C538FAC8C51339DFA8.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_c31ae37052ac497fa0e5bffd32c226db.Entities);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ScriptAssetSnapshot>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA75F0CAD5D5C5BE9BCC75D506E6DC1FC75A718AA088F117B5E413E48F9732140.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_c31ae37052ac497fa0e5bffd32c226db.Scripts);
		}
	}

	[DebuggerDisplay("Progressive SceneSnapshot")]
	internal sealed class tableReader_b99c4d1b637e483f8ab1672e72f651e5_Progressive<TInputBuffer> : SceneSnapshot, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private SceneDescriptor __index0Value;

		private IList<EntitySnapshot>? __index1Value;

		private IList<ScriptAssetSnapshot>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneSnapshot);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required SceneDescriptor Scene
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

		public override IList<EntitySnapshot>? Entities
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

		public override IList<ScriptAssetSnapshot>? Scripts
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_b99c4d1b637e483f8ab1672e72f651e5_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable4.Create(buffer, offset, out __vtable);
			__index0Value = null;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SceneDescriptor ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Scene.SceneSnapshot.Scene");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<EntitySnapshot>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9FEEBA7C103BFD63B28D762AAAAD1261F91BD44B4E73C2C538FAC8C51339DFA8.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_c31ae37052ac497fa0e5bffd32c226db.Entities);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ScriptAssetSnapshot>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA75F0CAD5D5C5BE9BCC75D506E6DC1FC75A718AA088F117B5E413E48F9732140.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_c31ae37052ac497fa0e5bffd32c226db.Scripts);
		}
	}

	[DebuggerDisplay("Greedy SceneSnapshot")]
	internal sealed class tableReader_b99c4d1b637e483f8ab1672e72f651e5_Greedy<TInputBuffer> : SceneSnapshot, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private SceneDescriptor __index0Value;

		private IList<EntitySnapshot>? __index1Value;

		private IList<ScriptAssetSnapshot>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneSnapshot);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required SceneDescriptor Scene
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

		public override IList<EntitySnapshot>? Entities
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

		public override IList<ScriptAssetSnapshot>? Scripts
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
		public tableReader_b99c4d1b637e483f8ab1672e72f651e5_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SceneDescriptor ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Scene.SceneSnapshot.Scene");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<EntitySnapshot>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9FEEBA7C103BFD63B28D762AAAAD1261F91BD44B4E73C2C538FAC8C51339DFA8.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_c31ae37052ac497fa0e5bffd32c226db.Entities);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ScriptAssetSnapshot>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA75F0CAD5D5C5BE9BCC75D506E6DC1FC75A718AA088F117B5E413E48F9732140.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_c31ae37052ac497fa0e5bffd32c226db.Scripts);
		}
	}

	[DebuggerDisplay("GreedyMutable SceneSnapshot")]
	internal sealed class tableReader_b99c4d1b637e483f8ab1672e72f651e5_GreedyMutable<TInputBuffer> : SceneSnapshot, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private SceneDescriptor __index0Value;

		private IList<EntitySnapshot>? __index1Value;

		private IList<ScriptAssetSnapshot>? __index2Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneSnapshot);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required SceneDescriptor Scene
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

		public override IList<EntitySnapshot>? Entities
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

		public override IList<ScriptAssetSnapshot>? Scripts
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
		public tableReader_b99c4d1b637e483f8ab1672e72f651e5_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable4.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static SceneDescriptor ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Scene.SceneSnapshot.Scene");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<EntitySnapshot>? ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9FEEBA7C103BFD63B28D762AAAAD1261F91BD44B4E73C2C538FAC8C51339DFA8.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_c31ae37052ac497fa0e5bffd32c226db.Entities);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ScriptAssetSnapshot>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NA75F0CAD5D5C5BE9BCC75D506E6DC1FC75A718AA088F117B5E413E48F9732140.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_c31ae37052ac497fa0e5bffd32c226db.Scripts);
		}
	}

	private static class tableMetadata_c31ae37052ac497fa0e5bffd32c226db
	{
		public static readonly TableFieldContext Scene = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneSnapshot.Scene", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Entities = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneSnapshot.Entities", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Scripts = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneSnapshot.Scripts", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SceneSnapshot value)
	{
		int num = 39;
		SceneDescriptor scene = value.Scene;
		if (scene != null)
		{
			num += FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.GetMaxSize(scene);
		}
		IList<EntitySnapshot> entities = value.Entities;
		if (entities != null)
		{
			num += FlatSharp.Compiler.Generated.N9FEEBA7C103BFD63B28D762AAAAD1261F91BD44B4E73C2C538FAC8C51339DFA8.Helpers.GetMaxSize(entities);
		}
		IList<ScriptAssetSnapshot> scripts = value.Scripts;
		if (scripts != null)
		{
			num += FlatSharp.Compiler.Generated.NA75F0CAD5D5C5BE9BCC75D506E6DC1FC75A718AA088F117B5E413E48F9732140.Helpers.GetMaxSize(scripts);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SceneSnapshot value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(25, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 6;
		Span<byte> span2 = stackalloc byte[10];
		SceneDescriptor scene = value.Scene;
		IList<EntitySnapshot> entities = value.Entities;
		IList<ScriptAssetSnapshot> scripts = value.Scripts;
		int num4 = num;
		if (scripts != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 10;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 8);
		int num5 = num;
		if (entities != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 6);
		int num6 = num;
		if (scene != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Scene.SceneSnapshot.Scene");
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 4);
		int num7 = num2 - num;
		context.Offset -= 25 - num7;
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)num3, 0);
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num7, 2);
		int num8 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num8, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NA75F0CAD5D5C5BE9BCC75D506E6DC1FC75A718AA088F117B5E413E48F9732140.Helpers.Serialize(spanWriter, span, scripts, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N9FEEBA7C103BFD63B28D762AAAAD1261F91BD44B4E73C2C538FAC8C51339DFA8.Helpers.Serialize(spanWriter, span, entities, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.N0625BBC64A09D0866F782D02C4DAA3CFEAA98CFF2EFCD18F07EBD3ACB4D1240E.Helpers.Serialize(spanWriter, span, scene, num6, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b99c4d1b637e483f8ab1672e72f651e5_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_b99c4d1b637e483f8ab1672e72f651e5_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b99c4d1b637e483f8ab1672e72f651e5_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_b99c4d1b637e483f8ab1672e72f651e5_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b99c4d1b637e483f8ab1672e72f651e5_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_b99c4d1b637e483f8ab1672e72f651e5_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_b99c4d1b637e483f8ab1672e72f651e5_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_b99c4d1b637e483f8ab1672e72f651e5_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
