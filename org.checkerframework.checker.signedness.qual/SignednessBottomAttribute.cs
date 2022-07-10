using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signedness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signedness.qual.$ProxySignednessBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signedness.qual.SignednessBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SignednessBottomAttribute : AnnotationAttributeBase, SignednessBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SignednessBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SignednessBottomAttribute()
		: base(ClassLiteral<SignednessBottom>.Value)
	{
	}
}
