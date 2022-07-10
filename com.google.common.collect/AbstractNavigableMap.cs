using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/Maps$IteratorBasedAbstractMap<TK;TV;>;Ljava/util/NavigableMap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 111, 0, 0,
	17, 1, 0, 0, 0, 111, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)111,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.NavigableMap" })]
internal abstract class AbstractNavigableMap : Maps.IteratorBasedAbstractMap, NavigableMap, SortedMap, Map
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

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Maps$DescendingMap<TK;TV;>;")]
	internal sealed class DescendingMap : Maps.DescendingMap
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractNavigableMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(175)]
		internal DescendingMap(AbstractNavigableMap P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(175)]
		private DescendingMap(AbstractNavigableMap P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
		internal override NavigableMap forward()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(183)]
		internal override Iterator entryIterator()
		{
			Iterator result = this_00240.descendingEntryIterator();
			_ = null;
			return result;
		}
	}

	[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
	internal abstract Iterator descendingEntryIterator();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(47)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry firstEntry()
	{
		return (Map.Entry)Iterators.getNext(entryIterator(), null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(53)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry lastEntry()
	{
		return (Map.Entry)Iterators.getNext(descendingEntryIterator(), null);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract NavigableMap headMap(object P_0, bool P_1);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract NavigableMap tailMap(object P_0, bool P_1);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(93)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry lowerEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Map.Entry result = headMap(P_0, false).lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(99)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry floorEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Map.Entry result = headMap(P_0, true).lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(105)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry ceilingEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Map.Entry result = tailMap(P_0, true).firstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(111)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry higherEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Map.Entry result = tailMap(P_0, false).firstEntry();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract NavigableMap subMap(object P_0, bool P_1, object P_2, bool P_3);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TK;>;")]
	[LineNumberTable(157)]
	public virtual NavigableSet navigableKeySet()
	{
		Maps.NavigableKeySet result = new Maps.NavigableKeySet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableMap<TK;TV;>;")]
	[LineNumberTable(172)]
	public virtual NavigableMap descendingMap()
	{
		DescendingMap result = new DescendingMap(this, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(37)]
	internal AbstractNavigableMap()
	{
	}

	[Signature("(Ljava/lang/Object;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public abstract override object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(59)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry pollFirstEntry()
	{
		return (Map.Entry)Iterators.pollNext(entryIterator());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
	[LineNumberTable(65)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry pollLastEntry()
	{
		return (Map.Entry)Iterators.pollNext(descendingEntryIterator());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TK;")]
	[LineNumberTable(new byte[] { 21, 103, 99, 139 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object firstKey()
	{
		Map.Entry entry = firstEntry();
		if (entry == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		object key = entry.getKey();
		_ = null;
		return key;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TK;")]
	[LineNumberTable(new byte[] { 32, 103, 99, 139 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object lastKey()
	{
		Map.Entry entry = lastEntry();
		if (entry == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		object key = entry.getKey();
		_ = null;
		return key;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(117)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object lowerKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		object result = Maps.keyOrNull(lowerEntry(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(123)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object floorKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		object result = Maps.keyOrNull(floorEntry(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(129)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object ceilingKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		object result = Maps.keyOrNull(ceilingEntry(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TK;")]
	[LineNumberTable(135)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object higherKey([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		object result = Maps.keyOrNull(higherEntry(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;TK;)Ljava/util/SortedMap<TK;TV;>;")]
	[LineNumberTable(142)]
	public virtual SortedMap subMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1)
	{
		NavigableMap result = subMap(P_0, true, P_1, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
	[LineNumberTable(147)]
	public virtual SortedMap headMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		NavigableMap result = headMap(P_0, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/SortedMap<TK;TV;>;")]
	[LineNumberTable(152)]
	public virtual SortedMap tailMap([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		NavigableMap result = tailMap(P_0, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TK;>;")]
	[LineNumberTable(162)]
	public override Set keySet()
	{
		NavigableSet result = navigableKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TK;>;")]
	[LineNumberTable(167)]
	public virtual NavigableSet descendingKeySet()
	{
		NavigableSet result = descendingMap().navigableKeySet();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Comparator comparator();

	Collection SortedMap.SortedMap_003A_003Avalues()
	{
		return values();
	}

	object Map.Map_003A_003Aput(object P_0, object P_1)
	{
		return put(P_0, P_1);
	}

	object Map.Map_003A_003Aremove(object P_0)
	{
		return remove(P_0);
	}

	void Map.Map_003A_003AputAll(Map P_0)
	{
		putAll(P_0);
	}

	object Map.Map_003A_003AputIfAbsent(object P_0, object P_1)
	{
		return putIfAbsent(P_0, P_1);
	}

	Collection Map.Map_003A_003Avalues()
	{
		return values();
	}

	bool Map.Map_003A_003AcontainsKey(object P_0)
	{
		return containsKey(P_0);
	}

	bool Map.Map_003A_003AisEmpty()
	{
		return isEmpty();
	}

	bool Map.Map_003A_003AcontainsValue(object P_0)
	{
		return containsValue(P_0);
	}

	bool Map.Map_003A_003Aequals(object P_0)
	{
		return equals(P_0);
	}

	int Map.Map_003A_003AhashCode()
	{
		return hashCode();
	}

	object Map.Map_003A_003AgetOrDefault(object P_0, object P_1)
	{
		return getOrDefault(P_0, P_1);
	}

	void Map.Map_003A_003AforEach(BiConsumer P_0)
	{
		forEach(P_0);
	}

	void Map.Map_003A_003AreplaceAll(BiFunction P_0)
	{
		replaceAll(P_0);
	}

	bool Map.Map_003A_003Aremove(object P_0, object P_1)
	{
		return remove(P_0, P_1);
	}

	bool Map.Map_003A_003Areplace(object P_0, object P_1, object P_2)
	{
		return replace(P_0, P_1, P_2);
	}

	object Map.Map_003A_003Areplace(object P_0, object P_1)
	{
		return replace(P_0, P_1);
	}

	object Map.Map_003A_003AcomputeIfAbsent(object P_0, Function P_1)
	{
		return computeIfAbsent(P_0, P_1);
	}

	object Map.Map_003A_003AcomputeIfPresent(object P_0, BiFunction P_1)
	{
		return computeIfPresent(P_0, P_1);
	}

	object Map.Map_003A_003Acompute(object P_0, BiFunction P_1)
	{
		return compute(P_0, P_1);
	}

	object Map.Map_003A_003Amerge(object P_0, object P_1, BiFunction P_2)
	{
		return merge(P_0, P_1, P_2);
	}
}
