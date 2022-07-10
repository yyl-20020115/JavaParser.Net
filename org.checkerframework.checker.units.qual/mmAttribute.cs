using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxymm", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.mm" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class mmAttribute : AnnotationAttributeBase, mm
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public mmAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public mmAttribute()
		: base(ClassLiteral<mm>.Value)
	{
	}
}
