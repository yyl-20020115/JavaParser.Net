using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.concurrent.atomic;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Comparator<TT;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 101, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)101,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public abstract class Ordering : java.lang.Object, Comparator
{
	[Signature("Lcom/google/common/collect/Ordering<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0,
		1,
		16,
		byte.MaxValue,
		byte.MaxValue,
		1,
		3,
		0,
		0,
		68,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)68,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class ArbitraryOrdering : Ordering
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private AtomicInteger counter;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/concurrent/ConcurrentMap<Ljava/lang/Object;Ljava/lang/Integer;>;")]
		private ConcurrentMap uids;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(383)]
		internal virtual int identityHashCode(object P_0)
		{
			int result = java.lang.System.identityHashCode(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 218, 114, 195, 113, 115, 99, 162 })]
		private Integer getUid(object P_0)
		{
			Integer integer = (Integer)uids.get(P_0);
			if (integer == null)
			{
				integer = Integer.valueOf(counter.getAndIncrement());
				Integer integer2 = (Integer)uids.putIfAbsent(P_0, integer);
				if (integer2 != null)
				{
					integer = integer2;
				}
			}
			return integer;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 211, 136, 108, 102, 47 })]
		internal ArbitraryOrdering()
		{
			counter = new AtomicInteger(0);
			uids = Platform.tryWeakKeys(new MapMaker()).makeMap();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 234, 100, 98, 99, 98, 99, 130, 104, 104,
			100, 201, 116, 99, 139
		})]
		public override int compare([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1)
		{
			if (P_0 == P_1)
			{
				return 0;
			}
			if (P_0 == null)
			{
				return -1;
			}
			if (P_1 == null)
			{
				return 1;
			}
			int num = identityHashCode(P_0);
			int num2 = identityHashCode(P_1);
			if (num != num2)
			{
				return (num >= num2) ? 1 : (-1);
			}
			int num3 = getUid(P_0).compareTo(getUid(P_1));
			if (num3 == 0)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
			return num3;
		}

		public override string toString()
		{
			return "Ordering.arbitrary()";
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[ConstantPool(new object[]
	{
		(byte)12,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class ArbitraryOrderingHolder : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Ordering<Ljava/lang/Object;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 19, 1, 3, 0, 0, 12, 0, 0 })]
		internal static Ordering ARBITRARY_ORDERING;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(320)]
		private ArbitraryOrderingHolder()
		{
		}

		[LineNumberTable(321)]
		static ArbitraryOrderingHolder()
		{
			ARBITRARY_ORDERING = new ArbitraryOrdering();
		}
	}

	[Serializable]
	internal class IncomparableValueException : ClassCastException
	{
		[Modifiers(Modifiers.Final)]
		internal object value;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 69, 127, 28, 103 })]
		internal IncomparableValueException(object P_0)
		{
			string text = java.lang.String.valueOf(P_0);
			base._002Ector(new StringBuilder(22 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text))).append("Cannot compare value: ").append(text).toString());
			value = P_0;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected IncomparableValueException(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	internal const int LEFT_IS_GREATER = 1;

	internal const int RIGHT_IS_GREATER = -1;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable;>()Lcom/google/common/collect/Ordering<TC;>;")]
	[LineNumberTable(164)]
	public static Ordering natural()
	{
		return NaturalOrdering.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Comparator<TT;>;)Lcom/google/common/collect/Ordering<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 101, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 70, 104, 104, 8 })]
	public static Ordering from(Comparator comparator)
	{
		Ordering result = ((!(comparator is Ordering)) ? new ComparatorOrdering(comparator) : ((Ordering)comparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:TT;>()Lcom/google/common/collect/Ordering<TS;>;")]
	[LineNumberTable(407)]
	public virtual Ordering reverse()
	{
		ReverseOrdering result = new ReverseOrdering(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;)Lcom/google/common/collect/Ordering<TT;>;")]
	[LineNumberTable(222)]
	public static Ordering @explicit(List valuesInOrder)
	{
		ExplicitOrdering result = new ExplicitOrdering(valuesInOrder);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<F:Ljava/lang/Object;>(Lcom/google/common/base/Function<TF;+TT;>;)Lcom/google/common/collect/Ordering<TF;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 101, 0, 0 })]
	[LineNumberTable(451)]
	public virtual Ordering onResultOf(com.google.common.@base.Function function)
	{
		ByFunctionOrdering result = new ByFunctionOrdering(function, this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(TE;TE;)TE;")]
	[LineNumberTable(599)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object min([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object a, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object b)
	{
		return (compare(a, b) > 0) ? b : a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/util/Iterator<TE;>;)TE;")]
	[LineNumberTable(new byte[] { 161, 184, 135, 104, 176 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object min(Iterator iterator)
	{
		object obj = iterator.next();
		while (iterator.hasNext())
		{
			obj = min(obj, iterator.next());
		}
		return obj;
	}

	[Signature("(TT;TT;)I")]
	public abstract int compare([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(TE;TE;)TE;")]
	[LineNumberTable(690)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object max([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object a, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object b)
	{
		return (compare(a, b) < 0) ? b : a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/util/Iterator<TE;>;)TE;")]
	[LineNumberTable(new byte[] { 162, 19, 135, 104, 176 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object max(Iterator iterator)
	{
		object obj = iterator.next();
		while (iterator.hasNext())
		{
			obj = max(obj, iterator.next());
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/util/Iterator<TE;>;I)Ljava/util/List<TE;>;")]
	[LineNumberTable(new byte[]
	{
		162, 146, 103, 140, 107, 104, 136, 103, 103, 105,
		146, 102, 137, 104, 103
	})]
	public virtual List leastOf(Iterator iterator, int k)
	{
		Preconditions.checkNotNull(iterator);
		CollectPreconditions.checkNonnegative(k, "k");
		if (k == 0 || !iterator.hasNext())
		{
			List result = Collections.emptyList();
			_ = null;
			return result;
		}
		if (k >= 1073741823)
		{
			ArrayList arrayList = Lists.newArrayList(iterator);
			Collections.sort(arrayList, this);
			if (arrayList.size() > k)
			{
				arrayList.subList(k, arrayList.size()).clear();
			}
			arrayList.trimToSize();
			List result2 = Collections.unmodifiableList(arrayList);
			_ = null;
			return result2;
		}
		TopKSelector topKSelector = TopKSelector.least(k, this);
		topKSelector.offerAll(iterator);
		List result3 = topKSelector.topK();
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/lang/Iterable<TE;>;I)Ljava/util/List<TE;>;")]
	[LineNumberTable(new byte[]
	{
		162, 110, 104, 103, 238, 70, 103, 103, 101, 136,
		174
	})]
	public virtual List leastOf(Iterable iterable, int k)
	{
		if (iterable is Collection)
		{
			Collection collection = (Collection)iterable;
			if (collection.size() <= 2L * (long)k)
			{
				object[] array = collection.toArray();
				Arrays.sort(array, this);
				if ((nint)array.LongLength > k)
				{
					array = Arrays.copyOf(array, k);
				}
				List result = Collections.unmodifiableList(Arrays.asList(array));
				_ = null;
				return result;
			}
		}
		List result2 = leastOf(iterable.iterator(), k);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/collect/Ordering<TT;>;)Lcom/google/common/collect/Ordering<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 101, 0, 0 })]
	[LineNumberTable(197)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static Ordering from(Ordering ordering)
	{
		return (Ordering)Preconditions.checkNotNull(ordering);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;[TT;)Lcom/google/common/collect/Ordering<TT;>;")]
	[LineNumberTable(248)]
	public static Ordering @explicit(object leastValue, params object[] remainingValuesInOrder)
	{
		Ordering result = @explicit(Lists.asList(leastValue, remainingValuesInOrder));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Ordering<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 101, 0, 0 })]
	[LineNumberTable(284)]
	public static Ordering allEqual()
	{
		return AllEqualOrdering.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Ordering<Ljava/lang/Object;>;")]
	[LineNumberTable(297)]
	public static Ordering usingToString()
	{
		return UsingToStringOrdering.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Ordering<Ljava/lang/Object;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 101, 0, 0 })]
	[LineNumberTable(317)]
	public static Ordering arbitrary()
	{
		return ArbitraryOrderingHolder.ARBITRARY_ORDERING;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(393)]
	protected internal Ordering()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:TT;>()Lcom/google/common/collect/Ordering<TS;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 101, 0, 0 })]
	[LineNumberTable(420)]
	public virtual Ordering nullsFirst()
	{
		NullsFirstOrdering result = new NullsFirstOrdering(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:TT;>()Lcom/google/common/collect/Ordering<TS;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 101, 0, 0 })]
	[LineNumberTable(433)]
	public virtual Ordering nullsLast()
	{
		NullsLastOrdering result = new NullsLastOrdering(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T2:TT;>()Lcom/google/common/collect/Ordering<Ljava/util/Map$Entry<TT2;*>;>;")]
	[LineNumberTable(455)]
	internal virtual Ordering onKeys()
	{
		Ordering result = onResultOf(Maps.keyFunction());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<U:TT;>(Ljava/util/Comparator<-TU;>;)Lcom/google/common/collect/Ordering<TU;>;")]
	[LineNumberTable(473)]
	public virtual Ordering compound(Comparator secondaryComparator)
	{
		CompoundOrdering result = new CompoundOrdering(this, (Comparator)Preconditions.checkNotNull(secondaryComparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/util/Comparator<-TT;>;>;)Lcom/google/common/collect/Ordering<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 101, 0, 0 })]
	[LineNumberTable(498)]
	public static Ordering compound(Iterable comparators)
	{
		CompoundOrdering result = new CompoundOrdering(comparators);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<S:TT;>()Lcom/google/common/collect/Ordering<Ljava/lang/Iterable<TS;>;>;")]
	[LineNumberTable(528)]
	public virtual Ordering lexicographical()
	{
		LexicographicalOrdering result = new LexicographicalOrdering(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/lang/Iterable<TE;>;)TE;")]
	[LineNumberTable(579)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object min(Iterable iterable)
	{
		object result = min(iterable.iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(TE;TE;TE;[TE;)TE;")]
	[LineNumberTable(new byte[] { 161, 249, 144, 113, 42, 198 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object min([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object a, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object b, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object c, params object[] rest)
	{
		object obj = min(min(a, b), c);
		int num = rest.Length;
		for (int i = 0; i < num; i++)
		{
			object b2 = rest[i];
			obj = min(obj, b2);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/lang/Iterable<TE;>;)TE;")]
	[LineNumberTable(670)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object max(Iterable iterable)
	{
		object result = max(iterable.iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(TE;TE;TE;[TE;)TE;")]
	[LineNumberTable(new byte[] { 162, 84, 144, 113, 42, 198 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object max([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object a, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object b, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object c, params object[] rest)
	{
		object obj = max(max(a, b), c);
		int num = rest.Length;
		for (int i = 0; i < num; i++)
		{
			object b2 = rest[i];
			obj = max(obj, b2);
		}
		return obj;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/lang/Iterable<TE;>;I)Ljava/util/List<TE;>;")]
	[LineNumberTable(812)]
	public virtual List greatestOf(Iterable iterable, int k)
	{
		List result = reverse().leastOf(iterable, k);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/util/Iterator<TE;>;I)Ljava/util/List<TE;>;")]
	[LineNumberTable(832)]
	public virtual List greatestOf(Iterator iterator, int k)
	{
		List result = reverse().leastOf(iterator, k);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/lang/Iterable<TE;>;)Ljava/util/List<TE;>;")]
	[LineNumberTable(new byte[] { 162, 227, 103, 103 })]
	public virtual List sortedCopy(Iterable elements)
	{
		object[] a = Iterables.toArray(elements);
		Arrays.sort(a, this);
		ArrayList result = Lists.newArrayList(Arrays.asList(a));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:TT;>(Ljava/lang/Iterable<TE;>;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(876)]
	public virtual ImmutableList immutableSortedCopy(Iterable elements)
	{
		ImmutableList result = ImmutableList.sortedCopyOf(this, elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TT;>;)Z")]
	[LineNumberTable(new byte[]
	{
		163, 7, 103, 104, 103, 104, 103, 107, 130, 98,
		130
	})]
	public virtual bool isOrdered(Iterable iterable)
	{
		Iterator iterator = iterable.iterator();
		if (iterator.hasNext())
		{
			object obj = iterator.next();
			while (iterator.hasNext())
			{
				object obj2 = iterator.next();
				if (compare(obj, obj2) > 0)
				{
					return false;
				}
				obj = obj2;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TT;>;)Z")]
	[LineNumberTable(new byte[]
	{
		163, 31, 103, 104, 103, 104, 103, 107, 130, 98,
		130
	})]
	public virtual bool isStrictlyOrdered(Iterable iterable)
	{
		Iterator iterator = iterable.iterator();
		if (iterator.hasNext())
		{
			object obj = iterator.next();
			while (iterator.hasNext())
			{
				object obj2 = iterator.next();
				if (compare(obj, obj2) >= 0)
				{
					return false;
				}
				obj = obj2;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/List<+TT;>;TT;)I")]
	[LineNumberTable(938)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual int binarySearch(List sortedList, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object key)
	{
		int result = Collections.binarySearch(sortedList, key, this);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparing(Comparator P_0)
	{
		return Comparator._003Cdefault_003EthenComparing(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator reversed()
	{
		return Comparator._003Cdefault_003Ereversed(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparing(java.util.function.Function P_0, Comparator P_1)
	{
		return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparing(java.util.function.Function P_0)
	{
		return Comparator._003Cdefault_003EthenComparing(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparingInt(ToIntFunction P_0)
	{
		return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparingLong(ToLongFunction P_0)
	{
		return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
	{
		return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
	}

	bool Comparator.Comparator_003A_003Aequals(object P_0)
	{
		return java.lang.Object.instancehelper_equals(this, P_0);
	}
}
