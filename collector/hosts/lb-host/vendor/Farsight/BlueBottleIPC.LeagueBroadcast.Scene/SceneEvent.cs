using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[CompilerGenerated]
public struct SceneEvent : IFlatBufferUnion<SceneCreated, SceneUnloaded, SceneStateChanged, SceneList, SceneSnapshot, SceneEntitiesAdded, SceneEntitiesRemoved, SceneEntitiesSnapshot, SceneEntityChanged, SceneEntityTransformUpdates, SceneSelectionChanged, SceneEntityIdChanged, SceneScriptError, SceneScriptLog, ScriptAssetChanged, ScriptAssetDeleted, ScriptLibrary>, IFlatBufferUnion
{
	public enum ItemKind : byte
	{
		SceneCreated = 1,
		SceneUnloaded = 2,
		SceneStateChanged = 3,
		SceneList = 4,
		SceneSnapshot = 5,
		SceneEntitiesAdded = 6,
		SceneEntitiesRemoved = 7,
		SceneEntitiesSnapshot = 8,
		SceneEntityChanged = 9,
		SceneEntityTransformUpdates = 10,
		SceneSelectionChanged = 11,
		SceneEntityIdChanged = 12,
		SceneScriptError = 13,
		SceneScriptLog = 14,
		ScriptAssetChanged = 15,
		ScriptAssetDeleted = 16,
		ScriptLibrary = 17,
		NONE = 0
	}

	public interface Visitor<TReturn> : IFlatBufferUnionVisitor<TReturn, SceneCreated, SceneUnloaded, SceneStateChanged, SceneList, SceneSnapshot, SceneEntitiesAdded, SceneEntitiesRemoved, SceneEntitiesSnapshot, SceneEntityChanged, SceneEntityTransformUpdates, SceneSelectionChanged, SceneEntityIdChanged, SceneScriptError, SceneScriptLog, ScriptAssetChanged, ScriptAssetDeleted, ScriptLibrary>
	{
	}

	private readonly object value;

	public ItemKind Kind => (ItemKind)Discriminator;

	public byte Discriminator { get; }

	public SceneCreated SceneCreated => Item1;

	public SceneCreated Item1
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

	public SceneUnloaded SceneUnloaded => Item2;

	public SceneUnloaded Item2
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

	public SceneStateChanged SceneStateChanged => Item3;

	public SceneStateChanged Item3
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

	public SceneList SceneList => Item4;

	public SceneList Item4
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

	public SceneSnapshot SceneSnapshot => Item5;

	public SceneSnapshot Item5
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

	public SceneEntitiesAdded SceneEntitiesAdded => Item6;

	public SceneEntitiesAdded Item6
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

	public SceneEntitiesRemoved SceneEntitiesRemoved => Item7;

	public SceneEntitiesRemoved Item7
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

	public SceneEntitiesSnapshot SceneEntitiesSnapshot => Item8;

	public SceneEntitiesSnapshot Item8
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

	public SceneEntityChanged SceneEntityChanged => Item9;

	public SceneEntityChanged Item9
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

	public SceneEntityTransformUpdates SceneEntityTransformUpdates => Item10;

	public SceneEntityTransformUpdates Item10
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

	public SceneSelectionChanged SceneSelectionChanged => Item11;

	public SceneSelectionChanged Item11
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

	public SceneEntityIdChanged SceneEntityIdChanged => Item12;

	public SceneEntityIdChanged Item12
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

	public SceneScriptError SceneScriptError => Item13;

	public SceneScriptError Item13
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

	public SceneScriptLog SceneScriptLog => Item14;

	public SceneScriptLog Item14
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

	public ScriptAssetChanged ScriptAssetChanged => Item15;

	public ScriptAssetChanged Item15
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

	public ScriptAssetDeleted ScriptAssetDeleted => Item16;

	public ScriptAssetDeleted Item16
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

	public ScriptLibrary ScriptLibrary => Item17;

	public ScriptLibrary Item17
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

	public SceneEvent(SceneCreated value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 1;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneCreated value)
	{
		return new SceneEvent(value);
	}

	private SceneCreated UncheckedGetItem1()
	{
		return (SceneCreated)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneCreated? value)
	{
		if (Discriminator != 1)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem1();
		return true;
	}

	public SceneEvent(SceneUnloaded value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 2;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneUnloaded value)
	{
		return new SceneEvent(value);
	}

