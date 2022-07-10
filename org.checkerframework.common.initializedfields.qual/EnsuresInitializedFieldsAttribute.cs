using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.common.initializedfields.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.common.initializedfields.qual.$ProxyEnsuresInitializedFields", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.common.initializedfields.qual.EnsuresInitializedFields" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresInitializedFieldsAttribute : AnnotationAttributeBase, EnsuresInitializedFields
{
	[HideFromJava]
	public string[] value
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("value", value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresInitializedFieldsAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresInitializedFieldsAttribute()
		: base(ClassLiteral<EnsuresInitializedFields>.Value)
	{
	}

	[HideFromJava]
	public EnsuresInitializedFieldsAttribute(string[] fields)
		: this()
	{
		setValue("fields", fields);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] EnsuresInitializedFields.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}

	private string[] fields()
	{
		return (string[])getValue("fields");
	}

	string[] EnsuresInitializedFields.fields()
	{
		//ILSpy generated this explicit interface implementation from .override directive in fields
		return this.fields();
	}
}
