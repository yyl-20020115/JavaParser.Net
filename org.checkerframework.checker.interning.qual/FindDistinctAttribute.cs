using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.interning.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.interning.qual.$ProxyFindDistinct", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.interning.qual.FindDistinct" })]
[AttributeUsage(AttributeTargets.Parameter)]
public sealed class FindDistinctAttribute : AnnotationAttributeBase, FindDistinct
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FindDistinctAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FindDistinctAttribute()
		: base(ClassLiteral<FindDistinct>.Value)
	{
	}
}
