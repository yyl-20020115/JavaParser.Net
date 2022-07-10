using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.regex.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.regex.qual.$ProxyPartialRegex", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.regex.qual.PartialRegex" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PartialRegexAttribute : AnnotationAttributeBase, PartialRegex
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PartialRegexAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PartialRegexAttribute()
		: base(ClassLiteral<PartialRegex>.Value)
	{
	}

	[HideFromJava]
	public PartialRegexAttribute(string value)
		: this()
	{
		setValue("value", value);
	}

	private string value()
	{
		return (string)getValue("value");
	}

	string PartialRegex.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
