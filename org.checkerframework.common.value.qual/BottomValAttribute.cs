using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyBottomVal", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.BottomVal" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class BottomValAttribute : AnnotationAttributeBase, BottomVal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public BottomValAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public BottomValAttribute()
		: base(ClassLiteral<BottomVal>.Value)
	{
	}
}
