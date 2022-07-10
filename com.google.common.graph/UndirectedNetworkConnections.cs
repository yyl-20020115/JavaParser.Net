using System.Runtime.CompilerServices;
using com.google.common.collect;
using IKVM.Attributes;
using java.util;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Lcom/google/common/graph/AbstractUndirectedNetworkConnections<TN;TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal sealed class UndirectedNetworkConnections : AbstractUndirectedNetworkConnections
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Ljava/util/Map<TE;TN;>;)Lcom/google/common/graph/UndirectedNetworkConnections<TN;TE;>;")]
	[LineNumberTable(47)]
	internal static UndirectedNetworkConnections ofImmutable(Map P_0)
	{
		UndirectedNetworkConnections result = new UndirectedNetworkConnections(ImmutableBiMap.copyOf(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>()Lcom/google/common/graph/UndirectedNetworkConnections<TN;TE;>;")]
	[LineNumberTable(43)]
	internal static UndirectedNetworkConnections of()
	{
		UndirectedNetworkConnections result = new UndirectedNetworkConnections(HashBiMap.create(2));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TE;TN;>;)V")]
	[LineNumberTable(new byte[] { 159, 181, 105 })]
	internal UndirectedNetworkConnections(Map P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(52)]
	public override Set adjacentNodes()
	{
		Set result = Collections.unmodifiableSet(((BiMap)incidentEdgeMap).values());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(57)]
	public override Set edgesConnecting(object P_0)
	{
		EdgesConnecting result = new EdgesConnecting(((BiMap)incidentEdgeMap).inverse(), P_0);
		_ = null;
		return result;
	}
}
