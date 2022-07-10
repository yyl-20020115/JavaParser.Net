using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.propkey.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.propkey.qual.$ProxyPropertyKeyBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.propkey.qual.PropertyKeyBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PropertyKeyBottomAttribute : AnnotationAttributeBase, PropertyKeyBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PropertyKeyBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PropertyKeyBottomAttribute()
		: base(ClassLiteral<PropertyKeyBottom>.Value)
	{
	}
}
