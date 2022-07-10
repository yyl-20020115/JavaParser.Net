using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxyFenumTop", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.FenumTop" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FenumTopAttribute : AnnotationAttributeBase, FenumTop
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FenumTopAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FenumTopAttribute()
		: base(ClassLiteral<FenumTop>.Value)
	{
	}
}
