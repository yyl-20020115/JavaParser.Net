using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.initializedfields.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.initializedfields.qual.$ProxyInitializedFields", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.initializedfields.qual.InitializedFields" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class InitializedFieldsAttribute : AnnotationAttributeBase, InitializedFields
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InitializedFieldsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InitializedFieldsAttribute()
		: base(ClassLiteral<InitializedFields>.Value)
	{
	}

	[HideFromJava]
	public InitializedFieldsAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] InitializedFields.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
