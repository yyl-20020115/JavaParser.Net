using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyLessThan", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.LessThan" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LessThanAttribute : AnnotationAttributeBase, LessThan
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LessThanAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private LessThanAttribute()
		: base(ClassLiteral<LessThan>.Value)
	{
	}

	[HideFromJava]
	public LessThanAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] LessThan.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
