using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyTargetLocations", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.TargetLocations" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class TargetLocationsAttribute : AnnotationAttributeBase, TargetLocations
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public TargetLocationsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private TargetLocationsAttribute()
		: base(ClassLiteral<TargetLocations>.Value)
	{
	}

	[HideFromJava]
	public TargetLocationsAttribute(TypeUseLocation.__Enum[] value)
		: this()
	{
		setValue("value", value);
	}

	private TypeUseLocation[] value()
	{
		return (TypeUseLocation[])getValue("value");
	}

	TypeUseLocation[] TargetLocations.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
