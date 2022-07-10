using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.dataflow.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.dataflow.qual.$ProxyDeterministic", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.dataflow.qual.Deterministic" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class DeterministicAttribute : AnnotationAttributeBase, Deterministic
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public DeterministicAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public DeterministicAttribute()
		: base(ClassLiteral<Deterministic>.Value)
	{
	}
}
