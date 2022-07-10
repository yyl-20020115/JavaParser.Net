using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyCanonicalNameAndBinaryName", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.CanonicalNameAndBinaryName" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CanonicalNameAndBinaryNameAttribute : AnnotationAttributeBase, CanonicalNameAndBinaryName
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CanonicalNameAndBinaryNameAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CanonicalNameAndBinaryNameAttribute()
		: base(ClassLiteral<CanonicalNameAndBinaryName>.Value)
	{
	}
}
