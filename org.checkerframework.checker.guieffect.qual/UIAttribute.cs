using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.guieffect.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.guieffect.qual.$ProxyUI", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.guieffect.qual.UI" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UIAttribute : AnnotationAttributeBase, UI
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UIAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UIAttribute()
		: base(ClassLiteral<UI>.Value)
	{
	}
}
