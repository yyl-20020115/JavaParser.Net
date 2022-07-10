using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyNonnull", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.Nonnull" })]
public sealed class NonnullAttribute : AnnotationAttributeBase, Nonnull
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
	public NonnullAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public NonnullAttribute()
		: base(ClassLiteral<Nonnull>.Value)
	{
	}

	private When when()
	{
		return (When)getValue("when");
	}

	When Nonnull.when()
	{
		//ILSpy generated this explicit interface implementation from .override directive in when
		return this.when();
	}
}
