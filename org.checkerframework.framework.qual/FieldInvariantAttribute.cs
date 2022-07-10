using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyFieldInvariant", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.FieldInvariant" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class FieldInvariantAttribute : AnnotationAttributeBase, FieldInvariant
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public FieldInvariantAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private FieldInvariantAttribute()
		: base(ClassLiteral<FieldInvariant>.Value)
	{
	}

	[HideFromJava]
	public FieldInvariantAttribute(Type[] qualifier, string[] field)
		: this()
	{
		setValue("qualifier", qualifier);
		setValue("field", field);
	}

	private Class[] qualifier()
	{
		return (Class[])getValue("qualifier");
	}

	Class[] FieldInvariant.qualifier()
	{
		//ILSpy generated this explicit interface implementation from .override directive in qualifier
		return this.qualifier();
	}

	private string[] field()
	{
		return (string[])getValue("field");
	}

	string[] FieldInvariant.field()
	{
		//ILSpy generated this explicit interface implementation from .override directive in field
		return this.field();
	}
}
