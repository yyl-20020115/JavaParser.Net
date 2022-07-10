using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxySearchIndexFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.SearchIndexFor" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SearchIndexForAttribute : AnnotationAttributeBase, SearchIndexFor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SearchIndexForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private SearchIndexForAttribute()
		: base(ClassLiteral<SearchIndexFor>.Value)
	{
	}

	[HideFromJava]
	public SearchIndexForAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] SearchIndexFor.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