	private SceneUnloaded UncheckedGetItem2()
	{
		return (SceneUnloaded)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneUnloaded? value)
	{
		if (Discriminator != 2)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem2();
		return true;
	}

	public SceneEvent(SceneStateChanged value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 3;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneStateChanged value)
	{
		return new SceneEvent(value);
	}

	private SceneStateChanged UncheckedGetItem3()
	{
		return (SceneStateChanged)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneStateChanged? value)
	{
		if (Discriminator != 3)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem3();
		return true;
	}

	public SceneEvent(SceneList value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 4;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneList value)
	{
		return new SceneEvent(value);
	}

	private SceneList UncheckedGetItem4()
	{
		return (SceneList)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneList? value)
	{
		if (Discriminator != 4)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem4();
		return true;
	}

	public SceneEvent(SceneSnapshot value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 5;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneSnapshot value)
	{
		return new SceneEvent(value);
	}

	private SceneSnapshot UncheckedGetItem5()
	{
		return (SceneSnapshot)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneSnapshot? value)
	{
		if (Discriminator != 5)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem5();
		return true;
	}

	public SceneEvent(SceneEntitiesAdded value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 6;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneEntitiesAdded value)
	{
		return new SceneEvent(value);
	}

	private SceneEntitiesAdded UncheckedGetItem6()
	{
		return (SceneEntitiesAdded)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneEntitiesAdded? value)
	{
		if (Discriminator != 6)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem6();
		return true;
	}

	public SceneEvent(SceneEntitiesRemoved value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 7;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneEntitiesRemoved value)
	{
		return new SceneEvent(value);
	}

	private SceneEntitiesRemoved UncheckedGetItem7()
	{
		return (SceneEntitiesRemoved)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneEntitiesRemoved? value)
	{
		if (Discriminator != 7)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem7();
		return true;
	}

	public SceneEvent(SceneEntitiesSnapshot value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 8;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneEntitiesSnapshot value)
	{
		return new SceneEvent(value);
	}

	private SceneEntitiesSnapshot UncheckedGetItem8()
	{
		return (SceneEntitiesSnapshot)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneEntitiesSnapshot? value)
	{
		if (Discriminator != 8)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem8();
		return true;
	}

	public SceneEvent(SceneEntityChanged value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 9;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneEntityChanged value)
	{
		return new SceneEvent(value);
	}

	private SceneEntityChanged UncheckedGetItem9()
	{
		return (SceneEntityChanged)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneEntityChanged? value)
	{
		if (Discriminator != 9)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem9();
		return true;
	}

	public SceneEvent(SceneEntityTransformUpdates value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 10;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneEntityTransformUpdates value)
	{
		return new SceneEvent(value);
	}

	private SceneEntityTransformUpdates UncheckedGetItem10()
	{
		return (SceneEntityTransformUpdates)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneEntityTransformUpdates? value)
	{
		if (Discriminator != 10)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem10();
		return true;
	}

	public SceneEvent(SceneSelectionChanged value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 11;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneSelectionChanged value)
	{
		return new SceneEvent(value);
	}

	private SceneSelectionChanged UncheckedGetItem11()
	{
		return (SceneSelectionChanged)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneSelectionChanged? value)
	{
		if (Discriminator != 11)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem11();
		return true;
	}

	public SceneEvent(SceneEntityIdChanged value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 12;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneEntityIdChanged value)
	{
		return new SceneEvent(value);
	}

	private SceneEntityIdChanged UncheckedGetItem12()
	{
		return (SceneEntityIdChanged)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneEntityIdChanged? value)
	{
		if (Discriminator != 12)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem12();
		return true;
	}

	public SceneEvent(SceneScriptError value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 13;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneScriptError value)
	{
		return new SceneEvent(value);
	}

	private SceneScriptError UncheckedGetItem13()
	{
		return (SceneScriptError)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneScriptError? value)
	{
		if (Discriminator != 13)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem13();
		return true;
	}

	public SceneEvent(SceneScriptLog value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 14;
		this.value = value;
	}

	public static implicit operator SceneEvent(SceneScriptLog value)
	{
		return new SceneEvent(value);
	}

	private SceneScriptLog UncheckedGetItem14()
	{
		return (SceneScriptLog)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneScriptLog? value)
	{
		if (Discriminator != 14)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem14();
		return true;
	}

