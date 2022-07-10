using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.guieffect.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.guieffect.qual.$ProxyAlwaysSafe", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.guieffect.qual.AlwaysSafe" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class AlwaysSafeAttribute : AnnotationAttributeBase, AlwaysSafe
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AlwaysSafeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public AlwaysSafeAttribute()
		: base(ClassLiteral<AlwaysSafe>.Value)
	{
	}
}
