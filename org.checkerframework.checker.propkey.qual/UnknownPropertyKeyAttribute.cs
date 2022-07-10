using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.propkey.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.propkey.qual.$ProxyUnknownPropertyKey", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.propkey.qual.UnknownPropertyKey" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownPropertyKeyAttribute : AnnotationAttributeBase, UnknownPropertyKey
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownPropertyKeyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownPropertyKeyAttribute()
		: base(ClassLiteral<UnknownPropertyKey>.Value)
	{
	}
}
