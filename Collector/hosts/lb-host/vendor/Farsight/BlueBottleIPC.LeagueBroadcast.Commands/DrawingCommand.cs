using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Commands;

[CompilerGenerated]
public struct DrawingCommand : IFlatBufferUnion<StrokeSetActive, StrokeSetLayer, StrokeSetColor, StrokeSetWidth, StrokeUndo, StrokeRedo, StrokeClear, StrokeSetTipStyle, GetStrokeProperties, StrokeSetLineStyle, StrokeSetVanishTime, StrokeSetTimeMode, StrokeSyncBeginRemote, StrokeSyncPointsRemote, StrokeSyncEndRemote, StrokeSyncCancelRemote, StrokeSyncSetEnabled, StrokeSyncCurrent, StrokeSyncGetCurrent, StrokeSetTool, StrokeEraseRemote, StrokeSetFillColor, StrokeSetHasOutline, StrokeDrawComplete, StrokeSetAnchorMode, StrokeSetAnchorTarget, StrokeSetPressureWidth, TouchPanSettings, StrokeSetCameraLock, PenEraserSettings, PenCursorSettings, AnchorClickSettings, StrokeSetWorldConstraint, StrokeSyncFlush>, IFlatBufferUnion
{
	public enum ItemKind : byte
	{
		StrokeSetActive = 1,
		StrokeSetLayer = 2,
		StrokeSetColor = 3,
		StrokeSetWidth = 4,
		StrokeUndo = 5,
		StrokeRedo = 6,
		StrokeClear = 7,
		StrokeSetTipStyle = 8,
		GetStrokeProperties = 9,
		StrokeSetLineStyle = 10,
		StrokeSetVanishTime = 11,
		StrokeSetTimeMode = 12,
		StrokeSyncBeginRemote = 13,
		StrokeSyncPointsRemote = 14,
		StrokeSyncEndRemote = 15,
		StrokeSyncCancelRemote = 16,
		StrokeSyncSetEnabled = 17,
		StrokeSyncCurrent = 18,
		StrokeSyncGetCurrent = 19,
		StrokeSetTool = 20,
		StrokeEraseRemote = 21,
		StrokeSetFillColor = 22,
		StrokeSetHasOutline = 23,
		StrokeDrawComplete = 24,
		StrokeSetAnchorMode = 25,
		StrokeSetAnchorTarget = 26,
		StrokeSetPressureWidth = 27,
		TouchPanSettings = 28,
		StrokeSetCameraLock = 29,
		PenEraserSettings = 30,
		PenCursorSettings = 31,
		AnchorClickSettings = 32,
		StrokeSetWorldConstraint = 33,
		StrokeSyncFlush = 34,
		NONE = 0
	}

	public interface Visitor<TReturn> : IFlatBufferUnionVisitor<TReturn, StrokeSetActive, StrokeSetLayer, StrokeSetColor, StrokeSetWidth, StrokeUndo, StrokeRedo, StrokeClear, StrokeSetTipStyle, GetStrokeProperties, StrokeSetLineStyle, StrokeSetVanishTime, StrokeSetTimeMode, StrokeSyncBeginRemote, StrokeSyncPointsRemote, StrokeSyncEndRemote, StrokeSyncCancelRemote, StrokeSyncSetEnabled, StrokeSyncCurrent, StrokeSyncGetCurrent, StrokeSetTool, StrokeEraseRemote, StrokeSetFillColor, StrokeSetHasOutline, StrokeDrawComplete, StrokeSetAnchorMode, StrokeSetAnchorTarget, StrokeSetPressureWidth, TouchPanSettings, StrokeSetCameraLock, PenEraserSettings, PenCursorSettings, AnchorClickSettings, StrokeSetWorldConstraint, StrokeSyncFlush>
	{
	}

	private readonly object value;

	public ItemKind Kind => (ItemKind)Discriminator;

	public byte Discriminator { get; }

	public StrokeSetActive StrokeSetActive => Item1;

	public StrokeSetActive Item1
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

	public StrokeSetLayer StrokeSetLayer => Item2;

	public StrokeSetLayer Item2
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

	public StrokeSetColor StrokeSetColor => Item3;

	public StrokeSetColor Item3
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

	public StrokeSetWidth StrokeSetWidth => Item4;

	public StrokeSetWidth Item4
	{
		get
		{
			if (Discriminator != 4)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem4();
		}
	}

	public StrokeUndo StrokeUndo => Item5;

