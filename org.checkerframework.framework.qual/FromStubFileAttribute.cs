using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyFromStubFile", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.FromStubFile" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class FromStubFileAttribute : AnnotationAttributeBase, FromStubFile
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FromStubFileAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public FromStubFileAttribute()
		: base(ClassLiteral<FromStubFile>.Value)
	{
	}
}
