using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/graph/AbstractValueGraph<TN;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal class StandardValueGraph : AbstractValueGraph
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/graph/IncidentEdgeSet<TN;>;")]
	[EnclosingMethod(null, "incidentEdges", "(Ljava.lang.Object;)Ljava.util.Set;")]
	internal new class _1 : IncidentEdgeSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal GraphConnections val_0024connections;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(123)]
		internal _1(StandardValueGraph P_0, BaseGraph P_1, object P_2, GraphConnections P_3)
		{
			val_0024connections = P_3;
			base._002Ector(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
		[LineNumberTable(126)]
		public override Iterator iterator()
		{
			Iterator result = val_0024connections.incidentEdgeIterator(node);
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new bool m_isDirected;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private new bool m_allowsSelfLoops;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/graph/ElementOrder<TN;>;")]
	private new ElementOrder m_nodeOrder;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/graph/MapIteratorCache<TN;Lcom/google/common/graph/GraphConnections<TN;TV;>;>;")]
	internal MapIteratorCache nodeConnections;

	internal new long edgeCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/AbstractGraphBuilder<-TN;>;Ljava/util/Map<TN;Lcom/google/common/graph/GraphConnections<TN;TV;>;>;J)V")]
	[LineNumberTable(new byte[] { 22, 104, 108, 108, 145, 97, 104, 104, 107, 108 })]
	internal StandardValueGraph(AbstractGraphBuilder P_0, Map P_1, long P_2)
	{
		this.m_isDirected = P_0.directed;
		this.m_allowsSelfLoops = P_0.allowsSelfLoops;
		this.m_nodeOrder = P_0.nodeOrder.cast();
		nodeConnections = ((!(P_1 is TreeMap)) ? new MapIteratorCache(P_1) : new MapRetrievalCache(P_1));
		this.edgeCount = Graphs.checkNonNegative(P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("(TN;)Lcom/google/common/graph/GraphConnections<TN;TV;>;")]
	[LineNumberTable(new byte[] { 112, 114, 99, 103, 159, 41 })]
	private GraphConnections checkedConnections(object P_0)
	{
		GraphConnections graphConnections = (GraphConnections)nodeConnections.get(P_0);
		if (graphConnections == null)
		{
			Preconditions.checkNotNull(P_0);
			string text = String.valueOf(P_0);
			int num = 38 + String.instancehelper_length(String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("Node ").append(text).append(" is not an element of this graph.")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return graphConnections;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("(TN;TN;)Z")]
	[LineNumberTable(new byte[] { 125, 114 })]
	private bool hasEdgeConnectingInternal(object P_0, object P_1)
	{
		GraphConnections graphConnections = (GraphConnections)nodeConnections.get(P_0);
		return (graphConnections != null && graphConnections.successors().contains(P_1)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("(TN;TN;TV;)TV;")]
	[LineNumberTable(new byte[] { 160, 67, 114, 142, 99, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object edgeValueOrDefaultInternal(object P_0, object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_2)
	{
		object obj = ((GraphConnections)nodeConnections.get(P_0))?.value(P_1);
		if (obj == null)
		{
			return P_2;
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(116)]
	public override Set successors(object P_0)
	{
		Set result = checkedConnections(P_0).successors();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(111)]
	public override Set predecessors(object P_0)
	{
		Set result = checkedConnections(P_0).predecessors();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/AbstractGraphBuilder<-TN;>;)V")]
	[LineNumberTable(new byte[] { 8, 176, 52, 7, 231, 69 })]
	internal StandardValueGraph(AbstractGraphBuilder P_0)
		: this(P_0, P_0.nodeOrder.createMap(((Integer)P_0.expectedNodeCount.or(Integer.valueOf(10))).intValue()), 0L)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(86)]
	public override Set nodes()
	{
		Set result = nodeConnections.unmodifiableKeySet();
		_ = null;
		return result;
	}

	public override bool isDirected()
	{
		return this.m_isDirected;
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(106)]
	public override Set adjacentNodes(object P_0)
	{
		Set result = checkedConnections(P_0).adjacentNodes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	[LineNumberTable(new byte[] { 71, 136 })]
	public override Set incidentEdges(object P_0)
	{
		GraphConnections graphConnections = checkedConnections(P_0);
		_1 result = new _1(this, this, P_0, graphConnections);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Z")]
	[LineNumberTable(133)]
	public override bool hasEdgeConnecting(object P_0, object P_1)
	{
		bool result = hasEdgeConnectingInternal(Preconditions.checkNotNull(P_0), Preconditions.checkNotNull(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	[LineNumberTable(new byte[] { 88, 103, 107, 54 })]
	public override bool hasEdgeConnecting(EndpointPair P_0)
	{
		Preconditions.checkNotNull(P_0);
		return (((AbstractBaseGraph)this).isOrderingCompatible(P_0) && hasEdgeConnectingInternal(P_0.nodeU(), P_0.nodeV())) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;TV;)TV;")]
	[LineNumberTable(146)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object edgeValueOrDefault(object P_0, object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_2)
	{
		object result = edgeValueOrDefaultInternal(Preconditions.checkNotNull(P_0), Preconditions.checkNotNull(P_1), P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;TV;)TV;")]
	[LineNumberTable(new byte[] { 102, 103 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object edgeValueOrDefault(EndpointPair P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		((AbstractBaseGraph)this).validateEndpoints(P_0);
		object result = edgeValueOrDefaultInternal(P_0.nodeU(), P_0.nodeV(), P_1);
		_ = null;
		return result;
	}

	protected internal override long edgeCount()
	{
		return this.edgeCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Z")]
	[LineNumberTable(171)]
	internal bool containsNode([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = nodeConnections.containsKey(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Iterable successors(object P_0)
	{
		Set result = this.successors(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Iterable predecessors(object P_0)
	{
		Set result = this.predecessors(P_0);
		_ = null;
		return result;
	}
}
