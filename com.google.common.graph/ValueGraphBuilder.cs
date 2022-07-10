using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/graph/AbstractGraphBuilder<TN;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
public sealed class ValueGraphBuilder : AbstractGraphBuilder
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ValueGraph<TN;TV;>;)Lcom/google/common/graph/ValueGraphBuilder<TN;TV;>;")]
	[LineNumberTable(new byte[] { 46, 108, 107, 107, 236, 61 })]
	public static ValueGraphBuilder from(ValueGraph graph)
	{
		ValueGraphBuilder result = new ValueGraphBuilder(graph.isDirected()).allowsSelfLoops(graph.allowsSelfLoops()).nodeOrder(graph.nodeOrder()).incidentEdgeOrder(graph.incidentEdgeOrder());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/graph/ValueGraphBuilder<TN;TV;>;")]
	[LineNumberTable(new byte[] { 86, 118 })]
	public new virtual ValueGraphBuilder expectedNodeCount(int expectedNodeCount)
	{
		base.expectedNodeCount = Optional.of(Integer.valueOf(Graphs.checkNonNegative(expectedNodeCount)));
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;V1:TV;>()Lcom/google/common/graph/MutableValueGraph<TN1;TV1;>;")]
	[LineNumberTable(181)]
	public virtual MutableValueGraph build()
	{
		StandardMutableValueGraph result = new StandardMutableValueGraph(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ValueGraphBuilder<TN;TV;>;")]
	[LineNumberTable(new byte[] { 160, 71, 108, 108, 108, 108, 108 })]
	internal virtual ValueGraphBuilder copy()
	{
		ValueGraphBuilder valueGraphBuilder = new ValueGraphBuilder(base.directed);
		((AbstractGraphBuilder)valueGraphBuilder).allowsSelfLoops = base.allowsSelfLoops;
		((AbstractGraphBuilder)valueGraphBuilder).nodeOrder = base.nodeOrder;
		((AbstractGraphBuilder)valueGraphBuilder).expectedNodeCount = base.expectedNodeCount;
		((AbstractGraphBuilder)valueGraphBuilder).incidentEdgeOrder = base.incidentEdgeOrder;
		return valueGraphBuilder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;>(Lcom/google/common/graph/ElementOrder<TN1;>;)Lcom/google/common/graph/ValueGraphBuilder<TN1;TV;>;")]
	[LineNumberTable(new byte[] { 116, 97, 109, 22, 229, 70, 103, 113 })]
	public new virtual ValueGraphBuilder incidentEdgeOrder(ElementOrder incidentEdgeOrder)
	{
		Preconditions.checkArgument((incidentEdgeOrder.type() == ElementOrder.Type.___003C_003EUNORDERED || incidentEdgeOrder.type() == ElementOrder.Type.___003C_003ESTABLE) ? true : false, "The given elementOrder (%s) is unsupported. incidentEdgeOrder() only supports ElementOrder.unordered() and ElementOrder.stable().", incidentEdgeOrder);
		ValueGraphBuilder valueGraphBuilder = cast();
		((AbstractGraphBuilder)valueGraphBuilder).incidentEdgeOrder = (ElementOrder)Preconditions.checkNotNull(incidentEdgeOrder);
		return valueGraphBuilder;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 124, 130, 105 })]
	private ValueGraphBuilder(bool P_0)
		: base(P_0)
	{
	}

	[Signature("(Z)Lcom/google/common/graph/ValueGraphBuilder<TN;TV;>;")]
	public new virtual ValueGraphBuilder allowsSelfLoops(bool allowsSelfLoops)
	{
		int num = ((base.allowsSelfLoops = allowsSelfLoops) ? 1 : 0);
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;>(Lcom/google/common/graph/ElementOrder<TN1;>;)Lcom/google/common/graph/ValueGraphBuilder<TN1;TV;>;")]
	[LineNumberTable(new byte[] { 96, 103, 113 })]
	public new virtual ValueGraphBuilder nodeOrder(ElementOrder nodeOrder)
	{
		ValueGraphBuilder valueGraphBuilder = cast();
		((AbstractGraphBuilder)valueGraphBuilder).nodeOrder = (ElementOrder)Preconditions.checkNotNull(nodeOrder);
		return valueGraphBuilder;
	}

	[Signature("<N1:TN;V1:TV;>()Lcom/google/common/graph/ValueGraphBuilder<TN1;TV1;>;")]
	private ValueGraphBuilder cast()
	{
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ValueGraphBuilder<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[LineNumberTable(79)]
	public new static ValueGraphBuilder directed()
	{
		ValueGraphBuilder result = new ValueGraphBuilder(true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ValueGraphBuilder<Ljava/lang/Object;Ljava/lang/Object;>;")]
	[LineNumberTable(84)]
	public static ValueGraphBuilder undirected()
	{
		ValueGraphBuilder result = new ValueGraphBuilder(false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N1:TN;V1:TV;>()Lcom/google/common/graph/ImmutableValueGraph$Builder<TN1;TV1;>;")]
	[LineNumberTable(new byte[] { 64, 103 })]
	public virtual ImmutableValueGraph.Builder immutable()
	{
		ValueGraphBuilder valueGraphBuilder = cast();
		ImmutableValueGraph.Builder result = new ImmutableValueGraph.Builder(valueGraphBuilder);
		_ = null;
		return result;
	}
}
