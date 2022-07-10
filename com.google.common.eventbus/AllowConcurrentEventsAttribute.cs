using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.common.eventbus;

[Modifiers(Modifiers.Final)]
[InnerClass("com.google.common.eventbus.$ProxyAllowConcurrentEvents", Modifiers.Final)]
[Implements(new string[] { "com.google.common.eventbus.AllowConcurrentEvents" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class AllowConcurrentEventsAttribute : AnnotationAttributeBase, AllowConcurrentEvents
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AllowConcurrentEventsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AllowConcurrentEventsAttribute()
		: base(ClassLiteral<AllowConcurrentEvents>.Value)
	{
	}
}
