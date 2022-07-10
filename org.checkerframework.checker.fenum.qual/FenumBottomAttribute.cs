using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxyFenumBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.FenumBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FenumBottomAttribute : AnnotationAttributeBase, FenumBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FenumBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FenumBottomAttribute()
		: base(ClassLiteral<FenumBottom>.Value)
	{
	}
}
