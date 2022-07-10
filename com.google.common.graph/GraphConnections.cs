using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal interface GraphConnections
{
	[Signature("()Ljava/util/Set<TN;>;")]
	virtual Set adjacentNodes();

	[Signature("()Ljava/util/Set<TN;>;")]
	virtual Set predecessors();

	[Signature("()Ljava/util/Set<TN;>;")]
	virtual Set successors();

	[Signature("(TN;)Ljava/util/Iterator<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	virtual Iterator incidentEdgeIterator(object P_0);

	[Signature("(TN;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object value(object P_0);

	[Signature("(TN;)V")]
	virtual void removePredecessor(object P_0);

	[Signature("(TN;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object removeSuccessor(object P_0);

	[Signature("(TN;TV;)V")]
	virtual void addPredecessor(object P_0, object P_1);

	[Signature("(TN;TV;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object addSuccessor(object P_0, object P_1);
}
