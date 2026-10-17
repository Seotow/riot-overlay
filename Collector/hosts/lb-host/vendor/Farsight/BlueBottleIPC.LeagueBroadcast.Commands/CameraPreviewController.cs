using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[CompilerGenerated]
public struct CameraPreviewController : IFlatBufferUnion<CameraPreviewFocusTargetsController, CameraPreviewFixedPoseController, CameraPreviewCinematicEditorController>, IFlatBufferUnion
{
	public enum ItemKind : byte
	{
		CameraPreviewFocusTargetsController = 1,
		CameraPreviewFixedPoseController = 2,
		CameraPreviewCinematicEditorController = 3,
		NONE = 0
	}

	public interface Visitor<TReturn> : IFlatBufferUnionVisitor<TReturn, CameraPreviewFocusTargetsController, CameraPreviewFixedPoseController, CameraPreviewCinematicEditorController>
	{
	}

	private readonly object value;

	public ItemKind Kind => (ItemKind)Discriminator;

	public byte Discriminator { get; }

	public CameraPreviewFocusTargetsController CameraPreviewFocusTargetsController => Item1;

	public CameraPreviewFocusTargetsController Item1
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

	public CameraPreviewFixedPoseController CameraPreviewFixedPoseController => Item2;

	public CameraPreviewFixedPoseController Item2
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

	public CameraPreviewCinematicEditorController CameraPreviewCinematicEditorController => Item3;

	public CameraPreviewCinematicEditorController Item3
	{
		get
		{
			if (Discriminator != 3)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem3();
		}
	}

	public CameraPreviewController(CameraPreviewFocusTargetsController value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 1;
		this.value = value;
	}

	public static implicit operator CameraPreviewController(CameraPreviewFocusTargetsController value)
	{
		return new CameraPreviewController(value);
	}

	private CameraPreviewFocusTargetsController UncheckedGetItem1()
	{
		return (CameraPreviewFocusTargetsController)value;
	}

	public bool TryGet([NotNullWhen(true)] out CameraPreviewFocusTargetsController? value)
	{
		if (Discriminator != 1)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem1();
		return true;
	}

	public CameraPreviewController(CameraPreviewFixedPoseController value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 2;
		this.value = value;
	}

	public static implicit operator CameraPreviewController(CameraPreviewFixedPoseController value)
	{
		return new CameraPreviewController(value);
	}

	private CameraPreviewFixedPoseController UncheckedGetItem2()
	{
		return (CameraPreviewFixedPoseController)value;
	}

	public bool TryGet([NotNullWhen(true)] out CameraPreviewFixedPoseController? value)
	{
		if (Discriminator != 2)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem2();
		return true;
	}

	public CameraPreviewController(CameraPreviewCinematicEditorController value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 3;
		this.value = value;
	}

	public static implicit operator CameraPreviewController(CameraPreviewCinematicEditorController value)
	{
		return new CameraPreviewController(value);
	}

	private CameraPreviewCinematicEditorController UncheckedGetItem3()
	{
		return (CameraPreviewCinematicEditorController)value;
	}

	public bool TryGet([NotNullWhen(true)] out CameraPreviewCinematicEditorController? value)
	{
		if (Discriminator != 3)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem3();
		return true;
	}

	public TReturn Accept<TVisitor, TReturn>(TVisitor visitor) where TVisitor : IFlatBufferUnionVisitor<TReturn, CameraPreviewFocusTargetsController, CameraPreviewFixedPoseController, CameraPreviewCinematicEditorController>
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
			CameraPreviewFocusTargetsController item2 = UncheckedGetItem1();
			return reference2.Visit(item2);
		}
		case 2:
		{
			ref TVisitor reference3 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference3;
				reference3 = ref val;
			}
			CameraPreviewFixedPoseController item3 = UncheckedGetItem2();
			return reference3.Visit(item3);
		}
		case 3:
		{
			ref TVisitor reference = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference;
				reference = ref val;
			}
			CameraPreviewCinematicEditorController item = UncheckedGetItem3();
			return reference.Visit(item);
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewController>(discriminator);
			return default;
		}
	}

	public TReturn Match<TReturn>(Func<CameraPreviewFocusTargetsController, TReturn> caseCameraPreviewFocusTargetsController, Func<CameraPreviewFixedPoseController, TReturn> caseCameraPreviewFixedPoseController, Func<CameraPreviewCinematicEditorController, TReturn> caseCameraPreviewCinematicEditorController)
	{
		byte discriminator = Discriminator;
		switch (discriminator)
		{
		case 1:
			return caseCameraPreviewFocusTargetsController(UncheckedGetItem1());
		case 2:
			return caseCameraPreviewFixedPoseController(UncheckedGetItem2());
		case 3:
			return caseCameraPreviewCinematicEditorController(UncheckedGetItem3());
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<CameraPreviewController>(discriminator);
			return default;
		}
	}
}
