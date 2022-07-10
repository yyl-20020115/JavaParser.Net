using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/SuccessorsFunction<TN;>;Lcom/google/common/graph/PredecessorsFunction<TN;>;")]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use NetworkBuilder to create a real instance"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.SuccessorsFunction", "com.google.common.graph.PredecessorsFunction" })]
public interface Network : SuccessorsFunction, PredecessorsFunction
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static Iterable successors(Network P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Esuccessors(P_0, P_1);
		}

		public unsafe static Iterable predecessors(Network P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Epredecessors(P_0, P_1);
		}
	}

	[Signature("(TE;)Lcom/google/common/graph/EndpointPair<TN;>;")]
	virtual EndpointPair incidentNodes(object obj);

	[Signature("()Ljava/util/Set<TE;>;")]
	virtual Set edges();

	[Signature("()Ljava/util/Set<TN;>;")]
	virtual Set nodes();

	virtual bool allowsParallelEdges();

	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	virtual ElementOrder nodeOrder();

	virtual bool isDirected();

	virtual bool allowsSelfLoops();

	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	virtual Set adjacentNodes(object obj);

	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	Set predecessors(object obj);

	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	Set successors(object obj);

	[Signature("()Lcom/google/common/graph/Graph<TN;>;")]
	virtual Graph asGraph();

	[Signature("()Lcom/google/common/graph/ElementOrder<TE;>;")]
	virtual ElementOrder edgeOrder();

	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	virtual Set incidentEdges(object obj);

	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	virtual Set inEdges(object obj);

	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	virtual Set outEdges(object obj);

	[Signature("(TN;)I")]
	virtual int degree(object obj);

	[Signature("(TN;)I")]
	virtual int inDegree(object obj);

	[Signature("(TN;)I")]
	virtual int outDegree(object obj);

	[Signature("(TE;)Ljava/util/Set<TE;>;")]
	virtual Set adjacentEdges(object obj);

	[Signature("(TN;TN;)Ljava/util/Set<TE;>;")]
	virtual Set edgesConnecting(object obj1, object obj2);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Set<TE;>;")]
	virtual Set edgesConnecting(EndpointPair ep);

	[Signature("(TN;TN;)Ljava/util/Optional<TE;>;")]
	virtual Optional edgeConnecting(object obj1, object obj2);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Optional<TE;>;")]
	virtual Optional edgeConnecting(EndpointPair ep);

	[Signature("(TN;TN;)TE;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object edgeConnectingOrNull(object obj1, object obj2);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)TE;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object edgeConnectingOrNull(EndpointPair ep);

	[Signature("(TN;TN;)Z")]
	virtual bool hasEdgeConnecting(object obj1, object obj2);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	virtual bool hasEdgeConnecting(EndpointPair ep);

	virtual bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual int hashCode();

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Iterable _003Cbridge_003Esuccessors(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(105)]
	static Iterable _003Cdefault_003E_003Cbridge_003Esuccessors(Network P_0, object P_1)
	{
		Set result = P_0.successors(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Iterable _003Cbridge_003Epredecessors(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(105)]
	static Iterable _003Cdefault_003E_003Cbridge_003Epredecessors(Network P_0, object P_1)
	{
		Set result = P_0.predecessors(P_1);
		_ = null;
		return result;
	}
}
