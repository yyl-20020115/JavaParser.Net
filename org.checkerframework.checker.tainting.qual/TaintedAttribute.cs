using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.tainting.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.tainting.qual.$ProxyTainted", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.tainting.qual.Tainted" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class TaintedAttribute : AnnotationAttributeBase, Tainted
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public TaintedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public TaintedAttribute()
		: base(ClassLiteral<Tainted>.Value)
	{
	}
}
