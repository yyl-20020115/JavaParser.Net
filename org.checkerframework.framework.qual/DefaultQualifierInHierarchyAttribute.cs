using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyDefaultQualifierInHierarchy", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.DefaultQualifierInHierarchy" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class DefaultQualifierInHierarchyAttribute : AnnotationAttributeBase, DefaultQualifierInHierarchy
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public DefaultQualifierInHierarchyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public DefaultQualifierInHierarchyAttribute()
		: base(ClassLiteral<DefaultQualifierInHierarchy>.Value)
	{
	}
}
