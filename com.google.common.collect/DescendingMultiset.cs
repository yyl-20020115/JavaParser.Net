using System;
using System.Collections;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMultiset<TE;>;Lcom/google/common/collect/SortedMultiset<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 107, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)107,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SortedMultiset" })]
internal abstract class DescendingMultiset : ForwardingMultiset, SortedMultiset, SortedMultisetBridge, Multiset, Collection, Iterable, IEnumerable, SortedIterable
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/Multisets$EntrySet<TE;>;")]
	[EnclosingMethod(null, "createEntrySet", "()Ljava.util.Set;")]
	internal class _1EntrySetImpl : Multisets.EntrySet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DescendingMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(129)]
		internal _1EntrySetImpl(DescendingMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[Signature("()Lcom/google/common/collect/Multiset<TE;>;")]
		internal override Multiset multiset()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(137)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.entryIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(142)]
		public override int size()
		{
			int result = this_00240.forwardMultiset().entrySet().size();
			_ = null;
			return result;
		}
	}

	[NonSerialized]
	[Signature("Ljava/util/Comparator<-TE;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Comparator m_comparator;

	[NonSerialized]
	[Signature("Ljava/util/NavigableSet<TE;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new NavigableSet m_elementSet;

	[NonSerialized]
	[Signature("Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new Set m_entrySet;

	[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
	internal abstract SortedMultiset forwardMultiset();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(145)]
	internal virtual Set createEntrySet()
	{
		_1EntrySetImpl result = new _1EntrySetImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(new byte[] { 73, 103 })]
	public override Set entrySet()
	{
		Set set = this.m_entrySet;
		Set result;
		if (set == null)
		{
			Set set2 = createEntrySet();
			result = set2;
			this.m_entrySet = set2;
		}
		else
		{
			result = set;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(new byte[] { 5, 103, 99, 146 })]
	public new virtual NavigableSet elementSet()
	{
		NavigableSet navigableSet = this.m_elementSet;
		if (navigableSet == null)
		{
			SortedMultisets.NavigableElementSet result = new SortedMultisets.NavigableElementSet(this);
			this.m_elementSet = result;
			return result;
		}
		return navigableSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset<TE;>;")]
	[LineNumberTable(97)]
	protected internal override Multiset @delegate()
	{
		SortedMultiset result = forwardMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(36)]
	internal DescendingMultiset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<-TE;>;")]
	[LineNumberTable(new byte[] { 159, 186, 103, 99, 159, 2 })]
	public virtual Comparator comparator()
	{
		Comparator comparator = this.m_comparator;
		if (comparator == null)
		{
			Ordering result = Ordering.from(forwardMultiset().comparator()).reverse();
			this.m_comparator = result;
			return result;
		}
		return comparator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(65)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry pollFirstEntry()
	{
		Multiset.Entry result = forwardMultiset().pollLastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(71)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry pollLastEntry()
	{
		Multiset.Entry result = forwardMultiset().pollFirstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(76)]
	public virtual SortedMultiset headMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, BoundType P_1)
	{
		SortedMultiset result = forwardMultiset().tailMultiset(P_0, P_1).descendingMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 35, 107, 101, 7 })]
	public virtual SortedMultiset subMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, BoundType P_1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_2, BoundType P_3)
	{
		SortedMultiset result = forwardMultiset().subMultiset(P_2, P_3, P_0, P_1).descendingMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(92)]
	public virtual SortedMultiset tailMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, BoundType P_1)
	{
		SortedMultiset result = forwardMultiset().headMultiset(P_0, P_1).descendingMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(102)]
	public virtual SortedMultiset descendingMultiset()
	{
		SortedMultiset result = forwardMultiset();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(108)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry firstEntry()
	{
		Multiset.Entry result = forwardMultiset().lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(114)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry lastEntry()
	{
		Multiset.Entry result = forwardMultiset().firstEntry();
		_ = null;
		return result;
	}

	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	internal abstract Iterator entryIterator();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(150)]
	public override Iterator iterator()
	{
		Iterator result = Multisets.iteratorImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 107, 0, 0 })]
	[LineNumberTable(155)]
	public override object[] toArray()
	{
		object[] result = standardToArray();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 107, 0, 0 })]
	[LineNumberTable(161)]
	public override object[] toArray(object[] P_0)
	{
		object[] result = standardToArray(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(166)]
	public override string toString()
	{
		string result = java.lang.Object.instancehelper_toString(entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public override Set elementSet()
	{
		NavigableSet result = this.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	protected internal new virtual Collection @delegate()
	{
		Multiset result = this.@delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	protected internal new virtual object @delegate()
	{
		Multiset result = this.@delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(34)]
	public new virtual SortedSet elementSet()
	{
		NavigableSet result = this.elementSet();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(Consumer P_0)
	{
		Multiset._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Spliterator spliterator()
	{
		return Multiset._003Cdefault_003Espliterator(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool removeIf(Predicate P_0)
	{
		return Collection._003Cdefault_003EremoveIf(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Stream stream()
	{
		return Collection._003Cdefault_003Estream(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Stream parallelStream()
	{
		return Collection._003Cdefault_003EparallelStream(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEachEntry(ObjIntConsumer P_0)
	{
		Multiset._003Cdefault_003EforEachEntry(this, P_0);
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	SortedSet SortedMultiset.SortedMultiset_003A_003AelementSet()
	{
		return this.elementSet();
	}

	Set SortedMultiset.SortedMultiset_003A_003AelementSet()
	{
		return this.elementSet();
	}
}
