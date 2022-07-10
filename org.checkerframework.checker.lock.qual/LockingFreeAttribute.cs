using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyLockingFree", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.LockingFree" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class LockingFreeAttribute : AnnotationAttributeBase, LockingFree
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LockingFreeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LockingFreeAttribute()
		: base(ClassLiteral<LockingFree>.Value)
	{
	}
}
