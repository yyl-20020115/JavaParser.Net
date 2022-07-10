using IKVM.Attributes;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.common.subtyping.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[Documented(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Documented;"
})]
[SubtypeOf(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/SubtypeOf;",
	"value",
	new object[] { (byte)91 }
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
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface Bottom : Annotation
{
}
