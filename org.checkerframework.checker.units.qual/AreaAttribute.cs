using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyArea", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Area" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class AreaAttribute : AnnotationAttributeBase, Area
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AreaAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AreaAttribute()
		: base(ClassLiteral<Area>.Value)
	{
	}
}
