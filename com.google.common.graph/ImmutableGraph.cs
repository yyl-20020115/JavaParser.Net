using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/ForwardingGraph<TN;>;")]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;",
	"containerOf",
	new object[]
	{
		(byte)91,
		"N"
	}
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
public class ImmutableGraph : ForwardingGraph
{
	[Signature("<N:Ljava/lang/Object;>Ljava/lang/Object;")]
	public class Builder : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/graph/MutableGraph<TN;>;")]
		private MutableGraph mutableGraph;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/GraphBuilder<TN;>;)V")]
		[LineNumberTable(new byte[] { 83, 168, 123 })]
		internal Builder(GraphBuilder P_0)
		{
			mutableGraph = P_0.copy().incidentEdgeOrder(ElementOrder.stable()).build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Lcom/google/common/graph/ImmutableGraph$Builder<TN;>;")]
		[LineNumberTable(new byte[] { 98, 109 })]
		public virtual Builder addNode(object node)
		{
			mutableGraph.addNode(node);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;)Lcom/google/common/graph/ImmutableGraph$Builder<TN;>;")]
		[LineNumberTable(new byte[] { 117, 110 })]
		public virtual Builder putEdge(object nodeU, object nodeV)
		{
			mutableGraph.putEdge(nodeU, nodeV);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Lcom/google/common/graph/ImmutableGraph$Builder<TN;>;")]
		[LineNumberTable(new byte[] { 160, 76, 109 })]
		public virtual Builder putEdge(EndpointPair endpoints)
		{
			mutableGraph.putEdge(endpoints);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/ImmutableGraph<TN;>;")]
		[LineNumberTable(198)]
		public virtual ImmutableGraph build()
		{
			ImmutableGraph result = copyOf(mutableGraph);
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/graph/BaseGraph<TN;>;")]
	private BaseGraph backingGraph;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;)Lcom/google/common/graph/ImmutableGraph<TN;>;")]
	[LineNumberTable(new byte[]
	{
		9,
		104,
		104,
		129,
		byte.MaxValue,
		4,
		60
	})]
	public static ImmutableGraph copyOf(Graph graph)
	{
		ImmutableGraph result = ((!(graph is ImmutableGraph)) ? new ImmutableGraph(new StandardValueGraph(GraphBuilder.from(graph), getNodeConnections(graph), graph.edges().size())) : ((ImmutableGraph)graph));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;)Lcom/google/common/collect/ImmutableMap<TN;Lcom/google/common/graph/GraphConnections<TN;Lcom/google/common/graph/GraphConstants$Presence;>;>;")]
	[LineNumberTable(new byte[] { 36, 102, 123, 111, 98 })]
	private static ImmutableMap getNodeConnections(Graph P_0)
	{
		ImmutableMap.Builder builder = ImmutableMap.builder();
		Iterator iterator = P_0.nodes().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			builder.put(obj, connectionsOf(P_0, obj));
		}
		ImmutableMap result = builder.buildOrThrow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/BaseGraph<TN;>;)V")]
	[LineNumberTable(new byte[] { 3, 104, 103 })]
	internal ImmutableGraph(BaseGraph P_0)
	{
		backingGraph = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;TN;)Lcom/google/common/graph/GraphConnections<TN;Lcom/google/common/graph/GraphConstants$Presence;>;")]
	[LineNumberTable(new byte[] { 45, 101, 102, 104, 112, 98, 43, 5 })]
	private static GraphConnections connectionsOf(Graph P_0, object P_1)
	{
		Function function = Functions.constant(GraphConstants.Presence.EDGE_EXISTS);
		object obj = ((!P_0.isDirected()) ? ((object)UndirectedGraphConnections.ofImmutable(Maps.asMap(P_0.adjacentNodes(P_1), function))) : ((object)DirectedGraphConnections.ofImmutable(P_1, P_0.incidentEdges(P_1), function)));
		GraphConnections result = ((obj == null) ? null : ((obj as GraphConnections) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/ImmutableGraph<TN;>;)Lcom/google/common/graph/ImmutableGraph<TN;>;")]
	[LineNumberTable(73)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static ImmutableGraph copyOf(ImmutableGraph graph)
	{
		return (ImmutableGraph)Preconditions.checkNotNull(graph);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	[LineNumberTable(78)]
	public override ElementOrder incidentEdgeOrder()
	{
		ElementOrder result = ElementOrder.stable();
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/graph/BaseGraph<TN;>;")]
	internal override BaseGraph @delegate()
	{
		return backingGraph;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override bool hasEdgeConnecting(EndpointPair ep)
	{
		bool result = base.hasEdgeConnecting(ep);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override bool hasEdgeConnecting(object obj1, object obj2)
	{
		bool result = base.hasEdgeConnecting(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override int outDegree(object obj)
	{
		int result = base.outDegree(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override int inDegree(object obj)
	{
		int result = base.inDegree(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override int degree(object obj)
	{
		int result = base.degree(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Set incidentEdges(object obj)
	{
		Set result = base.incidentEdges(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Set successors(object obj)
	{
		Set result = base.successors(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Set predecessors(object obj)
	{
		Set result = base.predecessors(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Set adjacentNodes(object obj)
	{
		Set result = base.adjacentNodes(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override ElementOrder nodeOrder()
	{
		ElementOrder result = base.nodeOrder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override bool allowsSelfLoops()
	{
		bool result = base.allowsSelfLoops();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override bool isDirected()
	{
		bool result = base.isDirected();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Set nodes()
	{
		Set result = base.nodes();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|edgeCount", "()J")]
	protected internal new long edgeCount()
	{
		return ((ForwardingGraph)this).edgeCount();
	}

	[HideFromJava]
	protected internal new long _003Cnonvirtual_003E0()
	{
		return base.edgeCount();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|successors", "(Ljava.lang.Object;)Ljava.lang.Iterable;")]
	public Iterable _003Cbridge_003Esuccessors(object P_0)
	{
		return ((ForwardingGraph)this).successors(P_0);
	}

	[HideFromJava]
	protected internal Iterable _003Cnonvirtual_003E1(object P_0)
	{
		return base.successors(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|predecessors", "(Ljava.lang.Object;)Ljava.lang.Iterable;")]
	public Iterable _003Cbridge_003Epredecessors(object P_0)
	{
		return ((ForwardingGraph)this).predecessors(P_0);
	}

	[HideFromJava]
	protected internal Iterable _003Cnonvirtual_003E2(object P_0)
	{
		return base.predecessors(P_0);
	}
}
