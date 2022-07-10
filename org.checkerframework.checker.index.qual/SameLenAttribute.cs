using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxySameLen", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.SameLen" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SameLenAttribute : AnnotationAttributeBase, SameLen
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SameLenAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private SameLenAttribute()
		: base(ClassLiteral<SameLen>.Value)
	{
	}

	[HideFromJava]
	public SameLenAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] SameLen.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
