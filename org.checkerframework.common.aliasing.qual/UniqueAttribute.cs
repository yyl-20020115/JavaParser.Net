using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.aliasing.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.aliasing.qual.$ProxyUnique", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.aliasing.qual.Unique" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UniqueAttribute : AnnotationAttributeBase, Unique
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UniqueAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UniqueAttribute()
		: base(ClassLiteral<Unique>.Value)
	{
	}
}
