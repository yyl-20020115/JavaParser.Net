using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyNewInstance", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.NewInstance" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class NewInstanceAttribute : AnnotationAttributeBase, NewInstance
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NewInstanceAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public NewInstanceAttribute()
		: base(ClassLiteral<NewInstance>.Value)
	{
	}
}
