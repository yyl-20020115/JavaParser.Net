using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18nformatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18nformatter.qual.$ProxyI18nChecksFormat", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18nformatter.qual.I18nChecksFormat" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class I18nChecksFormatAttribute : AnnotationAttributeBase, I18nChecksFormat
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public I18nChecksFormatAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public I18nChecksFormatAttribute()
		: base(ClassLiteral<I18nChecksFormat>.Value)
	{
	}
}
