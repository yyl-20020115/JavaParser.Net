using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyStaticallyExecutable", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.StaticallyExecutable" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class StaticallyExecutableAttribute : AnnotationAttributeBase, StaticallyExecutable
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public StaticallyExecutableAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public StaticallyExecutableAttribute()
		: base(ClassLiteral<StaticallyExecutable>.Value)
	{
	}
}
