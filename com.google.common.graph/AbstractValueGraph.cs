using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/graph/AbstractBaseGraph<TN;>;Lcom/google/common/graph/ValueGraph<TN;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.ValueGraph" })]
public abstract class AbstractValueGraph : AbstractBaseGraph, ValueGraph, BaseGraph, SuccessorsFunction, PredecessorsFunction
{
	[SpecialName]
	[Signature("Lcom/google/common/graph/AbstractGraph<TN;>;")]
	[EnclosingMethod(null, "asGraph", "()Lcom.google.common.graph.Graph;")]
	internal new class _1 : AbstractGraph
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractValueGraph this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(91)]
		public override Set successors(object P_0)
		{
			Set result = this_00240.successors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(86)]
		public override Set predecessors(object P_0)
		{
			Set result = this_00240.predecessors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(48)]
		internal _1(AbstractValueGraph P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TN;>;")]
		[LineNumberTable(51)]
		public override Set nodes()
		{
			Set result = this_00240.nodes();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
		[LineNumberTable(56)]
		public override Set edges()
		{
			Set result = this_00240.edges();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(61)]
		public override bool isDirected()
		{
			bool result = this_00240.isDirected();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(66)]
		public override bool allowsSelfLoops()
		{
			bool result = this_00240.allowsSelfLoops();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
		[LineNumberTable(71)]
		public override ElementOrder nodeOrder()
		{
			ElementOrder result = this_00240.nodeOrder();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
		[LineNumberTable(76)]
		public override ElementOrder incidentEdgeOrder()
		{
			ElementOrder result = this_00240.incidentEdgeOrder();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(81)]
		public override Set adjacentNodes(object P_0)
		{
			Set result = this_00240.adjacentNodes(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)I")]
		[LineNumberTable(96)]
		public override int degree(object P_0)
		{
			int result = this_00240.degree(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)I")]
		[LineNumberTable(101)]
		public override int inDegree(object P_0)
		{
			int result = this_00240.inDegree(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)I")]
		[LineNumberTable(106)]
		public override int outDegree(object P_0)
		{
			int result = this_00240.outDegree(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(48)]
		public override Iterable successors(object P_0)
		{
			Set result = this.successors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(48)]
		public override Iterable predecessors(object P_0)
		{
			Set result = this.predecessors(P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Lcom/google/common/graph/EndpointPair<TN;>;TV;>;")]
	[EnclosingMethod(null, "edgeValueMap", "(Lcom.google.common.graph.ValueGraph;)Ljava.util.Map;")]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal new class _2 : Object, com.google.common.@base.Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ValueGraph val_0024graph;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(156)]
		internal _2(ValueGraph P_0)
		{
			val_0024graph = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)TV;")]
		[LineNumberTable(160)]
		public virtual object apply(EndpointPair P_0)
		{
			object result = java.util.Objects.requireNonNull(val_0024graph.edgeValueOrDefault(P_0.nodeU(), P_0.nodeV(), null));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(156)]
		public virtual object apply(object P_0)
		{
			object result = apply((EndpointPair)P_0);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}

		bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override Set nodes();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override Set edges()
	{
		Set result = base.edges();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override bool isDirected();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override bool allowsSelfLoops();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override ElementOrder nodeOrder();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override ElementOrder incidentEdgeOrder()
	{
		ElementOrder result = base.incidentEdgeOrder();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override Set adjacentNodes(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override Set predecessors(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override Set successors(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override int degree(object obj)
	{
		int result = base.degree(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override int inDegree(object obj)
	{
		int result = base.inDegree(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override int outDegree(object obj)
	{
		int result = base.outDegree(obj);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract object edgeValueOrDefault(object P_0, object P_1, object P_2);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract object edgeValueOrDefault(EndpointPair P_0, object P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/graph/ValueGraph<TN;TV;>;)Ljava/util/Map<Lcom/google/common/graph/EndpointPair<TN;>;TV;>;")]
	[LineNumberTable(new byte[] { 105, 231, 72 })]
	private static Map edgeValueMap(ValueGraph P_0)
	{
		_2 function = new _2(P_0);
		Map result = Maps.asMap(P_0.edges(), function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	public AbstractValueGraph()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/Graph<TN;>;")]
	[LineNumberTable(48)]
	public virtual Graph asGraph()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Ljava/util/Optional<TV;>;")]
	[LineNumberTable(113)]
	public virtual java.util.Optional edgeValue(object nodeU, object nodeV)
	{
		java.util.Optional result = java.util.Optional.ofNullable(edgeValueOrDefault(nodeU, nodeV, null));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Optional<TV;>;")]
	[LineNumberTable(118)]
	public virtual java.util.Optional edgeValue(EndpointPair endpoints)
	{
		java.util.Optional result = java.util.Optional.ofNullable(edgeValueOrDefault(endpoints, null));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 73, 100, 130, 104, 130, 135, 111, 115, 22 })]
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
		if (!(obj is ValueGraph))
		{
			return false;
		}
		ValueGraph valueGraph = (ValueGraph)obj;
		return (isDirected() == valueGraph.isDirected() && nodes().equals(valueGraph.nodes()) && edgeValueMap(this).equals(edgeValueMap(valueGraph))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(138)]
	public sealed override int hashCode()
	{
		int result = edgeValueMap(this).hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		94,
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
		string text2 = String.valueOf(edgeValueMap(this));
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
	[LineNumberTable(41)]
	public override bool hasEdgeConnecting(EndpointPair ep)
	{
		bool result = base.hasEdgeConnecting(ep);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override bool hasEdgeConnecting(object obj1, object obj2)
	{
		bool result = base.hasEdgeConnecting(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override Set incidentEdges(object obj)
	{
		Set result = base.incidentEdges(obj);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Iterable successors(object P_0)
	{
		return ValueGraph._003Cdefault_003E_003Cbridge_003Esuccessors(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Iterable predecessors(object P_0)
	{
		return ValueGraph._003Cdefault_003E_003Cbridge_003Epredecessors(this, P_0);
	}

	Iterable ValueGraph.ValueGraph_003A_003Asuccessors(object P_0)
	{
		return this.successors(P_0);
	}

	Iterable ValueGraph.ValueGraph_003A_003Apredecessors(object P_0)
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
