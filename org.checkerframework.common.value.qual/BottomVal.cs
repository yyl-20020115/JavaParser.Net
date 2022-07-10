using IKVM.Attributes;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.common.value.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.common.value.qual.BottomValAttribute")]
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
			"EXPLICIT_LOWER_BOUND"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeUseLocation, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"EXPLICIT_UPPER_BOUND"
		}
	}
})]
[SubtypeOf(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/SubtypeOf;",
	"value",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/ArrayLen, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		},
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/BoolVal, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		},
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/DoubleVal, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		},
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/IntVal, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		},
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/StringVal, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		},
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/MatchesRegex, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		},
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/ArrayLenRange, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		},
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/IntRange, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		},
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/IntRangeFromPositive, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		},
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/IntRangeFromGTENegativeOne, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		},
		new object[]
		{
			(byte)99,
			"Lorg/checkerframework/common/value/qual/IntRangeFromNonNegative, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		}
	}
})]
[InvisibleQualifier(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/InvisibleQualifier;"
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface BottomVal : Annotation
{
}
