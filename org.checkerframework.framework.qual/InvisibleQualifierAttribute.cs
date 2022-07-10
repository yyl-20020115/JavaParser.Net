using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyInvisibleQualifier", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.InvisibleQualifier" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class InvisibleQualifierAttribute : AnnotationAttributeBase, InvisibleQualifier
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InvisibleQualifierAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InvisibleQualifierAttribute()
		: base(ClassLiteral<InvisibleQualifier>.Value)
	{
	}
}
