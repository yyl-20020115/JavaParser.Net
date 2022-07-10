using IKVM.Attributes;
using java.lang.annotation;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("javax.annotation.SyntaxAttribute")]
[Documented(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Documented;"
})]
[TypeQualifier(new object[]
{
	(byte)64,
	"Ljavax/annotation/meta/TypeQualifier;",
	"applicableTo",
	new object[]
	{
		(byte)99,
		"Ljava/lang/CharSequence+__Interface, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;"
	}
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
public interface Syntax : Annotation
{
	virtual string value();

	[AnnotationDefault(new object[]
	{
		(byte)101,
		"Ljavax/annotation/meta/When;",
		"ALWAYS"
	})]
	virtual When when();
}
