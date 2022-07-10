using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.math;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultiset<TE;>;Ljava/io/Serializable;")]
[ConstantPool(new object[]
{
	(byte)142,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public sealed class ConcurrentHashMultiset : AbstractMultiset, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/ForwardingSet<TE;>;")]
	[EnclosingMethod(null, "createElementSet", "()Ljava.util.Set;")]
	internal class _1 : ForwardingSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Set val_0024delegate;

		[Signature("()Ljava/util/Set<TE;>;")]
		protected internal override Set @delegate()
		{
			return val_0024delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(452)]
		internal _1(ConcurrentHashMultiset P_0, Set P_1)
		{
			val_0024delegate = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(460)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (P_0 != null && Collections2.safeContains(val_0024delegate, P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(465)]
		public override bool containsAll(Collection P_0)
		{
			bool result = standardContainsAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(470)]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (P_0 != null && Collections2.safeRemove(val_0024delegate, P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(475)]
		public override bool removeAll(Collection P_0)
		{
			bool result = standardRemoveAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(452)]
		protected internal new virtual Collection @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(452)]
		protected internal new virtual object @delegate()
		{
			Set result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/AbstractIterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
	internal class _2 : AbstractIterator
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Iterator<Ljava/util/Map$Entry<TE;Ljava/util/concurrent/atomic/AtomicInteger;>;>;")]
		private Iterator mapEntries;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ConcurrentHashMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 137, 111, 103, 52 })]
		internal _2(ConcurrentHashMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			mapEntries = access_0024100(this_00240).entrySet().iterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[LineNumberTable(new byte[] { 161, 145, 109, 140, 113, 113, 99, 143 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal new virtual Multiset.Entry computeNext()
		{
			Map.Entry entry;
			int num;
			do
			{
				if (!mapEntries.hasNext())
				{
					return (Multiset.Entry)endOfData();
				}
				entry = (Map.Entry)mapEntries.next();
				num = ((AtomicInteger)entry.getValue()).get();
			}
			while (num == 0);
			Multiset.Entry result = Multisets.immutableEntry(entry.getKey(), num);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(507)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			Multiset.Entry result = computeNext();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[Signature("Lcom/google/common/collect/ForwardingIterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
	internal class _3 : ForwardingIterator
	{
		[Signature("Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Multiset.Entry last;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024readOnlyIterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal ConcurrentHashMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(527)]
		internal _3(ConcurrentHashMultiset P_0, Iterator P_1)
		{
			this_00240 = P_0;
			val_0024readOnlyIterator = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[LineNumberTable(new byte[] { 161, 167, 113 })]
		public new virtual Multiset.Entry next()
		{
			last = (Multiset.Entry)base.next();
			return last;
		}

		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		protected internal override Iterator @delegate()
		{
			return val_0024readOnlyIterator;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 173, 118, 120, 103 })]
		public override void remove()
		{
			Preconditions.checkState(last != null, (object)"no calls to next() since the last call to remove()");
			this_00240.setCount(last.getElement(), 0);
			last = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(527)]
		public override object next()
		{
			Multiset.Entry result = next();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(527)]
		protected internal new virtual object @delegate()
		{
			Iterator result = this.@delegate();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/AbstractMultiset<TE;>.EntrySet;")]
	[ConstantPool(new object[]
	{
		(byte)39,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal new class EntrySet : AbstractMultiset.EntrySet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new ConcurrentHashMultiset this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(561)]
		internal EntrySet(ConcurrentHashMultiset P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(561)]
		private EntrySet(ConcurrentHashMultiset P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(new byte[] { 161, 214, 140, 109 })]
		private List snapshot()
		{
			ArrayList arrayList = Lists.newArrayListWithExpectedSize(size());
			Iterators.addAll(arrayList, iterator());
			return arrayList;
		}

		[Signature("()Lcom/google/common/collect/ConcurrentHashMultiset<TE;>;")]
		internal new virtual ConcurrentHashMultiset multiset()
		{
			return this_00240;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(574)]
		public override object[] toArray()
		{
			object[] result = snapshot().toArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 39, 0, 0 })]
		[LineNumberTable(580)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = snapshot().toArray(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(560)]
		internal override Multiset multiset()
		{
			ConcurrentHashMultiset result = multiset();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	internal class FieldSettersHolder : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Serialization$FieldSetter<Lcom/google/common/collect/ConcurrentHashMultiset;>;")]
		internal static Serialization.FieldSetter COUNT_MAP_FIELD_SETTER;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(77)]
		private FieldSettersHolder()
		{
		}

		[LineNumberTable(new byte[] { 28, 106, 42 })]
		static FieldSettersHolder()
		{
			COUNT_MAP_FIELD_SETTER = Serialization.getFieldSetter(ClassLiteral<ConcurrentHashMultiset>.Value, "countMap");
		}
	}

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	[Signature("Ljava/util/concurrent/ConcurrentMap<TE;Ljava/util/concurrent/atomic/AtomicInteger;>;")]
	private ConcurrentMap countMap;

	private const long serialVersionUID = 1L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/concurrent/ConcurrentMap<TE;Ljava/util/concurrent/atomic/AtomicInteger;>;)V")]
	[LineNumberTable(new byte[] { 77, 104, 113, 103 })]
	internal ConcurrentHashMultiset(ConcurrentMap P_0)
	{
		Preconditions.checkArgument(P_0.isEmpty(), "the backing map (%s) must be empty", P_0);
		countMap = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ConcurrentHashMultiset<TE;>;")]
	[LineNumberTable(90)]
	public static ConcurrentHashMultiset create()
	{
		ConcurrentHashMultiset result = new ConcurrentHashMultiset(new ConcurrentHashMap());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<TE;>;")]
	[LineNumberTable(new byte[] { 160, 68, 108, 127, 1, 103, 109, 40, 168, 98 })]
	private List snapshot()
	{
		ArrayList arrayList = Lists.newArrayListWithExpectedSize(size());
		Iterator iterator = entrySet().iterator();
		while (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			object element = entry.getElement();
			for (int i = entry.getCount(); i > 0; i += -1)
			{
				((List)arrayList).add(element);
			}
		}
		return arrayList;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 104, 99, 127, 6, 106, 98 })]
	public override int size()
	{
		long num = 0L;
		Iterator iterator = countMap.values().iterator();
		while (iterator.hasNext())
		{
			AtomicInteger atomicInteger = (AtomicInteger)iterator.next();
			num += atomicInteger.get();
		}
		int result = Ints.saturatedCast(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(58)]
	public override Set entrySet()
	{
		Set result = base.entrySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 92, 114 })]
	public override int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		int result = ((AtomicInteger)Maps.safeGet(countMap, element))?.get() ?? 0;
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/ConcurrentHashMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 52, 102, 104 })]
	public static ConcurrentHashMultiset create(Iterable elements)
	{
		ConcurrentHashMultiset concurrentHashMultiset = create();
		Iterables.addAll(concurrentHashMultiset, elements);
		return concurrentHashMultiset;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/concurrent/ConcurrentMap<TE;Ljava/util/concurrent/atomic/AtomicInteger;>;)Lcom/google/common/collect/ConcurrentHashMultiset<TE;>;")]
	[LineNumberTable(123)]
	public static ConcurrentHashMultiset create(ConcurrentMap countMap)
	{
		ConcurrentHashMultiset result = new ConcurrentHashMultiset(countMap);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(168)]
	public override object[] toArray()
	{
		object[] result = snapshot().toArray();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 142, 0, 0 })]
	[LineNumberTable(174)]
	public override object[] toArray(object[] array)
	{
		object[] result = snapshot().toArray(array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(new byte[]
	{
		160,
		92,
		103,
		99,
		136,
		171,
		114,
		99,
		120,
		99,
		226,
		70,
		103,
		134,
		104,
		138,
		254,
		69,
		229,
		61,
		97,
		byte.MaxValue,
		32,
		71,
		104,
		122,
		103,
		194,
		165
	})]
	public override int add(object element, int occurrences)
	{
		//Discarded unreachable code: IL_0073
		Preconditions.checkNotNull(element);
		if (occurrences == 0)
		{
			return count(element);
		}
		CollectPreconditions.checkPositive(occurrences, "occurrences");
		AtomicInteger atomicInteger;
		AtomicInteger atomicInteger2;
		do
		{
			atomicInteger = (AtomicInteger)Maps.safeGet(countMap, element);
			if (atomicInteger == null)
			{
				atomicInteger = (AtomicInteger)countMap.putIfAbsent(element, new AtomicInteger(occurrences));
				if (atomicInteger == null)
				{
					return 0;
				}
			}
			while (true)
			{
				int num = atomicInteger.get();
				if (num == 0)
				{
					break;
				}
				try
				{
					int update = IntMath.checkedAdd(num, occurrences);
					if (atomicInteger.compareAndSet(num, update))
					{
						return num;
					}
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<java.lang.ArithmeticException>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
					goto IL_0088;
				}
				continue;
				IL_0088:
				_ = null;
				int num2 = 65;
				num2 = num2;
				string s = new StringBuilder(num2).append("Overflow adding ").append(occurrences).append(" occurrences to a count of ")
					.append(num)
					.toString();
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException(s);
			}
			atomicInteger2 = new AtomicInteger(occurrences);
		}
		while (countMap.putIfAbsent(element, atomicInteger2) != null && !countMap.replace(element, atomicInteger, atomicInteger2));
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 159, 99, 138, 139, 114, 99, 162, 103, 99,
		106, 106, 163, 142, 130, 98, 130
	})]
	public override int remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element, int occurrences)
	{
		if (occurrences == 0)
		{
			int result = count(element);
			_ = null;
			return result;
		}
		CollectPreconditions.checkPositive(occurrences, "occurrences");
		AtomicInteger atomicInteger = (AtomicInteger)Maps.safeGet(countMap, element);
		if (atomicInteger == null)
		{
			return 0;
		}
		while (true)
		{
			int num = atomicInteger.get();
			if (num == 0)
			{
				break;
			}
			int num2 = java.lang.Math.max(0, num - occurrences);
			if (atomicInteger.compareAndSet(num, num2))
			{
				if (num2 == 0)
				{
					countMap.remove(element, atomicInteger);
				}
				return num;
			}
		}
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 200, 99, 130, 139, 114, 99, 162, 103, 100,
		130, 100, 106, 163, 142, 130
	})]
	public virtual bool removeExactly([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element, int occurrences)
	{
		if (occurrences == 0)
		{
			return true;
		}
		CollectPreconditions.checkPositive(occurrences, "occurrences");
		AtomicInteger atomicInteger = (AtomicInteger)Maps.safeGet(countMap, element);
		if (atomicInteger == null)
		{
			return false;
		}
		int num;
		int num2;
		do
		{
			num = atomicInteger.get();
			if (num < occurrences)
			{
				return false;
			}
			num2 = num - occurrences;
		}
		while (!atomicInteger.compareAndSet(num, num2));
		if (num2 == 0)
		{
			countMap.remove(element, atomicInteger);
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;I)I")]
	[LineNumberTable(new byte[]
	{
		160, 236, 103, 140, 114, 99, 99, 130, 120, 99,
		226, 71, 103, 99, 99, 130, 103, 120, 103, 162,
		130, 106, 163, 142, 162, 101
	})]
	public override int setCount(object element, int count)
	{
		Preconditions.checkNotNull(element);
		CollectPreconditions.checkNonnegative(count, "count");
		AtomicInteger atomicInteger;
		AtomicInteger atomicInteger2;
		do
		{
			atomicInteger = (AtomicInteger)Maps.safeGet(countMap, element);
			if (atomicInteger == null)
			{
				if (count == 0)
				{
					return 0;
				}
				atomicInteger = (AtomicInteger)countMap.putIfAbsent(element, new AtomicInteger(count));
				if (atomicInteger == null)
				{
					return 0;
				}
			}
			while (true)
			{
				int num = atomicInteger.get();
				if (num == 0)
				{
					break;
				}
				if (atomicInteger.compareAndSet(num, count))
				{
					if (count == 0)
					{
						countMap.remove(element, atomicInteger);
					}
					return num;
				}
			}
			if (count == 0)
			{
				return 0;
			}
			atomicInteger2 = new AtomicInteger(count);
		}
		while (countMap.putIfAbsent(element, atomicInteger2) != null && !countMap.replace(element, atomicInteger, atomicInteger2));
		return 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;II)Z")]
	[LineNumberTable(new byte[]
	{
		161, 36, 103, 108, 140, 114, 99, 99, 98, 99,
		162, 185, 103, 103, 99, 131, 110, 130, 103, 120,
		43, 193, 106, 163, 142, 194
	})]
	public override bool setCount(object element, int expectedOldCount, int newCount)
	{
		Preconditions.checkNotNull(element);
		CollectPreconditions.checkNonnegative(expectedOldCount, "oldCount");
		CollectPreconditions.checkNonnegative(newCount, "newCount");
		AtomicInteger atomicInteger = (AtomicInteger)Maps.safeGet(countMap, element);
		if (atomicInteger == null)
		{
			if (expectedOldCount != 0)
			{
				return false;
			}
			if (newCount == 0)
			{
				return true;
			}
			return countMap.putIfAbsent(element, new AtomicInteger(newCount)) == null;
		}
		int num = atomicInteger.get();
		if (num == expectedOldCount)
		{
			if (num == 0)
			{
				if (newCount == 0)
				{
					countMap.remove(element, atomicInteger);
					return true;
				}
				AtomicInteger atomicInteger2 = new AtomicInteger(newCount);
				return (countMap.putIfAbsent(element, atomicInteger2) == null || countMap.replace(element, atomicInteger, atomicInteger2)) ? true : false;
			}
			if (atomicInteger.compareAndSet(num, newCount))
			{
				if (newCount == 0)
				{
					countMap.remove(element, atomicInteger);
				}
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TE;>;")]
	[LineNumberTable(new byte[] { 161, 81, 108 })]
	internal override Set createElementSet()
	{
		Set set = countMap.keySet();
		_1 result = new _1(this, set);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(482)]
	internal override Iterator elementIterator()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(489)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public override Set createEntrySet()
	{
		EntrySet result = new EntrySet(this, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(494)]
	internal override int distinctElements()
	{
		int result = countMap.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(499)]
	public override bool isEmpty()
	{
		bool result = countMap.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[LineNumberTable(new byte[] { 161, 136, 231, 85 })]
	internal override Iterator entryIterator()
	{
		_2  = new _2(this);
		_3 result = new _3(this, );
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(552)]
	public override Iterator iterator()
	{
		Iterator result = Multisets.iteratorImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 187, 109 })]
	public override void clear()
	{
		countMap.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException" })]
	[LineNumberTable(new byte[] { 161, 223, 102, 110 })]
	private void writeObject(ObjectOutputStream P_0)
	{
		P_0.defaultWriteObject();
		P_0.writeObject(countMap);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.io.IOException", "java.lang.ClassNotFoundException" })]
	[LineNumberTable(new byte[] { 161, 228, 134, 97, 107, 110 })]
	private void readObject(ObjectInputStream P_0)
	{
		P_0.defaultReadObject();
		ConcurrentMap concurrentMap = (ConcurrentMap)P_0.readObject();
		FieldSettersHolder.COUNT_MAP_FIELD_SETTER.set(this, concurrentMap);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(58)]
	public override Set elementSet()
	{
		Set result = base.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(58)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.contains(obj);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(60)]
	internal static ConcurrentMap access_0024100(ConcurrentHashMultiset P_0)
	{
		return P_0.countMap;
	}

	[HideFromJava]
	public static implicit operator Serializable(ConcurrentHashMultiset P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
		return result;
	}

	[SecurityCritical]
	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.writeObject(this, P_0);
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ConcurrentHashMultiset(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|add", "(Ljava.lang.Object;)Z")]
	public new bool add(object P_0)
	{
		return ((AbstractMultiset)this).add(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|remove", "(Ljava.lang.Object;)Z")]
	public new bool remove(object P_0)
	{
		return ((AbstractMultiset)this).remove(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|addAll", "(Ljava.util.Collection;)Z")]
	public new bool addAll(Collection P_0)
	{
		return ((AbstractMultiset)this).addAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|removeAll", "(Ljava.util.Collection;)Z")]
	public new bool removeAll(Collection P_0)
	{
		return ((AbstractMultiset)this).removeAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|retainAll", "(Ljava.util.Collection;)Z")]
	public new bool retainAll(Collection P_0)
	{
		return ((AbstractMultiset)this).retainAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>5|equals", "(Ljava.lang.Object;)Z")]
	public new bool equals(object P_0)
	{
		return ((AbstractMultiset)this).equals(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>6|hashCode", "()I")]
	public new int hashCode()
	{
		return ((AbstractMultiset)this).hashCode();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>7|toString", "()Ljava.lang.String;")]
	public new string toString()
	{
		return ((AbstractMultiset)this).toString();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>8|forEachEntry", "(Ljava.util.function.ObjIntConsumer;)V")]
	public new void forEachEntry(ObjIntConsumer P_0)
	{
		((AbstractMultiset)this).forEachEntry(P_0);
	}
}
