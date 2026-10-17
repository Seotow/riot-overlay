using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N177F41C23F23F4C32D4ACA72142A83975A111B7E9E46A189CD5ED3CBF0376BCD;
using FlatSharp.Compiler.Generated.N1FB94CCF818D4F18E276DE2D6CDA5E29CCF8F7AE07579DA110B88182E0321DAC;
using FlatSharp.Compiler.Generated.N4EAC433854FE42EDC43F2B87B57DB0CC768F125556731E6448FFD8E1A394441C;
using FlatSharp.Compiler.Generated.N593F046A9C640420C1B7C7DD7614E503CB383F7C64B9657072D3976CF3D6B0A4;
using FlatSharp.Compiler.Generated.N9CA97BB431A89F9B8067DE122164F7D687A6ED6A36C070C6D4D6D608D04118D2;
using FlatSharp.Compiler.Generated.NB8B14F06D639393F097BA7716D95AC98754F6C5F27D1ABB098C44E6AE06AF158;
using FlatSharp.Compiler.Generated.ND312F9B9DDE0762086B11C7DBF89FFFDA7EFCE2687E9CE033F64898BA0AC4FFF;
using FlatSharp.Compiler.Generated.NDD8E4A8506C656A2C95491123840698AE70B9335B7B1668A0A9F8C4506628DDC;
using FlatSharp.Compiler.Generated.NDF5A630A053F130C9461F964AC2C64367326EDF6F060B30389888A9D16A1F9A3;
using FlatSharp.Compiler.Generated.NE863D08BB30A51E26819C00AE83A013A5E4C48A76FEA2B21DA83BFFA55FEAAEE;
using FlatSharp.Compiler.Generated.NFA357E6516EAEA078F5023B47E9AD2038337E9729180BCCC48BADB6CCA523B70;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N9052A50713F3C09043E0CE106DF6F5B39F67CDB10823AB69BA5709A0CE9D53D0;

