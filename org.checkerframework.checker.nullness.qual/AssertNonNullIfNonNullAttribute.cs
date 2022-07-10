using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyAssertNonNullIfNonNull", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.AssertNonNullIfNonNull" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class AssertNonNullIfNonNullAttribute : AnnotationAttributeBase, AssertNonNullIfNonNull
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public AssertNonNullIfNonNullAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private AssertNonNullIfNonNullAttribute()
		: base(ClassLiteral<AssertNonNullIfNonNull>.Value)
	{
	}

	[HideFromJava]
	public AssertNonNullIfNonNullAttribute(string[] value)
		: this()
	{
		setValue("value", value);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] AssertNonNullIfNonNull.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
