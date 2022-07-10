using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.optional.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.optional.qual.$ProxyOptionalBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.optional.qual.OptionalBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class OptionalBottomAttribute : AnnotationAttributeBase, OptionalBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public OptionalBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public OptionalBottomAttribute()
		: base(ClassLiteral<OptionalBottom>.Value)
	{
	}
}
