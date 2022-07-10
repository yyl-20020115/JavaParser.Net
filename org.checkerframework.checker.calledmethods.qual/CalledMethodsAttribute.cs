using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.calledmethods.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.calledmethods.qual.$ProxyCalledMethods", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.calledmethods.qual.CalledMethods" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CalledMethodsAttribute : AnnotationAttributeBase, CalledMethods
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CalledMethodsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CalledMethodsAttribute()
		: base(ClassLiteral<CalledMethods>.Value)
	{
	}

	[HideFromJava]
	public CalledMethodsAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] CalledMethods.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
