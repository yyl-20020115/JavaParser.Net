using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.interning.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.interning.qual.$ProxyInternedDistinct", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.interning.qual.InternedDistinct" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class InternedDistinctAttribute : AnnotationAttributeBase, InternedDistinct
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InternedDistinctAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InternedDistinctAttribute()
		: base(ClassLiteral<InternedDistinct>.Value)
	{
	}
}
