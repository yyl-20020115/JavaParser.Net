using IKVM.Attributes;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.checker.calledmethods.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[PostconditionAnnotation(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/PostconditionAnnotation;",
	"qualifier",
	new object[]
	{
		(byte)99,
		"Lorg/checkerframework/checker/calledmethods/qual/CalledMethods, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
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
			"METHOD"
		},
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"CONSTRUCTOR"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface EnsuresCalledMethods : Annotation
{
	virtual string[] value();

	[QualifierArgument(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/framework/qual/QualifierArgument;",
		"value",
		"value"
	})]
	virtual string[] methods();
}
