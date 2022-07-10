using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxySubstringIndexBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.SubstringIndexBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SubstringIndexBottomAttribute : AnnotationAttributeBase, SubstringIndexBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SubstringIndexBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SubstringIndexBottomAttribute()
		: base(ClassLiteral<SubstringIndexBottom>.Value)
	{
	}
}
