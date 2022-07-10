using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxyAwtColorSpace", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.AwtColorSpace" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class AwtColorSpaceAttribute : AnnotationAttributeBase, AwtColorSpace
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AwtColorSpaceAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AwtColorSpaceAttribute()
		: base(ClassLiteral<AwtColorSpace>.Value)
	{
	}
}
