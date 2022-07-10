using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyConditionalPostconditionAnnotation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.ConditionalPostconditionAnnotation" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class ConditionalPostconditionAnnotationAttribute : AnnotationAttributeBase, ConditionalPostconditionAnnotation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ConditionalPostconditionAnnotationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private ConditionalPostconditionAnnotationAttribute()
		: base(ClassLiteral<ConditionalPostconditionAnnotation>.Value)
	{
	}

	[HideFromJava]
	public ConditionalPostconditionAnnotationAttribute(Type qualifier)
		: this()
	{
		setValue("qualifier", qualifier);
	}

	private Class qualifier()
	{
		return (Class)getValue("qualifier");
	}

	Class ConditionalPostconditionAnnotation.qualifier()
	{
		//ILSpy generated this explicit interface implementation from .override directive in qualifier
		return this.qualifier();
	}
}
