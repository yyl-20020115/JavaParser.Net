using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyIgnoreInWholeProgramInference", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.IgnoreInWholeProgramInference" })]
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Interface)]
public sealed class IgnoreInWholeProgramInferenceAttribute : AnnotationAttributeBase, IgnoreInWholeProgramInference
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public IgnoreInWholeProgramInferenceAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public IgnoreInWholeProgramInferenceAttribute()
		: base(ClassLiteral<IgnoreInWholeProgramInference>.Value)
	{
	}
}
