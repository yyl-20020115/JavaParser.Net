using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyClassBound", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.ClassBound" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class ClassBoundAttribute : AnnotationAttributeBase, ClassBound
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ClassBoundAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private ClassBoundAttribute()
		: base(ClassLiteral<ClassBound>.Value)
	{
	}

	[HideFromJava]
	public ClassBoundAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] ClassBound.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
