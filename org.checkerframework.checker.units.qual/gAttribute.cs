using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxyg", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.g" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class gAttribute : AnnotationAttributeBase, g
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public gAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public gAttribute()
		: base(ClassLiteral<g>.Value)
	{
	}

	[HideFromJava]
	public gAttribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix g.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
