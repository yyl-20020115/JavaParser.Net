using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyArrayWithoutPackage", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.ArrayWithoutPackage" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class ArrayWithoutPackageAttribute : AnnotationAttributeBase, ArrayWithoutPackage
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ArrayWithoutPackageAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ArrayWithoutPackageAttribute()
		: base(ClassLiteral<ArrayWithoutPackage>.Value)
	{
	}
}
