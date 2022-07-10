using com.google.errorprone.annotations;
using IKVM.Attributes;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;")]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use Interners.new*Interner"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public interface Interner
{
	[Signature("(TE;)TE;")]
	virtual object intern(object obj);
}
