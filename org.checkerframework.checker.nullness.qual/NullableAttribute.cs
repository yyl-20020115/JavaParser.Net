using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyNullable", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.Nullable" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class NullableAttribute : AnnotationAttributeBase, Nullable
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NullableAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public NullableAttribute()
		: base(ClassLiteral<Nullable>.Value)
	{
	}
}
