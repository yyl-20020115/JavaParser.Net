using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.errorprone.annotations;

[Modifiers(Modifiers.Final)]
[InnerClass("com.google.errorprone.annotations.$ProxyImmutable", Modifiers.Final)]
[Implements(new string[] { "com.google.errorprone.annotations.Immutable" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class ImmutableAttribute : AnnotationAttributeBase, Immutable
{
	[HideFromJava]
	public string[] containerOf
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("containerOf", value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public ImmutableAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ImmutableAttribute()
		: base(ClassLiteral<Immutable>.Value)
	{
	}

	private string[] containerOf()
	{
		return (string[])getValue("containerOf");
	}

	string[] Immutable.containerOf()
	{
		//ILSpy generated this explicit interface implementation from .override directive in containerOf
		return this.containerOf();
	}
}
