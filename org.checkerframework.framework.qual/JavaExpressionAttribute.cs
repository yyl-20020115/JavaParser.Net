using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyJavaExpression", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.JavaExpression" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class JavaExpressionAttribute : AnnotationAttributeBase, JavaExpression
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public JavaExpressionAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public JavaExpressionAttribute()
		: base(ClassLiteral<JavaExpression>.Value)
	{
	}
}
