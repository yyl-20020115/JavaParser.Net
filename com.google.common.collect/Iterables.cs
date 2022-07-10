using System;
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
	(byte)120,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Iterables : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "cycle", "(Ljava.lang.Iterable;)Ljava.lang.Iterable;")]
	internal class _1 : FluentIterable
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : java.util.function.Supplier
		{
			private readonly Iterable arg_00241;

			internal ___003C_003EAnon0(Iterable P_0)
			{
				arg_00241 = P_0;
			}

			public object get()
			{
				Iterable result = lambda_0024spliterator_00240(arg_00241);
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon1 : java.util.function.Function
		{
			internal ___003C_003EAnon1()
			{
			}

			public object apply(object P_0)
			{
				Stream result = Streams.stream((Iterable)P_0);
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

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024iterable;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		private static Iterable lambda_0024spliterator_00240(Iterable P_0)
		{
			return P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(380)]
		internal _1(Iterable P_0)
		{
			val_0024iterable = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(383)]
		public override Iterator iterator()
		{
			Iterator result = Iterators.cycle(val_0024iterable);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TT;>;")]
		[LineNumberTable(388)]
		public override Spliterator spliterator()
		{
			Spliterator result = Stream.generate(new ___003C_003EAnon0(val_0024iterable)).flatMap(new ___003C_003EAnon1()).spliterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(393)]
		public override string toString()
		{
			string result = java.lang.String.instancehelper_concat(java.lang.String.valueOf(java.lang.Object.instancehelper_toString(val_0024iterable)), " (cycled)");
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<Ljava/lang/Iterable<+TT;>;Ljava/util/Iterator<+TT;>;>;")]
	[EnclosingMethod(null, "toIterator", "()Lcom.google.common.base.Function;")]
	[Implements(new string[] { "com.google.common.base.Function" })]
	internal class _10 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1084)]
		internal _10()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+TT;>;)Ljava/util/Iterator<+TT;>;")]
		[LineNumberTable(1087)]
		public virtual Iterator apply(Iterable P_0)
		{
			Iterator result = P_0.iterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1084)]
		public virtual object apply(object P_0)
		{
			Iterator result = apply((Iterable)P_0);
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

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<Ljava/util/List<TT;>;>;")]
	[EnclosingMethod(null, "partition", "(Ljava.lang.Iterable;I)Ljava.lang.Iterable;")]
	internal class _2 : FluentIterable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024iterable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024size;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(536)]
		internal _2(Iterable P_0, int P_1)
		{
			val_0024iterable = P_0;
			val_0024size = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/List<TT;>;>;")]
		[LineNumberTable(539)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = Iterators.partition(val_0024iterable.iterator(), val_0024size);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<Ljava/util/List<TT;>;>;")]
	[EnclosingMethod(null, "paddedPartition", "(Ljava.lang.Iterable;I)Ljava.lang.Iterable;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0,
		1,
		16,
		byte.MaxValue,
		byte.MaxValue,
		2,
		3,
		0,
		3,
		0,
		0,
		25,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)25,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _3 : FluentIterable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024iterable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024size;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(563)]
		internal _3(Iterable P_0, int P_1)
		{
			val_0024iterable = P_0;
			val_0024size = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/List<TT;>;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 1, 20, 2, 3, 0, 3, 0, 0, 25,
			0, 0
		})]
		[LineNumberTable(566)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = Iterators.paddedPartition(val_0024iterable.iterator(), val_0024size);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "filter", "(Ljava.lang.Iterable;Lcom.google.common.base.Predicate;)Ljava.lang.Iterable;")]
	internal class _4 : FluentIterable
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly com.google.common.@base.Predicate arg_00241;

			private readonly Consumer arg_00242;

			internal ___003C_003EAnon0(com.google.common.@base.Predicate P_0, Consumer P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				lambda_0024forEach_00240(arg_00241, arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024unfiltered;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal com.google.common.@base.Predicate val_0024retainIfTrue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(581)]
		internal _4(Iterable P_0, com.google.common.@base.Predicate P_1)
		{
			val_0024unfiltered = P_0;
			val_0024retainIfTrue = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(new byte[] { 161, 222, 105, 137 })]
		private static void lambda_0024forEach_00240(com.google.common.@base.Predicate P_0, Consumer P_1, object P_2)
		{
			if (P_0.test(P_2))
			{
				P_1.accept(P_2);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(584)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = Iterators.filter(val_0024unfiltered.iterator(), val_0024retainIfTrue);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TT;>;)V")]
		[LineNumberTable(new byte[] { 161, 219, 103, 254, 70 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			val_0024unfiltered.forEach(new ___003C_003EAnon0(val_0024retainIfTrue, P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TT;>;")]
		[LineNumberTable(600)]
		public override Spliterator spliterator()
		{
			Spliterator result = CollectSpliterators.filter(val_0024unfiltered.spliterator(), val_0024retainIfTrue);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "transform", "(Ljava.lang.Iterable;Lcom.google.common.base.Function;)Ljava.lang.Iterable;")]
	internal class _5 : FluentIterable
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly Consumer arg_00241;

			private readonly com.google.common.@base.Function arg_00242;

			internal ___003C_003EAnon0(Consumer P_0, com.google.common.@base.Function P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				lambda_0024forEach_00240(arg_00241, arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024fromIterable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal com.google.common.@base.Function val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(743)]
		internal _5(Iterable P_0, com.google.common.@base.Function P_1)
		{
			val_0024fromIterable = P_0;
			val_0024function = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(752)]
		private static void lambda_0024forEach_00240(Consumer P_0, com.google.common.@base.Function P_1, object P_2)
		{
			P_0.accept(P_1.apply(P_2));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(746)]
		public override Iterator iterator()
		{
			Iterator result = Iterators.transform(val_0024fromIterable.iterator(), val_0024function);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TT;>;)V")]
		[LineNumberTable(new byte[] { 162, 125, 103, 126 })]
		public override void forEach(Consumer P_0)
		{
			Preconditions.checkNotNull(P_0);
			val_0024fromIterable.forEach(new ___003C_003EAnon0(P_0, val_0024function));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TT;>;")]
		[LineNumberTable(757)]
		public override Spliterator spliterator()
		{
			Spliterator result = CollectSpliterators.map(val_0024fromIterable.spliterator(), val_0024function);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "skip", "(Ljava.lang.Iterable;I)Ljava.lang.Iterable;")]
	internal class _6 : FluentIterable
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
		[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
		internal new class _1 : java.lang.Object, Iterator
		{
			internal bool atStart;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024iterator;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 163, 47, 111 })]
			internal _1(_6 P_0, Iterator P_1)
			{
				val_0024iterator = P_1;
				base._002Ector();
				atStart = true;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(934)]
			public virtual bool hasNext()
			{
				bool result = val_0024iterator.hasNext();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TT;")]
			[LineNumberTable(new byte[] { 163, 58, 108, 103 })]
			[ParametricNullness(new object[]
			{
				(byte)64,
				"Lcom/google/common/collect/ParametricNullness;"
			})]
			public virtual object next()
			{
				object result = val_0024iterator.next();
				atStart = false;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 163, 65, 113, 109 })]
			public virtual void remove()
			{
				CollectPreconditions.checkRemove((!atStart) ? true : false);
				val_0024iterator.remove();
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual void forEachRemaining(Consumer P_0)
			{
				Iterator._003Cdefault_003EforEachRemaining(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024iterable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024numberToSkip;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(912)]
		internal _6(Iterable P_0, int P_1)
		{
			val_0024iterable = P_0;
			val_0024numberToSkip = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(new byte[] { 163, 33, 109, 108, 114, 149, 140, 237, 71 })]
		public override Iterator iterator()
		{
			if (val_0024iterable is List)
			{
				List list = (List)val_0024iterable;
				int fromIndex = java.lang.Math.min(list.size(), val_0024numberToSkip);
				Iterator result = list.subList(fromIndex, list.size()).iterator();
				_ = null;
				return result;
			}
			Iterator iterator = val_0024iterable.iterator();
			Iterators.advance(iterator, val_0024numberToSkip);
			_1 result2 = new _1(this, iterator);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TT;>;")]
		[LineNumberTable(new byte[] { 163, 73, 109, 108, 114, 149 })]
		public override Spliterator spliterator()
		{
			if (val_0024iterable is List)
			{
				List list = (List)val_0024iterable;
				int fromIndex = java.lang.Math.min(list.size(), val_0024numberToSkip);
				Spliterator result = list.subList(fromIndex, list.size()).spliterator();
				_ = null;
				return result;
			}
			Spliterator result2 = Streams.stream(val_0024iterable).skip(val_0024numberToSkip).spliterator();
			_ = null;
			return result2;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "limit", "(Ljava.lang.Iterable;I)Ljava.lang.Iterable;")]
	internal class _7 : FluentIterable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024iterable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024limitSize;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(983)]
		internal _7(Iterable P_0, int P_1)
		{
			val_0024iterable = P_0;
			val_0024limitSize = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(986)]
		public override Iterator iterator()
		{
			Iterator result = Iterators.limit(val_0024iterable.iterator(), val_0024limitSize);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TT;>;")]
		[LineNumberTable(991)]
		public override Spliterator spliterator()
		{
			Spliterator result = Streams.stream(val_0024iterable).limit(val_0024limitSize).spliterator();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "consumingIterable", "(Ljava.lang.Iterable;)Ljava.lang.Iterable;")]
	internal class _8 : FluentIterable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024iterable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1016)]
		internal _8(Iterable P_0)
		{
			val_0024iterable = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(new byte[] { 163, 137, 109, 114, 16 })]
		public override Iterator iterator()
		{
			Iterator obj = ((!(val_0024iterable is Queue)) ? Iterators.consumingIterator(val_0024iterable.iterator()) : new ConsumingQueueIterator((Queue)val_0024iterable));
			Iterator result = ((obj == null) ? null : ((obj as Iterator) ?? throw new java.lang.IncompatibleClassChangeError()));
			_ = null;
			return result;
		}

		public override string toString()
		{
			return "Iterables.consumingIterable(...)";
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/FluentIterable<TT;>;")]
	[EnclosingMethod(null, "mergeSorted", "(Ljava.lang.Iterable;Ljava.util.Comparator;)Ljava.lang.Iterable;")]
	internal class _9 : FluentIterable
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024iterables;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Comparator val_0024comparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1070)]
		internal _9(Iterable P_0, Comparator P_1)
		{
			val_0024iterables = P_0;
			val_0024comparator = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(new byte[] { 163, 191, 102, 48 })]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = Iterators.mergeSorted(Iterables.transform(val_0024iterables, toIterator()), val_0024comparator);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/FluentIterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 50, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)50,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class UnmodifiableIterable : FluentIterable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/lang/Iterable<+TT;>;")]
		private Iterable iterable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(95)]
		internal UnmodifiableIterable(Iterable P_0, Iterables._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+TT;>;)V")]
		[LineNumberTable(new byte[] { 49, 104, 103 })]
		private UnmodifiableIterable(Iterable P_0)
		{
			iterable = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TT;>;")]
		[LineNumberTable(105)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = Iterators.unmodifiableIterator(iterable.iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TT;>;)V")]
		[LineNumberTable(new byte[] { 60, 110 })]
		public override void forEach(Consumer P_0)
		{
			iterable.forEach(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TT;>;")]
		[LineNumberTable(116)]
		public override Spliterator spliterator()
		{
			Spliterator result = iterable.spliterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(121)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(iterable);
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;)[Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(310)]
	internal static object[] toArray(Iterable P_0)
	{
		object[] result = castOrCopyToCollection(P_0).toArray();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;[TT;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 185, 103 })]
	internal static object[] toArray(Iterable P_0, object[] P_1)
	{
		Collection collection = castOrCopyToCollection(P_0);
		object[] result = collection.toArray(P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;Lcom/google/common/base/Predicate<-TT;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 88, 104, 143 })]
	public static bool removeIf(Iterable removeFrom, com.google.common.@base.Predicate predicate)
	{
		if (removeFrom is Collection)
		{
			bool result = ((Collection)removeFrom).removeIf(predicate);
			_ = null;
			return result;
		}
		bool result2 = Iterators.removeIf(removeFrom.iterator(), predicate);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;Lcom/google/common/base/Predicate<-TT;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(634)]
	public static bool any(Iterable iterable, com.google.common.@base.Predicate predicate)
	{
		bool result = Iterators.any(iterable.iterator(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<TT;>;Ljava/lang/Iterable<+TT;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 219, 104, 103, 138 })]
	public static bool addAll(Collection addTo, Iterable elementsToAdd)
	{
		if (elementsToAdd is Collection)
		{
			Collection c = (Collection)elementsToAdd;
			bool result = addTo.addAll(c);
			_ = null;
			return result;
		}
		bool result2 = Iterators.addAll(addTo, ((Iterable)Preconditions.checkNotNull(elementsToAdd)).iterator());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;TT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(831)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object getFirst(Iterable iterable, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object defaultValue)
	{
		object next = Iterators.getNext(iterable.iterator(), defaultValue);
		_ = null;
		return next;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;I)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 27, 103, 145 })]
	public static Iterable skip(Iterable iterable, int numberToSkip)
	{
		Preconditions.checkNotNull(iterable);
		Preconditions.checkArgument(numberToSkip >= 0, (object)"number to skip cannot be negative");
		_6 result = new _6(iterable, numberToSkip);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;)Ljava/lang/String;")]
	[LineNumberTable(249)]
	public static string toString(Iterable iterable)
	{
		string result = Iterators.toString(iterable.iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;)I")]
	[LineNumberTable(new byte[] { 78, 104, 109, 13 })]
	public static int size(Iterable iterable)
	{
		int result = ((!(iterable is Collection)) ? Iterators.size(iterable.iterator()) : ((Collection)iterable).size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Object;>;Ljava/lang/Object;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 2, 3, 0, 2, 0, 0,
		120, 0, 0
	})]
	[LineNumberTable(new byte[] { 92, 104, 103, 138 })]
	public static bool contains(Iterable iterable, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		if (iterable is Collection)
		{
			Collection collection = (Collection)iterable;
			bool result = Collections2.safeContains(collection, element);
			_ = null;
			return result;
		}
		bool result2 = Iterators.contains(iterable.iterator(), element);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 9, 103 })]
	public static Iterable cycle(Iterable iterable)
	{
		Preconditions.checkNotNull(iterable);
		_1 result = new _1(iterable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;Lcom/google/common/base/Predicate<-TT;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 209, 103, 103 })]
	public static Iterable filter(Iterable unfiltered, com.google.common.@base.Predicate retainIfTrue)
	{
		Preconditions.checkNotNull(unfiltered);
		Preconditions.checkNotNull(retainIfTrue);
		_4 result = new _4(unfiltered, retainIfTrue);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<*>;Ljava/lang/Class<TT;>;)Ljava/lang/Iterable<TT;>;")]
	[LineNumberTable(new byte[] { 161, 252, 103, 103 })]
	public static Iterable filter(Iterable unfiltered, Class desiredType)
	{
		Preconditions.checkNotNull(unfiltered);
		Preconditions.checkNotNull(desiredType);
		Iterable result = filter(unfiltered, Predicates.instanceOf(desiredType));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;Lcom/google/common/base/Predicate<-TT;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(645)]
	public static bool all(Iterable iterable, com.google.common.@base.Predicate predicate)
	{
		bool result = Iterators.all(iterable.iterator(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;Lcom/google/common/base/Predicate<-TT;>;)Lcom/google/common/base/Optional<TT;>;")]
	[LineNumberTable(708)]
	public static com.google.common.@base.Optional tryFind(Iterable iterable, com.google.common.@base.Predicate predicate)
	{
		com.google.common.@base.Optional result = Iterators.tryFind(iterable.iterator(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>(Ljava/lang/Iterable<TF;>;Lcom/google/common/base/Function<-TF;+TT;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 120, 0, 0,
		18, 1, 0, 0, 0, 120, 0, 0
	})]
	[LineNumberTable(new byte[] { 162, 115, 103, 103 })]
	public static Iterable transform(Iterable fromIterable, com.google.common.@base.Function function)
	{
		Preconditions.checkNotNull(fromIterable);
		Preconditions.checkNotNull(function);
		_5 result = new _5(fromIterable, function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;I)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 99, 103, 113 })]
	public static Iterable limit(Iterable iterable, int limitSize)
	{
		Preconditions.checkNotNull(iterable);
		Preconditions.checkArgument(limitSize >= 0, (object)"limit is negative");
		_7 result = new _7(iterable, limitSize);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;Ljava/lang/Class<TT;>;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 1, 0, 0, 0, 120, 0, 0,
		22, 0, 2, 3, 0, 2, 0, 0, 120, 0,
		0
	})]
	[LineNumberTable(295)]
	public static object[] toArray(Iterable iterable, Class type)
	{
		object[] result = toArray(iterable, ObjectArrays.newArray(type, 0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;I)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 149, 103, 104, 110, 14 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object get(Iterable iterable, int position)
	{
		Preconditions.checkNotNull(iterable);
		object result = ((!(iterable is List)) ? Iterators.get(iterable.iterator(), position) : ((List)iterable).get(position));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/base/Function<Ljava/lang/Iterable<+TT;>;Ljava/util/Iterator<+TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(1084)]
	internal static com.google.common.@base.Function toIterator()
	{
		_10 result = new _10();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(263)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object getOnlyElement(Iterable iterable)
	{
		object onlyElement = Iterators.getOnlyElement(iterable.iterator());
		_ = null;
		return onlyElement;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(436)]
	public static Iterable concat(Iterable a, Iterable b)
	{
		FluentIterable result = FluentIterable.concat(a, b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 220, 104, 103, 104, 139, 169 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object getLast(Iterable iterable)
	{
		if (iterable is List)
		{
			List list = (List)iterable;
			if (list.isEmpty())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			object lastInNonemptyList = getLastInNonemptyList(list);
			_ = null;
			return lastInNonemptyList;
		}
		object last = Iterators.getLast(iterable.iterator());
		_ = null;
		return last;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<TE;>;)Ljava/util/Collection<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 206, 104, 104, 11 })]
	private static Collection castOrCopyToCollection(Iterable P_0)
	{
		Collection obj = ((!(P_0 is Collection)) ? Lists.newArrayList(P_0.iterator()) : ((Collection)P_0));
		Collection result = ((obj == null) ? null : ((obj as Collection) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/List<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(885)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	private static object getLastInNonemptyList(List P_0)
	{
		object result = P_0.get(P_0.size() - 1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(70)]
	private Iterables()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 25, 103, 144, 98, 130 })]
	public static Iterable unmodifiableIterable(Iterable iterable)
	{
		Preconditions.checkNotNull(iterable);
		if (iterable is UnmodifiableIterable || iterable is ImmutableCollection)
		{
			return iterable;
		}
		UnmodifiableIterable result = new UnmodifiableIterable(iterable, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/ImmutableCollection<TE;>;)Ljava/lang/Iterable<TE;>;")]
	[LineNumberTable(92)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static Iterable unmodifiableIterable(ImmutableCollection iterable)
	{
		return (Iterable)Preconditions.checkNotNull(iterable);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[] { 111, 104, 120, 14 })]
	public static bool removeAll(Iterable removeFrom, Collection elementsToRemove)
	{
		bool result = ((!(removeFrom is Collection)) ? Iterators.removeAll(removeFrom.iterator(), elementsToRemove) : ((Collection)removeFrom).removeAll((Collection)Preconditions.checkNotNull(elementsToRemove)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[] { 160, 64, 104, 120, 14 })]
	public static bool retainAll(Iterable removeFrom, Collection elementsToRetain)
	{
		bool result = ((!(removeFrom is Collection)) ? Iterators.retainAll(removeFrom.iterator(), elementsToRetain) : ((Collection)removeFrom).retainAll((Collection)Preconditions.checkNotNull(elementsToRetain)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;Lcom/google/common/base/Predicate<-TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 98, 103, 103, 104, 103, 105, 102, 130, 98 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal static object removeFirstMatching(Iterable P_0, com.google.common.@base.Predicate P_1)
	{
		Preconditions.checkNotNull(P_1);
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (P_1.apply(obj))
			{
				iterator.remove();
				return obj;
			}
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;Ljava/lang/Iterable<*>;)Z")]
	[LineNumberTable(new byte[] { 160, 117, 112, 103, 103, 110, 162 })]
	public static bool elementsEqual(Iterable iterable1, Iterable iterable2)
	{
		if (iterable1 is Collection && iterable2 is Collection)
		{
			Collection collection = (Collection)iterable1;
			Collection collection2 = (Collection)iterable2;
			if (collection.size() != collection2.size())
			{
				return false;
			}
		}
		bool result = Iterators.elementsEqual(iterable1.iterator(), iterable2.iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;TT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(278)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object getOnlyElement(Iterable iterable, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object defaultValue)
	{
		object onlyElement = Iterators.getOnlyElement(iterable.iterator(), defaultValue);
		_ = null;
		return onlyElement;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;Ljava/lang/Object;)I")]
	[LineNumberTable(new byte[] { 160, 238, 104, 111, 104, 147 })]
	public static int frequency(Iterable iterable, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		if (iterable is Multiset)
		{
			int result = ((Multiset)iterable).count(element);
			_ = null;
			return result;
		}
		if (iterable is Set)
		{
			return ((Set)iterable).contains(element) ? 1 : 0;
		}
		int result2 = Iterators.frequency(iterable.iterator(), element);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(420)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static Iterable cycle(params object[] elements)
	{
		Iterable result = cycle(Lists.newArrayList(elements));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(452)]
	public static Iterable concat(Iterable a, Iterable b, Iterable c)
	{
		FluentIterable result = FluentIterable.concat(a, b, c);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;Ljava/lang/Iterable<+TT;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(472)]
	public static Iterable concat(Iterable a, Iterable b, Iterable c, Iterable d)
	{
		FluentIterable result = FluentIterable.concat(a, b, c, d);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([Ljava/lang/Iterable<+TT;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(490)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static Iterable concat(params Iterable[] inputs)
	{
		FluentIterable result = FluentIterable.concat(inputs);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/lang/Iterable<+TT;>;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(507)]
	public static Iterable concat(Iterable inputs)
	{
		FluentIterable result = FluentIterable.concat(inputs);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;I)Ljava/lang/Iterable<Ljava/util/List<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 164, 103, 105 })]
	public static Iterable partition(Iterable iterable, int size)
	{
		Preconditions.checkNotNull(iterable);
		Preconditions.checkArgument(size > 0);
		_2 result = new _2(iterable, size);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;I)Ljava/lang/Iterable<Ljava/util/List<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 2, 3, 0, 3, 0, 0, 120,
		0, 0, 18, 0, 0, 0, 0, 120, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 191, 103, 105 })]
	public static Iterable paddedPartition(Iterable iterable, int size)
	{
		Preconditions.checkNotNull(iterable);
		Preconditions.checkArgument(size > 0);
		_3 result = new _3(iterable, size);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;Lcom/google/common/base/Predicate<-TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(660)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object find(Iterable iterable, com.google.common.@base.Predicate predicate)
	{
		object result = Iterators.find(iterable.iterator(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;Lcom/google/common/base/Predicate<-TT;>;TT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(693)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static object find(Iterable iterable, com.google.common.@base.Predicate predicate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object defaultValue)
	{
		object result = Iterators.find(iterable.iterator(), predicate, defaultValue);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;Lcom/google/common/base/Predicate<-TT;>;)I")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(723)]
	public static int indexOf(Iterable iterable, com.google.common.@base.Predicate predicate)
	{
		int result = Iterators.indexOf(iterable.iterator(), predicate);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;ITT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 173, 103, 102, 104, 103, 148, 103, 104 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object get(Iterable iterable, int position, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object defaultValue)
	{
		Preconditions.checkNotNull(iterable);
		Iterators.checkNonnegative(position);
		if (iterable is List)
		{
			List list = Lists.cast(iterable);
			return (position >= list.size()) ? defaultValue : list.get(position);
		}
		Iterator iterator = iterable.iterator();
		Iterators.advance(iterator, position);
		object next = Iterators.getNext(iterator, defaultValue);
		_ = null;
		return next;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+TT;>;TT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 245, 104, 103, 104, 98, 104, 206 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object getLast(Iterable iterable, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object defaultValue)
	{
		if (iterable is Collection)
		{
			Collection collection = (Collection)iterable;
			if (collection.isEmpty())
			{
				return defaultValue;
			}
			if (iterable is List)
			{
				object lastInNonemptyList = getLastInNonemptyList(Lists.cast(iterable));
				_ = null;
				return lastInNonemptyList;
			}
		}
		object last = Iterators.getLast(iterable.iterator(), defaultValue);
		_ = null;
		return last;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 132, 135 })]
	public static Iterable consumingIterable(Iterable iterable)
	{
		Preconditions.checkNotNull(iterable);
		_8 result = new _8(iterable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;)Z")]
	[LineNumberTable(new byte[] { 163, 163, 104, 142 })]
	public static bool isEmpty(Iterable iterable)
	{
		if (iterable is Collection)
		{
			bool result = ((Collection)iterable).isEmpty();
			_ = null;
			return result;
		}
		return (!iterable.iterator().hasNext()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/lang/Iterable<+TT;>;>;Ljava/util/Comparator<-TT;>;)Ljava/lang/Iterable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 120, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 185, 108, 108, 232, 72 })]
	public static Iterable mergeSorted(Iterable iterables, Comparator comparator)
	{
		Preconditions.checkNotNull((object)iterables, (object)"iterables");
		Preconditions.checkNotNull((object)comparator, (object)"comparator");
		_9  = new _9(iterables, comparator);
		UnmodifiableIterable result = new UnmodifiableIterable(, null);
		_ = null;
		return result;
	}
}
