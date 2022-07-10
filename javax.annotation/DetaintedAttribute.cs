using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyDetainted", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.Detainted" })]
public sealed class DetaintedAttribute : AnnotationAttributeBase, Detainted
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public DetaintedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public DetaintedAttribute()
		: base(ClassLiteral<Detainted>.Value)
	{
	}
}
