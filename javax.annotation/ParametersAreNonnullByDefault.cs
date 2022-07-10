using IKVM.Attributes;
using java.lang.annotation;
using javax.annotation.meta;

namespace javax.annotation;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("javax.annotation.ParametersAreNonnullByDefaultAttribute")]
[Documented(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Documented;"
})]
[Nonnull(new object[]
{
	(byte)64,
	"Ljavax/annotation/Nonnull;"
})]
[TypeQualifierDefault(new object[]
{
	(byte)64,
	"Ljavax/annotation/meta/TypeQualifierDefault;",
	"value",
	new object[]
	{
		(byte)91,
		new object[]
		{
			(byte)101,
			"Ljava/lang/annotation/ElementType, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
			"PARAMETER"
		}
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
public interface ParametersAreNonnullByDefault : Annotation
{
}
