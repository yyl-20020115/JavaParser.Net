using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyPolyValue", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.PolyValue" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class PolyValueAttribute : AnnotationAttributeBase, PolyValue
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyValueAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyValueAttribute()
		: base(ClassLiteral<PolyValue>.Value)
	{
	}
}
