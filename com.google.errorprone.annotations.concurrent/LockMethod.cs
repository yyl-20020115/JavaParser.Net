using IKVM.Attributes;
using java.lang.annotation;

namespace com.google.errorprone.annotations.concurrent;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
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
		"CLASS"
	}
})]
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface LockMethod : Annotation
{
	virtual string[] value();
}
