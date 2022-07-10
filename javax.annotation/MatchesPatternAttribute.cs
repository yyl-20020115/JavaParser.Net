using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyMatchesPattern", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.MatchesPattern" })]
public sealed class MatchesPatternAttribute : AnnotationAttributeBase, MatchesPattern
{
	[HideFromJava]
	public int flags
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("flags", value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public MatchesPatternAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private MatchesPatternAttribute()
		: base(ClassLiteral<MatchesPattern>.Value)
	{
	}

	[HideFromJava]
	public MatchesPatternAttribute(string value)
		: this()
	{
		setValue("value", value);
	}

	private string value()
	{
		return (string)getValue("value");
	}

	string MatchesPattern.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}

	private int flags()
	{
		return getIntValue("flags");
	}

	int MatchesPattern.flags()
	{
		//ILSpy generated this explicit interface implementation from .override directive in flags
		return this.flags();
	}
}
