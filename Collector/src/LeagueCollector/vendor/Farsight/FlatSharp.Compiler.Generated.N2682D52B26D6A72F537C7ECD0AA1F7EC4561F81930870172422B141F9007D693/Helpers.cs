using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Common;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.N58830D9707848C98BDACB1247AB8415FB9A6809E3518960277DFB64757D9A05C;
using FlatSharp.Compiler.Generated.N5F66A1194756F852F9BC4323EDB5E7AB483E52B3318934AB13C9AF4442DACB07;
using FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.N76D810C3A6028A465C325E7922410CAE2D568BDD5AFF725184FECEBF4A3E530A;
using FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562;
using FlatSharp.Compiler.Generated.NC0C3F51A01FAD113C228014DB183CF84D970F82532900DE344FACCD8FFD99C01;
using FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N2682D52B26D6A72F537C7ECD0AA1F7EC4561F81930870172422B141F9007D693;

internal static class Helpers
{
	[DebuggerDisplay("Lazy ScriptVariableValue")]
	internal sealed class tableReader_ba045bda899340f5b2e8dafc0a531711_Lazy<TInputBuffer> : ScriptVariableValue, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ScriptVariableValue);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override ScriptVariableValueType Type
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

		public override bool BoolValue
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

		public override long IntValue
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

		public override ulong UintValue
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

		public override double NumberValue
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

		public override string? StringValue
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

		public override Vector3? Vec3Value
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

		public override Vector4? ColorValue
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

		public override ScriptVariableValueType ArrayElementType
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

		public override IList<ScriptVariableValue>? ArrayValues
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_ba045bda899340f5b2e8dafc0a531711_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ScriptVariableValueType ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return ScriptVariableValueType.None;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static long ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0L;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N58830D9707848C98BDACB1247AB8415FB9A6809E3518960277DFB64757D9A05C.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0.0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5F66A1194756F852F9BC4323EDB5E7AB483E52B3318934AB13C9AF4442DACB07.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector4? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N76D810C3A6028A465C325E7922410CAE2D568BDD5AFF725184FECEBF4A3E530A.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ScriptVariableValueType ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return ScriptVariableValueType.None;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ScriptVariableValue>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC0C3F51A01FAD113C228014DB183CF84D970F82532900DE344FACCD8FFD99C01.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_3f1d4f0355f54d10b29ef8d471e7eed5.ArrayValues);
		}
	}

	[DebuggerDisplay("Progressive ScriptVariableValue")]
	internal sealed class tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer> : ScriptVariableValue, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private ScriptVariableValueType __index0Value;

		private bool __index1Value;

		private long __index2Value;

		private ulong __index3Value;

		private double __index4Value;

		private string? __index5Value;

		private Vector3? __index6Value;

		private Vector4? __index7Value;

		private byte __mask1;

		private ScriptVariableValueType __index8Value;

		private IList<ScriptVariableValue>? __index9Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ScriptVariableValue);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override ScriptVariableValueType Type
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

		public override bool BoolValue
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

		public override long IntValue
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

		public override ulong UintValue
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

		public override double NumberValue
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

		public override string? StringValue
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

		public override Vector3? Vec3Value
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

		public override Vector4? ColorValue
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

		public override ScriptVariableValueType ArrayElementType
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

		public override IList<ScriptVariableValue>? ArrayValues
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ScriptVariableValueType ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return ScriptVariableValueType.None;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static long ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0L;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N58830D9707848C98BDACB1247AB8415FB9A6809E3518960277DFB64757D9A05C.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0.0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5F66A1194756F852F9BC4323EDB5E7AB483E52B3318934AB13C9AF4442DACB07.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector4? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N76D810C3A6028A465C325E7922410CAE2D568BDD5AFF725184FECEBF4A3E530A.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ScriptVariableValueType ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return ScriptVariableValueType.None;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ScriptVariableValue>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC0C3F51A01FAD113C228014DB183CF84D970F82532900DE344FACCD8FFD99C01.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_3f1d4f0355f54d10b29ef8d471e7eed5.ArrayValues);
		}
	}

	[DebuggerDisplay("Greedy ScriptVariableValue")]
	internal sealed class tableReader_ba045bda899340f5b2e8dafc0a531711_Greedy<TInputBuffer> : ScriptVariableValue, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private ScriptVariableValueType __index0Value;

		private bool __index1Value;

		private long __index2Value;

		private ulong __index3Value;

		private double __index4Value;

		private string? __index5Value;

		private Vector3? __index6Value;

		private Vector4? __index7Value;

		private ScriptVariableValueType __index8Value;

		private IList<ScriptVariableValue>? __index9Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ScriptVariableValue);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override ScriptVariableValueType Type
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

		public override bool BoolValue
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

		public override long IntValue
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

		public override ulong UintValue
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

		public override double NumberValue
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

		public override string? StringValue
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

		public override Vector3? Vec3Value
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

		public override Vector4? ColorValue
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

		public override ScriptVariableValueType ArrayElementType
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

		public override IList<ScriptVariableValue>? ArrayValues
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_ba045bda899340f5b2e8dafc0a531711_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ScriptVariableValueType ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return ScriptVariableValueType.None;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static long ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0L;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N58830D9707848C98BDACB1247AB8415FB9A6809E3518960277DFB64757D9A05C.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0.0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5F66A1194756F852F9BC4323EDB5E7AB483E52B3318934AB13C9AF4442DACB07.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector4? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N76D810C3A6028A465C325E7922410CAE2D568BDD5AFF725184FECEBF4A3E530A.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ScriptVariableValueType ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return ScriptVariableValueType.None;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ScriptVariableValue>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC0C3F51A01FAD113C228014DB183CF84D970F82532900DE344FACCD8FFD99C01.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_3f1d4f0355f54d10b29ef8d471e7eed5.ArrayValues);
		}
	}

	[DebuggerDisplay("GreedyMutable ScriptVariableValue")]
	internal sealed class tableReader_ba045bda899340f5b2e8dafc0a531711_GreedyMutable<TInputBuffer> : ScriptVariableValue, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private ScriptVariableValueType __index0Value;

		private bool __index1Value;

		private long __index2Value;

		private ulong __index3Value;

		private double __index4Value;

		private string? __index5Value;

		private Vector3? __index6Value;

		private Vector4? __index7Value;

		private ScriptVariableValueType __index8Value;

		private IList<ScriptVariableValue>? __index9Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(ScriptVariableValue);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override ScriptVariableValueType Type
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

		public override bool BoolValue
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

		public override long IntValue
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

		public override ulong UintValue
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

		public override double NumberValue
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

		public override string? StringValue
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

		public override Vector3? Vec3Value
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

		public override Vector4? ColorValue
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

		public override ScriptVariableValueType ArrayElementType
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

		public override IList<ScriptVariableValue>? ArrayValues
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_ba045bda899340f5b2e8dafc0a531711_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ScriptVariableValueType ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return ScriptVariableValueType.None;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562.Helpers.Parse(buffer, offset2, remainingDepth);
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
		private static long ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0L;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N58830D9707848C98BDACB1247AB8415FB9A6809E3518960277DFB64757D9A05C.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static double ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return 0.0;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector3? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5F66A1194756F852F9BC4323EDB5E7AB483E52B3318934AB13C9AF4442DACB07.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Vector4? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N76D810C3A6028A465C325E7922410CAE2D568BDD5AFF725184FECEBF4A3E530A.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ScriptVariableValueType ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return ScriptVariableValueType.None;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ScriptVariableValue>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC0C3F51A01FAD113C228014DB183CF84D970F82532900DE344FACCD8FFD99C01.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_3f1d4f0355f54d10b29ef8d471e7eed5.ArrayValues);
		}
	}

	private static class tableMetadata_3f1d4f0355f54d10b29ef8d471e7eed5
	{
		public static readonly TableFieldContext Type = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue.Type", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BoolValue = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue.BoolValue", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext IntValue = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue.IntValue", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext UintValue = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue.UintValue", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext NumberValue = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue.NumberValue", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext StringValue = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue.StringValue", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Vec3Value = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue.Vec3Value", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ColorValue = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue.ColorValue", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ArrayElementType = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue.ArrayElementType", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ArrayValues = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Common.ScriptVariableValue.ArrayValues", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(ScriptVariableValue value)
	{
		int num = 128;
		string stringValue = value.StringValue;
		if (stringValue != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(stringValue);
		}
		IList<ScriptVariableValue> arrayValues = value.ArrayValues;
		if (arrayValues != null)
		{
			num += FlatSharp.Compiler.Generated.NC0C3F51A01FAD113C228014DB183CF84D970F82532900DE344FACCD8FFD99C01.Helpers.GetMaxSize(arrayValues);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, ScriptVariableValue value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(100, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[24];
		ScriptVariableValueType type = value.Type;
		bool boolValue = value.BoolValue;
		long intValue = value.IntValue;
		ulong uintValue = value.UintValue;
		double numberValue = value.NumberValue;
		string stringValue = value.StringValue;
		Vector3? vec3Value = value.Vec3Value;
		Vector4? colorValue = value.ColorValue;
		ScriptVariableValueType arrayElementType = value.ArrayElementType;
		IList<ScriptVariableValue> arrayValues = value.ArrayValues;
		int num4 = num;
		if (numberValue != 0.0)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 8);
			num4 = num2;
			num2 += 8;
			FlatSharp.Compiler.Generated.N69778B0A505EF22DDC87C3C5ACB43FEC37AE9060433697AE39F2F466540F7A19.Helpers.Serialize(spanWriter, span, numberValue, num4);
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 12);
		int num5 = num;
		if (uintValue != 0L)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 8);
			num5 = num2;
			num2 += 8;
			FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Serialize(spanWriter, span, uintValue, num5);
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 10);
		int num6 = num;
		if (intValue != 0L)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 8);
			num6 = num2;
			num2 += 8;
			FlatSharp.Compiler.Generated.N58830D9707848C98BDACB1247AB8415FB9A6809E3518960277DFB64757D9A05C.Helpers.Serialize(spanWriter, span, intValue, num6);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 8);
		int num7 = num;
		if (arrayValues != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			num3 = 24;
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 22);
		int num8 = num;
		if (stringValue != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 14);
		int num9 = num;
		if (vec3Value.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 12;
			FlatSharp.Compiler.Generated.N5F66A1194756F852F9BC4323EDB5E7AB483E52B3318934AB13C9AF4442DACB07.Helpers.Serialize(spanWriter, span, vec3Value, num9);
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 16);
		int num10 = num;
		if (colorValue.HasValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 16;
			FlatSharp.Compiler.Generated.N76D810C3A6028A465C325E7922410CAE2D568BDD5AFF725184FECEBF4A3E530A.Helpers.Serialize(spanWriter, span, colorValue, num10);
			if (20 > num3)
			{
				num3 = 20;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 18);
		int num11 = num;
		if (arrayElementType != ScriptVariableValueType.None)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num11 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562.Helpers.Serialize(spanWriter, span, arrayElementType, num11);
			if (22 > num3)
			{
				num3 = 22;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 20);
		int num12 = num;
		if (boolValue)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num12 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, boolValue, num12);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 6);
		int num13 = num;
		if (type != ScriptVariableValueType.None)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num13 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N7C8FD57AA391F6C55EB063378F2F396F413DBC44A55FFC4EB5AF1C3DE3C66562.Helpers.Serialize(spanWriter, span, type, num13);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)(num13 - num), 4);
		int num14 = num2 - num;
		context.Offset -= 100 - num14;
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)num3, 0);
		Span<byte> span14 = span2;
		spanWriter.WriteUShort(span14, (ushort)num14, 2);
		int num15 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num15, num);
		if (num7 != num)
		{
			FlatSharp.Compiler.Generated.NC0C3F51A01FAD113C228014DB183CF84D970F82532900DE344FACCD8FFD99C01.Helpers.Serialize(spanWriter, span, arrayValues, num7, context);
		}
		if (num8 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, stringValue, num8, context, tableMetadata_3f1d4f0355f54d10b29ef8d471e7eed5.StringValue);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_ba045bda899340f5b2e8dafc0a531711_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_ba045bda899340f5b2e8dafc0a531711_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_ba045bda899340f5b2e8dafc0a531711_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_ba045bda899340f5b2e8dafc0a531711_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_ba045bda899340f5b2e8dafc0a531711_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_ba045bda899340f5b2e8dafc0a531711_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		remainingDepth--;
		SerializationHelpers.EnsureDepthLimit(remainingDepth);
		return new tableReader_ba045bda899340f5b2e8dafc0a531711_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
