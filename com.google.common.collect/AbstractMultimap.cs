using System;
using System.Collections;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/Multimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 168, 0, 0,
	17, 1, 0, 0, 0, 168, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)168,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractMultimap : java.lang.Object, Multimap
{
	[Signature("Lcom/google/common/collect/Multimaps$Entries<TK;TV;>;")]
	internal class Entries : Multimaps.Entries
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(125)]
		internal Entries(AbstractMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[Signature("()Lcom/google/common/collect/Multimap<TK;TV;>;")]
		internal override Multimap multimap()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(133)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.entryIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(138)]
		public override Spliterator spliterator()
		{
			Spliterator result = this_00240.entrySpliterator();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/AbstractMultimap<TK;TV;>.Entries;Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[Implements(new string[] { "java.util.Set" })]
	internal class EntrySet : Entries, Set, Collection, Iterable, IEnumerable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(143)]
		internal EntrySet(AbstractMultimap P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(146)]
		public override int hashCode()
		{
			int result = Sets.hashCodeImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(151)]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = Sets.equalsImpl(this, P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		bool Set.Set_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		bool Set.Set_003A_003AisEmpty()
		{
			return isEmpty();
		}

		object[] Set.Set_003A_003AtoArray()
		{
			return toArray();
		}

		object[] Set.Set_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		bool Set.Set_003A_003AcontainsAll(Collection P_0)
		{
			return containsAll(P_0);
		}

		bool Set.Set_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Set.Set_003A_003AretainAll(Collection P_0)
		{
			return retainAll(P_0);
		}

		bool Set.Set_003A_003AremoveAll(Collection P_0)
		{
			return removeAll(P_0);
		}

		bool Collection.Collection_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		bool Collection.Collection_003A_003AisEmpty()
		{
			return isEmpty();
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AcontainsAll(Collection P_0)
		{
			return containsAll(P_0);
		}

		bool Collection.Collection_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Collection.Collection_003A_003AremoveAll(Collection P_0)
		{
			return removeAll(P_0);
		}

		bool Collection.Collection_003A_003AremoveIf(java.util.function.Predicate P_0)
		{
			return removeIf(P_0);
		}

		bool Collection.Collection_003A_003AretainAll(Collection P_0)
		{
			return retainAll(P_0);
		}

		Stream Collection.Collection_003A_003Astream()
		{
			return stream();
		}

		Stream Collection.Collection_003A_003AparallelStream()
		{
			return parallelStream();
		}

		void Iterable.Iterable_003A_003AforEach(Consumer P_0)
		{
			forEach(P_0);
		}
	}

	[Signature("Ljava/util/AbstractCollection<TV;>;")]
	internal class Values : AbstractCollection
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMultimap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(193)]
		internal Values(AbstractMultimap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TV;>;")]
		[LineNumberTable(196)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.valueIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TV;>;")]
		[LineNumberTable(201)]
		public override Spliterator spliterator()
		{
			Spliterator result = this_00240.valueSpliterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(206)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(211)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = this_00240.containsValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 102, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}
	}

	[NonSerialized]
	[Signature("Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Collection m_entries;

	[NonSerialized]
	[Signature("Ljava/util/Set<TK;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Set m_keySet;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/Multiset<TK;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Multiset m_keys;

	[NonSerialized]
	[Signature("Ljava/util/Collection<TV;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Collection m_values;

	[NonSerialized]
	[Signature("Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Map m_asMap;

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract int size();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(new byte[] { 160, 118, 103 })]
	public virtual Map asMap()
	{
		Map map = this.m_asMap;
		Map result;
		if (map == null)
		{
			Map map2 = createAsMap();
			result = map2;
			this.m_asMap = map2;
		}
		else
		{
			result = map;
		}
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Collection get(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TV;)Z")]
	[LineNumberTable(77)]
	public virtual bool put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1)
	{
		bool result = get(P_0).add(P_1);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Collection removeAll(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Z")]
	[LineNumberTable(new byte[] { 33, 167, 104, 103, 156, 103 })]
	public virtual bool putAll([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		Preconditions.checkNotNull(P_1);
		if (P_1 is Collection)
		{
			Collection collection = (Collection)P_1;
			return (!collection.isEmpty() && get(P_0).addAll(collection)) ? true : false;
		}
		Iterator iterator = P_1.iterator();
		return (iterator.hasNext() && Iterators.addAll(get(P_0), iterator)) ? true : false;
	}

	[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal abstract Collection createEntries();

	[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal abstract Iterator entryIterator();

	[Signature("()Ljava/util/Set<TK;>;")]
	internal abstract Set createKeySet();

	[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
	internal abstract Multiset createKeys();

	[Signature("()Ljava/util/Collection<TV;>;")]
	internal abstract Collection createValues();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 68, 103 })]
	public virtual Collection entries()
	{
		Collection collection = this.m_entries;
		Collection result;
		if (collection == null)
		{
			Collection collection2 = createEntries();
			result = collection2;
			this.m_entries = collection2;
		}
		else
		{
			result = collection;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TV;>;")]
	[LineNumberTable(221)]
	internal virtual Iterator valueIterator()
	{
		Iterator result = Maps.valueIterator(entries().iterator());
		_ = null;
		return result;
	}

	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	internal abstract Map createAsMap();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	internal AbstractMultimap()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(47)]
	public virtual bool isEmpty()
	{
		return (size() == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 2, 127, 6, 105, 130, 130 })]
	public virtual bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Iterator iterator = asMap().values().iterator();
		while (iterator.hasNext())
		{
			Collection collection = (Collection)iterator.next();
			if (collection.contains(P_0))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 114 })]
	public virtual bool containsEntry([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		Collection collection = (Collection)asMap().get(P_0);
		return (collection != null && collection.contains(P_1)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 20, 114 })]
	public virtual bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		Collection collection = (Collection)asMap().get(P_0);
		return (collection != null && collection.remove(P_1)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multimap<+TK;+TV;>;)Z")]
	[LineNumberTable(new byte[] { 48, 98, 127, 1, 117, 98 })]
	public virtual bool putAll(Multimap P_0)
	{
		int num = 0;
		Iterator iterator = P_0.entries().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			num |= (put(entry.getKey(), entry.getValue()) ? 1 : 0);
		}
		return (byte)num != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 58, 103, 104, 105 })]
	public virtual Collection replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		Preconditions.checkNotNull(P_1);
		Collection result = removeAll(P_0);
		putAll(P_0, P_1);
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(new byte[] { 108, 97, 56 })]
	internal virtual Spliterator entrySpliterator()
	{
		Spliterator result = Spliterators.spliterator(entryIterator(), size(), (this is SetMultimap) ? 1 : 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(new byte[] { 116, 103 })]
	public virtual Set keySet()
	{
		Set set = this.m_keySet;
		Set result;
		if (set == null)
		{
			Set set2 = createKeySet();
			result = set2;
			this.m_keySet = set2;
		}
		else
		{
			result = set;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset<TK;>;")]
	[LineNumberTable(new byte[] { 126, 103 })]
	public virtual Multiset keys()
	{
		Multiset multiset = this.m_keys;
		Multiset result;
		if (multiset == null)
		{
			Multiset multiset2 = createKeys();
			result = multiset2;
			this.m_keys = multiset2;
		}
		else
		{
			result = multiset;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 160, 72, 103 })]
	public virtual Collection values()
	{
		Collection collection = this.m_values;
		Collection result;
		if (collection == null)
		{
			Collection collection2 = createValues();
			result = collection2;
			this.m_values = collection2;
		}
		else
		{
			result = collection;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TV;>;")]
	[LineNumberTable(225)]
	internal virtual Spliterator valueSpliterator()
	{
		Spliterator result = Spliterators.spliterator(valueIterator(), size(), 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(242)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = Multimaps.equalsImpl(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(255)]
	public override int hashCode()
	{
		int result = asMap().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(266)]
	public override string toString()
	{
		string result = java.lang.Object.instancehelper_toString(asMap());
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract bool containsKey(object P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract void clear();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEach(BiConsumer P_0)
	{
		Multimap._003Cdefault_003EforEach(this, P_0);
	}
}
