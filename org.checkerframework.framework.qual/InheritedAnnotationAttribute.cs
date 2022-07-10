using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyInheritedAnnotation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.InheritedAnnotation" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class InheritedAnnotationAttribute : AnnotationAttributeBase, InheritedAnnotation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InheritedAnnotationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InheritedAnnotationAttribute()
		: base(ClassLiteral<InheritedAnnotation>.Value)
	{
	}
}
