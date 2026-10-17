using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using FlatSharp;
using FlatSharp.Internal;

namespace BlueBottleIPC.LeagueBroadcast.Entity;

[CompilerGenerated]
public struct Component : IFlatBufferUnion<ComponentTransform, ComponentVisibility, ComponentEditState, ComponentScript, ComponentMeshRenderer, ComponentDecalProjector, ComponentTextRenderer, ComponentStreamSource, ComponentSpriteRenderer, ComponentUnitAnchor>, IFlatBufferUnion
{
	public enum ItemKind : byte
	{
		Transform = 1,
		Visibility = 2,
		EditState = 3,
		Script = 4,
		MeshRenderer = 5,
		DecalProjector = 6,
		TextRenderer = 7,
		StreamSource = 8,
		SpriteRenderer = 9,
		UnitAnchor = 10,
		NONE = 0
	}

	public interface Visitor<TReturn> : IFlatBufferUnionVisitor<TReturn, ComponentTransform, ComponentVisibility, ComponentEditState, ComponentScript, ComponentMeshRenderer, ComponentDecalProjector, ComponentTextRenderer, ComponentStreamSource, ComponentSpriteRenderer, ComponentUnitAnchor>
	{
	}

	private readonly object value;

	public ItemKind Kind => (ItemKind)Discriminator;

	public byte Discriminator { get; }

	public ComponentTransform Transform => Item1;

	public ComponentTransform Item1
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

	public ComponentVisibility Visibility => Item2;

	public ComponentVisibility Item2
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

	public ComponentEditState EditState => Item3;

	public ComponentEditState Item3
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

	public ComponentScript Script => Item4;

	public ComponentScript Item4
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

	public ComponentMeshRenderer MeshRenderer => Item5;

	public ComponentMeshRenderer Item5
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

	public ComponentDecalProjector DecalProjector => Item6;

	public ComponentDecalProjector Item6
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

	public ComponentTextRenderer TextRenderer => Item7;

	public ComponentTextRenderer Item7
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

	public ComponentStreamSource StreamSource => Item8;

	public ComponentStreamSource Item8
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

	public ComponentSpriteRenderer SpriteRenderer => Item9;

	public ComponentSpriteRenderer Item9
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

	public ComponentUnitAnchor UnitAnchor => Item10;

	public ComponentUnitAnchor Item10
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

	public Component(ComponentTransform value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 1;
		this.value = value;
	}

	public static implicit operator Component(ComponentTransform value)
	{
		return new Component(value);
	}

	private ComponentTransform UncheckedGetItem1()
	{
		return (ComponentTransform)value;
	}

	public bool TryGet([NotNullWhen(true)] out ComponentTransform? value)
	{
		if (Discriminator != 1)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem1();
		return true;
	}

	public Component(ComponentVisibility value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 2;
		this.value = value;
	}

	public static implicit operator Component(ComponentVisibility value)
	{
		return new Component(value);
	}

	private ComponentVisibility UncheckedGetItem2()
	{
		return (ComponentVisibility)value;
	}

	public bool TryGet([NotNullWhen(true)] out ComponentVisibility? value)
	{
		if (Discriminator != 2)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem2();
		return true;
	}

	public Component(ComponentEditState value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 3;
		this.value = value;
	}

	public static implicit operator Component(ComponentEditState value)
	{
		return new Component(value);
	}

	private ComponentEditState UncheckedGetItem3()
	{
		return (ComponentEditState)value;
	}

	public bool TryGet([NotNullWhen(true)] out ComponentEditState? value)
	{
		if (Discriminator != 3)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem3();
		return true;
	}

	public Component(ComponentScript value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 4;
		this.value = value;
	}

	public static implicit operator Component(ComponentScript value)
	{
		return new Component(value);
	}

	private ComponentScript UncheckedGetItem4()
	{
		return (ComponentScript)value;
	}

	public bool TryGet([NotNullWhen(true)] out ComponentScript? value)
	{
		if (Discriminator != 4)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem4();
		return true;
	}

	public Component(ComponentMeshRenderer value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 5;
		this.value = value;
	}

	public static implicit operator Component(ComponentMeshRenderer value)
	{
		return new Component(value);
	}

	private ComponentMeshRenderer UncheckedGetItem5()
	{
		return (ComponentMeshRenderer)value;
	}

	public bool TryGet([NotNullWhen(true)] out ComponentMeshRenderer? value)
	{
		if (Discriminator != 5)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem5();
		return true;
	}

	public Component(ComponentDecalProjector value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 6;
		this.value = value;
	}

	public static implicit operator Component(ComponentDecalProjector value)
	{
		return new Component(value);
	}

	private ComponentDecalProjector UncheckedGetItem6()
	{
		return (ComponentDecalProjector)value;
	}

	public bool TryGet([NotNullWhen(true)] out ComponentDecalProjector? value)
	{
		if (Discriminator != 6)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem6();
		return true;
	}

	public Component(ComponentTextRenderer value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 7;
		this.value = value;
	}

	public static implicit operator Component(ComponentTextRenderer value)
	{
		return new Component(value);
	}

	private ComponentTextRenderer UncheckedGetItem7()
	{
		return (ComponentTextRenderer)value;
	}

	public bool TryGet([NotNullWhen(true)] out ComponentTextRenderer? value)
	{
		if (Discriminator != 7)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem7();
		return true;
	}

	public Component(ComponentStreamSource value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 8;
		this.value = value;
	}

	public static implicit operator Component(ComponentStreamSource value)
	{
		return new Component(value);
	}

	private ComponentStreamSource UncheckedGetItem8()
	{
		return (ComponentStreamSource)value;
	}

