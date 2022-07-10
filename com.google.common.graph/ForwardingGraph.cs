using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/AbstractGraph<TN;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ForwardingGraph : AbstractGraph
{
	[Signature("()Lcom/google/common/graph/BaseGraph<TN;>;")]
	internal abstract BaseGraph @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(78)]
	public override Set successors(object P_0)
	{
		Set result = @delegate().successors(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(73)]
	public override Set predecessors(object P_0)
	{
		Set result = @delegate().predecessors(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(28)]
	internal ForwardingGraph()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(34)]
	public override Set nodes()
	{
		Set result = @delegate().nodes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	protected internal override long edgeCount()
	{
		return @delegate().edges().size();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(48)]
	public override bool isDirected()
	{
		bool result = @delegate().isDirected();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public override bool allowsSelfLoops()
	{
		bool result = @delegate().allowsSelfLoops();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	[LineNumberTable(58)]
	public override ElementOrder nodeOrder()
	{
		ElementOrder result = @delegate().nodeOrder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	[LineNumberTable(63)]
	public override ElementOrder incidentEdgeOrder()
	{
		ElementOrder result = @delegate().incidentEdgeOrder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(68)]
	public override Set adjacentNodes(object P_0)
	{
		Set result = @delegate().adjacentNodes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	[LineNumberTable(83)]
	public override Set incidentEdges(object P_0)
	{
		Set result = @delegate().incidentEdges(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(88)]
	public override int degree(object P_0)
	{
		int result = @delegate().degree(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(93)]
	public override int inDegree(object P_0)
	{
		int result = @delegate().inDegree(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(98)]
	public override int outDegree(object P_0)
	{
		int result = @delegate().outDegree(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Z")]
	[LineNumberTable(103)]
	public override bool hasEdgeConnecting(object P_0, object P_1)
	{
		bool result = @delegate().hasEdgeConnecting(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	[LineNumberTable(108)]
	public override bool hasEdgeConnecting(EndpointPair P_0)
	{
		bool result = @delegate().hasEdgeConnecting(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(27)]
	public override Iterable successors(object P_0)
	{
		Set result = this.successors(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(27)]
	public override Iterable predecessors(object P_0)
	{
		Set result = this.predecessors(P_0);
		_ = null;
		return result;
	}
}
