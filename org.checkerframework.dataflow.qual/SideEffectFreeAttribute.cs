using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.dataflow.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.dataflow.qual.$ProxySideEffectFree", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.dataflow.qual.SideEffectFree" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class SideEffectFreeAttribute : AnnotationAttributeBase, SideEffectFree
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SideEffectFreeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SideEffectFreeAttribute()
		: base(ClassLiteral<SideEffectFree>.Value)
	{
	}
}
