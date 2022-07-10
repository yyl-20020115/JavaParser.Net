using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.optional.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.optional.qual.$ProxyPresent", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.optional.qual.Present" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PresentAttribute : AnnotationAttributeBase, Present
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PresentAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PresentAttribute()
		: base(ClassLiteral<Present>.Value)
	{
	}
}
