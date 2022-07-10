using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.builder.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.builder.qual.$ProxyNotCalledMethods", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.builder.qual.NotCalledMethods" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class NotCalledMethodsAttribute : AnnotationAttributeBase, NotCalledMethods
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NotCalledMethodsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private NotCalledMethodsAttribute()
		: base(ClassLiteral<NotCalledMethods>.Value)
	{
	}

	[HideFromJava]
	public NotCalledMethodsAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] NotCalledMethods.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
