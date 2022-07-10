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

[ConstantPool(new object[]
{
	(byte)33,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class SortedMultisets : Object
{
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Multisets$ElementSet<TE;>;Ljava/util/SortedSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 69, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)69,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.SortedSet" })]
	internal class ElementSet : Multisets.ElementSet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/SortedMultiset<TE;>;")]
		private new SortedMultiset m_multiset;

		[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
		internal new SortedMultiset multiset()
		{
			return this.m_multiset;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/SortedMultiset<TE;>;)V")]
		[LineNumberTable(new byte[] { 0, 104, 103 })]
		internal ElementSet(SortedMultiset P_0)
		{
			this.m_multiset = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(61)]
		public override Iterator iterator()
		{
			Iterator result = Multisets.elementIterator(multiset().entrySet().iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TE;>;")]
		[LineNumberTable(66)]
		public virtual Comparator comparator()
		{
			Comparator result = multiset().comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(71)]
		public virtual SortedSet subSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			NavigableSet result = multiset().subMultiset(P_0, BoundType.___003C_003ECLOSED, P_1, BoundType.___003C_003EOPEN).elementSet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(76)]
		public virtual SortedSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			NavigableSet result = multiset().headMultiset(P_0, BoundType.___003C_003EOPEN).elementSet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Ljava/util/SortedSet<TE;>;")]
		[LineNumberTable(81)]
		public virtual SortedSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			NavigableSet result = multiset().tailMultiset(P_0, BoundType.___003C_003ECLOSED).elementSet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(87)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object first()
		{
			object result = access_0024000(multiset().firstEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(93)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object last()
		{
			object result = access_0024000(multiset().lastEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(45)]
		internal override Multiset multiset()
		{
			SortedMultiset result = multiset();
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		Spliterator SortedSet.SortedSet_003A_003Aspliterator()
		{
			return spliterator();
		}

		bool Set.Set_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Set.Set_003A_003AtoArray()
		{
			return toArray();
		}

		object[] Set.Set_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		bool Set.Set_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Set.Set_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Set.Set_003A_003AhashCode()
		{
			return hashCode();
		}

		Spliterator Set.Set_003A_003Aspliterator()
		{
			return spliterator();
		}

		bool Collection.Collection_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		Spliterator Collection.Collection_003A_003Aspliterator()
		{
			return spliterator();
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Collection.Collection_003A_003AremoveIf(Predicate P_0)
		{
			return removeIf(P_0);
		}

		bool Collection.Collection_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Collection.Collection_003A_003AhashCode()
		{
			return hashCode();
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

		Spliterator Iterable.Iterable_003A_003Aspliterator()
		{
			return spliterator();
		}
	}

	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/SortedMultisets$ElementSet<TE;>;Ljava/util/NavigableSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 80, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)80,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.NavigableSet" })]
	internal class NavigableElementSet : ElementSet, NavigableSet, SortedSet, Set, Collection, Iterable, IEnumerable
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/SortedMultiset<TE;>;)V")]
		[LineNumberTable(new byte[] { 52, 105 })]
		internal NavigableElementSet(SortedMultiset P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(131)]
		public virtual NavigableSet descendingSet()
		{
			NavigableElementSet result = new NavigableElementSet(multiset().descendingMultiset());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(108)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object lower([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = access_0024100(multiset().headMultiset(P_0, BoundType.___003C_003EOPEN).lastEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(114)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object floor([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = access_0024100(multiset().headMultiset(P_0, BoundType.___003C_003ECLOSED).lastEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(120)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object ceiling([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = access_0024100(multiset().tailMultiset(P_0, BoundType.___003C_003ECLOSED).firstEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)TE;")]
		[LineNumberTable(126)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object higher([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = access_0024100(multiset().tailMultiset(P_0, BoundType.___003C_003EOPEN).firstEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(136)]
		public virtual Iterator descendingIterator()
		{
			Iterator result = descendingSet().iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(142)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollFirst()
		{
			object result = access_0024100(multiset().pollFirstEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(148)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object pollLast()
		{
			object result = access_0024100(multiset().pollLastEntry());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;ZTE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 159, 103, 101, 97, 135, 103, 5, 12 })]
		public virtual NavigableSet subSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_2, bool P_3)
		{
			NavigableElementSet result = new NavigableElementSet(multiset().subMultiset(P_0, BoundType.forBoolean(P_1), P_2, BoundType.forBoolean(P_3)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 159, 101, 130, 97, 56 })]
		public virtual NavigableSet headSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableElementSet result = new NavigableElementSet(multiset().headMultiset(P_0, BoundType.forBoolean(P_1)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;Z)Ljava/util/NavigableSet<TE;>;")]
		[LineNumberTable(new byte[] { 159, 99, 66, 97, 56 })]
		public virtual NavigableSet tailSet([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, bool P_1)
		{
			NavigableElementSet result = new NavigableElementSet(multiset().tailMultiset(P_0, BoundType.forBoolean(P_1)));
			_ = null;
			return result;
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}

		Spliterator SortedSet.SortedSet_003A_003Aspliterator()
		{
			return spliterator();
		}

		bool Set.Set_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Set.Set_003A_003AtoArray()
		{
			return toArray();
		}

		object[] Set.Set_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		bool Set.Set_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Set.Set_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Set.Set_003A_003AhashCode()
		{
			return hashCode();
		}

		Spliterator Set.Set_003A_003Aspliterator()
		{
			return spliterator();
		}

		bool Collection.Collection_003A_003Aadd(object P_0)
		{
			return add(P_0);
		}

		object[] Collection.Collection_003A_003AtoArray(object[] P_0)
		{
			return toArray(P_0);
		}

		Spliterator Collection.Collection_003A_003Aspliterator()
		{
			return spliterator();
		}

		object[] Collection.Collection_003A_003AtoArray()
		{
			return toArray();
		}

		bool Collection.Collection_003A_003AaddAll(Collection P_0)
		{
			return addAll(P_0);
		}

		bool Collection.Collection_003A_003AremoveIf(Predicate P_0)
		{
			return removeIf(P_0);
		}

		bool Collection.Collection_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Collection.Collection_003A_003AhashCode()
		{
			return hashCode();
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

		Spliterator Iterable.Iterable_003A_003Aspliterator()
		{
			return spliterator();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	internal static object access_0024000(Multiset.Entry P_0)
	{
		object elementOrThrow = getElementOrThrow(P_0);
		_ = null;
		return elementOrThrow;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	internal static object access_0024100(Multiset.Entry P_0)
	{
		object elementOrNull = getElementOrNull(P_0);
		_ = null;
		return elementOrNull;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset$Entry<TE;>;)TE;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 33, 0, 0 })]
	[LineNumberTable(186)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private static object getElementOrNull([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Multiset.Entry P_0)
	{
		object result = P_0?.getElement();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset$Entry<TE;>;)TE;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 33, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 64, 99, 139 })]
	private static object getElementOrThrow([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Multiset.Entry P_0)
	{
		if (P_0 == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		object element = P_0.getElement();
		_ = null;
		return element;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(42)]
	private SortedMultisets()
	{
	}
}
