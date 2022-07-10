using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxySubstringIndexUnknown", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.SubstringIndexUnknown" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SubstringIndexUnknownAttribute : AnnotationAttributeBase, SubstringIndexUnknown
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SubstringIndexUnknownAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SubstringIndexUnknownAttribute()
		: base(ClassLiteral<SubstringIndexUnknown>.Value)
	{
	}
}
