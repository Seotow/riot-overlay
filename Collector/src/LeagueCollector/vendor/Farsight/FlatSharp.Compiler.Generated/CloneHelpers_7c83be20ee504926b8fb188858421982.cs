using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using BlueBottleIPC.LeagueBroadcast.Cinematics;
using BlueBottleIPC.LeagueBroadcast.Commands;
using BlueBottleIPC.LeagueBroadcast.Common;
using BlueBottleIPC.LeagueBroadcast.Entity;
using BlueBottleIPC.LeagueBroadcast.Scene;
using BlueBottleIPC.LeagueBroadcast.Sequencer;
using BlueBottleIPC.LeagueBroadcast.Snapshot;
using FlatSharp.Internal;

namespace FlatSharp.Compiler.Generated;

internal static class CloneHelpers_7c83be20ee504926b8fb188858421982
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraHold Clone(CameraHold item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static byte Clone(byte item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraLookAtObjective Clone(CameraLookAtObjective item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraLookAtSource Clone(CameraLookAtSource item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraLookAtTeam Clone(CameraLookAtTeam item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraTangentMode Clone(CameraTangentMode item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ChannelValue Clone(ChannelValue item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ClipPhase Clone(ClipPhase item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ExposedKind Clone(ExposedKind item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Extrapolation Clone(Extrapolation item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static MarkerKind Clone(MarkerKind item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SectionBlend Clone(SectionBlend item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SeqProperty Clone(SeqProperty item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ushort Clone(ushort item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TargetKind Clone(TargetKind item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Binding? Clone(Binding? item)
	{
		if (item != null)
		{
			return new Binding(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static uint Clone(uint item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static string? Clone(string? item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong Clone(ulong item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraFocusPoint? Clone(CameraFocusPoint? item)
	{
		if (item != null)
		{
			return new CameraFocusPoint(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static float Clone(float item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraLookAtSettings? Clone(CameraLookAtSettings? item)
	{
		if (item != null)
		{
			return new CameraLookAtSettings(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Channel? Clone(Channel? item)
	{
		if (item != null)
		{
			return new Channel(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<SeqKeyframe>? Clone(IList<SeqKeyframe>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SeqKeyframe? Clone(SeqKeyframe? item)
	{
		if (item != null)
		{
			return new SeqKeyframe(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool Clone(bool item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static BlendEasing Clone(BlendEasing item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Clip? Clone(Clip? item)
	{
		if (item != null)
		{
			return new Clip(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Track>? Clone(IList<Track>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Marker>? Clone(IList<Marker>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Track? Clone(Track? item)
	{
		if (item != null)
		{
			return new Track(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Marker? Clone(Marker? item)
	{
		if (item != null)
		{
			return new Marker(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Section>? Clone(IList<Section>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CameraFocusPoint>? Clone(IList<CameraFocusPoint>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Section? Clone(Section? item)
	{
		if (item != null)
		{
			return new Section(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Channel>? Clone(IList<Channel>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Exposed? Clone(Exposed? item)
	{
		if (item != null)
		{
			return new Exposed(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ExposedChoice>? Clone(IList<ExposedChoice>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ExposedChoice? Clone(ExposedChoice? item)
	{
		if (item != null)
		{
			return new ExposedChoice(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Sequence? Clone(Sequence? item)
	{
		if (item != null)
		{
			return new Sequence(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Binding>? Clone(IList<Binding>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Clip>? Clone(IList<Clip>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Exposed>? Clone(IList<Exposed>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SequenceClipState? Clone(SequenceClipState? item)
	{
		if (item != null)
		{
			return new SequenceClipState(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SequenceState? Clone(SequenceState? item)
	{
		if (item != null)
		{
			return new SequenceState(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<SequenceClipState>? Clone(IList<SequenceClipState>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<uint>? Clone(IList<uint>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<string>? Clone(IList<string>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<SeqProperty>? Clone(IList<SeqProperty>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static BoundTextSource Clone(BoundTextSource item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CinematicHudElement Clone(CinematicHudElement item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static PlayerSlot Clone(PlayerSlot item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static PropKind Clone(PropKind item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static PropOrientation Clone(PropOrientation item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TeamSlot Clone(TeamSlot item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TextFormat Clone(TextFormat item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TrackKind Clone(TrackKind item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AddBoundTextRequest? Clone(AddBoundTextRequest? item)
	{
		if (item != null)
		{
			return new AddBoundTextRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AddLogoRequest? Clone(AddLogoRequest? item)
	{
		if (item != null)
		{
			return new AddLogoRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AddModelRequest? Clone(AddModelRequest? item)
	{
		if (item != null)
		{
			return new AddModelRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AddPlayerChampionRequest? Clone(AddPlayerChampionRequest? item)
	{
		if (item != null)
		{
			return new AddPlayerChampionRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AddPlayerVideoRequest? Clone(AddPlayerVideoRequest? item)
	{
		if (item != null)
		{
			return new AddPlayerVideoRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Cinematic? Clone(Cinematic? item)
	{
		if (item != null)
		{
			return new Cinematic(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CinematicProp>? Clone(IList<CinematicProp>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CinematicHudTrack>? Clone(IList<CinematicHudTrack>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CinematicMarker>? Clone(IList<CinematicMarker>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CinematicOverlayTrack>? Clone(IList<CinematicOverlayTrack>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicProp? Clone(CinematicProp? item)
	{
		if (item != null)
		{
			return new CinematicProp(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicHudTrack? Clone(CinematicHudTrack? item)
	{
		if (item != null)
		{
			return new CinematicHudTrack(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicMarker? Clone(CinematicMarker? item)
	{
		if (item != null)
		{
			return new CinematicMarker(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicOverlayTrack? Clone(CinematicOverlayTrack? item)
	{
		if (item != null)
		{
			return new CinematicOverlayTrack(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CinematicTrack>? Clone(IList<CinematicTrack>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static PropStyle? Clone(PropStyle? item)
	{
		if (item != null)
		{
			return new PropStyle(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CinematicKeyframe>? Clone(IList<CinematicKeyframe>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicTrack? Clone(CinematicTrack? item)
	{
		if (item != null)
		{
			return new CinematicTrack(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static int Clone(int item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicKeyframe? Clone(CinematicKeyframe? item)
	{
		if (item != null)
		{
			return new CinematicKeyframe(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicList? Clone(CinematicList? item)
	{
		if (item != null)
		{
			return new CinematicList(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Cinematic>? Clone(IList<Cinematic>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicPlayback? Clone(CinematicPlayback? item)
	{
		if (item != null)
		{
			return new CinematicPlayback(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetHudTrackRequest? Clone(SetHudTrackRequest? item)
	{
		if (item != null)
		{
			return new SetHudTrackRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetMarkersRequest? Clone(SetMarkersRequest? item)
	{
		if (item != null)
		{
			return new SetMarkersRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetOverlayTrackRequest? Clone(SetOverlayTrackRequest? item)
	{
		if (item != null)
		{
			return new SetOverlayTrackRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetPropStyleRequest? Clone(SetPropStyleRequest? item)
	{
		if (item != null)
		{
			return new SetPropStyleRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetTrackRequest? Clone(SetTrackRequest? item)
	{
		if (item != null)
		{
			return new SetTrackRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static AIClientStatus Clone(AIClientStatus item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static AIMinionClientTypeInfo Clone(AIMinionClientTypeInfo item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static AnimationBlendMode Clone(AnimationBlendMode item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static AnimationStateStatus Clone(AnimationStateStatus item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static AttackSuccessFlag Clone(AttackSuccessFlag item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static sbyte Clone(sbyte item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CinematicCameraEditPhase Clone(CinematicCameraEditPhase item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CinematicControllerAction Clone(CinematicControllerAction item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CinematicPropEditPhase Clone(CinematicPropEditPhase item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static DamageType Clone(DamageType item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ObjectType Clone(ObjectType item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ObjectiveType Clone(ObjectiveType item)
	{
		return item;
	}

	public static ResponseKind Clone(ResponseKind item)
	{
		byte discriminator = item.Discriminator;
		switch (discriminator)
		{
		case 1:
			return new ResponseKind(Clone(item.Item1));
		case 2:
			return new ResponseKind(Clone(item.Item2));
		case 3:
			return new ResponseKind(Clone(item.Item3));
		case 4:
			return new ResponseKind(Clone(item.Item4));
		case 5:
			return new ResponseKind(Clone(item.Item5));
		case 6:
			return new ResponseKind(Clone(item.Item6));
		case 7:
			return new ResponseKind(Clone(item.Item7));
		case 8:
			return new ResponseKind(Clone(item.Item8));
		case 9:
			return new ResponseKind(Clone(item.Item9));
		case 10:
			return new ResponseKind(Clone(item.Item10));
		case 11:
			return new ResponseKind(Clone(item.Item11));
		case 12:
			return new ResponseKind(Clone(item.Item12));
		case 13:
			return new ResponseKind(Clone(item.Item13));
		case 14:
			return new ResponseKind(Clone(item.Item14));
		case 15:
			return new ResponseKind(Clone(item.Item15));
		case 16:
			return new ResponseKind(Clone(item.Item16));
		case 17:
			return new ResponseKind(Clone(item.Item17));
		case 18:
			return new ResponseKind(Clone(item.Item18));
		case 19:
			return new ResponseKind(Clone(item.Item19));
		case 20:
			return new ResponseKind(Clone(item.Item20));
		case 21:
			return new ResponseKind(Clone(item.Item21));
		case 22:
			return new ResponseKind(Clone(item.Item22));
		case 23:
			return new ResponseKind(Clone(item.Item23));
		case 24:
			return new ResponseKind(Clone(item.Item24));
		case 25:
			return new ResponseKind(Clone(item.Item25));
		case 26:
			return new ResponseKind(Clone(item.Item26));
		case 27:
			return new ResponseKind(Clone(item.Item27));
		case 28:
			return new ResponseKind(Clone(item.Item28));
		case 29:
			return new ResponseKind(Clone(item.Item29));
		case 30:
			return new ResponseKind(Clone(item.Item30));
		case 31:
			return new ResponseKind(Clone(item.Item31));
		case 32:
			return new ResponseKind(Clone(item.Item32));
		case 33:
			return new ResponseKind(Clone(item.Item33));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<ResponseKind>(discriminator);
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static GameInfo? Clone(GameInfo? item)
	{
		if (item != null)
		{
			return new GameInfo(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static GameStateMetaData? Clone(GameStateMetaData? item)
	{
		if (item != null)
		{
			return new GameStateMetaData(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SimpleResponse? Clone(SimpleResponse? item)
	{
		if (item != null)
		{
			return new SimpleResponse(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeProperties? Clone(StrokeProperties? item)
	{
		if (item != null)
		{
			return new StrokeProperties(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AuthenticationChallenge? Clone(AuthenticationChallenge? item)
	{
		if (item != null)
		{
			return new AuthenticationChallenge(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraProperties? Clone(CameraProperties? item)
	{
		if (item != null)
		{
			return new CameraProperties(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSyncEvent? Clone(StrokeSyncEvent? item)
	{
		if (item != null)
		{
			return new StrokeSyncEvent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSyncEvents? Clone(StrokeSyncEvents? item)
	{
		if (item != null)
		{
			return new StrokeSyncEvents(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSyncCurrent? Clone(StrokeSyncCurrent? item)
	{
		if (item != null)
		{
			return new StrokeSyncCurrent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SpellObjectList? Clone(SpellObjectList? item)
	{
		if (item != null)
		{
			return new SpellObjectList(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneEventWrapper? Clone(SceneEventWrapper? item)
	{
		if (item != null)
		{
			return new SceneEventWrapper(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AssetCreateBatchResult? Clone(AssetCreateBatchResult? item)
	{
		if (item != null)
		{
			return new AssetCreateBatchResult(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StreamTextureSDPAnswer? Clone(StreamTextureSDPAnswer? item)
	{
		if (item != null)
		{
			return new StreamTextureSDPAnswer(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static MirrorState? Clone(MirrorState? item)
	{
		if (item != null)
		{
			return new MirrorState(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static OffsetDump? Clone(OffsetDump? item)
	{
		if (item != null)
		{
			return new OffsetDump(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ObjectAddressDump? Clone(ObjectAddressDump? item)
	{
		if (item != null)
		{
			return new ObjectAddressDump(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraState? Clone(CameraState? item)
	{
		if (item != null)
		{
			return new CameraState(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static HudPanelRowClicked? Clone(HudPanelRowClicked? item)
	{
		if (item != null)
		{
			return new HudPanelRowClicked(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static HudPanelRowsReordered? Clone(HudPanelRowsReordered? item)
	{
		if (item != null)
		{
			return new HudPanelRowsReordered(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeAnchorTargetChanged? Clone(StrokeAnchorTargetChanged? item)
	{
		if (item != null)
		{
			return new StrokeAnchorTargetChanged(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeCameraLockChanged? Clone(StrokeCameraLockChanged? item)
	{
		if (item != null)
		{
			return new StrokeCameraLockChanged(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static PenEraserStateChanged? Clone(PenEraserStateChanged? item)
	{
		if (item != null)
		{
			return new PenEraserStateChanged(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StreamTextureSDPResult? Clone(StreamTextureSDPResult? item)
	{
		if (item != null)
		{
			return new StreamTextureSDPResult(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StreamTextureStatus? Clone(StreamTextureStatus? item)
	{
		if (item != null)
		{
			return new StreamTextureStatus(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneEditorHudLayout? Clone(SceneEditorHudLayout? item)
	{
		if (item != null)
		{
			return new SceneEditorHudLayout(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static RenderSettings? Clone(RenderSettings? item)
	{
		if (item != null)
		{
			return new RenderSettings(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SequenceStateResponse? Clone(SequenceStateResponse? item)
	{
		if (item != null)
		{
			return new SequenceStateResponse(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicCameraPose? Clone(CinematicCameraPose? item)
	{
		if (item != null)
		{
			return new CinematicCameraPose(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicCameraEditEvent? Clone(CinematicCameraEditEvent? item)
	{
		if (item != null)
		{
			return new CinematicCameraEditEvent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicPropEditEvent? Clone(CinematicPropEditEvent? item)
	{
		if (item != null)
		{
			return new CinematicPropEditEvent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicAuthoringActionEvent? Clone(CinematicAuthoringActionEvent? item)
	{
		if (item != null)
		{
			return new CinematicAuthoringActionEvent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewStatus? Clone(CameraPreviewStatus? item)
	{
		if (item != null)
		{
			return new CameraPreviewStatus(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CrashReportChannel? Clone(CrashReportChannel? item)
	{
		if (item != null)
		{
			return new CrashReportChannel(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Camera? Clone(Camera? item)
	{
		if (item != null)
		{
			return new Camera(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<TeamStats>? Clone(IList<TeamStats>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static GameEvents? Clone(GameEvents? item)
	{
		if (item != null)
		{
			return new GameEvents(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AIHeroClient>? Clone(IList<AIHeroClient>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AIMinionClient>? Clone(IList<AIMinionClient>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AITurretClient>? Clone(IList<AITurretClient>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Building>? Clone(IList<Building>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Missile>? Clone(IList<Missile>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<GeneralParticleEmitter>? Clone(IList<GeneralParticleEmitter>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<MiscObjects>? Clone(IList<MiscObjects>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SimpleResponseKind Clone(SimpleResponseKind item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static StrokeLayer Clone(StrokeLayer item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static StrokeTipStyle Clone(StrokeTipStyle item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ColorRGBA? Clone(ColorRGBA? item)
	{
		if (item != null)
		{
			return new ColorRGBA(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static StrokeLineStyle Clone(StrokeLineStyle item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static StrokeTimeMode Clone(StrokeTimeMode item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Challenge Clone(Challenge item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static StrokeSyncEventType Clone(StrokeSyncEventType item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Vector3>? Clone(IList<Vector3>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<float>? Clone(IList<float>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<StrokeSyncEvent>? Clone(IList<StrokeSyncEvent>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CompletedStroke>? Clone(IList<CompletedStroke>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<StrokeSyncBeginRemote>? Clone(IList<StrokeSyncBeginRemote>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<SpellObjectEntry>? Clone(IList<SpellObjectEntry>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SceneEvent? Clone(SceneEvent? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<bool>? Clone(IList<bool>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<OffsetEntry>? Clone(IList<OffsetEntry>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ObjectAddressEntry>? Clone(IList<ObjectAddressEntry>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3? Clone(Vector3? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static StreamTextureState Clone(StreamTextureState item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static bool? Clone(bool? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Memory<byte>? Clone(Memory<byte>? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CinematicCameraEditorHandle Clone(CinematicCameraEditorHandle item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewState Clone(CameraPreviewState item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewError Clone(CameraPreviewError item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix4x4? Clone(Matrix4x4? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AutoDirectorPresentation? Clone(AutoDirectorPresentation? item)
	{
		if (item != null)
		{
			return new AutoDirectorPresentation(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static TeamStats? Clone(TeamStats? item)
	{
		if (item != null)
		{
			return new TeamStats(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<DeathEvent>? Clone(IList<DeathEvent>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<DamageDealtEvent>? Clone(IList<DamageDealtEvent>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<NotificationEvent>? Clone(IList<NotificationEvent>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<InhibitorKillEvent>? Clone(IList<InhibitorKillEvent>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<FirstBloodEvent>? Clone(IList<FirstBloodEvent>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<TurretKillEvent>? Clone(IList<TurretKillEvent>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<TurretPlateDestroyEvent>? Clone(IList<TurretPlateDestroyEvent>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<XKillEvent>? Clone(IList<XKillEvent>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AceEvent>? Clone(IList<AceEvent>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ObjectiveStealEvent>? Clone(IList<ObjectiveStealEvent>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<HeroDieEvent>? Clone(IList<HeroDieEvent>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AIHeroClient? Clone(AIHeroClient? item)
	{
		if (item != null)
		{
			return new AIHeroClient(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AIMinionClient? Clone(AIMinionClient? item)
	{
		if ((object)item != null)
		{
			return new AIMinionClient(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AITurretClient? Clone(AITurretClient? item)
	{
		if (item != null)
		{
			return new AITurretClient(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Building? Clone(Building? item)
	{
		if (item != null)
		{
			return new Building(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Missile? Clone(Missile? item)
	{
		if (item != null)
		{
			return new Missile(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static GeneralParticleEmitter? Clone(GeneralParticleEmitter? item)
	{
		if (item != null)
		{
			return new GeneralParticleEmitter(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static MiscObjects? Clone(MiscObjects? item)
	{
		if (item != null)
		{
			return new MiscObjects(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector3 Clone(Vector3 item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CompletedStroke? Clone(CompletedStroke? item)
	{
		if (item != null)
		{
			return new CompletedStroke(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSyncBeginRemote? Clone(StrokeSyncBeginRemote? item)
	{
		if (item != null)
		{
			return new StrokeSyncBeginRemote(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SpellObjectEntry? Clone(SpellObjectEntry? item)
	{
		if (item != null)
		{
			return new SpellObjectEntry(item);
		}
		return null;
	}

	public static SceneEvent Clone(SceneEvent item)
	{
		byte discriminator = item.Discriminator;
		switch (discriminator)
		{
		case 1:
			return new SceneEvent(Clone(item.Item1));
		case 2:
			return new SceneEvent(Clone(item.Item2));
		case 3:
			return new SceneEvent(Clone(item.Item3));
		case 4:
			return new SceneEvent(Clone(item.Item4));
		case 5:
			return new SceneEvent(Clone(item.Item5));
		case 6:
			return new SceneEvent(Clone(item.Item6));
		case 7:
			return new SceneEvent(Clone(item.Item7));
		case 8:
			return new SceneEvent(Clone(item.Item8));
		case 9:
			return new SceneEvent(Clone(item.Item9));
		case 10:
			return new SceneEvent(Clone(item.Item10));
		case 11:
			return new SceneEvent(Clone(item.Item11));
		case 12:
			return new SceneEvent(Clone(item.Item12));
		case 13:
			return new SceneEvent(Clone(item.Item13));
		case 14:
			return new SceneEvent(Clone(item.Item14));
		case 15:
			return new SceneEvent(Clone(item.Item15));
		case 16:
			return new SceneEvent(Clone(item.Item16));
		case 17:
			return new SceneEvent(Clone(item.Item17));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneEvent>(discriminator);
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static OffsetEntry? Clone(OffsetEntry? item)
	{
		if (item != null)
		{
			return new OffsetEntry(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ObjectAddressEntry? Clone(ObjectAddressEntry? item)
	{
		if (item != null)
		{
			return new ObjectAddressEntry(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Memory<byte> Clone(Memory<byte> item)
	{
		return item.ToArray().AsMemory();
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix4x4 Clone(Matrix4x4 item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static DeathEvent? Clone(DeathEvent? item)
	{
		if (item != null)
		{
			return new DeathEvent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static DamageDealtEvent? Clone(DamageDealtEvent? item)
	{
		if (item != null)
		{
			return new DamageDealtEvent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static NotificationEvent? Clone(NotificationEvent? item)
	{
		if (item != null)
		{
			return new NotificationEvent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static InhibitorKillEvent Clone(InhibitorKillEvent item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static FirstBloodEvent Clone(FirstBloodEvent item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TurretKillEvent Clone(TurretKillEvent item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static TurretPlateDestroyEvent Clone(TurretPlateDestroyEvent item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static XKillEvent Clone(XKillEvent item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static AceEvent Clone(AceEvent item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ObjectiveStealEvent Clone(ObjectiveStealEvent item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static HeroDieEvent Clone(HeroDieEvent item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ObjectInfo? Clone(ObjectInfo? item)
	{
		if ((object)item != null)
		{
			return new ObjectInfo(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AIClient? Clone(AIClient? item)
	{
		if (item != null)
		{
			return new AIClient(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Spell>? Clone(IList<Spell>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Item>? Clone(IList<Item>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Perk>? Clone(IList<Perk>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Bone>? Clone(IList<Bone>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CharacterStats? Clone(CharacterStats? item)
	{
		if (item != null)
		{
			return new CharacterStats(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Matrix3x3 Clone(Matrix3x3 item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ObjectInfo>? Clone(IList<ObjectInfo>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneCreated? Clone(SceneCreated? item)
	{
		if (item != null)
		{
			return new SceneCreated(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneUnloaded? Clone(SceneUnloaded? item)
	{
		if (item != null)
		{
			return new SceneUnloaded(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneStateChanged? Clone(SceneStateChanged? item)
	{
		if (item != null)
		{
			return new SceneStateChanged(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneList? Clone(SceneList? item)
	{
		if (item != null)
		{
			return new SceneList(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneSnapshot? Clone(SceneSnapshot? item)
	{
		if (item != null)
		{
			return new SceneSnapshot(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneEntitiesAdded? Clone(SceneEntitiesAdded? item)
	{
		if (item != null)
		{
			return new SceneEntitiesAdded(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneEntitiesRemoved? Clone(SceneEntitiesRemoved? item)
	{
		if (item != null)
		{
			return new SceneEntitiesRemoved(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneEntitiesSnapshot? Clone(SceneEntitiesSnapshot? item)
	{
		if (item != null)
		{
			return new SceneEntitiesSnapshot(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneEntityChanged? Clone(SceneEntityChanged? item)
	{
		if (item != null)
		{
			return new SceneEntityChanged(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneEntityTransformUpdates? Clone(SceneEntityTransformUpdates? item)
	{
		if (item != null)
		{
			return new SceneEntityTransformUpdates(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneSelectionChanged? Clone(SceneSelectionChanged? item)
	{
		if (item != null)
		{
			return new SceneSelectionChanged(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneEntityIdChanged? Clone(SceneEntityIdChanged? item)
	{
		if (item != null)
		{
			return new SceneEntityIdChanged(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneScriptError? Clone(SceneScriptError? item)
	{
		if (item != null)
		{
			return new SceneScriptError(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneScriptLog? Clone(SceneScriptLog? item)
	{
		if (item != null)
		{
			return new SceneScriptLog(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptAssetChanged? Clone(ScriptAssetChanged? item)
	{
		if (item != null)
		{
			return new ScriptAssetChanged(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptAssetDeleted? Clone(ScriptAssetDeleted? item)
	{
		if (item != null)
		{
			return new ScriptAssetDeleted(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptLibrary? Clone(ScriptLibrary? item)
	{
		if (item != null)
		{
			return new ScriptLibrary(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static DataStack? Clone(DataStack? item)
	{
		if (item != null)
		{
			return new DataStack(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Buff>? Clone(IList<Buff>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Animation>? Clone(IList<Animation>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AnimationState? Clone(AnimationState? item)
	{
		if (item != null)
		{
			return new AnimationState(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Spell? Clone(Spell? item)
	{
		if (item != null)
		{
			return new Spell(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Item? Clone(Item? item)
	{
		if (item != null)
		{
			return new Item(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Perk? Clone(Perk? item)
	{
		if (item != null)
		{
			return new Perk(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Bone? Clone(Bone? item)
	{
		if (item != null)
		{
			return new Bone(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneDescriptor? Clone(SceneDescriptor? item)
	{
		if (item != null)
		{
			return new SceneDescriptor(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<SceneDescriptor>? Clone(IList<SceneDescriptor>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<EntitySnapshot>? Clone(IList<EntitySnapshot>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ScriptAssetSnapshot>? Clone(IList<ScriptAssetSnapshot>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<EntityAssignment>? Clone(IList<EntityAssignment>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ulong>? Clone(IList<ulong>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EntityEventKind Clone(EntityEventKind item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<Component>? Clone(IList<Component>? item)
	{
		return VectorCloneHelpers.CloneVectorOfUnion(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<EntityTransformUpdate>? Clone(IList<EntityTransformUpdate>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static GizmoManipulationPhase Clone(GizmoManipulationPhase item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ScriptLogLevel Clone(ScriptLogLevel item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptAssetSnapshot? Clone(ScriptAssetSnapshot? item)
	{
		if (item != null)
		{
			return new ScriptAssetSnapshot(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Buff? Clone(Buff? item)
	{
		if (item != null)
		{
			return new Buff(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Animation? Clone(Animation? item)
	{
		if (item != null)
		{
			return new Animation(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AnimationContribution>? Clone(IList<AnimationContribution>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AnimationPoseNode>? Clone(IList<AnimationPoseNode>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AnimationTrackState>? Clone(IList<AnimationTrackState>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ItemStats? Clone(ItemStats? item)
	{
		if (item != null)
		{
			return new ItemStats(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static double Clone(double item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Xform? Clone(Xform? item)
	{
		if (item != null)
		{
			return new Xform(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static EntitySnapshot? Clone(EntitySnapshot? item)
	{
		if (item != null)
		{
			return new EntitySnapshot(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static EntityAssignment? Clone(EntityAssignment? item)
	{
		if (item != null)
		{
			return new EntityAssignment(item);
		}
		return null;
	}

	public static Component Clone(Component item)
	{
		byte discriminator = item.Discriminator;
		switch (discriminator)
		{
		case 1:
			return new Component(Clone(item.Item1));
		case 2:
			return new Component(Clone(item.Item2));
		case 3:
			return new Component(Clone(item.Item3));
		case 4:
			return new Component(Clone(item.Item4));
		case 5:
			return new Component(Clone(item.Item5));
		case 6:
			return new Component(Clone(item.Item6));
		case 7:
			return new Component(Clone(item.Item7));
		case 8:
			return new Component(Clone(item.Item8));
		case 9:
			return new Component(Clone(item.Item9));
		case 10:
			return new Component(Clone(item.Item10));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<Component>(discriminator);
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static EntityTransformUpdate? Clone(EntityTransformUpdate? item)
	{
		if (item != null)
		{
			return new EntityTransformUpdate(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ScriptVariableSnapshot>? Clone(IList<ScriptVariableSnapshot>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AnimationContribution? Clone(AnimationContribution? item)
	{
		if (item != null)
		{
			return new AnimationContribution(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AnimationPoseNode? Clone(AnimationPoseNode? item)
	{
		if (item != null)
		{
			return new AnimationPoseNode(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AnimationTrackState? Clone(AnimationTrackState? item)
	{
		if (item != null)
		{
			return new AnimationTrackState(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4 Clone(Vector4 item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ComponentTransform? Clone(ComponentTransform? item)
	{
		if (item != null)
		{
			return new ComponentTransform(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ComponentVisibility? Clone(ComponentVisibility? item)
	{
		if (item != null)
		{
			return new ComponentVisibility(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ComponentEditState? Clone(ComponentEditState? item)
	{
		if (item != null)
		{
			return new ComponentEditState(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ComponentScript? Clone(ComponentScript? item)
	{
		if (item != null)
		{
			return new ComponentScript(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ComponentMeshRenderer? Clone(ComponentMeshRenderer? item)
	{
		if (item != null)
		{
			return new ComponentMeshRenderer(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ComponentDecalProjector? Clone(ComponentDecalProjector? item)
	{
		if (item != null)
		{
			return new ComponentDecalProjector(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ComponentTextRenderer? Clone(ComponentTextRenderer? item)
	{
		if (item != null)
		{
			return new ComponentTextRenderer(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ComponentStreamSource? Clone(ComponentStreamSource? item)
	{
		if (item != null)
		{
			return new ComponentStreamSource(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ComponentSpriteRenderer? Clone(ComponentSpriteRenderer? item)
	{
		if (item != null)
		{
			return new ComponentSpriteRenderer(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ComponentUnitAnchor? Clone(ComponentUnitAnchor? item)
	{
		if (item != null)
		{
			return new ComponentUnitAnchor(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptVariableSnapshot? Clone(ScriptVariableSnapshot? item)
	{
		if (item != null)
		{
			return new ScriptVariableSnapshot(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AnimationJointWeight>? Clone(IList<AnimationJointWeight>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Quaternion Clone(Quaternion item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ScriptEntry>? Clone(IList<ScriptEntry>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static AssetIdentifier? Clone(AssetIdentifier? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AnimationStateDefinition>? Clone(IList<AnimationStateDefinition>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AnimationTransitionDefinition>? Clone(IList<AnimationTransitionDefinition>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static UnitAnchorTargetType Clone(UnitAnchorTargetType item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static UnitAnchorTeam Clone(UnitAnchorTeam item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static UnitAnchorObjective Clone(UnitAnchorObjective item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptVariableValue? Clone(ScriptVariableValue? item)
	{
		if (item != null)
		{
			return new ScriptVariableValue(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ScriptVariableEnumOption>? Clone(IList<ScriptVariableEnumOption>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AnimationJointWeight? Clone(AnimationJointWeight? item)
	{
		if (item != null)
		{
			return new AnimationJointWeight(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptEntry? Clone(ScriptEntry? item)
	{
		if (item != null)
		{
			return new ScriptEntry(item);
		}
		return null;
	}

	public static AssetIdentifier Clone(AssetIdentifier item)
	{
		byte discriminator = item.Discriminator;
		switch (discriminator)
		{
		case 1:
			return new AssetIdentifier(Clone(item.Item1));
		case 2:
			return new AssetIdentifier(Clone(item.Item2));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<AssetIdentifier>(discriminator);
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AnimationStateDefinition? Clone(AnimationStateDefinition? item)
	{
		if (item != null)
		{
			return new AnimationStateDefinition(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AnimationTransitionDefinition? Clone(AnimationTransitionDefinition? item)
	{
		if (item != null)
		{
			return new AnimationTransitionDefinition(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ScriptVariableValueType Clone(ScriptVariableValueType item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static long Clone(long item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector4? Clone(Vector4? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ScriptVariableValue>? Clone(IList<ScriptVariableValue>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptVariableEnumOption? Clone(ScriptVariableEnumOption? item)
	{
		if (item != null)
		{
			return new ScriptVariableEnumOption(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ScriptVariableOverride>? Clone(IList<ScriptVariableOverride>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IdWrapper? Clone(IdWrapper? item)
	{
		if (item != null)
		{
			return new IdWrapper(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static AnimationTransitionCondition Clone(AnimationTransitionCondition item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptVariableOverride? Clone(ScriptVariableOverride? item)
	{
		if (item != null)
		{
			return new ScriptVariableOverride(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static PausedGameInfo? Clone(PausedGameInfo? item)
	{
		if (item != null)
		{
			return new PausedGameInfo(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ReplayFile? Clone(ReplayFile? item)
	{
		if (item != null)
		{
			return new ReplayFile(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<GameInfo>? Clone(IList<GameInfo>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Response? Clone(Response? item)
	{
		if (item != null)
		{
			return new Response(item);
		}
		return null;
	}

	public static SceneCommand Clone(SceneCommand item)
	{
		byte discriminator = item.Discriminator;
		switch (discriminator)
		{
		case 1:
			return new SceneCommand(Clone(item.Item1));
		case 2:
			return new SceneCommand(Clone(item.Item2));
		case 3:
			return new SceneCommand(Clone(item.Item3));
		case 4:
			return new SceneCommand(Clone(item.Item4));
		case 5:
			return new SceneCommand(Clone(item.Item5));
		case 6:
			return new SceneCommand(Clone(item.Item6));
		case 7:
			return new SceneCommand(Clone(item.Item7));
		case 8:
			return new SceneCommand(Clone(item.Item8));
		case 9:
			return new SceneCommand(Clone(item.Item9));
		case 10:
			return new SceneCommand(Clone(item.Item10));
		case 11:
			return new SceneCommand(Clone(item.Item11));
		case 12:
			return new SceneCommand(Clone(item.Item12));
		case 13:
			return new SceneCommand(Clone(item.Item13));
		case 14:
			return new SceneCommand(Clone(item.Item14));
		case 15:
			return new SceneCommand(Clone(item.Item15));
		case 16:
			return new SceneCommand(Clone(item.Item16));
		case 17:
			return new SceneCommand(Clone(item.Item17));
		case 18:
			return new SceneCommand(Clone(item.Item18));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneCommand>(discriminator);
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneCreate? Clone(SceneCreate? item)
	{
		if (item != null)
		{
			return new SceneCreate(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneUnload? Clone(SceneUnload? item)
	{
		if (item != null)
		{
			return new SceneUnload(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneSetVisibility? Clone(SceneSetVisibility? item)
	{
		if (item != null)
		{
			return new SceneSetVisibility(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneSetEditable? Clone(SceneSetEditable? item)
	{
		if (item != null)
		{
			return new SceneSetEditable(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneSetZOrder? Clone(SceneSetZOrder? item)
	{
		if (item != null)
		{
			return new SceneSetZOrder(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneListRequest? Clone(SceneListRequest? item)
	{
		if (item != null)
		{
			return new SceneListRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneSnapshotRequest? Clone(SceneSnapshotRequest? item)
	{
		if (item != null)
		{
			return new SceneSnapshotRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneSetSelection? Clone(SceneSetSelection? item)
	{
		if (item != null)
		{
			return new SceneSetSelection(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static EntityCreateBatch? Clone(EntityCreateBatch? item)
	{
		if (item != null)
		{
			return new EntityCreateBatch(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static EntityDestroy? Clone(EntityDestroy? item)
	{
		if (item != null)
		{
			return new EntityDestroy(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetComponentBatch? Clone(SetComponentBatch? item)
	{
		if (item != null)
		{
			return new SetComponentBatch(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static RemoveComponent? Clone(RemoveComponent? item)
	{
		if (item != null)
		{
			return new RemoveComponent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static GetComponents? Clone(GetComponents? item)
	{
		if (item != null)
		{
			return new GetComponents(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptCreate? Clone(ScriptCreate? item)
	{
		if (item != null)
		{
			return new ScriptCreate(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptUpdate? Clone(ScriptUpdate? item)
	{
		if (item != null)
		{
			return new ScriptUpdate(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptDelete? Clone(ScriptDelete? item)
	{
		if (item != null)
		{
			return new ScriptDelete(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptListRequest? Clone(ScriptListRequest? item)
	{
		if (item != null)
		{
			return new ScriptListRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptValidate? Clone(ScriptValidate? item)
	{
		if (item != null)
		{
			return new ScriptValidate(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<EntityCreate>? Clone(IList<EntityCreate>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<SetComponent>? Clone(IList<SetComponent>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ComponentKind Clone(ComponentKind item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ComponentKind>? Clone(IList<ComponentKind>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static EntityCreate? Clone(EntityCreate? item)
	{
		if (item != null)
		{
			return new EntityCreate(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetComponent? Clone(SetComponent? item)
	{
		if (item != null)
		{
			return new SetComponent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Component? Clone(Component? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneAction? Clone(SceneAction? item)
	{
		if (item != null)
		{
			return new SceneAction(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SceneCommand? Clone(SceneCommand? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static EntityRecord? Clone(EntityRecord? item)
	{
		if (item != null)
		{
			return new EntityRecord(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SceneFile? Clone(SceneFile? item)
	{
		if (item != null)
		{
			return new SceneFile(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ScriptAsset>? Clone(IList<ScriptAsset>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<EntityRecord>? Clone(IList<EntityRecord>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptAsset? Clone(ScriptAsset? item)
	{
		if (item != null)
		{
			return new ScriptAsset(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<ScriptVariable>? Clone(IList<ScriptVariable>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ScriptVariable? Clone(ScriptVariable? item)
	{
		if (item != null)
		{
			return new ScriptVariable(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static StrokeTool Clone(StrokeTool item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Vector2 Clone(Vector2 item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static AssetType Clone(AssetType item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewCameraSourceKind Clone(CameraPreviewCameraSourceKind item)
	{
		return item;
	}

	public static CameraPreviewController Clone(CameraPreviewController item)
	{
		byte discriminator = item.Discriminator;
		switch (discriminator)
		{
		case 1:
			return new CameraPreviewController(Clone(item.Item1));
		case 2:
			return new CameraPreviewController(Clone(item.Item2));
		case 3:
			return new CameraPreviewController(Clone(item.Item3));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewController>(discriminator);
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewFocusTargetsController? Clone(CameraPreviewFocusTargetsController? item)
	{
		if (item != null)
		{
			return new CameraPreviewFocusTargetsController(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewFixedPoseController? Clone(CameraPreviewFixedPoseController? item)
	{
		if (item != null)
		{
			return new CameraPreviewFixedPoseController(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewCinematicEditorController? Clone(CameraPreviewCinematicEditorController? item)
	{
		if (item != null)
		{
			return new CameraPreviewCinematicEditorController(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CameraPreviewFocusTarget>? Clone(IList<CameraPreviewFocusTarget>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewFocusJumpMode Clone(CameraPreviewFocusJumpMode item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewFocusTarget? Clone(CameraPreviewFocusTarget? item)
	{
		if (item != null)
		{
			return new CameraPreviewFocusTarget(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewFocusTargetKind Clone(CameraPreviewFocusTargetKind item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewDirectorTargetRole Clone(CameraPreviewDirectorTargetRole item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewGradientAnimationKind Clone(CameraPreviewGradientAnimationKind item)
	{
		return item;
	}

	public static CameraPreviewLayout Clone(CameraPreviewLayout item)
	{
		byte discriminator = item.Discriminator;
		switch (discriminator)
		{
		case 1:
			return new CameraPreviewLayout(Clone(item.Item1));
		case 2:
			return new CameraPreviewLayout(Clone(item.Item2));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewLayout>(discriminator);
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewStripLayout? Clone(CameraPreviewStripLayout? item)
	{
		if (item != null)
		{
			return new CameraPreviewStripLayout(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewPipLayout? Clone(CameraPreviewPipLayout? item)
	{
		if (item != null)
		{
			return new CameraPreviewPipLayout(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CameraPreviewCameraSource>? Clone(IList<CameraPreviewCameraSource>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewCameraSource? Clone(CameraPreviewCameraSource? item)
	{
		if (item != null)
		{
			return new CameraPreviewCameraSource(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewOutputDestination Clone(CameraPreviewOutputDestination item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewProjectileFollowMode Clone(CameraPreviewProjectileFollowMode item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewTransitionKind Clone(CameraPreviewTransitionKind item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ControllerButton Clone(ControllerButton item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ControllerStick Clone(ControllerStick item)
	{
		return item;
	}

	public static DrawingCommand Clone(DrawingCommand item)
	{
		byte discriminator = item.Discriminator;
		switch (discriminator)
		{
		case 1:
			return new DrawingCommand(Clone(item.Item1));
		case 2:
			return new DrawingCommand(Clone(item.Item2));
		case 3:
			return new DrawingCommand(Clone(item.Item3));
		case 4:
			return new DrawingCommand(Clone(item.Item4));
		case 5:
			return new DrawingCommand(Clone(item.Item5));
		case 6:
			return new DrawingCommand(Clone(item.Item6));
		case 7:
			return new DrawingCommand(Clone(item.Item7));
		case 8:
			return new DrawingCommand(Clone(item.Item8));
		case 9:
			return new DrawingCommand(Clone(item.Item9));
		case 10:
			return new DrawingCommand(Clone(item.Item10));
		case 11:
			return new DrawingCommand(Clone(item.Item11));
		case 12:
			return new DrawingCommand(Clone(item.Item12));
		case 13:
			return new DrawingCommand(Clone(item.Item13));
		case 14:
			return new DrawingCommand(Clone(item.Item14));
		case 15:
			return new DrawingCommand(Clone(item.Item15));
		case 16:
			return new DrawingCommand(Clone(item.Item16));
		case 17:
			return new DrawingCommand(Clone(item.Item17));
		case 18:
			return new DrawingCommand(Clone(item.Item18));
		case 19:
			return new DrawingCommand(Clone(item.Item19));
		case 20:
			return new DrawingCommand(Clone(item.Item20));
		case 21:
			return new DrawingCommand(Clone(item.Item21));
		case 22:
			return new DrawingCommand(Clone(item.Item22));
		case 23:
			return new DrawingCommand(Clone(item.Item23));
		case 24:
			return new DrawingCommand(Clone(item.Item24));
		case 25:
			return new DrawingCommand(Clone(item.Item25));
		case 26:
			return new DrawingCommand(Clone(item.Item26));
		case 27:
			return new DrawingCommand(Clone(item.Item27));
		case 28:
			return new DrawingCommand(Clone(item.Item28));
		case 29:
			return new DrawingCommand(Clone(item.Item29));
		case 30:
			return new DrawingCommand(Clone(item.Item30));
		case 31:
			return new DrawingCommand(Clone(item.Item31));
		case 32:
			return new DrawingCommand(Clone(item.Item32));
		case 33:
			return new DrawingCommand(Clone(item.Item33));
		case 34:
			return new DrawingCommand(Clone(item.Item34));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<DrawingCommand>(discriminator);
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetActive? Clone(StrokeSetActive? item)
	{
		if (item != null)
		{
			return new StrokeSetActive(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetLayer? Clone(StrokeSetLayer? item)
	{
		if (item != null)
		{
			return new StrokeSetLayer(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetColor? Clone(StrokeSetColor? item)
	{
		if (item != null)
		{
			return new StrokeSetColor(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetWidth? Clone(StrokeSetWidth? item)
	{
		if (item != null)
		{
			return new StrokeSetWidth(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeUndo? Clone(StrokeUndo? item)
	{
		if (item != null)
		{
			return new StrokeUndo(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeRedo? Clone(StrokeRedo? item)
	{
		if (item != null)
		{
			return new StrokeRedo(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeClear? Clone(StrokeClear? item)
	{
		if (item != null)
		{
			return new StrokeClear(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetTipStyle? Clone(StrokeSetTipStyle? item)
	{
		if (item != null)
		{
			return new StrokeSetTipStyle(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static GetStrokeProperties? Clone(GetStrokeProperties? item)
	{
		if (item != null)
		{
			return new GetStrokeProperties(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetLineStyle? Clone(StrokeSetLineStyle? item)
	{
		if (item != null)
		{
			return new StrokeSetLineStyle(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetVanishTime? Clone(StrokeSetVanishTime? item)
	{
		if (item != null)
		{
			return new StrokeSetVanishTime(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetTimeMode? Clone(StrokeSetTimeMode? item)
	{
		if (item != null)
		{
			return new StrokeSetTimeMode(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSyncPointsRemote? Clone(StrokeSyncPointsRemote? item)
	{
		if (item != null)
		{
			return new StrokeSyncPointsRemote(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSyncEndRemote? Clone(StrokeSyncEndRemote? item)
	{
		if (item != null)
		{
			return new StrokeSyncEndRemote(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSyncCancelRemote? Clone(StrokeSyncCancelRemote? item)
	{
		if (item != null)
		{
			return new StrokeSyncCancelRemote(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSyncSetEnabled? Clone(StrokeSyncSetEnabled? item)
	{
		if (item != null)
		{
			return new StrokeSyncSetEnabled(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSyncGetCurrent? Clone(StrokeSyncGetCurrent? item)
	{
		if (item != null)
		{
			return new StrokeSyncGetCurrent(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetTool? Clone(StrokeSetTool? item)
	{
		if (item != null)
		{
			return new StrokeSetTool(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeEraseRemote? Clone(StrokeEraseRemote? item)
	{
		if (item != null)
		{
			return new StrokeEraseRemote(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetFillColor? Clone(StrokeSetFillColor? item)
	{
		if (item != null)
		{
			return new StrokeSetFillColor(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetHasOutline? Clone(StrokeSetHasOutline? item)
	{
		if (item != null)
		{
			return new StrokeSetHasOutline(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeDrawComplete? Clone(StrokeDrawComplete? item)
	{
		if (item != null)
		{
			return new StrokeDrawComplete(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetAnchorMode? Clone(StrokeSetAnchorMode? item)
	{
		if (item != null)
		{
			return new StrokeSetAnchorMode(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetAnchorTarget? Clone(StrokeSetAnchorTarget? item)
	{
		if (item != null)
		{
			return new StrokeSetAnchorTarget(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetPressureWidth? Clone(StrokeSetPressureWidth? item)
	{
		if (item != null)
		{
			return new StrokeSetPressureWidth(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static TouchPanSettings? Clone(TouchPanSettings? item)
	{
		if (item != null)
		{
			return new TouchPanSettings(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetCameraLock? Clone(StrokeSetCameraLock? item)
	{
		if (item != null)
		{
			return new StrokeSetCameraLock(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static PenEraserSettings? Clone(PenEraserSettings? item)
	{
		if (item != null)
		{
			return new PenEraserSettings(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static PenCursorSettings? Clone(PenCursorSettings? item)
	{
		if (item != null)
		{
			return new PenCursorSettings(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AnchorClickSettings? Clone(AnchorClickSettings? item)
	{
		if (item != null)
		{
			return new AnchorClickSettings(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSetWorldConstraint? Clone(StrokeSetWorldConstraint? item)
	{
		if (item != null)
		{
			return new StrokeSetWorldConstraint(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StrokeSyncFlush? Clone(StrokeSyncFlush? item)
	{
		if (item != null)
		{
			return new StrokeSyncFlush(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EphemeralType Clone(EphemeralType item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static Feature Clone(Feature item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static GizmoModeChange Clone(GizmoModeChange item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static GizmoSpaceChange Clone(GizmoSpaceChange item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static HudPanelAlignX Clone(HudPanelAlignX item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static HudPanelAlignY Clone(HudPanelAlignY item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static HudPanelRowState Clone(HudPanelRowState item)
	{
		return item;
	}

	public static RequestKind Clone(RequestKind item)
	{
		byte discriminator = item.Discriminator;
		switch (discriminator)
		{
		case 1:
			return new RequestKind(Clone(item.Item1));
		case 2:
			return new RequestKind(Clone(item.Item2));
		case 3:
			return new RequestKind(Clone(item.Item3));
		case 4:
			return new RequestKind(Clone(item.Item4));
		case 5:
			return new RequestKind(Clone(item.Item5));
		case 6:
			return new RequestKind(Clone(item.Item6));
		case 7:
			return new RequestKind(Clone(item.Item7));
		case 8:
			return new RequestKind(Clone(item.Item8));
		case 9:
			return new RequestKind(Clone(item.Item9));
		case 10:
			return new RequestKind(Clone(item.Item10));
		case 11:
			return new RequestKind(Clone(item.Item11));
		case 12:
			return new RequestKind(Clone(item.Item12));
		case 13:
			return new RequestKind(Clone(item.Item13));
		case 14:
			return new RequestKind(Clone(item.Item14));
		case 15:
			return new RequestKind(Clone(item.Item15));
		case 16:
			return new RequestKind(Clone(item.Item16));
		case 17:
			return new RequestKind(Clone(item.Item17));
		case 18:
			return new RequestKind(Clone(item.Item18));
		case 19:
			return new RequestKind(Clone(item.Item19));
		case 20:
			return new RequestKind(Clone(item.Item20));
		case 21:
			return new RequestKind(Clone(item.Item21));
		case 22:
			return new RequestKind(Clone(item.Item22));
		case 23:
			return new RequestKind(Clone(item.Item23));
		case 24:
			return new RequestKind(Clone(item.Item24));
		case 25:
			return new RequestKind(Clone(item.Item25));
		case 26:
			return new RequestKind(Clone(item.Item26));
		case 27:
			return new RequestKind(Clone(item.Item27));
		case 28:
			return new RequestKind(Clone(item.Item28));
		case 29:
			return new RequestKind(Clone(item.Item29));
		case 30:
			return new RequestKind(Clone(item.Item30));
		case 31:
			return new RequestKind(Clone(item.Item31));
		case 32:
			return new RequestKind(Clone(item.Item32));
		case 33:
			return new RequestKind(Clone(item.Item33));
		case 34:
			return new RequestKind(Clone(item.Item34));
		case 35:
			return new RequestKind(Clone(item.Item35));
		case 36:
			return new RequestKind(Clone(item.Item36));
		case 37:
			return new RequestKind(Clone(item.Item37));
		case 38:
			return new RequestKind(Clone(item.Item38));
		case 39:
			return new RequestKind(Clone(item.Item39));
		case 40:
			return new RequestKind(Clone(item.Item40));
		case 41:
			return new RequestKind(Clone(item.Item41));
		case 42:
			return new RequestKind(Clone(item.Item42));
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<RequestKind>(discriminator);
			return default;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static RegisterService? Clone(RegisterService? item)
	{
		if (item != null)
		{
			return new RegisterService(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ConfigService? Clone(ConfigService? item)
	{
		if (item != null)
		{
			return new ConfigService(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static UnregisterService? Clone(UnregisterService? item)
	{
		if (item != null)
		{
			return new UnregisterService(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static EphemeralAction? Clone(EphemeralAction? item)
	{
		if (item != null)
		{
			return new EphemeralAction(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AuthenticationStart? Clone(AuthenticationStart? item)
	{
		if (item != null)
		{
			return new AuthenticationStart(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AuthenticationVerify? Clone(AuthenticationVerify? item)
	{
		if (item != null)
		{
			return new AuthenticationVerify(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static DrawingStateAction? Clone(DrawingStateAction? item)
	{
		if (item != null)
		{
			return new DrawingStateAction(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AssetCreate? Clone(AssetCreate? item)
	{
		if (item != null)
		{
			return new AssetCreate(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AssetCreateBatch? Clone(AssetCreateBatch? item)
	{
		if (item != null)
		{
			return new AssetCreateBatch(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static AssetDelete? Clone(AssetDelete? item)
	{
		if (item != null)
		{
			return new AssetDelete(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StreamTextureSDPOffer? Clone(StreamTextureSDPOffer? item)
	{
		if (item != null)
		{
			return new StreamTextureSDPOffer(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StreamTextureCloseSession? Clone(StreamTextureCloseSession? item)
	{
		if (item != null)
		{
			return new StreamTextureCloseSession(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetCameraTarget? Clone(SetCameraTarget? item)
	{
		if (item != null)
		{
			return new SetCameraTarget(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetCameraFollowEnabled? Clone(SetCameraFollowEnabled? item)
	{
		if (item != null)
		{
			return new SetCameraFollowEnabled(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IdentifyClient? Clone(IdentifyClient? item)
	{
		if (item != null)
		{
			return new IdentifyClient(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetCameraPath? Clone(SetCameraPath? item)
	{
		if (item != null)
		{
			return new SetCameraPath(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetGizmoState? Clone(SetGizmoState? item)
	{
		if (item != null)
		{
			return new SetGizmoState(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetClientCapabilities? Clone(SetClientCapabilities? item)
	{
		if (item != null)
		{
			return new SetClientCapabilities(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static HudPanelSet? Clone(HudPanelSet? item)
	{
		if (item != null)
		{
			return new HudPanelSet(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static HudLabelsSet? Clone(HudLabelsSet? item)
	{
		if (item != null)
		{
			return new HudLabelsSet(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StreamTextureCreateSDPOffer? Clone(StreamTextureCreateSDPOffer? item)
	{
		if (item != null)
		{
			return new StreamTextureCreateSDPOffer(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StreamTextureApplySDPAnswer? Clone(StreamTextureApplySDPAnswer? item)
	{
		if (item != null)
		{
			return new StreamTextureApplySDPAnswer(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static StreamTextureStatusRequest? Clone(StreamTextureStatusRequest? item)
	{
		if (item != null)
		{
			return new StreamTextureStatusRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetSceneEditorViewport? Clone(SetSceneEditorViewport? item)
	{
		if (item != null)
		{
			return new SetSceneEditorViewport(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static GetSceneEditorHudLayout? Clone(GetSceneEditorHudLayout? item)
	{
		if (item != null)
		{
			return new GetSceneEditorHudLayout(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetDirectedCameraTarget? Clone(SetDirectedCameraTarget? item)
	{
		if (item != null)
		{
			return new SetDirectedCameraTarget(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetReplayTime? Clone(SetReplayTime? item)
	{
		if (item != null)
		{
			return new SetReplayTime(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static GetRenderSettings? Clone(GetRenderSettings? item)
	{
		if (item != null)
		{
			return new GetRenderSettings(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetRenderSettings? Clone(SetRenderSettings? item)
	{
		if (item != null)
		{
			return new SetRenderSettings(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetSequence? Clone(SetSequence? item)
	{
		if (item != null)
		{
			return new SetSequence(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SequenceTransport? Clone(SequenceTransport? item)
	{
		if (item != null)
		{
			return new SequenceTransport(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SequenceStateRequest? Clone(SequenceStateRequest? item)
	{
		if (item != null)
		{
			return new SequenceStateRequest(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetCinematicCameraEditor? Clone(SetCinematicCameraEditor? item)
	{
		if (item != null)
		{
			return new SetCinematicCameraEditor(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static GetCinematicCameraPose? Clone(GetCinematicCameraPose? item)
	{
		if (item != null)
		{
			return new GetCinematicCameraPose(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetCinematicPropEditor? Clone(SetCinematicPropEditor? item)
	{
		if (item != null)
		{
			return new SetCinematicPropEditor(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetControllerCameraConfig? Clone(SetControllerCameraConfig? item)
	{
		if (item != null)
		{
			return new SetControllerCameraConfig(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetCameraPreviewConfiguration? Clone(SetCameraPreviewConfiguration? item)
	{
		if (item != null)
		{
			return new SetCameraPreviewConfiguration(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static ClearCameraPreviewConfiguration? Clone(ClearCameraPreviewConfiguration? item)
	{
		if (item != null)
		{
			return new ClearCameraPreviewConfiguration(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static GetCameraPreviewStatus? Clone(GetCameraPreviewStatus? item)
	{
		if (item != null)
		{
			return new GetCameraPreviewStatus(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static TakeCameraPreviewAux? Clone(TakeCameraPreviewAux? item)
	{
		if (item != null)
		{
			return new TakeCameraPreviewAux(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static SetAutoDirectorMainCamera? Clone(SetAutoDirectorMainCamera? item)
	{
		if (item != null)
		{
			return new SetAutoDirectorMainCamera(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ServiceType Clone(ServiceType item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static EdDSASig Clone(EdDSASig item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static DrawingCommand? Clone(DrawingCommand? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static ulong? Clone(ulong? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<AssetCreate>? Clone(IList<AssetCreate>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<IceServer>? Clone(IList<IceServer>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CameraPathKeyframe>? Clone(IList<CameraPathKeyframe>? item)
	{
		return VectorCloneHelpers.Clone(item);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<HudPanelRow>? Clone(IList<HudPanelRow>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<HudLabel>? Clone(IList<HudLabel>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static SequenceTransportCommand Clone(SequenceTransportCommand item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CinematicPropPath>? Clone(IList<CinematicPropPath>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewConfiguration? Clone(CameraPreviewConfiguration? item)
	{
		if (item != null)
		{
			return new CameraPreviewConfiguration(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewDirectorController? Clone(CameraPreviewDirectorController? item)
	{
		if (item != null)
		{
			return new CameraPreviewDirectorController(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IceServer? Clone(IceServer? item)
	{
		if (item != null)
		{
			return new IceServer(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPathKeyframe Clone(CameraPathKeyframe item)
	{
		return item;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static HudPanelRow? Clone(HudPanelRow? item)
	{
		if (item != null)
		{
			return new HudPanelRow(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static HudLabel? Clone(HudLabel? item)
	{
		if (item != null)
		{
			return new HudLabel(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicPropPath? Clone(CinematicPropPath? item)
	{
		if (item != null)
		{
			return new CinematicPropPath(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CameraPreviewCameraDefinition>? Clone(IList<CameraPreviewCameraDefinition>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CameraPreviewOutputDefinition>? Clone(IList<CameraPreviewOutputDefinition>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CameraPreviewDirectorTarget>? Clone(IList<CameraPreviewDirectorTarget>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CinematicPropKey>? Clone(IList<CinematicPropKey>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewCameraDefinition? Clone(CameraPreviewCameraDefinition? item)
	{
		if (item != null)
		{
			return new CameraPreviewCameraDefinition(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewOutputDefinition? Clone(CameraPreviewOutputDefinition? item)
	{
		if (item != null)
		{
			return new CameraPreviewOutputDefinition(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewDirectorTarget? Clone(CameraPreviewDirectorTarget? item)
	{
		if (item != null)
		{
			return new CameraPreviewDirectorTarget(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CinematicPropKey? Clone(CinematicPropKey? item)
	{
		if (item != null)
		{
			return new CinematicPropKey(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewController? Clone(CameraPreviewController? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static CameraPreviewLayout? Clone(CameraPreviewLayout? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewBorderStyle? Clone(CameraPreviewBorderStyle? item)
	{
		if (item != null)
		{
			return new CameraPreviewBorderStyle(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewTransition? Clone(CameraPreviewTransition? item)
	{
		if (item != null)
		{
			return new CameraPreviewTransition(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static IList<CameraPreviewGradientStop>? Clone(IList<CameraPreviewGradientStop>? item)
	{
		return VectorCloneHelpers.Clone(item, Clone);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewGradientStop? Clone(CameraPreviewGradientStop? item)
	{
		if (item != null)
		{
			return new CameraPreviewGradientStop(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static CameraPreviewOklchColor? Clone(CameraPreviewOklchColor? item)
	{
		if (item != null)
		{
			return new CameraPreviewOklchColor(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	[return: NotNullIfNotNull("item")]
	public static Request? Clone(Request? item)
	{
		if (item != null)
		{
			return new Request(item);
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static RequestKind? Clone(RequestKind? item)
	{
		if (item.HasValue)
		{
			return Clone(item.Value);
		}
		return null;
	}
}
