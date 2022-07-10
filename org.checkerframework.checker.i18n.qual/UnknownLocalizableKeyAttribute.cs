using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.i18n.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.i18n.qual.$ProxyUnknownLocalizableKey", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.i18n.qual.UnknownLocalizableKey" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownLocalizableKeyAttribute : AnnotationAttributeBase, UnknownLocalizableKey
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownLocalizableKeyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownLocalizableKeyAttribute()
		: base(ClassLiteral<UnknownLocalizableKey>.Value)
	{
	}
}
