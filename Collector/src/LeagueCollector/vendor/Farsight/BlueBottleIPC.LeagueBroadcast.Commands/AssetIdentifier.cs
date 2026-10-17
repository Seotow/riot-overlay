using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[CompilerGenerated]
public struct AssetIdentifier : IFlatBufferUnion<IdWrapper, string>, IFlatBufferUnion
{
	public enum ItemKind : byte
	{
		id = 1,
		name = 2,
		NONE = 0
	}

	public interface Visitor<TReturn> : IFlatBufferUnionVisitor<TReturn, IdWrapper, string>
	{
	}

	private readonly object value;

	public ItemKind Kind => (ItemKind)Discriminator;

	public byte Discriminator { get; }

	public IdWrapper id => Item1;

	public IdWrapper Item1
	{
		get
		{
			if (Discriminator != 1)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem1();
		}
	}

	public string name => Item2;

	public string Item2
	{
		get
		{
			if (Discriminator != 2)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem2();
		}
	}

	public AssetIdentifier(IdWrapper value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 1;
		this.value = value;
	}

	public static implicit operator AssetIdentifier(IdWrapper value)
	{
		return new AssetIdentifier(value);
	}

	private IdWrapper UncheckedGetItem1()
	{
		return (IdWrapper)value;
	}

	public bool TryGet([NotNullWhen(true)] out IdWrapper? value)
	{
		if (Discriminator != 1)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem1();
		return true;
	}

	public AssetIdentifier(string value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 2;
		this.value = value;
	}

	public static implicit operator AssetIdentifier(string value)
	{
		return new AssetIdentifier(value);
	}

	private string UncheckedGetItem2()
	{
		return (string)value;
	}

	public bool TryGet([NotNullWhen(true)] out string? value)
	{
		if (Discriminator != 2)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem2();
		return true;
	}

	public TReturn Accept<TVisitor, TReturn>(TVisitor visitor) where TVisitor : IFlatBufferUnionVisitor<TReturn, IdWrapper, string>
	{
		byte discriminator = Discriminator;
		TVisitor val;
		switch (discriminator)
		{
		case 1:
		{
			ref TVisitor reference2 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference2;
				reference2 = ref val;
			}
			IdWrapper item2 = UncheckedGetItem1();
			return reference2.Visit(item2);
		}
		case 2:
		{
			ref TVisitor reference = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference;
				reference = ref val;
			}
			string item = UncheckedGetItem2();
			return reference.Visit(item);
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<AssetIdentifier>(discriminator);
			return default;
		}
	}

	public TReturn Match<TReturn>(Func<IdWrapper, TReturn> caseid, Func<string, TReturn> casename)
	{
		byte discriminator = Discriminator;
		switch (discriminator)
		{
		case 1:
			return caseid(UncheckedGetItem1());
		case 2:
			return casename(UncheckedGetItem2());
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<AssetIdentifier>(discriminator);
			return default;
		}
	}
}
