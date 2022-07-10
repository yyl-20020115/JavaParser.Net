using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18nformatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18nformatter.qual.$ProxyI18nMakeFormat", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18nformatter.qual.I18nMakeFormat" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class I18nMakeFormatAttribute : AnnotationAttributeBase, I18nMakeFormat
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public I18nMakeFormatAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public I18nMakeFormatAttribute()
		: base(ClassLiteral<I18nMakeFormat>.Value)
	{
	}
}
