using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyMayReleaseLocks", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.MayReleaseLocks" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class MayReleaseLocksAttribute : AnnotationAttributeBase, MayReleaseLocks
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MayReleaseLocksAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public MayReleaseLocksAttribute()
		: base(ClassLiteral<MayReleaseLocks>.Value)
	{
	}
}
