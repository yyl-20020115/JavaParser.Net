using IKVM.Attributes;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.checker.signedness.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.checker.signedness.qual.SignedAttribute")]
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
			"Lorg/checkerframework/checker/signedness/qual/UnknownSignedness, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		}
	}
})]
[DefaultFor(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/DefaultFor;",
	"typeKinds",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"BYTE"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"INT"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"LONG"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"SHORT"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"FLOAT"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"DOUBLE"
		}
	},
	"types",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)99,
			"Ljava/lang/Byte, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		},
		new object[]
		{
			(byte)99,
			"Ljava/lang/Integer, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		},
		new object[]
		{
			(byte)99,
			"Ljava/lang/Long, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		},
		new object[]
		{
			(byte)99,
			"Ljava/lang/Short, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		},
		new object[]
		{
			(byte)99,
			"Ljava/lang/Float, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		},
		new object[]
		{
			(byte)99,
			"Ljava/lang/Double, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		}
	}
})]
[UpperBoundFor(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/UpperBoundFor;",
	"typeKinds",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"FLOAT"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"DOUBLE"
		}
	},
	"types",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)99,
			"Ljava/lang/Float, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		},
		new object[]
		{
			(byte)99,
			"Ljava/lang/Double, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface Signed : Annotation
{
}
