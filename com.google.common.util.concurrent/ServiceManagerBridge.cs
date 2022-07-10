using com.google.common.collect;
using IKVM.Attributes;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal interface ServiceManagerBridge
{
	[Signature("()Lcom/google/common/collect/ImmutableMultimap<Lcom/google/common/util/concurrent/Service$State;Lcom/google/common/util/concurrent/Service;>;")]
	virtual ImmutableMultimap servicesByState();
}
