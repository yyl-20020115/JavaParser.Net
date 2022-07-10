using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyPolymorphicQualifier", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.PolymorphicQualifier" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class PolymorphicQualifierAttribute : AnnotationAttributeBase, PolymorphicQualifier
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolymorphicQualifierAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolymorphicQualifierAttribute()
		: base(ClassLiteral<PolymorphicQualifier>.Value)
	{
	}

	[HideFromJava]
	public PolymorphicQualifierAttribute(Type value)
		: this()
	{
		setValue("value", value);
	}

	private Class value()
	{
		return (Class)getValue("value");
	}

	Class PolymorphicQualifier.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
