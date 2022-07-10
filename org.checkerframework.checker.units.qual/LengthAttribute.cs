using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyLength", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Length" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LengthAttribute : AnnotationAttributeBase, Length
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LengthAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LengthAttribute()
		: base(ClassLiteral<Length>.Value)
	{
	}
}
