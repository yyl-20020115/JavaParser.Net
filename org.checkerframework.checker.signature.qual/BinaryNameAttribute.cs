using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyBinaryName", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.BinaryName" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class BinaryNameAttribute : AnnotationAttributeBase, BinaryName
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public BinaryNameAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public BinaryNameAttribute()
		: base(ClassLiteral<BinaryName>.Value)
	{
	}
}
