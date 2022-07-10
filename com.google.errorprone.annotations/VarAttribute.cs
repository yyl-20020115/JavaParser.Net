using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.errorprone.annotations;

[Modifiers(Modifiers.Final)]
[InnerClass("com.google.errorprone.annotations.$ProxyVar", Modifiers.Final)]
[Implements(new string[] { "com.google.errorprone.annotations.Var" })]
[AttributeUsage(AttributeTargets.Field | AttributeTargets.Parameter)]
public sealed class VarAttribute : AnnotationAttributeBase, Var
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public VarAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public VarAttribute()
		: base(ClassLiteral<Var>.Value)
	{
	}
}
