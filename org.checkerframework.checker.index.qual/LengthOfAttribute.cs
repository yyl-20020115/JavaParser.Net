using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyLengthOf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.LengthOf" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class LengthOfAttribute : AnnotationAttributeBase, LengthOf
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LengthOfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private LengthOfAttribute()
		: base(ClassLiteral<LengthOf>.Value)
	{
	}

	[HideFromJava]
	public LengthOfAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] LengthOf.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
