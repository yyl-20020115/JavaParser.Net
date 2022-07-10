using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.formatter.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.formatter.qual.$ProxyUnknownFormat", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.formatter.qual.UnknownFormat" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownFormatAttribute : AnnotationAttributeBase, UnknownFormat
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownFormatAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownFormatAttribute()
		: base(ClassLiteral<UnknownFormat>.Value)
	{
	}
}
