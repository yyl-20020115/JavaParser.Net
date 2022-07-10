using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxySearchIndexUnknown", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.SearchIndexUnknown" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SearchIndexUnknownAttribute : AnnotationAttributeBase, SearchIndexUnknown
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SearchIndexUnknownAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SearchIndexUnknownAttribute()
		: base(ClassLiteral<SearchIndexUnknown>.Value)
	{
	}
}
