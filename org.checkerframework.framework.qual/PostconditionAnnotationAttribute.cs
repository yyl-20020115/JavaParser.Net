using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyPostconditionAnnotation", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.PostconditionAnnotation" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class PostconditionAnnotationAttribute : AnnotationAttributeBase, PostconditionAnnotation
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PostconditionAnnotationAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private PostconditionAnnotationAttribute()
		: base(ClassLiteral<PostconditionAnnotation>.Value)
	{
	}

	[HideFromJava]
	public PostconditionAnnotationAttribute(Type qualifier)
		: this()
	{
		setValue("qualifier", qualifier);
	}

	private Class qualifier()
	{
		return (Class)getValue("qualifier");
	}

	Class PostconditionAnnotation.qualifier()
	{
		//ILSpy generated this explicit interface implementation from .override directive in qualifier
		return this.qualifier();
	}
}
