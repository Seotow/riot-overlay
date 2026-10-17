using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[CompilerGenerated]
public struct CameraPreviewLayout : IFlatBufferUnion<CameraPreviewStripLayout, CameraPreviewPipLayout>, IFlatBufferUnion
{
	public enum ItemKind : byte
	{
		CameraPreviewStripLayout = 1,
		CameraPreviewPipLayout = 2,
		NONE = 0
	}

	public interface Visitor<TReturn> : IFlatBufferUnionVisitor<TReturn, CameraPreviewStripLayout, CameraPreviewPipLayout>
	{
	}

	private readonly object value;

	public ItemKind Kind => (ItemKind)Discriminator;

	public byte Discriminator { get; }

	public CameraPreviewStripLayout CameraPreviewStripLayout => Item1;

	public CameraPreviewStripLayout Item1
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

	public CameraPreviewPipLayout CameraPreviewPipLayout => Item2;

	public CameraPreviewPipLayout Item2
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

	public CameraPreviewLayout(CameraPreviewStripLayout value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 1;
		this.value = value;
	}

	public static implicit operator CameraPreviewLayout(CameraPreviewStripLayout value)
	{
		return new CameraPreviewLayout(value);
	}

	private CameraPreviewStripLayout UncheckedGetItem1()
	{
		return (CameraPreviewStripLayout)value;
	}

	public bool TryGet([NotNullWhen(true)] out CameraPreviewStripLayout? value)
	{
		if (Discriminator != 1)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem1();
		return true;
	}

	public CameraPreviewLayout(CameraPreviewPipLayout value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 2;
		this.value = value;
	}

	public static implicit operator CameraPreviewLayout(CameraPreviewPipLayout value)
	{
		return new CameraPreviewLayout(value);
	}

	private CameraPreviewPipLayout UncheckedGetItem2()
	{
		return (CameraPreviewPipLayout)value;
	}

	public bool TryGet([NotNullWhen(true)] out CameraPreviewPipLayout? value)
	{
		if (Discriminator != 2)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem2();
		return true;
	}

	public TReturn Accept<TVisitor, TReturn>(TVisitor visitor) where TVisitor : IFlatBufferUnionVisitor<TReturn, CameraPreviewStripLayout, CameraPreviewPipLayout>
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
			CameraPreviewStripLayout item2 = UncheckedGetItem1();
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
			CameraPreviewPipLayout item = UncheckedGetItem2();
			return reference.Visit(item);
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewLayout>(discriminator);
			return default;
		}
	}

	public TReturn Match<TReturn>(Func<CameraPreviewStripLayout, TReturn> caseCameraPreviewStripLayout, Func<CameraPreviewPipLayout, TReturn> caseCameraPreviewPipLayout)
	{
		byte discriminator = Discriminator;
		switch (discriminator)
		{
		case 1:
			return caseCameraPreviewStripLayout(UncheckedGetItem1());
		case 2:
			return caseCameraPreviewPipLayout(UncheckedGetItem2());
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewLayout>(discriminator);
			return default;
		}
	}
}
