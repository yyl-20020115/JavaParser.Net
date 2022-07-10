using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyLockPossiblyHeld", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.LockPossiblyHeld" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LockPossiblyHeldAttribute : AnnotationAttributeBase, LockPossiblyHeld
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LockPossiblyHeldAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LockPossiblyHeldAttribute()
		: base(ClassLiteral<LockPossiblyHeld>.Value)
	{
	}
}
