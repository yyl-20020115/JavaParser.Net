using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyA", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.A" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class AAttribute : AnnotationAttributeBase, A
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AAttribute()
		: base(ClassLiteral<A>.Value)
	{
	}

	[HideFromJava]
	public AAttribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix A.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
