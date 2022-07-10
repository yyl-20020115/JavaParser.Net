using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyWillCloseWhenClosed", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.WillCloseWhenClosed" })]
public sealed class WillCloseWhenClosedAttribute : AnnotationAttributeBase, WillCloseWhenClosed
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public WillCloseWhenClosedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public WillCloseWhenClosedAttribute()
		: base(ClassLiteral<WillCloseWhenClosed>.Value)
	{
	}
}
