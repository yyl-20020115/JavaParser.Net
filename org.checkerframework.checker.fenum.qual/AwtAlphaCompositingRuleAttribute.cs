using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxyAwtAlphaCompositingRule", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.AwtAlphaCompositingRule" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class AwtAlphaCompositingRuleAttribute : AnnotationAttributeBase, AwtAlphaCompositingRule
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AwtAlphaCompositingRuleAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AwtAlphaCompositingRuleAttribute()
		: base(ClassLiteral<AwtAlphaCompositingRule>.Value)
	{
	}
}
