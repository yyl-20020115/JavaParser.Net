using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyParametersAreNonnullByDefault", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.ParametersAreNonnullByDefault" })]
public sealed class ParametersAreNonnullByDefaultAttribute : AnnotationAttributeBase, ParametersAreNonnullByDefault
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public ParametersAreNonnullByDefaultAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public ParametersAreNonnullByDefaultAttribute()
		: base(ClassLiteral<ParametersAreNonnullByDefault>.Value)
	{
	}
}
