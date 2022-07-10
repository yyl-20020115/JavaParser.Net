using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyClassVal", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.ClassVal" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class ClassValAttribute : AnnotationAttributeBase, ClassVal
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ClassValAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private ClassValAttribute()
		: base(ClassLiteral<ClassVal>.Value)
	{
	}

	[HideFromJava]
	public ClassValAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] ClassVal.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
