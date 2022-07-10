using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyClassGetName", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.ClassGetName" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class ClassGetNameAttribute : AnnotationAttributeBase, ClassGetName
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ClassGetNameAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ClassGetNameAttribute()
		: base(ClassLiteral<ClassGetName>.Value)
	{
	}
}
