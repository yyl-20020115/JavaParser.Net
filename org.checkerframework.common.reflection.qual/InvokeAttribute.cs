using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyInvoke", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.Invoke" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class InvokeAttribute : AnnotationAttributeBase, Invoke
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InvokeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InvokeAttribute()
		: base(ClassLiteral<Invoke>.Value)
	{
	}
}
