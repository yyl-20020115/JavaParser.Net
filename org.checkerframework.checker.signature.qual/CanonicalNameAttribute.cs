using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyCanonicalName", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.CanonicalName" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CanonicalNameAttribute : AnnotationAttributeBase, CanonicalName
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CanonicalNameAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CanonicalNameAttribute()
		: base(ClassLiteral<CanonicalName>.Value)
	{
	}
}
