using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18nformatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18nformatter.qual.$ProxyI18nValidFormat", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18nformatter.qual.I18nValidFormat" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class I18nValidFormatAttribute : AnnotationAttributeBase, I18nValidFormat
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public I18nValidFormatAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public I18nValidFormatAttribute()
		: base(ClassLiteral<I18nValidFormat>.Value)
	{
	}
}
