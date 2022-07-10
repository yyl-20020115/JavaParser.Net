using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.interning.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.interning.qual.$ProxyCompareToMethod", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.interning.qual.CompareToMethod" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class CompareToMethodAttribute : AnnotationAttributeBase, CompareToMethod
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CompareToMethodAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CompareToMethodAttribute()
		: base(ClassLiteral<CompareToMethod>.Value)
	{
	}
}
