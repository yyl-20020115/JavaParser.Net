using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyNullable", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.Nullable" })]
public sealed class NullableAttribute : AnnotationAttributeBase, Nullable
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public NullableAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public NullableAttribute()
		: base(ClassLiteral<Nullable>.Value)
	{
	}
}
