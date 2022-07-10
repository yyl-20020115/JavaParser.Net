using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.regex.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.regex.qual.$ProxyPolyRegex", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.regex.qual.PolyRegex" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyRegexAttribute : AnnotationAttributeBase, PolyRegex
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyRegexAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyRegexAttribute()
		: base(ClassLiteral<PolyRegex>.Value)
	{
	}
}
