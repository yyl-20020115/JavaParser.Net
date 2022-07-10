using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.aliasing.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.aliasing.qual.$ProxyLeakedToResult", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.aliasing.qual.LeakedToResult" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LeakedToResultAttribute : AnnotationAttributeBase, LeakedToResult
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LeakedToResultAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LeakedToResultAttribute()
		: base(ClassLiteral<LeakedToResult>.Value)
	{
	}
}
