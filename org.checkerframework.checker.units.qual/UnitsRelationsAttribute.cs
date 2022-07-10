using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyUnitsRelations", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.UnitsRelations" })]
public sealed class UnitsRelationsAttribute : AnnotationAttributeBase, UnitsRelations
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnitsRelationsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private UnitsRelationsAttribute()
		: base(ClassLiteral<UnitsRelations>.Value)
	{
	}

	[HideFromJava]
	public UnitsRelationsAttribute(Type value)
		: this()
	{
		setValue("value", value);
	}

	private Class value()
	{
		return (Class)getValue("value");
	}

	Class UnitsRelations.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
