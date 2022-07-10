using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Lcom/google/common/graph/AbstractNetwork<TN;TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ForwardingNetwork : AbstractNetwork
{
	[Signature("()Lcom/google/common/graph/Network<TN;TE;>;")]
	internal abstract Network @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(82)]
	public override Set successors(object P_0)
	{
		Set result = @delegate().successors(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(77)]
	public override Set predecessors(object P_0)
	{
		Set result = @delegate().predecessors(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	internal ForwardingNetwork()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(37)]
	public override Set nodes()
	{
		Set result = @delegate().nodes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(42)]
	public override Set edges()
	{
		Set result = @delegate().edges();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(47)]
	public override bool isDirected()
	{
		bool result = @delegate().isDirected();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(52)]
	public override bool allowsParallelEdges()
	{
		bool result = @delegate().allowsParallelEdges();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(57)]
	public override bool allowsSelfLoops()
	{
		bool result = @delegate().allowsSelfLoops();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	[LineNumberTable(62)]
	public override ElementOrder nodeOrder()
	{
		ElementOrder result = @delegate().nodeOrder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ElementOrder<TE;>;")]
	[LineNumberTable(67)]
	public override ElementOrder edgeOrder()
	{
		ElementOrder result = @delegate().edgeOrder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(72)]
	public override Set adjacentNodes(object P_0)
	{
		Set result = @delegate().adjacentNodes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(87)]
	public override Set incidentEdges(object P_0)
	{
		Set result = @delegate().incidentEdges(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(92)]
	public override Set inEdges(object P_0)
	{
		Set result = @delegate().inEdges(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(97)]
	public override Set outEdges(object P_0)
	{
		Set result = @delegate().outEdges(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Lcom/google/common/graph/EndpointPair<TN;>;")]
	[LineNumberTable(102)]
	public override EndpointPair incidentNodes(object P_0)
	{
		EndpointPair result = @delegate().incidentNodes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(107)]
	public override Set adjacentEdges(object P_0)
	{
		Set result = @delegate().adjacentEdges(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(112)]
	public override int degree(object P_0)
	{
		int result = @delegate().degree(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(117)]
	public override int inDegree(object P_0)
	{
		int result = @delegate().inDegree(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(122)]
	public override int outDegree(object P_0)
	{
		int result = @delegate().outDegree(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(127)]
	public override Set edgesConnecting(object P_0, object P_1)
	{
		Set result = @delegate().edgesConnecting(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(132)]
	public override Set edgesConnecting(EndpointPair P_0)
	{
		Set result = @delegate().edgesConnecting(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Ljava/util/Optional<TE;>;")]
	[LineNumberTable(137)]
	public override Optional edgeConnecting(object P_0, object P_1)
	{
		Optional result = @delegate().edgeConnecting(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Optional<TE;>;")]
	[LineNumberTable(142)]
	public override Optional edgeConnecting(EndpointPair P_0)
	{
		Optional result = @delegate().edgeConnecting(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)TE;")]
	[LineNumberTable(148)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object edgeConnectingOrNull(object P_0, object P_1)
	{
		object result = @delegate().edgeConnectingOrNull(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)TE;")]
	[LineNumberTable(154)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object edgeConnectingOrNull(EndpointPair P_0)
	{
		object result = @delegate().edgeConnectingOrNull(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Z")]
	[LineNumberTable(159)]
	public override bool hasEdgeConnecting(object P_0, object P_1)
	{
		bool result = @delegate().hasEdgeConnecting(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	[LineNumberTable(164)]
	public override bool hasEdgeConnecting(EndpointPair P_0)
	{
		bool result = @delegate().hasEdgeConnecting(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override Iterable successors(object P_0)
	{
		Set result = this.successors(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override Iterable predecessors(object P_0)
	{
		Set result = this.predecessors(P_0);
		_ = null;
		return result;
	}
}
