using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxySyntax", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.Syntax" })]
public sealed class SyntaxAttribute : AnnotationAttributeBase, Syntax
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
	public SyntaxAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private SyntaxAttribute()
		: base(ClassLiteral<Syntax>.Value)
	{
	}

	[HideFromJava]
	public SyntaxAttribute(string value)
		: this()
	{
		setValue("value", value);
	}

	private string value()
	{
		return (string)getValue("value");
	}

	string Syntax.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}

	private When when()
	{
		return (When)getValue("when");
	}

	When Syntax.when()
	{
		//ILSpy generated this explicit interface implementation from .override directive in when
		return this.when();
	}
}
