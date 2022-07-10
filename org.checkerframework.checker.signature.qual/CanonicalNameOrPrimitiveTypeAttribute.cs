using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyCanonicalNameOrPrimitiveType", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.CanonicalNameOrPrimitiveType" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CanonicalNameOrPrimitiveTypeAttribute : AnnotationAttributeBase, CanonicalNameOrPrimitiveType
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CanonicalNameOrPrimitiveTypeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CanonicalNameOrPrimitiveTypeAttribute()
		: base(ClassLiteral<CanonicalNameOrPrimitiveType>.Value)
	{
	}
}
