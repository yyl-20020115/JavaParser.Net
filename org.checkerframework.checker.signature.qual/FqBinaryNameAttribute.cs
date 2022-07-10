using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyFqBinaryName", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.FqBinaryName" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FqBinaryNameAttribute : AnnotationAttributeBase, FqBinaryName
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FqBinaryNameAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FqBinaryNameAttribute()
		: base(ClassLiteral<FqBinaryName>.Value)
	{
	}
}
