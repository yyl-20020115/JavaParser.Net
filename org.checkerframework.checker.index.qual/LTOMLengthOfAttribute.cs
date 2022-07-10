using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyLTOMLengthOf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.LTOMLengthOf" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LTOMLengthOfAttribute : AnnotationAttributeBase, LTOMLengthOf
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LTOMLengthOfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private LTOMLengthOfAttribute()
		: base(ClassLiteral<LTOMLengthOf>.Value)
	{
	}

	[HideFromJava]
	public LTOMLengthOfAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] LTOMLengthOf.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
