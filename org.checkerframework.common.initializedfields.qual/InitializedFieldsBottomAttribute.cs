using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.initializedfields.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.initializedfields.qual.$ProxyInitializedFieldsBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.initializedfields.qual.InitializedFieldsBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class InitializedFieldsBottomAttribute : AnnotationAttributeBase, InitializedFieldsBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InitializedFieldsBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InitializedFieldsBottomAttribute()
		: base(ClassLiteral<InitializedFieldsBottom>.Value)
	{
	}
}
