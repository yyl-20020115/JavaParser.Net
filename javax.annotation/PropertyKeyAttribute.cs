using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyPropertyKey", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.PropertyKey" })]
public sealed class PropertyKeyAttribute : AnnotationAttributeBase, PropertyKey
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
	public PropertyKeyAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public PropertyKeyAttribute()
		: base(ClassLiteral<PropertyKey>.Value)
	{
	}

	private When when()
	{
		return (When)getValue("when");
	}

	When PropertyKey.when()
	{
		//ILSpy generated this explicit interface implementation from .override directive in when
		return this.when();
	}
}
