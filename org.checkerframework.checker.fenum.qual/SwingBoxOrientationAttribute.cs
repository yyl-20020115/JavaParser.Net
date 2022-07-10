using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxySwingBoxOrientation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.SwingBoxOrientation" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SwingBoxOrientationAttribute : AnnotationAttributeBase, SwingBoxOrientation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SwingBoxOrientationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SwingBoxOrientationAttribute()
		: base(ClassLiteral<SwingBoxOrientation>.Value)
	{
	}
}
