namespace LeagueCollector;

// Verification facts, not inferred from login success or an empty feature set.
public static class ProjectStatus
{
    public static object Current => new
    {
        release = "2026-10-14-status-update",
        nativeGameTested = false,
        freeTierParityVerified = false,
        unauthenticatedNativeVerified = false,
        nativeCppSourceComplete = false,
        nativeDependency = "original lblib.dll",
        subscriptionLookup = "previous_authenticated_lookup_returned_404",
        nativeEvents = "raw_snapshot_events; objective classification not integrated",
        serializer = "some native struct inline vectors are not exported",
        documentation = "STATUS.vi.md"
    };
}