	public SceneEvent(ScriptAssetChanged value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 15;
		this.value = value;
	}

	public static implicit operator SceneEvent(ScriptAssetChanged value)
	{
		return new SceneEvent(value);
	}

	private ScriptAssetChanged UncheckedGetItem15()
	{
		return (ScriptAssetChanged)value;
	}

	public bool TryGet([NotNullWhen(true)] out ScriptAssetChanged? value)
	{
		if (Discriminator != 15)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem15();
		return true;
	}

	public SceneEvent(ScriptAssetDeleted value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 16;
		this.value = value;
	}

	public static implicit operator SceneEvent(ScriptAssetDeleted value)
	{
		return new SceneEvent(value);
	}

	private ScriptAssetDeleted UncheckedGetItem16()
	{
		return (ScriptAssetDeleted)value;
	}

	public bool TryGet([NotNullWhen(true)] out ScriptAssetDeleted? value)
	{
		if (Discriminator != 16)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem16();
		return true;
	}

	public SceneEvent(ScriptLibrary value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 17;
		this.value = value;
	}

	public static implicit operator SceneEvent(ScriptLibrary value)
	{
		return new SceneEvent(value);
	}

	private ScriptLibrary UncheckedGetItem17()
	{
		return (ScriptLibrary)value;
	}

	public bool TryGet([NotNullWhen(true)] out ScriptLibrary? value)
	{
		if (Discriminator != 17)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem17();
		return true;
	}

