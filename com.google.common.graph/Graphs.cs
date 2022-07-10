using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.graph;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
public sealed class Graphs : java.lang.Object
{
	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/graph/Graphs$NodeVisitState;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class NodeVisitState : java.lang.Enum
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static NodeVisitState PENDING;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static NodeVisitState COMPLETE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static NodeVisitState[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(642)]
		private NodeVisitState(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(642)]
		private static NodeVisitState[] _0024values()
		{
			return new NodeVisitState[2] { PENDING, COMPLETE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(642)]
		public static NodeVisitState[] values()
		{
			return (NodeVisitState[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(642)]
		public static NodeVisitState valueOf(string P_0)
		{
			return (NodeVisitState)java.lang.Enum.valueOf(ClassLiteral<NodeVisitState>.Value, P_0);
		}

		[LineNumberTable(new byte[] { 162, 17, 112, 16 })]
		static NodeVisitState()
		{
			PENDING = new NodeVisitState("PENDING", 0);
			COMPLETE = new NodeVisitState("COMPLETE", 1);
			_0024VALUES = _0024values();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/ForwardingGraph<TN;>;")]
	internal class TransposedGraph : ForwardingGraph
	{
		[SpecialName]
		[Signature("Lcom/google/common/graph/IncidentEdgeSet<TN;>;")]
		[EnclosingMethod(null, "incidentEdges", "(Ljava.lang.Object;)Ljava.util.Set;")]
		internal new class _1 : IncidentEdgeSet
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Lcom/google/common/graph/EndpointPair<TN;>;Lcom/google/common/graph/EndpointPair<TN;>;>;")]
			[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
			[Implements(new string[] { "com.google.common.base.Function" })]
			internal class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal TransposedGraph._1 this_00241;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Lcom/google/common/graph/EndpointPair<TN;>;")]
				[LineNumberTable(295)]
				public virtual EndpointPair apply(EndpointPair P_0)
				{
					EndpointPair result = EndpointPair.of(this_00241.this_00240.@delegate(), P_0.nodeV(), P_0.nodeU());
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(292)]
				internal _1(TransposedGraph._1 P_0)
				{
					this_00241 = P_0;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(292)]
				public virtual object apply(object P_0)
				{
					EndpointPair result = apply((EndpointPair)P_0);
					_ = null;
					return result;
				}

				[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
				public virtual java.util.function.Function compose(java.util.function.Function P_0)
				{
					return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
				}

				[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
				public virtual java.util.function.Function andThen(java.util.function.Function P_0)
				{
					return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
				}

				bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
				{
					return java.lang.Object.instancehelper_equals(this, P_0);
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal TransposedGraph this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(287)]
			internal _1(TransposedGraph P_0, BaseGraph P_1, object P_2)
			{
				this_00240 = P_0;
				base._002Ector(P_1, P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
			[LineNumberTable(new byte[] { 160, 176, 102, 59 })]
			public override Iterator iterator()
			{
				Iterator result = Iterators.transform(this_00240.@delegate().incidentEdges(node).iterator(), new _1(this));
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/graph/Graph<TN;>;")]
		private Graph graph;

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(263)]
		internal static Graph access_0024000(TransposedGraph P_0)
		{
			return P_0.graph;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/Graph<TN;>;)V")]
		[LineNumberTable(new byte[] { 160, 152, 104, 103 })]
		internal TransposedGraph(Graph P_0)
		{
			graph = P_0;
		}

		[Signature("()Lcom/google/common/graph/Graph<TN;>;")]
		internal new virtual Graph @delegate()
		{
			return graph;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(282)]
		public override Set successors(object P_0)
		{
			Set result = @delegate().predecessors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(277)]
		public override Set predecessors(object P_0)
		{
			Set result = @delegate().successors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
		[LineNumberTable(287)]
		public override Set incidentEdges(object P_0)
		{
			_1 result = new _1(this, this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)I")]
		[LineNumberTable(304)]
		public override int inDegree(object P_0)
		{
			int result = @delegate().outDegree(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)I")]
		[LineNumberTable(309)]
		public override int outDegree(object P_0)
		{
			int result = @delegate().inDegree(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;)Z")]
		[LineNumberTable(314)]
		public override bool hasEdgeConnecting(object P_0, object P_1)
		{
			bool result = @delegate().hasEdgeConnecting(P_1, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
		[LineNumberTable(319)]
		public override bool hasEdgeConnecting(EndpointPair P_0)
		{
			bool result = @delegate().hasEdgeConnecting(transpose(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(263)]
		internal override BaseGraph @delegate()
		{
			Graph result = @delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(263)]
		public override Iterable successors(object P_0)
		{
			Set result = this.successors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(263)]
		public override Iterable predecessors(object P_0)
		{
			Set result = this.predecessors(P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Lcom/google/common/graph/ForwardingNetwork<TN;TE;>;")]
	internal class TransposedNetwork : ForwardingNetwork
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/graph/Network<TN;TE;>;")]
		private Network network;

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(390)]
		internal static Network access_0024200(TransposedNetwork P_0)
		{
			return P_0.network;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/Network<TN;TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 23, 104, 103 })]
		internal TransposedNetwork(Network P_0)
		{
			network = P_0;
		}

		[Signature("()Lcom/google/common/graph/Network<TN;TE;>;")]
		internal override Network @delegate()
		{
			return network;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(409)]
		public override Set successors(object P_0)
		{
			Set result = @delegate().predecessors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(404)]
		public override Set predecessors(object P_0)
		{
			Set result = @delegate().successors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)I")]
		[LineNumberTable(414)]
		public override int inDegree(object P_0)
		{
			int result = @delegate().outDegree(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)I")]
		[LineNumberTable(419)]
		public override int outDegree(object P_0)
		{
			int result = @delegate().inDegree(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TE;>;")]
		[LineNumberTable(424)]
		public override Set inEdges(object P_0)
		{
			Set result = @delegate().outEdges(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TE;>;")]
		[LineNumberTable(429)]
		public override Set outEdges(object P_0)
		{
			Set result = @delegate().inEdges(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/graph/EndpointPair<TN;>;")]
		[LineNumberTable(new byte[] { 161, 64, 109 })]
		public override EndpointPair incidentNodes(object P_0)
		{
			EndpointPair endpointPair = @delegate().incidentNodes(P_0);
			EndpointPair result = EndpointPair.of(network, endpointPair.nodeV(), endpointPair.nodeU());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;)Ljava/util/Set<TE;>;")]
		[LineNumberTable(440)]
		public override Set edgesConnecting(object P_0, object P_1)
		{
			Set result = @delegate().edgesConnecting(P_1, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Set<TE;>;")]
		[LineNumberTable(445)]
		public override Set edgesConnecting(EndpointPair P_0)
		{
			Set result = @delegate().edgesConnecting(transpose(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;)Ljava/util/Optional<TE;>;")]
		[LineNumberTable(450)]
		public override java.util.Optional edgeConnecting(object P_0, object P_1)
		{
			java.util.Optional result = @delegate().edgeConnecting(P_1, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Optional<TE;>;")]
		[LineNumberTable(455)]
		public override java.util.Optional edgeConnecting(EndpointPair P_0)
		{
			java.util.Optional result = @delegate().edgeConnecting(transpose(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;)TE;")]
		[LineNumberTable(461)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object edgeConnectingOrNull(object P_0, object P_1)
		{
			object result = @delegate().edgeConnectingOrNull(P_1, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)TE;")]
		[LineNumberTable(467)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object edgeConnectingOrNull(EndpointPair P_0)
		{
			object result = @delegate().edgeConnectingOrNull(transpose(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;)Z")]
		[LineNumberTable(472)]
		public override bool hasEdgeConnecting(object P_0, object P_1)
		{
			bool result = @delegate().hasEdgeConnecting(P_1, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
		[LineNumberTable(477)]
		public override bool hasEdgeConnecting(EndpointPair P_0)
		{
			bool result = @delegate().hasEdgeConnecting(transpose(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(390)]
		public override Iterable successors(object P_0)
		{
			Set result = this.successors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(390)]
		public override Iterable predecessors(object P_0)
		{
			Set result = this.predecessors(P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/graph/ForwardingValueGraph<TN;TV;>;")]
	internal class TransposedValueGraph : ForwardingValueGraph
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/graph/ValueGraph<TN;TV;>;")]
		private ValueGraph graph;

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(325)]
		internal static ValueGraph access_0024100(TransposedValueGraph P_0)
		{
			return P_0.graph;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/ValueGraph<TN;TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 214, 104, 103 })]
		internal TransposedValueGraph(ValueGraph P_0)
		{
			graph = P_0;
		}

		[Signature("()Lcom/google/common/graph/ValueGraph<TN;TV;>;")]
		internal override ValueGraph @delegate()
		{
			return graph;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(344)]
		public override Set successors(object P_0)
		{
			Set result = @delegate().predecessors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(339)]
		public override Set predecessors(object P_0)
		{
			Set result = @delegate().successors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)I")]
		[LineNumberTable(349)]
		public override int inDegree(object P_0)
		{
			int result = @delegate().outDegree(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)I")]
		[LineNumberTable(354)]
		public override int outDegree(object P_0)
		{
			int result = @delegate().inDegree(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;)Z")]
		[LineNumberTable(359)]
		public override bool hasEdgeConnecting(object P_0, object P_1)
		{
			bool result = @delegate().hasEdgeConnecting(P_1, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
		[LineNumberTable(364)]
		public override bool hasEdgeConnecting(EndpointPair P_0)
		{
			bool result = @delegate().hasEdgeConnecting(transpose(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;)Ljava/util/Optional<TV;>;")]
		[LineNumberTable(369)]
		public override java.util.Optional edgeValue(object P_0, object P_1)
		{
			java.util.Optional result = @delegate().edgeValue(P_1, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Optional<TV;>;")]
		[LineNumberTable(374)]
		public override java.util.Optional edgeValue(EndpointPair P_0)
		{
			java.util.Optional result = @delegate().edgeValue(transpose(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;TN;TV;)TV;")]
		[LineNumberTable(380)]
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
			object result = @delegate().edgeValueOrDefault(P_1, P_0, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;TV;)TV;")]
		[LineNumberTable(386)]
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
			object result = @delegate().edgeValueOrDefault(transpose(P_0), P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(325)]
		public override Iterable successors(object P_0)
		{
			Set result = this.successors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(325)]
		public override Iterable predecessors(object P_0)
		{
			Set result = this.predecessors(P_0);
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 245, 114 })]
	internal static int checkNonNegative(int P_0)
	{
		Preconditions.checkArgument(P_0 >= 0, "Not true that %s is non-negative.", P_0);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 1, 111 })]
	internal static int checkPositive(int P_0)
	{
		Preconditions.checkArgument(P_0 > 0, "Not true that %s is positive.", P_0);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;Ljava/util/Map<Ljava/lang/Object;Lcom/google/common/graph/Graphs$NodeVisitState;>;TN;TN;)Z")]
	[LineNumberTable(new byte[]
	{
		58, 109, 104, 130, 104, 162, 109, 124, 110, 103,
		130, 98, 109
	})]
	private static bool subgraphHasCycle(Graph P_0, Map P_1, object P_2, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_3)
	{
		NodeVisitState nodeVisitState = (NodeVisitState)P_1.get(P_2);
		if (nodeVisitState == NodeVisitState.COMPLETE)
		{
			return false;
		}
		if (nodeVisitState == NodeVisitState.PENDING)
		{
			return true;
		}
		P_1.put(P_2, NodeVisitState.PENDING);
		Iterator iterator = P_0.successors(P_2).iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (canTraverseWithoutReusingEdge(P_0, obj, P_3) && subgraphHasCycle(P_0, P_1, obj, P_2))
			{
				return true;
			}
		}
		P_1.put(P_2, NodeVisitState.COMPLETE);
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;)Z")]
	[LineNumberTable(new byte[]
	{
		12, 108, 99, 130, 118, 162, 97, 112, 123, 107,
		130, 98
	})]
	public static bool hasCycle(Graph graph)
	{
		int num = graph.edges().size();
		if (num == 0)
		{
			return false;
		}
		if (!graph.isDirected() && num >= graph.nodes().size())
		{
			return true;
		}
		HashMap hashMap = Maps.newHashMapWithExpectedSize(graph.nodes().size());
		Iterator iterator = graph.nodes().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (subgraphHasCycle(graph, hashMap, obj, null))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/Graph<*>;Ljava/lang/Object;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[] { 85, 113, 194 })]
	private static bool canTraverseWithoutReusingEdge(Graph P_0, object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_2)
	{
		if (P_0.isDirected() || !com.google.common.@base.Objects.equal(P_2, P_1))
		{
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(new byte[] { 160, 84, 119 })]
	public static Set reachableNodes(Graph graph, object node)
	{
		Preconditions.checkArgument(graph.nodes().contains(node), "Node %s is not an element of this graph.", node);
		ImmutableSet result = ImmutableSet.copyOf(Traverser.forGraph(graph).breadthFirst(node));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(50)]
	private Graphs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/Network<**>;)Z")]
	[LineNumberTable(new byte[] { 40, 105, 104, 124, 130 })]
	public static bool hasCycle(Network network)
	{
		if (!network.isDirected() && network.allowsParallelEdges() && network.edges().size() > network.asGraph().edges().size())
		{
			return true;
		}
		bool result = hasCycle(network.asGraph());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;)Lcom/google/common/graph/Graph<TN;>;")]
	[LineNumberTable(new byte[]
	{
		104, 210, 136, 123, 125, 106, 98, 199, 103, 127,
		3, 110, 106, 106, 99, 123, 127, 9, 107, 98,
		130, 165
	})]
	public static Graph transitiveClosure(Graph graph)
	{
		MutableGraph mutableGraph = GraphBuilder.from(graph).allowsSelfLoops(allowsSelfLoops: true).build();
		if (graph.isDirected())
		{
			Iterator iterator = graph.nodes().iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				Iterator iterator2 = reachableNodes(graph, obj).iterator();
				while (iterator2.hasNext())
				{
					object obj2 = iterator2.next();
					mutableGraph.putEdge(obj, obj2);
				}
			}
		}
		else
		{
			HashSet hashSet = new HashSet();
			Iterator iterator3 = graph.nodes().iterator();
			while (iterator3.hasNext())
			{
				object obj3 = iterator3.next();
				if (((Set)hashSet).contains(obj3))
				{
					continue;
				}
				Set set = reachableNodes(graph, obj3);
				((Set)hashSet).addAll((Collection)set);
				int num = 1;
				Iterator iterator4 = set.iterator();
				while (iterator4.hasNext())
				{
					object obj4 = iterator4.next();
					int limitSize = num;
					num++;
					Iterator iterator5 = Iterables.limit(set, limitSize).iterator();
					while (iterator5.hasNext())
					{
						object obj5 = iterator5.next();
						mutableGraph.putEdge(obj4, obj5);
					}
				}
			}
		}
		return mutableGraph;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;)Lcom/google/common/graph/Graph<TN;>;")]
	[LineNumberTable(new byte[] { 160, 97, 104, 162, 104, 174 })]
	public static Graph transpose(Graph graph)
	{
		if (!graph.isDirected())
		{
			return graph;
		}
		if (graph is TransposedGraph)
		{
			Graph result = TransposedGraph.access_0024000((TransposedGraph)graph);
			_ = null;
			return result;
		}
		TransposedGraph result2 = new TransposedGraph(graph);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ValueGraph<TN;TV;>;)Lcom/google/common/graph/ValueGraph<TN;TV;>;")]
	[LineNumberTable(new byte[] { 160, 113, 104, 162, 104, 174 })]
	public static ValueGraph transpose(ValueGraph graph)
	{
		if (!graph.isDirected())
		{
			return graph;
		}
		if (graph is TransposedValueGraph)
		{
			ValueGraph result = TransposedValueGraph.access_0024100((TransposedValueGraph)graph);
			_ = null;
			return result;
		}
		TransposedValueGraph result2 = new TransposedValueGraph(graph);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;)Lcom/google/common/graph/Network<TN;TE;>;")]
	[LineNumberTable(new byte[] { 160, 129, 104, 162, 104, 174 })]
	public static Network transpose(Network network)
	{
		if (!network.isDirected())
		{
			return network;
		}
		if (network is TransposedNetwork)
		{
			Network result = TransposedNetwork.access_0024200((TransposedNetwork)network);
			_ = null;
			return result;
		}
		TransposedNetwork result2 = new TransposedNetwork(network);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/EndpointPair<TN;>;)Lcom/google/common/graph/EndpointPair<TN;>;")]
	[LineNumberTable(new byte[] { 160, 141, 104, 148 })]
	internal static EndpointPair transpose(EndpointPair P_0)
	{
		if (P_0.isOrdered())
		{
			EndpointPair result = EndpointPair.ordered(P_0.target(), P_0.source());
			_ = null;
			return result;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;Ljava/lang/Iterable<+TN;>;)Lcom/google/common/graph/MutableGraph<TN;>;")]
	[LineNumberTable(new byte[]
	{
		161, 122, 104, 125, 108, 118, 104, 98, 123, 125,
		111, 138, 98, 98
	})]
	public static MutableGraph inducedSubgraph(Graph graph, Iterable nodes)
	{
		MutableGraph mutableGraph = ((!(nodes is Collection)) ? GraphBuilder.from(graph).build() : GraphBuilder.from(graph).expectedNodeCount(((Collection)nodes).size()).build());
		Iterator iterator = nodes.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			mutableGraph.addNode(obj);
		}
		iterator = mutableGraph.nodes().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			Iterator iterator2 = graph.successors(obj).iterator();
			while (iterator2.hasNext())
			{
				object obj2 = iterator2.next();
				if (mutableGraph.nodes().contains(obj2))
				{
					mutableGraph.putEdge(obj, obj2);
				}
			}
		}
		return mutableGraph;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ValueGraph<TN;TV;>;Ljava/lang/Iterable<+TN;>;)Lcom/google/common/graph/MutableValueGraph<TN;TV;>;")]
	[LineNumberTable(new byte[]
	{
		161, 149, 104, 125, 108, 118, 104, 98, 126, 125,
		143, 169, 234, 61, 230, 69, 98, 101
	})]
	public static MutableValueGraph inducedSubgraph(ValueGraph graph, Iterable nodes)
	{
		MutableValueGraph mutableValueGraph = ((!(nodes is Collection)) ? ValueGraphBuilder.from(graph).build() : ValueGraphBuilder.from(graph).expectedNodeCount(((Collection)nodes).size()).build());
		Iterator iterator = nodes.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			mutableValueGraph.addNode(obj);
		}
		iterator = mutableValueGraph.nodes().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			Iterator iterator2 = graph.successors(obj).iterator();
			while (iterator2.hasNext())
			{
				object obj2 = iterator2.next();
				if (mutableValueGraph.nodes().contains(obj2))
				{
					mutableValueGraph.putEdgeValue(obj, obj2, java.util.Objects.requireNonNull(graph.edgeValueOrDefault(obj, obj2, null)));
				}
			}
		}
		return mutableValueGraph;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;Ljava/lang/Iterable<+TN;>;)Lcom/google/common/graph/MutableNetwork<TN;TE;>;")]
	[LineNumberTable(new byte[]
	{
		161, 180, 104, 125, 108, 118, 104, 98, 126, 125,
		112, 111, 140, 98, 101
	})]
	public static MutableNetwork inducedSubgraph(Network network, Iterable nodes)
	{
		MutableNetwork mutableNetwork = ((!(nodes is Collection)) ? NetworkBuilder.from(network).build() : NetworkBuilder.from(network).expectedNodeCount(((Collection)nodes).size()).build());
		Iterator iterator = nodes.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			mutableNetwork.addNode(obj);
		}
		iterator = mutableNetwork.nodes().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			Iterator iterator2 = network.outEdges(obj).iterator();
			while (iterator2.hasNext())
			{
				object obj2 = iterator2.next();
				object obj3 = network.incidentNodes(obj2).adjacentNode(obj);
				if (mutableNetwork.nodes().contains(obj3))
				{
					mutableNetwork.addEdge(obj, obj3, obj2);
				}
			}
		}
		return mutableNetwork;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;)Lcom/google/common/graph/MutableGraph<TN;>;")]
	[LineNumberTable(new byte[] { 161, 199, 124, 123, 104, 98, 127, 1, 115, 98 })]
	public static MutableGraph copyOf(Graph graph)
	{
		MutableGraph mutableGraph = GraphBuilder.from(graph).expectedNodeCount(graph.nodes().size()).build();
		Iterator iterator = graph.nodes().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			mutableGraph.addNode(obj);
		}
		iterator = graph.edges().iterator();
		while (iterator.hasNext())
		{
			EndpointPair endpointPair = (EndpointPair)iterator.next();
			mutableGraph.putEdge(endpointPair.nodeU(), endpointPair.nodeV());
		}
		return mutableGraph;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ValueGraph<TN;TV;>;)Lcom/google/common/graph/MutableValueGraph<TN;TV;>;")]
	[LineNumberTable(new byte[]
	{
		161, 211, 97, 123, 123, 104, 98, 159, 1, 98,
		102, 103, 246, 61, 198, 98
	})]
	public static MutableValueGraph copyOf(ValueGraph graph)
	{
		MutableValueGraph mutableValueGraph = ValueGraphBuilder.from(graph).expectedNodeCount(graph.nodes().size()).build();
		Iterator iterator = graph.nodes().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			mutableValueGraph.addNode(obj);
		}
		iterator = graph.edges().iterator();
		while (iterator.hasNext())
		{
			EndpointPair endpointPair = (EndpointPair)iterator.next();
			mutableValueGraph.putEdgeValue(endpointPair.nodeU(), endpointPair.nodeV(), java.util.Objects.requireNonNull(graph.edgeValueOrDefault(endpointPair.nodeU(), endpointPair.nodeV(), null)));
		}
		return mutableValueGraph;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;)Lcom/google/common/graph/MutableNetwork<TN;TE;>;")]
	[LineNumberTable(new byte[]
	{
		161, 228, 97, 102, 112, 111, 102, 123, 104, 98,
		123, 104, 116, 98
	})]
	public static MutableNetwork copyOf(Network network)
	{
		MutableNetwork mutableNetwork = NetworkBuilder.from(network).expectedNodeCount(network.nodes().size()).expectedEdgeCount(network.edges().size())
			.build();
		Iterator iterator = network.nodes().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			mutableNetwork.addNode(obj);
		}
		iterator = network.edges().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			EndpointPair endpointPair = network.incidentNodes(obj);
			mutableNetwork.addEdge(endpointPair.nodeU(), endpointPair.nodeV(), obj);
		}
		return mutableNetwork;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 251, 115 })]
	internal static long checkNonNegative(long P_0)
	{
		Preconditions.checkArgument(P_0 >= 0, "Not true that %s is non-negative.", P_0);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 7, 112 })]
	internal static long checkPositive(long P_0)
	{
		Preconditions.checkArgument(P_0 > 0, "Not true that %s is positive.", P_0);
		return P_0;
	}
}
