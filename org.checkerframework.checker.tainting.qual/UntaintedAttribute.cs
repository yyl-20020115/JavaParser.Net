using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.tainting.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.tainting.qual.$ProxyUntainted", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.tainting.qual.Untainted" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UntaintedAttribute : AnnotationAttributeBase, Untainted
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UntaintedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UntaintedAttribute()
		: base(ClassLiteral<Untainted>.Value)
	{
	}
}
