using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N21635D30AF8E8544595A02CD69F1DD933DF334B37B39975221F688FDA908768F;

internal static class Helpers
{
	[DebuggerDisplay("Lazy NotificationEvent")]
	internal sealed class structReader_d688d80425bf427ca52f0dc7b73722d9_Lazy<TInputBuffer> : NotificationEvent, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(NotificationEvent);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override float GameTime
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

		protected override byte __flatsharp__Type_0
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

		protected override byte __flatsharp__Type_1
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

		protected override byte __flatsharp__Type_2
		{
			get
			{
				return ReadIndex3Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_3
		{
			get
			{
				return ReadIndex4Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_4
		{
			get
			{
				return ReadIndex5Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_5
		{
			get
			{
				return ReadIndex6Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_6
		{
			get
			{
				return ReadIndex7Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_7
		{
			get
			{
				return ReadIndex8Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_8
		{
			get
			{
				return ReadIndex9Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_9
		{
			get
			{
				return ReadIndex10Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_10
		{
			get
			{
				return ReadIndex11Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_11
		{
			get
			{
				return ReadIndex12Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_12
		{
			get
			{
				return ReadIndex13Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_13
		{
			get
			{
				return ReadIndex14Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_14
		{
			get
			{
				return ReadIndex15Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_15
		{
			get
			{
				return ReadIndex16Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_16
		{
			get
			{
				return ReadIndex17Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_17
		{
			get
			{
				return ReadIndex18Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_18
		{
			get
			{
				return ReadIndex19Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_19
		{
			get
			{
				return ReadIndex20Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_20
		{
			get
			{
				return ReadIndex21Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_21
		{
			get
			{
				return ReadIndex22Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_22
		{
			get
			{
				return ReadIndex23Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_23
		{
			get
			{
				return ReadIndex24Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_24
		{
			get
			{
				return ReadIndex25Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_25
		{
			get
			{
				return ReadIndex26Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_26
		{
			get
			{
				return ReadIndex27Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_27
		{
			get
			{
				return ReadIndex28Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_28
		{
			get
			{
				return ReadIndex29Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_29
		{
			get
			{
				return ReadIndex30Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_30
		{
			get
			{
				return ReadIndex31Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_31
		{
			get
			{
				return ReadIndex32Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_32
		{
			get
			{
				return ReadIndex33Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_33
		{
			get
			{
				return ReadIndex34Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_34
		{
			get
			{
				return ReadIndex35Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_35
		{
			get
			{
				return ReadIndex36Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_36
		{
			get
			{
				return ReadIndex37Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_37
		{
			get
			{
				return ReadIndex38Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_38
		{
			get
			{
				return ReadIndex39Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_39
		{
			get
			{
				return ReadIndex40Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_40
		{
			get
			{
				return ReadIndex41Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_41
		{
			get
			{
				return ReadIndex42Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_42
		{
			get
			{
				return ReadIndex43Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_43
		{
			get
			{
				return ReadIndex44Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_44
		{
			get
			{
				return ReadIndex45Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_45
		{
			get
			{
				return ReadIndex46Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_46
		{
			get
			{
				return ReadIndex47Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_47
		{
			get
			{
				return ReadIndex48Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_48
		{
			get
			{
				return ReadIndex49Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_49
		{
			get
			{
				return ReadIndex50Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_50
		{
			get
			{
				return ReadIndex51Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_51
		{
			get
			{
				return ReadIndex52Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_52
		{
			get
			{
				return ReadIndex53Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_53
		{
			get
			{
				return ReadIndex54Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_54
		{
			get
			{
				return ReadIndex55Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_55
		{
			get
			{
				return ReadIndex56Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_56
		{
			get
			{
				return ReadIndex57Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_57
		{
			get
			{
				return ReadIndex58Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_58
		{
			get
			{
				return ReadIndex59Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_59
		{
			get
			{
				return ReadIndex60Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_60
		{
			get
			{
				return ReadIndex61Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_61
		{
			get
			{
				return ReadIndex62Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_62
		{
			get
			{
				return ReadIndex63Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_63
		{
			get
			{
				return ReadIndex64Value(__buffer, __offset, default, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_d688d80425bf427ca52f0dc7b73722d9_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 4, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 5, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 6, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex4Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 7, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex5Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 8, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex6Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 9, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex7Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 10, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex8Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 11, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex9Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 12, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex10Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 13, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex11Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 14, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex12Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 15, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex13Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 16, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex14Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 17, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex15Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 18, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex16Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 19, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex17Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 20, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex18Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 21, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex19Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 22, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex20Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 23, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex21Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 24, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex22Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 25, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex23Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 26, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex24Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 27, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex25Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 28, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex26Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 29, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex27Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 30, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex28Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 31, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex29Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 32, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex30Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 33, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex31Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 34, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex32Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 35, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex33Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 36, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex34Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 37, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex35Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 38, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex36Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 39, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex37Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 40, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex38Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 41, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex39Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 42, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex40Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 43, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex41Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 44, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex42Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 45, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex43Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 46, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex44Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 47, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex45Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 48, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex46Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 49, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex47Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 50, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex48Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 51, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex49Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 52, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex50Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 53, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex51Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 54, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex52Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 55, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex53Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 56, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex54Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 57, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex55Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 58, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex56Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 59, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex57Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 60, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex58Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 61, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex59Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 62, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex60Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 63, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex61Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 64, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex62Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 65, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex63Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 66, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex64Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 67, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive NotificationEvent")]
	internal sealed class structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer> : NotificationEvent, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private byte __mask0;

		private float __index0Value;

		private byte __index1Value;

		private byte __index2Value;

		private byte __index3Value;

		private byte __index4Value;

		private byte __index5Value;

		private byte __index6Value;

		private byte __index7Value;

		private byte __mask1;

		private byte __index8Value;

		private byte __index9Value;

		private byte __index10Value;

		private byte __index11Value;

		private byte __index12Value;

		private byte __index13Value;

		private byte __index14Value;

		private byte __index15Value;

		private byte __mask2;

		private byte __index16Value;

		private byte __index17Value;

		private byte __index18Value;

		private byte __index19Value;

		private byte __index20Value;

		private byte __index21Value;

		private byte __index22Value;

		private byte __index23Value;

		private byte __mask3;

		private byte __index24Value;

		private byte __index25Value;

		private byte __index26Value;

		private byte __index27Value;

		private byte __index28Value;

		private byte __index29Value;

		private byte __index30Value;

		private byte __index31Value;

		private byte __mask4;

		private byte __index32Value;

		private byte __index33Value;

		private byte __index34Value;

		private byte __index35Value;

		private byte __index36Value;

		private byte __index37Value;

		private byte __index38Value;

		private byte __index39Value;

		private byte __mask5;

		private byte __index40Value;

		private byte __index41Value;

		private byte __index42Value;

		private byte __index43Value;

		private byte __index44Value;

		private byte __index45Value;

		private byte __index46Value;

		private byte __index47Value;

		private byte __mask6;

		private byte __index48Value;

		private byte __index49Value;

		private byte __index50Value;

		private byte __index51Value;

		private byte __index52Value;

		private byte __index53Value;

		private byte __index54Value;

		private byte __index55Value;

		private byte __mask7;

		private byte __index56Value;

		private byte __index57Value;

		private byte __index58Value;

		private byte __index59Value;

		private byte __index60Value;

		private byte __index61Value;

		private byte __index62Value;

		private byte __index63Value;

		private byte __mask8;

		private byte __index64Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(NotificationEvent);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override float GameTime
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

		protected override byte __flatsharp__Type_0
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

		protected override byte __flatsharp__Type_1
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

		protected override byte __flatsharp__Type_2
		{
			get
			{
				if ((__mask0 & 8) == 0)
				{
					__index3Value = ReadIndex3Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 8);
				}
				return __index3Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_3
		{
			get
			{
				if ((__mask0 & 0x10) == 0)
				{
					__index4Value = ReadIndex4Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 16);
				}
				return __index4Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_4
		{
			get
			{
				if ((__mask0 & 0x20) == 0)
				{
					__index5Value = ReadIndex5Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 32);
				}
				return __index5Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_5
		{
			get
			{
				if ((__mask0 & 0x40) == 0)
				{
					__index6Value = ReadIndex6Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 64);
				}
				return __index6Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_6
		{
			get
			{
				if ((__mask0 & 0x80) == 0)
				{
					__index7Value = ReadIndex7Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask0, 128);
				}
				return __index7Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_7
		{
			get
			{
				if ((__mask1 & 1) == 0)
				{
					__index8Value = ReadIndex8Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 1);
				}
				return __index8Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_8
		{
			get
			{
				if ((__mask1 & 2) == 0)
				{
					__index9Value = ReadIndex9Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 2);
				}
				return __index9Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_9
		{
			get
			{
				if ((__mask1 & 4) == 0)
				{
					__index10Value = ReadIndex10Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 4);
				}
				return __index10Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_10
		{
			get
			{
				if ((__mask1 & 8) == 0)
				{
					__index11Value = ReadIndex11Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 8);
				}
				return __index11Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_11
		{
			get
			{
				if ((__mask1 & 0x10) == 0)
				{
					__index12Value = ReadIndex12Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 16);
				}
				return __index12Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_12
		{
			get
			{
				if ((__mask1 & 0x20) == 0)
				{
					__index13Value = ReadIndex13Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 32);
				}
				return __index13Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_13
		{
			get
			{
				if ((__mask1 & 0x40) == 0)
				{
					__index14Value = ReadIndex14Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 64);
				}
				return __index14Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_14
		{
			get
			{
				if ((__mask1 & 0x80) == 0)
				{
					__index15Value = ReadIndex15Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 128);
				}
				return __index15Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_15
		{
			get
			{
				if ((__mask2 & 1) == 0)
				{
					__index16Value = ReadIndex16Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 1);
				}
				return __index16Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_16
		{
			get
			{
				if ((__mask2 & 2) == 0)
				{
					__index17Value = ReadIndex17Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 2);
				}
				return __index17Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_17
		{
			get
			{
				if ((__mask2 & 4) == 0)
				{
					__index18Value = ReadIndex18Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 4);
				}
				return __index18Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_18
		{
			get
			{
				if ((__mask2 & 8) == 0)
				{
					__index19Value = ReadIndex19Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 8);
				}
				return __index19Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_19
		{
			get
			{
				if ((__mask2 & 0x10) == 0)
				{
					__index20Value = ReadIndex20Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 16);
				}
				return __index20Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_20
		{
			get
			{
				if ((__mask2 & 0x20) == 0)
				{
					__index21Value = ReadIndex21Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 32);
				}
				return __index21Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_21
		{
			get
			{
				if ((__mask2 & 0x40) == 0)
				{
					__index22Value = ReadIndex22Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 64);
				}
				return __index22Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_22
		{
			get
			{
				if ((__mask2 & 0x80) == 0)
				{
					__index23Value = ReadIndex23Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask2, 128);
				}
				return __index23Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_23
		{
			get
			{
				if ((__mask3 & 1) == 0)
				{
					__index24Value = ReadIndex24Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 1);
				}
				return __index24Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_24
		{
			get
			{
				if ((__mask3 & 2) == 0)
				{
					__index25Value = ReadIndex25Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 2);
				}
				return __index25Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_25
		{
			get
			{
				if ((__mask3 & 4) == 0)
				{
					__index26Value = ReadIndex26Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 4);
				}
				return __index26Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_26
		{
			get
			{
				if ((__mask3 & 8) == 0)
				{
					__index27Value = ReadIndex27Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 8);
				}
				return __index27Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_27
		{
			get
			{
				if ((__mask3 & 0x10) == 0)
				{
					__index28Value = ReadIndex28Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 16);
				}
				return __index28Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_28
		{
			get
			{
				if ((__mask3 & 0x20) == 0)
				{
					__index29Value = ReadIndex29Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 32);
				}
				return __index29Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_29
		{
			get
			{
				if ((__mask3 & 0x40) == 0)
				{
					__index30Value = ReadIndex30Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 64);
				}
				return __index30Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_30
		{
			get
			{
				if ((__mask3 & 0x80) == 0)
				{
					__index31Value = ReadIndex31Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask3, 128);
				}
				return __index31Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_31
		{
			get
			{
				if ((__mask4 & 1) == 0)
				{
					__index32Value = ReadIndex32Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 1);
				}
				return __index32Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_32
		{
			get
			{
				if ((__mask4 & 2) == 0)
				{
					__index33Value = ReadIndex33Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 2);
				}
				return __index33Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_33
		{
			get
			{
				if ((__mask4 & 4) == 0)
				{
					__index34Value = ReadIndex34Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 4);
				}
				return __index34Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_34
		{
			get
			{
				if ((__mask4 & 8) == 0)
				{
					__index35Value = ReadIndex35Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 8);
				}
				return __index35Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_35
		{
			get
			{
				if ((__mask4 & 0x10) == 0)
				{
					__index36Value = ReadIndex36Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 16);
				}
				return __index36Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_36
		{
			get
			{
				if ((__mask4 & 0x20) == 0)
				{
					__index37Value = ReadIndex37Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 32);
				}
				return __index37Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_37
		{
			get
			{
				if ((__mask4 & 0x40) == 0)
				{
					__index38Value = ReadIndex38Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 64);
				}
				return __index38Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_38
		{
			get
			{
				if ((__mask4 & 0x80) == 0)
				{
					__index39Value = ReadIndex39Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask4, 128);
				}
				return __index39Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_39
		{
			get
			{
				if ((__mask5 & 1) == 0)
				{
					__index40Value = ReadIndex40Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 1);
				}
				return __index40Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_40
		{
			get
			{
				if ((__mask5 & 2) == 0)
				{
					__index41Value = ReadIndex41Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 2);
				}
				return __index41Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_41
		{
			get
			{
				if ((__mask5 & 4) == 0)
				{
					__index42Value = ReadIndex42Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 4);
				}
				return __index42Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_42
		{
			get
			{
				if ((__mask5 & 8) == 0)
				{
					__index43Value = ReadIndex43Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 8);
				}
				return __index43Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_43
		{
			get
			{
				if ((__mask5 & 0x10) == 0)
				{
					__index44Value = ReadIndex44Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 16);
				}
				return __index44Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_44
		{
			get
			{
				if ((__mask5 & 0x20) == 0)
				{
					__index45Value = ReadIndex45Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 32);
				}
				return __index45Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_45
		{
			get
			{
				if ((__mask5 & 0x40) == 0)
				{
					__index46Value = ReadIndex46Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 64);
				}
				return __index46Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_46
		{
			get
			{
				if ((__mask5 & 0x80) == 0)
				{
					__index47Value = ReadIndex47Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask5, 128);
				}
				return __index47Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_47
		{
			get
			{
				if ((__mask6 & 1) == 0)
				{
					__index48Value = ReadIndex48Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask6, 1);
				}
				return __index48Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_48
		{
			get
			{
				if ((__mask6 & 2) == 0)
				{
					__index49Value = ReadIndex49Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask6, 2);
				}
				return __index49Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_49
		{
			get
			{
				if ((__mask6 & 4) == 0)
				{
					__index50Value = ReadIndex50Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask6, 4);
				}
				return __index50Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_50
		{
			get
			{
				if ((__mask6 & 8) == 0)
				{
					__index51Value = ReadIndex51Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask6, 8);
				}
				return __index51Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_51
		{
			get
			{
				if ((__mask6 & 0x10) == 0)
				{
					__index52Value = ReadIndex52Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask6, 16);
				}
				return __index52Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_52
		{
			get
			{
				if ((__mask6 & 0x20) == 0)
				{
					__index53Value = ReadIndex53Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask6, 32);
				}
				return __index53Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_53
		{
			get
			{
				if ((__mask6 & 0x40) == 0)
				{
					__index54Value = ReadIndex54Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask6, 64);
				}
				return __index54Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_54
		{
			get
			{
				if ((__mask6 & 0x80) == 0)
				{
					__index55Value = ReadIndex55Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask6, 128);
				}
				return __index55Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_55
		{
			get
			{
				if ((__mask7 & 1) == 0)
				{
					__index56Value = ReadIndex56Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask7, 1);
				}
				return __index56Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_56
		{
			get
			{
				if ((__mask7 & 2) == 0)
				{
					__index57Value = ReadIndex57Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask7, 2);
				}
				return __index57Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_57
		{
			get
			{
				if ((__mask7 & 4) == 0)
				{
					__index58Value = ReadIndex58Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask7, 4);
				}
				return __index58Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_58
		{
			get
			{
				if ((__mask7 & 8) == 0)
				{
					__index59Value = ReadIndex59Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask7, 8);
				}
				return __index59Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_59
		{
			get
			{
				if ((__mask7 & 0x10) == 0)
				{
					__index60Value = ReadIndex60Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask7, 16);
				}
				return __index60Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_60
		{
			get
			{
				if ((__mask7 & 0x20) == 0)
				{
					__index61Value = ReadIndex61Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask7, 32);
				}
				return __index61Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_61
		{
			get
			{
				if ((__mask7 & 0x40) == 0)
				{
					__index62Value = ReadIndex62Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask7, 64);
				}
				return __index62Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_62
		{
			get
			{
				if ((__mask7 & 0x80) == 0)
				{
					__index63Value = ReadIndex63Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask7, 128);
				}
				return __index63Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_63
		{
			get
			{
				if ((__mask8 & 1) == 0)
				{
					__index64Value = ReadIndex64Value(__buffer, __offset, default, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask8, 1);
				}
				return __index64Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 4, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 5, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 6, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex4Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 7, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex5Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 8, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex6Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 9, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex7Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 10, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex8Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 11, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex9Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 12, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex10Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 13, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex11Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 14, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex12Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 15, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex13Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 16, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex14Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 17, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex15Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 18, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex16Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 19, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex17Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 20, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex18Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 21, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex19Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 22, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex20Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 23, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex21Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 24, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex22Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 25, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex23Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 26, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex24Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 27, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex25Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 28, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex26Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 29, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex27Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 30, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex28Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 31, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex29Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 32, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex30Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 33, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex31Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 34, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex32Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 35, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex33Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 36, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex34Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 37, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex35Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 38, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex36Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 39, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex37Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 40, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex38Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 41, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex39Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 42, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex40Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 43, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex41Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 44, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex42Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 45, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex43Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 46, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex44Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 47, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex45Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 48, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex46Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 49, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex47Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 50, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex48Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 51, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex49Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 52, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex50Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 53, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex51Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 54, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex52Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 55, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex53Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 56, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex54Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 57, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex55Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 58, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex56Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 59, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex57Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 60, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex58Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 61, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex59Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 62, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex60Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 63, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex61Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 64, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex62Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 65, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex63Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 66, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex64Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 67, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy NotificationEvent")]
	internal sealed class structReader_d688d80425bf427ca52f0dc7b73722d9_Greedy<TInputBuffer> : NotificationEvent, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private float __index0Value;

		private byte __index1Value;

		private byte __index2Value;

		private byte __index3Value;

		private byte __index4Value;

		private byte __index5Value;

		private byte __index6Value;

		private byte __index7Value;

		private byte __index8Value;

		private byte __index9Value;

		private byte __index10Value;

		private byte __index11Value;

		private byte __index12Value;

		private byte __index13Value;

		private byte __index14Value;

		private byte __index15Value;

		private byte __index16Value;

		private byte __index17Value;

		private byte __index18Value;

		private byte __index19Value;

		private byte __index20Value;

		private byte __index21Value;

		private byte __index22Value;

		private byte __index23Value;

		private byte __index24Value;

		private byte __index25Value;

		private byte __index26Value;

		private byte __index27Value;

		private byte __index28Value;

		private byte __index29Value;

		private byte __index30Value;

		private byte __index31Value;

		private byte __index32Value;

		private byte __index33Value;

		private byte __index34Value;

		private byte __index35Value;

		private byte __index36Value;

		private byte __index37Value;

		private byte __index38Value;

		private byte __index39Value;

		private byte __index40Value;

		private byte __index41Value;

		private byte __index42Value;

		private byte __index43Value;

		private byte __index44Value;

		private byte __index45Value;

		private byte __index46Value;

		private byte __index47Value;

		private byte __index48Value;

		private byte __index49Value;

		private byte __index50Value;

		private byte __index51Value;

		private byte __index52Value;

		private byte __index53Value;

		private byte __index54Value;

		private byte __index55Value;

		private byte __index56Value;

		private byte __index57Value;

		private byte __index58Value;

		private byte __index59Value;

		private byte __index60Value;

		private byte __index61Value;

		private byte __index62Value;

		private byte __index63Value;

		private byte __index64Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(NotificationEvent);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override float GameTime
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

		protected override byte __flatsharp__Type_0
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

		protected override byte __flatsharp__Type_1
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

		protected override byte __flatsharp__Type_2
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

		protected override byte __flatsharp__Type_3
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

		protected override byte __flatsharp__Type_4
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

		protected override byte __flatsharp__Type_5
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

		protected override byte __flatsharp__Type_6
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

		protected override byte __flatsharp__Type_7
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

		protected override byte __flatsharp__Type_8
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

		protected override byte __flatsharp__Type_9
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

		protected override byte __flatsharp__Type_10
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

		protected override byte __flatsharp__Type_11
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

		protected override byte __flatsharp__Type_12
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

		protected override byte __flatsharp__Type_13
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

		protected override byte __flatsharp__Type_14
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

		protected override byte __flatsharp__Type_15
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

		protected override byte __flatsharp__Type_16
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

		protected override byte __flatsharp__Type_17
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

		protected override byte __flatsharp__Type_18
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

		protected override byte __flatsharp__Type_19
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

		protected override byte __flatsharp__Type_20
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

		protected override byte __flatsharp__Type_21
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

		protected override byte __flatsharp__Type_22
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

		protected override byte __flatsharp__Type_23
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

		protected override byte __flatsharp__Type_24
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

		protected override byte __flatsharp__Type_25
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

		protected override byte __flatsharp__Type_26
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

		protected override byte __flatsharp__Type_27
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

		protected override byte __flatsharp__Type_28
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

		protected override byte __flatsharp__Type_29
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

		protected override byte __flatsharp__Type_30
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

		protected override byte __flatsharp__Type_31
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

		protected override byte __flatsharp__Type_32
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

		protected override byte __flatsharp__Type_33
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

		protected override byte __flatsharp__Type_34
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

		protected override byte __flatsharp__Type_35
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

		protected override byte __flatsharp__Type_36
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

		protected override byte __flatsharp__Type_37
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

		protected override byte __flatsharp__Type_38
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

		protected override byte __flatsharp__Type_39
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

		protected override byte __flatsharp__Type_40
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

		protected override byte __flatsharp__Type_41
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

		protected override byte __flatsharp__Type_42
		{
			get
			{
				return __index43Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_43
		{
			get
			{
				return __index44Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_44
		{
			get
			{
				return __index45Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_45
		{
			get
			{
				return __index46Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_46
		{
			get
			{
				return __index47Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_47
		{
			get
			{
				return __index48Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_48
		{
			get
			{
				return __index49Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_49
		{
			get
			{
				return __index50Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_50
		{
			get
			{
				return __index51Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_51
		{
			get
			{
				return __index52Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_52
		{
			get
			{
				return __index53Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_53
		{
			get
			{
				return __index54Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_54
		{
			get
			{
				return __index55Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_55
		{
			get
			{
				return __index56Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_56
		{
			get
			{
				return __index57Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_57
		{
			get
			{
				return __index58Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_58
		{
			get
			{
				return __index59Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_59
		{
			get
			{
				return __index60Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_60
		{
			get
			{
				return __index61Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_61
		{
			get
			{
				return __index62Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_62
		{
			get
			{
				return __index63Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		protected override byte __flatsharp__Type_63
		{
			get
			{
				return __index64Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_d688d80425bf427ca52f0dc7b73722d9_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__index0Value = ReadIndex0Value(buffer, offset, default, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, default, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, default, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, default, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, default, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, default, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, default, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, default, remainingDepth);
			__index8Value = ReadIndex8Value(buffer, offset, default, remainingDepth);
			__index9Value = ReadIndex9Value(buffer, offset, default, remainingDepth);
			__index10Value = ReadIndex10Value(buffer, offset, default, remainingDepth);
			__index11Value = ReadIndex11Value(buffer, offset, default, remainingDepth);
			__index12Value = ReadIndex12Value(buffer, offset, default, remainingDepth);
			__index13Value = ReadIndex13Value(buffer, offset, default, remainingDepth);
			__index14Value = ReadIndex14Value(buffer, offset, default, remainingDepth);
			__index15Value = ReadIndex15Value(buffer, offset, default, remainingDepth);
			__index16Value = ReadIndex16Value(buffer, offset, default, remainingDepth);
			__index17Value = ReadIndex17Value(buffer, offset, default, remainingDepth);
			__index18Value = ReadIndex18Value(buffer, offset, default, remainingDepth);
			__index19Value = ReadIndex19Value(buffer, offset, default, remainingDepth);
			__index20Value = ReadIndex20Value(buffer, offset, default, remainingDepth);
			__index21Value = ReadIndex21Value(buffer, offset, default, remainingDepth);
			__index22Value = ReadIndex22Value(buffer, offset, default, remainingDepth);
			__index23Value = ReadIndex23Value(buffer, offset, default, remainingDepth);
			__index24Value = ReadIndex24Value(buffer, offset, default, remainingDepth);
			__index25Value = ReadIndex25Value(buffer, offset, default, remainingDepth);
			__index26Value = ReadIndex26Value(buffer, offset, default, remainingDepth);
			__index27Value = ReadIndex27Value(buffer, offset, default, remainingDepth);
			__index28Value = ReadIndex28Value(buffer, offset, default, remainingDepth);
			__index29Value = ReadIndex29Value(buffer, offset, default, remainingDepth);
			__index30Value = ReadIndex30Value(buffer, offset, default, remainingDepth);
			__index31Value = ReadIndex31Value(buffer, offset, default, remainingDepth);
			__index32Value = ReadIndex32Value(buffer, offset, default, remainingDepth);
			__index33Value = ReadIndex33Value(buffer, offset, default, remainingDepth);
			__index34Value = ReadIndex34Value(buffer, offset, default, remainingDepth);
			__index35Value = ReadIndex35Value(buffer, offset, default, remainingDepth);
			__index36Value = ReadIndex36Value(buffer, offset, default, remainingDepth);
			__index37Value = ReadIndex37Value(buffer, offset, default, remainingDepth);
			__index38Value = ReadIndex38Value(buffer, offset, default, remainingDepth);
			__index39Value = ReadIndex39Value(buffer, offset, default, remainingDepth);
			__index40Value = ReadIndex40Value(buffer, offset, default, remainingDepth);
			__index41Value = ReadIndex41Value(buffer, offset, default, remainingDepth);
			__index42Value = ReadIndex42Value(buffer, offset, default, remainingDepth);
			__index43Value = ReadIndex43Value(buffer, offset, default, remainingDepth);
			__index44Value = ReadIndex44Value(buffer, offset, default, remainingDepth);
			__index45Value = ReadIndex45Value(buffer, offset, default, remainingDepth);
			__index46Value = ReadIndex46Value(buffer, offset, default, remainingDepth);
			__index47Value = ReadIndex47Value(buffer, offset, default, remainingDepth);
			__index48Value = ReadIndex48Value(buffer, offset, default, remainingDepth);
			__index49Value = ReadIndex49Value(buffer, offset, default, remainingDepth);
			__index50Value = ReadIndex50Value(buffer, offset, default, remainingDepth);
			__index51Value = ReadIndex51Value(buffer, offset, default, remainingDepth);
			__index52Value = ReadIndex52Value(buffer, offset, default, remainingDepth);
			__index53Value = ReadIndex53Value(buffer, offset, default, remainingDepth);
			__index54Value = ReadIndex54Value(buffer, offset, default, remainingDepth);
			__index55Value = ReadIndex55Value(buffer, offset, default, remainingDepth);
			__index56Value = ReadIndex56Value(buffer, offset, default, remainingDepth);
			__index57Value = ReadIndex57Value(buffer, offset, default, remainingDepth);
			__index58Value = ReadIndex58Value(buffer, offset, default, remainingDepth);
			__index59Value = ReadIndex59Value(buffer, offset, default, remainingDepth);
			__index60Value = ReadIndex60Value(buffer, offset, default, remainingDepth);
			__index61Value = ReadIndex61Value(buffer, offset, default, remainingDepth);
			__index62Value = ReadIndex62Value(buffer, offset, default, remainingDepth);
			__index63Value = ReadIndex63Value(buffer, offset, default, remainingDepth);
			__index64Value = ReadIndex64Value(buffer, offset, default, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 4, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 5, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 6, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex4Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 7, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex5Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 8, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex6Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 9, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex7Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 10, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex8Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 11, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex9Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 12, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex10Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 13, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex11Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 14, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex12Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 15, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex13Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 16, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex14Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 17, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex15Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 18, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex16Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 19, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex17Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 20, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex18Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 21, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex19Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 22, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex20Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 23, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex21Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 24, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex22Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 25, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex23Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 26, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex24Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 27, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex25Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 28, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex26Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 29, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex27Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 30, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex28Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 31, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex29Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 32, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex30Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 33, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex31Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 34, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex32Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 35, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex33Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 36, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex34Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 37, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex35Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 38, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex36Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 39, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex37Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 40, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex38Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 41, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex39Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 42, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex40Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 43, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex41Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 44, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex42Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 45, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex43Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 46, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex44Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 47, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex45Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 48, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex46Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 49, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex47Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 50, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex48Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 51, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex49Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 52, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex50Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 53, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex51Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 54, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex52Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 55, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex53Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 56, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex54Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 57, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex55Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 58, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex56Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 59, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex57Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 60, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex58Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 61, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex59Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 62, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex60Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 63, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex61Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 64, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex62Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 65, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex63Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 66, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex64Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 67, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable NotificationEvent")]
	internal sealed class structReader_d688d80425bf427ca52f0dc7b73722d9_GreedyMutable<TInputBuffer> : NotificationEvent, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private float __index0Value;

		private byte __index1Value;

		private byte __index2Value;

		private byte __index3Value;

		private byte __index4Value;

		private byte __index5Value;

		private byte __index6Value;

		private byte __index7Value;

		private byte __index8Value;

		private byte __index9Value;

		private byte __index10Value;

		private byte __index11Value;

		private byte __index12Value;

		private byte __index13Value;

		private byte __index14Value;

		private byte __index15Value;

		private byte __index16Value;

		private byte __index17Value;

		private byte __index18Value;

		private byte __index19Value;

		private byte __index20Value;

		private byte __index21Value;

		private byte __index22Value;

		private byte __index23Value;

		private byte __index24Value;

		private byte __index25Value;

		private byte __index26Value;

		private byte __index27Value;

		private byte __index28Value;

		private byte __index29Value;

		private byte __index30Value;

		private byte __index31Value;

		private byte __index32Value;

		private byte __index33Value;

		private byte __index34Value;

		private byte __index35Value;

		private byte __index36Value;

		private byte __index37Value;

		private byte __index38Value;

		private byte __index39Value;

		private byte __index40Value;

		private byte __index41Value;

		private byte __index42Value;

		private byte __index43Value;

		private byte __index44Value;

		private byte __index45Value;

		private byte __index46Value;

		private byte __index47Value;

		private byte __index48Value;

		private byte __index49Value;

		private byte __index50Value;

		private byte __index51Value;

		private byte __index52Value;

		private byte __index53Value;

		private byte __index54Value;

		private byte __index55Value;

		private byte __index56Value;

		private byte __index57Value;

		private byte __index58Value;

		private byte __index59Value;

		private byte __index60Value;

		private byte __index61Value;

		private byte __index62Value;

		private byte __index63Value;

		private byte __index64Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(NotificationEvent);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override float GameTime
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

		protected override byte __flatsharp__Type_0
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

		protected override byte __flatsharp__Type_1
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

		protected override byte __flatsharp__Type_2
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

		protected override byte __flatsharp__Type_3
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

		protected override byte __flatsharp__Type_4
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

		protected override byte __flatsharp__Type_5
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

		protected override byte __flatsharp__Type_6
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

		protected override byte __flatsharp__Type_7
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

		protected override byte __flatsharp__Type_8
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

		protected override byte __flatsharp__Type_9
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

		protected override byte __flatsharp__Type_10
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

		protected override byte __flatsharp__Type_11
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

		protected override byte __flatsharp__Type_12
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

		protected override byte __flatsharp__Type_13
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

		protected override byte __flatsharp__Type_14
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

		protected override byte __flatsharp__Type_15
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

		protected override byte __flatsharp__Type_16
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

		protected override byte __flatsharp__Type_17
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

		protected override byte __flatsharp__Type_18
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

		protected override byte __flatsharp__Type_19
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

		protected override byte __flatsharp__Type_20
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

		protected override byte __flatsharp__Type_21
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

		protected override byte __flatsharp__Type_22
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

		protected override byte __flatsharp__Type_23
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

		protected override byte __flatsharp__Type_24
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

		protected override byte __flatsharp__Type_25
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

		protected override byte __flatsharp__Type_26
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

		protected override byte __flatsharp__Type_27
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

		protected override byte __flatsharp__Type_28
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

		protected override byte __flatsharp__Type_29
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

		protected override byte __flatsharp__Type_30
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

		protected override byte __flatsharp__Type_31
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

		protected override byte __flatsharp__Type_32
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

		protected override byte __flatsharp__Type_33
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

		protected override byte __flatsharp__Type_34
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

		protected override byte __flatsharp__Type_35
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

		protected override byte __flatsharp__Type_36
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

		protected override byte __flatsharp__Type_37
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

		protected override byte __flatsharp__Type_38
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

		protected override byte __flatsharp__Type_39
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

		protected override byte __flatsharp__Type_40
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

		protected override byte __flatsharp__Type_41
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

		protected override byte __flatsharp__Type_42
		{
			get
			{
				return __index43Value;
			}
			set
			{
				__index43Value = value;
			}
		}

		protected override byte __flatsharp__Type_43
		{
			get
			{
				return __index44Value;
			}
			set
			{
				__index44Value = value;
			}
		}

		protected override byte __flatsharp__Type_44
		{
			get
			{
				return __index45Value;
			}
			set
			{
				__index45Value = value;
			}
		}

		protected override byte __flatsharp__Type_45
		{
			get
			{
				return __index46Value;
			}
			set
			{
				__index46Value = value;
			}
		}

		protected override byte __flatsharp__Type_46
		{
			get
			{
				return __index47Value;
			}
			set
			{
				__index47Value = value;
			}
		}

		protected override byte __flatsharp__Type_47
		{
			get
			{
				return __index48Value;
			}
			set
			{
				__index48Value = value;
			}
		}

		protected override byte __flatsharp__Type_48
		{
			get
			{
				return __index49Value;
			}
			set
			{
				__index49Value = value;
			}
		}

		protected override byte __flatsharp__Type_49
		{
			get
			{
				return __index50Value;
			}
			set
			{
				__index50Value = value;
			}
		}

		protected override byte __flatsharp__Type_50
		{
			get
			{
				return __index51Value;
			}
			set
			{
				__index51Value = value;
			}
		}

		protected override byte __flatsharp__Type_51
		{
			get
			{
				return __index52Value;
			}
			set
			{
				__index52Value = value;
			}
		}

		protected override byte __flatsharp__Type_52
		{
			get
			{
				return __index53Value;
			}
			set
			{
				__index53Value = value;
			}
		}

		protected override byte __flatsharp__Type_53
		{
			get
			{
				return __index54Value;
			}
			set
			{
				__index54Value = value;
			}
		}

		protected override byte __flatsharp__Type_54
		{
			get
			{
				return __index55Value;
			}
			set
			{
				__index55Value = value;
			}
		}

		protected override byte __flatsharp__Type_55
		{
			get
			{
				return __index56Value;
			}
			set
			{
				__index56Value = value;
			}
		}

		protected override byte __flatsharp__Type_56
		{
			get
			{
				return __index57Value;
			}
			set
			{
				__index57Value = value;
			}
		}

		protected override byte __flatsharp__Type_57
		{
			get
			{
				return __index58Value;
			}
			set
			{
				__index58Value = value;
			}
		}

		protected override byte __flatsharp__Type_58
		{
			get
			{
				return __index59Value;
			}
			set
			{
				__index59Value = value;
			}
		}

		protected override byte __flatsharp__Type_59
		{
			get
			{
				return __index60Value;
			}
			set
			{
				__index60Value = value;
			}
		}

		protected override byte __flatsharp__Type_60
		{
			get
			{
				return __index61Value;
			}
			set
			{
				__index61Value = value;
			}
		}

		protected override byte __flatsharp__Type_61
		{
			get
			{
				return __index62Value;
			}
			set
			{
				__index62Value = value;
			}
		}

		protected override byte __flatsharp__Type_62
		{
			get
			{
				return __index63Value;
			}
			set
			{
				__index63Value = value;
			}
		}

		protected override byte __flatsharp__Type_63
		{
			get
			{
				return __index64Value;
			}
			set
			{
				__index64Value = value;
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public structReader_d688d80425bf427ca52f0dc7b73722d9_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__index0Value = ReadIndex0Value(buffer, offset, default, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, default, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, default, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, default, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, default, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, default, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, default, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, default, remainingDepth);
			__index8Value = ReadIndex8Value(buffer, offset, default, remainingDepth);
			__index9Value = ReadIndex9Value(buffer, offset, default, remainingDepth);
			__index10Value = ReadIndex10Value(buffer, offset, default, remainingDepth);
			__index11Value = ReadIndex11Value(buffer, offset, default, remainingDepth);
			__index12Value = ReadIndex12Value(buffer, offset, default, remainingDepth);
			__index13Value = ReadIndex13Value(buffer, offset, default, remainingDepth);
			__index14Value = ReadIndex14Value(buffer, offset, default, remainingDepth);
			__index15Value = ReadIndex15Value(buffer, offset, default, remainingDepth);
			__index16Value = ReadIndex16Value(buffer, offset, default, remainingDepth);
			__index17Value = ReadIndex17Value(buffer, offset, default, remainingDepth);
			__index18Value = ReadIndex18Value(buffer, offset, default, remainingDepth);
			__index19Value = ReadIndex19Value(buffer, offset, default, remainingDepth);
			__index20Value = ReadIndex20Value(buffer, offset, default, remainingDepth);
			__index21Value = ReadIndex21Value(buffer, offset, default, remainingDepth);
			__index22Value = ReadIndex22Value(buffer, offset, default, remainingDepth);
			__index23Value = ReadIndex23Value(buffer, offset, default, remainingDepth);
			__index24Value = ReadIndex24Value(buffer, offset, default, remainingDepth);
			__index25Value = ReadIndex25Value(buffer, offset, default, remainingDepth);
			__index26Value = ReadIndex26Value(buffer, offset, default, remainingDepth);
			__index27Value = ReadIndex27Value(buffer, offset, default, remainingDepth);
			__index28Value = ReadIndex28Value(buffer, offset, default, remainingDepth);
			__index29Value = ReadIndex29Value(buffer, offset, default, remainingDepth);
			__index30Value = ReadIndex30Value(buffer, offset, default, remainingDepth);
			__index31Value = ReadIndex31Value(buffer, offset, default, remainingDepth);
			__index32Value = ReadIndex32Value(buffer, offset, default, remainingDepth);
			__index33Value = ReadIndex33Value(buffer, offset, default, remainingDepth);
			__index34Value = ReadIndex34Value(buffer, offset, default, remainingDepth);
			__index35Value = ReadIndex35Value(buffer, offset, default, remainingDepth);
			__index36Value = ReadIndex36Value(buffer, offset, default, remainingDepth);
			__index37Value = ReadIndex37Value(buffer, offset, default, remainingDepth);
			__index38Value = ReadIndex38Value(buffer, offset, default, remainingDepth);
			__index39Value = ReadIndex39Value(buffer, offset, default, remainingDepth);
			__index40Value = ReadIndex40Value(buffer, offset, default, remainingDepth);
			__index41Value = ReadIndex41Value(buffer, offset, default, remainingDepth);
			__index42Value = ReadIndex42Value(buffer, offset, default, remainingDepth);
			__index43Value = ReadIndex43Value(buffer, offset, default, remainingDepth);
			__index44Value = ReadIndex44Value(buffer, offset, default, remainingDepth);
			__index45Value = ReadIndex45Value(buffer, offset, default, remainingDepth);
			__index46Value = ReadIndex46Value(buffer, offset, default, remainingDepth);
			__index47Value = ReadIndex47Value(buffer, offset, default, remainingDepth);
			__index48Value = ReadIndex48Value(buffer, offset, default, remainingDepth);
			__index49Value = ReadIndex49Value(buffer, offset, default, remainingDepth);
			__index50Value = ReadIndex50Value(buffer, offset, default, remainingDepth);
			__index51Value = ReadIndex51Value(buffer, offset, default, remainingDepth);
			__index52Value = ReadIndex52Value(buffer, offset, default, remainingDepth);
			__index53Value = ReadIndex53Value(buffer, offset, default, remainingDepth);
			__index54Value = ReadIndex54Value(buffer, offset, default, remainingDepth);
			__index55Value = ReadIndex55Value(buffer, offset, default, remainingDepth);
			__index56Value = ReadIndex56Value(buffer, offset, default, remainingDepth);
			__index57Value = ReadIndex57Value(buffer, offset, default, remainingDepth);
			__index58Value = ReadIndex58Value(buffer, offset, default, remainingDepth);
			__index59Value = ReadIndex59Value(buffer, offset, default, remainingDepth);
			__index60Value = ReadIndex60Value(buffer, offset, default, remainingDepth);
			__index61Value = ReadIndex61Value(buffer, offset, default, remainingDepth);
			__index62Value = ReadIndex62Value(buffer, offset, default, remainingDepth);
			__index63Value = ReadIndex63Value(buffer, offset, default, remainingDepth);
			__index64Value = ReadIndex64Value(buffer, offset, default, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex1Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 4, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex2Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 5, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex3Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 6, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex4Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 7, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex5Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 8, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex6Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 9, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex7Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 10, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex8Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 11, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex9Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 12, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex10Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 13, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex11Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 14, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex12Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 15, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex13Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 16, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex14Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 17, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex15Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 18, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex16Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 19, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex17Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 20, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex18Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 21, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex19Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 22, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex20Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 23, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex21Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 24, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex22Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 25, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex23Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 26, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex24Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 27, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex25Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 28, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex26Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 29, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex27Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 30, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex28Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 31, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex29Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 32, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex30Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 33, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex31Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 34, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex32Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 35, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex33Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 36, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex34Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 37, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex35Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 38, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex36Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 39, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex37Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 40, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex38Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 41, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex39Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 42, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex40Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 43, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex41Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 44, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex42Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 45, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex43Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 46, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex44Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 47, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex45Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 48, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex46Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 49, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex47Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 50, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex48Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 51, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex49Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 52, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex50Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 53, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex51Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 54, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex52Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 55, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex53Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 56, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex54Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 57, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex55Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 58, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex56Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 59, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex57Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 60, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex58Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 61, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex59Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 62, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex60Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 63, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex61Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 64, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex62Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 65, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex63Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 66, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static byte ReadIndex64Value(TInputBuffer buffer, int offset, VTable4 vtable, short remainingDepth)
		{
			return FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Parse(buffer, offset + 67, remainingDepth);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static int GetMaxSize(NotificationEvent value)
	{
		return 71;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, NotificationEvent value, int offset) where TSpanWriter : ISpanWriter
	{
		Span<byte> span2 = span.Slice(offset, 68);
		if (value == null)
		{
			span2.Clear();
			return;
		}
		FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span2, value.GameTime, 0);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[0], 4);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[1], 5);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[2], 6);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[3], 7);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[4], 8);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[5], 9);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[6], 10);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[7], 11);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[8], 12);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[9], 13);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[10], 14);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[11], 15);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[12], 16);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[13], 17);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[14], 18);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[15], 19);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[16], 20);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[17], 21);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[18], 22);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[19], 23);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[20], 24);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[21], 25);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[22], 26);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[23], 27);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[24], 28);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[25], 29);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[26], 30);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[27], 31);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[28], 32);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[29], 33);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[30], 34);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[31], 35);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[32], 36);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[33], 37);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[34], 38);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[35], 39);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[36], 40);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[37], 41);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[38], 42);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[39], 43);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[40], 44);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[41], 45);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[42], 46);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[43], 47);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[44], 48);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[45], 49);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[46], 50);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[47], 51);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[48], 52);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[49], 53);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[50], 54);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[51], 55);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[52], 56);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[53], 57);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[54], 58);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[55], 59);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[56], 60);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[57], 61);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[58], 62);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[59], 63);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[60], 64);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[61], 65);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[62], 66);
		FlatSharp.Compiler.Generated.NC274CD218E9DE0B3BDF675849D0907EA99BEB976F56808C38D86E7FB2E35311B.Helpers.Serialize(spanWriter, span2, value.Type[63], 67);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_d688d80425bf427ca52f0dc7b73722d9_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_d688d80425bf427ca52f0dc7b73722d9_Lazy<TInputBuffer>(buffer, offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_d688d80425bf427ca52f0dc7b73722d9_Progressive<TInputBuffer>(buffer, offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_d688d80425bf427ca52f0dc7b73722d9_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_d688d80425bf427ca52f0dc7b73722d9_Greedy<TInputBuffer>(buffer, offset, remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static structReader_d688d80425bf427ca52f0dc7b73722d9_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new structReader_d688d80425bf427ca52f0dc7b73722d9_GreedyMutable<TInputBuffer>(buffer, offset, remainingDepth);
	}
}
