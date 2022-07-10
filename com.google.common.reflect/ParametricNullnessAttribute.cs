using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.common.reflect;

[InnerClass("com.google.common.reflect.$ProxyParametricNullness", Modifiers.Final)]
[Implements(new string[] { "com.google.common.reflect.ParametricNullness" })]
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Parameter)]
internal sealed class ParametricNullnessAttribute : AnnotationAttributeBase, ParametricNullness
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ParametricNullnessAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ParametricNullnessAttribute()
		: base(ClassLiteral<ParametricNullness>.Value)
	{
	}
}
