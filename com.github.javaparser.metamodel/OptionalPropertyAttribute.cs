using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.github.javaparser.metamodel;


[InnerClass("com.github.javaparser.metamodel.$ProxyOptionalProperty", Modifiers.Final)]

[AttributeUsage(AttributeTargets.Field)]
public class OptionalPropertyAttribute : AnnotationAttributeBase, OptionalProperty
{
	
	public OptionalPropertyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public OptionalPropertyAttribute()
		: base(ClassLiteral<OptionalProperty>.Value)
	{
	}
}
