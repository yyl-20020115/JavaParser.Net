using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyWillNotClose", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.WillNotClose" })]
public sealed class WillNotCloseAttribute : AnnotationAttributeBase, WillNotClose
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public WillNotCloseAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public WillNotCloseAttribute()
		: base(ClassLiteral<WillNotClose>.Value)
	{
	}
}
