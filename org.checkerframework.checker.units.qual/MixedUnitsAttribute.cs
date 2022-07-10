using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyMixedUnits", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.MixedUnits" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MixedUnitsAttribute : AnnotationAttributeBase, MixedUnits
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MixedUnitsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public MixedUnitsAttribute()
		: base(ClassLiteral<MixedUnits>.Value)
	{
	}
}
