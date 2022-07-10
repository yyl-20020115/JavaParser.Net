using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyFullyQualifiedName", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.FullyQualifiedName" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FullyQualifiedNameAttribute : AnnotationAttributeBase, FullyQualifiedName
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FullyQualifiedNameAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FullyQualifiedNameAttribute()
		: base(ClassLiteral<FullyQualifiedName>.Value)
	{
	}
}
