using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxySignatureBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.SignatureBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SignatureBottomAttribute : AnnotationAttributeBase, SignatureBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SignatureBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SignatureBottomAttribute()
		: base(ClassLiteral<SignatureBottom>.Value)
	{
	}
}
