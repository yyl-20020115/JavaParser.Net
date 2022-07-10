using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxyradians", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.radians" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class radiansAttribute : AnnotationAttributeBase, radians
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public radiansAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public radiansAttribute()
		: base(ClassLiteral<radians>.Value)
	{
	}

	[HideFromJava]
	public radiansAttribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix radians.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
