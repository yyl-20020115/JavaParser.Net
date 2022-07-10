using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyEnsuresKeyFor", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.EnsuresKeyFor" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresKeyForAttribute : AnnotationAttributeBase, EnsuresKeyFor
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresKeyForAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresKeyForAttribute()
		: base(ClassLiteral<EnsuresKeyFor>.Value)
	{
	}

	[HideFromJava]
	public EnsuresKeyForAttribute(string[] value, string[] map)
		: this()
	{
		setValue("value", value);
		setValue("map", map);
	}

	private string[] value()
	{
		return (string[])getValue("value");
	}

	string[] EnsuresKeyFor.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}

	private string[] map()
	{
		return (string[])getValue("map");
	}

	string[] EnsuresKeyFor.map()
	{
		//ILSpy generated this explicit interface implementation from .override directive in map
		return this.map();
	}
}
