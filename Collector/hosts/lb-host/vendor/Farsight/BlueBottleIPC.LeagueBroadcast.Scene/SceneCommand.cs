using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Scene;

[CompilerGenerated]
public struct SceneCommand : IFlatBufferUnion<SceneCreate, SceneUnload, SceneSetVisibility, SceneSetEditable, SceneSetZOrder, SceneListRequest, SceneSnapshotRequest, SceneSetSelection, EntityCreateBatch, EntityDestroy, SetComponentBatch, RemoveComponent, GetComponents, ScriptCreate, ScriptUpdate, ScriptDelete, ScriptListRequest, ScriptValidate>, IFlatBufferUnion
{
	public enum ItemKind : byte
	{
		SceneCreate = 1,
		SceneUnload = 2,
		SceneSetVisibility = 3,
		SceneSetEditable = 4,
		SceneSetZOrder = 5,
		SceneListRequest = 6,
		SceneSnapshotRequest = 7,
		SceneSetSelection = 8,
		EntityCreateBatch = 9,
		EntityDestroy = 10,
		SetComponentBatch = 11,
		RemoveComponent = 12,
		GetComponents = 13,
		ScriptCreate = 14,
		ScriptUpdate = 15,
		ScriptDelete = 16,
		ScriptListRequest = 17,
		ScriptValidate = 18,
		NONE = 0
	}

	public interface Visitor<TReturn> : IFlatBufferUnionVisitor<TReturn, SceneCreate, SceneUnload, SceneSetVisibility, SceneSetEditable, SceneSetZOrder, SceneListRequest, SceneSnapshotRequest, SceneSetSelection, EntityCreateBatch, EntityDestroy, SetComponentBatch, RemoveComponent, GetComponents, ScriptCreate, ScriptUpdate, ScriptDelete, ScriptListRequest, ScriptValidate>
	{
	}

	private readonly object value;

	public ItemKind Kind => (ItemKind)Discriminator;

	public byte Discriminator { get; }

	public SceneCreate SceneCreate => Item1;

	public SceneCreate Item1
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

	public SceneUnload SceneUnload => Item2;

	public SceneUnload Item2
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

	public SceneSetVisibility SceneSetVisibility => Item3;

	public SceneSetVisibility Item3
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

	public SceneSetEditable SceneSetEditable => Item4;

	public SceneSetEditable Item4
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

	public SceneSetZOrder SceneSetZOrder => Item5;

	public SceneSetZOrder Item5
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

	public SceneListRequest SceneListRequest => Item6;

	public SceneListRequest Item6
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

	public SceneSnapshotRequest SceneSnapshotRequest => Item7;

	public SceneSnapshotRequest Item7
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

	public SceneSetSelection SceneSetSelection => Item8;

	public SceneSetSelection Item8
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

	public EntityCreateBatch EntityCreateBatch => Item9;

	public EntityCreateBatch Item9
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

	public EntityDestroy EntityDestroy => Item10;

	public EntityDestroy Item10
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

	public SetComponentBatch SetComponentBatch => Item11;

	public SetComponentBatch Item11
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

	public RemoveComponent RemoveComponent => Item12;

	public RemoveComponent Item12
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

	public GetComponents GetComponents => Item13;

	public GetComponents Item13
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

	public ScriptCreate ScriptCreate => Item14;

	public ScriptCreate Item14
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

	public ScriptUpdate ScriptUpdate => Item15;

	public ScriptUpdate Item15
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

	public ScriptDelete ScriptDelete => Item16;

	public ScriptDelete Item16
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

	public ScriptListRequest ScriptListRequest => Item17;

	public ScriptListRequest Item17
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

	public ScriptValidate ScriptValidate => Item18;

	public ScriptValidate Item18
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

	public SceneCommand(SceneCreate value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 1;
		this.value = value;
	}

	public static implicit operator SceneCommand(SceneCreate value)
	{
		return new SceneCommand(value);
	}

	private SceneCreate UncheckedGetItem1()
	{
		return (SceneCreate)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneCreate? value)
	{
		if (Discriminator != 1)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem1();
		return true;
	}

	public SceneCommand(SceneUnload value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 2;
		this.value = value;
	}

	public static implicit operator SceneCommand(SceneUnload value)
	{
		return new SceneCommand(value);
	}

	private SceneUnload UncheckedGetItem2()
	{
		return (SceneUnload)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneUnload? value)
	{
		if (Discriminator != 2)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem2();
		return true;
	}

	public SceneCommand(SceneSetVisibility value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 3;
		this.value = value;
	}

	public static implicit operator SceneCommand(SceneSetVisibility value)
	{
		return new SceneCommand(value);
	}

