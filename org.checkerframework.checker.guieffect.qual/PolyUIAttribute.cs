using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.guieffect.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.guieffect.qual.$ProxyPolyUI", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.guieffect.qual.PolyUI" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyUIAttribute : AnnotationAttributeBase, PolyUI
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyUIAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyUIAttribute()
		: base(ClassLiteral<PolyUI>.Value)
	{
	}
}
