using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72;
using FlatSharp.Compiler.Generated.N4CFCEA029A77422A168508762952090A3C3269E1B690082A0B33089E74E992A8;
using FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E;
using FlatSharp.Compiler.Generated.NB4DA8001DE10551D82288DAC8DB0DF78985132A131AC3E24E1E0CF5D4599A844;
using FlatSharp.Compiler.Generated.NDEB3DB9F7AA13185E4D6F6836E4E9EA74E52FEC3BE7639BA7EA35B7ED3815794;
using FlatSharp.Compiler.Generated.NF29B84F765342CF782A6B0C7502B36BA7258A41E254D296DB7CD063C18E73855;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated.NA0DB75AEFD3B890080AA25971C19D4FBC47079AFB7E1C63BF09C85CACABF7CEB;

internal static class Helpers
{
	[DebuggerDisplay("Lazy Cinematic")]
	internal sealed class tableReader_a88be26b47f44da98aff1a3a7a9581e5_Lazy<TInputBuffer> : Cinematic, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Lazy);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Cinematic);

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

		public override string? Name
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

		public override string? CameraSequenceName
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

		public override IList<CinematicProp>? Props
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

		public override IList<CinematicHudTrack>? HudTracks
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

		public override IList<CinematicMarker>? Markers
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

		public override IList<CinematicOverlayTrack>? OverlayTracks
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

		public override bool HideOverlays
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a88be26b47f44da98aff1a3a7a9581e5_Lazy(TInputBuffer buffer, int offset, short remainingDepth)
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
		private static string? ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicProp>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4CFCEA029A77422A168508762952090A3C3269E1B690082A0B33089E74E992A8.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.Props);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicHudTrack>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB4DA8001DE10551D82288DAC8DB0DF78985132A131AC3E24E1E0CF5D4599A844.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.HudTracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicMarker>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF29B84F765342CF782A6B0C7502B36BA7258A41E254D296DB7CD063C18E73855.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.Markers);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicOverlayTrack>? ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDEB3DB9F7AA13185E4D6F6836E4E9EA74E52FEC3BE7639BA7EA35B7ED3815794.Helpers.Parse_Lazy(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.OverlayTracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex7Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Progressive Cinematic")]
	internal sealed class tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer> : Cinematic, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Progressive);

		private TInputBuffer __buffer;

		private int __offset;

		private short __remainingDepth;

		private VTable8 __vtable;

		private byte __mask0;

		private string? __index0Value;

		private string? __index1Value;

		private string? __index2Value;

		private IList<CinematicProp>? __index3Value;

		private IList<CinematicHudTrack>? __index4Value;

		private IList<CinematicMarker>? __index5Value;

		private IList<CinematicOverlayTrack>? __index6Value;

		private bool __index7Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Cinematic);

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

		public override string? Name
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

		public override string? CameraSequenceName
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

		public override IList<CinematicProp>? Props
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

		public override IList<CinematicHudTrack>? HudTracks
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

		public override IList<CinematicMarker>? Markers
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

		public override IList<CinematicOverlayTrack>? OverlayTracks
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

		public override bool HideOverlays
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive(TInputBuffer buffer, int offset, short remainingDepth)
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
		private static string? ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicProp>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4CFCEA029A77422A168508762952090A3C3269E1B690082A0B33089E74E992A8.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.Props);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicHudTrack>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB4DA8001DE10551D82288DAC8DB0DF78985132A131AC3E24E1E0CF5D4599A844.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.HudTracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicMarker>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF29B84F765342CF782A6B0C7502B36BA7258A41E254D296DB7CD063C18E73855.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.Markers);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicOverlayTrack>? ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDEB3DB9F7AA13185E4D6F6836E4E9EA74E52FEC3BE7639BA7EA35B7ED3815794.Helpers.Parse_Progressive(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.OverlayTracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex7Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("Greedy Cinematic")]
	internal sealed class tableReader_a88be26b47f44da98aff1a3a7a9581e5_Greedy<TInputBuffer> : Cinematic, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.Greedy);

		private string? __index0Value;

		private string? __index1Value;

		private string? __index2Value;

		private IList<CinematicProp>? __index3Value;

		private IList<CinematicHudTrack>? __index4Value;

		private IList<CinematicMarker>? __index5Value;

		private IList<CinematicOverlayTrack>? __index6Value;

		private bool __index7Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Cinematic);

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

		public override string? Name
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

		public override string? CameraSequenceName
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

		public override IList<CinematicProp>? Props
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

		public override IList<CinematicHudTrack>? HudTracks
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

		public override IList<CinematicMarker>? Markers
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

		public override IList<CinematicOverlayTrack>? OverlayTracks
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

		public override bool HideOverlays
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a88be26b47f44da98aff1a3a7a9581e5_Greedy(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, item, remainingDepth);
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
		private static string? ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicProp>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4CFCEA029A77422A168508762952090A3C3269E1B690082A0B33089E74E992A8.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.Props);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicHudTrack>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB4DA8001DE10551D82288DAC8DB0DF78985132A131AC3E24E1E0CF5D4599A844.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.HudTracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicMarker>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF29B84F765342CF782A6B0C7502B36BA7258A41E254D296DB7CD063C18E73855.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.Markers);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicOverlayTrack>? ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDEB3DB9F7AA13185E4D6F6836E4E9EA74E52FEC3BE7639BA7EA35B7ED3815794.Helpers.Parse_Greedy(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.OverlayTracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex7Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	[DebuggerDisplay("GreedyMutable Cinematic")]
	internal sealed class tableReader_a88be26b47f44da98aff1a3a7a9581e5_GreedyMutable<TInputBuffer> : Cinematic, IFlatBufferDeserializedObject where TInputBuffer : IInputBuffer
	{
		private static readonly FlatBufferDeserializationContext __CtorContext = new FlatBufferDeserializationContext(FlatBufferDeserializationOption.GreedyMutable);

		private string? __index0Value;

		private string? __index1Value;

		private string? __index2Value;

		private IList<CinematicProp>? __index3Value;

		private IList<CinematicHudTrack>? __index4Value;

		private IList<CinematicMarker>? __index5Value;

		private IList<CinematicOverlayTrack>? __index6Value;

		private bool __index7Value;

		Type IFlatBufferDeserializedObject.TableOrStructType => typeof(Cinematic);

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

		public override string? Name
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

		public override string? CameraSequenceName
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

		public override IList<CinematicProp>? Props
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

		public override IList<CinematicHudTrack>? HudTracks
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

		public override IList<CinematicMarker>? Markers
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

		public override IList<CinematicOverlayTrack>? OverlayTracks
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

		public override bool HideOverlays
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

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		[SetsRequiredMembers]
		public tableReader_a88be26b47f44da98aff1a3a7a9581e5_GreedyMutable(TInputBuffer buffer, int offset, short remainingDepth)
			: base(__CtorContext)
		{
			VTable8.Create(buffer, offset, out var item);
			__index0Value = ReadIndex0Value(buffer, offset, item, remainingDepth);
			__index1Value = ReadIndex1Value(buffer, offset, item, remainingDepth);
			__index2Value = ReadIndex2Value(buffer, offset, item, remainingDepth);
			__index3Value = ReadIndex3Value(buffer, offset, item, remainingDepth);
			__index4Value = ReadIndex4Value(buffer, offset, item, remainingDepth);
			__index5Value = ReadIndex5Value(buffer, offset, item, remainingDepth);
			__index6Value = ReadIndex6Value(buffer, offset, item, remainingDepth);
			__index7Value = ReadIndex7Value(buffer, offset, item, remainingDepth);
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
		private static string? ReadIndex1Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 1);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static string? ReadIndex2Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 2);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Parse(buffer, offset2, remainingDepth);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicProp>? ReadIndex3Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 3);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N4CFCEA029A77422A168508762952090A3C3269E1B690082A0B33089E74E992A8.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.Props);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicHudTrack>? ReadIndex4Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 4);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NB4DA8001DE10551D82288DAC8DB0DF78985132A131AC3E24E1E0CF5D4599A844.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.HudTracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicMarker>? ReadIndex5Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 5);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NF29B84F765342CF782A6B0C7502B36BA7258A41E254D296DB7CD063C18E73855.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.Markers);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static IList<CinematicOverlayTrack>? ReadIndex6Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 6);
			if (num == 0)
			{
				return null;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.NDEB3DB9F7AA13185E4D6F6836E4E9EA74E52FEC3BE7639BA7EA35B7ED3815794.Helpers.Parse_GreedyMutable(buffer, offset2, remainingDepth, tableMetadata_6b57092359a944dc95b2e25227e57004.OverlayTracks);
		}

		[MethodImpl(MethodImplOptions.AggressiveInlining)]
		private static bool ReadIndex7Value(TInputBuffer buffer, int offset, VTable8 vtable, short remainingDepth)
		{
			int num = vtable.OffsetOf(buffer, 7);
			if (num == 0)
			{
				return false;
			}
			int offset2 = offset + num;
			return FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Parse(buffer, offset2, remainingDepth);
		}
	}

	private static class tableMetadata_6b57092359a944dc95b2e25227e57004
	{
		public static readonly TableFieldContext Id = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.Cinematic.Id", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Name = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.Cinematic.Name", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext CameraSequenceName = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.Cinematic.CameraSequenceName", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Props = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.Cinematic.Props", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext HudTracks = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.Cinematic.HudTracks", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext Markers = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.Cinematic.Markers", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext OverlayTracks = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.Cinematic.OverlayTracks", sharedString: false, writeThrough: false);

		public static readonly TableFieldContext HideOverlays = new TableFieldContext("BlueBottleIPC.LeagueBroadcast.Cinematics.Cinematic.HideOverlays", sharedString: false, writeThrough: false);
	}

	internal static int GetMaxSize(Cinematic value)
	{
		int num = 78;
		string id = value.Id;
		if (id != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(id);
		}
		string name = value.Name;
		if (name != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(name);
		}
		string cameraSequenceName = value.CameraSequenceName;
		if (cameraSequenceName != null)
		{
			num += FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.GetMaxSize(cameraSequenceName);
		}
		IList<CinematicProp> props = value.Props;
		if (props != null)
		{
			num += FlatSharp.Compiler.Generated.N4CFCEA029A77422A168508762952090A3C3269E1B690082A0B33089E74E992A8.Helpers.GetMaxSize(props);
		}
		IList<CinematicHudTrack> hudTracks = value.HudTracks;
		if (hudTracks != null)
		{
			num += FlatSharp.Compiler.Generated.NB4DA8001DE10551D82288DAC8DB0DF78985132A131AC3E24E1E0CF5D4599A844.Helpers.GetMaxSize(hudTracks);
		}
		IList<CinematicMarker> markers = value.Markers;
		if (markers != null)
		{
			num += FlatSharp.Compiler.Generated.NF29B84F765342CF782A6B0C7502B36BA7258A41E254D296DB7CD063C18E73855.Helpers.GetMaxSize(markers);
		}
		IList<CinematicOverlayTrack> overlayTracks = value.OverlayTracks;
		if (overlayTracks != null)
		{
			num += FlatSharp.Compiler.Generated.NDEB3DB9F7AA13185E4D6F6836E4E9EA74E52FEC3BE7639BA7EA35B7ED3815794.Helpers.GetMaxSize(overlayTracks);
		}
		return num;
	}

	internal static void Serialize<TSpanWriter>(TSpanWriter spanWriter, Span<byte> span, Cinematic value, int offset, SerializationContext context) where TSpanWriter : ISpanWriter
	{
		int num = context.AllocateSpace(54, 4);
		spanWriter.WriteUOffset(span, offset, num);
		int num2 = num + 4;
		int num3 = 4;
		Span<byte> span2 = stackalloc byte[20];
		string id = value.Id;
		string name = value.Name;
		string cameraSequenceName = value.CameraSequenceName;
		IList<CinematicProp> props = value.Props;
		IList<CinematicHudTrack> hudTracks = value.HudTracks;
		IList<CinematicMarker> markers = value.Markers;
		IList<CinematicOverlayTrack> overlayTracks = value.OverlayTracks;
		bool hideOverlays = value.HideOverlays;
		int num4 = num;
		if (overlayTracks != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num4 = num2;
			num2 += 4;
			if (18 > num3)
			{
				num3 = 18;
			}
		}
		Span<byte> span3 = span2;
		spanWriter.WriteUShort(span3, (ushort)(num4 - num), 16);
		int num5 = num;
		if (markers != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num5 = num2;
			num2 += 4;
			if (16 > num3)
			{
				num3 = 16;
			}
		}
		Span<byte> span4 = span2;
		spanWriter.WriteUShort(span4, (ushort)(num5 - num), 14);
		int num6 = num;
		if (hudTracks != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num6 = num2;
			num2 += 4;
			if (14 > num3)
			{
				num3 = 14;
			}
		}
		Span<byte> span5 = span2;
		spanWriter.WriteUShort(span5, (ushort)(num6 - num), 12);
		int num7 = num;
		if (props != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num7 = num2;
			num2 += 4;
			if (12 > num3)
			{
				num3 = 12;
			}
		}
		Span<byte> span6 = span2;
		spanWriter.WriteUShort(span6, (ushort)(num7 - num), 10);
		int num8 = num;
		if (cameraSequenceName != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num8 = num2;
			num2 += 4;
			if (10 > num3)
			{
				num3 = 10;
			}
		}
		Span<byte> span7 = span2;
		spanWriter.WriteUShort(span7, (ushort)(num8 - num), 8);
		int num9 = num;
		if (name != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num9 = num2;
			num2 += 4;
			if (8 > num3)
			{
				num3 = 8;
			}
		}
		Span<byte> span8 = span2;
		spanWriter.WriteUShort(span8, (ushort)(num9 - num), 6);
		int num10 = num;
		if (id != null)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 4);
			num10 = num2;
			num2 += 4;
			if (6 > num3)
			{
				num3 = 6;
			}
		}
		Span<byte> span9 = span2;
		spanWriter.WriteUShort(span9, (ushort)(num10 - num), 4);
		int num11 = num;
		if (hideOverlays)
		{
			num2 += SerializationHelpers.GetAlignmentError(num2, 1);
			num11 = num2;
			num2++;
			FlatSharp.Compiler.Generated.N1B56312394AAA84E32CA7EDCB7D07A5B2E64E1AF0FB7AF7AC68C941AE6659E72.Helpers.Serialize(spanWriter, span, hideOverlays, num11);
			num3 = 20;
		}
		Span<byte> span10 = span2;
		spanWriter.WriteUShort(span10, (ushort)(num11 - num), 18);
		int num12 = num2 - num;
		context.Offset -= 54 - num12;
		Span<byte> span11 = span2;
		spanWriter.WriteUShort(span11, (ushort)num3, 0);
		Span<byte> span12 = span2;
		spanWriter.WriteUShort(span12, (ushort)num12, 2);
		int num13 = context.FinishVTable(span, span2.Slice(0, num3));
		spanWriter.WriteInt(span, num - num13, num);
		if (num4 != num)
		{
			FlatSharp.Compiler.Generated.NDEB3DB9F7AA13185E4D6F6836E4E9EA74E52FEC3BE7639BA7EA35B7ED3815794.Helpers.Serialize(spanWriter, span, overlayTracks, num4, context);
		}
		if (num5 != num)
		{
			FlatSharp.Compiler.Generated.NF29B84F765342CF782A6B0C7502B36BA7258A41E254D296DB7CD063C18E73855.Helpers.Serialize(spanWriter, span, markers, num5, context);
		}
		if (num6 != num)
		{
			FlatSharp.Compiler.Generated.NB4DA8001DE10551D82288DAC8DB0DF78985132A131AC3E24E1E0CF5D4599A844.Helpers.Serialize(spanWriter, span, hudTracks, num6, context);
		}
		if (num7 != num)
		{
			FlatSharp.Compiler.Generated.N4CFCEA029A77422A168508762952090A3C3269E1B690082A0B33089E74E992A8.Helpers.Serialize(spanWriter, span, props, num7, context);
		}
		if (num8 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, cameraSequenceName, num8, context, tableMetadata_6b57092359a944dc95b2e25227e57004.CameraSequenceName);
		}
		if (num9 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, name, num9, context, tableMetadata_6b57092359a944dc95b2e25227e57004.Name);
		}
		if (num10 != num)
		{
			FlatSharp.Compiler.Generated.N713267F71061CB50DD0B6E0459A8B28F01DB10694EEF7B2C6253EFEEF1AAB66E.Helpers.Serialize(spanWriter, span, id, num10, context, tableMetadata_6b57092359a944dc95b2e25227e57004.Id);
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a88be26b47f44da98aff1a3a7a9581e5_Lazy<TInputBuffer> Parse_Lazy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a88be26b47f44da98aff1a3a7a9581e5_Lazy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer> Parse_Progressive<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a88be26b47f44da98aff1a3a7a9581e5_Progressive<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a88be26b47f44da98aff1a3a7a9581e5_Greedy<TInputBuffer> Parse_Greedy<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a88be26b47f44da98aff1a3a7a9581e5_Greedy<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static tableReader_a88be26b47f44da98aff1a3a7a9581e5_GreedyMutable<TInputBuffer> Parse_GreedyMutable<TInputBuffer>(TInputBuffer buffer, int offset, short remainingDepth) where TInputBuffer : IInputBuffer
	{
		return new tableReader_a88be26b47f44da98aff1a3a7a9581e5_GreedyMutable<TInputBuffer>(buffer, offset + buffer.ReadUOffset(offset), remainingDepth);
	}
}