	public StrokeUndo Item5
	{
		get
		{
			if (Discriminator != 5)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem5();
		}
	}

	public StrokeRedo StrokeRedo => Item6;

	public StrokeRedo Item6
	{
		get
		{
			if (Discriminator != 6)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem6();
		}
	}

	public StrokeClear StrokeClear => Item7;

	public StrokeClear Item7
	{
		get
		{
			if (Discriminator != 7)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem7();
		}
	}

	public StrokeSetTipStyle StrokeSetTipStyle => Item8;

	public StrokeSetTipStyle Item8
	{
		get
		{
			if (Discriminator != 8)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem8();
		}
	}

	public GetStrokeProperties GetStrokeProperties => Item9;

	public GetStrokeProperties Item9
	{
		get
		{
			if (Discriminator != 9)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem9();
		}
	}

	public StrokeSetLineStyle StrokeSetLineStyle => Item10;

	public StrokeSetLineStyle Item10
	{
		get
		{
			if (Discriminator != 10)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem10();
		}
	}

	public StrokeSetVanishTime StrokeSetVanishTime => Item11;

	public StrokeSetVanishTime Item11
	{
		get
		{
			if (Discriminator != 11)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem11();
		}
	}

	public StrokeSetTimeMode StrokeSetTimeMode => Item12;

	public StrokeSetTimeMode Item12
	{
		get
		{
			if (Discriminator != 12)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem12();
		}
	}

	public StrokeSyncBeginRemote StrokeSyncBeginRemote => Item13;

	public StrokeSyncBeginRemote Item13
	{
		get
		{
			if (Discriminator != 13)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem13();
		}
	}

	public StrokeSyncPointsRemote StrokeSyncPointsRemote => Item14;

	public StrokeSyncPointsRemote Item14
	{
		get
		{
			if (Discriminator != 14)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem14();
		}
	}

	public StrokeSyncEndRemote StrokeSyncEndRemote => Item15;

	public StrokeSyncEndRemote Item15
	{
		get
		{
			if (Discriminator != 15)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem15();
		}
	}

	public StrokeSyncCancelRemote StrokeSyncCancelRemote => Item16;

	public StrokeSyncCancelRemote Item16
	{
		get
		{
			if (Discriminator != 16)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem16();
		}
	}

	public StrokeSyncSetEnabled StrokeSyncSetEnabled => Item17;

	public StrokeSyncSetEnabled Item17
	{
		get
		{
			if (Discriminator != 17)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem17();
		}
	}

	public StrokeSyncCurrent StrokeSyncCurrent => Item18;

	public StrokeSyncCurrent Item18
	{
		get
		{
			if (Discriminator != 18)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem18();
		}
	}

	public StrokeSyncGetCurrent StrokeSyncGetCurrent => Item19;

	public StrokeSyncGetCurrent Item19
	{
		get
		{
			if (Discriminator != 19)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem19();
		}
	}

	public StrokeSetTool StrokeSetTool => Item20;

	public StrokeSetTool Item20
	{
		get
		{
			if (Discriminator != 20)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem20();
		}
	}

	public StrokeEraseRemote StrokeEraseRemote => Item21;

	public StrokeEraseRemote Item21
	{
		get
		{
			if (Discriminator != 21)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem21();
		}
	}

	public StrokeSetFillColor StrokeSetFillColor => Item22;

	public StrokeSetFillColor Item22
	{
		get
		{
			if (Discriminator != 22)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem22();
		}
	}

	public StrokeSetHasOutline StrokeSetHasOutline => Item23;

	public StrokeSetHasOutline Item23
	{
		get
		{
			if (Discriminator != 23)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem23();
		}
	}

	public StrokeDrawComplete StrokeDrawComplete => Item24;

	public StrokeDrawComplete Item24
	{
		get
		{
			if (Discriminator != 24)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem24();
		}
	}

	public StrokeSetAnchorMode StrokeSetAnchorMode => Item25;

	public StrokeSetAnchorMode Item25
	{
		get
		{
			if (Discriminator != 25)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem25();
		}
	}

	public StrokeSetAnchorTarget StrokeSetAnchorTarget => Item26;

	public StrokeSetAnchorTarget Item26
	{
		get
		{
			if (Discriminator != 26)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem26();
		}
	}

	public StrokeSetPressureWidth StrokeSetPressureWidth => Item27;

	public StrokeSetPressureWidth Item27
	{
		get
		{
			if (Discriminator != 27)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem27();
		}
	}

