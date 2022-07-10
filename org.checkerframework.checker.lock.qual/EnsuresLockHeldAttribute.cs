using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyEnsuresLockHeld", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.EnsuresLockHeld" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresLockHeldAttribute : AnnotationAttributeBase, EnsuresLockHeld
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresLockHeldAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresLockHeldAttribute()
		: base(ClassLiteral<EnsuresLockHeld>.Value)
	{
	}

	[HideFromJava]
	public EnsuresLockHeldAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] EnsuresLockHeld.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
