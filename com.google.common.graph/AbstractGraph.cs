using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/AbstractBaseGraph<TN;>;Lcom/google/common/graph/Graph<TN;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.Graph" })]
public abstract class AbstractGraph : AbstractBaseGraph, Graph, BaseGraph, SuccessorsFunction, PredecessorsFunction
{
	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override bool isDirected();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override Set nodes();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override Set edges()
	{
		Set result = base.edges();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override bool allowsSelfLoops();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(32)]
	public AbstractGraph()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 178, 100, 130, 104, 130, 135, 111, 115, 22 })]
	public sealed override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (!(obj is Graph))
		{
			return false;
		}
		Graph graph = (Graph)obj;
		return (isDirected() == graph.isDirected() && nodes().equals(graph.nodes()) && edges().equals(graph.edges())) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(51)]
	public sealed override int hashCode()
	{
		int result = edges().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		7,
		97,
		135,
		135,
		140,
		byte.MaxValue,
		90,
		57
	})]
	public override string toString()
	{
		int b = (isDirected() ? 1 : 0);
		int b2 = (allowsSelfLoops() ? 1 : 0);
		string text = String.valueOf(nodes());
		string text2 = String.valueOf(edges());
		int num = 59 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text2));
		num = num;
		string result = new StringBuilder(num).append("isDirected: ").append((byte)b != 0).append(", allowsSelfLoops: ")
			.append((byte)b2 != 0)
			.append(", nodes: ")
			.append(text)
			.append(", edges: ")
			.append(text2)
			.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override bool hasEdgeConnecting(EndpointPair ep)
	{
		bool result = base.hasEdgeConnecting(ep);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override bool hasEdgeConnecting(object obj1, object obj2)
	{
		bool result = base.hasEdgeConnecting(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override int outDegree(object obj)
	{
		int result = base.outDegree(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override int inDegree(object obj)
	{
		int result = base.inDegree(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override int degree(object obj)
	{
		int result = base.degree(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override Set incidentEdges(object obj)
	{
		Set result = base.incidentEdges(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override ElementOrder incidentEdgeOrder()
	{
		ElementOrder result = base.incidentEdgeOrder();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Iterable successors(object P_0)
	{
		return Graph._003Cdefault_003E_003Cbridge_003Esuccessors(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Iterable predecessors(object P_0)
	{
		return Graph._003Cdefault_003E_003Cbridge_003Epredecessors(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override ElementOrder nodeOrder();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override Set adjacentNodes(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override Set predecessors(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override Set successors(object P_0);

	Iterable Graph.Graph_003A_003Asuccessors(object P_0)
	{
		return this.successors(P_0);
	}

	Iterable Graph.Graph_003A_003Apredecessors(object P_0)
	{
		return this.predecessors(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|edgeCount", "()J")]
	protected internal new long edgeCount()
	{
		return ((AbstractBaseGraph)this).edgeCount();
	}

	[HideFromJava]
	protected internal long _003Cnonvirtual_003E0()
	{
		return base.edgeCount();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|validateEndpoints", "(Lcom.google.common.graph.EndpointPair;)V")]
	protected internal new void validateEndpoints(EndpointPair P_0)
	{
		((AbstractBaseGraph)this).validateEndpoints(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|isOrderingCompatible", "(Lcom.google.common.graph.EndpointPair;)Z")]
	protected internal new bool isOrderingCompatible(EndpointPair P_0)
	{
		return ((AbstractBaseGraph)this).isOrderingCompatible(P_0);
	}
}
