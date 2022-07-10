using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyCurrent", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Current" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CurrentAttribute : AnnotationAttributeBase, Current
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CurrentAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CurrentAttribute()
		: base(ClassLiteral<Current>.Value)
	{
	}
}
