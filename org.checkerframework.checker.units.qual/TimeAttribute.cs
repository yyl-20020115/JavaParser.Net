using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxyTime", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.Time" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class TimeAttribute : AnnotationAttributeBase, Time
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public TimeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public TimeAttribute()
		: base(ClassLiteral<Time>.Value)
	{
	}
}
