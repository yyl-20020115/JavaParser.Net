using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyDefaultQualifierForUse", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.DefaultQualifierForUse" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class DefaultQualifierForUseAttribute : AnnotationAttributeBase, DefaultQualifierForUse
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public DefaultQualifierForUseAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public DefaultQualifierForUseAttribute()
		: base(ClassLiteral<DefaultQualifierForUse>.Value)
	{
	}

	[HideFromJava]
	public DefaultQualifierForUseAttribute(Type[] value)
		: this()
	{
		setValue("value", value);
	}

	private Class[] value()
	{
		return (Class[])getValue("value");
	}

	Class[] DefaultQualifierForUse.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
