using IKVM.Attributes;
using java.lang;
using java.util.function;
using javax.annotation;

namespace com.google.common.@base;

[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/function/Function<TF;TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 23, 0, 0,
	17, 1, 0, 0, 0, 23, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)23,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[FunctionalInterface(new object[]
{
	(byte)64,
	"Ljava/lang/FunctionalInterface;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.function.Function" })]
public interface Function : java.util.function.Function
{
	[Signature("(TF;)TT;")]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/base/ParametricNullness;"
	})]
	object apply([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/base/ParametricNullness;"
	})] object obj);

	virtual bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);
}
