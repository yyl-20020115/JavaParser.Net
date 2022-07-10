using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.guieffect.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.guieffect.qual.$ProxyUIPackage", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.guieffect.qual.UIPackage" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class UIPackageAttribute : AnnotationAttributeBase, UIPackage
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UIPackageAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UIPackageAttribute()
		: base(ClassLiteral<UIPackage>.Value)
	{
	}
}
