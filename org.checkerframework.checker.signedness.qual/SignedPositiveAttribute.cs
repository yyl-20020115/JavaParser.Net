using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signedness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signedness.qual.$ProxySignedPositive", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signedness.qual.SignedPositive" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SignedPositiveAttribute : AnnotationAttributeBase, SignedPositive
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SignedPositiveAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SignedPositiveAttribute()
		: base(ClassLiteral<SignedPositive>.Value)
	{
	}
}
