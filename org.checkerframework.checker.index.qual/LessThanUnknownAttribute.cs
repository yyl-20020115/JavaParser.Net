using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyLessThanUnknown", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.LessThanUnknown" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LessThanUnknownAttribute : AnnotationAttributeBase, LessThanUnknown
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LessThanUnknownAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LessThanUnknownAttribute()
		: base(ClassLiteral<LessThanUnknown>.Value)
	{
	}
}
