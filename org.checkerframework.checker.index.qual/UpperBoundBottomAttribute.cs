using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyUpperBoundBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.UpperBoundBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UpperBoundBottomAttribute : AnnotationAttributeBase, UpperBoundBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UpperBoundBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UpperBoundBottomAttribute()
		: base(ClassLiteral<UpperBoundBottom>.Value)
	{
	}
}
