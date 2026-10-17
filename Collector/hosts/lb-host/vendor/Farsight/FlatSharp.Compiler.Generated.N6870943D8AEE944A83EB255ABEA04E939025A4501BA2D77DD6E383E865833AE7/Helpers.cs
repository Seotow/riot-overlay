using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.N1E3EF9587AB2AADC68D2E4B7C3F0A89A26D1E41B01A1EF25D2E0032DE5DB3952;
using FlatSharp.Compiler.Generated.N2FB321CB2C2689D401D2AC452EEF32A01422A0C19E537F34FD8EC01D0FC4B96E;
using FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127;
using FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.N8090398D1B77AAA8F41A5F2DB9186E734B55A163ABC3E85F13E84319C39DEF0C;
using FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73;
using FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.N6870943D8AEE944A83EB255ABEA04E939025A4501BA2D77DD6E383E865833AE7;

internal static class Helpers
{
	[DebuggerDisplay("Lazy CinematicProp")]
	internal sealed class tableReader_d8e7163e81db413995fc887d97a4ac5e_Lazy<TInputBuffer> : CinematicProp, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicProp);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override string? Id
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

		public override PropKind Kind
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

		public override BoundTextSource Source
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

		public override TextFormat Format
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

		public override TeamSlot TeamSlot
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

		public override IList<CinematicTrack>? Tracks
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

		public override PropStyle? Style
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

		public override PlayerSlot PlayerSlot
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

		public override string? ModelAsset
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_d8e7163e81db413995fc887d97a4ac5e_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PropKind ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return PropKind.BoundText;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2FB321CB2C2689D401D2AC452EEF32A01422A0C19E537F34FD8EC01D0FC4B96E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static BoundTextSource ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return BoundTextSource.Team1Name;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TextFormat ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return TextFormat.Default;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TeamSlot ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return TeamSlot.Team1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicTrack>? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8090398D1B77AAA8F41A5F2DB9186E734B55A163ABC3E85F13E84319C39DEF0C.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_9cb01e4d830046ceacc7c4b447aad408.Tracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PropStyle? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E3EF9587AB2AADC68D2E4B7C3F0A89A26D1E41B01A1EF25D2E0032DE5DB3952.Helpers.Parse_Lazy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PlayerSlot ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return PlayerSlot.Player1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive CinematicProp")]
	internal sealed class tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer> : CinematicProp, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTableGeneric __vtable;

		private byte __mask0;

		private string? __index0Value;

		private PropKind __index1Value;

		private BoundTextSource __index2Value;

		private TextFormat __index3Value;

		private TeamSlot __index4Value;

		private IList<CinematicTrack>? __index5Value;

		private PropStyle? __index6Value;

		private PlayerSlot __index7Value;

		private byte __mask1;

		private string? __index8Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicProp);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override string? Id
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

		public override PropKind Kind
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

		public override BoundTextSource Source
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

		public override TextFormat Format
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

		public override TeamSlot TeamSlot
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

		public override IList<CinematicTrack>? Tracks
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

		public override PropStyle? Style
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

		public override PlayerSlot PlayerSlot
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

		public override string? ModelAsset
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTableGeneric.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PropKind ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return PropKind.BoundText;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2FB321CB2C2689D401D2AC452EEF32A01422A0C19E537F34FD8EC01D0FC4B96E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static BoundTextSource ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return BoundTextSource.Team1Name;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TextFormat ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return TextFormat.Default;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TeamSlot ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return TeamSlot.Team1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicTrack>? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8090398D1B77AAA8F41A5F2DB9186E734B55A163ABC3E85F13E84319C39DEF0C.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_9cb01e4d830046ceacc7c4b447aad408.Tracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PropStyle? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E3EF9587AB2AADC68D2E4B7C3F0A89A26D1E41B01A1EF25D2E0032DE5DB3952.Helpers.Parse_Progressive(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PlayerSlot ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return PlayerSlot.Player1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy CinematicProp")]
	internal sealed class tableReader_d8e7163e81db413995fc887d97a4ac5e_Greedy<TInputBuffer> : CinematicProp, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private string? __index0Value;

		private PropKind __index1Value;

		private BoundTextSource __index2Value;

		private TextFormat __index3Value;

		private TeamSlot __index4Value;

		private IList<CinematicTrack>? __index5Value;

		private PropStyle? __index6Value;

		private PlayerSlot __index7Value;

		private string? __index8Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicProp);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override string? Id
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

		public override PropKind Kind
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

		public override BoundTextSource Source
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

		public override TextFormat Format
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

		public override TeamSlot TeamSlot
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

		public override IList<CinematicTrack>? Tracks
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

		public override PropStyle? Style
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

		public override PlayerSlot PlayerSlot
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

		public override string? ModelAsset
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_d8e7163e81db413995fc887d97a4ac5e_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
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
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PropKind ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return PropKind.BoundText;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2FB321CB2C2689D401D2AC452EEF32A01422A0C19E537F34FD8EC01D0FC4B96E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static BoundTextSource ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return BoundTextSource.Team1Name;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TextFormat ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return TextFormat.Default;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TeamSlot ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return TeamSlot.Team1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicTrack>? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8090398D1B77AAA8F41A5F2DB9186E734B55A163ABC3E85F13E84319C39DEF0C.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_9cb01e4d830046ceacc7c4b447aad408.Tracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PropStyle? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E3EF9587AB2AADC68D2E4B7C3F0A89A26D1E41B01A1EF25D2E0032DE5DB3952.Helpers.Parse_Greedy(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PlayerSlot ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return PlayerSlot.Player1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable CinematicProp")]
	internal sealed class tableReader_d8e7163e81db413995fc887d97a4ac5e_GreedyMutable<TInputBuffer> : CinematicProp, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private string? __index0Value;

		private PropKind __index1Value;

		private BoundTextSource __index2Value;

		private TextFormat __index3Value;

		private TeamSlot __index4Value;

		private IList<CinematicTrack>? __index5Value;

		private PropStyle? __index6Value;

		private PlayerSlot __index7Value;

		private string? __index8Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(CinematicProp);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override string? Id
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

		public override PropKind Kind
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

		public override BoundTextSource Source
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

		public override TextFormat Format
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

		public override TeamSlot TeamSlot
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

		public override IList<CinematicTrack>? Tracks
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

		public override PropStyle? Style
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

		public override PlayerSlot PlayerSlot
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

		public override string? ModelAsset
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_d8e7163e81db413995fc887d97a4ac5e_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
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
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 0);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PropKind ReadIndex1Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return PropKind.BoundText;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N2FB321CB2C2689D401D2AC452EEF32A01422A0C19E537F34FD8EC01D0FC4B96E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static BoundTextSource ReadIndex2Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return BoundTextSource.Team1Name;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TextFormat ReadIndex3Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return TextFormat.Default;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TeamSlot ReadIndex4Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return TeamSlot.Team1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicTrack>? ReadIndex5Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N8090398D1B77AAA8F41A5F2DB9186E734B55A163ABC3E85F13E84319C39DEF0C.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_9cb01e4d830046ceacc7c4b447aad408.Tracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PropStyle? ReadIndex6Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1E3EF9587AB2AADC68D2E4B7C3F0A89A26D1E41B01A1EF25D2E0032DE5DB3952.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PlayerSlot ReadIndex7Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return PlayerSlot.Player1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex8Value(TInputBuffer buffer, int offset, VTableGeneric vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 8);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_9cb01e4d830046ceacc7c4b447aad408
	{
		public static readonly TableFieldContext Id = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicProp.Id", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Kind = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicProp.Kind", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Source = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicProp.Source", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Format = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicProp.Format", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext TeamSlot = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicProp.TeamSlot", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Tracks = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicProp.Tracks", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Style = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicProp.Style", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PlayerSlot = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicProp.PlayerSlot", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext ModelAsset = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.CinematicProp.ModelAsset", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(CinematicProp value)
	{
		int num = 63;
		string id = value.Id;
		if (id != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(id);
		}
		IList<CinematicTrack> tracks = value.Tracks;
		if (tracks != null)
		{
			num += FlatSharp.Compiler.Generated.N8090398D1B77AAA8F41A5F2DB9186E734B55A163ABC3E85F13E84319C39DEF0C.Helpers.GetMaxSize(tracks);
		}
		PropStyle style = value.Style;
		if (style != null)
		{
			num += FlatSharp.Compiler.Generated.N1E3EF9587AB2AADC68D2E4B7C3F0A89A26D1E41B01A1EF25D2E0032DE5DB3952.Helpers.GetMaxSize(style);
		}
		string modelAsset = value.ModelAsset;
		if (modelAsset != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(modelAsset);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, CinematicProp value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(37, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[22];
		string id = value.Id;
		PropKind kind = value.Kind;
		BoundTextSource source = value.Source;
		TextFormat format = value.Format;
		TeamSlot teamSlot = value.TeamSlot;
		IList<CinematicTrack> tracks = value.Tracks;
		PropStyle style = value.Style;
		PlayerSlot playerSlot = value.PlayerSlot;
		string modelAsset = value.ModelAsset;
		int num4 = num;
		if (modelAsset != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			num3 = 22;
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 20);
		int num5 = num;
		if (style != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 16);
		int num6 = num;
		if (tracks != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 14);
		int num7 = num;
		if (id != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 4);
		int num8 = num;
		if (playerSlot != PlayerSlot.Player1)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num8 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA.Helpers.Serialize(spanWriter, span, playerSlot, num8);
			if (20 > num3)
			{
				num3 = 20;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 18);
		int num9 = num;
		if (teamSlot != TeamSlot.Team1)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num9 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822.Helpers.Serialize(spanWriter, span, teamSlot, num9);
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 12);
		int num10 = num;
		if (format != TextFormat.Default)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num10 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73.Helpers.Serialize(spanWriter, span, format, num10);
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 10);
		int num11 = num;
		if (source != BoundTextSource.Team1Name)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num11 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127.Helpers.Serialize(spanWriter, span, source, num11);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 8);
		int num12 = num;
		if (kind != PropKind.BoundText)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num12 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N2FB321CB2C2689D401D2AC452EEF32A01422A0C19E537F34FD8EC01D0FC4B96E.Helpers.Serialize(spanWriter, span, kind, num12);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)(num12 - num), 6);
		int num13 = num2 - num;
		context.Offset -= 37 - num13;
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)num3, 0);
		Span<byte> span13 = span2;
		spanWriter.WriteUShort(span13, (ushort)num13, 2);
		int num14 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num14, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, modelAsset, num4, context, tableMetadata_9cb01e4d830046ceacc7c4b447aad408.ModelAsset);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.N1E3EF9587AB2AADC68D2E4B7C3F0A89A26D1E41B01A1EF25D2E0032DE5DB3952.Helpers.Serialize(spanWriter, span, style, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.N8090398D1B77AAA8F41A5F2DB9186E734B55A163ABC3E85F13E84319C39DEF0C.Helpers.Serialize(spanWriter, span, tracks, num6, context);
		}
		if (num7 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, id, num7, context, tableMetadata_9cb01e4d830046ceacc7c4b447aad408.Id);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_d8e7163e81db413995fc887d97a4ac5e_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_d8e7163e81db413995fc887d97a4ac5e_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_d8e7163e81db413995fc887d97a4ac5e_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_d8e7163e81db413995fc887d97a4ac5e_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_d8e7163e81db413995fc887d97a4ac5e_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_d8e7163e81db413995fc887d97a4ac5e_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_d8e7163e81db413995fc887d97a4ac5e_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
