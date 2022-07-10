using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyPolyUpperBound", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.PolyUpperBound" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyUpperBoundAttribute : AnnotationAttributeBase, PolyUpperBound
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyUpperBoundAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyUpperBoundAttribute()
		: base(ClassLiteral<PolyUpperBound>.Value)
	{
	}
}
