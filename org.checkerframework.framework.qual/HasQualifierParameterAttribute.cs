using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyHasQualifierParameter", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.HasQualifierParameter" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class HasQualifierParameterAttribute : AnnotationAttributeBase, HasQualifierParameter
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public HasQualifierParameterAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private HasQualifierParameterAttribute()
		: base(ClassLiteral<HasQualifierParameter>.Value)
	{
	}

	[HideFromJava]
	public HasQualifierParameterAttribute(Type[] value)
		: this()
	{
		setValue("value", value);
	}

	private Class[] value()
	{
		return (Class[])getValue("value");
	}

	Class[] HasQualifierParameter.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
