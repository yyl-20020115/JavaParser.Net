using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyMethodDescriptor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.MethodDescriptor" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MethodDescriptorAttribute : AnnotationAttributeBase, MethodDescriptor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MethodDescriptorAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public MethodDescriptorAttribute()
		: base(ClassLiteral<MethodDescriptor>.Value)
	{
	}
}
