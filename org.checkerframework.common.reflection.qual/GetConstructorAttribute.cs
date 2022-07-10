using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyGetConstructor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.GetConstructor" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class GetConstructorAttribute : AnnotationAttributeBase, GetConstructor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public GetConstructorAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public GetConstructorAttribute()
		: base(ClassLiteral<GetConstructor>.Value)
	{
	}
}
