using IKVM.Attributes;
using java.lang;
using java.lang.annotation;

namespace org.checkerframework.framework.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[AnnotationAttribute("org.checkerframework.framework.qual.UpperBoundForAttribute")]
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
			"ANNOTATION_TYPE"
		}
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface UpperBoundFor : Annotation
{
	[AnnotationDefault(new object[] { (byte)91 })]
	virtual TypeKind[] typeKinds();

	[AnnotationDefault(new object[] { (byte)91 })]
	[Signature("()[Ljava/lang/Class<*>;")]
	virtual Class[] types();
}
