using IKVM.Attributes;
using java.lang;
using java.lang.annotation;

namespace org.checkerframework.checker.units.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.checker.units.qual.UnitsMultipleAttribute")]
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
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface UnitsMultiple : Annotation
{
	[Signature("()Ljava/lang/Class<+Ljava/lang/annotation/Annotation;>;")]
	virtual Class quantity();

	[AnnotationDefault(new object[]
	{
		(byte)101,
		"Lorg/checkerframework/checker/units/qual/Prefix;",
		"one"
	})]
	virtual Prefix prefix();
}
