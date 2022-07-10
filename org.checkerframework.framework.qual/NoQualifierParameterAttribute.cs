using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyNoQualifierParameter", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.NoQualifierParameter" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class NoQualifierParameterAttribute : AnnotationAttributeBase, NoQualifierParameter
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NoQualifierParameterAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private NoQualifierParameterAttribute()
		: base(ClassLiteral<NoQualifierParameter>.Value)
	{
	}

	[HideFromJava]
	public NoQualifierParameterAttribute(Type[] value)
		: this()
	{
		setValue("value", value);
	}

	private Class[] value()
	{
		return (Class[])getValue("value");
	}

	Class[] NoQualifierParameter.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
