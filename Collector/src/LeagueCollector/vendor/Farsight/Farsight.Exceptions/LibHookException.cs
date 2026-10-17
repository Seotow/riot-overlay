using System;

namespace Farsight.Exceptions;

public class LibHookException : Exception
{
	public LibHookException()
		: base("Failed to hook into the game.")
	{
	}

	public LibHookException(string message)
		: base(message)
	{
	}

	public LibHookException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
