using IKVM.Attributes;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/Network<TN;TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.Network" })]
public interface MutableNetwork : Network, SuccessorsFunction, PredecessorsFunction
{
	[Signature("(TN;)Z")]
	virtual bool addNode(object obj);

	[Signature("(TN;TN;TE;)Z")]
	virtual bool addEdge(object obj1, object obj2, object obj3);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;TE;)Z")]
	virtual bool addEdge(EndpointPair ep, object obj);

	[Signature("(TN;)Z")]
	virtual bool removeNode(object obj);

	[Signature("(TE;)Z")]
	virtual bool removeEdge(object obj);
}
