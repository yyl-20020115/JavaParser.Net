using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyRequiresNonNull", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.RequiresNonNull" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class RequiresNonNullAttribute : AnnotationAttributeBase, RequiresNonNull
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public RequiresNonNullAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private RequiresNonNullAttribute()
		: base(ClassLiteral<RequiresNonNull>.Value)
	{
	}

	[HideFromJava]
	public RequiresNonNullAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] RequiresNonNull.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
