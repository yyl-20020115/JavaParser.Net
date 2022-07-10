using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.builder.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.builder.qual.$ProxyReturnsReceiver", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.builder.qual.ReturnsReceiver" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class ReturnsReceiverAttribute : AnnotationAttributeBase, ReturnsReceiver
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ReturnsReceiverAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ReturnsReceiverAttribute()
		: base(ClassLiteral<ReturnsReceiver>.Value)
	{
	}
}
