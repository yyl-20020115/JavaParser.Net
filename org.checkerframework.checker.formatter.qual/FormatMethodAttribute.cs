using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.formatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.formatter.qual.$ProxyFormatMethod", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.formatter.qual.FormatMethod" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class FormatMethodAttribute : AnnotationAttributeBase, FormatMethod
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FormatMethodAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FormatMethodAttribute()
		: base(ClassLiteral<FormatMethod>.Value)
	{
	}
}
