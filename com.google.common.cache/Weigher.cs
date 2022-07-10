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
public interface Weigher
{
	[Signature("(TK;TV;)I")]
	virtual int weigh(object obj1, object obj2);
}