	private SceneSetVisibility UncheckedGetItem3()
	{
		return (SceneSetVisibility)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneSetVisibility? value)
	{
		if (Discriminator != 3)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem3();
		return true;
	}

	public SceneCommand(SceneSetEditable value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 4;
		this.value = value;
	}

	public static implicit operator SceneCommand(SceneSetEditable value)
	{
		return new SceneCommand(value);
	}

	private SceneSetEditable UncheckedGetItem4()
	{
		return (SceneSetEditable)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneSetEditable? value)
	{
		if (Discriminator != 4)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem4();
		return true;
	}

	public SceneCommand(SceneSetZOrder value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 5;
		this.value = value;
	}

	public static implicit operator SceneCommand(SceneSetZOrder value)
	{
		return new SceneCommand(value);
	}

	private SceneSetZOrder UncheckedGetItem5()
	{
		return (SceneSetZOrder)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneSetZOrder? value)
	{
		if (Discriminator != 5)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem5();
		return true;
	}

	public SceneCommand(SceneListRequest value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 6;
		this.value = value;
	}

	public static implicit operator SceneCommand(SceneListRequest value)
	{
		return new SceneCommand(value);
	}

	private SceneListRequest UncheckedGetItem6()
	{
		return (SceneListRequest)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneListRequest? value)
	{
		if (Discriminator != 6)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem6();
		return true;
	}

	public SceneCommand(SceneSnapshotRequest value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 7;
		this.value = value;
	}

	public static implicit operator SceneCommand(SceneSnapshotRequest value)
	{
		return new SceneCommand(value);
	}

	private SceneSnapshotRequest UncheckedGetItem7()
	{
		return (SceneSnapshotRequest)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneSnapshotRequest? value)
	{
		if (Discriminator != 7)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem7();
		return true;
	}

	public SceneCommand(SceneSetSelection value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 8;
		this.value = value;
	}

	public static implicit operator SceneCommand(SceneSetSelection value)
	{
		return new SceneCommand(value);
	}

	private SceneSetSelection UncheckedGetItem8()
	{
		return (SceneSetSelection)value;
	}

	public bool TryGet([NotNullWhen(true)] out SceneSetSelection? value)
	{
		if (Discriminator != 8)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem8();
		return true;
	}

	public SceneCommand(EntityCreateBatch value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 9;
		this.value = value;
	}

	public static implicit operator SceneCommand(EntityCreateBatch value)
	{
		return new SceneCommand(value);
	}

	private EntityCreateBatch UncheckedGetItem9()
	{
		return (EntityCreateBatch)value;
	}

	public bool TryGet([NotNullWhen(true)] out EntityCreateBatch? value)
	{
		if (Discriminator != 9)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem9();
		return true;
	}

	public SceneCommand(EntityDestroy value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 10;
		this.value = value;
	}

	public static implicit operator SceneCommand(EntityDestroy value)
	{
		return new SceneCommand(value);
	}

	private EntityDestroy UncheckedGetItem10()
	{
		return (EntityDestroy)value;
	}

	public bool TryGet([NotNullWhen(true)] out EntityDestroy? value)
	{
		if (Discriminator != 10)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem10();
		return true;
	}

	public SceneCommand(SetComponentBatch value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 11;
		this.value = value;
	}

	public static implicit operator SceneCommand(SetComponentBatch value)
	{
		return new SceneCommand(value);
	}

	private SetComponentBatch UncheckedGetItem11()
	{
		return (SetComponentBatch)value;
	}

	public bool TryGet([NotNullWhen(true)] out SetComponentBatch? value)
	{
		if (Discriminator != 11)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem11();
		return true;
	}

	public SceneCommand(RemoveComponent value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 12;
		this.value = value;
	}

	public static implicit operator SceneCommand(RemoveComponent value)
	{
		return new SceneCommand(value);
	}

	private RemoveComponent UncheckedGetItem12()
	{
		return (RemoveComponent)value;
	}

	public bool TryGet([NotNullWhen(true)] out RemoveComponent? value)
	{
		if (Discriminator != 12)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem12();
		return true;
	}

	public SceneCommand(GetComponents value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 13;
		this.value = value;
	}

	public static implicit operator SceneCommand(GetComponents value)
	{
		return new SceneCommand(value);
	}

	private GetComponents UncheckedGetItem13()
	{
		return (GetComponents)value;
	}

	public bool TryGet([NotNullWhen(true)] out GetComponents? value)
	{
		if (Discriminator != 13)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem13();
		return true;
	}

	public SceneCommand(ScriptCreate value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 14;
		this.value = value;
	}

	public static implicit operator SceneCommand(ScriptCreate value)
	{
		return new SceneCommand(value);
	}

