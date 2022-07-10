using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signedness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signedness.qual.$ProxyPolySigned", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signedness.qual.PolySigned" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolySignedAttribute : AnnotationAttributeBase, PolySigned
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolySignedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolySignedAttribute()
		: base(ClassLiteral<PolySigned>.Value)
	{
	}
}
