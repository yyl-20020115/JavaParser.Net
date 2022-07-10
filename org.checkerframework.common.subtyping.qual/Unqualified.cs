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
[Retention(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Retention;",
	"value",
	new object[]
	{
		(byte)101,
		"Ljava/lang/annotation/RetentionPolicy, IKVM/OpenJDK/Core, Version=8/1/5717/0, Culture=neutral, PublicKeyToken=13235d27fcbfff58;",
		"SOURCE"
	}
})]
[Target(new object[]
{
	(byte)64,
	"Ljava/lang/annotation/Target;",
	"value",
	new object[] { (byte)91 }
})]
[InvisibleQualifier(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/InvisibleQualifier;"
})]
[SubtypeOf(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/SubtypeOf;",
	"value",
	new object[] { (byte)91 }
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface Unqualified : Annotation
{
}
