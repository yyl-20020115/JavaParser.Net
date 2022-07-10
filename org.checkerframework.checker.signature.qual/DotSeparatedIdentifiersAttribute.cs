using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyDotSeparatedIdentifiers", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.DotSeparatedIdentifiers" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class DotSeparatedIdentifiersAttribute : AnnotationAttributeBase, DotSeparatedIdentifiers
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public DotSeparatedIdentifiersAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public DotSeparatedIdentifiersAttribute()
		: base(ClassLiteral<DotSeparatedIdentifiers>.Value)
	{
	}
}
