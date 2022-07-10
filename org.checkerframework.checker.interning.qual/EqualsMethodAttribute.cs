using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.interning.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.interning.qual.$ProxyEqualsMethod", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.interning.qual.EqualsMethod" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class EqualsMethodAttribute : AnnotationAttributeBase, EqualsMethod
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EqualsMethodAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public EqualsMethodAttribute()
		: base(ClassLiteral<EqualsMethod>.Value)
	{
	}
}
