using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.dataflow.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.dataflow.qual.$ProxyTerminatesExecution", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.dataflow.qual.TerminatesExecution" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class TerminatesExecutionAttribute : AnnotationAttributeBase, TerminatesExecution
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public TerminatesExecutionAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public TerminatesExecutionAttribute()
		: base(ClassLiteral<TerminatesExecution>.Value)
	{
	}
}
