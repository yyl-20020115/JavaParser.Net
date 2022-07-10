using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.math;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/NetworkConnections<TN;TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractDirectedNetworkConnections : Object, NetworkConnections
{
	[SpecialName]
	[Signature("Ljava/util/AbstractSet<TE;>;")]
	[EnclosingMethod(null, "incidentEdges", "()Ljava.util.Set;")]
	internal class _1 : AbstractSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractDirectedNetworkConnections this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
		[LineNumberTable(new byte[] { 21, 109, 127, 8, 127, 7 })]
		public new virtual UnmodifiableIterator iterator()
		{
			object obj = ((access_0024000(this_00240) != 0) ? Sets.union(this_00240.inEdgeMap.keySet(), this_00240.outEdgeMap.keySet()) : Iterables.concat(this_00240.inEdgeMap.keySet(), this_00240.outEdgeMap.keySet()));
			UnmodifiableIterator result = Iterators.unmodifiableIterator(((obj == null) ? null : ((obj as Iterable) ?? throw new java.lang.IncompatibleClassChangeError())).iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(67)]
		internal _1(AbstractDirectedNetworkConnections P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(79)]
		public override int size()
		{
			int result = IntMath.saturatedAdd(this_00240.inEdgeMap.size(), this_00240.outEdgeMap.size() - access_0024000(this_00240));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(84)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (this_00240.inEdgeMap.containsKey(P_0) || this_00240.outEdgeMap.containsKey(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(67)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/util/Map<TE;TN;>;")]
	internal Map inEdgeMap;

	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/util/Map<TE;TN;>;")]
	internal Map outEdgeMap;

	private int selfLoopCount;

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	internal static int access_0024000(AbstractDirectedNetworkConnections P_0)
	{
		return P_0.selfLoopCount;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set predecessors();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set successors();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TE;TN;>;Ljava/util/Map<TE;TN;>;I)V")]
	[LineNumberTable(new byte[] { 3, 104, 113, 113, 108, 125 })]
	internal AbstractDirectedNetworkConnections(Map P_0, Map P_1, int P_2)
	{
		inEdgeMap = (Map)Preconditions.checkNotNull(P_0);
		outEdgeMap = (Map)Preconditions.checkNotNull(P_1);
		selfLoopCount = Graphs.checkNonNegative(P_2);
		Preconditions.checkState((P_2 <= P_0.size() && P_2 <= P_1.size()) ? true : false);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(62)]
	public virtual Set adjacentNodes()
	{
		Sets.SetView result = Sets.union(predecessors(), successors());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(67)]
	public virtual Set incidentEdges()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(91)]
	public virtual Set inEdges()
	{
		Set result = Collections.unmodifiableSet(inEdgeMap.keySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(96)]
	public virtual Set outEdges()
	{
		Set result = Collections.unmodifiableSet(outEdgeMap.keySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TN;")]
	[LineNumberTable(104)]
	public virtual object adjacentNode(object P_0)
	{
		object result = java.util.Objects.requireNonNull(outEdgeMap.get(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)TN;")]
	[LineNumberTable(new byte[] { 159, 115, 98, 99, 153, 141 })]
	public virtual object removeInEdge(object P_0, bool P_1)
	{
		if (P_1)
		{
			int num = selfLoopCount - 1;
			selfLoopCount = num;
			Graphs.checkNonNegative(num);
		}
		object obj = inEdgeMap.remove(P_0);
		object result = java.util.Objects.requireNonNull(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TN;")]
	[LineNumberTable(new byte[] { 69, 141 })]
	public virtual object removeOutEdge(object P_0)
	{
		object obj = outEdgeMap.remove(P_0);
		object result = java.util.Objects.requireNonNull(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TN;Z)V")]
	[LineNumberTable(new byte[] { 159, 111, 130, 103, 135, 99, 153, 110, 110 })]
	public virtual void addInEdge(object P_0, object P_1, bool P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		if (P_2)
		{
			int num = selfLoopCount + 1;
			selfLoopCount = num;
			Graphs.checkPositive(num);
		}
		object obj = inEdgeMap.put(P_0, P_1);
		Preconditions.checkState(obj == null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TN;)V")]
	[LineNumberTable(new byte[] { 88, 103, 135, 110, 110 })]
	public virtual void addOutEdge(object P_0, object P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		object obj = outEdgeMap.put(P_0, P_1);
		Preconditions.checkState(obj == null);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set edgesConnecting(object P_0);
}
