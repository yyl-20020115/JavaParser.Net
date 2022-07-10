using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyForName", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.ForName" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class ForNameAttribute : AnnotationAttributeBase, ForName
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ForNameAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ForNameAttribute()
		: base(ClassLiteral<ForName>.Value)
	{
	}
}