	private ScriptCreate UncheckedGetItem14()
	{
		return (ScriptCreate)value;
	}

	public bool TryGet([NotNullWhen(true)] out ScriptCreate? value)
	{
		if (Discriminator != 14)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem14();
		return true;
	}

	public SceneCommand(ScriptUpdate value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 15;
		this.value = value;
	}

	public static implicit operator SceneCommand(ScriptUpdate value)
	{
		return new SceneCommand(value);
	}

	private ScriptUpdate UncheckedGetItem15()
	{
		return (ScriptUpdate)value;
	}

	public bool TryGet([NotNullWhen(true)] out ScriptUpdate? value)
	{
		if (Discriminator != 15)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem15();
		return true;
	}

	public SceneCommand(ScriptDelete value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 16;
		this.value = value;
	}

	public static implicit operator SceneCommand(ScriptDelete value)
	{
		return new SceneCommand(value);
	}

	private ScriptDelete UncheckedGetItem16()
	{
		return (ScriptDelete)value;
	}

	public bool TryGet([NotNullWhen(true)] out ScriptDelete? value)
	{
		if (Discriminator != 16)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem16();
		return true;
	}

	public SceneCommand(ScriptListRequest value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 17;
		this.value = value;
	}

	public static implicit operator SceneCommand(ScriptListRequest value)
	{
		return new SceneCommand(value);
	}

	private ScriptListRequest UncheckedGetItem17()
	{
		return (ScriptListRequest)value;
	}

	public bool TryGet([NotNullWhen(true)] out ScriptListRequest? value)
	{
		if (Discriminator != 17)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem17();
		return true;
	}

	public SceneCommand(ScriptValidate value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 18;
		this.value = value;
	}

	public static implicit operator SceneCommand(ScriptValidate value)
	{
		return new SceneCommand(value);
	}

	private ScriptValidate UncheckedGetItem18()
	{
		return (ScriptValidate)value;
	}

	public bool TryGet([NotNullWhen(true)] out ScriptValidate? value)
	{
		if (Discriminator != 18)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem18();
		return true;
	}

