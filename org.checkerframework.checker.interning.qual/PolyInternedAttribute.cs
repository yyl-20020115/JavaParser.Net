using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.interning.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.interning.qual.$ProxyPolyInterned", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.interning.qual.PolyInterned" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyInternedAttribute : AnnotationAttributeBase, PolyInterned
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyInternedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyInternedAttribute()
		: base(ClassLiteral<PolyInterned>.Value)
	{
	}
}
