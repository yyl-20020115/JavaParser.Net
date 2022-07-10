using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18nformatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18nformatter.qual.$ProxyI18nFormatBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18nformatter.qual.I18nFormatBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class I18nFormatBottomAttribute : AnnotationAttributeBase, I18nFormatBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public I18nFormatBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public I18nFormatBottomAttribute()
		: base(ClassLiteral<I18nFormatBottom>.Value)
	{
	}
}
