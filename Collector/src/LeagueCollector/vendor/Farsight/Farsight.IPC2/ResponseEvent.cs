using BlueBottleIPC.LeagueBroadcast.Snapshot;

namespace Farsight.IPC2;

public struct ResponseEvent(Response response)
{
	public Response Response { get; private set; } = response;
}
