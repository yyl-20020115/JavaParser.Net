using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signedness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signedness.qual.$ProxySignedPositiveFromUnsigned", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signedness.qual.SignedPositiveFromUnsigned" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SignedPositiveFromUnsignedAttribute : AnnotationAttributeBase, SignedPositiveFromUnsigned
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SignedPositiveFromUnsignedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SignedPositiveFromUnsignedAttribute()
		: base(ClassLiteral<SignedPositiveFromUnsigned>.Value)
	{
	}
}
