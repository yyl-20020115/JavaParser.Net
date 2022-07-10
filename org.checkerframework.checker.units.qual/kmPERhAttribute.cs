using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.units.qual.$ProxykmPERh", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.units.qual.kmPERh" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class kmPERhAttribute : AnnotationAttributeBase, kmPERh
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public kmPERhAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public kmPERhAttribute()
		: base(ClassLiteral<kmPERh>.Value)
	{
	}
}
