using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxySignatureUnknown", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.SignatureUnknown" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SignatureUnknownAttribute : AnnotationAttributeBase, SignatureUnknown
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SignatureUnknownAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SignatureUnknownAttribute()
		: base(ClassLiteral<SignatureUnknown>.Value)
	{
	}
}
