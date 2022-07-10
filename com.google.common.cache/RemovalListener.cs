using IKVM.Attributes;
using java.lang;

namespace com.google.common.cache;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[FunctionalInterface(new object[]
{
	(byte)64,
	"Ljava/lang/FunctionalInterface;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/cache/ElementTypesAreNonnullByDefault;"
})]
public interface RemovalListener
{
	[Signature("(Lcom/google/common/cache/RemovalNotification<TK;TV;>;)V")]
	virtual void onRemoval(RemovalNotification rn);
}
