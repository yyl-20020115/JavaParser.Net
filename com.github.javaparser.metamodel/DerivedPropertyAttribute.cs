using System;
using System.ComponentModel;

using ikvm.@internal;

namespace com.github.javaparser.metamodel;


[InnerClass("com.github.javaparser.metamodel.$ProxyDerivedProperty", Modifiers.Final)]

[AttributeUsage(AttributeTargets.Method)]
public class DerivedPropertyAttribute : AnnotationAttributeBase, DerivedProperty
{
	
	public DerivedPropertyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public DerivedPropertyAttribute()
		: base(ClassLiteral<DerivedProperty>.Value)
	{
	}
}
