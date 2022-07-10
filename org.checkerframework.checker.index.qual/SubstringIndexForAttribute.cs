using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxySubstringIndexFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.SubstringIndexFor" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SubstringIndexForAttribute : AnnotationAttributeBase, SubstringIndexFor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SubstringIndexForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private SubstringIndexForAttribute()
		: base(ClassLiteral<SubstringIndexFor>.Value)
	{
	}

	[HideFromJava]
	public SubstringIndexForAttribute(string[] value, string[] offset)
		: this()
	{
		setValue("value", value);
		setValue("offset", offset);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] SubstringIndexFor.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}

	private string[] offset()
	{
		return (string[])getValue("offset");
	}

	string[] SubstringIndexFor.offset()
	{
		//ILSpy generated this explicit interface implementation from .override directive in offset
		return this.offset();
	}
}
