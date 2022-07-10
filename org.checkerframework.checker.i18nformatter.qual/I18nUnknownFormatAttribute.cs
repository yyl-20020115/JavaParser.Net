using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18nformatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18nformatter.qual.$ProxyI18nUnknownFormat", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18nformatter.qual.I18nUnknownFormat" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class I18nUnknownFormatAttribute : AnnotationAttributeBase, I18nUnknownFormat
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public I18nUnknownFormatAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public I18nUnknownFormatAttribute()
		: base(ClassLiteral<I18nUnknownFormat>.Value)
	{
	}
}
