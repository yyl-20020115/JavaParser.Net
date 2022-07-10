using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Lcom/google/common/graph/StandardNetwork<TN;TE;>;")]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;",
	"containerOf",
	new object[]
	{
		(byte)91,
		"N",
		"E"
	}
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
public sealed class ImmutableNetwork : StandardNetwork
{
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Ljava/lang/Object;")]
	public class Builder : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/graph/MutableNetwork<TN;TE;>;")]
		private MutableNetwork mutableNetwork;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/NetworkBuilder<TN;TE;>;)V")]
		[LineNumberTable(new byte[] { 107, 104, 108 })]
		internal Builder(NetworkBuilder P_0)
		{
			mutableNetwork = P_0.build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Lcom/google/common/graph/ImmutableNetwork$Builder<TN;TE;>;")]
		[LineNumberTable(new byte[] { 120, 109 })]
		public virtual Builder addNode(object node)
		{
			mutableNetwork.addNode(node);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;TE;)Lcom/google/common/graph/ImmutableNetwork$Builder<TN;TE;>;")]
		[LineNumberTable(new byte[] { 160, 83, 111 })]
		public virtual Builder addEdge(object nodeU, object nodeV, object edge)
		{
			mutableNetwork.addEdge(nodeU, nodeV, edge);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;TE;)Lcom/google/common/graph/ImmutableNetwork$Builder<TN;TE;>;")]
		[LineNumberTable(new byte[] { 160, 114, 110 })]
		public virtual Builder addEdge(EndpointPair endpoints, object edge)
		{
			mutableNetwork.addEdge(endpoints, edge);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/ImmutableNetwork<TN;TE;>;")]
		[LineNumberTable(237)]
		public virtual ImmutableNetwork build()
		{
			ImmutableNetwork result = copyOf(mutableNetwork);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : com.google.common.@base.Function
	{
		private readonly Network arg_00241;

		internal ___003C_003EAnon0(Network P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			object result = lambda_0024sourceNodeFn_00240(arg_00241, P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : com.google.common.@base.Function
	{
		private readonly Network arg_00241;

		internal ___003C_003EAnon1(Network P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			object result = lambda_0024targetNodeFn_00241(arg_00241, P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : com.google.common.@base.Function
	{
		private readonly Network arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon2(Network P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			object result = lambda_0024adjacentNodeFn_00242(arg_00241, arg_00242, P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;)Lcom/google/common/graph/ImmutableNetwork<TN;TE;>;")]
	[LineNumberTable(new byte[] { 9, 104, 104, 8 })]
	public static ImmutableNetwork copyOf(Network network)
	{
		ImmutableNetwork result = ((!(network is ImmutableNetwork)) ? new ImmutableNetwork(network) : ((ImmutableNetwork)network));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;)Ljava/util/Map<TN;Lcom/google/common/graph/NetworkConnections<TN;TE;>;>;")]
	[LineNumberTable(new byte[] { 33, 102, 123, 111, 98 })]
	private static Map getNodeConnections(Network P_0)
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
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;)Ljava/util/Map<TE;TN;>;")]
	[LineNumberTable(new byte[] { 44, 102, 123, 116, 98 })]
	private static Map getEdgeToReferenceNode(Network P_0)
	{
		ImmutableMap.Builder builder = ImmutableMap.builder();
		Iterator iterator = P_0.edges().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			builder.put(obj, P_0.incidentNodes(obj).nodeU());
		}
		ImmutableMap result = builder.buildOrThrow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/Network<TN;TE;>;)V")]
	[LineNumberTable(new byte[] { 3, 98, 49, 135 })]
	private ImmutableNetwork(Network P_0)
		: base(NetworkBuilder.from(P_0), getNodeConnections(P_0), getEdgeToReferenceNode(P_0))
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;TN;)Lcom/google/common/graph/NetworkConnections<TN;TE;>;")]
	[LineNumberTable(new byte[]
	{
		52, 104, 115, 115, 110, 104, 106, 10, 193, 98,
		114, 104, 104, 8
	})]
	private static NetworkConnections connectionsOf(Network P_0, object P_1)
	{
		Map map;
		if (P_0.isDirected())
		{
			map = Maps.asMap(P_0.inEdges(P_1), sourceNodeFn(P_0));
			Map map2 = Maps.asMap(P_0.outEdges(P_1), targetNodeFn(P_0));
			int num = P_0.edgesConnecting(P_1, P_1).size();
			AbstractDirectedNetworkConnections result = ((!P_0.allowsParallelEdges()) ? ((AbstractDirectedNetworkConnections)DirectedNetworkConnections.ofImmutable(map, map2, num)) : ((AbstractDirectedNetworkConnections)DirectedMultiNetworkConnections.ofImmutable(map, map2, num)));
			_ = null;
			return result;
		}
		map = Maps.asMap(P_0.incidentEdges(P_1), adjacentNodeFn(P_0, P_1));
		AbstractUndirectedNetworkConnections result2 = ((!P_0.allowsParallelEdges()) ? ((AbstractUndirectedNetworkConnections)UndirectedNetworkConnections.ofImmutable(map)) : ((AbstractUndirectedNetworkConnections)UndirectedMultiNetworkConnections.ofImmutable(map)));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;)Lcom/google/common/base/Function<TE;TN;>;")]
	[LineNumberTable(119)]
	private static com.google.common.@base.Function sourceNodeFn(Network P_0)
	{
		return new ___003C_003EAnon0(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;)Lcom/google/common/base/Function<TE;TN;>;")]
	[LineNumberTable(123)]
	private static com.google.common.@base.Function targetNodeFn(Network P_0)
	{
		return new ___003C_003EAnon1(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;TN;)Lcom/google/common/base/Function<TE;TN;>;")]
	[LineNumberTable(127)]
	private static com.google.common.@base.Function adjacentNodeFn(Network P_0, object P_1)
	{
		return new ___003C_003EAnon2(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ImmutableGraph<TN;>;")]
	[LineNumberTable(76)]
	public new virtual ImmutableGraph asGraph()
	{
		ImmutableGraph result = new ImmutableGraph(base.asGraph());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(119)]
	private static object lambda_0024sourceNodeFn_00240(Network P_0, object P_1)
	{
		object result = P_0.incidentNodes(P_1).source();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(123)]
	private static object lambda_0024targetNodeFn_00241(Network P_0, object P_1)
	{
		object result = P_0.incidentNodes(P_1).target();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(127)]
	private static object lambda_0024adjacentNodeFn_00242(Network P_0, object P_1, object P_2)
	{
		object result = P_0.incidentNodes(P_2).adjacentNode(P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/ImmutableNetwork<TN;TE;>;)Lcom/google/common/graph/ImmutableNetwork<TN;TE;>;")]
	[LineNumberTable(71)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static ImmutableNetwork copyOf(ImmutableNetwork network)
	{
		return (ImmutableNetwork)Preconditions.checkNotNull(network);
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
	public override Set outEdges(object obj)
	{
		Set result = base.outEdges(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Set inEdges(object obj)
	{
		Set result = base.inEdges(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(46)]
	public override Set edgesConnecting(object obj1, object obj2)
	{
		Set result = base.edgesConnecting(obj1, obj2);
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
	public override EndpointPair incidentNodes(object obj)
	{
		EndpointPair result = base.incidentNodes(obj);
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
	public override ElementOrder edgeOrder()
	{
		ElementOrder result = base.edgeOrder();
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
	public override bool allowsParallelEdges()
	{
		bool result = base.allowsParallelEdges();
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
	public override Set edges()
	{
		Set result = base.edges();
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(46)]
	public virtual Graph _003Cbridge_003EasGraph()
	{
		ImmutableGraph result = asGraph();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|successors", "(Ljava.lang.Object;)Ljava.lang.Iterable;")]
	public Iterable _003Cbridge_003Esuccessors(object P_0)
	{
		return ((StandardNetwork)this).successors(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|predecessors", "(Ljava.lang.Object;)Ljava.lang.Iterable;")]
	public Iterable _003Cbridge_003Epredecessors(object P_0)
	{
		return ((StandardNetwork)this).predecessors(P_0);
	}
}
