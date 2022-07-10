using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Lcom/google/common/graph/AbstractGraphBuilder<TN;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
public sealed class NetworkBuilder : AbstractGraphBuilder
{
	internal bool allowsParallelEdges;

	[Signature("Lcom/google/common/graph/ElementOrder<-TE;>;")]
	internal ElementOrder edgeOrder;

	[Signature("Lcom/google/common/base/Optional<Ljava/lang/Integer;>;")]
	internal Optional expectedEdgeCount;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;)Lcom/google/common/graph/NetworkBuilder<TN;TE;>;")]
	[LineNumberTable(new byte[] { 50, 108, 107, 107, 107, 236, 60 })]
	public static NetworkBuilder from(Network network)
	{
		NetworkBuilder result = new NetworkBuilder(network.isDirected()).allowsParallelEdges(network.allowsParallelEdges()).allowsSelfLoops(network.allowsSelfLoops()).nodeOrder(network.nodeOrder())
			.edgeOrder(network.edgeOrder());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/graph/NetworkBuilder<TN;TE;>;")]
	[LineNumberTable(new byte[] { 98, 118 })]
	public new virtual NetworkBuilder expectedNodeCount(int expectedNodeCount)
	{
		base.expectedNodeCount = Optional.of(Integer.valueOf(Graphs.checkNonNegative(expectedNodeCount)));
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;E1:TE;>()Lcom/google/common/graph/MutableNetwork<TN1;TE1;>;")]
	[LineNumberTable(186)]
	public virtual MutableNetwork build()
	{
		StandardMutableNetwork result = new StandardMutableNetwork(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/graph/NetworkBuilder<TN;TE;>;")]
	[LineNumberTable(new byte[] { 108, 118 })]
	public virtual NetworkBuilder expectedEdgeCount(int expectedEdgeCount)
	{
		this.expectedEdgeCount = Optional.of(Integer.valueOf(Graphs.checkNonNegative(expectedEdgeCount)));
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 123, 130, 233, 58, 103, 107, 235, 69 })]
	private NetworkBuilder(bool P_0)
		: base(P_0)
	{
		this.allowsParallelEdges = false;
		this.edgeOrder = ElementOrder.insertion();
		this.expectedEdgeCount = Optional.absent();
	}

	[Signature("(Z)Lcom/google/common/graph/NetworkBuilder<TN;TE;>;")]
	public virtual NetworkBuilder allowsParallelEdges(bool allowsParallelEdges)
	{
		int num = ((this.allowsParallelEdges = allowsParallelEdges) ? 1 : 0);
		return this;
	}

	[Signature("(Z)Lcom/google/common/graph/NetworkBuilder<TN;TE;>;")]
	public new virtual NetworkBuilder allowsSelfLoops(bool allowsSelfLoops)
	{
		int num = ((base.allowsSelfLoops = allowsSelfLoops) ? 1 : 0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;>(Lcom/google/common/graph/ElementOrder<TN1;>;)Lcom/google/common/graph/NetworkBuilder<TN1;TE;>;")]
	[LineNumberTable(new byte[] { 118, 103, 113 })]
	public new virtual NetworkBuilder nodeOrder(ElementOrder nodeOrder)
	{
		NetworkBuilder networkBuilder = cast();
		((AbstractGraphBuilder)networkBuilder).nodeOrder = (ElementOrder)Preconditions.checkNotNull(nodeOrder);
		return networkBuilder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E1:TE;>(Lcom/google/common/graph/ElementOrder<TE1;>;)Lcom/google/common/graph/NetworkBuilder<TN;TE1;>;")]
	[LineNumberTable(new byte[] { 160, 65, 103, 113 })]
	public virtual NetworkBuilder edgeOrder(ElementOrder edgeOrder)
	{
		NetworkBuilder networkBuilder = cast();
		networkBuilder.edgeOrder = (ElementOrder)Preconditions.checkNotNull(edgeOrder);
		return networkBuilder;
	}

	[Signature("<N1:TN;E1:TE;>()Lcom/google/common/graph/NetworkBuilder<TN1;TE1;>;")]
	private NetworkBuilder cast()
	{
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/NetworkBuilder<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[LineNumberTable(83)]
	public new static NetworkBuilder directed()
	{
		NetworkBuilder result = new NetworkBuilder(true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/NetworkBuilder<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[LineNumberTable(88)]
	public static NetworkBuilder undirected()
	{
		NetworkBuilder result = new NetworkBuilder(false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;E1:TE;>()Lcom/google/common/graph/ImmutableNetwork$Builder<TN1;TE1;>;")]
	[LineNumberTable(new byte[] { 65, 103 })]
	public virtual ImmutableNetwork.Builder immutable()
	{
		NetworkBuilder networkBuilder = cast();
		ImmutableNetwork.Builder result = new ImmutableNetwork.Builder(networkBuilder);
		_ = null;
		return result;
	}
}
