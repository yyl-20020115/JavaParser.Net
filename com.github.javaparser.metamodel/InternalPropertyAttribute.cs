using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.github.javaparser.metamodel;


[InnerClass("com.github.javaparser.metamodel.$ProxyInternalProperty", Modifiers.Final)]

[AttributeUsage(AttributeTargets.Field)]
public class InternalPropertyAttribute : AnnotationAttributeBase, InternalProperty
{
	
	public InternalPropertyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InternalPropertyAttribute()
		: base(ClassLiteral<InternalProperty>.Value)
	{
	}
}
