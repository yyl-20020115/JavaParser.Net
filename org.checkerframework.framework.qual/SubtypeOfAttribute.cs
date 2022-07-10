using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxySubtypeOf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.SubtypeOf" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class SubtypeOfAttribute : AnnotationAttributeBase, SubtypeOf
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SubtypeOfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private SubtypeOfAttribute()
		: base(ClassLiteral<SubtypeOf>.Value)
	{
	}

	[HideFromJava]
	public SubtypeOfAttribute(Type[] value)
		: this()
	{
		setValue("value", value);
	}

	private Class[] value()
	{
		return (Class[])getValue("value");
	}

	Class[] SubtypeOf.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
