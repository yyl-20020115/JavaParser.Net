using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyIdentifierOrPrimitiveType", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.IdentifierOrPrimitiveType" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class IdentifierOrPrimitiveTypeAttribute : AnnotationAttributeBase, IdentifierOrPrimitiveType
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public IdentifierOrPrimitiveTypeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public IdentifierOrPrimitiveTypeAttribute()
		: base(ClassLiteral<IdentifierOrPrimitiveType>.Value)
	{
	}
}