	public TReturn Accept<TVisitor, TReturn>(TVisitor visitor) where TVisitor : IFlatBufferUnionVisitor<TReturn, SceneCreated, SceneUnloaded, SceneStateChanged, SceneList, SceneSnapshot, SceneEntitiesAdded, SceneEntitiesRemoved, SceneEntitiesSnapshot, SceneEntityChanged, SceneEntityTransformUpdates, SceneSelectionChanged, SceneEntityIdChanged, SceneScriptError, SceneScriptLog, ScriptAssetChanged, ScriptAssetDeleted, ScriptLibrary>
	{
		byte discriminator = Discriminator;
		TVisitor val;
		switch (discriminator)
		{
		case 1:
		{
			ref TVisitor reference12 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference12;
				reference12 = ref val;
			}
			SceneCreated item12 = UncheckedGetItem1();
			return reference12.Visit(item12);
		}
		case 2:
		{
			ref TVisitor reference15 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference15;
				reference15 = ref val;
			}
			SceneUnloaded item15 = UncheckedGetItem2();
			return reference15.Visit(item15);
		}
		case 3:
		{
			ref TVisitor reference8 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference8;
				reference8 = ref val;
			}
			SceneStateChanged item8 = UncheckedGetItem3();
			return reference8.Visit(item8);
		}
		case 4:
		{
			ref TVisitor reference5 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference5;
				reference5 = ref val;
			}
			SceneList item5 = UncheckedGetItem4();
			return reference5.Visit(item5);
		}
		case 5:
		{
			ref TVisitor reference17 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference17;
				reference17 = ref val;
			}
			SceneSnapshot item17 = UncheckedGetItem5();
			return reference17.Visit(item17);
		}
		case 6:
		{
			ref TVisitor reference14 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference14;
				reference14 = ref val;
			}
			SceneEntitiesAdded item14 = UncheckedGetItem6();
			return reference14.Visit(item14);
		}
		case 7:
		{
			ref TVisitor reference6 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference6;
				reference6 = ref val;
			}
			SceneEntitiesRemoved item6 = UncheckedGetItem7();
			return reference6.Visit(item6);
		}
		case 8:
		{
			ref TVisitor reference3 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference3;
				reference3 = ref val;
			}
			SceneEntitiesSnapshot item3 = UncheckedGetItem8();
			return reference3.Visit(item3);
		}
		case 9:
		{
			ref TVisitor reference11 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference11;
				reference11 = ref val;
			}
			SceneEntityChanged item11 = UncheckedGetItem9();
			return reference11.Visit(item11);
		}
		case 10:
		{
			ref TVisitor reference9 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference9;
				reference9 = ref val;
			}
			SceneEntityTransformUpdates item9 = UncheckedGetItem10();
			return reference9.Visit(item9);
		}
		case 11:
		{
			ref TVisitor reference2 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference2;
				reference2 = ref val;
			}
			SceneSelectionChanged item2 = UncheckedGetItem11();
			return reference2.Visit(item2);
		}
		case 12:
		{
			ref TVisitor reference16 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference16;
				reference16 = ref val;
			}
			SceneEntityIdChanged item16 = UncheckedGetItem12();
			return reference16.Visit(item16);
		}
		case 13:
		{
			ref TVisitor reference13 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference13;
				reference13 = ref val;
			}
			SceneScriptError item13 = UncheckedGetItem13();
			return reference13.Visit(item13);
		}
		case 14:
		{
			ref TVisitor reference10 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference10;
				reference10 = ref val;
			}
			SceneScriptLog item10 = UncheckedGetItem14();
			return reference10.Visit(item10);
		}
		case 15:
		{
			ref TVisitor reference7 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference7;
				reference7 = ref val;
			}
			ScriptAssetChanged item7 = UncheckedGetItem15();
			return reference7.Visit(item7);
		}
		case 16:
		{
			ref TVisitor reference4 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference4;
				reference4 = ref val;
			}
			ScriptAssetDeleted item4 = UncheckedGetItem16();
			return reference4.Visit(item4);
		}
		case 17:
		{
			ref TVisitor reference = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference;
				reference = ref val;
			}
			ScriptLibrary item = UncheckedGetItem17();
			return reference.Visit(item);
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneEvent>(discriminator);
			return default;
		}
	}

	public TReturn Match<TReturn>(Func<SceneCreated, TReturn> caseSceneCreated, Func<SceneUnloaded, TReturn> caseSceneUnloaded, Func<SceneStateChanged, TReturn> caseSceneStateChanged, Func<SceneList, TReturn> caseSceneList, Func<SceneSnapshot, TReturn> caseSceneSnapshot, Func<SceneEntitiesAdded, TReturn> caseSceneEntitiesAdded, Func<SceneEntitiesRemoved, TReturn> caseSceneEntitiesRemoved, Func<SceneEntitiesSnapshot, TReturn> caseSceneEntitiesSnapshot, Func<SceneEntityChanged, TReturn> caseSceneEntityChanged, Func<SceneEntityTransformUpdates, TReturn> caseSceneEntityTransformUpdates, Func<SceneSelectionChanged, TReturn> caseSceneSelectionChanged, Func<SceneEntityIdChanged, TReturn> caseSceneEntityIdChanged, Func<SceneScriptError, TReturn> caseSceneScriptError, Func<SceneScriptLog, TReturn> caseSceneScriptLog, Func<ScriptAssetChanged, TReturn> caseScriptAssetChanged, Func<ScriptAssetDeleted, TReturn> caseScriptAssetDeleted, Func<ScriptLibrary, TReturn> caseScriptLibrary)
	{
		byte discriminator = Discriminator;
		switch (discriminator)
		{
		case 1:
			return caseSceneCreated(UncheckedGetItem1());
		case 2:
			return caseSceneUnloaded(UncheckedGetItem2());
		case 3:
			return caseSceneStateChanged(UncheckedGetItem3());
		case 4:
			return caseSceneList(UncheckedGetItem4());
		case 5:
			return caseSceneSnapshot(UncheckedGetItem5());
		case 6:
			return caseSceneEntitiesAdded(UncheckedGetItem6());
		case 7:
			return caseSceneEntitiesRemoved(UncheckedGetItem7());
		case 8:
			return caseSceneEntitiesSnapshot(UncheckedGetItem8());
		case 9:
			return caseSceneEntityChanged(UncheckedGetItem9());
		case 10:
			return caseSceneEntityTransformUpdates(UncheckedGetItem10());
		case 11:
			return caseSceneSelectionChanged(UncheckedGetItem11());
		case 12:
			return caseSceneEntityIdChanged(UncheckedGetItem12());
		case 13:
			return caseSceneScriptError(UncheckedGetItem13());
		case 14:
			return caseSceneScriptLog(UncheckedGetItem14());
		case 15:
			return caseScriptAssetChanged(UncheckedGetItem15());
		case 16:
			return caseScriptAssetDeleted(UncheckedGetItem16());
		case 17:
			return caseScriptLibrary(UncheckedGetItem17());
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneEvent>(discriminator);
			return default;
		}
	}
}
