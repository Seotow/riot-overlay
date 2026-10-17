namespace BlueBottleIPC.LeagueBroadcast.Snapshot;

public static class Challenge__FlatSharpExtensions
{
	public static ref byte Data(this ref Challenge item, int index)
	{
		return ref Challenge.Data_Item(ref item, index);
	}
}
