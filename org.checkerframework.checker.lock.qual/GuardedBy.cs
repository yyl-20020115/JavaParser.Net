using IKVM.Attributes;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.checker.@lock.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.checker.lock.qual.GuardedByAttribute")]
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
			"Lorg/checkerframework/checker/lock/qual/GuardedByUnknown, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
		}
	}
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
			"EXCEPTION_PARAMETER"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeUseLocation, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"UPPER_BOUND"
		}
	},
	"typeKinds",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"BOOLEAN"
		},
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
			"CHAR"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"DOUBLE"
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
		}
	},
	"types",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)99,
			"Ljava/lang/String, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		},
		new object[]
		{
			(byte)99,
			"Ljava/lang/Void, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
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
			"BOOLEAN"
		},
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
			"CHAR"
		},
		new object[]
		{
			(byte)101,
			"Lorg/checkerframework/framework/qual/TypeKind, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
			"DOUBLE"
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
		}
	},
	"types",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)99,
			"Ljava/lang/String, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface GuardedBy : Annotation
{
	[AnnotationDefault(new object[] { (byte)91 })]
	[JavaExpression(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/framework/qual/JavaExpression;"
	})]
	virtual string[] value();
}
