using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyNoDefaultQualifierForUse", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.NoDefaultQualifierForUse" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class NoDefaultQualifierForUseAttribute : AnnotationAttributeBase, NoDefaultQualifierForUse
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NoDefaultQualifierForUseAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public NoDefaultQualifierForUseAttribute()
		: base(ClassLiteral<NoDefaultQualifierForUse>.Value)
	{
	}

	[HideFromJava]
	public NoDefaultQualifierForUseAttribute(Type[] value)
		: this()
	{
		setValue("value", value);
	}

	private Class[] value()
	{
		return (Class[])getValue("value");
	}

	Class[] NoDefaultQualifierForUse.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
