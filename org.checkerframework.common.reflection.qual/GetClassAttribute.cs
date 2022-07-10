using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyGetClass", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.GetClass" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class GetClassAttribute : AnnotationAttributeBase, GetClass
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public GetClassAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public GetClassAttribute()
		: base(ClassLiteral<GetClass>.Value)
	{
	}
}
