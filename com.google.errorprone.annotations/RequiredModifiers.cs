using System;
using IKVM.Attributes;
using java.lang;
using java.lang.annotation;
using javax.lang.model.element;

namespace com.google.errorprone.annotations;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[Documented(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Documented;"
})]
[Retention(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Retention;",
	"value",
	new object[]
	{
		(byte)101,
		"Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
		"CLASS"
	}
})]
[Target(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Target;",
	"value",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"ANNOTATION_TYPE"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface RequiredModifiers : Annotation
{
	[AnnotationDefault(new object[] { (byte)91 })]
	[Obsolete]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	virtual javax.lang.model.element.Modifier[] value();

	[AnnotationDefault(new object[] { (byte)91 })]
	virtual Modifier[] modifier();
}
