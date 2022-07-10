using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.checker.initialization.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.initialization.qual.$ProxyUnknownInitialization", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.initialization.qual.UnknownInitialization" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownInitializationAttribute : AnnotationAttributeBase, UnknownInitialization
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownInitializationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownInitializationAttribute()
		: base(ClassLiteral<UnknownInitialization>.Value)
	{
	}

	[HideFromJava]
	public UnknownInitializationAttribute(Type value)
		: this()
	{
		setValue("value", value);
	}

	private Class value()
	{
		return (Class)getValue("value");
	}

	Class UnknownInitialization.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
