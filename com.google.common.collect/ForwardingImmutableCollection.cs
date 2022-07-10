using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.collect;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal class ForwardingImmutableCollection : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(29)]
	private ForwardingImmutableCollection()
	{
	}
}
