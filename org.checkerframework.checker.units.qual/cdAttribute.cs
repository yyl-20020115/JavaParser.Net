using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxycd", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.cd" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class cdAttribute : AnnotationAttributeBase, cd
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public cdAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public cdAttribute()
		: base(ClassLiteral<cd>.Value)
	{
	}

	[HideFromJava]
	public cdAttribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix cd.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
