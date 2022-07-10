using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.regex.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.regex.qual.$ProxyRegex", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.regex.qual.Regex" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class RegexAttribute : AnnotationAttributeBase, Regex
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public RegexAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public RegexAttribute()
		: base(ClassLiteral<Regex>.Value)
	{
	}

	[HideFromJava]
	public RegexAttribute(int value)
		: this()
	{
		setValue("value", value);
	}

	private int value()
	{
		return getIntValue("value");
	}

	int Regex.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
