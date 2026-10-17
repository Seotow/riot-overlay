using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Attributes;
using FlatSharp.Compiler.Generated;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

[FlatBufferStruct]
[CompilerGenerated]
[DebuggerTypeProxy("BlueBottleIPC.LeagueBroadcast.Snapshot.DeathEvent")]
public class DeathEvent
{
	public class __GoldByTeam_Vector : IEnumerable<float>, IEnumerable
	{
		private readonly DeathEvent item;

		public int Count => 2;

		public float this[int index]
		{
			get
			{
				DeathEvent deathEvent = item;
				return index switch
				{
					0 => deathEvent.__flatsharp__GoldByTeam_0, 
					1 => deathEvent.__flatsharp__GoldByTeam_1, 
					_ => FSThrow.IndexOutOfRange<float>(), 
				};
			}
			set
			{
				DeathEvent deathEvent = item;
				switch (index)
				{
				case 0:
					deathEvent.__flatsharp__GoldByTeam_0 = value;
					break;
				case 1:
					deathEvent.__flatsharp__GoldByTeam_1 = value;
					break;
				default:
					FSThrow.IndexOutOfRange();
					break;
				}
			}
		}

		public __GoldByTeam_Vector(DeathEvent item)
		{
			this.item = item;
		}

		IEnumerator IEnumerable.GetEnumerator()
		{
			return GetEnumerator();
		}

		public IEnumerator<float> GetEnumerator()
		{
			DeathEvent thisItem = item;
			yield return thisItem.__flatsharp__GoldByTeam_0;
			yield return thisItem.__flatsharp__GoldByTeam_1;
		}

		public void CopyFrom(ReadOnlySpan<float> source)
		{
			DeathEvent deathEvent = item;
			ReadOnlySpan<float> readOnlySpan = source;
			deathEvent.__flatsharp__GoldByTeam_1 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[1]);
			deathEvent.__flatsharp__GoldByTeam_0 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(readOnlySpan[0]);
		}

		public void CopyFrom(IReadOnlyList<float> source)
		{
			DeathEvent deathEvent = item;
			deathEvent.__flatsharp__GoldByTeam_1 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[1]);
			deathEvent.__flatsharp__GoldByTeam_0 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source[0]);
		}
	}

	private __GoldByTeam_Vector? __GoldByTeam;

	[FlatBufferItem(0)]
	public virtual float GameTime { get; set; }

	[FlatBufferItem(1)]
	public virtual uint KillerNetworkId { get; set; }

	[FlatBufferItem(2)]
	public virtual uint VictimNetworkId { get; set; }

	[FlatBufferItem(3)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "GoldByTeam[0]")]
	protected virtual float __flatsharp__GoldByTeam_0 { get; set; }

	[FlatBufferItem(4)]
	[FlatBufferMetadata(FlatBufferMetadataKind.Accessor, "", "GoldByTeam[1]")]
	protected virtual float __flatsharp__GoldByTeam_1 { get; set; }

	public __GoldByTeam_Vector GoldByTeam => __GoldByTeam ?? (__GoldByTeam = new __GoldByTeam_Vector(this));

	static DeathEvent()
	{
	}

	public DeathEvent()
	{
	}

	protected DeathEvent(FlatBufferDeserializationContext context)
	{
	}

	[SetsRequiredMembers]
	public DeathEvent(DeathEvent source)
	{
		GameTime = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.GameTime);
		KillerNetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.KillerNetworkId);
		VictimNetworkId = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.VictimNetworkId);
		__flatsharp__GoldByTeam_0 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__GoldByTeam_0);
		__flatsharp__GoldByTeam_1 = CloneHelpers_7c83be20ee504926b8fb188858421982.Clone(source.__flatsharp__GoldByTeam_1);
	}

	protected void OnFlatSharpDeserialized(FlatBufferDeserializationContext context)
	{
	}
}
