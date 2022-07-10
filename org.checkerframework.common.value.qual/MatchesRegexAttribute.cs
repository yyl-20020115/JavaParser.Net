using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyMatchesRegex", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.MatchesRegex" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MatchesRegexAttribute : AnnotationAttributeBase, MatchesRegex
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MatchesRegexAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private MatchesRegexAttribute()
		: base(ClassLiteral<MatchesRegex>.Value)
	{
	}

	[HideFromJava]
	public MatchesRegexAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] MatchesRegex.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
