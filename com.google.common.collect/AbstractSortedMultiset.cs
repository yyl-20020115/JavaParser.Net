using System;
using System.Collections;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultiset<TE;>;Lcom/google/common/collect/SortedMultiset<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 108, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)108,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SortedMultiset" })]
internal abstract class AbstractSortedMultiset : AbstractMultiset, SortedMultiset, SortedMultisetBridge, Multiset, Collection, Iterable, IEnumerable, SortedIterable
{
	[SpecialName]
	[Signature("Lcom/google/common/collect/DescendingMultiset<TE;>;")]
	[EnclosingMethod(null, "createDescendingMultiset", "()Lcom.google.common.collect.SortedMultiset;")]
	internal class _1DescendingMultisetImpl : DescendingMultiset
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractSortedMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(135)]
		internal _1DescendingMultisetImpl(AbstractSortedMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
		internal override SortedMultiset forwardMultiset()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(143)]
		internal override Iterator entryIterator()
		{
			Iterator result = this_00240.descendingEntryIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(148)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.descendingIterator();
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/util/Comparator<-TE;>;")]
	[GwtTransient(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/GwtTransient;"
	})]
	internal Comparator comparator;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private SortedMultiset m_descendingMultiset;

	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	internal abstract Iterator descendingEntryIterator();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(122)]
	internal virtual Iterator descendingIterator()
	{
		Iterator result = Multisets.iteratorImpl(descendingMultiset());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 190, 104, 113 })]
	internal AbstractSortedMultiset(Comparator P_0)
	{
		this.comparator = (Comparator)Preconditions.checkNotNull(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract SortedMultiset tailMultiset(object P_0, BoundType P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 79, 103 })]
	public virtual SortedMultiset descendingMultiset()
	{
		SortedMultiset sortedMultiset = this.m_descendingMultiset;
		SortedMultiset result;
		if (sortedMultiset == null)
		{
			SortedMultiset sortedMultiset2 = createDescendingMultiset();
			result = sortedMultiset2;
			this.m_descendingMultiset = sortedMultiset2;
		}
		else
		{
			result = sortedMultiset;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(151)]
	internal virtual SortedMultiset createDescendingMultiset()
	{
		_1DescendingMultisetImpl result = new _1DescendingMultisetImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(59)]
	internal new virtual NavigableSet createElementSet()
	{
		SortedMultisets.NavigableElementSet result = new SortedMultisets.NavigableElementSet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(54)]
	public new virtual NavigableSet elementSet()
	{
		return (NavigableSet)base.elementSet();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 187, 109 })]
	internal AbstractSortedMultiset()
		: this(Ordering.natural())
	{
	}

	[Signature("()Ljava/util/Comparator<-TE;>;")]
	public virtual Comparator comparator()
	{
		return this.comparator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(new byte[] { 20, 103 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry firstEntry()
	{
		Iterator iterator = entryIterator();
		return (!iterator.hasNext()) ? null : ((Multiset.Entry)iterator.next());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(new byte[] { 27, 103 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry lastEntry()
	{
		Iterator iterator = descendingEntryIterator();
		return (!iterator.hasNext()) ? null : ((Multiset.Entry)iterator.next());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(new byte[] { 34, 103, 104, 108, 114, 102, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry pollFirstEntry()
	{
		Iterator iterator = entryIterator();
		if (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			entry = Multisets.immutableEntry(entry.getElement(), entry.getCount());
			iterator.remove();
			return entry;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(new byte[] { 47, 103, 104, 108, 114, 102, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry pollLastEntry()
	{
		Iterator iterator = descendingEntryIterator();
		if (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			entry = Multisets.immutableEntry(entry.getElement(), entry.getCount());
			iterator.remove();
			return entry;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 64, 103, 104 })]
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
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_3);
		SortedMultiset result = tailMultiset(P_0, P_1).headMultiset(P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal override Set createElementSet()
	{
		NavigableSet result = createElementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Set elementSet()
	{
		NavigableSet result = this.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public new virtual SortedSet elementSet()
	{
		NavigableSet result = this.elementSet();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract override int count(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEachEntry(ObjIntConsumer P_0)
	{
		Multiset._003Cdefault_003EforEachEntry(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract SortedMultiset headMultiset(object P_0, BoundType P_1);

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	Iterator SortedMultiset.SortedMultiset_003A_003Aiterator()
	{
		return iterator();
	}

	SortedSet SortedMultiset.SortedMultiset_003A_003AelementSet()
	{
		return this.elementSet();
	}

	Set SortedMultiset.SortedMultiset_003A_003AelementSet()
	{
		return this.elementSet();
	}

	int Multiset.Multiset_003A_003Asize()
	{
		return size();
	}

	Iterator Multiset.Multiset_003A_003Aiterator()
	{
		return iterator();
	}

	bool Multiset.Multiset_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	void Multiset.Multiset_003A_003AforEach(Consumer P_0)
	{
		forEach(P_0);
	}

	Spliterator Multiset.Multiset_003A_003Aspliterator()
	{
		return spliterator();
	}

	object[] Collection.Collection_003A_003AtoArray(object[] P_0)
	{
		return toArray(P_0);
	}

	Iterator Collection.Collection_003A_003Aiterator()
	{
		return iterator();
	}

	Spliterator Collection.Collection_003A_003Aspliterator()
	{
		return spliterator();
	}

	int Collection.Collection_003A_003Asize()
	{
		return size();
	}

	object[] Collection.Collection_003A_003AtoArray()
	{
		return toArray();
	}

	bool Collection.Collection_003A_003AcontainsAll(Collection P_0)
	{
		return containsAll(P_0);
	}

	bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
	{
		return removeIf(P_0);
	}

	Stream Collection.Collection_003A_003Astream()
	{
		return stream();
	}

	Stream Collection.Collection_003A_003AparallelStream()
	{
		return parallelStream();
	}

	Iterator Iterable.Iterable_003A_003Aiterator()
	{
		return iterator();
	}

	void Iterable.Iterable_003A_003AforEach(Consumer P_0)
	{
		forEach(P_0);
	}

	Spliterator Iterable.Iterable_003A_003Aspliterator()
	{
		return spliterator();
	}

	Iterator SortedIterable.SortedIterable_003A_003Aiterator()
	{
		return iterator();
	}
}
