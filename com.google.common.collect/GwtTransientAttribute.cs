using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.common.collect;

[InnerClass("com.google.common.collect.$ProxyGwtTransient", Modifiers.Final)]
[Implements(new string[] { "com.google.common.collect.GwtTransient" })]
[AttributeUsage(AttributeTargets.Field)]
internal sealed class GwtTransientAttribute : AnnotationAttributeBase, GwtTransient
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public GwtTransientAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public GwtTransientAttribute()
		: base(ClassLiteral<GwtTransient>.Value)
	{
	}
}
