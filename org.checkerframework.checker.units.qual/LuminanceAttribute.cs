using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyLuminance", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Luminance" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LuminanceAttribute : AnnotationAttributeBase, Luminance
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LuminanceAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LuminanceAttribute()
		: base(ClassLiteral<Luminance>.Value)
	{
	}
}
