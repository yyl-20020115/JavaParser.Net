using IKVM.Attributes;
using java.lang;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 18, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)18,
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
public interface AsyncCallable
{
	[Throws(new string[] { "java.lang.Exception" })]
	[Signature("()Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
	virtual ListenableFuture call();
}
