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
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/graph/StandardValueGraph<TN;TV;>;")]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;",
	"containerOf",
	new object[]
	{
		(byte)91,
		"N",
		"V"
	}
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
public sealed class ImmutableValueGraph : StandardValueGraph
{
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	public class Builder : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/graph/MutableValueGraph<TN;TV;>;")]
		private MutableValueGraph mutableValueGraph;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/ValueGraphBuilder<TN;TV;>;)V")]
		[LineNumberTable(new byte[] { 80, 168, 98, 121 })]
		internal Builder(ValueGraphBuilder P_0)
		{
			mutableValueGraph = P_0.copy().incidentEdgeOrder(ElementOrder.stable()).build();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Lcom/google/common/graph/ImmutableValueGraph$Builder<TN;TV;>;")]
		[LineNumberTable(new byte[] { 96, 109 })]
		public virtual Builder addNode(object node)
		{
			mutableValueGraph.addNode(node);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;TV;)Lcom/google/common/graph/ImmutableValueGraph$Builder<TN;TV;>;")]
		[LineNumberTable(new byte[] { 118, 111 })]
		public virtual Builder putEdgeValue(object nodeU, object nodeV, object value)
		{
			mutableValueGraph.putEdgeValue(nodeU, nodeV, value);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;TV;)Lcom/google/common/graph/ImmutableValueGraph$Builder<TN;TV;>;")]
		[LineNumberTable(new byte[] { 160, 79, 110 })]
		public virtual Builder putEdgeValue(EndpointPair endpoints, object value)
		{
			mutableValueGraph.putEdgeValue(endpoints, value);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/ImmutableValueGraph<TN;TV;>;")]
		[LineNumberTable(202)]
		public virtual ImmutableValueGraph build()
		{
			ImmutableValueGraph result = copyOf(mutableValueGraph);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : com.google.common.@base.Function
	{
		private readonly ValueGraph arg_00241;

		private readonly object arg_00242;

		internal ___003C_003EAnon0(ValueGraph P_0, object P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object apply(object P_0)
		{
			object result = lambda_0024connectionsOf_00240(arg_00241, arg_00242, P_0);
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
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ValueGraph<TN;TV;>;)Lcom/google/common/graph/ImmutableValueGraph<TN;TV;>;")]
	[LineNumberTable(new byte[] { 6, 104, 104, 8 })]
	public static ImmutableValueGraph copyOf(ValueGraph graph)
	{
		ImmutableValueGraph result = ((!(graph is ImmutableValueGraph)) ? new ImmutableValueGraph(graph) : ((ImmutableValueGraph)graph));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ValueGraph<TN;TV;>;)Lcom/google/common/collect/ImmutableMap<TN;Lcom/google/common/graph/GraphConnections<TN;TV;>;>;")]
	[LineNumberTable(new byte[] { 36, 102, 123, 111, 98 })]
	private static ImmutableMap getNodeConnections(ValueGraph P_0)
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
	[Signature("(Lcom/google/common/graph/ValueGraph<TN;TV;>;)V")]
	[LineNumberTable(new byte[] { 1, 127, 1 })]
	private ImmutableValueGraph(ValueGraph P_0)
		: base(ValueGraphBuilder.from(P_0), getNodeConnections(P_0), P_0.edges().size())
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ValueGraph<TN;TV;>;TN;)Lcom/google/common/graph/GraphConnections<TN;TV;>;")]
	[LineNumberTable(new byte[] { 44, 205, 104, 99, 38, 135, 98, 43, 229, 61 })]
	private static GraphConnections connectionsOf(ValueGraph P_0, object P_1)
	{
		com.google.common.@base.Function function = new ___003C_003EAnon0(P_0, P_1);
		object obj = ((!P_0.isDirected()) ? ((object)UndirectedGraphConnections.ofImmutable(Maps.asMap(P_0.adjacentNodes(P_1), function))) : ((object)DirectedGraphConnections.ofImmutable(P_1, P_0.incidentEdges(P_1), function)));
		GraphConnections result = ((obj == null) ? null : ((obj as GraphConnections) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ImmutableGraph<TN;>;")]
	[LineNumberTable(78)]
	public new virtual ImmutableGraph asGraph()
	{
		ImmutableGraph result = new ImmutableGraph(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(97)]
	private static object lambda_0024connectionsOf_00240(ValueGraph P_0, object P_1, object P_2)
	{
		object result = java.util.Objects.requireNonNull(P_0.edgeValueOrDefault(P_1, P_2, null));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ImmutableValueGraph<TN;TV;>;)Lcom/google/common/graph/ImmutableValueGraph<TN;TV;>;")]
	[LineNumberTable(68)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static ImmutableValueGraph copyOf(ImmutableValueGraph graph)
	{
		return (ImmutableValueGraph)Preconditions.checkNotNull(graph);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	[LineNumberTable(73)]
	public override ElementOrder incidentEdgeOrder()
	{
		ElementOrder result = ElementOrder.stable();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object edgeValueOrDefault(EndpointPair ep, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		object result = base.edgeValueOrDefault(ep, obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object edgeValueOrDefault(object obj1, object obj2, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj3)
	{
		object result = base.edgeValueOrDefault(obj1, obj2, obj3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override bool hasEdgeConnecting(EndpointPair ep)
	{
		bool result = base.hasEdgeConnecting(ep);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override bool hasEdgeConnecting(object obj1, object obj2)
	{
		bool result = base.hasEdgeConnecting(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override Set incidentEdges(object obj)
	{
		Set result = base.incidentEdges(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override Set successors(object obj)
	{
		Set result = base.successors(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override Set predecessors(object obj)
	{
		Set result = base.predecessors(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override Set adjacentNodes(object obj)
	{
		Set result = base.adjacentNodes(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override ElementOrder nodeOrder()
	{
		ElementOrder result = base.nodeOrder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override bool allowsSelfLoops()
	{
		bool result = base.allowsSelfLoops();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override bool isDirected()
	{
		bool result = base.isDirected();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	public override Set nodes()
	{
		Set result = base.nodes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(44)]
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
		return ((StandardValueGraph)this).successors(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|predecessors", "(Ljava.lang.Object;)Ljava.lang.Iterable;")]
	public Iterable _003Cbridge_003Epredecessors(object P_0)
	{
		return ((StandardValueGraph)this).predecessors(P_0);
	}
}
