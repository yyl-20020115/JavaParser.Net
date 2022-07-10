using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.formatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.formatter.qual.$ProxyFormatBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.formatter.qual.FormatBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FormatBottomAttribute : AnnotationAttributeBase, FormatBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FormatBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FormatBottomAttribute()
		: base(ClassLiteral<FormatBottom>.Value)
	{
	}
}
