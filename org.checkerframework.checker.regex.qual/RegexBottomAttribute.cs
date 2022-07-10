using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.regex.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.regex.qual.$ProxyRegexBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.regex.qual.RegexBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class RegexBottomAttribute : AnnotationAttributeBase, RegexBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public RegexBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public RegexBottomAttribute()
		: base(ClassLiteral<RegexBottom>.Value)
	{
	}
}
