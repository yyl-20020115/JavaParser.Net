using IKVM.Attributes;
using java.lang.annotation;

namespace javax.annotation;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("javax.annotation.TaintedAttribute")]
[Documented(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Documented;"
})]
[Untainted(new object[]
{
	(byte)64,
	"Ljavax/annotation/Untainted;",
	"when",
	new object[]
	{
		(byte)101,
		"Ljavax/annotation/meta/When, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;",
		"MAYBE"
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
public interface Tainted : Annotation
{
}
