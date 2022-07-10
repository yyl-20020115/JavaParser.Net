using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxySearchIndexBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.SearchIndexBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SearchIndexBottomAttribute : AnnotationAttributeBase, SearchIndexBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SearchIndexBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SearchIndexBottomAttribute()
		: base(ClassLiteral<SearchIndexBottom>.Value)
	{
	}
}
