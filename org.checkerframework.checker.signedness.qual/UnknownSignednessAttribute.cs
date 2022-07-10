using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signedness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signedness.qual.$ProxyUnknownSignedness", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signedness.qual.UnknownSignedness" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownSignednessAttribute : AnnotationAttributeBase, UnknownSignedness
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownSignednessAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownSignednessAttribute()
		: base(ClassLiteral<UnknownSignedness>.Value)
	{
	}
}
