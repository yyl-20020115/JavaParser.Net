using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyGuardedByBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.GuardedByBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class GuardedByBottomAttribute : AnnotationAttributeBase, GuardedByBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public GuardedByBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public GuardedByBottomAttribute()
		: base(ClassLiteral<GuardedByBottom>.Value)
	{
	}
}
