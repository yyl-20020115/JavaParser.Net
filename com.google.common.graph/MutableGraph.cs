using IKVM.Attributes;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/Graph<TN;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.Graph" })]
public interface MutableGraph : Graph, BaseGraph, SuccessorsFunction, PredecessorsFunction
{
	[Signature("(TN;TN;)Z")]
	virtual bool putEdge(object obj1, object obj2);

	[Signature("(TN;)Z")]
	virtual bool addNode(object obj);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	virtual bool putEdge(EndpointPair ep);

	[Signature("(TN;)Z")]
	virtual bool removeNode(object obj);

	[Signature("(TN;TN;)Z")]
	virtual bool removeEdge(object obj1, object obj2);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	virtual bool removeEdge(EndpointPair ep);
}
