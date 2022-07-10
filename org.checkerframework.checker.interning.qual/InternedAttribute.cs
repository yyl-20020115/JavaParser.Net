using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.interning.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.interning.qual.$ProxyInterned", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.interning.qual.Interned" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class InternedAttribute : AnnotationAttributeBase, Interned
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public InternedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public InternedAttribute()
		: base(ClassLiteral<Interned>.Value)
	{
	}
}
