using IKVM.Attributes;
using java.lang;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/concurrent/ScheduledFuture<TV;>;Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 14, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)14,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.ScheduledFuture", "com.google.common.util.concurrent.ListenableFuture" })]
public interface ListenableScheduledFuture : ScheduledFuture, Delayed, Comparable, Future, ListenableFuture
{
}
