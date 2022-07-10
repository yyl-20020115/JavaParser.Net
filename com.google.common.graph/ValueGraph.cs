using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/BaseGraph<TN;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.BaseGraph" })]
public interface ValueGraph : BaseGraph, SuccessorsFunction, PredecessorsFunction
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static Iterable successors(ValueGraph P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Esuccessors(P_0, P_1);
		}

		public unsafe static Iterable predecessors(ValueGraph P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Epredecessors(P_0, P_1);
		}
	}

	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	Set successors(object obj);

	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	Set predecessors(object obj);

	[Signature("()Ljava/util/Set<TN;>;")]
	Set nodes();

	[Signature("()Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	Set edges();

	[Signature("()Lcom/google/common/graph/Graph<TN;>;")]
	virtual Graph asGraph();

	bool isDirected();

	bool allowsSelfLoops();

	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	ElementOrder nodeOrder();

	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	ElementOrder incidentEdgeOrder();

	[Signature("(TN;)Ljava/util/Set<TN;>;")]
	Set adjacentNodes(object obj);

	[Signature("(TN;)Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	Set incidentEdges(object obj);

	[Signature("(TN;)I")]
	int degree(object obj);

	[Signature("(TN;)I")]
	int inDegree(object obj);

	[Signature("(TN;)I")]
	int outDegree(object obj);

	[Signature("(TN;TN;)Z")]
	bool hasEdgeConnecting(object obj1, object obj2);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	bool hasEdgeConnecting(EndpointPair ep);

	[Signature("(TN;TN;)Ljava/util/Optional<TV;>;")]
	virtual Optional edgeValue(object obj1, object obj2);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Optional<TV;>;")]
	virtual Optional edgeValue(EndpointPair ep);

	[Signature("(TN;TN;TV;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object edgeValueOrDefault(object obj1, object obj2, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj3);

	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;TV;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object edgeValueOrDefault(EndpointPair ep, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual int hashCode();

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Iterable _003Cbridge_003Esuccessors(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(110)]
	static Iterable _003Cdefault_003E_003Cbridge_003Esuccessors(ValueGraph P_0, object P_1)
	{
		Set result = P_0.successors(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Iterable _003Cbridge_003Epredecessors(object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(110)]
	static Iterable _003Cdefault_003E_003Cbridge_003Epredecessors(ValueGraph P_0, object P_1)
	{
		Set result = P_0.predecessors(P_1);
		_ = null;
		return result;
	}
}
