using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyUnknownClass", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.UnknownClass" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownClassAttribute : AnnotationAttributeBase, UnknownClass
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownClassAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownClassAttribute()
		: base(ClassLiteral<UnknownClass>.Value)
	{
	}
}
