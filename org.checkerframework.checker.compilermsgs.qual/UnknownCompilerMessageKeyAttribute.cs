using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.compilermsgs.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.compilermsgs.qual.$ProxyUnknownCompilerMessageKey", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.compilermsgs.qual.UnknownCompilerMessageKey" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class UnknownCompilerMessageKeyAttribute : AnnotationAttributeBase, UnknownCompilerMessageKey
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public UnknownCompilerMessageKeyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UnknownCompilerMessageKeyAttribute()
		: base(ClassLiteral<UnknownCompilerMessageKey>.Value)
	{
	}
}
