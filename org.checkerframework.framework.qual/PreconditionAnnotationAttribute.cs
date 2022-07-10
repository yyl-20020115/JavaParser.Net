using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyPreconditionAnnotation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.PreconditionAnnotation" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class PreconditionAnnotationAttribute : AnnotationAttributeBase, PreconditionAnnotation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PreconditionAnnotationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private PreconditionAnnotationAttribute()
		: base(ClassLiteral<PreconditionAnnotation>.Value)
	{
	}

	[HideFromJava]
	public PreconditionAnnotationAttribute(Type qualifier)
		: this()
	{
		setValue("qualifier", qualifier);
	}

	private Class qualifier()
	{
		return (Class)getValue("qualifier");
	}

	Class PreconditionAnnotation.qualifier()
	{
		//ILSpy generated this explicit interface implementation from .override directive in qualifier
		return this.qualifier();
	}
}
