using System;

namespace Farsight.Exceptions;

public class LibLoadException : Exception
{
	public LibLoadException()
		: base("Failed to load the library.")
	{
	}

	public LibLoadException(string message)
		: base(message)
	{
	}

	public LibLoadException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
