using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.errorprone.annotations;

[Modifiers(Modifiers.Final)]
[InnerClass("com.google.errorprone.annotations.$ProxyKeep", Modifiers.Final)]
[Implements(new string[] { "com.google.errorprone.annotations.Keep" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Field | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class KeepAttribute : AnnotationAttributeBase, Keep
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public KeepAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public KeepAttribute()
		: base(ClassLiteral<Keep>.Value)
	{
	}
}
