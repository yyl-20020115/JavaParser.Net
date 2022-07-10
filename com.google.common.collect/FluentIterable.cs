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

[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/lang/Iterable<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 93, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)93,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.lang.Iterable" })]
public abstract class FluentIterable : java.lang.Object, Iterable, IEnumerable
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<TE;>;")]
	[EnclosingMethod(null, "from", "(Ljava.lang.Iterable;)Lcom.google.common.collect.FluentIterable;")]
	internal class _1 : FluentIterable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024iterable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(144)]
		internal _1(Iterable P_0, Iterable P_1)
		{
			val_0024iterable = P_1;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(147)]
		public override Iterator iterator()
		{
			Iterator result = val_0024iterable.iterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "concat", "(Ljava.lang.Iterable;)Lcom.google.common.collect.FluentIterable;")]
	internal class _2 : FluentIterable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024inputs;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(282)]
		internal _2(Iterable P_0)
		{
			val_0024inputs = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(285)]
		public override Iterator iterator()
		{
			Iterator result = Iterators.concat(Iterators.transform(val_0024inputs.iterator(), Iterables.toIterator()));
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "concatNoDefensiveCopy", "([Ljava.lang.Iterable;)Lcom.google.common.collect.FluentIterable;")]
	internal class _3 : FluentIterable
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIndexedListIterator<Ljava/util/Iterator<+TT;>;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal new class _1 : AbstractIndexedListIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _3 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(I)Ljava/util/Iterator<+TT;>;")]
			[LineNumberTable(304)]
			public new virtual Iterator get(int P_0)
			{
				Iterator result = this_00240.val_0024inputs[P_0].iterator();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(301)]
			internal _1(_3 P_0, int P_1)
			{
				this_00240 = P_0;
				base._002Ector(P_1);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(301)]
			public override object get(int P_0)
			{
				Iterator result = get(P_0);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable[] val_0024inputs;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(296)]
		internal _3(Iterable[] P_0)
		{
			val_0024inputs = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(299)]
		public override Iterator iterator()
		{
			Iterator result = Iterators.concat(new _1(this, val_0024inputs.Length));
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/lang/Iterable<TE;>;Lcom/google/common/collect/FluentIterable<TE;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 31, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)31,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class FromIterableFunction : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<TE;>;)Lcom/google/common/collect/FluentIterable<TE;>;")]
		[LineNumberTable(878)]
		public virtual FluentIterable apply(Iterable P_0)
		{
			FluentIterable result = from(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(874)]
		private FromIterableFunction()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(874)]
		public virtual object apply(object P_0)
		{
			FluentIterable result = apply((Iterable)P_0);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}

		bool com.google.common.@base.Function.Function_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/base/Optional<Ljava/lang/Iterable<TE;>;>;")]
	private com.google.common.@base.Optional iterableDelegate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<TE;>;)Lcom/google/common/collect/FluentIterable<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(new byte[] { 92, 104, 104, 9 })]
	public static FluentIterable from(Iterable iterable)
	{
		FluentIterable result = ((!(iterable is FluentIterable)) ? new _1(iterable, iterable) : ((FluentIterable)iterable));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([Ljava/lang/Iterable<+TT;>;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 179, 111, 39, 166 })]
	private static FluentIterable concatNoDefensiveCopy(params Iterable[] P_0)
	{
		int num = P_0.Length;
		for (int i = 0; i < num; i++)
		{
			Iterable reference = P_0[i];
			Preconditions.checkNotNull(reference);
		}
		_3 result = new _3(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/lang/Iterable<TE;>;")]
	[LineNumberTable(131)]
	private Iterable getDelegate()
	{
		return (Iterable)iterableDelegate.or(this);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(198)]
	public static FluentIterable concat(Iterable a, Iterable b)
	{
		FluentIterable result = concatNoDefensiveCopy(a, b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TE;TT;>;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(491)]
	public FluentIterable transform(com.google.common.@base.Function function)
	{
		FluentIterable result = from(Iterables.transform(getDelegate(), function));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/lang/Iterable<+TT;>;>;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 167, 103 })]
	public static FluentIterable concat(Iterable inputs)
	{
		Preconditions.checkNotNull(inputs);
		_2 result = new _2(inputs);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 72, 104, 107 })]
	protected internal FluentIterable()
	{
		iterableDelegate = com.google.common.@base.Optional.absent();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<TE;>;)V")]
	[LineNumberTable(new byte[] { 76, 104, 108 })]
	internal FluentIterable(Iterable P_0)
	{
		iterableDelegate = com.google.common.@base.Optional.of(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>([TE;)Lcom/google/common/collect/FluentIterable<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(164)]
	public static FluentIterable from(object[] elements)
	{
		FluentIterable result = from(Arrays.asList(elements));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/FluentIterable<TE;>;)Lcom/google/common/collect/FluentIterable<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(180)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static FluentIterable from(FluentIterable iterable)
	{
		return (FluentIterable)Preconditions.checkNotNull(iterable);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(217)]
	public static FluentIterable concat(Iterable a, Iterable b, Iterable c)
	{
		FluentIterable result = concatNoDefensiveCopy(a, b, c);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(240)]
	public static FluentIterable concat(Iterable a, Iterable b, Iterable c, Iterable d)
	{
		FluentIterable result = concatNoDefensiveCopy(a, b, c, d);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([Ljava/lang/Iterable<+TT;>;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(261)]
	public static FluentIterable concat(params Iterable[] inputs)
	{
		FluentIterable result = concatNoDefensiveCopy((Iterable[])Arrays.copyOf(inputs, inputs.Length));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/FluentIterable<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(320)]
	public static FluentIterable of()
	{
		FluentIterable result = from(Collections.emptyList());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;[TE;)Lcom/google/common/collect/FluentIterable<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(334)]
	public static FluentIterable of([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element, params object[] elements)
	{
		FluentIterable result = from(Lists.asList(element, elements));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(346)]
	public override string toString()
	{
		string result = Iterables.toString(getDelegate());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(355)]
	public int size()
	{
		int result = Iterables.size(getDelegate());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(365)]
	public bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object target)
	{
		bool result = Iterables.contains(getDelegate(), target);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/FluentIterable<TE;>;")]
	[LineNumberTable(386)]
	public FluentIterable cycle()
	{
		FluentIterable result = from(Iterables.cycle(getDelegate()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+TE;>;)Lcom/google/common/collect/FluentIterable<TE;>;")]
	[LineNumberTable(402)]
	public FluentIterable append(Iterable other)
	{
		FluentIterable result = concat(getDelegate(), other);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([TE;)Lcom/google/common/collect/FluentIterable<TE;>;")]
	[LineNumberTable(415)]
	public FluentIterable append(params object[] elements)
	{
		FluentIterable result = concat(getDelegate(), Arrays.asList(elements));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Predicate<-TE;>;)Lcom/google/common/collect/FluentIterable<TE;>;")]
	[LineNumberTable(425)]
	public FluentIterable filter(com.google.common.@base.Predicate predicate)
	{
		FluentIterable result = from(Iterables.filter(getDelegate(), predicate));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Class<TT;>;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[LineNumberTable(443)]
	public FluentIterable filter(Class type)
	{
		FluentIterable result = from(Iterables.filter(getDelegate(), type));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Predicate<-TE;>;)Z")]
	[LineNumberTable(452)]
	public bool anyMatch(com.google.common.@base.Predicate predicate)
	{
		bool result = Iterables.any(getDelegate(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Predicate<-TE;>;)Z")]
	[LineNumberTable(462)]
	public bool allMatch(com.google.common.@base.Predicate predicate)
	{
		bool result = Iterables.all(getDelegate(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/base/Predicate<-TE;>;)Lcom/google/common/base/Optional<TE;>;")]
	[LineNumberTable(476)]
	public com.google.common.@base.Optional firstMatch(com.google.common.@base.Predicate predicate)
	{
		com.google.common.@base.Optional result = Iterables.tryFind(getDelegate(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TE;+Ljava/lang/Iterable<+TT;>;>;)Lcom/google/common/collect/FluentIterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(509)]
	public virtual FluentIterable transformAndConcat(com.google.common.@base.Function function)
	{
		FluentIterable result = concat(transform(function));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Optional<TE;>;")]
	[LineNumberTable(new byte[] { 161, 154, 108 })]
	public com.google.common.@base.Optional first()
	{
		Iterator iterator = getDelegate().iterator();
		com.google.common.@base.Optional result = ((!iterator.hasNext()) ? com.google.common.@base.Optional.absent() : com.google.common.@base.Optional.of(iterator.next()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/base/Optional<TE;>;")]
	[LineNumberTable(new byte[]
	{
		161, 174, 103, 104, 103, 104, 136, 150, 103, 104,
		232, 71, 104, 103, 206, 104, 104, 138
	})]
	public com.google.common.@base.Optional last()
	{
		Iterable @delegate = getDelegate();
		if (@delegate is List)
		{
			List list = (List)@delegate;
			if (list.isEmpty())
			{
				com.google.common.@base.Optional result = com.google.common.@base.Optional.absent();
				_ = null;
				return result;
			}
			com.google.common.@base.Optional result2 = com.google.common.@base.Optional.of(list.get(list.size() - 1));
			_ = null;
			return result2;
		}
		Iterator iterator = @delegate.iterator();
		if (!iterator.hasNext())
		{
			com.google.common.@base.Optional result3 = com.google.common.@base.Optional.absent();
			_ = null;
			return result3;
		}
		if (@delegate is SortedSet)
		{
			SortedSet sortedSet = (SortedSet)@delegate;
			com.google.common.@base.Optional result4 = com.google.common.@base.Optional.of(sortedSet.last());
			_ = null;
			return result4;
		}
		object reference;
		do
		{
			reference = iterator.next();
		}
		while (iterator.hasNext());
		com.google.common.@base.Optional result5 = com.google.common.@base.Optional.of(reference);
		_ = null;
		return result5;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/FluentIterable<TE;>;")]
	[LineNumberTable(592)]
	public FluentIterable skip(int numberToSkip)
	{
		FluentIterable result = from(Iterables.skip(getDelegate(), numberToSkip));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/FluentIterable<TE;>;")]
	[LineNumberTable(607)]
	public FluentIterable limit(int maxSize)
	{
		FluentIterable result = from(Iterables.limit(getDelegate(), maxSize));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(616)]
	public bool isEmpty()
	{
		return (!getDelegate().iterator().hasNext()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(631)]
	public ImmutableList toList()
	{
		ImmutableList result = ImmutableList.copyOf(getDelegate());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TE;>;)Lcom/google/common/collect/ImmutableList<TE;>;")]
	[LineNumberTable(648)]
	public ImmutableList toSortedList(Comparator comparator)
	{
		ImmutableList result = Ordering.from(comparator).immutableSortedCopy(getDelegate());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
	[LineNumberTable(663)]
	public ImmutableSet toSet()
	{
		ImmutableSet result = ImmutableSet.copyOf(getDelegate());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TE;>;)Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	[LineNumberTable(681)]
	public ImmutableSortedSet toSortedSet(Comparator comparator)
	{
		ImmutableSortedSet result = ImmutableSortedSet.copyOf(comparator, getDelegate());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(695)]
	public ImmutableMultiset toMultiset()
	{
		ImmutableMultiset result = ImmutableMultiset.copyOf(getDelegate());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TE;TV;>;)Lcom/google/common/collect/ImmutableMap<TE;TV;>;")]
	[LineNumberTable(716)]
	public ImmutableMap toMap(com.google.common.@base.Function valueFunction)
	{
		ImmutableMap result = Maps.toMap(getDelegate(), valueFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TE;TK;>;)Lcom/google/common/collect/ImmutableListMultimap<TK;TE;>;")]
	[LineNumberTable(739)]
	public ImmutableListMultimap index(com.google.common.@base.Function keyFunction)
	{
		ImmutableListMultimap result = Multimaps.index(getDelegate(), keyFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K:Ljava/lang/Object;>(Lcom/google/common/base/Function<-TE;TK;>;)Lcom/google/common/collect/ImmutableMap<TK;TE;>;")]
	[LineNumberTable(774)]
	public ImmutableMap uniqueIndex(com.google.common.@base.Function keyFunction)
	{
		ImmutableMap result = Maps.uniqueIndex(getDelegate(), keyFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Class<TE;>;)[TE;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 93, 0, 0 })]
	[LineNumberTable(799)]
	public object[] toArray(Class type)
	{
		object[] result = Iterables.toArray(getDelegate(), type);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/util/Collection<-TE;>;>(TC;)TC;")]
	[LineNumberTable(new byte[] { 162, 189, 103, 103, 104, 143, 118, 104, 130 })]
	public Collection copyInto(Collection collection)
	{
		Preconditions.checkNotNull(collection);
		Iterable @delegate = getDelegate();
		if (@delegate is Collection)
		{
			collection.addAll((Collection)@delegate);
		}
		else
		{
			Iterator iterator = @delegate.iterator();
			while (iterator.hasNext())
			{
				object e = iterator.next();
				collection.add(e);
			}
		}
		return collection;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(839)]
	public string join(Joiner joiner)
	{
		string result = joiner.join(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TE;")]
	[LineNumberTable(856)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public object get(int position)
	{
		object result = Iterables.get(getDelegate(), position);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/stream/Stream<TE;>;")]
	[LineNumberTable(870)]
	public Stream stream()
	{
		Stream result = Streams.stream(getDelegate());
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Iterator iterator();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void forEach(Consumer P_0)
	{
		Iterable._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual Spliterator spliterator()
	{
		return Iterable._003Cdefault_003Espliterator(this);
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}
}
