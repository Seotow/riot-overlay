using System.Collections.Generic;

namespace Farsight;

public class StrokeSyncState
{
	public required IReadOnlyList<CompletedStrokeData> CompletedStrokes { get; init; }

	public required IReadOnlyList<InProgressStrokeData> InProgressStrokes { get; init; }
}
