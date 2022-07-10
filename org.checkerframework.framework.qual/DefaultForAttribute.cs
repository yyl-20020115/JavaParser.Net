using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyDefaultFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.DefaultFor" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class DefaultForAttribute : AnnotationAttributeBase, DefaultFor
{
	[HideFromJava]
	public TypeKind.__Enum[] typeKinds
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("typeKinds", value);
		}
	}

	[HideFromJava]
	public Type[] types
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("types", value);
		}
	}

	[HideFromJava]
	public string[] names
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("names", value);
		}
	}

	[HideFromJava]
	public string[] namesExceptions
	{
		[HideFromJava]
		get
		{
			throw new NotImplementedException();
		}
		[HideFromJava]
		set
		{
			setValue("namesExceptions", value);
		}
	}

	[EditorBrowsable(EditorBrowsableState.Never)]
	public DefaultForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public DefaultForAttribute()
		: base(ClassLiteral<DefaultFor>.Value)
	{
	}

	[HideFromJava]
	public DefaultForAttribute(TypeUseLocation.__Enum[] value)
		: this()
	{
		setValue("value", value);
	}

	private TypeUseLocation[] value()
	{
		return (TypeUseLocation[])getValue("value");
	}

	TypeUseLocation[] DefaultFor.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}

	private TypeKind[] typeKinds()
	{
		return (TypeKind[])getValue("typeKinds");
	}

	TypeKind[] DefaultFor.typeKinds()
	{
		//ILSpy generated this explicit interface implementation from .override directive in typeKinds
		return this.typeKinds();
	}

	private Class[] types()
	{
		return (Class[])getValue("types");
	}

	Class[] DefaultFor.types()
	{
		//ILSpy generated this explicit interface implementation from .override directive in types
		return this.types();
	}

	private string[] names()
	{
		return (string[])getValue("names");
	}

	string[] DefaultFor.names()
	{
		//ILSpy generated this explicit interface implementation from .override directive in names
		return this.names();
	}

	private string[] namesExceptions()
	{
		return (string[])getValue("namesExceptions");
	}

	string[] DefaultFor.namesExceptions()
	{
		//ILSpy generated this explicit interface implementation from .override directive in namesExceptions
		return this.namesExceptions();
	}
}
