using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.checker.nullness.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.checker.nullness.qual.$ProxyEnsuresKeyForIf", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.checker.nullness.qual.EnsuresKeyForIf" })]
[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method)]
public sealed class EnsuresKeyForIfAttribute : AnnotationAttributeBase, EnsuresKeyForIf
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public EnsuresKeyForIfAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	private EnsuresKeyForIfAttribute()
		: base(ClassLiteral<EnsuresKeyForIf>.Value)
	{
	}

	[HideFromJava]
	public EnsuresKeyForIfAttribute(bool result, string[] expression, string[] map)
		: this()
	{
		setValue("result", result);
		setValue("expression", expression);
		setValue("map", map);
	}

	private bool result()
	{
		return getBooleanValue("result");
	}

	bool EnsuresKeyForIf.result()
	{
		//ILSpy generated this explicit interface implementation from .override directive in result
		return this.result();
	}

	private string[] expression()
	{
		return (string[])getValue("expression");
	}

	string[] EnsuresKeyForIf.expression()
	{
		//ILSpy generated this explicit interface implementation from .override directive in expression
		return this.expression();
	}

	private string[] map()
	{
		return (string[])getValue("map");
	}

	string[] EnsuresKeyForIf.map()
	{
		//ILSpy generated this explicit interface implementation from .override directive in map
		return this.map();
	}
}
