using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/graph/StandardValueGraph<TN;TV;>;Lcom/google/common/graph/MutableValueGraph<TN;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.MutableValueGraph" })]
internal sealed class StandardMutableValueGraph : StandardValueGraph, MutableValueGraph, ValueGraph, BaseGraph, SuccessorsFunction, PredecessorsFunction
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/graph/ElementOrder<TN;>;")]
	private new ElementOrder m_incidentEdgeOrder;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/AbstractGraphBuilder<-TN;>;)V")]
	[LineNumberTable(new byte[] { 1, 105, 113 })]
	internal StandardMutableValueGraph(AbstractGraphBuilder P_0)
		: base(P_0)
	{
		this.m_incidentEdgeOrder = P_0.incidentEdgeOrder.cast();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Lcom/google/common/graph/GraphConnections<TN;TV;>;")]
	[LineNumberTable(new byte[] { 30, 103, 120 })]
	private GraphConnections addNodeInternal(object P_0)
	{
		GraphConnections graphConnections = newConnections();
		Preconditions.checkState(nodeConnections.put(P_0, graphConnections) == null);
		return graphConnections;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/GraphConnections<TN;TV;>;")]
	[LineNumberTable(new byte[] { 160, 74, 104, 109, 11 })]
	private GraphConnections newConnections()
	{
		object obj = ((!isDirected()) ? ((object)UndirectedGraphConnections.of(this.m_incidentEdgeOrder)) : ((object)DirectedGraphConnections.of(this.m_incidentEdgeOrder)));
		GraphConnections result = ((obj == null) ? null : ((obj as GraphConnections) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;TV;)TV;")]
	[LineNumberTable(new byte[]
	{
		39, 108, 108, 140, 104, 184, 114, 99, 136, 105,
		114, 99, 136, 104, 99, 156
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object putEdgeValue(object P_0, object P_1, object P_2)
	{
		Preconditions.checkNotNull(P_0, (object)"nodeU");
		Preconditions.checkNotNull(P_1, (object)"nodeV");
		Preconditions.checkNotNull(P_2, (object)"value");
		if (!allowsSelfLoops())
		{
			Preconditions.checkArgument((!Object.instancehelper_equals(P_0, P_1)) ? true : false, "Cannot add self-loop edge on node %s, as self-loops are not allowed. To construct a graph that allows self-loops, call allowsSelfLoops(true) on the Builder.", P_0);
		}
		GraphConnections graphConnections = (GraphConnections)nodeConnections.get(P_0);
		if (graphConnections == null)
		{
			graphConnections = addNodeInternal(P_0);
		}
		object obj = graphConnections.addSuccessor(P_1, P_2);
		GraphConnections graphConnections2 = (GraphConnections)nodeConnections.get(P_1);
		if (graphConnections2 == null)
		{
			graphConnections2 = addNodeInternal(P_1);
		}
		graphConnections2.addPredecessor(P_0, P_2);
		if (obj == null)
		{
			long num = base.edgeCount + 1;
			base.edgeCount = num;
			Graphs.checkPositive(num);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)TV;")]
	[LineNumberTable(new byte[]
	{
		112, 108, 140, 114, 114, 102, 162, 104, 99, 103,
		156
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object removeEdge(object P_0, object P_1)
	{
		Preconditions.checkNotNull(P_0, (object)"nodeU");
		Preconditions.checkNotNull(P_1, (object)"nodeV");
		GraphConnections graphConnections = (GraphConnections)nodeConnections.get(P_0);
		GraphConnections graphConnections2 = (GraphConnections)nodeConnections.get(P_1);
		if (graphConnections == null || graphConnections2 == null)
		{
			return null;
		}
		object obj = graphConnections.removeSuccessor(P_1);
		if (obj != null)
		{
			graphConnections2.removePredecessor(P_0);
			long num = base.edgeCount - 1;
			base.edgeCount = num;
			Graphs.checkNonNegative(num);
		}
		return obj;
	}

	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	public override ElementOrder incidentEdgeOrder()
	{
		return this.m_incidentEdgeOrder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Z")]
	[LineNumberTable(new byte[] { 13, 140, 105, 162, 104 })]
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
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;TV;)TV;")]
	[LineNumberTable(new byte[] { 67, 103 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object putEdgeValue(EndpointPair P_0, object P_1)
	{
		((AbstractBaseGraph)this).validateEndpoints(P_0);
		object result = putEdgeValue(P_0.nodeU(), P_0.nodeV(), P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Z")]
	[LineNumberTable(new byte[]
	{
		74, 140, 114, 99, 162, 136, 105, 103, 207, 155,
		127, 2, 111, 98, 104, 155, 103, 63, 1, 165,
		111, 130, 109, 108
	})]
	public virtual bool removeNode(object P_0)
	{
		Preconditions.checkNotNull(P_0, (object)"node");
		GraphConnections graphConnections = (GraphConnections)nodeConnections.get(P_0);
		if (graphConnections == null)
		{
			return false;
		}
		if (allowsSelfLoops() && graphConnections.removeSuccessor(P_0) != null)
		{
			graphConnections.removePredecessor(P_0);
			base.edgeCount--;
		}
		Iterator iterator = graphConnections.successors().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			((GraphConnections)java.util.Objects.requireNonNull((GraphConnections)nodeConnections.getWithoutCaching(obj))).removePredecessor(P_0);
			base.edgeCount--;
		}
		if (isDirected())
		{
			iterator = graphConnections.predecessors().iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				Preconditions.checkState(((GraphConnections)java.util.Objects.requireNonNull((GraphConnections)nodeConnections.getWithoutCaching(obj))).removeSuccessor(P_0) != null);
				base.edgeCount--;
			}
		}
		nodeConnections.remove(P_0);
		Graphs.checkNonNegative(base.edgeCount);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)TV;")]
	[LineNumberTable(new byte[] { 160, 69, 103 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object removeEdge(EndpointPair P_0)
	{
		((AbstractBaseGraph)this).validateEndpoints(P_0);
		object result = removeEdge(P_0.nodeU(), P_0.nodeV());
		_ = null;
		return result;
	}

	Iterable ValueGraph.ValueGraph_003A_003Asuccessors(object P_0)
	{
		return ((StandardValueGraph)this).successors(P_0);
	}

	Iterable ValueGraph.ValueGraph_003A_003Apredecessors(object P_0)
	{
		return ((StandardValueGraph)this).predecessors(P_0);
	}
}
