using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/graph/AbstractValueGraph<TN;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal abstract class ForwardingValueGraph : AbstractValueGraph
{
	[Signature("()Lcom/google/common/graph/ValueGraph<TN;TV;>;")]
	internal abstract ValueGraph @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(81)]
	public override Set successors(object P_0)
	{
		Set result = @delegate().successors(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(76)]
	public override Set predecessors(object P_0)
	{
		Set result = @delegate().predecessors(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(31)]
	internal ForwardingValueGraph()
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
	[LineNumberTable(46)]
	protected internal override long edgeCount()
	{
		return @delegate().edges().size();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(51)]
	public override bool isDirected()
	{
		bool result = @delegate().isDirected();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(56)]
	public override bool allowsSelfLoops()
	{
		bool result = @delegate().allowsSelfLoops();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	[LineNumberTable(61)]
	public override ElementOrder nodeOrder()
	{
		ElementOrder result = @delegate().nodeOrder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	[LineNumberTable(66)]
	public override ElementOrder incidentEdgeOrder()
	{
		ElementOrder result = @delegate().incidentEdgeOrder();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	[LineNumberTable(71)]
	public override Set adjacentNodes(object P_0)
	{
		Set result = @delegate().adjacentNodes(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(86)]
	public override int degree(object P_0)
	{
		int result = @delegate().degree(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(91)]
	public override int inDegree(object P_0)
	{
		int result = @delegate().inDegree(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(96)]
	public override int outDegree(object P_0)
	{
		int result = @delegate().outDegree(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Z")]
	[LineNumberTable(101)]
	public override bool hasEdgeConnecting(object P_0, object P_1)
	{
		bool result = @delegate().hasEdgeConnecting(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	[LineNumberTable(106)]
	public override bool hasEdgeConnecting(EndpointPair P_0)
	{
		bool result = @delegate().hasEdgeConnecting(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Ljava/util/Optional<TV;>;")]
	[LineNumberTable(111)]
	public override Optional edgeValue(object P_0, object P_1)
	{
		Optional result = @delegate().edgeValue(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Optional<TV;>;")]
	[LineNumberTable(116)]
	public override Optional edgeValue(EndpointPair P_0)
	{
		Optional result = @delegate().edgeValue(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;TV;)TV;")]
	[LineNumberTable(122)]
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
		object result = @delegate().edgeValueOrDefault(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;TV;)TV;")]
	[LineNumberTable(128)]
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
		object result = @delegate().edgeValueOrDefault(P_0, P_1);
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
