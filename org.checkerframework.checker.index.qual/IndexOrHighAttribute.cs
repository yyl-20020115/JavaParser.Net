using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyIndexOrHigh", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.IndexOrHigh" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class IndexOrHighAttribute : AnnotationAttributeBase, IndexOrHigh
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public IndexOrHighAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private IndexOrHighAttribute()
		: base(ClassLiteral<IndexOrHigh>.Value)
	{
	}

	[HideFromJava]
	public IndexOrHighAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] IndexOrHigh.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
