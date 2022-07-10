using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyPolyLowerBound", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.PolyLowerBound" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyLowerBoundAttribute : AnnotationAttributeBase, PolyLowerBound
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyLowerBoundAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyLowerBoundAttribute()
		: base(ClassLiteral<PolyLowerBound>.Value)
	{
	}
}
