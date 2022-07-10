using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyFieldDescriptor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.FieldDescriptor" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FieldDescriptorAttribute : AnnotationAttributeBase, FieldDescriptor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FieldDescriptorAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FieldDescriptorAttribute()
		: base(ClassLiteral<FieldDescriptor>.Value)
	{
	}
}
