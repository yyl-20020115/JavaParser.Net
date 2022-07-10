using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using com.google.common.math;
using com.google.common.primitives;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/graph/BaseGraph<TN;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.graph.BaseGraph" })]
internal abstract class AbstractBaseGraph : Object, BaseGraph, SuccessorsFunction, PredecessorsFunction
{
	[SpecialName]
	[Signature("Ljava/util/AbstractSet<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	[EnclosingMethod(null, "edges", "()Ljava.util.Set;")]
	internal class _1 : AbstractSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractBaseGraph this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
		[LineNumberTable(70)]
		public new virtual UnmodifiableIterator iterator()
		{
			EndpointPairIterator result = EndpointPairIterator.of(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(67)]
		internal _1(AbstractBaseGraph P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(75)]
		public override int size()
		{
			int result = Ints.saturatedCast(this_00240.edgeCount());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(80)]
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
		[LineNumberTable(new byte[] { 39, 104, 130, 103, 116, 121, 27 })]
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
			return (this_00240.isOrderingCompatible(endpointPair) && this_00240.nodes().contains(endpointPair.nodeU()) && this_00240.successors(endpointPair.nodeU()).contains(endpointPair.nodeV())) ? true : false;
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

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/graph/IncidentEdgeSet<TN;>;")]
	[EnclosingMethod(null, "incidentEdges", "(Ljava.lang.Object;)Ljava.util.Set;")]
	internal class _2 : IncidentEdgeSet
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : com.google.common.@base.Function
		{
			private readonly _2 arg_00241;

			internal ___003C_003EAnon0(_2 P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(object P_0)
			{
				EndpointPair result = arg_00241.lambda_0024iterator_00240(P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public bool equals(object P_0)
			{
				return Object.instancehelper_equals(this, P_0);
			}

			[SpecialName]
			public java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[SpecialName]
			public java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon1 : com.google.common.@base.Function
		{
			private readonly _2 arg_00241;

			internal ___003C_003EAnon1(_2 P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(object P_0)
			{
				EndpointPair result = arg_00241.lambda_0024iterator_00241(P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public bool equals(object P_0)
			{
				return Object.instancehelper_equals(this, P_0);
			}

			[SpecialName]
			public java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[SpecialName]
			public java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon2 : com.google.common.@base.Function
		{
			private readonly _2 arg_00241;

			internal ___003C_003EAnon2(_2 P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(object P_0)
			{
				EndpointPair result = arg_00241.lambda_0024iterator_00242(P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public bool equals(object P_0)
			{
				return Object.instancehelper_equals(this, P_0);
			}

			[SpecialName]
			public java.util.function.Function compose(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
			}

			[SpecialName]
			public java.util.function.Function andThen(java.util.function.Function P_0)
			{
				return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(109)]
		internal _2(AbstractBaseGraph P_0, BaseGraph P_1, object P_2)
			: base(P_1, P_2)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
		[LineNumberTable(new byte[]
		{
			62, 109, 172, 53, 241, 69, 31, 6, 229, 60,
			37, 232, 74, 140, 53, 37
		})]
		public new virtual UnmodifiableIterator iterator()
		{
			if (graph.isDirected())
			{
				UnmodifiableIterator result = Iterators.unmodifiableIterator(Iterators.concat(Iterators.transform(graph.predecessors(node).iterator(), new ___003C_003EAnon0(this)), Iterators.transform(Sets.difference(graph.successors(node), ImmutableSet.of(node)).iterator(), new ___003C_003EAnon1(this))));
				_ = null;
				return result;
			}
			UnmodifiableIterator result2 = Iterators.unmodifiableIterator(Iterators.transform(graph.adjacentNodes(node).iterator(), new ___003C_003EAnon2(this)));
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(117)]
		private EndpointPair lambda_0024iterator_00240(object P_0)
		{
			EndpointPair result = EndpointPair.ordered(P_0, node);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(121)]
		private EndpointPair lambda_0024iterator_00241(object P_0)
		{
			EndpointPair result = EndpointPair.ordered(node, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(126)]
		private EndpointPair lambda_0024iterator_00242(object P_0)
		{
			EndpointPair result = EndpointPair.unordered(node, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(109)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 99, 123, 107, 130, 109 })]
	protected internal virtual long edgeCount()
	{
		long num = 0L;
		Iterator iterator = nodes().iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			num += degree(obj);
		}
		Preconditions.checkState((num & 1) == 0);
		return (long)((ulong)num >> 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<*>;)Z")]
	[LineNumberTable(181)]
	protected internal bool isOrderingCompatible(EndpointPair P_0)
	{
		return (P_0.isOrdered() || !isDirected()) ? true : false;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set nodes();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set successors(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(new byte[] { 84, 104, 159, 1, 104, 118 })]
	public virtual int degree(object P_0)
	{
		if (isDirected())
		{
			int result = IntMath.saturatedAdd(this.predecessors(P_0).size(), this.successors(P_0).size());
			_ = null;
			return result;
		}
		Set set = adjacentNodes(P_0);
		int b = ((allowsSelfLoops() && set.contains(P_0)) ? 1 : 0);
		int result2 = IntMath.saturatedAdd(set.size(), b);
		_ = null;
		return result2;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract bool isDirected();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set predecessors(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set adjacentNodes(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract bool allowsSelfLoops();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(44)]
	internal AbstractBaseGraph()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	[LineNumberTable(67)]
	public virtual Set edges()
	{
		_1 result = new _1(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/graph/ElementOrder<TN;>;")]
	[LineNumberTable(102)]
	public virtual ElementOrder incidentEdgeOrder()
	{
		ElementOrder result = ElementOrder.unordered();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)Ljava/util/Set<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
	[LineNumberTable(new byte[] { 57, 103, 119 })]
	public virtual Set incidentEdges(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkArgument(nodes().contains(P_0), "Node %s is not an element of this graph.", P_0);
		_2 result = new _2(this, this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(145)]
	public virtual int inDegree(object P_0)
	{
		int result = ((!isDirected()) ? degree(P_0) : this.predecessors(P_0).size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;)I")]
	[LineNumberTable(150)]
	public virtual int outDegree(object P_0)
	{
		int result = ((!isDirected()) ? degree(P_0) : this.successors(P_0).size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TN;TN;)Z")]
	[LineNumberTable(new byte[] { 105, 103, 103 })]
	public virtual bool hasEdgeConnecting(object P_0, object P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		return (nodes().contains(P_0) && this.successors(P_0).contains(P_1)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<TN;>;)Z")]
	[LineNumberTable(new byte[] { 112, 103, 105, 130, 103, 103 })]
	public virtual bool hasEdgeConnecting(EndpointPair P_0)
	{
		Preconditions.checkNotNull(P_0);
		if (!isOrderingCompatible(P_0))
		{
			return false;
		}
		object obj = P_0.nodeU();
		object o = P_0.nodeV();
		return (nodes().contains(obj) && this.successors(obj).contains(o)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/EndpointPair<*>;)V")]
	[LineNumberTable(new byte[] { 126, 103, 115 })]
	protected internal void validateEndpoints(EndpointPair P_0)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkArgument(isOrderingCompatible(P_0), (object)"Mismatch: unordered endpoints cannot be used with directed graphs");
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Iterable successors(object P_0)
	{
		return BaseGraph._003Cdefault_003Esuccessors(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Iterable predecessors(object P_0)
	{
		return BaseGraph._003Cdefault_003Epredecessors(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract ElementOrder nodeOrder();
}
