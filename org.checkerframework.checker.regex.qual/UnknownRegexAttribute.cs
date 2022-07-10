using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.regex.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.regex.qual.$ProxyUnknownRegex", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.regex.qual.UnknownRegex" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownRegexAttribute : AnnotationAttributeBase, UnknownRegex
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownRegexAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownRegexAttribute()
		: base(ClassLiteral<UnknownRegex>.Value)
	{
	}
}
