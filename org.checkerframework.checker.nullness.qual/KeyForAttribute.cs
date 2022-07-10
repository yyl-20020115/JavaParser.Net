using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyKeyFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.KeyFor" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class KeyForAttribute : AnnotationAttributeBase, KeyFor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public KeyForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private KeyForAttribute()
		: base(ClassLiteral<KeyFor>.Value)
	{
	}

	[HideFromJava]
	public KeyForAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] KeyFor.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
