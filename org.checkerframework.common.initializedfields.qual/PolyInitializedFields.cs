using IKVM.Attributes;
using java.lang.annotation;
using org.checkerframework.framework.qual;

namespace org.checkerframework.common.initializedfields.qual;

[Modifiers(Modifiers.Public | Modifiers.Interface | Modifiers.Abstract | Modifiers.Annotation)]
[PolymorphicQualifier(new object[]
{
	(byte)64,
	"Lorg/checkerframework/framework/qual/PolymorphicQualifier;",
	"value",
	new object[]
	{
		(byte)99,
		"Lorg/checkerframework/common/initializedfields/qual/InitializedFields, javaparser, Version=0/0/0/0, Culture=neutral, PublicKeyToken=null;"
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
[Implements(new string[] { "java.lang.annotation.Annotation" })]
public interface PolyInitializedFields : Annotation
{
}
