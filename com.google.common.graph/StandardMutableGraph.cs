using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/ForwardingGraph<TN;>;Lcom/google/common/graph/MutableGraph<TN;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.MutableGraph" })]
internal sealed class StandardMutableGraph : ForwardingGraph, MutableGraph, Graph, BaseGraph, SuccessorsFunction, PredecessorsFunction
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/graph/MutableValueGraph<TN;Lcom/google/common/graph/GraphConstants$Presence;>;")]
	private MutableValueGraph backingValueGraph;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/AbstractGraphBuilder<-TN;>;)V")]
	[LineNumberTable(new byte[] { 159, 178, 104, 108 })]
	internal StandardMutableGraph(AbstractGraphBuilder P_0)
	{
		backingValueGraph = new StandardMutableValueGraph(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Z")]
	[LineNumberTable(52)]
	public virtual bool putEdge(object P_0, object P_1)
	{
		return backingValueGraph.putEdgeValue(P_0, P_1, GraphConstants.Presence.EDGE_EXISTS) == null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Z")]
	[LineNumberTable(68)]
	public virtual bool removeEdge(object P_0, object P_1)
	{
		return backingValueGraph.removeEdge(P_0, P_1) != null;
	}

	[Signature("()Lcom/google/common/graph/BaseGraph<TN;>;")]
	internal override BaseGraph @delegate()
	{
		return backingValueGraph;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Z")]
	[LineNumberTable(47)]
	public virtual bool addNode(object P_0)
	{
		bool result = backingValueGraph.addNode(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	[LineNumberTable(new byte[] { 7, 103 })]
	public virtual bool putEdge(EndpointPair P_0)
	{
		((AbstractBaseGraph)this).validateEndpoints(P_0);
		bool result = putEdge(P_0.nodeU(), P_0.nodeV());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Z")]
	[LineNumberTable(63)]
	public virtual bool removeNode(object P_0)
	{
		bool result = backingValueGraph.removeNode(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	[LineNumberTable(new byte[] { 23, 103 })]
	public virtual bool removeEdge(EndpointPair P_0)
	{
		((AbstractBaseGraph)this).validateEndpoints(P_0);
		bool result = removeEdge(P_0.nodeU(), P_0.nodeV());
		_ = null;
		return result;
	}

	Iterable Graph.Graph_003A_003Asuccessors(object P_0)
	{
		return ((ForwardingGraph)this).successors(P_0);
	}

	Iterable Graph.Graph_003A_003Apredecessors(object P_0)
	{
		return ((ForwardingGraph)this).predecessors(P_0);
	}
}
