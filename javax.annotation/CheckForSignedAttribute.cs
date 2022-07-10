using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace javax.annotation;

[Modifiers(Modifiers.Final)]
[InnerClass("javax.annotation.$ProxyCheckForSigned", Modifiers.Final)]
[Implements(new string[] { "javax.annotation.CheckForSigned" })]
public sealed class CheckForSignedAttribute : AnnotationAttributeBase, CheckForSigned
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public CheckForSignedAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public CheckForSignedAttribute()
		: base(ClassLiteral<CheckForSigned>.Value)
	{
	}
}
