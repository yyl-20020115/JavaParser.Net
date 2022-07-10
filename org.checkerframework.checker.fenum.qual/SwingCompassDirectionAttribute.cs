using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxySwingCompassDirection", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.SwingCompassDirection" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SwingCompassDirectionAttribute : AnnotationAttributeBase, SwingCompassDirection
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SwingCompassDirectionAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SwingCompassDirectionAttribute()
		: base(ClassLiteral<SwingCompassDirection>.Value)
	{
	}
}
