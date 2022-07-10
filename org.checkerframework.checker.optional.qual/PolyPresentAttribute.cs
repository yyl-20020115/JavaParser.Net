using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.optional.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.optional.qual.$ProxyPolyPresent", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.optional.qual.PolyPresent" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyPresentAttribute : AnnotationAttributeBase, PolyPresent
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyPresentAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyPresentAttribute()
		: base(ClassLiteral<PolyPresent>.Value)
	{
	}
}
