using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.errorprone.annotations;

[Modifiers(Modifiers.Final)]
[InnerClass("com.google.errorprone.annotations.$ProxyCheckReturnValue", Modifiers.Final)]
[Implements(new string[] { "com.google.errorprone.annotations.CheckReturnValue" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class CheckReturnValueAttribute : AnnotationAttributeBase, CheckReturnValue
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CheckReturnValueAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CheckReturnValueAttribute()
		: base(ClassLiteral<CheckReturnValue>.Value)
	{
	}
}
