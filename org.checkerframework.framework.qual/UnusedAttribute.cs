using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyUnused", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.Unused" })]
[AttributeUsage(AttributeTargets.Field)]
public sealed class UnusedAttribute : AnnotationAttributeBase, Unused
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnusedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private UnusedAttribute()
		: base(ClassLiteral<Unused>.Value)
	{
	}

	[HideFromJava]
	public UnusedAttribute(Type when)
		: this()
	{
		setValue("when", when);
	}

	private Class when()
	{
		return (Class)getValue("when");
	}

	Class Unused.when()
	{
		//ILSpy generated this explicit interface implementation from .override directive in when
		return this.when();
	}
}
