using IKVM.Attributes;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.common.returnsreceiver.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.common.returnsreceiver.qual.UnknownThisAttribute")]
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
[DefaultQualifierInHierarchy(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/DefaultQualifierInHierarchy;"
})]
[SubtypeOf(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/SubtypeOf;",
	"value",
	new object[] { (byte)91 }
})]
[QualifierForLiterals(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/QualifierForLiterals;",
	"value",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/LiteralKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"NULL"
		}
	}
})]
[DefaultFor(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/DefaultFor;",
	"value",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeUseLocation, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"LOWER_BOUND"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface UnknownThis : Annotation
{
}
