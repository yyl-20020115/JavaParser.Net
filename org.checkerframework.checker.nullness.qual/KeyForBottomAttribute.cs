using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyKeyForBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.KeyForBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class KeyForBottomAttribute : AnnotationAttributeBase, KeyForBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public KeyForBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public KeyForBottomAttribute()
		: base(ClassLiteral<KeyForBottom>.Value)
	{
	}
}
