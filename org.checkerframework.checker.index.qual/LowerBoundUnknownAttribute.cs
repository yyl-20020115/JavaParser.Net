using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyLowerBoundUnknown", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.LowerBoundUnknown" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LowerBoundUnknownAttribute : AnnotationAttributeBase, LowerBoundUnknown
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LowerBoundUnknownAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LowerBoundUnknownAttribute()
		: base(ClassLiteral<LowerBoundUnknown>.Value)
	{
	}
}
