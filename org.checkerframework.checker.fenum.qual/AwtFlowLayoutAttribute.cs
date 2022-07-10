using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxyAwtFlowLayout", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.AwtFlowLayout" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class AwtFlowLayoutAttribute : AnnotationAttributeBase, AwtFlowLayout
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AwtFlowLayoutAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AwtFlowLayoutAttribute()
		: base(ClassLiteral<AwtFlowLayout>.Value)
	{
	}
}
