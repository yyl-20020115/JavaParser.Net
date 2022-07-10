using com.google.common.@base;
using IKVM.Attributes;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/Multimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 22, 0, 0,
	17, 1, 0, 0, 0, 22, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)22,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.Multimap" })]
internal interface FilteredMultimap : Multimap
{
	[Signature("()Lcom/google/common/collect/Multimap<TK;TV;>;")]
	virtual Multimap unfiltered();

	[Signature("()Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;")]
	virtual Predicate entryPredicate();
}
