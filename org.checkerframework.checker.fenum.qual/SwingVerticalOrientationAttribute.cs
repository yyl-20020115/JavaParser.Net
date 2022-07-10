using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxySwingVerticalOrientation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.SwingVerticalOrientation" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SwingVerticalOrientationAttribute : AnnotationAttributeBase, SwingVerticalOrientation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SwingVerticalOrientationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SwingVerticalOrientationAttribute()
		: base(ClassLiteral<SwingVerticalOrientation>.Value)
	{
	}
}
