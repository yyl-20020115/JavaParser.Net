using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyUntainted", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.Untainted" })]
public sealed class UntaintedAttribute : AnnotationAttributeBase, Untainted
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
	public UntaintedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UntaintedAttribute()
		: base(ClassLiteral<Untainted>.Value)
	{
	}

	private When when()
	{
		return (When)getValue("when");
	}

	When Untainted.when()
	{
		//ILSpy generated this explicit interface implementation from .override directive in when
		return this.when();
	}
}
