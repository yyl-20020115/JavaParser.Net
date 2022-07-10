using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.initialization.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.initialization.qual.$ProxyFBCBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.initialization.qual.FBCBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class FBCBottomAttribute : AnnotationAttributeBase, FBCBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FBCBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FBCBottomAttribute()
		: base(ClassLiteral<FBCBottom>.Value)
	{
	}
}
