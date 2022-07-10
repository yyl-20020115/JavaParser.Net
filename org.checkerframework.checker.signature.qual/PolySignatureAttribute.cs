using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyPolySignature", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.PolySignature" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolySignatureAttribute : AnnotationAttributeBase, PolySignature
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolySignatureAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolySignatureAttribute()
		: base(ClassLiteral<PolySignature>.Value)
	{
	}
}