	public TReturn Accept<TVisitor, TReturn>(TVisitor visitor) where TVisitor : IFlatBufferUnionVisitor<TReturn, SceneCreate, SceneUnload, SceneSetVisibility, SceneSetEditable, SceneSetZOrder, SceneListRequest, SceneSnapshotRequest, SceneSetSelection, EntityCreateBatch, EntityDestroy, SetComponentBatch, RemoveComponent, GetComponents, ScriptCreate, ScriptUpdate, ScriptDelete, ScriptListRequest, ScriptValidate>
	{
		byte discriminator = Discriminator;
		TVisitor val;
		switch (discriminator)
		{
		case 1:
		{
			ref TVisitor reference15 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference15;
				reference15 = ref val;
			}
			SceneCreate item15 = UncheckedGetItem1();
			return reference15.Visit(item15);
		}
		case 2:
		{
			ref TVisitor reference18 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference18;
				reference18 = ref val;
			}
			SceneUnload item18 = UncheckedGetItem2();
			return reference18.Visit(item18);
		}
		case 3:
		{
			ref TVisitor reference11 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference11;
				reference11 = ref val;
			}
			SceneSetVisibility item11 = UncheckedGetItem3();
			return reference11.Visit(item11);
		}
		case 4:
		{
			ref TVisitor reference8 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference8;
				reference8 = ref val;
			}
			SceneSetEditable item8 = UncheckedGetItem4();
			return reference8.Visit(item8);
		}
		case 5:
		{
			ref TVisitor reference2 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference2;
				reference2 = ref val;
			}
			SceneSetZOrder item2 = UncheckedGetItem5();
			return reference2.Visit(item2);
		}
		case 6:
		{
			ref TVisitor reference17 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference17;
				reference17 = ref val;
			}
			SceneListRequest item17 = UncheckedGetItem6();
			return reference17.Visit(item17);
		}
		case 7:
		{
			ref TVisitor reference9 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference9;
				reference9 = ref val;
			}
			SceneSnapshotRequest item9 = UncheckedGetItem7();
			return reference9.Visit(item9);
		}
		case 8:
		{
			ref TVisitor reference6 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference6;
				reference6 = ref val;
			}
			SceneSetSelection item6 = UncheckedGetItem8();
			return reference6.Visit(item6);
		}
		case 9:
		{
			ref TVisitor reference14 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference14;
				reference14 = ref val;
			}
			EntityCreateBatch item14 = UncheckedGetItem9();
			return reference14.Visit(item14);
		}
		case 10:
		{
			ref TVisitor reference12 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference12;
				reference12 = ref val;
			}
			EntityDestroy item12 = UncheckedGetItem10();
			return reference12.Visit(item12);
		}
		case 11:
		{
			ref TVisitor reference5 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference5;
				reference5 = ref val;
			}
			SetComponentBatch item5 = UncheckedGetItem11();
			return reference5.Visit(item5);
		}
		case 12:
		{
			ref TVisitor reference3 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference3;
				reference3 = ref val;
			}
			RemoveComponent item3 = UncheckedGetItem12();
			return reference3.Visit(item3);
		}
		case 13:
		{
			ref TVisitor reference16 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference16;
				reference16 = ref val;
			}
			GetComponents item16 = UncheckedGetItem13();
			return reference16.Visit(item16);
		}
		case 14:
		{
			ref TVisitor reference13 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference13;
				reference13 = ref val;
			}
			ScriptCreate item13 = UncheckedGetItem14();
			return reference13.Visit(item13);
		}
		case 15:
		{
			ref TVisitor reference10 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference10;
				reference10 = ref val;
			}
			ScriptUpdate item10 = UncheckedGetItem15();
			return reference10.Visit(item10);
		}
		case 16:
		{
			ref TVisitor reference7 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference7;
				reference7 = ref val;
			}
			ScriptDelete item7 = UncheckedGetItem16();
			return reference7.Visit(item7);
		}
		case 17:
		{
			ref TVisitor reference4 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference4;
				reference4 = ref val;
			}
			ScriptListRequest item4 = UncheckedGetItem17();
			return reference4.Visit(item4);
		}
		case 18:
		{
			ref TVisitor reference = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference;
				reference = ref val;
			}
			ScriptValidate item = UncheckedGetItem18();
			return reference.Visit(item);
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneCommand>(discriminator);
			return default;
		}
	}

	public TReturn Match<TReturn>(Func<SceneCreate, TReturn> caseSceneCreate, Func<SceneUnload, TReturn> caseSceneUnload, Func<SceneSetVisibility, TReturn> caseSceneSetVisibility, Func<SceneSetEditable, TReturn> caseSceneSetEditable, Func<SceneSetZOrder, TReturn> caseSceneSetZOrder, Func<SceneListRequest, TReturn> caseSceneListRequest, Func<SceneSnapshotRequest, TReturn> caseSceneSnapshotRequest, Func<SceneSetSelection, TReturn> caseSceneSetSelection, Func<EntityCreateBatch, TReturn> caseEntityCreateBatch, Func<EntityDestroy, TReturn> caseEntityDestroy, Func<SetComponentBatch, TReturn> caseSetComponentBatch, Func<RemoveComponent, TReturn> caseRemoveComponent, Func<GetComponents, TReturn> caseGetComponents, Func<ScriptCreate, TReturn> caseScriptCreate, Func<ScriptUpdate, TReturn> caseScriptUpdate, Func<ScriptDelete, TReturn> caseScriptDelete, Func<ScriptListRequest, TReturn> caseScriptListRequest, Func<ScriptValidate, TReturn> caseScriptValidate)
	{
		byte discriminator = Discriminator;
		switch (discriminator)
		{
		case 1:
			return caseSceneCreate(UncheckedGetItem1());
		case 2:
			return caseSceneUnload(UncheckedGetItem2());
		case 3:
			return caseSceneSetVisibility(UncheckedGetItem3());
		case 4:
			return caseSceneSetEditable(UncheckedGetItem4());
		case 5:
			return caseSceneSetZOrder(UncheckedGetItem5());
		case 6:
			return caseSceneListRequest(UncheckedGetItem6());
		case 7:
			return caseSceneSnapshotRequest(UncheckedGetItem7());
		case 8:
			return caseSceneSetSelection(UncheckedGetItem8());
		case 9:
			return caseEntityCreateBatch(UncheckedGetItem9());
		case 10:
			return caseEntityDestroy(UncheckedGetItem10());
		case 11:
			return caseSetComponentBatch(UncheckedGetItem11());
		case 12:
			return caseRemoveComponent(UncheckedGetItem12());
		case 13:
			return caseGetComponents(UncheckedGetItem13());
		case 14:
			return caseScriptCreate(UncheckedGetItem14());
		case 15:
			return caseScriptUpdate(UncheckedGetItem15());
		case 16:
			return caseScriptDelete(UncheckedGetItem16());
		case 17:
			return caseScriptListRequest(UncheckedGetItem17());
		case 18:
			return caseScriptValidate(UncheckedGetItem18());
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<SceneCommand>(discriminator);
			return default;
		}
	}
}
