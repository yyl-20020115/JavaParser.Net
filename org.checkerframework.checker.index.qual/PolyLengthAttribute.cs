using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyPolyLength", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.PolyLength" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyLengthAttribute : AnnotationAttributeBase, PolyLength
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyLengthAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyLengthAttribute()
		: base(ClassLiteral<PolyLength>.Value)
	{
	}
}
