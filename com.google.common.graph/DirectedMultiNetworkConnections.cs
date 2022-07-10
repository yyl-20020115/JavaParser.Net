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

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Lcom/google/common/graph/AbstractDirectedNetworkConnections<TN;TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal sealed class DirectedMultiNetworkConnections : AbstractDirectedNetworkConnections
{
	[SpecialName]
	[Signature("Lcom/google/common/graph/MultiEdgesConnecting<TE;>;")]
	[EnclosingMethod(null, "edgesConnecting", "(Ljava.lang.Object;)Ljava.util.Set;")]
	internal new class _1 : MultiEdgesConnecting
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024node;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DirectedMultiNetworkConnections this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(97)]
		internal _1(DirectedMultiNetworkConnections P_0, Map P_1, object P_2, object P_3)
		{
			this_00240 = P_0;
			val_0024node = P_3;
			base._002Ector(P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(100)]
		public override int size()
		{
			int result = DirectedMultiNetworkConnections.access_0024000(this_00240).count(val_0024node);
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
	private Reference predecessorsReference;

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
	private Reference successorsReference;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(43)]
	internal static Multiset access_0024000(DirectedMultiNetworkConnections P_0)
	{
		Multiset result = P_0.successorsMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset<TN;>;")]
	[LineNumberTable(new byte[] { 37, 113, 104, 113, 145 })]
	private Multiset successorsMultiset()
	{
		object obj = (Multiset)getReference(successorsReference);
		if ((Multiset)obj == null)
		{
			obj = HashMultiset.create(outEdgeMap.values());
			successorsReference = new SoftReference((HashMultiset)obj);
		}
		object obj2 = obj;
		return (obj2 == null) ? null : ((obj2 as Multiset) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TE;TN;>;Ljava/util/Map<TE;TN;>;I)V")]
	[LineNumberTable(new byte[] { 159, 189, 107 })]
	private DirectedMultiNetworkConnections(Map P_0, Map P_1, int P_2)
		: base(P_0, P_1, P_2)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset<TN;>;")]
	[LineNumberTable(new byte[] { 21, 113, 104, 113, 145 })]
	private Multiset predecessorsMultiset()
	{
		object obj = (Multiset)getReference(predecessorsReference);
		if ((Multiset)obj == null)
		{
			obj = HashMultiset.create(inEdgeMap.values());
			predecessorsReference = new SoftReference((HashMultiset)obj);
		}
		object obj2 = obj;
		return (obj2 == null) ? null : ((obj2 as Multiset) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/ref/Reference<TT;>;)TT;")]
	[LineNumberTable(145)]
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
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>()Lcom/google/common/graph/DirectedMultiNetworkConnections<TN;TE;>;")]
	[LineNumberTable(51)]
	internal static DirectedMultiNetworkConnections of()
	{
		DirectedMultiNetworkConnections result = new DirectedMultiNetworkConnections(new HashMap(2, 1f), new HashMap(2, 1f), 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Ljava/util/Map<TE;TN;>;Ljava/util/Map<TE;TN;>;I)Lcom/google/common/graph/DirectedMultiNetworkConnections<TN;TE;>;")]
	[LineNumberTable(new byte[] { 9, 97, 51 })]
	internal static DirectedMultiNetworkConnections ofImmutable(Map P_0, Map P_1, int P_2)
	{
		DirectedMultiNetworkConnections result = new DirectedMultiNetworkConnections(ImmutableMap.copyOf(P_0), ImmutableMap.copyOf(P_1), P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(67)]
	public override Set predecessors()
	{
		Set result = Collections.unmodifiableSet(predecessorsMultiset().elementSet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(83)]
	public override Set successors()
	{
		Set result = Collections.unmodifiableSet(successorsMultiset().elementSet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(97)]
	public override Set edgesConnecting(object P_0)
	{
		_1 result = new _1(this, outEdgeMap, P_0, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)TN;")]
	[LineNumberTable(new byte[] { 159, 116, 162, 105, 113, 99, 140 })]
	public override object removeInEdge(object P_0, bool P_1)
	{
		object obj = base.removeInEdge(P_0, P_1);
		Multiset multiset = (Multiset)getReference(predecessorsReference);
		if (multiset != null)
		{
			Preconditions.checkState(multiset.remove(obj));
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TN;")]
	[LineNumberTable(new byte[] { 67, 104, 113, 99, 140 })]
	public override object removeOutEdge(object P_0)
	{
		object obj = base.removeOutEdge(P_0);
		Multiset multiset = (Multiset)getReference(successorsReference);
		if (multiset != null)
		{
			Preconditions.checkState(multiset.remove(obj));
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TN;Z)V")]
	[LineNumberTable(new byte[] { 159, 111, 162, 105, 113, 99, 142 })]
	public override void addInEdge(object P_0, object P_1, bool P_2)
	{
		base.addInEdge(P_0, P_1, P_2);
		Multiset multiset = (Multiset)getReference(predecessorsReference);
		if (multiset != null)
		{
			Preconditions.checkState(multiset.add(P_1));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TN;)V")]
	[LineNumberTable(new byte[] { 86, 104, 113, 99, 142 })]
	public override void addOutEdge(object P_0, object P_1)
	{
		base.addOutEdge(P_0, P_1);
		Multiset multiset = (Multiset)getReference(successorsReference);
		if (multiset != null)
		{
			Preconditions.checkState(multiset.add(P_1));
		}
	}
}
