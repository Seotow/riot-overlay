namespace BlueBottleIPC.LeagueBroadcast.Common;

public static class Matrix3x3__FlatSharpExtensions
{
	public static ref float M(this ref Matrix3x3 item, int index)
	{
		return ref Matrix3x3.M_Item(ref item, index);
	}
}
