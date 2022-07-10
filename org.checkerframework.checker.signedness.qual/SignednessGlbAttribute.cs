using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signedness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signedness.qual.$ProxySignednessGlb", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signedness.qual.SignednessGlb" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SignednessGlbAttribute : AnnotationAttributeBase, SignednessGlb
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SignednessGlbAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SignednessGlbAttribute()
		: base(ClassLiteral<SignednessGlb>.Value)
	{
	}
}
