using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18nformatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18nformatter.qual.$ProxyI18nFormatFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18nformatter.qual.I18nFormatFor" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class I18nFormatForAttribute : AnnotationAttributeBase, I18nFormatFor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public I18nFormatForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private I18nFormatForAttribute()
		: base(ClassLiteral<I18nFormatFor>.Value)
	{
	}

	[HideFromJava]
	public I18nFormatForAttribute(string value)
		: this()
	{
		setValue("value", value);
	}

	private string value()
	{
		return (string)getValue("value");
	}

	string I18nFormatFor.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
