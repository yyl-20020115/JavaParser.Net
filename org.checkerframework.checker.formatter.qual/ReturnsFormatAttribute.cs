using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.formatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.formatter.qual.$ProxyReturnsFormat", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.formatter.qual.ReturnsFormat" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class ReturnsFormatAttribute : AnnotationAttributeBase, ReturnsFormat
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ReturnsFormatAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ReturnsFormatAttribute()
		: base(ClassLiteral<ReturnsFormat>.Value)
	{
	}
}
