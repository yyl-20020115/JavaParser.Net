using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyPolySameLen", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.PolySameLen" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolySameLenAttribute : AnnotationAttributeBase, PolySameLen
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolySameLenAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolySameLenAttribute()
		: base(ClassLiteral<PolySameLen>.Value)
	{
	}
}
