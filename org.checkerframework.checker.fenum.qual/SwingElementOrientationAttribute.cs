using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxySwingElementOrientation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.SwingElementOrientation" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SwingElementOrientationAttribute : AnnotationAttributeBase, SwingElementOrientation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SwingElementOrientationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SwingElementOrientationAttribute()
		: base(ClassLiteral<SwingElementOrientation>.Value)
	{
	}
}
