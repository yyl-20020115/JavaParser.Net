using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyTainted", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.Tainted" })]
public sealed class TaintedAttribute : AnnotationAttributeBase, Tainted
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public TaintedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public TaintedAttribute()
		: base(ClassLiteral<Tainted>.Value)
	{
	}
}
