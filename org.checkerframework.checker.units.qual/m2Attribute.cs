using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxym2", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.m2" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class m2Attribute : AnnotationAttributeBase, m2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public m2Attribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public m2Attribute()
		: base(ClassLiteral<m2>.Value)
	{
	}

	[HideFromJava]
	public m2Attribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix m2.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
