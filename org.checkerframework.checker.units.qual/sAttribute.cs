using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxys", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.s" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class sAttribute : AnnotationAttributeBase, s
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public sAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public sAttribute()
		: base(ClassLiteral<s>.Value)
	{
	}

	[HideFromJava]
	public sAttribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix s.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
