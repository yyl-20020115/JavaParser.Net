using IKVM.Attributes;
using java.lang;
using java.lang.annotation;

namespace com.google.errorprone.annotations;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
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
			"CONSTRUCTOR"
		},
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"METHOD"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface RestrictedApi : Annotation
{
	virtual string explanation();

	virtual string link();

	[AnnotationDefault("")]
	virtual string allowedOnPath();

	[AnnotationDefault(new object[] { (byte)91 })]
	[Signature("()[Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;")]
	virtual Class[] allowlistAnnotations();

	[AnnotationDefault(new object[] { (byte)91 })]
	[Signature("()[Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;")]
	virtual Class[] allowlistWithWarningAnnotations();
}