	public bool TryGet([NotNullWhen(true)] out ComponentStreamSource? value)
	{
		if (Discriminator != 8)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem8();
		return true;
	}

	public Component(ComponentSpriteRenderer value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 9;
		this.value = value;
	}

	public static implicit operator Component(ComponentSpriteRenderer value)
	{
		return new Component(value);
	}

	private ComponentSpriteRenderer UncheckedGetItem9()
	{
		return (ComponentSpriteRenderer)value;
	}

	public bool TryGet([NotNullWhen(true)] out ComponentSpriteRenderer? value)
	{
		if (Discriminator != 9)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem9();
		return true;
	}

	public Component(ComponentUnitAnchor value)
	{
		if (value == null)
		{
			FSThrow.ArgumentNull("value");
		}
		Discriminator = 10;
		this.value = value;
	}

	public static implicit operator Component(ComponentUnitAnchor value)
	{
		return new Component(value);
	}

	private ComponentUnitAnchor UncheckedGetItem10()
	{
		return (ComponentUnitAnchor)value;
	}

	public bool TryGet([NotNullWhen(true)] out ComponentUnitAnchor? value)
	{
		if (Discriminator != 10)
		{
			value = null;
			return false;
		}
		value = UncheckedGetItem10();
		return true;
	}

	public TReturn Accept<TVisitor, TReturn>(TVisitor visitor) where TVisitor : IFlatBufferUnionVisitor<TReturn, ComponentTransform, ComponentVisibility, ComponentEditState, ComponentScript, ComponentMeshRenderer, ComponentDecalProjector, ComponentTextRenderer, ComponentStreamSource, ComponentSpriteRenderer, ComponentUnitAnchor>
	{
		byte discriminator = Discriminator;
		TVisitor val;
		switch (discriminator)
		{
		case 1:
		{
			ref TVisitor reference3 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference3;
				reference3 = ref val;
			}
			ComponentTransform item3 = UncheckedGetItem1();
			return reference3.Visit(item3);
		}
		case 2:
		{
			ref TVisitor reference5 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference5;
				reference5 = ref val;
			}
			ComponentVisibility item5 = UncheckedGetItem2();
			return reference5.Visit(item5);
		}
		case 3:
		{
			ref TVisitor reference2 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference2;
				reference2 = ref val;
			}
			ComponentEditState item2 = UncheckedGetItem3();
			return reference2.Visit(item2);
		}
		case 4:
		{
			ref TVisitor reference9 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference9;
				reference9 = ref val;
			}
			ComponentScript item9 = UncheckedGetItem4();
			return reference9.Visit(item9);
		}
		case 5:
		{
			ref TVisitor reference8 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference8;
				reference8 = ref val;
			}
			ComponentMeshRenderer item8 = UncheckedGetItem5();
			return reference8.Visit(item8);
		}
		case 6:
		{
			ref TVisitor reference6 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference6;
				reference6 = ref val;
			}
			ComponentDecalProjector item6 = UncheckedGetItem6();
			return reference6.Visit(item6);
		}
		case 7:
		{
			ref TVisitor reference10 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference10;
				reference10 = ref val;
			}
			ComponentTextRenderer item10 = UncheckedGetItem7();
			return reference10.Visit(item10);
		}
		case 8:
		{
			ref TVisitor reference7 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference7;
				reference7 = ref val;
			}
			ComponentStreamSource item7 = UncheckedGetItem8();
			return reference7.Visit(item7);
		}
		case 9:
		{
			ref TVisitor reference4 = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference4;
				reference4 = ref val;
			}
			ComponentSpriteRenderer item4 = UncheckedGetItem9();
			return reference4.Visit(item4);
		}
		case 10:
		{
			ref TVisitor reference = ref visitor;
			val = default;
			if (val == null)
			{
				val = reference;
				reference = ref val;
			}
			ComponentUnitAnchor item = UncheckedGetItem10();
			return reference.Visit(item);
		}
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<Component>(discriminator);
			return default;
		}
	}

	public TReturn Match<TReturn>(Func<ComponentTransform, TReturn> caseTransform, Func<ComponentVisibility, TReturn> caseVisibility, Func<ComponentEditState, TReturn> caseEditState, Func<ComponentScript, TReturn> caseScript, Func<ComponentMeshRenderer, TReturn> caseMeshRenderer, Func<ComponentDecalProjector, TReturn> caseDecalProjector, Func<ComponentTextRenderer, TReturn> caseTextRenderer, Func<ComponentStreamSource, TReturn> caseStreamSource, Func<ComponentSpriteRenderer, TReturn> caseSpriteRenderer, Func<ComponentUnitAnchor, TReturn> caseUnitAnchor)
	{
		byte discriminator = Discriminator;
		switch (discriminator)
		{
		case 1:
			return caseTransform(UncheckedGetItem1());
		case 2:
			return caseVisibility(UncheckedGetItem2());
		case 3:
			return caseEditState(UncheckedGetItem3());
		case 4:
			return caseScript(UncheckedGetItem4());
		case 5:
			return caseMeshRenderer(UncheckedGetItem5());
		case 6:
			return caseDecalProjector(UncheckedGetItem6());
		case 7:
			return caseTextRenderer(UncheckedGetItem7());
		case 8:
			return caseStreamSource(UncheckedGetItem8());
		case 9:
			return caseSpriteRenderer(UncheckedGetItem9());
		case 10:
			return caseUnitAnchor(UncheckedGetItem10());
		default:
			FSThrow.InvalidOperation_InvalidUnionDiscriminator<Component>(discriminator);
			return default;
		}
	}
}
