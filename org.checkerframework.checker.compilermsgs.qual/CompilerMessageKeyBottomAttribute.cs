using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.compilermsgs.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.compilermsgs.qual.$ProxyCompilerMessageKeyBottom", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.compilermsgs.qual.CompilerMessageKeyBottom" })]
[AttributeUsage((AttributeTargets)0)]
public sealed class CompilerMessageKeyBottomAttribute : AnnotationAttributeBase, CompilerMessageKeyBottom
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CompilerMessageKeyBottomAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CompilerMessageKeyBottomAttribute()
		: base(ClassLiteral<CompilerMessageKeyBottom>.Value)
	{
	}
}
