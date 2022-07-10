using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyMonotonicQualifier", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.MonotonicQualifier" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class MonotonicQualifierAttribute : AnnotationAttributeBase, MonotonicQualifier
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MonotonicQualifierAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private MonotonicQualifierAttribute()
		: base(ClassLiteral<MonotonicQualifier>.Value)
	{
	}

	[HideFromJava]
	public MonotonicQualifierAttribute(Type value)
		: this()
	{
		setValue("value", value);
	}

	private Class value()
	{
		return (Class)getValue("value");
	}

	Class MonotonicQualifier.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
