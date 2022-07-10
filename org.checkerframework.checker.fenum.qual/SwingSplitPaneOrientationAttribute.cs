using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxySwingSplitPaneOrientation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.SwingSplitPaneOrientation" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SwingSplitPaneOrientationAttribute : AnnotationAttributeBase, SwingSplitPaneOrientation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SwingSplitPaneOrientationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SwingSplitPaneOrientationAttribute()
		: base(ClassLiteral<SwingSplitPaneOrientation>.Value)
	{
	}
}
