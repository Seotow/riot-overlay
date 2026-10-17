namespace BlueBottleIPC.LeagueBroadcast.Common;

public static class Matrix4x4__FlatSharpExtensions
{
	public static ref float M(this ref Matrix4x4 item, int index)
	{
		return ref Matrix4x4.M_Item(ref item, index);
	}
}
