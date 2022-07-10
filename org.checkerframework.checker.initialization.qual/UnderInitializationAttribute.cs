using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.checker.initialization.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.initialization.qual.$ProxyUnderInitialization", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.initialization.qual.UnderInitialization" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnderInitializationAttribute : AnnotationAttributeBase, UnderInitialization
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnderInitializationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnderInitializationAttribute()
		: base(ClassLiteral<UnderInitialization>.Value)
	{
	}

	[HideFromJava]
	public UnderInitializationAttribute(Type value)
		: this()
	{
		setValue("value", value);
	}

	private Class value()
	{
		return (Class)getValue("value");
	}

	Class UnderInitialization.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