	public TouchPanSettings TouchPanSettings => Item28;

	public TouchPanSettings Item28
	{
		get
		{
			if (Discriminator != 28)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem28();
		}
	}

	public StrokeSetCameraLock StrokeSetCameraLock => Item29;

	public StrokeSetCameraLock Item29
	{
		get
		{
			if (Discriminator != 29)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem29();
		}
	}

	public PenEraserSettings PenEraserSettings => Item30;

	public PenEraserSettings Item30
	{
		get
		{
			if (Discriminator != 30)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem30();
		}
	}

	public PenCursorSettings PenCursorSettings => Item31;

	public PenCursorSettings Item31
	{
		get
		{
			if (Discriminator != 31)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem31();
		}
	}

	public AnchorClickSettings AnchorClickSettings => Item32;

	public AnchorClickSettings Item32
	{
		get
		{
			if (Discriminator != 32)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem32();
		}
	}

	public StrokeSetWorldConstraint StrokeSetWorldConstraint => Item33;

	public StrokeSetWorldConstraint Item33
	{
		get
		{
			if (Discriminator != 33)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem33();
		}
	}

	public StrokeSyncFlush StrokeSyncFlush => Item34;

	public StrokeSyncFlush Item34
	{
		get
		{
			if (Discriminator != 34)
			{
				FSThrow.InvalidOperation_UnionIsNotOfType();
			}
			return UncheckedGetItem34();
		}
	}

