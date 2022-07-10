using IKVM.Attributes;
using java.lang;

namespace com.google.common.util.concurrent;

[Signature("<I:Ljava/lang/Object;O:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 20, 0, 0,
	17, 1, 0, 0, 0, 20, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)20,
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
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public interface AsyncFunction
{
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("(TI;)Lcom/google/common/util/concurrent/ListenableFuture<TO;>;")]
	virtual ListenableFuture apply([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object obj);
}
