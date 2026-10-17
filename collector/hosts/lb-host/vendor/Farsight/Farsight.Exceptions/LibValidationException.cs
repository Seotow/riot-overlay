using System;

namespace Farsight.Exceptions;

public class LibValidationException : Exception
{
	public LibValidationException()
		: base("Library validation failed.")
	{
	}

	public LibValidationException(string message)
		: base(message)
	{
	}

	public LibValidationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
