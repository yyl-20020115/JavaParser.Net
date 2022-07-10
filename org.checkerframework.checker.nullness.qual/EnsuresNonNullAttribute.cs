using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyEnsuresNonNull", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.EnsuresNonNull" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresNonNullAttribute : AnnotationAttributeBase, EnsuresNonNull
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresNonNullAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresNonNullAttribute()
		: base(ClassLiteral<EnsuresNonNull>.Value)
	{
	}

	[HideFromJava]
	public EnsuresNonNullAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] EnsuresNonNull.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
