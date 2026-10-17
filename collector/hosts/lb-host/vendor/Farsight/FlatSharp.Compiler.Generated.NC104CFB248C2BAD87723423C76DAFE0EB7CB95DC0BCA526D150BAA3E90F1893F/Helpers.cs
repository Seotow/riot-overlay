using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Compiler.Generated.N24DBECE6B62B08BD51DE2FFCFDDA5F54DDED0060FC9DA9018573610D754D1626;
using FlatSharp.Compiler.Generated.N2C5A74543636834075C28C79EBCA1FCC66471B13296945F1E2F12F229B73A2B5;
using FlatSharp.Compiler.Generated.N691EC907C29AE3492438CAEF32349BADACD2DC821F4C0CDF14AF712B7F70AE9C;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.N80227353403F0A2FF4FC23754CEE5A38FF55573382A976C71E6158BE0A98679E;
using FlatSharp.Compiler.Generated.N9052A50713F3C09043E0CE106DF6F5B39F67CDB10823AB69BA5709A0CE9D53D0;
using FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF;
using FlatSharp.Compiler.Generated.NBFED703FA83B6E9DE1C1FE62C536F5317B2EB484B3BDA89CDF45E18DA865D398;
using FlatSharp.Compiler.Generated.NC14A0EE4EC8D77CF82257964E3F863010C3731C2C62919452638B39EC1B2A8CF;
using FlatSharp.Compiler.Generated.NC26A595523A24B17875FED6DE6040E1026980B5652454680EF2E8F76BDFF6065;
using FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45;
using FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E;
using FlatSharp.Compiler.Generated.ND6EBC62F8EB5330C79CC53DB52A9366CD8A448A9CC840438FFB649CFE426CE43;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NC104CFB248C2BAD87723423C76DAFE0EB7CB95DC0BCA526D150BAA3E90F1893F;

