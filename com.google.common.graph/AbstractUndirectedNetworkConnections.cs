using System.Runtime.CompilerServices;
using com.google.common.@base;
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
internal abstract class AbstractUndirectedNetworkConnections : Object, NetworkConnections
{
	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/util/Map<TE;TN;>;")]
	internal Map incidentEdgeMap;

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set adjacentNodes();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(56)]
	public virtual Set incidentEdges()
	{
		Set result = Collections.unmodifiableSet(incidentEdgeMap.keySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TN;")]
	[LineNumberTable(new byte[] { 36, 141 })]
	public virtual object removeOutEdge(object P_0)
	{
		object obj = incidentEdgeMap.remove(P_0);
		object result = java.util.Objects.requireNonNull(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;TN;)V")]
	[LineNumberTable(new byte[] { 50, 110, 110 })]
	public virtual void addOutEdge(object P_0, object P_1)
	{
		object obj = incidentEdgeMap.put(P_0, P_1);
		Preconditions.checkState(obj == null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TE;TN;>;)V")]
	[LineNumberTable(new byte[] { 159, 182, 104, 113 })]
	internal AbstractUndirectedNetworkConnections(Map P_0)
	{
		incidentEdgeMap = (Map)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(46)]
	public virtual Set predecessors()
	{
		Set result = adjacentNodes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TN;>;")]
	[LineNumberTable(51)]
	public virtual Set successors()
	{
		Set result = adjacentNodes();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(61)]
	public virtual Set inEdges()
	{
		Set result = incidentEdges();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(66)]
	public virtual Set outEdges()
	{
		Set result = incidentEdges();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)TN;")]
	[LineNumberTable(72)]
	public virtual object adjacentNode(object P_0)
	{
		object result = java.util.Objects.requireNonNull(incidentEdgeMap.get(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Z)TN;")]
	[LineNumberTable(new byte[] { 159, 123, 130, 99, 138 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object removeInEdge(object P_0, bool P_1)
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
	[LineNumberTable(new byte[] { 159, 119, 98, 99, 138 })]
	public virtual void addInEdge(object P_0, object P_1, bool P_2)
	{
		if (!P_2)
		{
			addOutEdge(P_0, P_1);
		}
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set edgesConnecting(object P_0);
}
