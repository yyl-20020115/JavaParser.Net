using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.math;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)77,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Collections2 : java.lang.Object
{
	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 116, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)116,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class FilteredCollection : AbstractCollection
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly FilteredCollection arg_00241;

			private readonly Consumer arg_00242;

			internal ___003C_003EAnon0(FilteredCollection P_0, Consumer P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024forEach_00240(arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon1 : java.util.function.Predicate
		{
			private readonly Collection arg_00241;

			internal ___003C_003EAnon1(Collection P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = arg_00241.contains(P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon2 : java.util.function.Predicate
		{
			private readonly Collection arg_00241;

			internal ___003C_003EAnon2(Collection P_0)
			{
				arg_00241 = P_0;
			}

			public bool test(object P_0)
			{
				bool result = lambda_0024retainAll_00241(arg_00241, P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon3 : java.util.function.Predicate
		{
			private readonly FilteredCollection arg_00241;

			private readonly java.util.function.Predicate arg_00242;

			internal ___003C_003EAnon3(FilteredCollection P_0, java.util.function.Predicate P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public bool test(object P_0)
			{
				bool result = arg_00241.lambda_0024removeIf_00242(arg_00242, P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Collection<TE;>;")]
		internal Collection unfiltered;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Predicate<-TE;>;")]
		internal com.google.common.@base.Predicate predicate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<TE;>;Lcom/google/common/base/Predicate<-TE;>;)V")]
		[LineNumberTable(new byte[] { 80, 104, 103, 103 })]
		internal FilteredCollection(Collection P_0, com.google.common.@base.Predicate P_1)
		{
			unfiltered = P_0;
			predicate = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 111, 142, 98, 143 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (safeContains(unfiltered, P_0))
			{
				bool result = predicate.apply(P_0);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Predicate<-TE;>;)Z")]
		[LineNumberTable(new byte[] { 160, 103, 103 })]
		public override bool removeIf(java.util.function.Predicate P_0)
		{
			Preconditions.checkNotNull(P_0);
			bool result = unfiltered.removeIf(new ___003C_003EAnon3(this, P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(181)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = Iterators.filter(unfiltered.iterator(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(new byte[] { 160, 80, 110, 137 })]
		private void lambda_0024forEach_00240(Consumer P_0, object P_1)
		{
			if (predicate.test(P_1))
			{
				P_0.accept(P_1);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(212)]
		private static bool lambda_0024retainAll_00241(Collection P_0, object P_1)
		{
			return (!P_0.contains(P_1)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(218)]
		private bool lambda_0024removeIf_00242(java.util.function.Predicate P_0, object P_1)
		{
			return (predicate.apply(P_1) && P_0.test(P_1)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Predicate<-TE;>;)Lcom/google/common/collect/Collections2$FilteredCollection<TE;>;")]
		[LineNumberTable(136)]
		internal virtual FilteredCollection createCombined(com.google.common.@base.Predicate P_0)
		{
			FilteredCollection result = new FilteredCollection(unfiltered, Predicates.and(predicate, P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(new byte[] { 92, 113 })]
		public override bool add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Preconditions.checkArgument(predicate.apply(P_0));
			bool result = unfiltered.add(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+TE;>;)Z")]
		[LineNumberTable(new byte[] { 98, 118, 113, 98 })]
		public override bool addAll(Collection P_0)
		{
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				Preconditions.checkArgument(predicate.apply(obj));
			}
			bool result = unfiltered.addAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 106, 114 })]
		public override void clear()
		{
			Iterables.removeIf(unfiltered, predicate);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(171)]
		public override bool containsAll(Collection P_0)
		{
			bool result = containsAllImpl(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(176)]
		public override bool isEmpty()
		{
			return (!Iterables.any(unfiltered, predicate)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TE;>;")]
		[LineNumberTable(186)]
		public override Spliterator spliterator()
		{
			Spliterator result = CollectSpliterators.filter(unfiltered.spliterator(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TE;>;)V")]
		[LineNumberTable(new byte[] { 160, 77, 103, 249, 70 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			unfiltered.forEach(new ___003C_003EAnon0(this, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(202)]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (contains(P_0) && unfiltered.remove(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(207)]
		public override bool removeAll(Collection P_0)
		{
			java.util.Objects.requireNonNull(P_0);
			bool result = removeIf(new ___003C_003EAnon1(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(212)]
		public override bool retainAll(Collection P_0)
		{
			bool result = removeIf(new ___003C_003EAnon2(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 109, 98, 123, 110, 132, 98 })]
		public override int size()
		{
			int num = 0;
			Iterator iterator = unfiltered.iterator();
			while (iterator.hasNext())
			{
				object obj = iterator.next();
				if (predicate.apply(obj))
				{
					num++;
				}
			}
			return num;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 116, 0, 0 })]
		[LineNumberTable(235)]
		public override object[] toArray()
		{
			object[] result = Lists.newArrayList(iterator()).toArray();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<T:Ljava/lang/Object;>([TT;)[TT;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 116, 0, 0 })]
		[LineNumberTable(241)]
		public override object[] toArray(object[] P_0)
		{
			object[] result = Lists.newArrayList(iterator()).toArray(P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<Ljava/util/List<TE;>;>;")]
	internal sealed class OrderedPermutationCollection : AbstractCollection
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableList<TE;>;")]
		internal ImmutableList inputList;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Comparator<-TE;>;")]
		internal Comparator comparator;

		[Modifiers(Modifiers.Final)]
		internal new int size;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<TE;>;Ljava/util/Comparator<-TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 76, 104, 109, 103, 114 })]
		internal OrderedPermutationCollection(Iterable P_0, Comparator P_1)
		{
			inputList = ImmutableList.sortedCopyOf(P_1, P_0);
			comparator = P_1;
			this.size = calculateSize(inputList, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("<E:Ljava/lang/Object;>(Ljava/util/List<TE;>;Ljava/util/Comparator<-TE;>;)I")]
		[LineNumberTable(new byte[]
		{
			161, 93, 98, 98, 98, 105, 119, 132, 110, 98,
			104, 166, 100, 100, 101
		})]
		private static int calculateSize(List P_0, Comparator P_1)
		{
			int num = 1;
			int num2 = 1;
			int num3 = 1;
			while (num2 < P_0.size())
			{
				int num4 = P_1.compare(P_0.get(num2 - 1), P_0.get(num2));
				if (num4 < 0)
				{
					num = IntMath.saturatedMultiply(num, IntMath.binomial(num2, num3));
					num3 = 0;
					if (num == int.MaxValue)
					{
						return int.MaxValue;
					}
				}
				num2++;
				num3++;
			}
			int result = IntMath.saturatedMultiply(num, IntMath.binomial(num2, num3));
			_ = null;
			return result;
		}

		public override int size()
		{
			return this.size;
		}

		public override bool isEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/List<TE;>;>;")]
		[LineNumberTable(494)]
		public override Iterator iterator()
		{
			OrderedPermutationIterator result = new OrderedPermutationIterator(inputList, comparator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 129, 104, 103, 143 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is List)
			{
				List list = (List)P_0;
				bool result = access_0024000(inputList, list);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(508)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(inputList);
			int num = 30 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("orderedPermutationCollection(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/AbstractIterator<Ljava/util/List<TE;>;>;")]
	internal sealed class OrderedPermutationIterator : AbstractIterator
	{
		[Signature("Ljava/util/List<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal List nextPermutation;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Comparator<-TE;>;")]
		internal Comparator comparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TE;>;Ljava/util/Comparator<-TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 146, 104, 108, 103 })]
		internal OrderedPermutationIterator(List P_0, Comparator P_1)
		{
			nextPermutation = Lists.newArrayList(P_0);
			comparator = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 163, 103, 100, 103, 225, 70, 140, 104, 109,
			108, 118
		})]
		internal virtual void calculateNextPermutation()
		{
			int num = findNextJ();
			if (num == -1)
			{
				nextPermutation = null;
				return;
			}
			java.util.Objects.requireNonNull(nextPermutation);
			int j = findNextL(num);
			Collections.swap(nextPermutation, num, j);
			int toIndex = nextPermutation.size();
			Collections.reverse(nextPermutation.subList(num + 1, toIndex));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 185, 108, 114, 127, 9, 2, 230, 69 })]
		internal virtual int findNextJ()
		{
			java.util.Objects.requireNonNull(nextPermutation);
			for (int i = nextPermutation.size() - 2; i >= 0; i += -1)
			{
				if (comparator.compare(nextPermutation.get(i), nextPermutation.get(i + 1)) < 0)
				{
					return i;
				}
			}
			return -1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 199, 108, 109, 114, 123, 2, 230, 69 })]
		internal virtual int findNextL(int P_0)
		{
			java.util.Objects.requireNonNull(nextPermutation);
			object o = nextPermutation.get(P_0);
			for (int i = nextPermutation.size() - 1; i > P_0; i += -1)
			{
				if (comparator.compare(o, nextPermutation.get(i)) < 0)
				{
					return i;
				}
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("this statement should be unreachable");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<TE;>;")]
		[LineNumberTable(new byte[] { 161, 154, 104, 140, 108, 102 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal new virtual List computeNext()
		{
			if (nextPermutation == null)
			{
				return (List)endOfData();
			}
			ImmutableList result = ImmutableList.copyOf(nextPermutation);
			calculateNextPermutation();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(512)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			List result = computeNext();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Ljava/util/AbstractCollection<Ljava/util/List<TE;>;>;")]
	internal sealed class PermutationCollection : AbstractCollection
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/ImmutableList<TE;>;")]
		internal ImmutableList inputList;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableList<TE;>;)V")]
		[LineNumberTable(new byte[] { 161, 235, 104, 103 })]
		internal PermutationCollection(ImmutableList P_0)
		{
			inputList = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(611)]
		public override int size()
		{
			int result = IntMath.factorial(inputList.size());
			_ = null;
			return result;
		}

		public override bool isEmpty()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/List<TE;>;>;")]
		[LineNumberTable(621)]
		public override Iterator iterator()
		{
			PermutationIterator result = new PermutationIterator(inputList);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 0, 104, 103, 143 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is List)
			{
				List list = (List)P_0;
				bool result = access_0024000(inputList, list);
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(635)]
		public override string toString()
		{
			string text = java.lang.String.valueOf(inputList);
			int num = 14 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string result = new StringBuilder(num).append("permutations(").append(text).append(")")
				.toString();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/AbstractIterator<Ljava/util/List<TE;>;>;")]
	internal class PermutationIterator : AbstractIterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/List<TE;>;")]
		internal List list;

		[Modifiers(Modifiers.Final)]
		internal int[] c;

		[Modifiers(Modifiers.Final)]
		internal int[] o;

		internal int j;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/List<TE;>;)V")]
		[LineNumberTable(new byte[] { 162, 19, 104, 108, 103, 108, 108, 108, 108, 107 })]
		internal PermutationIterator(List P_0)
		{
			list = new ArrayList(P_0);
			int num = P_0.size();
			c = new int[num];
			o = new int[num];
			Arrays.fill(c, 0);
			Arrays.fill(o, 1);
			j = int.MaxValue;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 41, 115, 194, 105, 193, 124, 100, 102, 130,
			107, 104, 130, 100, 102, 162, 127, 12, 110, 130
		})]
		internal virtual void calculateNextPermutation()
		{
			j = list.size() - 1;
			int num = 0;
			if (j == -1)
			{
				return;
			}
			int num2;
			while (true)
			{
				num2 = c[j] + o[j];
				if (num2 < 0)
				{
					switchDirection();
					continue;
				}
				if (num2 != j + 1)
				{
					break;
				}
				if (j == 0)
				{
					return;
				}
				num++;
				switchDirection();
			}
			Collections.swap(list, j - c[j] + num, j - num2 + num);
			c[j] = num2;
		}

		[LineNumberTable(new byte[] { 162, 72, 123, 110 })]
		internal virtual void switchDirection()
		{
			o[j] = -o[j];
			j--;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<TE;>;")]
		[LineNumberTable(new byte[] { 162, 32, 105, 140, 108, 102 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal new virtual List computeNext()
		{
			if (j <= 0)
			{
				return (List)endOfData();
			}
			ImmutableList result = ImmutableList.copyOf(list);
			calculateNextPermutation();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(639)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			List result = computeNext();
			_ = null;
			return result;
		}
	}

	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>Ljava/util/AbstractCollection<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 77, 0, 0,
		17, 1, 0, 0, 0, 77, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)77,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class TransformedCollection : AbstractCollection
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly TransformedCollection arg_00241;

			private readonly Consumer arg_00242;

			internal ___003C_003EAnon0(TransformedCollection P_0, Consumer P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024forEach_00240(arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon1 : java.util.function.Predicate
		{
			private readonly TransformedCollection arg_00241;

			private readonly java.util.function.Predicate arg_00242;

			internal ___003C_003EAnon1(TransformedCollection P_0, java.util.function.Predicate P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public bool test(object P_0)
			{
				bool result = arg_00241.lambda_0024removeIf_00241(arg_00242, P_0);
				_ = null;
				return result;
			}

			[SpecialName]
			public java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[SpecialName]
			public java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[SpecialName]
			public java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Collection<TF;>;")]
		internal Collection fromCollection;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Function<-TF;+TT;>;")]
		internal com.google.common.@base.Function function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<TF;>;Lcom/google/common/base/Function<-TF;+TT;>;)V")]
		[LineNumberTable(new byte[] { 160, 160, 104, 113, 113 })]
		internal TransformedCollection(Collection P_0, com.google.common.@base.Function P_1)
		{
			fromCollection = (Collection)Preconditions.checkNotNull(P_0);
			function = (com.google.common.@base.Function)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(302)]
		private void lambda_0024forEach_00240(Consumer P_0, object P_1)
		{
			P_0.accept(function.apply(P_1));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(308)]
		private bool lambda_0024removeIf_00241(java.util.function.Predicate P_0, object P_1)
		{
			bool result = P_0.test(function.apply(P_1));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 167, 109 })]
		public override void clear()
		{
			fromCollection.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(286)]
		public override bool isEmpty()
		{
			bool result = fromCollection.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(291)]
		public override Iterator iterator()
		{
			Iterator result = Iterators.transform(fromCollection.iterator(), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TT;>;")]
		[LineNumberTable(296)]
		public override Spliterator spliterator()
		{
			Spliterator result = CollectSpliterators.map(fromCollection.spliterator(), function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TT;>;)V")]
		[LineNumberTable(new byte[] { 160, 187, 103, 121 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			fromCollection.forEach(new ___003C_003EAnon0(this, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Predicate<-TT;>;)Z")]
		[LineNumberTable(new byte[] { 160, 193, 103 })]
		public override bool removeIf(java.util.function.Predicate P_0)
		{
			Preconditions.checkNotNull(P_0);
			bool result = fromCollection.removeIf(new ___003C_003EAnon1(this, P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(313)]
		public override int size()
		{
			int result = fromCollection.size();
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[] { 160, 215, 118, 105, 130, 98 })]
	internal static bool containsAllImpl(Collection P_0, Collection P_1)
	{
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			object o = iterator.next();
			if (!P_0.contains(o))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Ljava/lang/String;")]
	[LineNumberTable(new byte[]
	{
		160, 225, 115, 98, 118, 99, 140, 98, 100, 142,
		136, 98
	})]
	internal static string toStringImpl(Collection P_0)
	{
		StringBuilder stringBuilder = newStringBuilderForCollection(P_0.size()).append('[');
		int num = 1;
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (num == 0)
			{
				stringBuilder.append(", ");
			}
			num = 0;
			if (obj == P_0)
			{
				stringBuilder.append("(this Collection)");
			}
			else
			{
				stringBuilder.append(obj);
			}
		}
		string result = stringBuilder.append(']').toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[] { 55, 135, 127, 16, 97 })]
	internal static bool safeContains(Collection P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		//Discarded unreachable code: IL_0010
		Preconditions.checkNotNull(P_0);
		try
		{
			try
			{
				return P_0.contains(P_1);
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_0032;
		}
		object obj = null;
		goto IL_0036;
		IL_0032:
		obj = null;
		goto IL_0036;
		IL_0036:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[] { 68, 135, 127, 16, 97 })]
	internal static bool safeRemove(Collection P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		//Discarded unreachable code: IL_0010
		Preconditions.checkNotNull(P_0);
		try
		{
			try
			{
				return P_0.remove(P_1);
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
		}
		catch (System.Exception x2)
		{
			if (ByteCodeHelper.MapException<NullPointerException>(x2, ByteCodeHelper.MapFlags.Unused) == null)
			{
				throw;
			}
			goto IL_0032;
		}
		object obj = null;
		goto IL_0036;
		IL_0032:
		obj = null;
		goto IL_0036;
		IL_0036:
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<*>;Ljava/util/List<*>;)Z")]
	[LineNumberTable(new byte[] { 162, 79, 110, 130, 103, 103 })]
	private static bool isPermutation(List P_0, List P_1)
	{
		if (P_0.size() != P_1.size())
		{
			return false;
		}
		HashMultiset hashMultiset = HashMultiset.create(P_0);
		HashMultiset obj = HashMultiset.create(P_1);
		bool result = ((Multiset)hashMultiset).equals((object)obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 243, 108 })]
	internal static StringBuilder newStringBuilderForCollection(int P_0)
	{
		CollectPreconditions.checkNonnegative(P_0, "size");
		StringBuilder result = new StringBuilder((int)java.lang.Math.min((long)P_0 * 8L, 1073741824L));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<TE;>;Ljava/util/Comparator<-TE;>;)Ljava/util/Collection<Ljava/util/List<TE;>;>;")]
	[LineNumberTable(438)]
	public static Collection orderedPermutations(Iterable elements, Comparator comparator)
	{
		OrderedPermutationCollection result = new OrderedPermutationCollection(elements, comparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(60)]
	private Collections2()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;Lcom/google/common/base/Predicate<-TE;>;)Ljava/util/Collection<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 77, 0, 0 })]
	[LineNumberTable(new byte[] { 41, 168, 175 })]
	public static Collection filter(Collection unfiltered, com.google.common.@base.Predicate predicate)
	{
		if (unfiltered is FilteredCollection)
		{
			FilteredCollection result = ((FilteredCollection)unfiltered).createCombined(predicate);
			_ = null;
			return result;
		}
		FilteredCollection result2 = new FilteredCollection((Collection)Preconditions.checkNotNull(unfiltered), (com.google.common.@base.Predicate)Preconditions.checkNotNull(predicate));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>(Ljava/util/Collection<TF;>;Lcom/google/common/base/Function<-TF;TT;>;)Ljava/util/Collection<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 77, 0, 0,
		18, 1, 0, 0, 0, 77, 0, 0
	})]
	[LineNumberTable(266)]
	public static Collection transform(Collection fromCollection, com.google.common.@base.Function function)
	{
		TransformedCollection result = new TransformedCollection(fromCollection, function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable<-TE;>;>(Ljava/lang/Iterable<TE;>;)Ljava/util/Collection<Ljava/util/List<TE;>;>;")]
	[LineNumberTable(386)]
	public static Collection orderedPermutations(Iterable elements)
	{
		Collection result = orderedPermutations(elements, Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;)Ljava/util/Collection<Ljava/util/List<TE;>;>;")]
	[LineNumberTable(599)]
	public static Collection permutations(Collection elements)
	{
		PermutationCollection result = new PermutationCollection(ImmutableList.copyOf(elements));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(59)]
	internal static bool access_0024000(List P_0, List P_1)
	{
		bool result = isPermutation(P_0, P_1);
		_ = null;
		return result;
	}
}
