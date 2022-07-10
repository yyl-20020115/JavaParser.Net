using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxymPERs2", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.mPERs2" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class mPERs2Attribute : AnnotationAttributeBase, mPERs2
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public mPERs2Attribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public mPERs2Attribute()
		: base(ClassLiteral<mPERs2>.Value)
	{
	}

	[HideFromJava]
	public mPERs2Attribute(Prefix.__Enum value)
		: this()
	{
		setValue("value", value);
	}

	private Prefix value()
	{
		return (Prefix)getValue("value");
	}

	Prefix mPERs2.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
