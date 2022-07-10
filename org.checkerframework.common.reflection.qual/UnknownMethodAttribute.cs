using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyUnknownMethod", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.UnknownMethod" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownMethodAttribute : AnnotationAttributeBase, UnknownMethod
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownMethodAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownMethodAttribute()
		: base(ClassLiteral<UnknownMethod>.Value)
	{
	}
}
