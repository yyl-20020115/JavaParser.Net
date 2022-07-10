using System.Runtime.CompilerServices;
using com.google.common.collect;
using IKVM.Attributes;
using java.util;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Lcom/google/common/graph/AbstractDirectedNetworkConnections<TN;TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal sealed class DirectedNetworkConnections : AbstractDirectedNetworkConnections
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TE;TN;>;Ljava/util/Map<TE;TN;>;I)V")]
	[LineNumberTable(new byte[] { 159, 181, 107 })]
	internal DirectedNetworkConnections(Map P_0, Map P_1, int P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>()Lcom/google/common/graph/DirectedNetworkConnections<TN;TE;>;")]
	[LineNumberTable(new byte[] { 159, 185, 97, 51 })]
	internal static DirectedNetworkConnections of()
	{
		DirectedNetworkConnections result = new DirectedNetworkConnections(HashBiMap.create(2), HashBiMap.create(2), 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Ljava/util/Map<TE;TN;>;Ljava/util/Map<TE;TN;>;I)Lcom/google/common/graph/DirectedNetworkConnections<TN;TE;>;")]
	[LineNumberTable(new byte[] { 159, 191, 97, 51 })]
	internal static DirectedNetworkConnections ofImmutable(Map P_0, Map P_1, int P_2)
	{
		DirectedNetworkConnections result = new DirectedNetworkConnections(ImmutableBiMap.copyOf(P_0), ImmutableBiMap.copyOf(P_1), P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(55)]
	public override Set predecessors()
	{
		Set result = Collections.unmodifiableSet(((BiMap)inEdgeMap).values());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(60)]
	public override Set successors()
	{
		Set result = Collections.unmodifiableSet(((BiMap)outEdgeMap).values());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(65)]
	public override Set edgesConnecting(object P_0)
	{
		EdgesConnecting result = new EdgesConnecting(((BiMap)outEdgeMap).inverse(), P_0);
		_ = null;
		return result;
	}
}
