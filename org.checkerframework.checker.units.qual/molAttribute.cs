using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxymol", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.mol" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class molAttribute : AnnotationAttributeBase, mol
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public molAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public molAttribute()
		: base(ClassLiteral<mol>.Value)
	{
	}

	[HideFromJava]
	public molAttribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix mol.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
