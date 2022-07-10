using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyInternalForm", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.InternalForm" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class InternalFormAttribute : AnnotationAttributeBase, InternalForm
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InternalFormAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InternalFormAttribute()
		: base(ClassLiteral<InternalForm>.Value)
	{
	}
}