	public DrawingCommand(StrokeSetActive value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 1;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetActive value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetActive UncheckedGetItem1()
	{
		return (StrokeSetActive)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetActive? value)
	{
		if (Discriminator != 1)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem1();
		return true;
	}

	public DrawingCommand(StrokeSetLayer value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 2;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetLayer value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetLayer UncheckedGetItem2()
	{
		return (StrokeSetLayer)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetLayer? value)
	{
		if (Discriminator != 2)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem2();
		return true;
	}

	public DrawingCommand(StrokeSetColor value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 3;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetColor value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetColor UncheckedGetItem3()
	{
		return (StrokeSetColor)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetColor? value)
	{
		if (Discriminator != 3)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem3();
		return true;
	}

	public DrawingCommand(StrokeSetWidth value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 4;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetWidth value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetWidth UncheckedGetItem4()
	{
		return (StrokeSetWidth)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetWidth? value)
	{
		if (Discriminator != 4)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem4();
		return true;
	}

	public DrawingCommand(StrokeUndo value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 5;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeUndo value)
	{
		return new DrawingCommand(value);
	}

	private StrokeUndo UncheckedGetItem5()
	{
		return (StrokeUndo)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeUndo? value)
	{
		if (Discriminator != 5)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem5();
		return true;
	}

	public DrawingCommand(StrokeRedo value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 6;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeRedo value)
	{
		return new DrawingCommand(value);
	}

	private StrokeRedo UncheckedGetItem6()
	{
		return (StrokeRedo)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeRedo? value)
	{
		if (Discriminator != 6)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem6();
		return true;
	}

	public DrawingCommand(StrokeClear value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 7;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeClear value)
	{
		return new DrawingCommand(value);
	}

	private StrokeClear UncheckedGetItem7()
	{
		return (StrokeClear)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeClear? value)
	{
		if (Discriminator != 7)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem7();
		return true;
	}

	public DrawingCommand(StrokeSetTipStyle value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 8;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetTipStyle value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetTipStyle UncheckedGetItem8()
	{
		return (StrokeSetTipStyle)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetTipStyle? value)
	{
		if (Discriminator != 8)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem8();
		return true;
	}

	public DrawingCommand(GetStrokeProperties value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 9;
		this.value = value;
	}

	public static implicit operator DrawingCommand(GetStrokeProperties value)
	{
		return new DrawingCommand(value);
	}

	private GetStrokeProperties UncheckedGetItem9()
	{
		return (GetStrokeProperties)value;
	}

	public bool TryGet([NotNullWhen(true)] out GetStrokeProperties? value)
	{
		if (Discriminator != 9)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem9();
		return true;
	}

	public DrawingCommand(StrokeSetLineStyle value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 10;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetLineStyle value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetLineStyle UncheckedGetItem10()
	{
		return (StrokeSetLineStyle)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetLineStyle? value)
	{
		if (Discriminator != 10)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem10();
		return true;
	}

	public DrawingCommand(StrokeSetVanishTime value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 11;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetVanishTime value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetVanishTime UncheckedGetItem11()
	{
		return (StrokeSetVanishTime)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetVanishTime? value)
	{
		if (Discriminator != 11)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem11();
		return true;
	}

	public DrawingCommand(StrokeSetTimeMode value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 12;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetTimeMode value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetTimeMode UncheckedGetItem12()
	{
		return (StrokeSetTimeMode)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetTimeMode? value)
	{
		if (Discriminator != 12)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem12();
		return true;
	}

	public DrawingCommand(StrokeSyncBeginRemote value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 13;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSyncBeginRemote value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSyncBeginRemote UncheckedGetItem13()
	{
		return (StrokeSyncBeginRemote)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncBeginRemote? value)
	{
		if (Discriminator != 13)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem13();
		return true;
	}

	public DrawingCommand(StrokeSyncPointsRemote value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 14;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSyncPointsRemote value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSyncPointsRemote UncheckedGetItem14()
	{
		return (StrokeSyncPointsRemote)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncPointsRemote? value)
	{
		if (Discriminator != 14)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem14();
		return true;
	}

	public DrawingCommand(StrokeSyncEndRemote value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 15;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSyncEndRemote value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSyncEndRemote UncheckedGetItem15()
	{
		return (StrokeSyncEndRemote)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncEndRemote? value)
	{
		if (Discriminator != 15)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem15();
		return true;
	}

	public DrawingCommand(StrokeSyncCancelRemote value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 16;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSyncCancelRemote value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSyncCancelRemote UncheckedGetItem16()
	{
		return (StrokeSyncCancelRemote)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncCancelRemote? value)
	{
		if (Discriminator != 16)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem16();
		return true;
	}

	public DrawingCommand(StrokeSyncSetEnabled value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 17;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSyncSetEnabled value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSyncSetEnabled UncheckedGetItem17()
	{
		return (StrokeSyncSetEnabled)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncSetEnabled? value)
	{
		if (Discriminator != 17)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem17();
		return true;
	}

	public DrawingCommand(StrokeSyncCurrent value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 18;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSyncCurrent value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSyncCurrent UncheckedGetItem18()
	{
		return (StrokeSyncCurrent)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncCurrent? value)
	{
		if (Discriminator != 18)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem18();
		return true;
	}

	public DrawingCommand(StrokeSyncGetCurrent value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 19;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSyncGetCurrent value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSyncGetCurrent UncheckedGetItem19()
	{
		return (StrokeSyncGetCurrent)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncGetCurrent? value)
	{
		if (Discriminator != 19)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem19();
		return true;
	}

	public DrawingCommand(StrokeSetTool value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 20;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetTool value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetTool UncheckedGetItem20()
	{
		return (StrokeSetTool)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetTool? value)
	{
		if (Discriminator != 20)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem20();
		return true;
	}

	public DrawingCommand(StrokeEraseRemote value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 21;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeEraseRemote value)
	{
		return new DrawingCommand(value);
	}

	private StrokeEraseRemote UncheckedGetItem21()
	{
		return (StrokeEraseRemote)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeEraseRemote? value)
	{
		if (Discriminator != 21)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem21();
		return true;
	}

	public DrawingCommand(StrokeSetFillColor value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 22;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetFillColor value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetFillColor UncheckedGetItem22()
	{
		return (StrokeSetFillColor)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetFillColor? value)
	{
		if (Discriminator != 22)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem22();
		return true;
	}

	public DrawingCommand(StrokeSetHasOutline value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 23;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetHasOutline value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetHasOutline UncheckedGetItem23()
	{
		return (StrokeSetHasOutline)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetHasOutline? value)
	{
		if (Discriminator != 23)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem23();
		return true;
	}

	public DrawingCommand(StrokeDrawComplete value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 24;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeDrawComplete value)
	{
		return new DrawingCommand(value);
	}

	private StrokeDrawComplete UncheckedGetItem24()
	{
		return (StrokeDrawComplete)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeDrawComplete? value)
	{
		if (Discriminator != 24)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem24();
		return true;
	}

	public DrawingCommand(StrokeSetAnchorMode value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 25;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetAnchorMode value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetAnchorMode UncheckedGetItem25()
	{
		return (StrokeSetAnchorMode)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetAnchorMode? value)
	{
		if (Discriminator != 25)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem25();
		return true;
	}

	public DrawingCommand(StrokeSetAnchorTarget value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 26;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetAnchorTarget value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetAnchorTarget UncheckedGetItem26()
	{
		return (StrokeSetAnchorTarget)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetAnchorTarget? value)
	{
		if (Discriminator != 26)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem26();
		return true;
	}

	public DrawingCommand(StrokeSetPressureWidth value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 27;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetPressureWidth value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetPressureWidth UncheckedGetItem27()
	{
		return (StrokeSetPressureWidth)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetPressureWidth? value)
	{
		if (Discriminator != 27)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem27();
		return true;
	}

	public DrawingCommand(TouchPanSettings value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 28;
		this.value = value;
	}

	public static implicit operator DrawingCommand(TouchPanSettings value)
	{
		return new DrawingCommand(value);
	}

	private TouchPanSettings UncheckedGetItem28()
	{
		return (TouchPanSettings)value;
	}

	public bool TryGet([NotNullWhen(true)] out TouchPanSettings? value)
	{
		if (Discriminator != 28)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem28();
		return true;
	}

	public DrawingCommand(StrokeSetCameraLock value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 29;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetCameraLock value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetCameraLock UncheckedGetItem29()
	{
		return (StrokeSetCameraLock)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetCameraLock? value)
	{
		if (Discriminator != 29)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem29();
		return true;
	}

	public DrawingCommand(PenEraserSettings value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 30;
		this.value = value;
	}

	public static implicit operator DrawingCommand(PenEraserSettings value)
	{
		return new DrawingCommand(value);
	}

	private PenEraserSettings UncheckedGetItem30()
	{
		return (PenEraserSettings)value;
	}

	public bool TryGet([NotNullWhen(true)] out PenEraserSettings? value)
	{
		if (Discriminator != 30)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem30();
		return true;
	}

	public DrawingCommand(PenCursorSettings value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 31;
		this.value = value;
	}

	public static implicit operator DrawingCommand(PenCursorSettings value)
	{
		return new DrawingCommand(value);
	}

	private PenCursorSettings UncheckedGetItem31()
	{
		return (PenCursorSettings)value;
	}

	public bool TryGet([NotNullWhen(true)] out PenCursorSettings? value)
	{
		if (Discriminator != 31)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem31();
		return true;
	}

	public DrawingCommand(AnchorClickSettings value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 32;
		this.value = value;
	}

	public static implicit operator DrawingCommand(AnchorClickSettings value)
	{
		return new DrawingCommand(value);
	}

	private AnchorClickSettings UncheckedGetItem32()
	{
		return (AnchorClickSettings)value;
	}

	public bool TryGet([NotNullWhen(true)] out AnchorClickSettings? value)
	{
		if (Discriminator != 32)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem32();
		return true;
	}

	public DrawingCommand(StrokeSetWorldConstraint value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 33;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSetWorldConstraint value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSetWorldConstraint UncheckedGetItem33()
	{
		return (StrokeSetWorldConstraint)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSetWorldConstraint? value)
	{
		if (Discriminator != 33)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem33();
		return true;
	}

	public DrawingCommand(StrokeSyncFlush value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 34;
		this.value = value;
	}

	public static implicit operator DrawingCommand(StrokeSyncFlush value)
	{
		return new DrawingCommand(value);
	}

	private StrokeSyncFlush UncheckedGetItem34()
	{
		return (StrokeSyncFlush)value;
	}

	public bool TryGet([NotNullWhen(true)] out StrokeSyncFlush? value)
	{
		if (Discriminator != 34)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem34();
		return true;
	}

	public TReturn Accept<TVisitor, TReturn>(TVisitor visitor) where TVisitor : IFlatBufferUnionVisitor<TReturn, StrokeSetActive, StrokeSetLayer, StrokeSetColor, StrokeSetWidth, StrokeUndo, StrokeRedo, StrokeClear, StrokeSetTipStyle, GetStrokeProperties, StrokeSetLineStyle, StrokeSetVanishTime, StrokeSetTimeMode, StrokeSyncBeginRemote, StrokeSyncPointsRemote, StrokeSyncEndRemote, StrokeSyncCancelRemote, StrokeSyncSetEnabled, StrokeSyncCurrent, StrokeSyncGetCurrent, StrokeSetTool, StrokeEraseRemote, StrokeSetFillColor, StrokeSetHasOutline, StrokeDrawComplete, StrokeSetAnchorMode, StrokeSetAnchorTarget, StrokeSetPressureWidth, TouchPanSettings, StrokeSetCameraLock, PenEraserSettings, PenCursorSettings, AnchorClickSettings, StrokeSetWorldConstraint, StrokeSyncFlush>
	{
		byte discriminator = Discriminator;
		TVisitor val;
		switch (discriminator)
		{
		case 1:
		{
			ref TVisitor reference18 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference18;
				reference18 = ref val;
			}
			StrokeSetActive item18 = UncheckedGetItem1();
			return reference18.Visit(item18);
		}
		case 2:
		{
			ref TVisitor reference21 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference21;
				reference21 = ref val;
			}
			StrokeSetLayer item21 = UncheckedGetItem2();
			return reference21.Visit(item21);
		}
		case 3:
		{
			ref TVisitor reference9 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference9;
				reference9 = ref val;
			}
			StrokeSetColor item9 = UncheckedGetItem3();
			return reference9.Visit(item9);
		}
		case 4:
		{
			ref TVisitor reference32 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference32;
				reference32 = ref val;
			}
			StrokeSetWidth item32 = UncheckedGetItem4();
			return reference32.Visit(item32);
		}
		case 5:
		{
			ref TVisitor reference23 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference23;
				reference23 = ref val;
			}
			StrokeUndo item23 = UncheckedGetItem5();
			return reference23.Visit(item23);
		}
		case 6:
		{
			ref TVisitor reference20 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference20;
				reference20 = ref val;
			}
			StrokeRedo item20 = UncheckedGetItem6();
			return reference20.Visit(item20);
		}
		case 7:
		{
			ref TVisitor reference2 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference2;
				reference2 = ref val;
			}
			StrokeClear item2 = UncheckedGetItem7();
			return reference2.Visit(item2);
		}
		case 8:
		{
			ref TVisitor reference29 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference29;
				reference29 = ref val;
			}
			StrokeSetTipStyle item29 = UncheckedGetItem8();
			return reference29.Visit(item29);
		}
		case 9:
		{
			ref TVisitor reference12 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference12;
				reference12 = ref val;
			}
			GetStrokeProperties item12 = UncheckedGetItem9();
			return reference12.Visit(item12);
		}
		case 10:
		{
			ref TVisitor reference5 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference5;
				reference5 = ref val;
			}
			StrokeSetLineStyle item5 = UncheckedGetItem10();
			return reference5.Visit(item5);
		}
		case 11:
		{
			ref TVisitor reference30 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference30;
				reference30 = ref val;
			}
			StrokeSetVanishTime item30 = UncheckedGetItem11();
			return reference30.Visit(item30);
		}
		case 12:
		{
			ref TVisitor reference27 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference27;
				reference27 = ref val;
			}
			StrokeSetTimeMode item27 = UncheckedGetItem12();
			return reference27.Visit(item27);
		}
		case 13:
		{
			ref TVisitor reference14 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference14;
				reference14 = ref val;
			}
			StrokeSyncBeginRemote item14 = UncheckedGetItem13();
			return reference14.Visit(item14);
		}
		case 14:
		{
			ref TVisitor reference11 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference11;
				reference11 = ref val;
			}
			StrokeSyncPointsRemote item11 = UncheckedGetItem14();
			return reference11.Visit(item11);
		}
		case 15:
		{
			ref TVisitor reference3 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference3;
				reference3 = ref val;
			}
			StrokeSyncEndRemote item3 = UncheckedGetItem15();
			return reference3.Visit(item3);
		}
		case 16:
		{
			ref TVisitor reference33 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference33;
				reference33 = ref val;
			}
			StrokeSyncCancelRemote item33 = UncheckedGetItem16();
			return reference33.Visit(item33);
		}
		case 17:
		{
			ref TVisitor reference26 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference26;
				reference26 = ref val;
			}
			StrokeSyncSetEnabled item26 = UncheckedGetItem17();
			return reference26.Visit(item26);
		}
		case 18:
		{
			ref TVisitor reference24 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference24;
				reference24 = ref val;
			}
			StrokeSyncCurrent item24 = UncheckedGetItem18();
			return reference24.Visit(item24);
		}
		case 19:
		{
			ref TVisitor reference17 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference17;
				reference17 = ref val;
			}
			StrokeSyncGetCurrent item17 = UncheckedGetItem19();
			return reference17.Visit(item17);
		}
		case 20:
		{
			ref TVisitor reference15 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference15;
				reference15 = ref val;
			}
			StrokeSetTool item15 = UncheckedGetItem20();
			return reference15.Visit(item15);
		}
		case 21:
		{
			ref TVisitor reference8 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference8;
				reference8 = ref val;
			}
			StrokeEraseRemote item8 = UncheckedGetItem21();
			return reference8.Visit(item8);
		}
		case 22:
		{
			ref TVisitor reference6 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference6;
				reference6 = ref val;
			}
			StrokeSetFillColor item6 = UncheckedGetItem22();
			return reference6.Visit(item6);
		}
		case 23:
		{
			ref TVisitor reference34 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference34;
				reference34 = ref val;
			}
			StrokeSetHasOutline item34 = UncheckedGetItem23();
			return reference34.Visit(item34);
		}
		case 24:
		{
			ref TVisitor reference31 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference31;
				reference31 = ref val;
			}
			StrokeDrawComplete item31 = UncheckedGetItem24();
			return reference31.Visit(item31);
		}
		case 25:
		{
			ref TVisitor reference28 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference28;
				reference28 = ref val;
			}
			StrokeSetAnchorMode item28 = UncheckedGetItem25();
			return reference28.Visit(item28);
		}
		case 26:
		{
			ref TVisitor reference25 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference25;
				reference25 = ref val;
			}
			StrokeSetAnchorTarget item25 = UncheckedGetItem26();
			return reference25.Visit(item25);
		}
		case 27:
		{
			ref TVisitor reference22 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference22;
				reference22 = ref val;
			}
			StrokeSetPressureWidth item22 = UncheckedGetItem27();
			return reference22.Visit(item22);
		}
		case 28:
		{
			ref TVisitor reference19 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference19;
				reference19 = ref val;
			}
			TouchPanSettings item19 = UncheckedGetItem28();
			return reference19.Visit(item19);
		}
		case 29:
		{
			ref TVisitor reference16 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference16;
				reference16 = ref val;
			}
			StrokeSetCameraLock item16 = UncheckedGetItem29();
			return reference16.Visit(item16);
		}
		case 30:
		{
			ref TVisitor reference13 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference13;
				reference13 = ref val;
			}
			PenEraserSettings item13 = UncheckedGetItem30();
			return reference13.Visit(item13);
		}
		case 31:
		{
			ref TVisitor reference10 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference10;
				reference10 = ref val;
			}
			PenCursorSettings item10 = UncheckedGetItem31();
			return reference10.Visit(item10);
		}
		case 32:
		{
			ref TVisitor reference7 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference7;
				reference7 = ref val;
			}
			AnchorClickSettings item7 = UncheckedGetItem32();
			return reference7.Visit(item7);
		}
		case 33:
		{
			ref TVisitor reference4 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference4;
				reference4 = ref val;
			}
			StrokeSetWorldConstraint item4 = UncheckedGetItem33();
			return reference4.Visit(item4);
		}
		case 34:
		{
			ref TVisitor reference = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference;
				reference = ref val;
			}
			StrokeSyncFlush item = UncheckedGetItem34();
			return reference.Visit(item);
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<DrawingCommand>(discriminator);
			return default;
		}
	}

	public TReturn Match<TReturn>(Func<StrokeSetActive, TReturn> caseStrokeSetActive, Func<StrokeSetLayer, TReturn> caseStrokeSetLayer, Func<StrokeSetColor, TReturn> caseStrokeSetColor, Func<StrokeSetWidth, TReturn> caseStrokeSetWidth, Func<StrokeUndo, TReturn> caseStrokeUndo, Func<StrokeRedo, TReturn> caseStrokeRedo, Func<StrokeClear, TReturn> caseStrokeClear, Func<StrokeSetTipStyle, TReturn> caseStrokeSetTipStyle, Func<GetStrokeProperties, TReturn> caseGetStrokeProperties, Func<StrokeSetLineStyle, TReturn> caseStrokeSetLineStyle, Func<StrokeSetVanishTime, TReturn> caseStrokeSetVanishTime, Func<StrokeSetTimeMode, TReturn> caseStrokeSetTimeMode, Func<StrokeSyncBeginRemote, TReturn> caseStrokeSyncBeginRemote, Func<StrokeSyncPointsRemote, TReturn> caseStrokeSyncPointsRemote, Func<StrokeSyncEndRemote, TReturn> caseStrokeSyncEndRemote, Func<StrokeSyncCancelRemote, TReturn> caseStrokeSyncCancelRemote, Func<StrokeSyncSetEnabled, TReturn> caseStrokeSyncSetEnabled, Func<StrokeSyncCurrent, TReturn> caseStrokeSyncCurrent, Func<StrokeSyncGetCurrent, TReturn> caseStrokeSyncGetCurrent, Func<StrokeSetTool, TReturn> caseStrokeSetTool, Func<StrokeEraseRemote, TReturn> caseStrokeEraseRemote, Func<StrokeSetFillColor, TReturn> caseStrokeSetFillColor, Func<StrokeSetHasOutline, TReturn> caseStrokeSetHasOutline, Func<StrokeDrawComplete, TReturn> caseStrokeDrawComplete, Func<StrokeSetAnchorMode, TReturn> caseStrokeSetAnchorMode, Func<StrokeSetAnchorTarget, TReturn> caseStrokeSetAnchorTarget, Func<StrokeSetPressureWidth, TReturn> caseStrokeSetPressureWidth, Func<TouchPanSettings, TReturn> caseTouchPanSettings, Func<StrokeSetCameraLock, TReturn> caseStrokeSetCameraLock, Func<PenEraserSettings, TReturn> casePenEraserSettings, Func<PenCursorSettings, TReturn> casePenCursorSettings, Func<AnchorClickSettings, TReturn> caseAnchorClickSettings, Func<StrokeSetWorldConstraint, TReturn> caseStrokeSetWorldConstraint, Func<StrokeSyncFlush, TReturn> caseStrokeSyncFlush)
	{
		byte discriminator = Discriminator;
		switch (discriminator)
		{
		case 1:
			return caseStrokeSetActive(UncheckedGetItem1());
		case 2:
			return caseStrokeSetLayer(UncheckedGetItem2());
		case 3:
			return caseStrokeSetColor(UncheckedGetItem3());
		case 4:
			return caseStrokeSetWidth(UncheckedGetItem4());
		case 5:
			return caseStrokeUndo(UncheckedGetItem5());
		case 6:
			return caseStrokeRedo(UncheckedGetItem6());
		case 7:
			return caseStrokeClear(UncheckedGetItem7());
		case 8:
			return caseStrokeSetTipStyle(UncheckedGetItem8());
		case 9:
			return caseGetStrokeProperties(UncheckedGetItem9());
		case 10:
			return caseStrokeSetLineStyle(UncheckedGetItem10());
		case 11:
			return caseStrokeSetVanishTime(UncheckedGetItem11());
		case 12:
			return caseStrokeSetTimeMode(UncheckedGetItem12());
		case 13:
			return caseStrokeSyncBeginRemote(UncheckedGetItem13());
		case 14:
			return caseStrokeSyncPointsRemote(UncheckedGetItem14());
		case 15:
			return caseStrokeSyncEndRemote(UncheckedGetItem15());
		case 16:
			return caseStrokeSyncCancelRemote(UncheckedGetItem16());
		case 17:
			return caseStrokeSyncSetEnabled(UncheckedGetItem17());
		case 18:
			return caseStrokeSyncCurrent(UncheckedGetItem18());
		case 19:
			return caseStrokeSyncGetCurrent(UncheckedGetItem19());
		case 20:
			return caseStrokeSetTool(UncheckedGetItem20());
		case 21:
			return caseStrokeEraseRemote(UncheckedGetItem21());
		case 22:
			return caseStrokeSetFillColor(UncheckedGetItem22());
		case 23:
			return caseStrokeSetHasOutline(UncheckedGetItem23());
		case 24:
			return caseStrokeDrawComplete(UncheckedGetItem24());
		case 25:
			return caseStrokeSetAnchorMode(UncheckedGetItem25());
		case 26:
			return caseStrokeSetAnchorTarget(UncheckedGetItem26());
		case 27:
			return caseStrokeSetPressureWidth(UncheckedGetItem27());
		case 28:
			return caseTouchPanSettings(UncheckedGetItem28());
		case 29:
			return caseStrokeSetCameraLock(UncheckedGetItem29());
		case 30:
			return casePenEraserSettings(UncheckedGetItem30());
		case 31:
			return casePenCursorSettings(UncheckedGetItem31());
		case 32:
			return caseAnchorClickSettings(UncheckedGetItem32());
		case 33:
			return caseStrokeSetWorldConstraint(UncheckedGetItem33());
		case 34:
			return caseStrokeSyncFlush(UncheckedGetItem34());
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<DrawingCommand>(discriminator);
			return default;
		}
	}
}
