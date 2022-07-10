using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.common.html;

[InnerClass("com.google.common.html.$ProxyParametricNullness", Modifiers.Final)]
[Implements(new string[] { "com.google.common.html.ParametricNullness" })]
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
