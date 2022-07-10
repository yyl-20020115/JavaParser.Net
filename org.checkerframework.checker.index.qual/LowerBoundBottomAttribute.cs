using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyLowerBoundBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.LowerBoundBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LowerBoundBottomAttribute : AnnotationAttributeBase, LowerBoundBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LowerBoundBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LowerBoundBottomAttribute()
		: base(ClassLiteral<LowerBoundBottom>.Value)
	{
	}
}
