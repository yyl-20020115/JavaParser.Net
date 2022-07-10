using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyIndexFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.IndexFor" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class IndexForAttribute : AnnotationAttributeBase, IndexFor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public IndexForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private IndexForAttribute()
		: base(ClassLiteral<IndexFor>.Value)
	{
	}

	[HideFromJava]
	public IndexForAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] IndexFor.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
