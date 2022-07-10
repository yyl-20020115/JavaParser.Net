using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyIdentifier", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.Identifier" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class IdentifierAttribute : AnnotationAttributeBase, Identifier
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public IdentifierAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public IdentifierAttribute()
		: base(ClassLiteral<Identifier>.Value)
	{
	}
}
