using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.reflection.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.reflection.qual.$ProxyClassValBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.reflection.qual.ClassValBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class ClassValBottomAttribute : AnnotationAttributeBase, ClassValBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ClassValBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ClassValBottomAttribute()
		: base(ClassLiteral<ClassValBottom>.Value)
	{
	}
}