internal static class Helpers
{
	[DebuggerDisplay("Lazy GameEvents")]
	internal sealed class tableReader_700c4c62d12a4afd96bf88bb698947fa_Lazy<TInputBuffer> : GameEvents, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GameEvents);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<DeathEvent>? DeathEvents
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

		public override IList<DamageDealtEvent>? DamageDealtEvents
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

		public override IList<NotificationEvent>? NotificationEvents
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

		public override IList<InhibitorKillEvent>? InhibitorKillEvents
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

		public override IList<FirstBloodEvent>? FirstBloodEvents
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

		public override IList<TurretKillEvent>? TurretKillEvents
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

		public override IList<TurretPlateDestroyEvent>? TurretPlateDestroyEvents
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

		public override IList<XKillEvent>? XKillEvents
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

		public override IList<AceEvent>? AceEvents
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

		public override IList<ObjectiveStealEvent>? ObjectiveStealEvents
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

		public override IList<HeroDieEvent>? HeroDieEvents
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_700c4c62d12a4afd96bf88bb698947fa_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<DeathEvent>? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE863D08BB30A51E26819C00AE83A013A5E4C48A76FEA2B21DA83BFFA55FEAAEE.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.DeathEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<DamageDealtEvent>? ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB8B14F06D639393F097BA7716D95AC98754F6C5F27D1ABB098C44E6AE06AF158.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.DamageDealtEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<NotificationEvent>? ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1FB94CCF818D4F18E276DE2D6CDA5E29CCF8F7AE07579DA110B88182E0321DAC.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.NotificationEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<InhibitorKillEvent>? ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N177F41C23F23F4C32D4ACA72142A83975A111B7E9E46A189CD5ED3CBF0376BCD.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.InhibitorKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<FirstBloodEvent>? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4EAC433854FE42EDC43F2B87B57DB0CC768F125556731E6448FFD8E1A394441C.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.FirstBloodEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TurretKillEvent>? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDD8E4A8506C656A2C95491123840698AE70B9335B7B1668A0A9F8C4506628DDC.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.TurretKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TurretPlateDestroyEvent>? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N593F046A9C640420C1B7C7DD7614E503CB383F7C64B9657072D3976CF3D6B0A4.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.TurretPlateDestroyEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<XKillEvent>? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND312F9B9DDE0762086B11C7DBF89FFFDA7EFCE2687E9CE033F64898BA0AC4FFF.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.XKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AceEvent>? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDF5A630A053F130C9461F964AC2C64367326EDF6F060B30389888A9D16A1F9A3.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.AceEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ObjectiveStealEvent>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9CA97BB431A89F9B8067DE122164F7D687A6ED6A36C070C6D4D6D608D04118D2.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.ObjectiveStealEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<HeroDieEvent>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFA357E6516EAEA078F5023B47E9AD2038337E9729180BCCC48BADB6CCA523B70.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.HeroDieEvents);
		}
	}

	[DebuggerDisplay("Progressive GameEvents")]
	internal sealed class tableReader_700c4c62d12a4afd96bf88bb698947fa_Progressive<TInputBuffer> : GameEvents, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private IList<DeathEvent>? __index0Value;

		private IList<DamageDealtEvent>? __index1Value;

		private IList<NotificationEvent>? __index2Value;

		private IList<InhibitorKillEvent>? __index3Value;

		private IList<FirstBloodEvent>? __index4Value;

		private IList<TurretKillEvent>? __index5Value;

		private IList<TurretPlateDestroyEvent>? __index6Value;

		private IList<XKillEvent>? __index7Value;

		private byte __mask1;

		private IList<AceEvent>? __index8Value;

		private IList<ObjectiveStealEvent>? __index9Value;

		private IList<HeroDieEvent>? __index10Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GameEvents);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override IList<DeathEvent>? DeathEvents
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

		public override IList<DamageDealtEvent>? DamageDealtEvents
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

		public override IList<NotificationEvent>? NotificationEvents
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

		public override IList<InhibitorKillEvent>? InhibitorKillEvents
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

		public override IList<FirstBloodEvent>? FirstBloodEvents
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

		public override IList<TurretKillEvent>? TurretKillEvents
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

		public override IList<TurretPlateDestroyEvent>? TurretPlateDestroyEvents
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

		public override IList<XKillEvent>? XKillEvents
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

		public override IList<AceEvent>? AceEvents
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

		public override IList<ObjectiveStealEvent>? ObjectiveStealEvents
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

		public override IList<HeroDieEvent>? HeroDieEvents
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_700c4c62d12a4afd96bf88bb698947fa_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<DeathEvent>? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE863D08BB30A51E26819C00AE83A013A5E4C48A76FEA2B21DA83BFFA55FEAAEE.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.DeathEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<DamageDealtEvent>? ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB8B14F06D639393F097BA7716D95AC98754F6C5F27D1ABB098C44E6AE06AF158.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.DamageDealtEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<NotificationEvent>? ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1FB94CCF818D4F18E276DE2D6CDA5E29CCF8F7AE07579DA110B88182E0321DAC.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.NotificationEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<InhibitorKillEvent>? ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N177F41C23F23F4C32D4ACA72142A83975A111B7E9E46A189CD5ED3CBF0376BCD.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.InhibitorKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<FirstBloodEvent>? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4EAC433854FE42EDC43F2B87B57DB0CC768F125556731E6448FFD8E1A394441C.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.FirstBloodEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TurretKillEvent>? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDD8E4A8506C656A2C95491123840698AE70B9335B7B1668A0A9F8C4506628DDC.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.TurretKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TurretPlateDestroyEvent>? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N593F046A9C640420C1B7C7DD7614E503CB383F7C64B9657072D3976CF3D6B0A4.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.TurretPlateDestroyEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<XKillEvent>? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND312F9B9DDE0762086B11C7DBF89FFFDA7EFCE2687E9CE033F64898BA0AC4FFF.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.XKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AceEvent>? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDF5A630A053F130C9461F964AC2C64367326EDF6F060B30389888A9D16A1F9A3.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.AceEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ObjectiveStealEvent>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9CA97BB431A89F9B8067DE122164F7D687A6ED6A36C070C6D4D6D608D04118D2.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.ObjectiveStealEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<HeroDieEvent>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFA357E6516EAEA078F5023B47E9AD2038337E9729180BCCC48BADB6CCA523B70.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.HeroDieEvents);
		}
	}

	[DebuggerDisplay("Greedy GameEvents")]
	internal sealed class tableReader_700c4c62d12a4afd96bf88bb698947fa_Greedy<TInputBuffer> : GameEvents, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private IList<DeathEvent>? __index0Value;

		private IList<DamageDealtEvent>? __index1Value;

		private IList<NotificationEvent>? __index2Value;

		private IList<InhibitorKillEvent>? __index3Value;

		private IList<FirstBloodEvent>? __index4Value;

		private IList<TurretKillEvent>? __index5Value;

		private IList<TurretPlateDestroyEvent>? __index6Value;

		private IList<XKillEvent>? __index7Value;

		private IList<AceEvent>? __index8Value;

		private IList<ObjectiveStealEvent>? __index9Value;

		private IList<HeroDieEvent>? __index10Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GameEvents);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<DeathEvent>? DeathEvents
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

		public override IList<DamageDealtEvent>? DamageDealtEvents
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

		public override IList<NotificationEvent>? NotificationEvents
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

		public override IList<InhibitorKillEvent>? InhibitorKillEvents
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

		public override IList<FirstBloodEvent>? FirstBloodEvents
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

		public override IList<TurretKillEvent>? TurretKillEvents
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

		public override IList<TurretPlateDestroyEvent>? TurretPlateDestroyEvents
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

		public override IList<XKillEvent>? XKillEvents
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

		public override IList<AceEvent>? AceEvents
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

		public override IList<ObjectiveStealEvent>? ObjectiveStealEvents
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

		public override IList<HeroDieEvent>? HeroDieEvents
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_700c4c62d12a4afd96bf88bb698947fa_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<DeathEvent>? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE863D08BB30A51E26819C00AE83A013A5E4C48A76FEA2B21DA83BFFA55FEAAEE.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.DeathEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<DamageDealtEvent>? ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB8B14F06D639393F097BA7716D95AC98754F6C5F27D1ABB098C44E6AE06AF158.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.DamageDealtEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<NotificationEvent>? ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1FB94CCF818D4F18E276DE2D6CDA5E29CCF8F7AE07579DA110B88182E0321DAC.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.NotificationEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<InhibitorKillEvent>? ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N177F41C23F23F4C32D4ACA72142A83975A111B7E9E46A189CD5ED3CBF0376BCD.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.InhibitorKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<FirstBloodEvent>? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4EAC433854FE42EDC43F2B87B57DB0CC768F125556731E6448FFD8E1A394441C.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.FirstBloodEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TurretKillEvent>? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDD8E4A8506C656A2C95491123840698AE70B9335B7B1668A0A9F8C4506628DDC.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.TurretKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TurretPlateDestroyEvent>? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N593F046A9C640420C1B7C7DD7614E503CB383F7C64B9657072D3976CF3D6B0A4.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.TurretPlateDestroyEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<XKillEvent>? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND312F9B9DDE0762086B11C7DBF89FFFDA7EFCE2687E9CE033F64898BA0AC4FFF.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.XKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AceEvent>? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDF5A630A053F130C9461F964AC2C64367326EDF6F060B30389888A9D16A1F9A3.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.AceEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ObjectiveStealEvent>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9CA97BB431A89F9B8067DE122164F7D687A6ED6A36C070C6D4D6D608D04118D2.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.ObjectiveStealEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<HeroDieEvent>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFA357E6516EAEA078F5023B47E9AD2038337E9729180BCCC48BADB6CCA523B70.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.HeroDieEvents);
		}
	}

	[DebuggerDisplay("GreedyMutable GameEvents")]
	internal sealed class tableReader_700c4c62d12a4afd96bf88bb698947fa_GreedyMutable<TInputBuffer> : GameEvents, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private IList<DeathEvent>? __index0Value;

		private IList<DamageDealtEvent>? __index1Value;

		private IList<NotificationEvent>? __index2Value;

		private IList<InhibitorKillEvent>? __index3Value;

		private IList<FirstBloodEvent>? __index4Value;

		private IList<TurretKillEvent>? __index5Value;

		private IList<TurretPlateDestroyEvent>? __index6Value;

		private IList<XKillEvent>? __index7Value;

		private IList<AceEvent>? __index8Value;

		private IList<ObjectiveStealEvent>? __index9Value;

		private IList<HeroDieEvent>? __index10Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GameEvents);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override IList<DeathEvent>? DeathEvents
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

		public override IList<DamageDealtEvent>? DamageDealtEvents
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

		public override IList<NotificationEvent>? NotificationEvents
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

		public override IList<InhibitorKillEvent>? InhibitorKillEvents
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

		public override IList<FirstBloodEvent>? FirstBloodEvents
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

		public override IList<TurretKillEvent>? TurretKillEvents
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

		public override IList<TurretPlateDestroyEvent>? TurretPlateDestroyEvents
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

		public override IList<XKillEvent>? XKillEvents
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

		public override IList<AceEvent>? AceEvents
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

		public override IList<ObjectiveStealEvent>? ObjectiveStealEvents
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

		public override IList<HeroDieEvent>? HeroDieEvents
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_700c4c62d12a4afd96bf88bb698947fa_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<DeathEvent>? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NE863D08BB30A51E26819C00AE83A013A5E4C48A76FEA2B21DA83BFFA55FEAAEE.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.DeathEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<DamageDealtEvent>? ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB8B14F06D639393F097BA7716D95AC98754F6C5F27D1ABB098C44E6AE06AF158.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.DamageDealtEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<NotificationEvent>? ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1FB94CCF818D4F18E276DE2D6CDA5E29CCF8F7AE07579DA110B88182E0321DAC.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.NotificationEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<InhibitorKillEvent>? ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N177F41C23F23F4C32D4ACA72142A83975A111B7E9E46A189CD5ED3CBF0376BCD.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.InhibitorKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<FirstBloodEvent>? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4EAC433854FE42EDC43F2B87B57DB0CC768F125556731E6448FFD8E1A394441C.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.FirstBloodEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TurretKillEvent>? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDD8E4A8506C656A2C95491123840698AE70B9335B7B1668A0A9F8C4506628DDC.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.TurretKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TurretPlateDestroyEvent>? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N593F046A9C640420C1B7C7DD7614E503CB383F7C64B9657072D3976CF3D6B0A4.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.TurretPlateDestroyEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<XKillEvent>? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND312F9B9DDE0762086B11C7DBF89FFFDA7EFCE2687E9CE033F64898BA0AC4FFF.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.XKillEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AceEvent>? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDF5A630A053F130C9461F964AC2C64367326EDF6F060B30389888A9D16A1F9A3.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.AceEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<ObjectiveStealEvent>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9CA97BB431A89F9B8067DE122164F7D687A6ED6A36C070C6D4D6D608D04118D2.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.ObjectiveStealEvents);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<HeroDieEvent>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NFA357E6516EAEA078F5023B47E9AD2038337E9729180BCCC48BADB6CCA523B70.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_7245f36dbb2945d88a066e89d31df5d9.HeroDieEvents);
		}
	}

	private static class tableMetadata_7245f36dbb2945d88a066e89d31df5d9
	{
		public static readonly TableFieldContext DeathEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.DeathEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext DamageDealtEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.DamageDealtEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext NotificationEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.NotificationEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext InhibitorKillEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.InhibitorKillEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext FirstBloodEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.FirstBloodEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext TurretKillEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.TurretKillEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext TurretPlateDestroyEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.TurretPlateDestroyEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext XKillEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.XKillEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext AceEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.AceEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ObjectiveStealEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.ObjectiveStealEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext HeroDieEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameEvents.HeroDieEvents", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(GameEvents value)
	{
		int num = 111;
		IList<DeathEvent> deathEvents = value.DeathEvents;
		if (deathEvents != null)
		{
			num += FlatSharp.Compiler.Generated.NE863D08BB30A51E26819C00AE83A013A5E4C48A76FEA2B21DA83BFFA55FEAAEE.Helpers.GetMaxSize(deathEvents);
		}
		IList<DamageDealtEvent> damageDealtEvents = value.DamageDealtEvents;
		if (damageDealtEvents != null)
		{
			num += FlatSharp.Compiler.Generated.NB8B14F06D639393F097BA7716D95AC98754F6C5F27D1ABB098C44E6AE06AF158.Helpers.GetMaxSize(damageDealtEvents);
		}
		IList<NotificationEvent> notificationEvents = value.NotificationEvents;
		if (notificationEvents != null)
		{
			num += FlatSharp.Compiler.Generated.N1FB94CCF818D4F18E276DE2D6CDA5E29CCF8F7AE07579DA110B88182E0321DAC.Helpers.GetMaxSize(notificationEvents);
		}
		IList<InhibitorKillEvent> inhibitorKillEvents = value.InhibitorKillEvents;
		if (inhibitorKillEvents != null)
		{
			num += FlatSharp.Compiler.Generated.N177F41C23F23F4C32D4ACA72142A83975A111B7E9E46A189CD5ED3CBF0376BCD.Helpers.GetMaxSize(inhibitorKillEvents);
		}
		IList<FirstBloodEvent> firstBloodEvents = value.FirstBloodEvents;
		if (firstBloodEvents != null)
		{
			num += FlatSharp.Compiler.Generated.N4EAC433854FE42EDC43F2B87B57DB0CC768F125556731E6448FFD8E1A394441C.Helpers.GetMaxSize(firstBloodEvents);
		}
		IList<TurretKillEvent> turretKillEvents = value.TurretKillEvents;
		if (turretKillEvents != null)
		{
			num += FlatSharp.Compiler.Generated.NDD8E4A8506C656A2C95491123840698AE70B9335B7B1668A0A9F8C4506628DDC.Helpers.GetMaxSize(turretKillEvents);
		}
		IList<TurretPlateDestroyEvent> turretPlateDestroyEvents = value.TurretPlateDestroyEvents;
		if (turretPlateDestroyEvents != null)
		{
			num += FlatSharp.Compiler.Generated.N593F046A9C640420C1B7C7DD7614E503CB383F7C64B9657072D3976CF3D6B0A4.Helpers.GetMaxSize(turretPlateDestroyEvents);
		}
		IList<XKillEvent> xKillEvents = value.XKillEvents;
		if (xKillEvents != null)
		{
			num += FlatSharp.Compiler.Generated.ND312F9B9DDE0762086B11C7DBF89FFFDA7EFCE2687E9CE033F64898BA0AC4FFF.Helpers.GetMaxSize(xKillEvents);
		}
		IList<AceEvent> aceEvents = value.AceEvents;
		if (aceEvents != null)
		{
			num += FlatSharp.Compiler.Generated.NDF5A630A053F130C9461F964AC2C64367326EDF6F060B30389888A9D16A1F9A3.Helpers.GetMaxSize(aceEvents);
		}
		IList<ObjectiveStealEvent> objectiveStealEvents = value.ObjectiveStealEvents;
		if (objectiveStealEvents != null)
		{
			num += FlatSharp.Compiler.Generated.N9CA97BB431A89F9B8067DE122164F7D687A6ED6A36C070C6D4D6D608D04118D2.Helpers.GetMaxSize(objectiveStealEvents);
		}
		IList<HeroDieEvent> heroDieEvents = value.HeroDieEvents;
		if (heroDieEvents != null)
		{
			num += FlatSharp.Compiler.Generated.NFA357E6516EAEA078F5023B47E9AD2038337E9729180BCCC48BADB6CCA523B70.Helpers.GetMaxSize(heroDieEvents);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, GameEvents value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(81, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[26];
		IList<DeathEvent> deathEvents = value.DeathEvents;
		IList<DamageDealtEvent> damageDealtEvents = value.DamageDealtEvents;
		IList<NotificationEvent> notificationEvents = value.NotificationEvents;
		IList<InhibitorKillEvent> inhibitorKillEvents = value.InhibitorKillEvents;
		IList<FirstBloodEvent> firstBloodEvents = value.FirstBloodEvents;
		IList<TurretKillEvent> turretKillEvents = value.TurretKillEvents;
		IList<TurretPlateDestroyEvent> turretPlateDestroyEvents = value.TurretPlateDestroyEvents;
		IList<XKillEvent> xKillEvents = value.XKillEvents;
		IList<AceEvent> aceEvents = value.AceEvents;
		IList<ObjectiveStealEvent> objectiveStealEvents = value.ObjectiveStealEvents;
		IList<HeroDieEvent> heroDieEvents = value.HeroDieEvents;
		int num4 = num;
		if (heroDieEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 26;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 24);
		int num5 = num;
		if (objectiveStealEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (24 > num3)
			{
				num3 = 24;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 22);
		int num6 = num;
		if (aceEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (22 > num3)
			{
				num3 = 22;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 20);
		int num7 = num;
		if (xKillEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			if (20 > num3)
			{
				num3 = 20;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 18);
		int num8 = num;
		if (turretPlateDestroyEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 16);
		int num9 = num;
		if (turretKillEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 14);
		int num10 = num;
		if (firstBloodEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 12);
		int num11 = num;
		if (inhibitorKillEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num11 = num2;
			num2 += 4;
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 10);
		int num12 = num;
		if (notificationEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num12 = num2;
			num2 += 4;
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 8);
		int num13 = num;
		if (damageDealtEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num13 = num2;
			num2 += 4;
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)(num13 - num), 6);
		int num14 = num;
		if (deathEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num14 = num2;
			num2 += 4;
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)(num14 - num), 4);
		int num15 = num2 - num;
		context.Offset -= 81 - num15;
		Span<byte> span14 = span2;
		spanWriter.WriteUShort(span14, (ushort)num3, 0);
		Span<byte> span15 = span2;
		spanWriter.WriteUShort(span15, (ushort)num15, 2);
		int num16 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num16, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NFA357E6516EAEA078F5023B47E9AD2038337E9729180BCCC48BADB6CCA523B70.Helpers.Serialize(spanWriter, span, heroDieEvents, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N9CA97BB431A89F9B8067DE122164F7D687A6ED6A36C070C6D4D6D608D04118D2.Helpers.Serialize(spanWriter, span, objectiveStealEvents, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.NDF5A630A053F130C9461F964AC2C64367326EDF6F060B30389888A9D16A1F9A3.Helpers.Serialize(spanWriter, span, aceEvents, num6, context);
		}
		if (num7 != num)
		{
			FlatSharp.Compiler.Generated.ND312F9B9DDE0762086B11C7DBF89FFFDA7EFCE2687E9CE033F64898BA0AC4FFF.Helpers.Serialize(spanWriter, span, xKillEvents, num7, context);
		}
		if (num8 != num)
		{
			FlatSharp.Compiler.Generated.N593F046A9C640420C1B7C7DD7614E503CB383F7C64B9657072D3976CF3D6B0A4.Helpers.Serialize(spanWriter, span, turretPlateDestroyEvents, num8, context);
		}
		if (num9 != num)
		{
			FlatSharp.Compiler.Generated.NDD8E4A8506C656A2C95491123840698AE70B9335B7B1668A0A9F8C4506628DDC.Helpers.Serialize(spanWriter, span, turretKillEvents, num9, context);
		}
		if (num10 != num)
		{
			FlatSharp.Compiler.Generated.N4EAC433854FE42EDC43F2B87B57DB0CC768F125556731E6448FFD8E1A394441C.Helpers.Serialize(spanWriter, span, firstBloodEvents, num10, context);
		}
		if (num11 != num)
		{
			FlatSharp.Compiler.Generated.N177F41C23F23F4C32D4ACA72142A83975A111B7E9E46A189CD5ED3CBF0376BCD.Helpers.Serialize(spanWriter, span, inhibitorKillEvents, num11, context);
		}
		if (num12 != num)
		{
			FlatSharp.Compiler.Generated.N1FB94CCF818D4F18E276DE2D6CDA5E29CCF8F7AE07579DA110B88182E0321DAC.Helpers.Serialize(spanWriter, span, notificationEvents, num12, context);
		}
		if (num13 != num)
		{
			FlatSharp.Compiler.Generated.NB8B14F06D639393F097BA7716D95AC98754F6C5F27D1ABB098C44E6AE06AF158.Helpers.Serialize(spanWriter, span, damageDealtEvents, num13, context);
		}
		if (num14 != num)
		{
			FlatSharp.Compiler.Generated.NE863D08BB30A51E26819C00AE83A013A5E4C48A76FEA2B21DA83BFFA55FEAAEE.Helpers.Serialize(spanWriter, span, deathEvents, num14, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_700c4c62d12a4afd96bf88bb698947fa_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_700c4c62d12a4afd96bf88bb698947fa_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_700c4c62d12a4afd96bf88bb698947fa_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_700c4c62d12a4afd96bf88bb698947fa_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_700c4c62d12a4afd96bf88bb698947fa_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_700c4c62d12a4afd96bf88bb698947fa_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_700c4c62d12a4afd96bf88bb698947fa_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_700c4c62d12a4afd96bf88bb698947fa_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
