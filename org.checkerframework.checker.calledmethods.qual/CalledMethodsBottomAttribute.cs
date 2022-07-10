using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.calledmethods.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.calledmethods.qual.$ProxyCalledMethodsBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.calledmethods.qual.CalledMethodsBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CalledMethodsBottomAttribute : AnnotationAttributeBase, CalledMethodsBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CalledMethodsBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CalledMethodsBottomAttribute()
		: base(ClassLiteral<CalledMethodsBottom>.Value)
	{
	}
}