internal static class Helpers
{
	[DebuggerDisplay("Lazy GameInfo")]
	internal sealed class tableReader_c16154e7befa43f1948bd3a2e7ea084c_Lazy<TInputBuffer> : GameInfo, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GameInfo);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override float GameTime
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

		public override float PlaybackSpeed
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

		public override ulong UtcTime
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

		public override Camera? Camera
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

		public override IList<TeamStats>? TeamStats
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

		public override GameEvents? GameEvents
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

		public override IList<AIHeroClient>? Heroes
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

		public override IList<AIMinionClient>? Minions
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

		public override IList<AITurretClient>? Turrets
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

		public override IList<Building>? BarracksDampeners
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

		public override IList<Building>? Hqs
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

		public override IList<Missile>? Missiles
		{
			get
			{
				return ReadIndex11Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<GeneralParticleEmitter>? ParticleEmitters
		{
			get
			{
				return ReadIndex12Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<MiscObjects>? Misc
		{
			get
			{
				return ReadIndex13Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override string? GameId
		{
			get
			{
				return ReadIndex14Value(__buffer, __offset, __vtable, __remainingDepth);
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c16154e7befa43f1948bd3a2e7ea084c_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Camera? ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N80227353403F0A2FF4FC23754CEE5A38FF55573382A976C71E6158BE0A98679E.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TeamStats>? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC14A0EE4EC8D77CF82257964E3F863010C3731C2C62919452638B39EC1B2A8CF.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.TeamStats);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GameEvents? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9052A50713F3C09043E0CE106DF6F5B39F67CDB10823AB69BA5709A0CE9D53D0.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AIHeroClient>? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NBFED703FA83B6E9DE1C1FE62C536F5317B2EB484B3BDA89CDF45E18DA865D398.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Heroes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AIMinionClient>? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC26A595523A24B17875FED6DE6040E1026980B5652454680EF2E8F76BDFF6065.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Minions);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AITurretClient>? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2C5A74543636834075C28C79EBCA1FCC66471B13296945F1E2F12F229B73A2B5.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Turrets);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Building>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.BarracksDampeners);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Building>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Hqs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Missile>? ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N691EC907C29AE3492438CAEF32349BADACD2DC821F4C0CDF14AF712B7F70AE9C.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Missiles);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<GeneralParticleEmitter>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N24DBECE6B62B08BD51DE2FFCFDDA5F54DDED0060FC9DA9018573610D754D1626.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.ParticleEmitters);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<MiscObjects>? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND6EBC62F8EB5330C79CC53DB52A9366CD8A448A9CC840438FFB649CFE426CE43.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Misc);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive GameInfo")]
	internal sealed class tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer> : GameInfo, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private float __index0Value;

		private float __index1Value;

		private ulong __index2Value;

		private Camera? __index3Value;

		private IList<TeamStats>? __index4Value;

		private GameEvents? __index5Value;

		private IList<AIHeroClient>? __index6Value;

		private IList<AIMinionClient>? __index7Value;

		private byte __mask1;

		private IList<AITurretClient>? __index8Value;

		private IList<Building>? __index9Value;

		private IList<Building>? __index10Value;

		private IList<Missile>? __index11Value;

		private IList<GeneralParticleEmitter>? __index12Value;

		private IList<MiscObjects>? __index13Value;

		private string? __index14Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GameInfo);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override float GameTime
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

		public override float PlaybackSpeed
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

		public override ulong UtcTime
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

		public override Camera? Camera
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

		public override IList<TeamStats>? TeamStats
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

		public override GameEvents? GameEvents
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

		public override IList<AIHeroClient>? Heroes
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

		public override IList<AIMinionClient>? Minions
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

		public override IList<AITurretClient>? Turrets
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

		public override IList<Building>? BarracksDampeners
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

		public override IList<Building>? Hqs
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

		public override IList<Missile>? Missiles
		{
			get
			{
				if ((__mask1 & 8) == 0)
				{
					__index11Value = ReadIndex11Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 8);
				}
				return __index11Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<GeneralParticleEmitter>? ParticleEmitters
		{
			get
			{
				if ((__mask1 & 0x10) == 0)
				{
					__index12Value = ReadIndex12Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 16);
				}
				return __index12Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override IList<MiscObjects>? Misc
		{
			get
			{
				if ((__mask1 & 0x20) == 0)
				{
					__index13Value = ReadIndex13Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 32);
				}
				return __index13Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		public override string? GameId
		{
			get
			{
				if ((__mask1 & 0x40) == 0)
				{
					__index14Value = ReadIndex14Value(__buffer, __offset, __vtable, __remainingDepth);
					SerializationHelpers.CombineMask(ref __mask1, 64);
				}
				return __index14Value;
			}
			set
			{
				FSThrow.NotMutable();
			}
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Camera? ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N80227353403F0A2FF4FC23754CEE5A38FF55573382A976C71E6158BE0A98679E.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TeamStats>? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC14A0EE4EC8D77CF82257964E3F863010C3731C2C62919452638B39EC1B2A8CF.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.TeamStats);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GameEvents? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9052A50713F3C09043E0CE106DF6F5B39F67CDB10823AB69BA5709A0CE9D53D0.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AIHeroClient>? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NBFED703FA83B6E9DE1C1FE62C536F5317B2EB484B3BDA89CDF45E18DA865D398.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Heroes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AIMinionClient>? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC26A595523A24B17875FED6DE6040E1026980B5652454680EF2E8F76BDFF6065.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Minions);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AITurretClient>? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2C5A74543636834075C28C79EBCA1FCC66471B13296945F1E2F12F229B73A2B5.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Turrets);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Building>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.BarracksDampeners);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Building>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Hqs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Missile>? ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N691EC907C29AE3492438CAEF32349BADACD2DC821F4C0CDF14AF712B7F70AE9C.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Missiles);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<GeneralParticleEmitter>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N24DBECE6B62B08BD51DE2FFCFDDA5F54DDED0060FC9DA9018573610D754D1626.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.ParticleEmitters);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<MiscObjects>? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND6EBC62F8EB5330C79CC53DB52A9366CD8A448A9CC840438FFB649CFE426CE43.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Misc);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy GameInfo")]
	internal sealed class tableReader_c16154e7befa43f1948bd3a2e7ea084c_Greedy<TInputBuffer> : GameInfo, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private float __index0Value;

		private float __index1Value;

		private ulong __index2Value;

		private Camera? __index3Value;

		private IList<TeamStats>? __index4Value;

		private GameEvents? __index5Value;

		private IList<AIHeroClient>? __index6Value;

		private IList<AIMinionClient>? __index7Value;

		private IList<AITurretClient>? __index8Value;

		private IList<Building>? __index9Value;

		private IList<Building>? __index10Value;

		private IList<Missile>? __index11Value;

		private IList<GeneralParticleEmitter>? __index12Value;

		private IList<MiscObjects>? __index13Value;

		private string? __index14Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GameInfo);

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

		public override float PlaybackSpeed
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

		public override ulong UtcTime
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

		public override Camera? Camera
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

		public override IList<TeamStats>? TeamStats
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

		public override GameEvents? GameEvents
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

		public override IList<AIHeroClient>? Heroes
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

		public override IList<AIMinionClient>? Minions
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

		public override IList<AITurretClient>? Turrets
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

		public override IList<Building>? BarracksDampeners
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

		public override IList<Building>? Hqs
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

		public override IList<Missile>? Missiles
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

		public override IList<GeneralParticleEmitter>? ParticleEmitters
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

		public override IList<MiscObjects>? Misc
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

		public override string? GameId
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c16154e7befa43f1948bd3a2e7ea084c_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
			__index11Value = ReadIndex11Value(buffer, offset, item, remainingDepth);
			__index12Value = ReadIndex12Value(buffer, offset, item, remainingDepth);
			__index13Value = ReadIndex13Value(buffer, offset, item, remainingDepth);
			__index14Value = ReadIndex14Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Camera? ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N80227353403F0A2FF4FC23754CEE5A38FF55573382A976C71E6158BE0A98679E.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TeamStats>? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC14A0EE4EC8D77CF82257964E3F863010C3731C2C62919452638B39EC1B2A8CF.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.TeamStats);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GameEvents? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9052A50713F3C09043E0CE106DF6F5B39F67CDB10823AB69BA5709A0CE9D53D0.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AIHeroClient>? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NBFED703FA83B6E9DE1C1FE62C536F5317B2EB484B3BDA89CDF45E18DA865D398.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Heroes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AIMinionClient>? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC26A595523A24B17875FED6DE6040E1026980B5652454680EF2E8F76BDFF6065.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Minions);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AITurretClient>? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2C5A74543636834075C28C79EBCA1FCC66471B13296945F1E2F12F229B73A2B5.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Turrets);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Building>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.BarracksDampeners);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Building>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Hqs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Missile>? ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N691EC907C29AE3492438CAEF32349BADACD2DC821F4C0CDF14AF712B7F70AE9C.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Missiles);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<GeneralParticleEmitter>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N24DBECE6B62B08BD51DE2FFCFDDA5F54DDED0060FC9DA9018573610D754D1626.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.ParticleEmitters);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<MiscObjects>? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND6EBC62F8EB5330C79CC53DB52A9366CD8A448A9CC840438FFB649CFE426CE43.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Misc);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable GameInfo")]
	internal sealed class tableReader_c16154e7befa43f1948bd3a2e7ea084c_GreedyMutable<TInputBuffer> : GameInfo, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private float __index0Value;

		private float __index1Value;

		private ulong __index2Value;

		private Camera? __index3Value;

		private IList<TeamStats>? __index4Value;

		private GameEvents? __index5Value;

		private IList<AIHeroClient>? __index6Value;

		private IList<AIMinionClient>? __index7Value;

		private IList<AITurretClient>? __index8Value;

		private IList<Building>? __index9Value;

		private IList<Building>? __index10Value;

		private IList<Missile>? __index11Value;

		private IList<GeneralParticleEmitter>? __index12Value;

		private IList<MiscObjects>? __index13Value;

		private string? __index14Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(GameInfo);

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

		public override float PlaybackSpeed
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

		public override ulong UtcTime
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

		public override Camera? Camera
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

		public override IList<TeamStats>? TeamStats
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

		public override GameEvents? GameEvents
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

		public override IList<AIHeroClient>? Heroes
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

		public override IList<AIMinionClient>? Minions
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

		public override IList<AITurretClient>? Turrets
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

		public override IList<Building>? BarracksDampeners
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

		public override IList<Building>? Hqs
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

		public override IList<Missile>? Missiles
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

		public override IList<GeneralParticleEmitter>? ParticleEmitters
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

		public override IList<MiscObjects>? Misc
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

		public override string? GameId
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_c16154e7befa43f1948bd3a2e7ea084c_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
			__index11Value = ReadIndex11Value(buffer, offset, item, remainingDepth);
			__index12Value = ReadIndex12Value(buffer, offset, item, remainingDepth);
			__index13Value = ReadIndex13Value(buffer, offset, item, remainingDepth);
			__index14Value = ReadIndex14Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static float ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return 0f;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static ulong ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return 0uL;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static Camera? ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N80227353403F0A2FF4FC23754CEE5A38FF55573382A976C71E6158BE0A98679E.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<TeamStats>? ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC14A0EE4EC8D77CF82257964E3F863010C3731C2C62919452638B39EC1B2A8CF.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.TeamStats);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static GameEvents? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9052A50713F3C09043E0CE106DF6F5B39F67CDB10823AB69BA5709A0CE9D53D0.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AIHeroClient>? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NBFED703FA83B6E9DE1C1FE62C536F5317B2EB484B3BDA89CDF45E18DA865D398.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Heroes);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AIMinionClient>? ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC26A595523A24B17875FED6DE6040E1026980B5652454680EF2E8F76BDFF6065.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Minions);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<AITurretClient>? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2C5A74543636834075C28C79EBCA1FCC66471B13296945F1E2F12F229B73A2B5.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Turrets);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Building>? ReadIndex9Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 9);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.BarracksDampeners);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Building>? ReadIndex10Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 10);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Hqs);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<Missile>? ReadIndex11Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 11);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N691EC907C29AE3492438CAEF32349BADACD2DC821F4C0CDF14AF712B7F70AE9C.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Missiles);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<GeneralParticleEmitter>? ReadIndex12Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 12);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N24DBECE6B62B08BD51DE2FFCFDDA5F54DDED0060FC9DA9018573610D754D1626.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.ParticleEmitters);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<MiscObjects>? ReadIndex13Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 13);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.ND6EBC62F8EB5330C79CC53DB52A9366CD8A448A9CC840438FFB649CFE426CE43.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_746921bbc0e141509c109086e0a3728b.Misc);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex14Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 14);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_746921bbc0e141509c109086e0a3728b
	{
		public static readonly TableFieldContext GameTime = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.GameTime", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PlaybackSpeed = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.PlaybackSpeed", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext UtcTime = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.UtcTime", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Camera = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.Camera", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext TeamStats = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.TeamStats", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext GameEvents = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.GameEvents", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Heroes = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.Heroes", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Minions = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.Minions", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Turrets = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.Turrets", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext BarracksDampeners = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.BarracksDampeners", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Hqs = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.Hqs", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Missiles = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.Missiles", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ParticleEmitters = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.ParticleEmitters", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Misc = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.Misc", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext GameId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Snapshot.GameInfo.GameId", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(GameInfo value)
	{
		int num = 155;
		Camera camera = value.Camera;
		if (camera != null)
		{
			num += FlatSharp.Compiler.Generated.N80227353403F0A2FF4FC23754CEE5A38FF55573382A976C71E6158BE0A98679E.Helpers.GetMaxSize(camera);
		}
		IList<TeamStats> teamStats = value.TeamStats;
		if (teamStats != null)
		{
			num += FlatSharp.Compiler.Generated.NC14A0EE4EC8D77CF82257964E3F863010C3731C2C62919452638B39EC1B2A8CF.Helpers.GetMaxSize(teamStats);
		}
		GameEvents gameEvents = value.GameEvents;
		if (gameEvents != null)
		{
			num += FlatSharp.Compiler.Generated.N9052A50713F3C09043E0CE106DF6F5B39F67CDB10823AB69BA5709A0CE9D53D0.Helpers.GetMaxSize(gameEvents);
		}
		IList<AIHeroClient> heroes = value.Heroes;
		if (heroes != null)
		{
			num += FlatSharp.Compiler.Generated.NBFED703FA83B6E9DE1C1FE62C536F5317B2EB484B3BDA89CDF45E18DA865D398.Helpers.GetMaxSize(heroes);
		}
		IList<AIMinionClient> minions = value.Minions;
		if (minions != null)
		{
			num += FlatSharp.Compiler.Generated.NC26A595523A24B17875FED6DE6040E1026980B5652454680EF2E8F76BDFF6065.Helpers.GetMaxSize(minions);
		}
		IList<AITurretClient> turrets = value.Turrets;
		if (turrets != null)
		{
			num += FlatSharp.Compiler.Generated.N2C5A74543636834075C28C79EBCA1FCC66471B13296945F1E2F12F229B73A2B5.Helpers.GetMaxSize(turrets);
		}
		IList<Building> barracksDampeners = value.BarracksDampeners;
		if (barracksDampeners != null)
		{
			num += FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.GetMaxSize(barracksDampeners);
		}
		IList<Building> hqs = value.Hqs;
		if (hqs != null)
		{
			num += FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.GetMaxSize(hqs);
		}
		IList<Missile> missiles = value.Missiles;
		if (missiles != null)
		{
			num += FlatSharp.Compiler.Generated.N691EC907C29AE3492438CAEF32349BADACD2DC821F4C0CDF14AF712B7F70AE9C.Helpers.GetMaxSize(missiles);
		}
		IList<GeneralParticleEmitter> particleEmitters = value.ParticleEmitters;
		if (particleEmitters != null)
		{
			num += FlatSharp.Compiler.Generated.N24DBECE6B62B08BD51DE2FFCFDDA5F54DDED0060FC9DA9018573610D754D1626.Helpers.GetMaxSize(particleEmitters);
		}
		IList<MiscObjects> misc = value.Misc;
		if (misc != null)
		{
			num += FlatSharp.Compiler.Generated.ND6EBC62F8EB5330C79CC53DB52A9366CD8A448A9CC840438FFB649CFE426CE43.Helpers.GetMaxSize(misc);
		}
		string gameId = value.GameId;
		if (gameId != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(gameId);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, GameInfo value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(117, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[34];
		float gameTime = value.GameTime;
		float playbackSpeed = value.PlaybackSpeed;
		ulong utcTime = value.UtcTime;
		Camera camera = value.Camera;
		IList<TeamStats> teamStats = value.TeamStats;
		GameEvents gameEvents = value.GameEvents;
		IList<AIHeroClient> heroes = value.Heroes;
		IList<AIMinionClient> minions = value.Minions;
		IList<AITurretClient> turrets = value.Turrets;
		IList<Building> barracksDampeners = value.BarracksDampeners;
		IList<Building> hqs = value.Hqs;
		IList<Missile> missiles = value.Missiles;
		IList<GeneralParticleEmitter> particleEmitters = value.ParticleEmitters;
		IList<MiscObjects> misc = value.Misc;
		string gameId = value.GameId;
		int num4 = num;
		if (utcTime != 0L)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 8);
			num4 = num2;
			num2 += 8;
			FlatSharp.Compiler.Generated.ND5802027154E3862E3DC1ECBFAC480E0946C1D3F83FAE1301753B92402055A9E.Helpers.Serialize(spanWriter, span, utcTime, num4);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 8);
		int num5 = num;
		if (gameId != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			num3 = 34;
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 32);
		int num6 = num;
		if (misc != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (32 > num3)
			{
				num3 = 32;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 30);
		int num7 = num;
		if (particleEmitters != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			if (30 > num3)
			{
				num3 = 30;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 28);
		int num8 = num;
		if (missiles != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			if (28 > num3)
			{
				num3 = 28;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 26);
		int num9 = num;
		if (hqs != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			if (26 > num3)
			{
				num3 = 26;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 24);
		int num10 = num;
		if (barracksDampeners != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
			if (24 > num3)
			{
				num3 = 24;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 22);
		int num11 = num;
		if (turrets != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num11 = num2;
			num2 += 4;
			if (22 > num3)
			{
				num3 = 22;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 20);
		int num12 = num;
		if (minions != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num12 = num2;
			num2 += 4;
			if (20 > num3)
			{
				num3 = 20;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 18);
		int num13 = num;
		if (heroes != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num13 = num2;
			num2 += 4;
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)(num13 - num), 16);
		int num14 = num;
		if (gameEvents != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num14 = num2;
			num2 += 4;
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)(num14 - num), 14);
		int num15 = num;
		if (teamStats != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num15 = num2;
			num2 += 4;
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span14 = span2;
		spanWriter.WriteUShort(span14, (ushort)(num15 - num), 12);
		int num16 = num;
		if (camera != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num16 = num2;
			num2 += 4;
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span15 = span2;
		spanWriter.WriteUShort(span15, (ushort)(num16 - num), 10);
		int num17 = num;
		if (playbackSpeed != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num17 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, playbackSpeed, num17);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span16 = span2;
		spanWriter.WriteUShort(span16, (ushort)(num17 - num), 6);
		int num18 = num;
		if (gameTime != 0f)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num18 = num2;
			num2 += 4;
			FlatSharp.Compiler.Generated.NCFA4E1D328DE890B0729499CC6DFD44622EA2719E2FA0454F61F6686B802FB45.Helpers.Serialize(spanWriter, span, gameTime, num18);
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span17 = span2;
		spanWriter.WriteUShort(span17, (ushort)(num18 - num), 4);
		int num19 = num2 - num;
		context.Offset -= 117 - num19;
		Span<byte> span18 = span2;
		spanWriter.WriteUShort(span18, (ushort)num3, 0);
		Span<byte> span19 = span2;
		spanWriter.WriteUShort(span19, (ushort)num19, 2);
		int num20 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num20, num);
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, gameId, num5, context, tableMetadata_746921bbc0e141509c109086e0a3728b.GameId);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.ND6EBC62F8EB5330C79CC53DB52A9366CD8A448A9CC840438FFB649CFE426CE43.Helpers.Serialize(spanWriter, span, misc, num6, context);
		}
		if (num7 != num)
		{
			FlatSharp.Compiler.Generated.N24DBECE6B62B08BD51DE2FFCFDDA5F54DDED0060FC9DA9018573610D754D1626.Helpers.Serialize(spanWriter, span, particleEmitters, num7, context);
		}
		if (num8 != num)
		{
			FlatSharp.Compiler.Generated.N691EC907C29AE3492438CAEF32349BADACD2DC821F4C0CDF14AF712B7F70AE9C.Helpers.Serialize(spanWriter, span, missiles, num8, context);
		}
		if (num9 != num)
		{
			FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.Serialize(spanWriter, span, hqs, num9, context);
		}
		if (num10 != num)
		{
			FlatSharp.Compiler.Generated.N9440120DF7E52A18C649E716B4EA1A2AFA91D4CE77790D6E7FD7D6A6FBE2E8FF.Helpers.Serialize(spanWriter, span, barracksDampeners, num10, context);
		}
		if (num11 != num)
		{
			FlatSharp.Compiler.Generated.N2C5A74543636834075C28C79EBCA1FCC66471B13296945F1E2F12F229B73A2B5.Helpers.Serialize(spanWriter, span, turrets, num11, context);
		}
		if (num12 != num)
		{
			FlatSharp.Compiler.Generated.NC26A595523A24B17875FED6DE6040E1026980B5652454680EF2E8F76BDFF6065.Helpers.Serialize(spanWriter, span, minions, num12, context);
		}
		if (num13 != num)
		{
			FlatSharp.Compiler.Generated.NBFED703FA83B6E9DE1C1FE62C536F5317B2EB484B3BDA89CDF45E18DA865D398.Helpers.Serialize(spanWriter, span, heroes, num13, context);
		}
		if (num14 != num)
		{
			FlatSharp.Compiler.Generated.N9052A50713F3C09043E0CE106DF6F5B39F67CDB10823AB69BA5709A0CE9D53D0.Helpers.Serialize(spanWriter, span, gameEvents, num14, context);
		}
		if (num15 != num)
		{
			FlatSharp.Compiler.Generated.NC14A0EE4EC8D77CF82257964E3F863010C3731C2C62919452638B39EC1B2A8CF.Helpers.Serialize(spanWriter, span, teamStats, num15, context);
		}
		if (num16 != num)
		{
			FlatSharp.Compiler.Generated.N80227353403F0A2FF4FC23754CEE5A38FF55573382A976C71E6158BE0A98679E.Helpers.Serialize(spanWriter, span, camera, num16, context);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c16154e7befa43f1948bd3a2e7ea084c_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c16154e7befa43f1948bd3a2e7ea084c_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c16154e7befa43f1948bd3a2e7ea084c_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c16154e7befa43f1948bd3a2e7ea084c_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c16154e7befa43f1948bd3a2e7ea084c_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_c16154e7befa43f1948bd3a2e7ea084c_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_c16154e7befa43f1948bd3a2e7ea084c_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
