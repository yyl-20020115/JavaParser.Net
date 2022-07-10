using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Ljava/lang/Object;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal interface NetworkConnections
{
	[Signature("()Ljava/util/Set<TN;>;")]
	virtual Set adjacentNodes();

	[Signature("()Ljava/util/Set<TN;>;")]
	virtual Set predecessors();

	[Signature("()Ljava/util/Set<TN;>;")]
	virtual Set successors();

	[Signature("()Ljava/util/Set<TE;>;")]
	virtual Set incidentEdges();

	[Signature("()Ljava/util/Set<TE;>;")]
	virtual Set inEdges();

	[Signature("()Ljava/util/Set<TE;>;")]
	virtual Set outEdges();

	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	virtual Set edgesConnecting(object P_0);

	[Signature("(TE;)TN;")]
	virtual object adjacentNode(object P_0);

	[Signature("(TE;Z)TN;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object removeInEdge(object P_0, bool P_1);

	[Signature("(TE;)TN;")]
	virtual object removeOutEdge(object P_0);

	[Signature("(TE;TN;Z)V")]
	virtual void addInEdge(object P_0, object P_1, bool P_2);

	[Signature("(TE;TN;)V")]
	virtual void addOutEdge(object P_0, object P_1);
}
