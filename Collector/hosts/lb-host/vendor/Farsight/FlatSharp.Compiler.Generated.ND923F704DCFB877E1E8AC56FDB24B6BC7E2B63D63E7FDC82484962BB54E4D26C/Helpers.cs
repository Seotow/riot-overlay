using System;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127;
using FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73;
using FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.ND923F704DCFB877E1E8AC56FDB24B6BC7E2B63D63E7FDC82484962BB54E4D26C;

internal static class Helpers
{
	[DebuggerDisplay("Lazy AddBoundTextRequest")]
	internal sealed class tableReader_0393ed5aa613488480a95c13278737ca_Lazy<TInputBuffer> : AddBoundTextRequest, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AddBoundTextRequest);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override string? CinematicId
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

		public override BoundTextSource Source
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

		public override TextFormat Format
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

		public override TeamSlot TeamSlot
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

		public override PlayerSlot PlayerSlot
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

		public override bool PlayerBinding
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_0393ed5aa613488480a95c13278737ca_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
		private static BoundTextSource ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return BoundTextSource.Team1Name;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TextFormat ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return TextFormat.Default;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TeamSlot ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return TeamSlot.Team1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PlayerSlot ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return PlayerSlot.Player1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive AddBoundTextRequest")]
	internal sealed class tableReader_0393ed5aa613488480a95c13278737ca_Progressive<TInputBuffer> : AddBoundTextRequest, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		private byte __mask0;

		private string? __index0Value;

		private BoundTextSource __index1Value;

		private TextFormat __index2Value;

		private TeamSlot __index3Value;

		private PlayerSlot __index4Value;

		private bool __index5Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AddBoundTextRequest);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => __buffer;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => true;

		public override string? CinematicId
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

		public override BoundTextSource Source
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

		public override TextFormat Format
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

		public override TeamSlot TeamSlot
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

		public override PlayerSlot PlayerSlot
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

		public override bool PlayerBinding
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_0393ed5aa613488480a95c13278737ca_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			__buffer = buffer;
			__offset = offset;
			__remainingDepth = remainingDepth;
			VTable8.Create(buffer, offset, out __vtable);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
		private static BoundTextSource ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return BoundTextSource.Team1Name;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TextFormat ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return TextFormat.Default;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TeamSlot ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return TeamSlot.Team1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PlayerSlot ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return PlayerSlot.Player1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy AddBoundTextRequest")]
	internal sealed class tableReader_0393ed5aa613488480a95c13278737ca_Greedy<TInputBuffer> : AddBoundTextRequest, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private string? __index0Value;

		private BoundTextSource __index1Value;

		private TextFormat __index2Value;

		private TeamSlot __index3Value;

		private PlayerSlot __index4Value;

		private bool __index5Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AddBoundTextRequest);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override string? CinematicId
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

		public override BoundTextSource Source
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

		public override TextFormat Format
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

		public override TeamSlot TeamSlot
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

		public override PlayerSlot PlayerSlot
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

		public override bool PlayerBinding
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_0393ed5aa613488480a95c13278737ca_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
		private static BoundTextSource ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return BoundTextSource.Team1Name;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TextFormat ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return TextFormat.Default;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TeamSlot ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return TeamSlot.Team1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PlayerSlot ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return PlayerSlot.Player1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable AddBoundTextRequest")]
	internal sealed class tableReader_0393ed5aa613488480a95c13278737ca_GreedyMutable<TInputBuffer> : AddBoundTextRequest, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private string? __index0Value;

		private BoundTextSource __index1Value;

		private TextFormat __index2Value;

		private TeamSlot __index3Value;

		private PlayerSlot __index4Value;

		private bool __index5Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(AddBoundTextRequest);

		FlatBufferDeserializationContext IFlatBufferDeserializedObject.DeserializationContext => __CtorContext;

		IInputBuffer? IFlatBufferDeserializedObject.InputBuffer => null;

		bool IFlatBufferDeserializedObject.CanSerializeWithMemoryCopy => false;

		public override string? CinematicId
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

		public override BoundTextSource Source
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

		public override TextFormat Format
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

		public override TeamSlot TeamSlot
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

		public override PlayerSlot PlayerSlot
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

		public override bool PlayerBinding
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_0393ed5aa613488480a95c13278737ca_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			OnFlatSharpDeserialized(__CtorContext);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex0Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
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
		private static BoundTextSource ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return BoundTextSource.Team1Name;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TextFormat ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return TextFormat.Default;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static TeamSlot ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return TeamSlot.Team1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static PlayerSlot ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return PlayerSlot.Player1;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_2996ab9da1a142bb81e7b9f74967e78f
	{
		public static readonly TableFieldContext CinematicId = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.AddBoundTextRequest.CinematicId", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Source = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.AddBoundTextRequest.Source", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Format = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.AddBoundTextRequest.Format", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext TeamSlot = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.AddBoundTextRequest.TeamSlot", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PlayerSlot = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.AddBoundTextRequest.PlayerSlot", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext PlayerBinding = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.AddBoundTextRequest.PlayerBinding", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(AddBoundTextRequest value)
	{
		int num = 36;
		string cinematicId = value.CinematicId;
		if (cinematicId != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(cinematicId);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, AddBoundTextRequest value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(16, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[16];
		string cinematicId = value.CinematicId;
		BoundTextSource source = value.Source;
		TextFormat format = value.Format;
		TeamSlot teamSlot = value.TeamSlot;
		PlayerSlot playerSlot = value.PlayerSlot;
		bool playerBinding = value.PlayerBinding;
		int num4 = num;
		if (cinematicId != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 4);
		int num5 = num;
		if (playerBinding)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num5 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, playerBinding, num5);
			num3 = 16;
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 14);
		int num6 = num;
		if (playerSlot != PlayerSlot.Player1)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num6 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N5D2F919AD5D1643153BDF018C78556280DD450C44DC26E10267E7A110764B3AA.Helpers.Serialize(spanWriter, span, playerSlot, num6);
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 12);
		int num7 = num;
		if (teamSlot != TeamSlot.Team1)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num7 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NC681018D430FA3B79F633E2650F0DD9FD2A02869635B0383E5122A931444E822.Helpers.Serialize(spanWriter, span, teamSlot, num7);
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 10);
		int num8 = num;
		if (format != TextFormat.Default)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num8 = num2;
			num2++;
			FlatSharp.Compiler.Generated.NB0C686BAC3BD05121F014CB35836D67C338E8E0D9F36F8E1F9CDA80C05421C73.Helpers.Serialize(spanWriter, span, format, num8);
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 8);
		int num9 = num;
		if (source != BoundTextSource.Team1Name)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num9 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N3D5D63D7C10DB64ED6D39E19589B3391CF52F331F0183C68BBAD10EEB9D55127.Helpers.Serialize(spanWriter, span, source, num9);
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 6);
		int num10 = num2 - num;
		context.Offset -= 16 - num10;
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)num3, 0);
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)num10, 2);
		int num11 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num11, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, cinematicId, num4, context, tableMetadata_2996ab9da1a142bb81e7b9f74967e78f.CinematicId);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_0393ed5aa613488480a95c13278737ca_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_0393ed5aa613488480a95c13278737ca_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_0393ed5aa613488480a95c13278737ca_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_0393ed5aa613488480a95c13278737ca_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_0393ed5aa613488480a95c13278737ca_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_0393ed5aa613488480a95c13278737ca_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_0393ed5aa613488480a95c13278737ca_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_0393ed5aa613488480a95c13278737ca_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
