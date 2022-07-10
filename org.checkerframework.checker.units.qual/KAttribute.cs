using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyK", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.K" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class KAttribute : AnnotationAttributeBase, K
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public KAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public KAttribute()
		: base(ClassLiteral<K>.Value)
	{
	}

	[HideFromJava]
	public KAttribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix K.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
