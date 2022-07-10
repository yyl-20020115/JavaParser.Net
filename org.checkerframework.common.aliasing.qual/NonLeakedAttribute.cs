using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.aliasing.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.aliasing.qual.$ProxyNonLeaked", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.aliasing.qual.NonLeaked" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class NonLeakedAttribute : AnnotationAttributeBase, NonLeaked
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NonLeakedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public NonLeakedAttribute()
		: base(ClassLiteral<NonLeaked>.Value)
	{
	}
}
