using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/AbstractGraphBuilder<TN;>;")]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
public sealed class GraphBuilder : AbstractGraphBuilder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 124, 66, 105 })]
	private GraphBuilder(bool P_0)
		: base(P_0)
	{
	}

	[Signature("(Z)Lcom/google/common/graph/GraphBuilder<TN;>;")]
	public new virtual GraphBuilder allowsSelfLoops(bool allowsSelfLoops)
	{
		int num = ((base.allowsSelfLoops = allowsSelfLoops) ? 1 : 0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;>(Lcom/google/common/graph/ElementOrder<TN1;>;)Lcom/google/common/graph/GraphBuilder<TN1;>;")]
	[LineNumberTable(new byte[] { 92, 103, 113 })]
	public new virtual GraphBuilder nodeOrder(ElementOrder nodeOrder)
	{
		GraphBuilder graphBuilder = cast();
		((AbstractGraphBuilder)graphBuilder).nodeOrder = (ElementOrder)Preconditions.checkNotNull(nodeOrder);
		return graphBuilder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;>(Lcom/google/common/graph/ElementOrder<TN1;>;)Lcom/google/common/graph/GraphBuilder<TN1;>;")]
	[LineNumberTable(new byte[] { 111, 97, 109, 22, 229, 70, 103, 113 })]
	public new virtual GraphBuilder incidentEdgeOrder(ElementOrder incidentEdgeOrder)
	{
		Preconditions.checkArgument((incidentEdgeOrder.type() == ElementOrder.Type.___003C_003EUNORDERED || incidentEdgeOrder.type() == ElementOrder.Type.___003C_003ESTABLE) ? true : false, "The given elementOrder (%s) is unsupported. incidentEdgeOrder() only supports ElementOrder.unordered() and ElementOrder.stable().", incidentEdgeOrder);
		GraphBuilder graphBuilder = cast();
		((AbstractGraphBuilder)graphBuilder).incidentEdgeOrder = (ElementOrder)Preconditions.checkNotNull(incidentEdgeOrder);
		return graphBuilder;
	}

	[Signature("<N1:TN;>()Lcom/google/common/graph/GraphBuilder<TN1;>;")]
	private GraphBuilder cast()
	{
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/GraphBuilder<Ljava/lang/Object;>;")]
	[LineNumberTable(77)]
	public new static GraphBuilder directed()
	{
		GraphBuilder result = new GraphBuilder(true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/GraphBuilder<Ljava/lang/Object;>;")]
	[LineNumberTable(82)]
	public static GraphBuilder undirected()
	{
		GraphBuilder result = new GraphBuilder(false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/Graph<TN;>;)Lcom/google/common/graph/GraphBuilder<TN;>;")]
	[LineNumberTable(new byte[] { 43, 108, 107, 107, 236, 61 })]
	public static GraphBuilder from(Graph graph)
	{
		GraphBuilder result = new GraphBuilder(graph.isDirected()).allowsSelfLoops(graph.allowsSelfLoops()).nodeOrder(graph.nodeOrder()).incidentEdgeOrder(graph.incidentEdgeOrder());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;>()Lcom/google/common/graph/ImmutableGraph$Builder<TN1;>;")]
	[LineNumberTable(new byte[] { 60, 103 })]
	public virtual ImmutableGraph.Builder immutable()
	{
		GraphBuilder graphBuilder = cast();
		ImmutableGraph.Builder result = new ImmutableGraph.Builder(graphBuilder);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/graph/GraphBuilder<TN;>;")]
	[LineNumberTable(new byte[] { 82, 118 })]
	public new virtual GraphBuilder expectedNodeCount(int expectedNodeCount)
	{
		base.expectedNodeCount = Optional.of(Integer.valueOf(Graphs.checkNonNegative(expectedNodeCount)));
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;>()Lcom/google/common/graph/MutableGraph<TN1;>;")]
	[LineNumberTable(174)]
	public virtual MutableGraph build()
	{
		StandardMutableGraph result = new StandardMutableGraph(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/GraphBuilder<TN;>;")]
	[LineNumberTable(new byte[] { 160, 64, 108, 108, 108, 108, 108 })]
	internal virtual GraphBuilder copy()
	{
		GraphBuilder graphBuilder = new GraphBuilder(base.directed);
		((AbstractGraphBuilder)graphBuilder).allowsSelfLoops = base.allowsSelfLoops;
		((AbstractGraphBuilder)graphBuilder).nodeOrder = base.nodeOrder;
		((AbstractGraphBuilder)graphBuilder).expectedNodeCount = base.expectedNodeCount;
		((AbstractGraphBuilder)graphBuilder).incidentEdgeOrder = base.incidentEdgeOrder;
		return graphBuilder;
	}
}
