using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyRegEx", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.RegEx" })]
public sealed class RegExAttribute : AnnotationAttributeBase, RegEx
{
	[HideFromJava]
	public When.__Enum when
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("when", value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public RegExAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public RegExAttribute()
		: base(ClassLiteral<RegEx>.Value)
	{
	}

	private When when()
	{
		return (When)getValue("when");
	}

	When RegEx.when()
	{
		//ILSpy generated this explicit interface implementation from .override directive in when
		return this.when();
	}
}
