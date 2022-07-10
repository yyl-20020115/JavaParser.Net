using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.interning.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.interning.qual.$ProxyInternMethod", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.interning.qual.InternMethod" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class InternMethodAttribute : AnnotationAttributeBase, InternMethod
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InternMethodAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InternMethodAttribute()
		: base(ClassLiteral<InternMethod>.Value)
	{
	}
}
