using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyGuardedByUnknown", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.GuardedByUnknown" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class GuardedByUnknownAttribute : AnnotationAttributeBase, GuardedByUnknown
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public GuardedByUnknownAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public GuardedByUnknownAttribute()
		: base(ClassLiteral<GuardedByUnknown>.Value)
	{
	}
}
