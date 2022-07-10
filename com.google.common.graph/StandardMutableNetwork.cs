using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Lcom/google/common/graph/StandardNetwork<TN;TE;>;Lcom/google/common/graph/MutableNetwork<TN;TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.MutableNetwork" })]
internal sealed class StandardMutableNetwork : StandardNetwork, MutableNetwork, Network, SuccessorsFunction, PredecessorsFunction
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/NetworkBuilder<-TN;-TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 191, 105 })]
	internal StandardMutableNetwork(NetworkBuilder P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Lcom/google/common/graph/NetworkConnections<TN;TE;>;")]
	[LineNumberTable(new byte[] { 22, 103, 120 })]
	private NetworkConnections addNodeInternal(object P_0)
	{
		NetworkConnections networkConnections = newConnections();
		Preconditions.checkState(nodeConnections.put(P_0, networkConnections) == null);
		return networkConnections;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/NetworkConnections<TN;TE;>;")]
	[LineNumberTable(new byte[] { 118, 104, 104, 103, 103, 104, 103, 229, 58 })]
	private NetworkConnections newConnections()
	{
		object obj = (isDirected() ? ((object)((!allowsParallelEdges()) ? ((AbstractDirectedNetworkConnections)DirectedNetworkConnections.of()) : ((AbstractDirectedNetworkConnections)DirectedMultiNetworkConnections.of()))) : ((object)((!allowsParallelEdges()) ? ((AbstractUndirectedNetworkConnections)UndirectedNetworkConnections.of()) : ((AbstractUndirectedNetworkConnections)UndirectedMultiNetworkConnections.of()))));
		NetworkConnections result = ((obj == null) ? null : ((obj as NetworkConnections) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;TE;)Z")]
	[LineNumberTable(new byte[]
	{
		30, 108, 108, 140, 105, 104, 105, 98, 45, 229,
		70, 130, 114, 104, 100, 56, 229, 70, 104, 104,
		178, 99, 136, 104, 115, 100, 137, 106, 110
	})]
	public virtual bool addEdge(object P_0, object P_1, object P_2)
	{
		Preconditions.checkNotNull(P_0, (object)"nodeU");
		Preconditions.checkNotNull(P_1, (object)"nodeV");
		Preconditions.checkNotNull(P_2, (object)"edge");
		if (containsEdge(P_2))
		{
			EndpointPair endpointPair = incidentNodes(P_2);
			EndpointPair endpointPair2 = EndpointPair.of(this, P_0, P_1);
			Preconditions.checkArgument(endpointPair.equals(endpointPair2), "Edge %s already exists between the following nodes: %s, so it cannot be reused to connect the following nodes: %s.", P_2, endpointPair, endpointPair2);
			return false;
		}
		NetworkConnections networkConnections = (NetworkConnections)nodeConnections.get(P_0);
		if (!allowsParallelEdges())
		{
			Preconditions.checkArgument((networkConnections == null || !networkConnections.successors().contains(P_1)) ? true : false, "Nodes %s and %s are already connected by a different edge. To construct a graph that allows parallel edges, call allowsParallelEdges(true) on the Builder.", P_0, P_1);
		}
		int num = (Object.instancehelper_equals(P_0, P_1) ? 1 : 0);
		if (!allowsSelfLoops())
		{
			Preconditions.checkArgument((num == 0) ? true : false, "Cannot add self-loop edge on node %s, as self-loops are not allowed. To construct a graph that allows self-loops, call allowsSelfLoops(true) on the Builder.", P_0);
		}
		if (networkConnections == null)
		{
			networkConnections = addNodeInternal(P_0);
		}
		networkConnections.addOutEdge(P_2, P_1);
		NetworkConnections networkConnections2 = (NetworkConnections)nodeConnections.get(P_1);
		if (networkConnections2 == null)
		{
			networkConnections2 = addNodeInternal(P_1);
		}
		networkConnections2.addInEdge(P_2, P_0, (byte)num != 0);
		edgeToReferenceNode.put(P_2, P_0);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(new byte[]
	{
		100, 140, 109, 99, 194, 124, 104, 124, 104, 125,
		109
	})]
	public virtual bool removeEdge(object P_0)
	{
		Preconditions.checkNotNull(P_0, (object)"edge");
		object obj = edgeToReferenceNode.get(P_0);
		if (obj == null)
		{
			return false;
		}
		NetworkConnections networkConnections = (NetworkConnections)java.util.Objects.requireNonNull((NetworkConnections)nodeConnections.get(obj));
		object obj2 = networkConnections.adjacentNode(P_0);
		NetworkConnections networkConnections2 = (NetworkConnections)java.util.Objects.requireNonNull((NetworkConnections)nodeConnections.get(obj2));
		networkConnections.removeOutEdge(P_0);
		networkConnections2.removeInEdge(P_0, (allowsSelfLoops() && Object.instancehelper_equals(obj, obj2)) ? true : false);
		edgeToReferenceNode.remove(P_0);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Z")]
	[LineNumberTable(new byte[] { 5, 140, 105, 162, 104 })]
	public virtual bool addNode(object P_0)
	{
		Preconditions.checkNotNull(P_0, (object)"node");
		if (containsNode(P_0))
		{
			return false;
		}
		addNodeInternal(P_0);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;TE;)Z")]
	[LineNumberTable(new byte[] { 74, 103 })]
	public virtual bool addEdge(EndpointPair P_0, object P_1)
	{
		validateEndpoints(P_0);
		bool result = addEdge(P_0.nodeU(), P_0.nodeV(), P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Z")]
	[LineNumberTable(new byte[]
	{
		81, 140, 114, 99, 226, 69, 127, 1, 104, 98,
		109
	})]
	public virtual bool removeNode(object P_0)
	{
		Preconditions.checkNotNull(P_0, (object)"node");
		NetworkConnections networkConnections = (NetworkConnections)nodeConnections.get(P_0);
		if (networkConnections == null)
		{
			return false;
		}
		UnmodifiableIterator unmodifiableIterator = ImmutableList.copyOf(networkConnections.incidentEdges()).iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			object obj = ((Iterator)unmodifiableIterator).next();
			removeEdge(obj);
		}
		nodeConnections.remove(P_0);
		return true;
	}

	Iterable Network.Network_003A_003Asuccessors(object P_0)
	{
		return ((StandardNetwork)this).successors(P_0);
	}

	Iterable Network.Network_003A_003Apredecessors(object P_0)
	{
		return ((StandardNetwork)this).predecessors(P_0);
	}
}
