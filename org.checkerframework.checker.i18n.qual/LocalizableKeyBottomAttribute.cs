using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18n.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18n.qual.$ProxyLocalizableKeyBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18n.qual.LocalizableKeyBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LocalizableKeyBottomAttribute : AnnotationAttributeBase, LocalizableKeyBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LocalizableKeyBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LocalizableKeyBottomAttribute()
		: base(ClassLiteral<LocalizableKeyBottom>.Value)
	{
	}
}
