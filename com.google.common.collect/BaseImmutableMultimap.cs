using System.Runtime.CompilerServices;
using IKVM.Attributes;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultimap<TK;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class BaseImmutableMultimap : AbstractMultimap
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(26)]
	internal BaseImmutableMultimap()
	{
	}
}
