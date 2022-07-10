using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18nformatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18nformatter.qual.$ProxyI18nFormat", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18nformatter.qual.I18nFormat" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class I18nFormatAttribute : AnnotationAttributeBase, I18nFormat
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public I18nFormatAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private I18nFormatAttribute()
		: base(ClassLiteral<I18nFormat>.Value)
	{
	}

	[HideFromJava]
	public I18nFormatAttribute(I18nConversionCategory.__Enum[] value)
		: this()
	{
		setValue("value", value);
	}

	private I18nConversionCategory[] value()
	{
		return (I18nConversionCategory[])getValue("value");
	}

	I18nConversionCategory[] I18nFormat.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
