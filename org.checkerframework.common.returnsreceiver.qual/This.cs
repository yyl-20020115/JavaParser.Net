using IKVM.Attributes;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.common.returnsreceiver.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.common.returnsreceiver.qual.ThisAttribute")]
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
			"TYPE_USE"
		},
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"TYPE_PARAMETER"
		}
	}
})]
[PolymorphicQualifier(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/PolymorphicQualifier;"
})]
[TargetLocations(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/TargetLocations;",
	"value",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeUseLocation, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"RECEIVER"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeUseLocation, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"RETURN"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface This : Annotation
{
}
