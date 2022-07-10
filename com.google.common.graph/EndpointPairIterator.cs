using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.graph;

[Signature("<N:Ljava/lang/Object;>Lcom/google/common/collect/AbstractIterator<Lcom/google/common/graph/EndpointPair<TN;>;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/graph/ElementTypesAreNonnullByDefault;"
})]
internal abstract class EndpointPairIterator : com.google.common.collect.AbstractIterator
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal new class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/EndpointPairIterator<TN;>;")]
	internal sealed class Directed : EndpointPairIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(72)]
		internal Directed(BaseGraph P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/BaseGraph<TN;>;)V")]
		[LineNumberTable(new byte[] { 24, 106 })]
		private Directed(BaseGraph P_0)
			: base(P_0, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/EndpointPair<TN;>;")]
		[LineNumberTable(new byte[] { 31, 141, 158, 104 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal new virtual EndpointPair computeNext()
		{
			do
			{
				if (successorIterator.hasNext())
				{
					EndpointPair result = EndpointPair.ordered(java.util.Objects.requireNonNull(node), successorIterator.next());
					_ = null;
					return result;
				}
			}
			while (advance());
			return (EndpointPair)endOfData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(72)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			EndpointPair result = computeNext();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<N:Ljava/lang/Object;>Lcom/google/common/graph/EndpointPairIterator<TN;>;")]
	[ConstantPool(new object[]
	{
		(byte)28,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class Undirected : EndpointPairIterator
	{
		[Signature("Ljava/util/Set<TN;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 3, 0, 0, 28, 0, 0 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Set visitedNodes;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(118)]
		internal Undirected(BaseGraph P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/graph/BaseGraph<TN;>;)V")]
		[LineNumberTable(new byte[] { 73, 106, 120 })]
		private Undirected(BaseGraph P_0)
			: base(P_0, null)
		{
			visitedNodes = Sets.newHashSetWithExpectedSize(P_0.nodes().size() + 1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/graph/EndpointPair<TN;>;")]
		[LineNumberTable(new byte[] { 85, 108, 109, 108, 142, 148, 130, 114, 104, 103 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal new virtual EndpointPair computeNext()
		{
			do
			{
				java.util.Objects.requireNonNull(visitedNodes);
				while (successorIterator.hasNext())
				{
					object obj = successorIterator.next();
					if (!visitedNodes.contains(obj))
					{
						EndpointPair result = EndpointPair.unordered(java.util.Objects.requireNonNull(node), obj);
						_ = null;
						return result;
					}
				}
				visitedNodes.add(node);
			}
			while (advance());
			visitedNodes = null;
			return (EndpointPair)endOfData();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(118)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			EndpointPair result = computeNext();
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/graph/BaseGraph<TN;>;")]
	private BaseGraph graph;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Iterator<TN;>;")]
	private Iterator nodeIterator;

	[Signature("TN;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal object node;

	[Signature("Ljava/util/Iterator<TN;>;")]
	internal Iterator successorIterator;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<N:Ljava/lang/Object;>(Lcom/google/common/graph/BaseGraph<TN;>;)Lcom/google/common/graph/EndpointPairIterator<TN;>;")]
	[LineNumberTable(46)]
	internal static EndpointPairIterator of(BaseGraph P_0)
	{
		EndpointPairIterator result = ((!P_0.isDirected()) ? ((EndpointPairIterator)new Undirected(P_0, null)) : ((EndpointPairIterator)new Directed(P_0, null)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/graph/BaseGraph<TN;>;)V")]
	[LineNumberTable(new byte[] { 159, 191, 232, 55, 167, 240, 71, 103, 113 })]
	private EndpointPairIterator(BaseGraph P_0)
	{
		node = null;
		successorIterator = ImmutableSet.of().iterator();
		graph = P_0;
		nodeIterator = P_0.nodes().iterator();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 9, 118, 109, 130, 113, 124 })]
	internal bool advance()
	{
		Preconditions.checkState((!successorIterator.hasNext()) ? true : false);
		if (!nodeIterator.hasNext())
		{
			return false;
		}
		node = nodeIterator.next();
		successorIterator = graph.successors(node).iterator();
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal EndpointPairIterator(BaseGraph P_0, _1 P_1)
		: this(P_0)
	{
	}
}
