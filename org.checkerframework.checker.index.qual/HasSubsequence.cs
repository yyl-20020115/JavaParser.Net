using IKVM.Attributes;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.checker.index.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.checker.index.qual.HasSubsequenceAttribute")]
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
			"FIELD"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface HasSubsequence : Annotation
{
	[JavaExpression(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/framework/qual/JavaExpression;"
	})]
	virtual string subsequence();

	[JavaExpression(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/framework/qual/JavaExpression;"
	})]
	virtual string from();

	[JavaExpression(new object[]
	{
		(byte)64,
		"Lorg/checkerframework/framework/qual/JavaExpression;"
	})]
	virtual string to();
}
