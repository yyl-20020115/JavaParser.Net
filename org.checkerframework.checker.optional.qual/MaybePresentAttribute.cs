using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.optional.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.optional.qual.$ProxyMaybePresent", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.optional.qual.MaybePresent" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MaybePresentAttribute : AnnotationAttributeBase, MaybePresent
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MaybePresentAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public MaybePresentAttribute()
		: base(ClassLiteral<MaybePresent>.Value)
	{
	}
}
