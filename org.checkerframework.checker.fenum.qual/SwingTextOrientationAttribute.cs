using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxySwingTextOrientation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.SwingTextOrientation" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SwingTextOrientationAttribute : AnnotationAttributeBase, SwingTextOrientation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SwingTextOrientationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SwingTextOrientationAttribute()
		: base(ClassLiteral<SwingTextOrientation>.Value)
	{
	}
}
