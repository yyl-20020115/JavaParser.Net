using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyMethodValBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.MethodValBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MethodValBottomAttribute : AnnotationAttributeBase, MethodValBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MethodValBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public MethodValBottomAttribute()
		: base(ClassLiteral<MethodValBottom>.Value)
	{
	}
}
