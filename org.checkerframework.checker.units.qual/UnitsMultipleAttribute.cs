using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyUnitsMultiple", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.UnitsMultiple" })]
public sealed class UnitsMultipleAttribute : AnnotationAttributeBase, UnitsMultiple
{
	[HideFromJava]
	public Prefix.__Enum prefix
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("prefix", value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnitsMultipleAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private UnitsMultipleAttribute()
		: base(ClassLiteral<UnitsMultiple>.Value)
	{
	}

	[HideFromJava]
	public UnitsMultipleAttribute(Type quantity)
		: this()
	{
		setValue("quantity", quantity);
	}

	private Class quantity()
	{
		return (Class)getValue("quantity");
	}

	Class UnitsMultiple.quantity()
	{
		//ILSpy generated this explicit interface implementation from .override directive in quantity
		return this.quantity();
	}

	private Prefix prefix()
	{
		return (Prefix)getValue("prefix");
	}

	Prefix UnitsMultiple.prefix()
	{
		//ILSpy generated this explicit interface implementation from .override directive in prefix
		return this.prefix();
	}
}
