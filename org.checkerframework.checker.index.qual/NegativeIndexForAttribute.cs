using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyNegativeIndexFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.NegativeIndexFor" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class NegativeIndexForAttribute : AnnotationAttributeBase, NegativeIndexFor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NegativeIndexForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private NegativeIndexForAttribute()
		: base(ClassLiteral<NegativeIndexFor>.Value)
	{
	}

	[HideFromJava]
	public NegativeIndexForAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] NegativeIndexFor.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
