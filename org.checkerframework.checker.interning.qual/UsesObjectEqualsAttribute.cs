using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.interning.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.interning.qual.$ProxyUsesObjectEquals", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.interning.qual.UsesObjectEquals" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class UsesObjectEqualsAttribute : AnnotationAttributeBase, UsesObjectEquals
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UsesObjectEqualsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UsesObjectEqualsAttribute()
		: base(ClassLiteral<UsesObjectEquals>.Value)
	{
	}
}
