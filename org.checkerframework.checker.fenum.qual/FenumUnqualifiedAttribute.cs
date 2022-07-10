using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxyFenumUnqualified", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.FenumUnqualified" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FenumUnqualifiedAttribute : AnnotationAttributeBase, FenumUnqualified
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FenumUnqualifiedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FenumUnqualifiedAttribute()
		: base(ClassLiteral<FenumUnqualified>.Value)
	{
	}
}
