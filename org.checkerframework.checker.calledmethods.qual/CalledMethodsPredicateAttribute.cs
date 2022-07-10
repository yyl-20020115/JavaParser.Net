using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.calledmethods.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.calledmethods.qual.$ProxyCalledMethodsPredicate", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.calledmethods.qual.CalledMethodsPredicate" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CalledMethodsPredicateAttribute : AnnotationAttributeBase, CalledMethodsPredicate
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CalledMethodsPredicateAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private CalledMethodsPredicateAttribute()
		: base(ClassLiteral<CalledMethodsPredicate>.Value)
	{
	}

	[HideFromJava]
	public CalledMethodsPredicateAttribute(string value)
		: this()
	{
		setValue("value", value);
	}

	private string value()
	{
		return (string)getValue("value");
	}

	string CalledMethodsPredicate.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
