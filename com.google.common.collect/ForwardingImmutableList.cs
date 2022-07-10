using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ForwardingImmutableList : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	private ForwardingImmutableList()
	{
	}
}
