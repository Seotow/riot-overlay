using System;

namespace Farsight.Exceptions;

internal class SnapshotDeserializationException : Exception
{
	public SnapshotDeserializationException()
		: base("Failed to deserialize snapshot.")
	{
	}

	public SnapshotDeserializationException(string message)
		: base(message)
	{
	}

	public SnapshotDeserializationException(string message, Exception innerException)
		: base(message, innerException)
	{
	}
}
