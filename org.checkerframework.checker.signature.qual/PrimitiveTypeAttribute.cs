using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyPrimitiveType", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.PrimitiveType" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PrimitiveTypeAttribute : AnnotationAttributeBase, PrimitiveType
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PrimitiveTypeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PrimitiveTypeAttribute()
		: base(ClassLiteral<PrimitiveType>.Value)
	{
	}
}
