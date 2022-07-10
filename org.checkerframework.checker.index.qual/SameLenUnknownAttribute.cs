using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxySameLenUnknown", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.SameLenUnknown" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class SameLenUnknownAttribute : AnnotationAttributeBase, SameLenUnknown
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SameLenUnknownAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SameLenUnknownAttribute()
		: base(ClassLiteral<SameLenUnknown>.Value)
	{
	}
}
