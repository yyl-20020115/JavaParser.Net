using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.aliasing.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.aliasing.qual.$ProxyMaybeAliased", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.aliasing.qual.MaybeAliased" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class MaybeAliasedAttribute : AnnotationAttributeBase, MaybeAliased
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MaybeAliasedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public MaybeAliasedAttribute()
		: base(ClassLiteral<MaybeAliased>.Value)
	{
	}
}
