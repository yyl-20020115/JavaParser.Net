using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyCheckForNull", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.CheckForNull" })]
public sealed class CheckForNullAttribute : AnnotationAttributeBase, CheckForNull
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CheckForNullAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CheckForNullAttribute()
		: base(ClassLiteral<CheckForNull>.Value)
	{
	}
}
