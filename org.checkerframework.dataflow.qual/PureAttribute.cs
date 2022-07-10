using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.dataflow.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.dataflow.qual.$ProxyPure", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.dataflow.qual.Pure" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class PureAttribute : AnnotationAttributeBase, Pure
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PureAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PureAttribute()
		: base(ClassLiteral<Pure>.Value)
	{
	}
}
