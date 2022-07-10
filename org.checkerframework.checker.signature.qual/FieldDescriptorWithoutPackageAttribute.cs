using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyFieldDescriptorWithoutPackage", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.FieldDescriptorWithoutPackage" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FieldDescriptorWithoutPackageAttribute : AnnotationAttributeBase, FieldDescriptorWithoutPackage
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FieldDescriptorWithoutPackageAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FieldDescriptorWithoutPackageAttribute()
		: base(ClassLiteral<FieldDescriptorWithoutPackage>.Value)
	{
	}
}
