using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxym", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.m" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class mAttribute : AnnotationAttributeBase, m
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public mAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public mAttribute()
		: base(ClassLiteral<m>.Value)
	{
	}

	[HideFromJava]
	public mAttribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix m.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
