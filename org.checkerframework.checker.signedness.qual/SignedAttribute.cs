using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signedness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signedness.qual.$ProxySigned", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signedness.qual.Signed" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SignedAttribute : AnnotationAttributeBase, Signed
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SignedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SignedAttribute()
		: base(ClassLiteral<Signed>.Value)
	{
	}
}
