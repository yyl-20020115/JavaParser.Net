using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.returnsreceiver.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.returnsreceiver.qual.$ProxyBottomThis", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.returnsreceiver.qual.BottomThis" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class BottomThisAttribute : AnnotationAttributeBase, BottomThis
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public BottomThisAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public BottomThisAttribute()
		: base(ClassLiteral<BottomThis>.Value)
	{
	}
}
