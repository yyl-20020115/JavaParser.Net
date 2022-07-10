using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.guieffect.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.guieffect.qual.$ProxyPolyUIEffect", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.guieffect.qual.PolyUIEffect" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field)]
public sealed class PolyUIEffectAttribute : AnnotationAttributeBase, PolyUIEffect
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyUIEffectAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyUIEffectAttribute()
		: base(ClassLiteral<PolyUIEffect>.Value)
	{
	}
}
