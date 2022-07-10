using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signedness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signedness.qual.$ProxyUnsigned", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signedness.qual.Unsigned" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnsignedAttribute : AnnotationAttributeBase, Unsigned
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnsignedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnsignedAttribute()
		: base(ClassLiteral<Unsigned>.Value)
	{
	}
}
