using IKVM.Attributes;
using java.lang.annotation;
using javax.annotation;

namespace com.google.common.eventbus;

[Modifiers(Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("com.google.common.eventbus.ParametricNullnessAttribute")]
[Retention(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Retention;",
	"value",
	new object[]
	{
		(byte)101,
		"Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
		"RUNTIME"
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
			"FIELD"
		},
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"METHOD"
		},
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"PARAMETER"
		}
	}
})]
[Nonnull(new object[]
{
	(byte)64,
	"Ljavax/annotation/Nonnull;",
	"when",
	new object[]
	{
		(byte)101,
		"Ljavax/annotation/meta/When, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
		"UNKNOWN"
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
internal interface ParametricNullness : Annotation
{
}
