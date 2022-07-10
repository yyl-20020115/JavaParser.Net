using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyRelevantJavaTypes", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.RelevantJavaTypes" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class RelevantJavaTypesAttribute : AnnotationAttributeBase, RelevantJavaTypes
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public RelevantJavaTypesAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private RelevantJavaTypesAttribute()
		: base(ClassLiteral<RelevantJavaTypes>.Value)
	{
	}

	[HideFromJava]
	public RelevantJavaTypesAttribute(Type[] value)
		: this()
	{
		setValue("value", value);
	}

	private Class[] value()
	{
		return (Class[])getValue("value");
	}

	Class[] RelevantJavaTypes.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
