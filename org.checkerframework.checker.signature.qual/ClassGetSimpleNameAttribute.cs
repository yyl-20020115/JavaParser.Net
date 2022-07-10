using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.signature.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.signature.qual.$ProxyClassGetSimpleName", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.signature.qual.ClassGetSimpleName" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class ClassGetSimpleNameAttribute : AnnotationAttributeBase, ClassGetSimpleName
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ClassGetSimpleNameAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ClassGetSimpleNameAttribute()
		: base(ClassLiteral<ClassGetSimpleName>.Value)
	{
	}
}
