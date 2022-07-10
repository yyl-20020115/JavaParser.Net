using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.common.hash;

[InnerClass("com.google.common.hash.$ProxyElementTypesAreNonnullByDefault", Modifiers.Final)]
[Implements(new string[] { "com.google.common.hash.ElementTypesAreNonnullByDefault" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
internal sealed class ElementTypesAreNonnullByDefaultAttribute : AnnotationAttributeBase, ElementTypesAreNonnullByDefault
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ElementTypesAreNonnullByDefaultAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ElementTypesAreNonnullByDefaultAttribute()
		: base(ClassLiteral<ElementTypesAreNonnullByDefault>.Value)
	{
	}
}
