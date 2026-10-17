using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Scene;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.N31430A2ADE7CEC4DBFD9D2EE81800A56CAE638DA6A4731938ADA40A958B3C573;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.NADA1DAB95809967000C176D40CAE3666060B5B0125D683AAA1162C13D5785A83;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N04FB7D6A142D759287EBB1AE8B0EE2F74E4289DD6A6B520678DEDF23BC1327E6;

internal static class Helpers
{
	[DebuggerDisplay("Lazy SceneFile")]
	internal sealed class tableReader_2fef007920f34541a8a89a00bf71c3e7_Lazy<TInputBuffer> : SceneFile, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneFile);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required string Name
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

		public override bool IsActive
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

		public override IList<ScriptAsset>? ScriptLibrary
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

		public override IList<EntityRecord>? Entities
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
		public tableReader_2fef007920f34541a8a89a00bf71c3e7_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Scene.SceneFile.Name");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static IList<ScriptAsset>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NADA1DAB95809967000C176D40CAE3666060B5B0125D683AAA1162C13D5785A83.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_9cd95ace4d2a4b33b27cb45f0669ec80.ScriptLibrary);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<EntityRecord>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N31430A2ADE7CEC4DBFD9D2EE81800A56CAE638DA6A4731938ADA40A958B3C573.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_9cd95ace4d2a4b33b27cb45f0669ec80.Entities);
		}
	}

	[DebuggerDisplay("Progressive SceneFile")]
	internal sealed class tableReader_2fef007920f34541a8a89a00bf71c3e7_Progressive<TInputBuffer> : SceneFile, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable4 __vtable;

		private byte __mask0;

		private string __index0Value;

		private bool __index1Value;

		private IList<ScriptAsset>? __index2Value;

		private IList<EntityRecord>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneFile);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override required string Name
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

		public override bool IsActive
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

		public override IList<ScriptAsset>? ScriptLibrary
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

		public override IList<EntityRecord>? Entities
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
		public tableReader_2fef007920f34541a8a89a00bf71c3e7_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
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
		private static string ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Scene.SceneFile.Name");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static IList<ScriptAsset>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NADA1DAB95809967000C176D40CAE3666060B5B0125D683AAA1162C13D5785A83.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_9cd95ace4d2a4b33b27cb45f0669ec80.ScriptLibrary);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<EntityRecord>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N31430A2ADE7CEC4DBFD9D2EE81800A56CAE638DA6A4731938ADA40A958B3C573.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_9cd95ace4d2a4b33b27cb45f0669ec80.Entities);
		}
	}

	[DebuggerDisplay("Greedy SceneFile")]
	internal sealed class tableReader_2fef007920f34541a8a89a00bf71c3e7_Greedy<TInputBuffer> : SceneFile, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private string __index0Value;

		private bool __index1Value;

		private IList<ScriptAsset>? __index2Value;

		private IList<EntityRecord>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneFile);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required string Name
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

		public override bool IsActive
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

		public override IList<ScriptAsset>? ScriptLibrary
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

		public override IList<EntityRecord>? Entities
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
		public tableReader_2fef007920f34541a8a89a00bf71c3e7_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Scene.SceneFile.Name");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static IList<ScriptAsset>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NADA1DAB95809967000C176D40CAE3666060B5B0125D683AAA1162C13D5785A83.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_9cd95ace4d2a4b33b27cb45f0669ec80.ScriptLibrary);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<EntityRecord>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N31430A2ADE7CEC4DBFD9D2EE81800A56CAE638DA6A4731938ADA40A958B3C573.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_9cd95ace4d2a4b33b27cb45f0669ec80.Entities);
		}
	}

	[DebuggerDisplay("GreedyMutable SceneFile")]
	internal sealed class tableReader_2fef007920f34541a8a89a00bf71c3e7_GreedyMutable<TInputBuffer> : SceneFile, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private string __index0Value;

		private bool __index1Value;

		private IList<ScriptAsset>? __index2Value;

		private IList<EntityRecord>? __index3Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(SceneFile);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override required string Name
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

		public override bool IsActive
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

		public override IList<ScriptAsset>? ScriptLibrary
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

		public override IList<EntityRecord>? Entities
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
		public tableReader_2fef007920f34541a8a89a00bf71c3e7_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
				FSThrow.InvalidData_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Scene.SceneFile.Name");
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
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
		private static IList<ScriptAsset>? ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NADA1DAB95809967000C176D40CAE3666060B5B0125D683AAA1162C13D5785A83.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_9cd95ace4d2a4b33b27cb45f0669ec80.ScriptLibrary);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<EntityRecord>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N31430A2ADE7CEC4DBFD9D2EE81800A56CAE638DA6A4731938ADA40A958B3C573.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_9cd95ace4d2a4b33b27cb45f0669ec80.Entities);
		}
	}

	private static class tableMetadata_9cd95ace4d2a4b33b27cb45f0669ec80
	{
		public static readonly TableFieldContext Name = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneFile.Name", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext IsActive = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneFile.IsActive", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ScriptLibrary = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneFile.ScriptLibrary", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Entities = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Scene.SceneFile.Entities", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(SceneFile value)
	{
		int num = 42;
		string name = value.Name;
		if (name != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(name);
		}
		IList<ScriptAsset> scriptLibrary = value.ScriptLibrary;
		if (scriptLibrary != null)
		{
			num += FlatSharp.Compiler.Generated.NADA1DAB95809967000C176D40CAE3666060B5B0125D683AAA1162C13D5785A83.Helpers.GetMaxSize(scriptLibrary);
		}
		IList<EntityRecord> entities = value.Entities;
		if (entities != null)
		{
			num += FlatSharp.Compiler.Generated.N31430A2ADE7CEC4DBFD9D2EE81800A56CAE638DA6A4731938ADA40A958B3C573.Helpers.GetMaxSize(entities);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, SceneFile value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(26, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 6;
		Span<byte> span2 = stackalloc byte[12];
		string name = value.Name;
		bool isActive = value.IsActive;
		IList<ScriptAsset> scriptLibrary = value.ScriptLibrary;
		IList<EntityRecord> entities = value.Entities;
		int num4 = num;
		if (entities != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 12;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 10);
		int num5 = num;
		if (scriptLibrary != null)
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
		if (name != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
		}
		else
		{
			FSThrow.InvalidOperation_RequiredPropertyNotSet("BlueBottleIPC.LeagueBroadcast.Scene.SceneFile.Name");
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 4);
		int num7 = num;
		if (isActive)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num7 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, isActive, num7);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 6);
		int num8 = num2 - num;
		context.Offset -= 26 - num8;
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)num3, 0);
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)num8, 2);
		int num9 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num9, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N31430A2ADE7CEC4DBFD9D2EE81800A56CAE638DA6A4731938ADA40A958B3C573.Helpers.Serialize(spanWriter, span, entities, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.NADA1DAB95809967000C176D40CAE3666060B5B0125D683AAA1162C13D5785A83.Helpers.Serialize(spanWriter, span, scriptLibrary, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, name, num6, context, tableMetadata_9cd95ace4d2a4b33b27cb45f0669ec80.Name);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_2fef007920f34541a8a89a00bf71c3e7_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_2fef007920f34541a8a89a00bf71c3e7_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_2fef007920f34541a8a89a00bf71c3e7_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_2fef007920f34541a8a89a00bf71c3e7_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_2fef007920f34541a8a89a00bf71c3e7_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_2fef007920f34541a8a89a00bf71c3e7_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_2fef007920f34541a8a89a00bf71c3e7_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_2fef007920f34541a8a89a00bf71c3e7_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
