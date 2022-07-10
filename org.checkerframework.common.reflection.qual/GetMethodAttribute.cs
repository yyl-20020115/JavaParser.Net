using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyGetMethod", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.GetMethod" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class GetMethodAttribute : AnnotationAttributeBase, GetMethod
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public GetMethodAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public GetMethodAttribute()
		: base(ClassLiteral<GetMethod>.Value)
	{
	}
}
