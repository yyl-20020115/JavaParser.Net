using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxySigned", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.Signed" })]
public sealed class SignedAttribute : AnnotationAttributeBase, Signed
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public SignedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public SignedAttribute()
		: base(ClassLiteral<Signed>.Value)
	{
	}
}
