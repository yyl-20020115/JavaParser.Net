using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.collect;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Iterable<TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 19, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)19,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.lang.Iterable" })]
internal interface SortedIterable : Iterable
{
	[Signature("()Ljava/util/Comparator<-TT;>;")]
	virtual Comparator comparator();

	[Signature("()Ljava/util/Iterator<TT;>;")]
	Iterator iterator();
}
