using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyQualifierForLiterals", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.QualifierForLiterals" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class QualifierForLiteralsAttribute : AnnotationAttributeBase, QualifierForLiterals
{
	[HideFromJava]
	public string[] stringPatterns
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("stringPatterns", value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public QualifierForLiteralsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public QualifierForLiteralsAttribute()
		: base(ClassLiteral<QualifierForLiterals>.Value)
	{
	}

	[HideFromJava]
	public QualifierForLiteralsAttribute(LiteralKind.__Enum[] value)
		: this()
	{
		setValue("value", value);
	}

	private LiteralKind[] value()
	{
		return (LiteralKind[])getValue("value");
	}

	LiteralKind[] QualifierForLiterals.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}

	private string[] stringPatterns()
	{
		return (string[])getValue("stringPatterns");
	}

	string[] QualifierForLiterals.stringPatterns()
	{
		//ILSpy generated this explicit interface implementation from .override directive in stringPatterns
		return this.stringPatterns();
	}
}
