using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.aliasing.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.aliasing.qual.$ProxyMaybeLeaked", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.aliasing.qual.MaybeLeaked" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MaybeLeakedAttribute : AnnotationAttributeBase, MaybeLeaked
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MaybeLeakedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public MaybeLeakedAttribute()
		: base(ClassLiteral<MaybeLeaked>.Value)
	{
	}
}
