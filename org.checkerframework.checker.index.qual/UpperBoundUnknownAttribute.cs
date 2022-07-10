using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyUpperBoundUnknown", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.UpperBoundUnknown" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UpperBoundUnknownAttribute : AnnotationAttributeBase, UpperBoundUnknown
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UpperBoundUnknownAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UpperBoundUnknownAttribute()
		: base(ClassLiteral<UpperBoundUnknown>.Value)
	{
	}
}
