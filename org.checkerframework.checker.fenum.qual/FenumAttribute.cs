using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxyFenum", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.Fenum" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FenumAttribute : AnnotationAttributeBase, Fenum
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FenumAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private FenumAttribute()
		: base(ClassLiteral<Fenum>.Value)
	{
	}

	[HideFromJava]
	public FenumAttribute(string value)
		: this()
	{
		setValue("value", value);
	}

	private string value()
	{
		return (string)getValue("value");
	}

	string Fenum.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
