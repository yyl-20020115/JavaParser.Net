using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxymPERs", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.mPERs" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class mPERsAttribute : AnnotationAttributeBase, mPERs
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public mPERsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public mPERsAttribute()
		: base(ClassLiteral<mPERs>.Value)
	{
	}

	[HideFromJava]
	public mPERsAttribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix mPERs.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
