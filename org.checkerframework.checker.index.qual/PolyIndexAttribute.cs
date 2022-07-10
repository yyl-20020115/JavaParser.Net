using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyPolyIndex", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.PolyIndex" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyIndexAttribute : AnnotationAttributeBase, PolyIndex
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyIndexAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyIndexAttribute()
		: base(ClassLiteral<PolyIndex>.Value)
	{
	}
}
