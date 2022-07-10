using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxyPolyFenum", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.PolyFenum" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyFenumAttribute : AnnotationAttributeBase, PolyFenum
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyFenumAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyFenumAttribute()
		: base(ClassLiteral<PolyFenum>.Value)
	{
	}
}
