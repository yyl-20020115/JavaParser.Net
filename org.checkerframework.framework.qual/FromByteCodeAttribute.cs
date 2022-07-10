using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyFromByteCode", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.FromByteCode" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class FromByteCodeAttribute : AnnotationAttributeBase, FromByteCode
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FromByteCodeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FromByteCodeAttribute()
		: base(ClassLiteral<FromByteCode>.Value)
	{
	}
}
