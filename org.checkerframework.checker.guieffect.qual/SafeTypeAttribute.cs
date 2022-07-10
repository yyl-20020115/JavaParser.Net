using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.guieffect.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.guieffect.qual.$ProxySafeType", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.guieffect.qual.SafeType" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class SafeTypeAttribute : AnnotationAttributeBase, SafeType
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SafeTypeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SafeTypeAttribute()
		: base(ClassLiteral<SafeType>.Value)
	{
	}
}
