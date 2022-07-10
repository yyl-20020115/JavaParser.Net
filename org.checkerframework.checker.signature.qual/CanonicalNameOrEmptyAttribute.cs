using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyCanonicalNameOrEmpty", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.CanonicalNameOrEmpty" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CanonicalNameOrEmptyAttribute : AnnotationAttributeBase, CanonicalNameOrEmpty
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CanonicalNameOrEmptyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CanonicalNameOrEmptyAttribute()
		: base(ClassLiteral<CanonicalNameOrEmpty>.Value)
	{
	}
}
