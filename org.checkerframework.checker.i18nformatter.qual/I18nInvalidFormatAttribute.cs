using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18nformatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18nformatter.qual.$ProxyI18nInvalidFormat", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18nformatter.qual.I18nInvalidFormat" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class I18nInvalidFormatAttribute : AnnotationAttributeBase, I18nInvalidFormat
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public I18nInvalidFormatAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private I18nInvalidFormatAttribute()
		: base(ClassLiteral<I18nInvalidFormat>.Value)
	{
	}

	[HideFromJava]
	public I18nInvalidFormatAttribute(string value)
		: this()
	{
		setValue("value", value);
	}

	private string value()
	{
		return (string)getValue("value");
	}

	string I18nInvalidFormat.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
