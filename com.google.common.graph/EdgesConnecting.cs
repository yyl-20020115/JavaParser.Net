using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractSet<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal sealed class EdgesConnecting : AbstractSet
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Map<*TE;>;")]
	private Map nodeToOutEdge;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private object targetNode;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<*TE;>;Ljava/lang/Object;)V")]
	[LineNumberTable(new byte[] { 159, 185, 104, 113, 108 })]
	internal EdgesConnecting(Map P_0, object P_1)
	{
		nodeToOutEdge = (Map)Preconditions.checkNotNull(P_0);
		targetNode = Preconditions.checkNotNull(P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(69)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private object getConnectingEdge()
	{
		object result = nodeToOutEdge.get(targetNode);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
	[LineNumberTable(new byte[] { 0, 103, 99, 108, 8 })]
	public new virtual UnmodifiableIterator iterator()
	{
		object connectingEdge = getConnectingEdge();
		UnmodifiableIterator result = ((connectingEdge != null) ? Iterators.singletonIterator(connectingEdge) : ImmutableSet.of().iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	public override int size()
	{
		return (getConnectingEdge() != null) ? 1 : 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 103 })]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		object connectingEdge = getConnectingEdge();
		return (connectingEdge != null && Object.instancehelper_equals(connectingEdge, P_0)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(37)]
	public override Iterator iterator()
	{
		UnmodifiableIterator result = iterator();
		_ = null;
		return result;
	}
}
