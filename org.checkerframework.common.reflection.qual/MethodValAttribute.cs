using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyMethodVal", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.MethodVal" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MethodValAttribute : AnnotationAttributeBase, MethodVal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MethodValAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private MethodValAttribute()
		: base(ClassLiteral<MethodVal>.Value)
	{
	}

	[HideFromJava]
	public MethodValAttribute(string[] className, string[] methodName, int[] @params)
		: this()
	{
		setValue("className", className);
		setValue("methodName", methodName);
		setValue("params", @params);
	}

	private string[] className()
	{
		return (string[])getValue("className");
	}

	string[] MethodVal.className()
	{
		//ILSpy generated this explicit interface implementation from .override directive in className
		return this.className();
	}

	private string[] methodName()
	{
		return (string[])getValue("methodName");
	}

	string[] MethodVal.methodName()
	{
		//ILSpy generated this explicit interface implementation from .override directive in methodName
		return this.methodName();
	}

	private int[] @params()
	{
		return (int[])getValue("params");
	}

	int[] MethodVal.@params()
	{
		//ILSpy generated this explicit interface implementation from .override directive in params
		return this.@params();
	}
}
