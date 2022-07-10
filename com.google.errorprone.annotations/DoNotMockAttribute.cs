using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace com.google.errorprone.annotations;

[Modifiers(Modifiers.Final)]
[InnerClass("com.google.errorprone.annotations.$ProxyDoNotMock", Modifiers.Final)]
[Implements(new string[] { "com.google.errorprone.annotations.DoNotMock" })]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Interface | AttributeTargets.Delegate)]
public sealed class DoNotMockAttribute : AnnotationAttributeBase, DoNotMock
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public DoNotMockAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public DoNotMockAttribute()
		: base(ClassLiteral<DoNotMock>.Value)
	{
	}

	[HideFromJava]
	public DoNotMockAttribute(string value)
		: this()
	{
		setValue("value", value);
	}

	private string value()
	{
		return (string)getValue("value");
	}

	string DoNotMock.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
