using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.returnsreceiver.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.returnsreceiver.qual.$ProxyUnknownThis", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.returnsreceiver.qual.UnknownThis" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownThisAttribute : AnnotationAttributeBase, UnknownThis
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownThisAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownThisAttribute()
		: base(ClassLiteral<UnknownThis>.Value)
	{
	}
}
