using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/SuccessorsFunction<TN;>;Lcom/google/common/graph/PredecessorsFunction<TN;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.SuccessorsFunction", "com.google.common.graph.PredecessorsFunction" })]
internal interface BaseGraph : SuccessorsFunction, PredecessorsFunction
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static Iterable successors(BaseGraph P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Esuccessors(P_0, P_1);
		}

		public unsafe static Iterable predecessors(BaseGraph P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Epredecessors(P_0, P_1);
		}
	}

	[Signature("()Ljava/util/Set<TN;>;")]
	virtual Set nodes();

	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	Set successors(object P_0);

	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	Set predecessors(object P_0);

	[Signature("()Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	virtual Set edges();

	virtual bool isDirected();

	virtual bool allowsSelfLoops();

	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	virtual ElementOrder nodeOrder();

	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	virtual ElementOrder incidentEdgeOrder();

	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	virtual Set adjacentNodes(object P_0);

	[Signature("(TN;)Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	virtual Set incidentEdges(object P_0);

	[Signature("(TN;)I")]
	virtual int degree(object P_0);

	[Signature("(TN;)I")]
	virtual int inDegree(object P_0);

	[Signature("(TN;)I")]
	virtual int outDegree(object P_0);

	[Signature("(TN;TN;)Z")]
	virtual bool hasEdgeConnecting(object P_0, object P_1);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	virtual bool hasEdgeConnecting(EndpointPair P_0);

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	Iterable successors(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(27)]
	static Iterable _003Cdefault_003Esuccessors(BaseGraph P_0, object P_1)
	{
		Set result = P_0.successors(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	Iterable predecessors(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(27)]
	static Iterable _003Cdefault_003Epredecessors(BaseGraph P_0, object P_1)
	{
		Set result = P_0.predecessors(P_1);
		_ = null;
		return result;
	}
}
