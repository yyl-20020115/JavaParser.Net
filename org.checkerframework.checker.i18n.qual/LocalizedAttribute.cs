using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18n.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18n.qual.$ProxyLocalized", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18n.qual.Localized" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LocalizedAttribute : AnnotationAttributeBase, Localized
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LocalizedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LocalizedAttribute()
		: base(ClassLiteral<Localized>.Value)
	{
	}
}
