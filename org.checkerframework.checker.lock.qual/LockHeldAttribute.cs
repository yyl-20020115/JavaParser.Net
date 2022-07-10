using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyLockHeld", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.LockHeld" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class LockHeldAttribute : AnnotationAttributeBase, LockHeld
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LockHeldAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LockHeldAttribute()
		: base(ClassLiteral<LockHeld>.Value)
	{
	}
}
