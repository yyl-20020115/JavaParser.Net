using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.math;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/Network<TN;TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.Network" })]
public abstract class AbstractNetwork : Object, Network, SuccessorsFunction, PredecessorsFunction
{
	[SpecialName]
	[Signature("Lcom/google/common/graph/AbstractGraph<TN;>;")]
	[EnclosingMethod(null, "asGraph", "()Lcom.google.common.graph.Graph;")]
	internal class _1 : AbstractGraph
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/util/AbstractSet<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
		[EnclosingMethod(null, "edges", "()Ljava.util.Set;")]
		internal new class _1 : AbstractSet
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<TE;Lcom/google/common/graph/EndpointPair<TN;>;>;")]
			[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
			[Implements(new string[] { "com.google.common.base.Function" })]
			internal class _1 : Object, com.google.common.@base.Function, java.util.function.Function
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal AbstractNetwork._1._1 this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(TE;)Lcom/google/common/graph/EndpointPair<TN;>;")]
				[LineNumberTable(79)]
				public virtual EndpointPair apply(object P_0)
				{
					EndpointPair result = this_00242.this_00241.this_00240.incidentNodes(P_0);
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(76)]
				internal _1(AbstractNetwork._1._1 P_0)
				{
					this_00242 = P_0;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(76)]
				public virtual object apply(object P_0)
				{
					EndpointPair result = this.apply(P_0);
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

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal AbstractNetwork._1 this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(71)]
			internal _1(AbstractNetwork._1 P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
			[LineNumberTable(new byte[] { 24, 107, 48 })]
			public override Iterator iterator()
			{
				Iterator result = Iterators.transform(this_00241.this_00240.edges().iterator(), new _1(this));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(86)]
			public override int size()
			{
				int result = this_00241.this_00240.edges().size();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 45, 104, 130, 103, 116, 121, 27 })]
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
				return (((AbstractBaseGraph)this_00241).isOrderingCompatible(endpointPair) && this_00241.nodes().contains(endpointPair.nodeU()) && this_00241.successors(endpointPair.nodeU()).contains(endpointPair.nodeV())) ? true : false;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractNetwork this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TN;>;")]
		[LineNumberTable(61)]
		public override Set nodes()
		{
			Set result = this_00240.nodes();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(140)]
		public override Set successors(object P_0)
		{
			Set result = this_00240.successors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(135)]
		public override Set predecessors(object P_0)
		{
			Set result = this_00240.predecessors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(58)]
		internal _1(AbstractNetwork P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
		[LineNumberTable(new byte[] { 16, 109, 201 })]
		public override Set edges()
		{
			if (this_00240.allowsParallelEdges())
			{
				Set result = base.edges();
				_ = null;
				return result;
			}
			_1 result2 = new _1(this);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
		[LineNumberTable(108)]
		public override ElementOrder nodeOrder()
		{
			ElementOrder result = this_00240.nodeOrder();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
		[LineNumberTable(115)]
		public override ElementOrder incidentEdgeOrder()
		{
			ElementOrder result = ElementOrder.unordered();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(120)]
		public override bool isDirected()
		{
			bool result = this_00240.isDirected();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(125)]
		public override bool allowsSelfLoops()
		{
			bool result = this_00240.allowsSelfLoops();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TN;)Ljava/util/Set<TN;>;")]
		[LineNumberTable(130)]
		public override Set adjacentNodes(object P_0)
		{
			Set result = this_00240.adjacentNodes(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(58)]
		public override Iterable successors(object P_0)
		{
			Set result = this.successors(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(58)]
		public override Iterable predecessors(object P_0)
		{
			Set result = this.predecessors(P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Predicate<TE;>;")]
	[EnclosingMethod(null, "connectedPredicate", "(Ljava.lang.Object;Ljava.lang.Object;)Lcom.google.common.base.Predicate;")]
	[Implements(new string[] { "com.google.common.base.Predicate" })]
	internal class _2 : Object, com.google.common.@base.Predicate, java.util.function.Predicate
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024nodePresent;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024nodeToCheck;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractNetwork this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(190)]
		internal _2(AbstractNetwork P_0, object P_1, object P_2)
		{
			this_00240 = P_0;
			val_0024nodePresent = P_1;
			val_0024nodeToCheck = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(193)]
		public virtual bool apply(object P_0)
		{
			bool result = Object.instancehelper_equals(this_00240.incidentNodes(P_0).adjacentNode(val_0024nodePresent), val_0024nodeToCheck);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool test(object P_0)
		{
			return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate and(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate negate()
		{
			return java.util.function.Predicate._003Cdefault_003Enegate(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Predicate or(java.util.function.Predicate P_0)
		{
			return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
		}

		bool com.google.common.@base.Predicate.Predicate_003A_003Aequals(object P_0)
		{
			return Object.instancehelper_equals(this, P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<TE;Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	[EnclosingMethod(null, "edgeIncidentNodesMap", "(Lcom.google.common.graph.Network;)Ljava.util.Map;")]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class _3 : Object, com.google.common.@base.Function, java.util.function.Function
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Network val_0024network;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(296)]
		internal _3(Network P_0)
		{
			val_0024network = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Lcom/google/common/graph/EndpointPair<TN;>;")]
		[LineNumberTable(299)]
		public virtual EndpointPair apply(object P_0)
		{
			EndpointPair result = val_0024network.incidentNodes(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(296)]
		public virtual object apply(object P_0)
		{
			EndpointPair result = this.apply(P_0);
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
	public abstract EndpointPair incidentNodes(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set edges();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set nodes();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract bool allowsParallelEdges();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract ElementOrder nodeOrder();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract bool isDirected();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract bool allowsSelfLoops();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set adjacentNodes(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set predecessors(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set successors(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set inEdges(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set outEdges(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set incidentEdges(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(new byte[] { 126, 104, 104, 110, 117, 21 })]
	public virtual Set edgesConnecting(object nodeU, object nodeV)
	{
		Set set = outEdges(nodeU);
		Set set2 = inEdges(nodeV);
		Set result = ((set.size() > set2.size()) ? Collections.unmodifiableSet(Sets.filter(set2, connectedPredicate(nodeV, nodeU))) : Collections.unmodifiableSet(Sets.filter(set, connectedPredicate(nodeU, nodeV))));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(new byte[] { 99, 104, 159, 1 })]
	public virtual int degree(object node)
	{
		if (isDirected())
		{
			int result = IntMath.saturatedAdd(inEdges(node).size(), outEdges(node).size());
			_ = null;
			return result;
		}
		int result2 = IntMath.saturatedAdd(incidentEdges(node).size(), edgesConnecting(node, node).size());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Lcom/google/common/base/Predicate<TE;>;")]
	[LineNumberTable(190)]
	private com.google.common.@base.Predicate connectedPredicate(object P_0, object P_1)
	{
		_2 result = new _2(this, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<*>;)V")]
	[LineNumberTable(new byte[] { 160, 137, 103, 115 })]
	protected internal void validateEndpoints(EndpointPair endpoints)
	{
		Preconditions.checkNotNull(endpoints);
		Preconditions.checkArgument(isOrderingCompatible(endpoints), (object)"Mismatch: unordered endpoints cannot be used with directed graphs");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)TE;")]
	[LineNumberTable(new byte[] { 160, 98, 105, 151, 130, 142 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object edgeConnectingOrNull(object nodeU, object nodeV)
	{
		Set set = edgesConnecting(nodeU, nodeV);
		switch (set.size())
		{
		case 0:
			return null;
		case 1:
		{
			object result = set.iterator().next();
			_ = null;
			return result;
		}
		default:
		{
			string s = String.format("Cannot call edgeConnecting() when parallel edges exist between %s and %s. Consider calling edgesConnecting() instead.", nodeU, nodeV);
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Ljava/util/Optional<TE;>;")]
	[LineNumberTable(200)]
	public virtual java.util.Optional edgeConnecting(object nodeU, object nodeV)
	{
		java.util.Optional result = java.util.Optional.ofNullable(edgeConnectingOrNull(nodeU, nodeV));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<*>;)Z")]
	[LineNumberTable(256)]
	protected internal bool isOrderingCompatible(EndpointPair endpoints)
	{
		return (endpoints.isOrdered() || !isDirected()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Z")]
	[LineNumberTable(new byte[] { 160, 118, 103, 103 })]
	public virtual bool hasEdgeConnecting(object nodeU, object nodeV)
	{
		Preconditions.checkNotNull(nodeU);
		Preconditions.checkNotNull(nodeV);
		return (nodes().contains(nodeU) && this.successors(nodeU).contains(nodeV)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;E:Ljava/lang/Object;>(Lcom/google/common/graph/Network<TN;TE;>;)Ljava/util/Map<TE;Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	[LineNumberTable(new byte[] { 160, 181, 231, 71 })]
	private static Map edgeIncidentNodesMap(Network P_0)
	{
		_3 function = new _3(P_0);
		Map result = Maps.asMap(P_0.edges(), function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(54)]
	public AbstractNetwork()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/Graph<TN;>;")]
	[LineNumberTable(58)]
	public virtual Graph asGraph()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(158)]
	public virtual int inDegree(object node)
	{
		int result = ((!isDirected()) ? degree(node) : inEdges(node).size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(163)]
	public virtual int outDegree(object node)
	{
		int result = ((!isDirected()) ? degree(node) : outEdges(node).size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(new byte[] { 118, 104, 98, 124 })]
	public virtual Set adjacentEdges(object edge)
	{
		EndpointPair endpointPair = incidentNodes(edge);
		Sets.SetView set = Sets.union(incidentEdges(endpointPair.nodeU()), incidentEdges(endpointPair.nodeV()));
		Sets.SetView result = Sets.difference(set, ImmutableSet.of(edge));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Set<TE;>;")]
	[LineNumberTable(new byte[] { 160, 71, 103 })]
	public virtual Set edgesConnecting(EndpointPair endpoints)
	{
		validateEndpoints(endpoints);
		Set result = edgesConnecting(endpoints.nodeU(), endpoints.nodeV());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Ljava/util/Optional<TE;>;")]
	[LineNumberTable(new byte[] { 160, 91, 103 })]
	public virtual java.util.Optional edgeConnecting(EndpointPair endpoints)
	{
		validateEndpoints(endpoints);
		java.util.Optional result = edgeConnecting(endpoints.nodeU(), endpoints.nodeV());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)TE;")]
	[LineNumberTable(new byte[] { 160, 112, 103 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object edgeConnectingOrNull(EndpointPair endpoints)
	{
		validateEndpoints(endpoints);
		object result = edgeConnectingOrNull(endpoints.nodeU(), endpoints.nodeV());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	[LineNumberTable(new byte[] { 160, 125, 103, 105, 130 })]
	public virtual bool hasEdgeConnecting(EndpointPair endpoints)
	{
		Preconditions.checkNotNull(endpoints);
		if (!isOrderingCompatible(endpoints))
		{
			return false;
		}
		bool result = hasEdgeConnecting(endpoints.nodeU(), endpoints.nodeV());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 147, 100, 130, 104, 130, 135, 111, 115, 22 })]
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
		if (!(obj is Network))
		{
			return false;
		}
		Network network = (Network)obj;
		return (isDirected() == network.isDirected() && nodes().equals(network.nodes()) && edgeIncidentNodesMap(this).equals(edgeIncidentNodesMap(network))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(276)]
	public sealed override int hashCode()
	{
		int result = edgeIncidentNodesMap(this).hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160,
		168,
		97,
		135,
		135,
		135,
		140,
		byte.MaxValue,
		109,
		55
	})]
	public override string toString()
	{
		int b = (isDirected() ? 1 : 0);
		int b2 = (allowsParallelEdges() ? 1 : 0);
		int b3 = (allowsSelfLoops() ? 1 : 0);
		string text = String.valueOf(nodes());
		string text2 = String.valueOf(edgeIncidentNodesMap(this));
		int num = 87 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text2));
		num = num;
		string result = new StringBuilder(num).append("isDirected: ").append((byte)b != 0).append(", allowsParallelEdges: ")
			.append((byte)b2 != 0)
			.append(", allowsSelfLoops: ")
			.append((byte)b3 != 0)
			.append(", nodes: ")
			.append(text)
			.append(", edges: ")
			.append(text2)
			.toString();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Iterable successors(object P_0)
	{
		return Network._003Cdefault_003E_003Cbridge_003Esuccessors(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Iterable predecessors(object P_0)
	{
		return Network._003Cdefault_003E_003Cbridge_003Epredecessors(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract ElementOrder edgeOrder();

	Iterable Network.Network_003A_003Asuccessors(object P_0)
	{
		return this.successors(P_0);
	}

	Iterable Network.Network_003A_003Apredecessors(object P_0)
	{
		return this.predecessors(P_0);
	}
}
