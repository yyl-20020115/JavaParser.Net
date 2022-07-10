using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.initialization.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.initialization.qual.$ProxyNotOnlyInitialized", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.initialization.qual.NotOnlyInitialized" })]
[AttributeUsage(AttributeTargets.Field)]
public sealed class NotOnlyInitializedAttribute : AnnotationAttributeBase, NotOnlyInitialized
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NotOnlyInitializedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public NotOnlyInitializedAttribute()
		: base(ClassLiteral<NotOnlyInitialized>.Value)
	{
	}
}
