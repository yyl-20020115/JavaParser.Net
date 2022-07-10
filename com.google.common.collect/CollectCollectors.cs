using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)183,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class CollectCollectors : Object
{
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	internal class EnumMapAccumulator : Object
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : BiConsumer
		{
			private readonly EnumMapAccumulator arg_00241;

			internal ___003C_003EAnon0(EnumMapAccumulator P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0, object P_1)
			{
				arg_00241.put((Enum)P_0, P_1);
				_ = null;
			}

			[SpecialName]
			public BiConsumer andThen(BiConsumer P_0)
			{
				return BiConsumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/function/BinaryOperator<TV;>;")]
		private BinaryOperator mergeFunction;

		[Signature("Ljava/util/EnumMap<TK;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private EnumMap map;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;TV;)V")]
		[LineNumberTable(new byte[] { 160, 201, 104, 150, 116 })]
		internal virtual void put(Enum P_0, object P_1)
		{
			if (map == null)
			{
				EnumMap.___003Cclinit_003E();
				map = new EnumMap(P_0.getDeclaringClass());
			}
			map.merge(P_0, P_1, mergeFunction);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/BinaryOperator<TV;>;)V")]
		[LineNumberTable(new byte[] { 160, 196, 8, 167, 103 })]
		internal EnumMapAccumulator(BinaryOperator P_0)
		{
			map = null;
			mergeFunction = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/CollectCollectors$EnumMapAccumulator<TK;TV;>;)Lcom/google/common/collect/CollectCollectors$EnumMapAccumulator<TK;TV;>;")]
		[LineNumberTable(new byte[] { 160, 208, 104, 98, 104, 130, 118 })]
		internal virtual EnumMapAccumulator combine(EnumMapAccumulator P_0)
		{
			if (map == null)
			{
				return P_0;
			}
			if (P_0.map == null)
			{
				return this;
			}
			P_0.map.forEach(new ___003C_003EAnon0(this));
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMap<TK;TV;>;")]
		[LineNumberTable(333)]
		internal virtual ImmutableMap toImmutableMap()
		{
			ImmutableMap result = ((map != null) ? ImmutableEnumMap.asImmutable(map) : ImmutableMap.of());
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>Ljava/lang/Object;")]
	internal sealed class EnumSetAccumulator : Object
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : java.util.function.Supplier
		{
			internal ___003C_003EAnon0()
			{
			}

			public object get()
			{
				EnumSetAccumulator result = new EnumSetAccumulator();
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
				((EnumSetAccumulator)P_0).add((Enum)P_1);
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
				EnumSetAccumulator result = ((EnumSetAccumulator)P_0).combine((EnumSetAccumulator)P_1);
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
				ImmutableSet result = ((EnumSetAccumulator)P_0).toImmutableSet();
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

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Ljava/util/stream/Collector<Ljava/lang/Enum<*>;*Lcom/google/common/collect/ImmutableSet<+Ljava/lang/Enum<*>;>;>;")]
		internal static Collector TO_IMMUTABLE_ENUM_SET;

		[Signature("Ljava/util/EnumSet<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private EnumSet set;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(98)]
		private EnumSetAccumulator()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)V")]
		[LineNumberTable(new byte[] { 62, 104, 142, 141 })]
		internal virtual void add(Enum P_0)
		{
			if (set == null)
			{
				set = EnumSet.of(P_0);
			}
			else
			{
				set.add(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/CollectCollectors$EnumSetAccumulator<TE;>;)Lcom/google/common/collect/CollectCollectors$EnumSetAccumulator<TE;>;")]
		[LineNumberTable(new byte[] { 70, 104, 98, 104, 130, 114 })]
		internal virtual EnumSetAccumulator combine(EnumSetAccumulator P_0)
		{
			if (set == null)
			{
				return P_0;
			}
			if (P_0.set == null)
			{
				return this;
			}
			set.addAll(P_0.set);
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TE;>;")]
		[LineNumberTable(131)]
		internal virtual ImmutableSet toImmutableSet()
		{
			ImmutableSet result = ((set != null) ? ImmutableEnumSet.asImmutable(set) : ImmutableSet.of());
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 50, 159, 23, 10 })]
		static EnumSetAccumulator()
		{
			TO_IMMUTABLE_ENUM_SET = Collector.of(new ___003C_003EAnon0(), new ___003C_003EAnon1(), new ___003C_003EAnon2(), new ___003C_003EAnon3(), Collector.Characteristics.UNORDERED);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : java.util.function.Supplier
	{
		private readonly Comparator arg_00241;

		internal ___003C_003EAnon0(Comparator P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			ImmutableSortedSet.Builder result = lambda_0024toImmutableSortedSet_00240(arg_00241);
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
			((ImmutableSortedSet.Builder)P_0).add(P_1);
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
			ImmutableSortedSet.Builder result = ((ImmutableSortedSet.Builder)P_0).combine((ImmutableSortedSet.Builder)P_1);
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
			ImmutableSortedSet result = ((ImmutableSortedSet.Builder)P_0).build();
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
	private sealed class ___003C_003EAnon4 : java.util.function.Supplier
	{
		internal ___003C_003EAnon4()
		{
		}

		public object get()
		{
			Multiset result = LinkedHashMultiset.create();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon5 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly ToIntFunction arg_00242;

		internal ___003C_003EAnon5(java.util.function.Function P_0, ToIntFunction P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableMultiset_00241(arg_00241, arg_00242, (Multiset)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon6 : BinaryOperator
	{
		internal ___003C_003EAnon6()
		{
		}

		public object apply(object P_0, object P_1)
		{
			Multiset result = lambda_0024toImmutableMultiset_00242((Multiset)P_0, (Multiset)P_1);
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
	private sealed class ___003C_003EAnon7 : java.util.function.Function
	{
		internal ___003C_003EAnon7()
		{
		}

		public object apply(object P_0)
		{
			ImmutableMultiset result = lambda_0024toImmutableMultiset_00243((Multiset)P_0);
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
	private sealed class ___003C_003EAnon8 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly ToIntFunction arg_00242;

		internal ___003C_003EAnon8(java.util.function.Function P_0, ToIntFunction P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toMultiset_00244(arg_00241, arg_00242, (Multiset)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon9 : BinaryOperator
	{
		internal ___003C_003EAnon9()
		{
		}

		public object apply(object P_0, object P_1)
		{
			Multiset result = lambda_0024toMultiset_00245((Multiset)P_0, (Multiset)P_1);
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
	private sealed class ___003C_003EAnon10 : java.util.function.Supplier
	{
		internal ___003C_003EAnon10()
		{
		}

		public object get()
		{
			ImmutableMap.Builder result = new ImmutableMap.Builder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon11 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		internal ___003C_003EAnon11(java.util.function.Function P_0, java.util.function.Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableMap_00246(arg_00241, arg_00242, (ImmutableMap.Builder)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon12 : BinaryOperator
	{
		internal ___003C_003EAnon12()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableMap.Builder result = ((ImmutableMap.Builder)P_0).combine((ImmutableMap.Builder)P_1);
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
	private sealed class ___003C_003EAnon13 : java.util.function.Function
	{
		internal ___003C_003EAnon13()
		{
		}

		public object apply(object P_0)
		{
			ImmutableMap result = ((ImmutableMap.Builder)P_0).build();
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
	private sealed class ___003C_003EAnon14 : java.util.function.Supplier
	{
		internal ___003C_003EAnon14()
		{
		}

		public object get()
		{
			LinkedHashMap result = new LinkedHashMap();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon15 : java.util.function.Function
	{
		internal ___003C_003EAnon15()
		{
		}

		public object apply(object P_0)
		{
			ImmutableMap result = ImmutableMap.copyOf((LinkedHashMap)P_0);
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
	private sealed class ___003C_003EAnon16 : java.util.function.Supplier
	{
		private readonly Comparator arg_00241;

		internal ___003C_003EAnon16(Comparator P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			ImmutableSortedMap.Builder result = lambda_0024toImmutableSortedMap_00247(arg_00241);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon17 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		internal ___003C_003EAnon17(java.util.function.Function P_0, java.util.function.Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableSortedMap_00248(arg_00241, arg_00242, (ImmutableSortedMap.Builder)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon18 : BinaryOperator
	{
		internal ___003C_003EAnon18()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableSortedMap.Builder result = ((ImmutableSortedMap.Builder)P_0).combine((ImmutableSortedMap.Builder)P_1);
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
	private sealed class ___003C_003EAnon19 : java.util.function.Function
	{
		internal ___003C_003EAnon19()
		{
		}

		public object apply(object P_0)
		{
			ImmutableSortedMap result = ((ImmutableSortedMap.Builder)P_0).build();
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
	private sealed class ___003C_003EAnon20 : java.util.function.Supplier
	{
		private readonly Comparator arg_00241;

		internal ___003C_003EAnon20(Comparator P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			TreeMap result = lambda_0024toImmutableSortedMap_00249(arg_00241);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon21 : java.util.function.Function
	{
		internal ___003C_003EAnon21()
		{
		}

		public object apply(object P_0)
		{
			ImmutableSortedMap result = ImmutableSortedMap.copyOfSorted((TreeMap)P_0);
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
	private sealed class ___003C_003EAnon22 : java.util.function.Supplier
	{
		internal ___003C_003EAnon22()
		{
		}

		public object get()
		{
			ImmutableBiMap.Builder result = new ImmutableBiMap.Builder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon23 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		internal ___003C_003EAnon23(java.util.function.Function P_0, java.util.function.Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableBiMap_002410(arg_00241, arg_00242, (ImmutableBiMap.Builder)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon24 : BinaryOperator
	{
		internal ___003C_003EAnon24()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableBiMap.Builder result = ((ImmutableBiMap.Builder)P_0).combine((ImmutableBiMap.Builder)P_1);
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
	private sealed class ___003C_003EAnon25 : java.util.function.Function
	{
		internal ___003C_003EAnon25()
		{
		}

		public object apply(object P_0)
		{
			ImmutableBiMap result = ((ImmutableBiMap.Builder)P_0).build();
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
	private sealed class ___003C_003EAnon26 : java.util.function.Supplier
	{
		internal ___003C_003EAnon26()
		{
		}

		public object get()
		{
			EnumMapAccumulator result = lambda_0024toImmutableEnumMap_002412();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon27 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		internal ___003C_003EAnon27(java.util.function.Function P_0, java.util.function.Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableEnumMap_002413(arg_00241, arg_00242, (EnumMapAccumulator)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon28 : BinaryOperator
	{
		internal ___003C_003EAnon28()
		{
		}

		public object apply(object P_0, object P_1)
		{
			EnumMapAccumulator result = ((EnumMapAccumulator)P_0).combine((EnumMapAccumulator)P_1);
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
	private sealed class ___003C_003EAnon29 : java.util.function.Function
	{
		internal ___003C_003EAnon29()
		{
		}

		public object apply(object P_0)
		{
			ImmutableMap result = ((EnumMapAccumulator)P_0).toImmutableMap();
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
	private sealed class ___003C_003EAnon30 : java.util.function.Supplier
	{
		private readonly BinaryOperator arg_00241;

		internal ___003C_003EAnon30(BinaryOperator P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			EnumMapAccumulator result = lambda_0024toImmutableEnumMap_002414(arg_00241);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon31 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		internal ___003C_003EAnon31(java.util.function.Function P_0, java.util.function.Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableEnumMap_002415(arg_00241, arg_00242, (EnumMapAccumulator)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon32 : java.util.function.Supplier
	{
		internal ___003C_003EAnon32()
		{
		}

		public object get()
		{
			ImmutableRangeMap.Builder result = ImmutableRangeMap.builder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon33 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		internal ___003C_003EAnon33(java.util.function.Function P_0, java.util.function.Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableRangeMap_002416(arg_00241, arg_00242, (ImmutableRangeMap.Builder)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon34 : BinaryOperator
	{
		internal ___003C_003EAnon34()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableRangeMap.Builder result = ((ImmutableRangeMap.Builder)P_0).combine((ImmutableRangeMap.Builder)P_1);
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
	private sealed class ___003C_003EAnon35 : java.util.function.Function
	{
		internal ___003C_003EAnon35()
		{
		}

		public object apply(object P_0)
		{
			ImmutableRangeMap result = ((ImmutableRangeMap.Builder)P_0).build();
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
	private sealed class ___003C_003EAnon36 : java.util.function.Supplier
	{
		internal ___003C_003EAnon36()
		{
		}

		public object get()
		{
			ImmutableListMultimap.Builder result = ImmutableListMultimap.builder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon37 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		internal ___003C_003EAnon37(java.util.function.Function P_0, java.util.function.Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableListMultimap_002417(arg_00241, arg_00242, (ImmutableListMultimap.Builder)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon38 : BinaryOperator
	{
		internal ___003C_003EAnon38()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableListMultimap.Builder result = ((ImmutableListMultimap.Builder)P_0).combine((ImmutableListMultimap.Builder)P_1);
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
	private sealed class ___003C_003EAnon39 : java.util.function.Function
	{
		internal ___003C_003EAnon39()
		{
		}

		public object apply(object P_0)
		{
			ImmutableListMultimap result = ((ImmutableListMultimap.Builder)P_0).build();
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
	private sealed class ___003C_003EAnon40 : java.util.function.Function
	{
		private readonly java.util.function.Function arg_00241;

		internal ___003C_003EAnon40(java.util.function.Function P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			object result = lambda_0024flatteningToImmutableListMultimap_002418(arg_00241, P_0);
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
	private sealed class ___003C_003EAnon41 : java.util.function.Function
	{
		private readonly java.util.function.Function arg_00241;

		internal ___003C_003EAnon41(java.util.function.Function P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Stream result = lambda_0024flatteningToImmutableListMultimap_002419(arg_00241, P_0);
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
	private sealed class ___003C_003EAnon42 : java.util.function.Supplier
	{
		private readonly MultimapBuilder.ListMultimapBuilder arg_00241;

		internal ___003C_003EAnon42(MultimapBuilder.ListMultimapBuilder P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			ListMultimap result = arg_00241.build();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon43 : java.util.function.Function
	{
		internal ___003C_003EAnon43()
		{
		}

		public object apply(object P_0)
		{
			ImmutableListMultimap result = ImmutableListMultimap.copyOf((ListMultimap)P_0);
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
	private sealed class ___003C_003EAnon44 : java.util.function.Supplier
	{
		internal ___003C_003EAnon44()
		{
		}

		public object get()
		{
			ImmutableSetMultimap.Builder result = ImmutableSetMultimap.builder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon45 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		internal ___003C_003EAnon45(java.util.function.Function P_0, java.util.function.Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toImmutableSetMultimap_002420(arg_00241, arg_00242, (ImmutableSetMultimap.Builder)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon46 : BinaryOperator
	{
		internal ___003C_003EAnon46()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableSetMultimap.Builder result = ((ImmutableSetMultimap.Builder)P_0).combine((ImmutableSetMultimap.Builder)P_1);
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
	private sealed class ___003C_003EAnon47 : java.util.function.Function
	{
		internal ___003C_003EAnon47()
		{
		}

		public object apply(object P_0)
		{
			ImmutableSetMultimap result = ((ImmutableSetMultimap.Builder)P_0).build();
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
	private sealed class ___003C_003EAnon48 : java.util.function.Function
	{
		private readonly java.util.function.Function arg_00241;

		internal ___003C_003EAnon48(java.util.function.Function P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			object result = lambda_0024flatteningToImmutableSetMultimap_002421(arg_00241, P_0);
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
	private sealed class ___003C_003EAnon49 : java.util.function.Function
	{
		private readonly java.util.function.Function arg_00241;

		internal ___003C_003EAnon49(java.util.function.Function P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Stream result = lambda_0024flatteningToImmutableSetMultimap_002422(arg_00241, P_0);
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
	private sealed class ___003C_003EAnon50 : java.util.function.Supplier
	{
		private readonly MultimapBuilder.SetMultimapBuilder arg_00241;

		internal ___003C_003EAnon50(MultimapBuilder.SetMultimapBuilder P_0)
		{
			arg_00241 = P_0;
		}

		public object get()
		{
			SetMultimap result = arg_00241.build();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon51 : java.util.function.Function
	{
		internal ___003C_003EAnon51()
		{
		}

		public object apply(object P_0)
		{
			ImmutableSetMultimap result = ImmutableSetMultimap.copyOf((SetMultimap)P_0);
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
	private sealed class ___003C_003EAnon52 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		internal ___003C_003EAnon52(java.util.function.Function P_0, java.util.function.Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024toMultimap_002423(arg_00241, arg_00242, (Multimap)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon53 : BinaryOperator
	{
		internal ___003C_003EAnon53()
		{
		}

		public object apply(object P_0, object P_1)
		{
			Multimap result = lambda_0024toMultimap_002424((Multimap)P_0, (Multimap)P_1);
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
	private sealed class ___003C_003EAnon54 : BiConsumer
	{
		private readonly java.util.function.Function arg_00241;

		private readonly java.util.function.Function arg_00242;

		internal ___003C_003EAnon54(java.util.function.Function P_0, java.util.function.Function P_1)
		{
			arg_00241 = P_0;
			arg_00242 = P_1;
		}

		public void accept(object P_0, object P_1)
		{
			lambda_0024flatteningToMultimap_002425(arg_00241, arg_00242, (Multimap)P_0, P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon55 : BinaryOperator
	{
		internal ___003C_003EAnon55()
		{
		}

		public object apply(object P_0, object P_1)
		{
			Multimap result = lambda_0024flatteningToMultimap_002426((Multimap)P_0, (Multimap)P_1);
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
	private sealed class ___003C_003EAnon56 : Consumer
	{
		private readonly Collection arg_00241;

		internal ___003C_003EAnon56(Collection P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.add(P_0);
			_ = null;
		}

		[SpecialName]
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon57 : Consumer
	{
		internal ___003C_003EAnon57()
		{
		}

		public void accept(object P_0)
		{
			Preconditions.checkNotNull(P_0);
			_ = null;
		}

		[SpecialName]
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon58 : BinaryOperator
	{
		internal ___003C_003EAnon58()
		{
		}

		public object apply(object P_0, object P_1)
		{
			object result = lambda_0024toImmutableEnumMap_002411(P_0, P_1);
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
	private sealed class ___003C_003EAnon59 : java.util.function.Supplier
	{
		internal ___003C_003EAnon59()
		{
		}

		public object get()
		{
			ImmutableList.Builder result = ImmutableList.builder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon60 : BiConsumer
	{
		internal ___003C_003EAnon60()
		{
		}

		public void accept(object P_0, object P_1)
		{
			((ImmutableList.Builder)P_0).add(P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon61 : BinaryOperator
	{
		internal ___003C_003EAnon61()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableList.Builder result = ((ImmutableList.Builder)P_0).combine((ImmutableList.Builder)P_1);
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
	private sealed class ___003C_003EAnon62 : java.util.function.Function
	{
		internal ___003C_003EAnon62()
		{
		}

		public object apply(object P_0)
		{
			ImmutableList result = ((ImmutableList.Builder)P_0).build();
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
	private sealed class ___003C_003EAnon63 : java.util.function.Supplier
	{
		internal ___003C_003EAnon63()
		{
		}

		public object get()
		{
			ImmutableSet.Builder result = ImmutableSet.builder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon64 : BiConsumer
	{
		internal ___003C_003EAnon64()
		{
		}

		public void accept(object P_0, object P_1)
		{
			((ImmutableSet.Builder)P_0).add(P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon65 : BinaryOperator
	{
		internal ___003C_003EAnon65()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableSet.Builder result = ((ImmutableSet.Builder)P_0).combine((ImmutableSet.Builder)P_1);
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
	private sealed class ___003C_003EAnon66 : java.util.function.Function
	{
		internal ___003C_003EAnon66()
		{
		}

		public object apply(object P_0)
		{
			ImmutableSet result = ((ImmutableSet.Builder)P_0).build();
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
	private sealed class ___003C_003EAnon67 : java.util.function.Supplier
	{
		internal ___003C_003EAnon67()
		{
		}

		public object get()
		{
			ImmutableRangeSet.Builder result = ImmutableRangeSet.builder();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon68 : BiConsumer
	{
		internal ___003C_003EAnon68()
		{
		}

		public void accept(object P_0, object P_1)
		{
			((ImmutableRangeSet.Builder)P_0).add((Range)P_1);
			_ = null;
		}

		[SpecialName]
		public BiConsumer andThen(BiConsumer P_0)
		{
			return BiConsumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon69 : BinaryOperator
	{
		internal ___003C_003EAnon69()
		{
		}

		public object apply(object P_0, object P_1)
		{
			ImmutableRangeSet.Builder result = ((ImmutableRangeSet.Builder)P_0).combine((ImmutableRangeSet.Builder)P_1);
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
	private sealed class ___003C_003EAnon70 : java.util.function.Function
	{
		internal ___003C_003EAnon70()
		{
		}

		public object apply(object P_0)
		{
			ImmutableRangeSet result = ((ImmutableRangeSet.Builder)P_0).build();
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

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/stream/Collector<Ljava/lang/Object;*Lcom/google/common/collect/ImmutableList<Ljava/lang/Object;>;>;")]
	private static Collector TO_IMMUTABLE_LIST;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/stream/Collector<Ljava/lang/Object;*Lcom/google/common/collect/ImmutableSet<Ljava/lang/Object;>;>;")]
	private static Collector TO_IMMUTABLE_SET;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/util/stream/Collector<Lcom/google/common/collect/Range<Ljava/lang/Comparable<*>;>;*Lcom/google/common/collect/ImmutableRangeSet<Ljava/lang/Comparable<*>;>;>;")]
	private static Collector TO_IMMUTABLE_RANGE_SET;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[Signature("<E:Ljava/lang/Object;>()Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableList<TE;>;>;")]
	internal static Collector toImmutableList()
	{
		return TO_IMMUTABLE_LIST;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;M::Lcom/google/common/collect/Multimap<TK;TV;>;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+Ljava/util/stream/Stream<+TV;>;>;Ljava/util/function/Supplier<TM;>;)Ljava/util/stream/Collector<TT;*TM;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 183, 0, 0,
		18, 1, 0, 0, 0, 183, 0, 0, 18, 2,
		0, 0, 0, 183, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 67, 103, 103, 103 })]
	internal static Collector flatteningToMultimap(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Supplier P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		Collector result = Collector.of(P_2, new ___003C_003EAnon54(P_0, P_1), new ___003C_003EAnon55());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(87)]
	private static ImmutableSortedSet.Builder lambda_0024toImmutableSortedSet_00240(Comparator P_0)
	{
		ImmutableSortedSet.Builder result = new ImmutableSortedSet.Builder(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(151)]
	private static void lambda_0024toImmutableMultiset_00241(java.util.function.Function P_0, ToIntFunction P_1, Multiset P_2, object P_3)
	{
		P_2.add(Preconditions.checkNotNull(P_0.apply(P_3)), P_1.applyAsInt(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 103, 104 })]
	private static Multiset lambda_0024toImmutableMultiset_00242(Multiset P_0, Multiset P_1)
	{
		P_0.addAll(P_1);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(156)]
	private static ImmutableMultiset lambda_0024toImmutableMultiset_00243(Multiset P_0)
	{
		ImmutableMultiset result = ImmutableMultiset.copyFromEntries(P_0.entrySet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(169)]
	private static void lambda_0024toMultiset_00244(java.util.function.Function P_0, ToIntFunction P_1, Multiset P_2, object P_3)
	{
		P_2.add(P_0.apply(P_3), P_1.applyAsInt(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 121, 104 })]
	private static Multiset lambda_0024toMultiset_00245(Multiset P_0, Multiset P_1)
	{
		P_0.addAll(P_1);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(185)]
	private static void lambda_0024toImmutableMap_00246(java.util.function.Function P_0, java.util.function.Function P_1, ImmutableMap.Builder P_2, object P_3)
	{
		P_2.put(P_0.apply(P_3), P_1.apply(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(216)]
	private static ImmutableSortedMap.Builder lambda_0024toImmutableSortedMap_00247(Comparator P_0)
	{
		ImmutableSortedMap.Builder result = new ImmutableSortedMap.Builder(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(217)]
	private static void lambda_0024toImmutableSortedMap_00248(java.util.function.Function P_0, java.util.function.Function P_1, ImmutableSortedMap.Builder P_2, object P_3)
	{
		P_2.put(P_0.apply(P_3), P_1.apply(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(235)]
	private static TreeMap lambda_0024toImmutableSortedMap_00249(Comparator P_0)
	{
		TreeMap result = new TreeMap(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(246)]
	private static void lambda_0024toImmutableBiMap_002410(java.util.function.Function P_0, java.util.function.Function P_1, ImmutableBiMap.Builder P_2, object P_3)
	{
		P_2.put(P_0.apply(P_3), P_1.apply(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(260)]
	private static EnumMapAccumulator lambda_0024toImmutableEnumMap_002412()
	{
		EnumMapAccumulator result = new EnumMapAccumulator(new ___003C_003EAnon58());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 160, 155, 109, 104, 104, 113, 5, 167 })]
	private static void lambda_0024toImmutableEnumMap_002413(java.util.function.Function P_0, java.util.function.Function P_1, EnumMapAccumulator P_2, object P_3)
	{
		Enum obj = (Enum)P_0.apply(P_3);
		object obj2 = P_1.apply(P_3);
		P_2.put((Enum)Preconditions.checkNotNull(obj, "Null key for input %s", P_3), Preconditions.checkNotNull(obj2, "Null value for input %s", P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(290)]
	private static EnumMapAccumulator lambda_0024toImmutableEnumMap_002414(BinaryOperator P_0)
	{
		EnumMapAccumulator result = new EnumMapAccumulator(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 160, 182, 109, 104, 104, 113, 5, 167 })]
	private static void lambda_0024toImmutableEnumMap_002415(java.util.function.Function P_0, java.util.function.Function P_1, EnumMapAccumulator P_2, object P_3)
	{
		Enum obj = (Enum)P_0.apply(P_3);
		object obj2 = P_1.apply(P_3);
		P_2.put((Enum)Preconditions.checkNotNull(obj, "Null key for input %s", P_3), Preconditions.checkNotNull(obj2, "Null value for input %s", P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(346)]
	private static void lambda_0024toImmutableRangeMap_002416(java.util.function.Function P_0, java.util.function.Function P_1, ImmutableRangeMap.Builder P_2, object P_3)
	{
		P_2.put((Range)P_0.apply(P_3), P_1.apply(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(361)]
	private static void lambda_0024toImmutableListMultimap_002417(java.util.function.Function P_0, java.util.function.Function P_1, ImmutableListMultimap.Builder P_2, object P_3)
	{
		P_2.put(P_0.apply(P_3), P_1.apply(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(374)]
	private static object lambda_0024flatteningToImmutableListMultimap_002418(java.util.function.Function P_0, object P_1)
	{
		object result = Preconditions.checkNotNull(P_0.apply(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(375)]
	private static Stream lambda_0024flatteningToImmutableListMultimap_002419(java.util.function.Function P_0, object P_1)
	{
		Stream result = ((Stream)P_0.apply(P_1)).peek(new ___003C_003EAnon57());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(388)]
	private static void lambda_0024toImmutableSetMultimap_002420(java.util.function.Function P_0, java.util.function.Function P_1, ImmutableSetMultimap.Builder P_2, object P_3)
	{
		P_2.put(P_0.apply(P_3), P_1.apply(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(401)]
	private static object lambda_0024flatteningToImmutableSetMultimap_002421(java.util.function.Function P_0, object P_1)
	{
		object result = Preconditions.checkNotNull(P_0.apply(P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(402)]
	private static Stream lambda_0024flatteningToImmutableSetMultimap_002422(java.util.function.Function P_0, object P_1)
	{
		Stream result = ((Stream)P_0.apply(P_1)).peek(new ___003C_003EAnon57());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(421)]
	private static void lambda_0024toMultimap_002423(java.util.function.Function P_0, java.util.function.Function P_1, Multimap P_2, object P_3)
	{
		P_2.put(P_0.apply(P_3), P_1.apply(P_3));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 161, 53, 104 })]
	private static Multimap lambda_0024toMultimap_002424(Multimap P_0, Multimap P_1)
	{
		P_0.putAll(P_1);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 161, 73, 104, 104, 127, 6 })]
	private static void lambda_0024flatteningToMultimap_002425(java.util.function.Function P_0, java.util.function.Function P_1, Multimap P_2, object P_3)
	{
		object obj = P_0.apply(P_3);
		Collection collection = P_2.get(obj);
		Stream obj2 = (Stream)P_1.apply(P_3);
		java.util.Objects.requireNonNull(collection);
		obj2.forEachOrdered(new ___003C_003EAnon56(collection));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 161, 78, 104 })]
	private static Multimap lambda_0024flatteningToMultimap_002426(Multimap P_0, Multimap P_1)
	{
		P_0.putAll(P_1);
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(262)]
	private static object lambda_0024toImmutableEnumMap_002411(object P_0, object P_1)
	{
		string text = String.valueOf(P_0);
		string text2 = String.valueOf(P_1);
		int num = 27 + String.instancehelper_length(String.valueOf(text)) + String.instancehelper_length(String.valueOf(text2));
		num = num;
		string s = new StringBuilder(num).append("Multiple values for key: ").append(text).append(", ")
			.append(text2)
			.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(44)]
	internal CollectCollectors()
	{
	}

	[Signature("<E:Ljava/lang/Object;>()Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableSet<TE;>;>;")]
	internal static Collector toImmutableSet()
	{
		return TO_IMMUTABLE_SET;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Comparator<-TE;>;)Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableSortedSet<TE;>;>;")]
	[LineNumberTable(new byte[] { 35, 103 })]
	internal static Collector toImmutableSortedSet(Comparator P_0)
	{
		Preconditions.checkNotNull(P_0);
		Collector result = Collector.of(new ___003C_003EAnon0(P_0), new ___003C_003EAnon1(), new ___003C_003EAnon2(), new ___003C_003EAnon3());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Enum<TE;>;>()Ljava/util/stream/Collector<TE;*Lcom/google/common/collect/ImmutableSet<TE;>;>;")]
	[LineNumberTable(95)]
	internal static Collector toImmutableEnumSet()
	{
		return EnumSetAccumulator.TO_IMMUTABLE_ENUM_SET;
	}

	[Signature("<E::Ljava/lang/Comparable<-TE;>;>()Ljava/util/stream/Collector<Lcom/google/common/collect/Range<TE;>;*Lcom/google/common/collect/ImmutableRangeSet<TE;>;>;")]
	internal static Collector toImmutableRangeSet()
	{
		return TO_IMMUTABLE_RANGE_SET;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;E:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TE;>;Ljava/util/function/ToIntFunction<-TT;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMultiset<TE;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 96, 103, 103 })]
	internal static Collector toImmutableMultiset(java.util.function.Function P_0, ToIntFunction P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Collector result = Collector.of(new ___003C_003EAnon4(), new ___003C_003EAnon5(P_0, P_1), new ___003C_003EAnon6(), new ___003C_003EAnon7());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;E:Ljava/lang/Object;M::Lcom/google/common/collect/Multiset<TE;>;>(Ljava/util/function/Function<-TT;TE;>;Ljava/util/function/ToIntFunction<-TT;>;Ljava/util/function/Supplier<TM;>;)Ljava/util/stream/Collector<TT;*TM;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 183, 0, 0,
		18, 1, 0, 0, 0, 183, 0, 0
	})]
	[LineNumberTable(new byte[] { 114, 103, 103, 103 })]
	internal static Collector toMultiset(java.util.function.Function P_0, ToIntFunction P_1, java.util.function.Supplier P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		Collector result = Collector.of(P_2, new ___003C_003EAnon8(P_0, P_1), new ___003C_003EAnon9());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 67, 103, 103 })]
	internal static Collector toImmutableMap(java.util.function.Function P_0, java.util.function.Function P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Collector result = Collector.of(new ___003C_003EAnon10(), new ___003C_003EAnon11(P_0, P_1), new ___003C_003EAnon12(), new ___003C_003EAnon13());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 81, 103, 103, 103, 109, 47 })]
	public static Collector toImmutableMap(java.util.function.Function P_0, java.util.function.Function P_1, BinaryOperator P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		Collector result = Collectors.collectingAndThen(Collectors.toMap(P_0, P_1, P_2, new ___003C_003EAnon14()), new ___003C_003EAnon15());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<-TK;>;Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 94, 103, 103, 231, 69 })]
	internal static Collector toImmutableSortedMap(Comparator P_0, java.util.function.Function P_1, java.util.function.Function P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		Collector result = Collector.of(new ___003C_003EAnon16(P_0), new ___003C_003EAnon17(P_1, P_2), new ___003C_003EAnon18(), new ___003C_003EAnon19(), Collector.Characteristics.UNORDERED);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<-TK;>;Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableSortedMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 115, 103, 103, 103, 103, 110, 47 })]
	internal static Collector toImmutableSortedMap(Comparator P_0, java.util.function.Function P_1, java.util.function.Function P_2, BinaryOperator P_3)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		Preconditions.checkNotNull(P_3);
		Collector result = Collectors.collectingAndThen(Collectors.toMap(P_1, P_2, P_3, new ___003C_003EAnon20(P_0)), new ___003C_003EAnon21());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableBiMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 128, 103, 103 })]
	internal static Collector toImmutableBiMap(java.util.function.Function P_0, java.util.function.Function P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Collector result = Collector.of(new ___003C_003EAnon22(), new ___003C_003EAnon23(P_0, P_1), new ___003C_003EAnon24(), new ___003C_003EAnon25());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 142, 103, 103 })]
	internal static Collector toImmutableEnumMap(java.util.function.Function P_0, java.util.function.Function P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Collector result = Collector.of(new ___003C_003EAnon26(), new ___003C_003EAnon27(P_0, P_1), new ___003C_003EAnon28(), new ___003C_003EAnon29(), Collector.Characteristics.UNORDERED);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Enum<TK;>;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 171, 103, 103, 135 })]
	internal static Collector toImmutableEnumMap(java.util.function.Function P_0, java.util.function.Function P_1, BinaryOperator P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		Collector result = Collector.of(new ___003C_003EAnon30(P_2), new ___003C_003EAnon31(P_0, P_1), new ___003C_003EAnon28(), new ___003C_003EAnon29());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K::Ljava/lang/Comparable<-TK;>;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;Lcom/google/common/collect/Range<TK;>;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableRangeMap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 228, 103, 103 })]
	internal static Collector toImmutableRangeMap(java.util.function.Function P_0, java.util.function.Function P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Collector result = Collector.of(new ___003C_003EAnon32(), new ___003C_003EAnon33(P_0, P_1), new ___003C_003EAnon34(), new ___003C_003EAnon35());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 243, 108, 108 })]
	internal static Collector toImmutableListMultimap(java.util.function.Function P_0, java.util.function.Function P_1)
	{
		Preconditions.checkNotNull((object)P_0, (object)"keyFunction");
		Preconditions.checkNotNull((object)P_1, (object)"valueFunction");
		Collector result = Collector.of(new ___003C_003EAnon36(), new ___003C_003EAnon37(P_0, P_1), new ___003C_003EAnon38(), new ___003C_003EAnon39());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+Ljava/util/stream/Stream<+TV;>;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableListMultimap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 0, 103, 103, 214, 251, 61, 47 })]
	internal static Collector flatteningToImmutableListMultimap(java.util.function.Function P_0, java.util.function.Function P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		java.util.function.Function obj = new ___003C_003EAnon40(P_0);
		java.util.function.Function obj2 = new ___003C_003EAnon41(P_1);
		MultimapBuilder.ListMultimapBuilder listMultimapBuilder = MultimapBuilder.linkedHashKeys().arrayListValues();
		java.util.Objects.requireNonNull(listMultimapBuilder);
		Collector result = Collectors.collectingAndThen(flatteningToMultimap(obj, obj2, new ___003C_003EAnon42(listMultimapBuilder)), new ___003C_003EAnon43());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 14, 108, 108 })]
	internal static Collector toImmutableSetMultimap(java.util.function.Function P_0, java.util.function.Function P_1)
	{
		Preconditions.checkNotNull((object)P_0, (object)"keyFunction");
		Preconditions.checkNotNull((object)P_1, (object)"valueFunction");
		Collector result = Collector.of(new ___003C_003EAnon44(), new ___003C_003EAnon45(P_0, P_1), new ___003C_003EAnon46(), new ___003C_003EAnon47());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+Ljava/util/stream/Stream<+TV;>;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableSetMultimap<TK;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 183, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 27, 103, 103, 214, 251, 61, 47 })]
	internal static Collector flatteningToImmutableSetMultimap(java.util.function.Function P_0, java.util.function.Function P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		java.util.function.Function obj = new ___003C_003EAnon48(P_0);
		java.util.function.Function obj2 = new ___003C_003EAnon49(P_1);
		MultimapBuilder.SetMultimapBuilder setMultimapBuilder = MultimapBuilder.linkedHashKeys().linkedHashSetValues();
		java.util.Objects.requireNonNull(setMultimapBuilder);
		Collector result = Collectors.collectingAndThen(flatteningToMultimap(obj, obj2, new ___003C_003EAnon50(setMultimapBuilder)), new ___003C_003EAnon51());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;K:Ljava/lang/Object;V:Ljava/lang/Object;M::Lcom/google/common/collect/Multimap<TK;TV;>;>(Ljava/util/function/Function<-TT;+TK;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/Supplier<TM;>;)Ljava/util/stream/Collector<TT;*TM;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 183, 0, 0,
		18, 1, 0, 0, 0, 183, 0, 0, 18, 2,
		0, 0, 0, 183, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 46, 103, 103, 103 })]
	internal static Collector toMultimap(java.util.function.Function P_0, java.util.function.Function P_1, java.util.function.Supplier P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		Collector result = Collector.of(P_2, new ___003C_003EAnon52(P_0, P_1), new ___003C_003EAnon53());
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[]
	{
		159, 188, 127, 15, 234, 70, 127, 15, 234, 72,
		127, 15, 42
	})]
	static CollectCollectors()
	{
		TO_IMMUTABLE_LIST = Collector.of(new ___003C_003EAnon59(), new ___003C_003EAnon60(), new ___003C_003EAnon61(), new ___003C_003EAnon62());
		TO_IMMUTABLE_SET = Collector.of(new ___003C_003EAnon63(), new ___003C_003EAnon64(), new ___003C_003EAnon65(), new ___003C_003EAnon66());
		TO_IMMUTABLE_RANGE_SET = Collector.of(new ___003C_003EAnon67(), new ___003C_003EAnon68(), new ___003C_003EAnon69(), new ___003C_003EAnon70());
	}
}
