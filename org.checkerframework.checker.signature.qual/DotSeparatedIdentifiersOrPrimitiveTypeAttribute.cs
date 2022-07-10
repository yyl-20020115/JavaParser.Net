using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyDotSeparatedIdentifiersOrPrimitiveType", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.DotSeparatedIdentifiersOrPrimitiveType" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class DotSeparatedIdentifiersOrPrimitiveTypeAttribute : AnnotationAttributeBase, DotSeparatedIdentifiersOrPrimitiveType
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public DotSeparatedIdentifiersOrPrimitiveTypeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public DotSeparatedIdentifiersOrPrimitiveTypeAttribute()
		: base(ClassLiteral<DotSeparatedIdentifiersOrPrimitiveType>.Value)
	{
	}
}
