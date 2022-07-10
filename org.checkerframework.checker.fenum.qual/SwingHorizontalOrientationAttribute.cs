using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxySwingHorizontalOrientation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.SwingHorizontalOrientation" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SwingHorizontalOrientationAttribute : AnnotationAttributeBase, SwingHorizontalOrientation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SwingHorizontalOrientationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SwingHorizontalOrientationAttribute()
		: base(ClassLiteral<SwingHorizontalOrientation>.Value)
	{
	}
}
