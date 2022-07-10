using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Lcom/google/common/graph/AbstractNetwork<TN;TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal class StandardNetwork : AbstractNetwork
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new bool m_isDirected;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new bool m_allowsParallelEdges;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new bool m_allowsSelfLoops;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/graph/ElementOrder<TN;>;")]
	private new ElementOrder m_nodeOrder;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/graph/ElementOrder<TE;>;")]
	private new ElementOrder m_edgeOrder;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/graph/MapIteratorCache<TN;Lcom/google/common/graph/NetworkConnections<TN;TE;>;>;")]
	internal MapIteratorCache nodeConnections;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/graph/MapIteratorCache<TE;TN;>;")]
	internal MapIteratorCache edgeToReferenceNode;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/NetworkBuilder<-TN;-TE;>;Ljava/util/Map<TN;Lcom/google/common/graph/NetworkConnections<TN;TE;>;>;Ljava/util/Map<TE;TN;>;)V")]
	[LineNumberTable(new byte[]
	{
		31, 104, 108, 108, 108, 113, 177, 97, 104, 104,
		107, 108
	})]
	internal StandardNetwork(NetworkBuilder P_0, Map P_1, Map P_2)
	{
		this.m_isDirected = ((AbstractGraphBuilder)P_0).directed;
		this.m_allowsParallelEdges = P_0.allowsParallelEdges;
		this.m_allowsSelfLoops = ((AbstractGraphBuilder)P_0).allowsSelfLoops;
		this.m_nodeOrder = ((AbstractGraphBuilder)P_0).nodeOrder.cast();
		this.m_edgeOrder = P_0.edgeOrder.cast();
		nodeConnections = ((!(P_1 is TreeMap)) ? new MapIteratorCache(P_1) : new MapRetrievalCache(P_1));
		edgeToReferenceNode = new MapIteratorCache(P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Lcom/google/common/graph/NetworkConnections<TN;TE;>;")]
	[LineNumberTable(new byte[] { 160, 66, 114, 99, 103, 159, 0 })]
	internal NetworkConnections checkedConnections(object P_0)
	{
		NetworkConnections networkConnections = (NetworkConnections)nodeConnections.get(P_0);
		if (networkConnections == null)
		{
			Preconditions.checkNotNull(P_0);
			string s = String.format("Node %s is not an element of this graph.", P_0);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return networkConnections;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TN;")]
	[LineNumberTable(new byte[] { 160, 75, 109, 99, 103, 159, 0 })]
	internal object checkedReferenceNode(object P_0)
	{
		object obj = edgeToReferenceNode.get(P_0);
		if (obj == null)
		{
			Preconditions.checkNotNull(P_0);
			string s = String.format("Edge %s is not an element of this graph.", P_0);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Z")]
	[LineNumberTable(198)]
	internal bool containsNode(object P_0)
	{
		bool result = nodeConnections.containsKey(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(176)]
	public override Set successors(object P_0)
	{
		Set result = checkedConnections(P_0).successors();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(171)]
	public override Set predecessors(object P_0)
	{
		Set result = checkedConnections(P_0).predecessors();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/NetworkBuilder<-TN;-TE;>;)V")]
	[LineNumberTable(new byte[] { 17, 176, 52, 147, 249, 60, 231, 69 })]
	internal StandardNetwork(NetworkBuilder P_0)
		: this(P_0, ((AbstractGraphBuilder)P_0).nodeOrder.createMap(((Integer)((AbstractGraphBuilder)P_0).expectedNodeCount.or(Integer.valueOf(10))).intValue()), P_0.edgeOrder.createMap(((Integer)P_0.expectedEdgeCount.or(Integer.valueOf(20))).intValue()))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(98)]
	public override Set nodes()
	{
		Set result = nodeConnections.unmodifiableKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(103)]
	public override Set edges()
	{
		Set result = edgeToReferenceNode.unmodifiableKeySet();
		_ = null;
		return result;
	}

	public override bool isDirected()
	{
		return this.m_isDirected;
	}

	public override bool allowsParallelEdges()
	{
		return this.m_allowsParallelEdges;
	}

	public override bool allowsSelfLoops()
	{
		return this.m_allowsSelfLoops;
	}

	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	public override ElementOrder nodeOrder()
	{
		return this.m_nodeOrder;
	}

	[Signature("()Lcom/google/common/graph/ElementOrder<TE;>;")]
	public override ElementOrder edgeOrder()
	{
		return this.m_edgeOrder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(133)]
	public override Set incidentEdges(object P_0)
	{
		Set result = checkedConnections(P_0).incidentEdges();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Lcom/google/common/graph/EndpointPair<TN;>;")]
	[LineNumberTable(new byte[] { 88, 136, 127, 3 })]
	public override EndpointPair incidentNodes(object P_0)
	{
		object obj = checkedReferenceNode(P_0);
		object obj2 = ((NetworkConnections)java.util.Objects.requireNonNull((NetworkConnections)nodeConnections.get(obj))).adjacentNode(P_0);
		EndpointPair result = EndpointPair.of(this, obj, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(146)]
	public override Set adjacentNodes(object P_0)
	{
		Set result = checkedConnections(P_0).adjacentNodes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(new byte[] { 101, 104, 108, 136, 114 })]
	public override Set edgesConnecting(object P_0, object P_1)
	{
		NetworkConnections networkConnections = checkedConnections(P_0);
		if (!this.m_allowsSelfLoops && P_0 == P_1)
		{
			ImmutableSet result = ImmutableSet.of();
			_ = null;
			return result;
		}
		Preconditions.checkArgument(containsNode(P_1), "Node %s is not an element of this graph.", P_1);
		Set result2 = networkConnections.edgesConnecting(P_1);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(161)]
	public override Set inEdges(object P_0)
	{
		Set result = checkedConnections(P_0).inEdges();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(166)]
	public override Set outEdges(object P_0)
	{
		Set result = checkedConnections(P_0).outEdges();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(202)]
	internal bool containsEdge(object P_0)
	{
		bool result = edgeToReferenceNode.containsKey(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	public override Iterable successors(object P_0)
	{
		Set result = this.successors(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	public override Iterable predecessors(object P_0)
	{
		Set result = this.predecessors(P_0);
		_ = null;
		return result;
	}
}
