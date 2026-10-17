using System;

namespace Farsight.Exceptions;

public class GameVersionNotFoundException : Exception
{
	public GameVersionNotFoundException(string message)
		: base(message)
	{
	}

	public GameVersionNotFoundException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
