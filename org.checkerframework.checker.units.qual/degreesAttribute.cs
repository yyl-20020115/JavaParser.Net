using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$Proxydegrees", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.degrees" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class degreesAttribute : AnnotationAttributeBase, degrees
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public degreesAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public degreesAttribute()
		: base(ClassLiteral<degrees>.Value)
	{
	}
}
