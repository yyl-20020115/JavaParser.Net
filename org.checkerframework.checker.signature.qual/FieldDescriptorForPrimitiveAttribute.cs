using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyFieldDescriptorForPrimitive", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.FieldDescriptorForPrimitive" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FieldDescriptorForPrimitiveAttribute : AnnotationAttributeBase, FieldDescriptorForPrimitive
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FieldDescriptorForPrimitiveAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FieldDescriptorForPrimitiveAttribute()
		: base(ClassLiteral<FieldDescriptorForPrimitive>.Value)
	{
	}
}
