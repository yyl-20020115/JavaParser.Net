using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyLTEqLengthOf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.LTEqLengthOf" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LTEqLengthOfAttribute : AnnotationAttributeBase, LTEqLengthOf
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LTEqLengthOfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private LTEqLengthOfAttribute()
		: base(ClassLiteral<LTEqLengthOf>.Value)
	{
	}

	[HideFromJava]
	public LTEqLengthOfAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] LTEqLengthOf.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
