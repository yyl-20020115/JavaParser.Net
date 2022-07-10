using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyCheckReturnValue", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.CheckReturnValue" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class CheckReturnValueAttribute : AnnotationAttributeBase, CheckReturnValue
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
	public CheckReturnValueAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CheckReturnValueAttribute()
		: base(ClassLiteral<CheckReturnValue>.Value)
	{
	}

	private When when()
	{
		return (When)getValue("when");
	}

	When CheckReturnValue.when()
	{
		//ILSpy generated this explicit interface implementation from .override directive in when
		return this.when();
	}
}
