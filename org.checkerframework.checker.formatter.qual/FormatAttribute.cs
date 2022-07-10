using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.formatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.formatter.qual.$ProxyFormat", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.formatter.qual.Format" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FormatAttribute : AnnotationAttributeBase, Format
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FormatAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private FormatAttribute()
		: base(ClassLiteral<Format>.Value)
	{
	}

	[HideFromJava]
	public FormatAttribute(ConversionCategory.__Enum[] value)
		: this()
	{
		setValue("value", value);
	}

	private ConversionCategory[] value()
	{
		return (ConversionCategory[])getValue("value");
	}

	ConversionCategory[] Format.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
