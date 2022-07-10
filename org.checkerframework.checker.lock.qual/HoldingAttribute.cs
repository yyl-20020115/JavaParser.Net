using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyHolding", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.Holding" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class HoldingAttribute : AnnotationAttributeBase, Holding
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public HoldingAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private HoldingAttribute()
		: base(ClassLiteral<Holding>.Value)
	{
	}

	[HideFromJava]
	public HoldingAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] Holding.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
