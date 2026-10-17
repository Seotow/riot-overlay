using System;

namespace Farsight.Exceptions;

public class NotSpectatorException : Exception
{
	public NotSpectatorException()
		: base("Not a spectator client.")
	{
	}

	public NotSpectatorException(string message)
		: base(message)
	{
	}

	public NotSpectatorException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
