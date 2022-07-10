using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyUpperBoundFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.UpperBoundFor" })]
[AttributeUsage(AttributeTargets.Interface)]
public sealed class UpperBoundForAttribute : AnnotationAttributeBase, UpperBoundFor
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

	[EditorBrowsable(EditorBrowsableState.Never)]
	public UpperBoundForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public UpperBoundForAttribute()
		: base(ClassLiteral<UpperBoundFor>.Value)
	{
	}

	private TypeKind[] typeKinds()
	{
		return (TypeKind[])getValue("typeKinds");
	}

	TypeKind[] UpperBoundFor.typeKinds()
	{
		//ILSpy generated this explicit interface implementation from .override directive in typeKinds
		return this.typeKinds();
	}

	private Class[] types()
	{
		return (Class[])getValue("types");
	}

	Class[] UpperBoundFor.types()
	{
		//ILSpy generated this explicit interface implementation from .override directive in types
		return this.types();
	}
}
