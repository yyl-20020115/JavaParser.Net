using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.guieffect.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.guieffect.qual.$ProxyUIType", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.guieffect.qual.UIType" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class UITypeAttribute : AnnotationAttributeBase, UIType
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UITypeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UITypeAttribute()
		: base(ClassLiteral<UIType>.Value)
	{
	}
}
