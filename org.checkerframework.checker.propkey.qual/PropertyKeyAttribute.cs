using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.propkey.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.propkey.qual.$ProxyPropertyKey", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.propkey.qual.PropertyKey" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PropertyKeyAttribute : AnnotationAttributeBase, PropertyKey
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PropertyKeyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PropertyKeyAttribute()
		: base(ClassLiteral<PropertyKey>.Value)
	{
	}
}
