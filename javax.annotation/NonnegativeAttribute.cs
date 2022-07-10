using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyNonnegative", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.Nonnegative" })]
public sealed class NonnegativeAttribute : AnnotationAttributeBase, Nonnegative
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
	public NonnegativeAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public NonnegativeAttribute()
		: base(ClassLiteral<Nonnegative>.Value)
	{
	}

	private When when()
	{
		return (When)getValue("when");
	}

	When Nonnegative.when()
	{
		//ILSpy generated this explicit interface implementation from .override directive in when
		return this.when();
	}
}
