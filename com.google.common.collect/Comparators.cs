using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)47,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Comparators : java.lang.Object
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : java.util.function.Supplier
	{
		private readonly int arg_00241;

		private readonly Comparator arg_00242;

		internal ___003C_003EAnon0(int P_0, Comparator P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public object get()
		{
			TopKSelector result = lambda_0024least_00240(arg_00241, arg_00242);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon1 : BiConsumer
	{
		internal ___003C_003EAnon1()
		{
		}

		public void accept(object P_0, object P_1)
		{
			((TopKSelector)P_0).offer(P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : BinaryOperator
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0, object P_1)
		{
			TopKSelector result = ((TopKSelector)P_0).combine((TopKSelector)P_1);
			_ = null;
			return result;
		}

		[SpecialName]
		public BiFunction andThen(java.util.function.Function P_0)
		{
			return BiFunction._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon3 : java.util.function.Function
	{
		internal ___003C_003EAnon3()
		{
		}

		public object apply(object P_0)
		{
			List result = ((TopKSelector)P_0).topK();
			_ = null;
			return result;
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon4 : java.util.function.Function
	{
		internal ___003C_003EAnon4()
		{
		}

		public object apply(object P_0)
		{
			object result = lambda_0024emptiesFirst_00241((java.util.Optional)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon5 : java.util.function.Function
	{
		internal ___003C_003EAnon5()
		{
		}

		public object apply(object P_0)
		{
			object result = lambda_0024emptiesLast_00242((java.util.Optional)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public java.util.function.Function compose(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public java.util.function.Function andThen(java.util.function.Function P_0)
		{
			return java.util.function.Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(ILjava/util/Comparator<-TT;>;)Ljava/util/stream/Collector<TT;*Ljava/util/List<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(new byte[] { 85, 108, 103 })]
	public static Collector least(int k, Comparator comparator)
	{
		CollectPreconditions.checkNonnegative(k, "k");
		Preconditions.checkNotNull(comparator);
		Collector result = Collector.of(new ___003C_003EAnon0(k, comparator), new ___003C_003EAnon1(), new ___003C_003EAnon2(), new ___003C_003EAnon3(), Collector.Characteristics.UNORDERED);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(138)]
	private static TopKSelector lambda_0024least_00240(int P_0, Comparator P_1)
	{
		TopKSelector result = TopKSelector.least(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(180)]
	private static object lambda_0024emptiesFirst_00241(java.util.Optional P_0)
	{
		object result = P_0.orElse(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(193)]
	private static object lambda_0024emptiesLast_00242(java.util.Optional P_0)
	{
		object result = P_0.orElse(null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(48)]
	private Comparators()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;S:TT;>(Ljava/util/Comparator<TT;>;)Ljava/util/Comparator<Ljava/lang/Iterable<TS;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(66)]
	public static Comparator lexicographical(Comparator comparator)
	{
		LexicographicalOrdering result = new LexicographicalOrdering((Comparator)Preconditions.checkNotNull(comparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;Ljava/util/Comparator<TT;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		26, 103, 103, 104, 103, 104, 103, 107, 130, 98,
		130
	})]
	public static bool isInOrder(Iterable iterable, Comparator comparator)
	{
		Preconditions.checkNotNull(comparator);
		Iterator iterator = iterable.iterator();
		if (iterator.hasNext())
		{
			object o = iterator.next();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				if (comparator.compare(o, obj) > 0)
				{
					return false;
				}
				o = obj;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;Ljava/util/Comparator<TT;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		48, 103, 103, 104, 103, 104, 103, 107, 130, 98,
		130
	})]
	public static bool isInStrictOrder(Iterable iterable, Comparator comparator)
	{
		Preconditions.checkNotNull(comparator);
		Iterator iterator = iterable.iterator();
		if (iterator.hasNext())
		{
			object o = iterator.next();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				if (comparator.compare(o, obj) >= 0)
				{
					return false;
				}
				o = obj;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(ILjava/util/Comparator<-TT;>;)Ljava/util/stream/Collector<TT;*Ljava/util/List<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(167)]
	public static Collector greatest(int k, Comparator comparator)
	{
		Collector result = least(k, comparator.reversed());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Comparator<-TT;>;)Ljava/util/Comparator<Ljava/util/Optional<TT;>;>;")]
	[LineNumberTable(new byte[] { 160, 64, 103, 107, 37 })]
	public static Comparator emptiesFirst(Comparator valueComparator)
	{
		Preconditions.checkNotNull(valueComparator);
		Comparator result = Comparator.comparing(new ___003C_003EAnon4(), Comparator.nullsFirst(valueComparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Comparator<-TT;>;)Ljava/util/Comparator<Ljava/util/Optional<TT;>;>;")]
	[LineNumberTable(new byte[] { 160, 77, 103, 107, 37 })]
	public static Comparator emptiesLast(Comparator valueComparator)
	{
		Preconditions.checkNotNull(valueComparator);
		Comparator result = Comparator.comparing(new ___003C_003EAnon5(), Comparator.nullsLast(valueComparator));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T::Ljava/lang/Comparable<-TT;>;>(TT;TT;)TT;")]
	[LineNumberTable(210)]
	public static IComparable min(IComparable a, IComparable b)
	{
		return (Comparable.__Helper.compareTo(a, b) > 0) ? b : a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;TT;Ljava/util/Comparator<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(231)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object min([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object a, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object b, Comparator comparator)
	{
		return (comparator.compare(a, b) > 0) ? b : a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T::Ljava/lang/Comparable<-TT;>;>(TT;TT;)TT;")]
	[LineNumberTable(248)]
	public static IComparable max(IComparable a, IComparable b)
	{
		return (Comparable.__Helper.compareTo(a, b) < 0) ? b : a;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;TT;Ljava/util/Comparator<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 47, 0, 0 })]
	[LineNumberTable(269)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object max([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object a, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object b, Comparator comparator)
	{
		return (comparator.compare(a, b) < 0) ? b : a;
	}
}
