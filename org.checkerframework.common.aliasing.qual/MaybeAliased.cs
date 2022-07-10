using IKVM.Attributes;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.common.aliasing.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.common.aliasing.qual.MaybeAliasedAttribute")]
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
			"TYPE_PARAMETER"
		},
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"TYPE_USE"
		}
	}
})]
[SubtypeOf(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/SubtypeOf;",
	"value",
	new object[] { (byte)91 }
})]
[DefaultQualifierInHierarchy(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/DefaultQualifierInHierarchy;"
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
			"UPPER_BOUND"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeUseLocation, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"LOWER_BOUND"
		}
	},
	"types",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)99,
			"Ljava/lang/Void, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface MaybeAliased : Annotation
{
}
