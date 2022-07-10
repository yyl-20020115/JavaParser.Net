using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Ljava/util/AbstractSet<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal abstract class IncidentEdgeSet : AbstractSet
{
	[Modifiers(Modifiers.Final)]
	[Signature("TN;")]
	internal object node;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/graph/BaseGraph<TN;>;")]
	internal BaseGraph graph;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/BaseGraph<TN;>;TN;)V")]
	[LineNumberTable(new byte[] { 159, 174, 104, 103, 103 })]
	internal IncidentEdgeSet(BaseGraph P_0, object P_1)
	{
		graph = P_0;
		node = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(39)]
	public override bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 186, 109, 125, 102, 31, 4, 193 })]
	public override int size()
	{
		if (graph.isDirected())
		{
			return graph.inDegree(node) + graph.outDegree(node) - (graph.successors(node).contains(node) ? 1 : 0);
		}
		int result = graph.adjacentNodes(node).size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		5, 104, 130, 135, 112, 104, 162, 103, 103, 127,
		15, 63, 5, 161, 104, 130, 114, 103, 136, 127,
		0, 53
	})]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (!(P_0 is EndpointPair))
		{
			return false;
		}
		EndpointPair endpointPair = (EndpointPair)P_0;
		object obj2;
		if (graph.isDirected())
		{
			if (!endpointPair.isOrdered())
			{
				return false;
			}
			object obj = endpointPair.source();
			obj2 = endpointPair.target();
			return ((Object.instancehelper_equals(node, obj) && graph.successors(node).contains(obj2)) || (Object.instancehelper_equals(node, obj2) && graph.predecessors(node).contains(obj))) ? true : false;
		}
		if (endpointPair.isOrdered())
		{
			return false;
		}
		Set set = graph.adjacentNodes(node);
		obj2 = endpointPair.nodeU();
		object obj3 = endpointPair.nodeV();
		return ((Object.instancehelper_equals(node, obj3) && set.contains(obj2)) || (Object.instancehelper_equals(node, obj2) && set.contains(obj3))) ? true : false;
	}
}
