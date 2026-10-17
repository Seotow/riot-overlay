using System;
using System.Collections.Generic;

namespace Farsight.BBObject;

public class SelectionChangedEventArgs(IReadOnlyList<ulong> selectedIds) : EventArgs
{
	public IReadOnlyList<ulong> SelectedIds { get; } = selectedIds;
}
