using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxySwingTitleJustification", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.SwingTitleJustification" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SwingTitleJustificationAttribute : AnnotationAttributeBase, SwingTitleJustification
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SwingTitleJustificationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SwingTitleJustificationAttribute()
		: base(ClassLiteral<SwingTitleJustification>.Value)
	{
	}
}
