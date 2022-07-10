using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.common.eventbus;

[Modifiers(Modifiers.Final)]
[InnerClass("com.google.common.eventbus.$ProxySubscribe", Modifiers.Final)]
[Implements(new string[] { "com.google.common.eventbus.Subscribe" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class SubscribeAttribute : AnnotationAttributeBase, Subscribe
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SubscribeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SubscribeAttribute()
		: base(ClassLiteral<Subscribe>.Value)
	{
	}
}
