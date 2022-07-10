using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal abstract class GwtFuturesCatchingSpecialization : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(27)]
	internal GwtFuturesCatchingSpecialization()
	{
	}
}
