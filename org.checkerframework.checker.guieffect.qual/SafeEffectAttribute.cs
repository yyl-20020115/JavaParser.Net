using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.guieffect.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.guieffect.qual.$ProxySafeEffect", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.guieffect.qual.SafeEffect" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field)]
public sealed class SafeEffectAttribute : AnnotationAttributeBase, SafeEffect
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SafeEffectAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SafeEffectAttribute()
		: base(ClassLiteral<SafeEffect>.Value)
	{
	}
}
