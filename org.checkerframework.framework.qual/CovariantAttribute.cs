using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyCovariant", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.Covariant" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class CovariantAttribute : AnnotationAttributeBase, Covariant
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CovariantAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private CovariantAttribute()
		: base(ClassLiteral<Covariant>.Value)
	{
	}

	[HideFromJava]
	public CovariantAttribute(int[] value)
		: this()
	{
		setValue("value", value);
	}

	private int[] value()
	{
		return (int[])getValue("value");
	}

	int[] Covariant.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
