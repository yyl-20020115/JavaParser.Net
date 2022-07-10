using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.github.javaparser.ast;


[InnerClass("com.github.javaparser.ast.$ProxyAllFieldsConstructor", Modifiers.Final)]

[AttributeUsage(AttributeTargets.Constructor)]
public class AllFieldsConstructorAttribute : AnnotationAttributeBase, AllFieldsConstructor
{
	
	public AllFieldsConstructorAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AllFieldsConstructorAttribute()
		: base(ClassLiteral<AllFieldsConstructor>.Value)
	{
	}
}
