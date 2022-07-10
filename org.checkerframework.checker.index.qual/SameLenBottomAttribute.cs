using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxySameLenBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.SameLenBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SameLenBottomAttribute : AnnotationAttributeBase, SameLenBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SameLenBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SameLenBottomAttribute()
		: base(ClassLiteral<SameLenBottom>.Value)
	{
	}
}
