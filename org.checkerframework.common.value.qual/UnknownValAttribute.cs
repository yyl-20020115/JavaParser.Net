using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyUnknownVal", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.UnknownVal" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownValAttribute : AnnotationAttributeBase, UnknownVal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownValAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownValAttribute()
		: base(ClassLiteral<UnknownVal>.Value)
	{
	}
}
