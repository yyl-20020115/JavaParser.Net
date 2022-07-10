using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.interning.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.interning.qual.$ProxyUnknownInterned", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.interning.qual.UnknownInterned" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownInternedAttribute : AnnotationAttributeBase, UnknownInterned
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownInternedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownInternedAttribute()
		: base(ClassLiteral<UnknownInterned>.Value)
	{
	}
}
