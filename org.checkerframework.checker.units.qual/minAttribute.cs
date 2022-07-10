using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxymin", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.min" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class minAttribute : AnnotationAttributeBase, min
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public minAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public minAttribute()
		: base(ClassLiteral<min>.Value)
	{
	}
}
