using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.guieffect.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.guieffect.qual.$ProxyUIEffect", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.guieffect.qual.UIEffect" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field)]
public sealed class UIEffectAttribute : AnnotationAttributeBase, UIEffect
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UIEffectAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UIEffectAttribute()
		: base(ClassLiteral<UIEffect>.Value)
	{
	}
}
