using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxykm", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.km" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class kmAttribute : AnnotationAttributeBase, km
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public kmAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public kmAttribute()
		: base(ClassLiteral<km>.Value)
	{
	}
}
