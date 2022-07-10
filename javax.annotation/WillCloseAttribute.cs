using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyWillClose", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.WillClose" })]
public sealed class WillCloseAttribute : AnnotationAttributeBase, WillClose
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public WillCloseAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public WillCloseAttribute()
		: base(ClassLiteral<WillClose>.Value)
	{
	}
}
