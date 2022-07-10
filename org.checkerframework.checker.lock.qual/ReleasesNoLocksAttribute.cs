using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.lock.qual.$ProxyReleasesNoLocks", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.lock.qual.ReleasesNoLocks" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class ReleasesNoLocksAttribute : AnnotationAttributeBase, ReleasesNoLocks
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ReleasesNoLocksAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ReleasesNoLocksAttribute()
		: base(ClassLiteral<ReleasesNoLocks>.Value)
	{
	}
}
