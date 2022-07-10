using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.fenum.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.fenum.qual.$ProxyAwtCursorType", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.fenum.qual.AwtCursorType" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class AwtCursorTypeAttribute : AnnotationAttributeBase, AwtCursorType
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AwtCursorTypeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AwtCursorTypeAttribute()
		: base(ClassLiteral<AwtCursorType>.Value)
	{
	}
}
