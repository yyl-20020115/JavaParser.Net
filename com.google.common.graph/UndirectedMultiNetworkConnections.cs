using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using java.lang;
using java.lang.@ref;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Lcom/google/common/graph/AbstractUndirectedNetworkConnections<TN;TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal sealed class UndirectedMultiNetworkConnections : AbstractUndirectedNetworkConnections
{
	[SpecialName]
	[Signature("Lcom/google/common/graph/MultiEdgesConnecting<TE;>;")]
	[EnclosingMethod(null, "edgesConnecting", "(Ljava.lang.Object;)Ljava.util.Set;")]
	internal class _1 : MultiEdgesConnecting
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024node;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal UndirectedMultiNetworkConnections this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(77)]
		internal _1(UndirectedMultiNetworkConnections P_0, Map P_1, object P_2, object P_3)
		{
			this_00240 = P_0;
			val_0024node = P_3;
			base._002Ector(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(80)]
		public override int size()
		{
			int result = UndirectedMultiNetworkConnections.access_0024000(this_00240).count(val_0024node);
			_ = null;
			return result;
		}
	}

	[NonSerialized]
	[Signature("Ljava/lang/ref/Reference<Lcom/google/common/collect/Multiset<TN;>;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	private Reference adjacentNodesReference;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Ljava/util/Map<TE;TN;>;)Lcom/google/common/graph/UndirectedMultiNetworkConnections<TN;TE;>;")]
	[LineNumberTable(56)]
	internal static UndirectedMultiNetworkConnections ofImmutable(Map P_0)
	{
		UndirectedMultiNetworkConnections result = new UndirectedMultiNetworkConnections(ImmutableMap.copyOf(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>()Lcom/google/common/graph/UndirectedMultiNetworkConnections<TN;TE;>;")]
	[LineNumberTable(51)]
	internal static UndirectedMultiNetworkConnections of()
	{
		UndirectedMultiNetworkConnections result = new UndirectedMultiNetworkConnections(new HashMap(2, 1f));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(43)]
	internal static Multiset access_0024000(UndirectedMultiNetworkConnections P_0)
	{
		Multiset result = P_0.adjacentNodesMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset<TN;>;")]
	[LineNumberTable(new byte[] { 17, 113, 104, 113, 145 })]
	private Multiset adjacentNodesMultiset()
	{
		object obj = (Multiset)getReference(adjacentNodesReference);
		if ((Multiset)obj == null)
		{
			obj = HashMultiset.create(incidentEdgeMap.values());
			adjacentNodesReference = new SoftReference((HashMultiset)obj);
		}
		object obj2 = obj;
		return (obj2 == null) ? null : ((obj2 as Multiset) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TE;TN;>;)V")]
	[LineNumberTable(new byte[] { 159, 189, 105 })]
	private UndirectedMultiNetworkConnections(Map P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/ref/Reference<TT;>;)TT;")]
	[LineNumberTable(122)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static object getReference([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Reference P_0)
	{
		object result = P_0?.get();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TN;")]
	[LineNumberTable(new byte[] { 46, 104, 113, 99, 140 })]
	public override object removeOutEdge(object P_0)
	{
		object obj = base.removeOutEdge(P_0);
		Multiset multiset = (Multiset)getReference(adjacentNodesReference);
		if (multiset != null)
		{
			Preconditions.checkState(multiset.remove(obj));
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TN;)V")]
	[LineNumberTable(new byte[] { 63, 104, 113, 99, 142 })]
	public override void addOutEdge(object P_0, object P_1)
	{
		base.addOutEdge(P_0, P_1);
		Multiset multiset = (Multiset)getReference(adjacentNodesReference);
		if (multiset != null)
		{
			Preconditions.checkState(multiset.add(P_1));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(63)]
	public override Set adjacentNodes()
	{
		Set result = Collections.unmodifiableSet(adjacentNodesMultiset().elementSet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(77)]
	public override Set edgesConnecting(object P_0)
	{
		_1 result = new _1(this, incidentEdgeMap, P_0, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)TN;")]
	[LineNumberTable(new byte[] { 159, 120, 66, 99, 138 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object removeInEdge(object P_0, bool P_1)
	{
		if (!P_1)
		{
			object result = removeOutEdge(P_0);
			_ = null;
			return result;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TN;Z)V")]
	[LineNumberTable(new byte[] { 159, 116, 130, 99, 138 })]
	public override void addInEdge(object P_0, object P_1, bool P_2)
	{
		if (!P_2)
		{
			addOutEdge(P_0, P_1);
		}
	}
}
