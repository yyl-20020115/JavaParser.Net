using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxykg", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.kg" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class kgAttribute : AnnotationAttributeBase, kg
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public kgAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public kgAttribute()
		: base(ClassLiteral<kg>.Value)
	{
	}
}
