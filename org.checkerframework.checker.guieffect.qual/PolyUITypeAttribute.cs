using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.guieffect.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.guieffect.qual.$ProxyPolyUIType", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.guieffect.qual.PolyUIType" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class PolyUITypeAttribute : AnnotationAttributeBase, PolyUIType
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public PolyUITypeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PolyUITypeAttribute()
		: base(ClassLiteral<PolyUIType>.Value)
	{
	}
}
