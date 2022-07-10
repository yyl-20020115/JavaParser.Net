using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyIndexOrLow", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.IndexOrLow" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class IndexOrLowAttribute : AnnotationAttributeBase, IndexOrLow
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public IndexOrLowAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private IndexOrLowAttribute()
		: base(ClassLiteral<IndexOrLow>.Value)
	{
	}

	[HideFromJava]
	public IndexOrLowAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] IndexOrLow.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
