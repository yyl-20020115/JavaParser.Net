using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxySwingTitlePosition", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.SwingTitlePosition" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SwingTitlePositionAttribute : AnnotationAttributeBase, SwingTitlePosition
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SwingTitlePositionAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SwingTitlePositionAttribute()
		: base(ClassLiteral<SwingTitlePosition>.Value)
	{
	}
}
