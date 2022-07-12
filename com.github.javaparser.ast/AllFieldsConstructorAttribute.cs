using System;
using System.ComponentModel;

using ikvm.@internal;

namespace com.github.javaparser.ast;

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
