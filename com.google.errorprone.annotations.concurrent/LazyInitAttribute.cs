using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.errorprone.annotations.concurrent;

[Modifiers(Modifiers.Final)]
[InnerClass("com.google.errorprone.annotations.concurrent.$ProxyLazyInit", Modifiers.Final)]
[Implements(new string[] { "com.google.errorprone.annotations.concurrent.LazyInit" })]
[AttributeUsage(AttributeTargets.Field)]
public sealed class LazyInitAttribute : AnnotationAttributeBase, LazyInit
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public LazyInitAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public LazyInitAttribute()
		: base(ClassLiteral<LazyInit>.Value)
	{
	}
}
