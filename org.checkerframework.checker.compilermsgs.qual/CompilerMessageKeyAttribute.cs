using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.compilermsgs.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.compilermsgs.qual.$ProxyCompilerMessageKey", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.compilermsgs.qual.CompilerMessageKey" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CompilerMessageKeyAttribute : AnnotationAttributeBase, CompilerMessageKey
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CompilerMessageKeyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CompilerMessageKeyAttribute()
		: base(ClassLiteral<CompilerMessageKey>.Value)
	{
	}
}
