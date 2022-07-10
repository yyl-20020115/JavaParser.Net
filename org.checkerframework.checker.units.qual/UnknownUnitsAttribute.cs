using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyUnknownUnits", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.UnknownUnits" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownUnitsAttribute : AnnotationAttributeBase, UnknownUnits
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownUnitsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownUnitsAttribute()
		: base(ClassLiteral<UnknownUnits>.Value)
	{
	}
}
