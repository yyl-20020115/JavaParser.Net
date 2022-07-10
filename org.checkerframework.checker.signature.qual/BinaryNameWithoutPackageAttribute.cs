using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyBinaryNameWithoutPackage", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.BinaryNameWithoutPackage" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class BinaryNameWithoutPackageAttribute : AnnotationAttributeBase, BinaryNameWithoutPackage
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public BinaryNameWithoutPackageAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public BinaryNameWithoutPackageAttribute()
		: base(ClassLiteral<BinaryNameWithoutPackage>.Value)
	{
	}
}
