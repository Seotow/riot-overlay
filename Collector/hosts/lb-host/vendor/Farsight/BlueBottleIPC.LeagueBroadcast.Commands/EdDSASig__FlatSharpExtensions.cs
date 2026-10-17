namespace BlueBottleIPC.LeagueBroadcast.Commands;

public static class EdDSASig__FlatSharpExtensions
{
	public static ref byte Data(this ref EdDSASig item, int index)
	{
		return ref EdDSASig.Data_Item(ref item, index);
	}
}
