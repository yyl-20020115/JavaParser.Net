using System;
using System.ComponentModel;
using IKVM.Attributes;
using ikvm.@internal;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Final)]
[InnerClass("org.checkerframework.framework.qual.$ProxyQualifierArgument", Modifiers.Final)]
[Implements(new string[] { "org.checkerframework.framework.qual.QualifierArgument" })]
[AttributeUsage(AttributeTargets.Method)]
public sealed class QualifierArgumentAttribute : AnnotationAttributeBase, QualifierArgument
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	public QualifierArgumentAttribute(object[] P_0)
		: this()
	{
		setDefinition(P_0);
	}

	public QualifierArgumentAttribute()
		: base(ClassLiteral<QualifierArgument>.Value)
	{
	}

	[HideFromJava]
	public QualifierArgumentAttribute(string value)
		: this()
	{
		setValue("value", value);
	}

	private string value()
	{
		return (string)getValue("value");
	}

	string QualifierArgument.value()
	{
		//ILSpy generated this explicit interface implementation from .override directive in value
		return this.value();
	}
}
