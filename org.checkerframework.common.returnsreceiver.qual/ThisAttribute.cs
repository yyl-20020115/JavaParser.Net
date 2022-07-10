using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.returnsreceiver.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.returnsreceiver.qual.$ProxyThis", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.returnsreceiver.qual.This" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class ThisAttribute : AnnotationAttributeBase, This
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ThisAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ThisAttribute()
		: base(ClassLiteral<This>.Value)
	{
	}
}
