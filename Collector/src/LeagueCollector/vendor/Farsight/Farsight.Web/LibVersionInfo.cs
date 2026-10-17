using System;

namespace Farsight.Web;

public struct LibVersionInfo
{
	public string Name { get; set; } = "";

	public Version MinVersion { get; set; } = new Version(0, 0, 0, 0);

	public Version? MaxVersion { get; set; } = null;

	public LibVersionInfo()
	{
	}
}
