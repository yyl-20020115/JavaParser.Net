using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyGuardedBy", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.GuardedBy" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class GuardedByAttribute : AnnotationAttributeBase, GuardedBy
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public GuardedByAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public GuardedByAttribute()
		: base(ClassLiteral<GuardedBy>.Value)
	{
	}

	[HideFromJava]
	public GuardedByAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] GuardedBy.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
