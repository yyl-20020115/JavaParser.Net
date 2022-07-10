using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18n.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18n.qual.$ProxyLocalizableKey", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18n.qual.LocalizableKey" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LocalizableKeyAttribute : AnnotationAttributeBase, LocalizableKey
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LocalizableKeyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LocalizableKeyAttribute()
		: base(ClassLiteral<LocalizableKey>.Value)
	{
	}
}
