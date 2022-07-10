using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18n.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18n.qual.$ProxyUnknownLocalized", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18n.qual.UnknownLocalized" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownLocalizedAttribute : AnnotationAttributeBase, UnknownLocalized
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownLocalizedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownLocalizedAttribute()
		: base(ClassLiteral<UnknownLocalized>.Value)
	{
	}
}
