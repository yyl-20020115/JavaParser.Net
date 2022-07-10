using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.index.qual.$ProxyHasSubsequence", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.index.qual.HasSubsequence" })]
[AttributeUsage(AttributeTargets.Field)]
public sealed class HasSubsequenceAttribute : AnnotationAttributeBase, HasSubsequence
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public HasSubsequenceAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private HasSubsequenceAttribute()
		: base(ClassLiteral<HasSubsequence>.Value)
	{
	}

	[HideFromJava]
	public HasSubsequenceAttribute(string subsequence, string from, string to)
		: this()
	{
		setValue("subsequence", subsequence);
		setValue("from", from);
		setValue("to", to);
	}

	private string subsequence()
	{
		return (string)getValue("subsequence");
	}

	string HasSubsequence.subsequence()
	{
		//ILSpy generated this explicit interface implementation from .override directive in subsequence
		return this.subsequence();
	}

	private string from()
	{
		return (string)getValue("from");
	}

	string HasSubsequence.from()
	{
		//ILSpy generated this explicit interface implementation from .override directive in from
		return this.from();
	}

	private string to()
	{
		return (string)getValue("to");
	}

	string HasSubsequence.to()
	{
		//ILSpy generated this explicit interface implementation from .override directive in to
		return this.to();
	}
}
