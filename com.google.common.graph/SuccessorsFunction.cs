using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Ljava/lang/Object;")]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Implement with a lambda, or use GraphBuilder to build a Graph with the desired edges"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
public interface SuccessorsFunction
{
	[Signature("(TN;)Ljava/lang/Iterable<+TN;>;")]
	virtual Iterable successors(object obj);
}
