using IKVM.Attributes;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/ValueGraph<TN;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.ValueGraph" })]
public interface MutableValueGraph : ValueGraph, BaseGraph, SuccessorsFunction, PredecessorsFunction
{
	[Signature("(TN;)Z")]
	virtual bool addNode(object obj);

	[Signature("(TN;TN;TV;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object putEdgeValue(object obj1, object obj2, object obj3);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;TV;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object putEdgeValue(EndpointPair ep, object obj);

	[Signature("(TN;)Z")]
	virtual bool removeNode(object obj);

	[Signature("(TN;TN;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object removeEdge(object obj1, object obj2);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object removeEdge(EndpointPair ep);
}
