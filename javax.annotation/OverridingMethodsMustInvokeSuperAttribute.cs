using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyOverridingMethodsMustInvokeSuper", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.OverridingMethodsMustInvokeSuper" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class OverridingMethodsMustInvokeSuperAttribute : AnnotationAttributeBase, OverridingMethodsMustInvokeSuper
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public OverridingMethodsMustInvokeSuperAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public OverridingMethodsMustInvokeSuperAttribute()
		: base(ClassLiteral<OverridingMethodsMustInvokeSuper>.Value)
	{
	}
}
