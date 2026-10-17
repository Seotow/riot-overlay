using System.IO;

namespace Farsight.BBObject;

public sealed class ScriptAssetConflictException : IOException
{
	public ScriptAssetConflictException(string message)
		: base(message)
	{
	}
}
