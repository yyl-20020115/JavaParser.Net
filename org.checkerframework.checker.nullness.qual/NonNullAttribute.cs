using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyNonNull", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.NonNull" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class NonNullAttribute : AnnotationAttributeBase, NonNull
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NonNullAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public NonNullAttribute()
		: base(ClassLiteral<NonNull>.Value)
	{
	}
}
