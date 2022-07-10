using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;

namespace com.google.common.graph;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal sealed class GraphConstants : java.lang.Object
{
	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/graph/GraphConstants$Presence;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	internal sealed class Presence : java.lang.Enum
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static Presence EDGE_EXISTS;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static Presence[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(58)]
		private Presence(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(58)]
		private static Presence[] _0024values()
		{
			return new Presence[1] { EDGE_EXISTS };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(58)]
		public static Presence[] values()
		{
			return (Presence[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(58)]
		public static Presence valueOf(string P_0)
		{
			return (Presence)java.lang.Enum.valueOf(ClassLiteral<Presence>.Value, P_0);
		}

		[LineNumberTable(new byte[] { 9, 48 })]
		static Presence()
		{
			EDGE_EXISTS = new Presence("EDGE_EXISTS", 0);
			_0024VALUES = _0024values();
		}
	}

	internal const int EXPECTED_DEGREE = 2;

	internal const int DEFAULT_NODE_COUNT = 10;

	internal const int DEFAULT_EDGE_COUNT = 20;

	internal const float INNER_LOAD_FACTOR = 1f;

	internal const int INNER_CAPACITY = 2;

	internal const string NODE_NOT_IN_GRAPH = "Node %s is not an element of this graph.";

	internal const string EDGE_NOT_IN_GRAPH = "Edge %s is not an element of this graph.";

	internal const string REUSING_EDGE = "Edge %s already exists between the following nodes: %s, so it cannot be reused to connect the following nodes: %s.";

	internal const string MULTIPLE_EDGES_CONNECTING = "Cannot call edgeConnecting() when parallel edges exist between %s and %s. Consider calling edgesConnecting() instead.";

	internal const string PARALLEL_EDGES_NOT_ALLOWED = "Nodes %s and %s are already connected by a different edge. To construct a graph that allows parallel edges, call allowsParallelEdges(true) on the Builder.";

	internal const string SELF_LOOPS_NOT_ALLOWED = "Cannot add self-loop edge on node %s, as self-loops are not allowed. To construct a graph that allows self-loops, call allowsSelfLoops(true) on the Builder.";

	internal const string NOT_AVAILABLE_ON_UNDIRECTED = "Cannot call source()/target() on a EndpointPair from an undirected graph. Consider calling adjacentNode(node) if you already have a node, or nodeU()/nodeV() if you don't.";

	internal const string EDGE_ALREADY_EXISTS = "Edge %s already exists in the graph.";

	internal const string ENDPOINTS_MISMATCH = "Mismatch: unordered endpoints cannot be used with directed graphs";

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(24)]
	private GraphConstants()
	{
	}
}
