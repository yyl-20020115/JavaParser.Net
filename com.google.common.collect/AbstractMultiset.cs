using System;
using System.Collections;
using System.Runtime.CompilerServices;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;Lcom/google/common/collect/Multiset<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 114, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)114,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.Multiset" })]
internal abstract class AbstractMultiset : AbstractCollection, Multiset, Collection, Iterable, IEnumerable
{
	[Signature("Lcom/google/common/collect/Multisets$ElementSet<TE;>;")]
	internal class ElementSet : Multisets.ElementSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(150)]
		internal ElementSet(AbstractMultiset P_0)
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
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(158)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.elementIterator();
			_ = null;
			return result;
		}
	}

	[Signature("Lcom/google/common/collect/Multisets$EntrySet<TE;>;")]
	internal class EntrySet : Multisets.EntrySet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(176)]
		internal EntrySet(AbstractMultiset P_0)
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
		[LineNumberTable(184)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.entryIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(189)]
		public override int size()
		{
			int result = this_00240.distinctElements();
			_ = null;
			return result;
		}
	}

	[NonSerialized]
	[Signature("Ljava/util/Set<TE;>;")]
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
	private Set m_elementSet;

	[NonSerialized]
	[Signature("Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
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
	private Set m_entrySet;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(new byte[] { 118, 103, 99, 142 })]
	public virtual Set entrySet()
	{
		Set set = this.m_entrySet;
		if (set == null)
		{
			set = (this.m_entrySet = createEntrySet());
		}
		return set;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract int count(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(72)]
	public virtual int add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, int P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(84)]
	public virtual int remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, int P_1)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(146)]
	internal virtual Set createElementSet()
	{
		ElementSet result = new ElementSet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(194)]
	internal virtual Set createEntrySet()
	{
		EntrySet result = new EntrySet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(47)]
	internal AbstractMultiset()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public override bool isEmpty()
	{
		bool result = entrySet().isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return count(P_0) > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(new byte[] { 15, 105 })]
	public sealed override bool add([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		add(P_0, 1);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(78)]
	public sealed override bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return remove(P_0, 1) > 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(90)]
	public virtual int setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, int P_1)
	{
		int result = Multisets.setCountImpl(this, P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;II)Z")]
	[LineNumberTable(96)]
	public virtual bool setCount([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, int P_1, int P_2)
	{
		bool result = Multisets.setCountImpl(this, P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<+TE;>;)Z")]
	[LineNumberTable(110)]
	public sealed override bool addAll(Collection P_0)
	{
		bool result = Multisets.addAllImpl(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(116)]
	public sealed override bool removeAll(Collection P_0)
	{
		bool result = Multisets.removeAllImpl(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(122)]
	public sealed override bool retainAll(Collection P_0)
	{
		bool result = Multisets.retainAllImpl(this, P_0);
		_ = null;
		return result;
	}

	public abstract override void clear();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(new byte[] { 84, 103, 99, 142 })]
	public virtual Set elementSet()
	{
		Set set = this.m_elementSet;
		if (set == null)
		{
			set = (this.m_elementSet = createElementSet());
		}
		return set;
	}

	[Signature("()Ljava/util/Iterator<TE;>;")]
	internal abstract Iterator elementIterator();

	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	internal abstract Iterator entryIterator();

	internal abstract int distinctElements();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(211)]
	public sealed override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = Multisets.equalsImpl(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(221)]
	public sealed override int hashCode()
	{
		int result = entrySet().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(232)]
	public sealed override string toString()
	{
		string result = java.lang.Object.instancehelper_toString(entrySet());
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEachEntry(ObjIntConsumer P_0)
	{
		Multiset._003Cdefault_003EforEachEntry(this, P_0);
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
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

	bool Collection.Collection_003A_003AremoveIf(Predicate P_0)
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
}
