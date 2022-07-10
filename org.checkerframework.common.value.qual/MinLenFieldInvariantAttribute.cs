using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.value.qual.$ProxyMinLenFieldInvariant", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.value.qual.MinLenFieldInvariant" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class MinLenFieldInvariantAttribute : AnnotationAttributeBase, MinLenFieldInvariant
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public MinLenFieldInvariantAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private MinLenFieldInvariantAttribute()
		: base(ClassLiteral<MinLenFieldInvariant>.Value)
	{
	}

	[HideFromJava]
	public MinLenFieldInvariantAttribute(int[] minLen, string[] field)
		: this()
	{
		setValue("minLen", minLen);
		setValue("field", field);
	}

	private int[] minLen()
	{
		return (int[])getValue("minLen");
	}

	int[] MinLenFieldInvariant.minLen()
	{
		//ILSpy generated this explicit interface implementation from .override directive in minLen
		return this.minLen();
	}

	private string[] field()
	{
		return (string[])getValue("field");
	}

	string[] MinLenFieldInvariant.field()
	{
		//ILSpy generated this explicit interface implementation from .override directive in field
		return this.field();
	}
}
