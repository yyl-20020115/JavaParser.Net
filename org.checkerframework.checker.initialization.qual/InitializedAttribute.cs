using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.initialization.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.initialization.qual.$ProxyInitialized", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.initialization.qual.Initialized" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class InitializedAttribute : AnnotationAttributeBase, Initialized
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InitializedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InitializedAttribute()
		: base(ClassLiteral<Initialized>.Value)
	{
	}
}
