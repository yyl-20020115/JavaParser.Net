using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.github.javaparser.metamodel;


[InnerClass("com.github.javaparser.metamodel.$ProxyNonEmptyProperty", Modifiers.Final)]

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Field)]
public class NonEmptyPropertyAttribute : AnnotationAttributeBase, NonEmptyProperty
{
	
	public NonEmptyPropertyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public NonEmptyPropertyAttribute()
		: base(ClassLiteral<NonEmptyProperty>.Value)
	{
	}
}
