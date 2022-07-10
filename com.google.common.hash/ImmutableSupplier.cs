using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.util.function;

namespace com.google.common.hash;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<TT;>;")]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/hash/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.base.Supplier" })]
internal interface ImmutableSupplier : com.google.common.@base.Supplier, java.util.function.Supplier
{
}
