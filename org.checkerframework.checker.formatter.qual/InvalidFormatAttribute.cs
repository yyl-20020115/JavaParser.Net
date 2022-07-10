using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.formatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.formatter.qual.$ProxyInvalidFormat", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.formatter.qual.InvalidFormat" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class InvalidFormatAttribute : AnnotationAttributeBase, InvalidFormat
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InvalidFormatAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private InvalidFormatAttribute()
		: base(ClassLiteral<InvalidFormat>.Value)
	{
	}

	[HideFromJava]
	public InvalidFormatAttribute(string value)
		: this()
	{
		setValue("value", value);
	}

	private string value()
	{
		return (string)getValue("value");
	}

	string InvalidFormat.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
