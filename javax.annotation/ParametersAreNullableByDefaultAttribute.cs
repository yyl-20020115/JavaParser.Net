using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyParametersAreNullableByDefault", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.ParametersAreNullableByDefault" })]
public sealed class ParametersAreNullableByDefaultAttribute : AnnotationAttributeBase, ParametersAreNullableByDefault
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ParametersAreNullableByDefaultAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ParametersAreNullableByDefaultAttribute()
		: base(ClassLiteral<ParametersAreNullableByDefault>.Value)
	{
	}
}
