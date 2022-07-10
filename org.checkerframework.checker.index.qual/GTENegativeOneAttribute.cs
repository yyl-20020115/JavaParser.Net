using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyGTENegativeOne", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.GTENegativeOne" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class GTENegativeOneAttribute : AnnotationAttributeBase, GTENegativeOne
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public GTENegativeOneAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public GTENegativeOneAttribute()
		: base(ClassLiteral<GTENegativeOne>.Value)
	{
	}
}
