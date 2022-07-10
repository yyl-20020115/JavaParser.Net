using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyGuardSatisfied", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.GuardSatisfied" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class GuardSatisfiedAttribute : AnnotationAttributeBase, GuardSatisfied
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public GuardSatisfiedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public GuardSatisfiedAttribute()
		: base(ClassLiteral<GuardSatisfied>.Value)
	{
	}

	[HideFromJava]
	public GuardSatisfiedAttribute(int value)
		: this()
	{
		setValue("value", value);
	}

	private int value()
	{
		return getIntValue("value");
	}

	int GuardSatisfied.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
