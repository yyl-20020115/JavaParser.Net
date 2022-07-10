using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.math;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)176,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Streams : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/util/Spliterators$AbstractSpliterator<TR;>;")]
	[EnclosingMethod(null, "zip", "(Ljava.util.stream.Stream;Ljava.util.stream.Stream;Ljava.util.function.BiFunction;)Ljava.util.stream.Stream;")]
	internal class _1 : Spliterators.AbstractSpliterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024itrA;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024itrB;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal BiFunction val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(334)]
		internal _1(long P_0, int P_1, Iterator P_2, Iterator P_3, BiFunction P_4)
		{
			val_0024itrA = P_2;
			val_0024itrB = P_3;
			val_0024function = P_4;
			base._002Ector(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TR;>;)Z")]
		[LineNumberTable(new byte[] { 160, 223, 122, 127, 8, 130 })]
		public override bool tryAdvance(Consumer P_0)
		{
			if (val_0024itrA.hasNext() && val_0024itrB.hasNext())
			{
				P_0.accept(val_0024function.apply(val_0024itrA.next(), val_0024itrB.next()));
				return true;
			}
			return false;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "findLast", "(Ljava.util.stream.Stream;)Ljava.util.Optional;")]
	internal class _1OptionalState : java.lang.Object
	{
		internal bool set;

		[Signature("TT;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 223, 104, 103 })]
		internal _1OptionalState()
		{
			this.set = false;
			value = null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(864)]
		internal virtual object get()
		{
			object result = java.util.Objects.requireNonNull(value);
			_ = null;
			return result;
		}

		[Signature("(TT;)V")]
		internal virtual void set(object P_0)
		{
			this.set = true;
			value = P_0;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Streams$MapWithIndexSpliterator<Ljava/util/Spliterator<TT;>;TR;Lcom/google/common/collect/Streams$1Splitr;>;Ljava/util/function/Consumer<TT;>;")]
	[EnclosingMethod(null, "mapWithIndex", "(Ljava.util.stream.Stream;Lcom.google.common.collect.Streams$FunctionWithIndex;)Ljava.util.stream.Stream;")]
	[Implements(new string[] { "java.util.function.Consumer" })]
	internal class _1Splitr : MapWithIndexSpliterator, Consumer
	{
		[Signature("TT;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object holder;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal FunctionWithIndex val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Spliterator<TT;>;J)V")]
		[LineNumberTable(new byte[] { 161, 88, 103, 106 })]
		internal _1Splitr(Spliterator P_0, long P_1, FunctionWithIndex P_2)
		{
			val_0024function = P_2;
			base._002Ector(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Spliterator<TT;>;J)Lcom/google/common/collect/Streams$1Splitr;")]
		[LineNumberTable(483)]
		internal new virtual _1Splitr createSplit(Spliterator P_0, long P_1)
		{
			_1Splitr result = new _1Splitr(P_0, P_1, val_0024function);
			_ = null;
			return result;
		}

		[Signature("(TT;)V")]
		public virtual void accept([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			holder = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TR;>;)Z")]
		[LineNumberTable(new byte[]
		{
			161, 99, 174, 127, 17, 134, 103, 35, 2, 226,
			69
		})]
		public override bool tryAdvance(Consumer P_0)
		{
			if (fromSpliterator.tryAdvance(this))
			{
				try
				{
					FunctionWithIndex functionWithIndex = val_0024function;
					object obj = NullnessCasts.uncheckedCastNullableTToT(holder);
					long num = index;
					index = num + 1;
					P_0.accept(functionWithIndex.apply(obj, num));
					return true;
				}
				finally
				{
					holder = null;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(455)]
		internal override MapWithIndexSpliterator createSplit(Spliterator P_0, long P_1)
		{
			_1Splitr result = createSplit(P_0, P_1);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/util/Spliterators$AbstractSpliterator<TR;>;")]
	[EnclosingMethod(null, "mapWithIndex", "(Ljava.util.stream.Stream;Lcom.google.common.collect.Streams$FunctionWithIndex;)Ljava.util.stream.Stream;")]
	internal class _2 : Spliterators.AbstractSpliterator
	{
		internal long index;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024fromIterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal FunctionWithIndex val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 70, 121 })]
		internal _2(long P_0, int P_1, Iterator P_2, FunctionWithIndex P_3)
		{
			val_0024fromIterator = P_2;
			val_0024function = P_3;
			base._002Ector(P_0, P_1);
			index = 0L;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TR;>;)Z")]
		[LineNumberTable(new byte[] { 161, 75, 109, 127, 17, 130 })]
		public override bool tryAdvance(Consumer P_0)
		{
			if (val_0024fromIterator.hasNext())
			{
				FunctionWithIndex functionWithIndex = val_0024function;
				object obj = val_0024fromIterator.next();
				long num = index;
				index = num + 1;
				P_0.accept(functionWithIndex.apply(obj, num));
				return true;
			}
			return false;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Streams$MapWithIndexSpliterator<Ljava/util/Spliterator$OfInt;TR;Lcom/google/common/collect/Streams$2Splitr;>;Ljava/util/function/IntConsumer;Ljava/util/Spliterator<TR;>;")]
	[EnclosingMethod(null, "mapWithIndex", "(Ljava.util.stream.IntStream;Lcom.google.common.collect.Streams$IntFunctionWithIndex;)Ljava.util.stream.Stream;")]
	[Implements(new string[] { "java.util.function.IntConsumer", "java.util.Spliterator" })]
	internal class _2Splitr : MapWithIndexSpliterator, IntConsumer, Spliterator
	{
		internal int holder;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal IntFunctionWithIndex val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Spliterator$OfInt;J)V")]
		[LineNumberTable(new byte[] { 161, 172, 103, 106 })]
		internal _2Splitr(Spliterator.OfInt P_0, long P_1, IntFunctionWithIndex P_2)
		{
			val_0024function = P_2;
			base._002Ector(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(562)]
		internal virtual _2Splitr createSplit(Spliterator.OfInt P_0, long P_1)
		{
			_2Splitr result = new _2Splitr(P_0, P_1, val_0024function);
			_ = null;
			return result;
		}

		public virtual void accept(int P_0)
		{
			holder = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TR;>;)Z")]
		[LineNumberTable(new byte[] { 161, 183, 115, 127, 12, 130 })]
		public override bool tryAdvance(Consumer P_0)
		{
			if (((Spliterator.OfInt)fromSpliterator).tryAdvance(this))
			{
				IntFunctionWithIndex intFunctionWithIndex = val_0024function;
				int i = holder;
				long num = index;
				index = num + 1;
				P_0.accept(intFunctionWithIndex.apply(i, num));
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(538)]
		internal override MapWithIndexSpliterator createSplit(Spliterator P_0, long P_1)
		{
			_2Splitr result = createSplit((Spliterator.OfInt)P_0, P_1);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual IntConsumer andThen(IntConsumer P_0)
		{
			return IntConsumer._003Cdefault_003EandThen(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override void forEachRemaining(Consumer P_0)
		{
			Spliterator._003Cdefault_003EforEachRemaining(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override long getExactSizeIfKnown()
		{
			return Spliterator._003Cdefault_003EgetExactSizeIfKnown(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override bool hasCharacteristics(int P_0)
		{
			return Spliterator._003Cdefault_003EhasCharacteristics(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override Comparator getComparator()
		{
			return Spliterator._003Cdefault_003EgetComparator(this);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/util/Spliterators$AbstractSpliterator<TR;>;")]
	[EnclosingMethod(null, "mapWithIndex", "(Ljava.util.stream.IntStream;Lcom.google.common.collect.Streams$IntFunctionWithIndex;)Ljava.util.stream.Stream;")]
	internal class _3 : Spliterators.AbstractSpliterator
	{
		internal long index;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal PrimitiveIterator.OfInt val_0024fromIterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal IntFunctionWithIndex val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 153, 121 })]
		internal _3(long P_0, int P_1, PrimitiveIterator.OfInt P_2, IntFunctionWithIndex P_3)
		{
			val_0024fromIterator = P_2;
			val_0024function = P_3;
			base._002Ector(P_0, P_1);
			index = 0L;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TR;>;)Z")]
		[LineNumberTable(new byte[] { 161, 158, 109, 127, 17, 130 })]
		public override bool tryAdvance(Consumer P_0)
		{
			if (val_0024fromIterator.hasNext())
			{
				IntFunctionWithIndex intFunctionWithIndex = val_0024function;
				int i = val_0024fromIterator.nextInt();
				long num = index;
				index = num + 1;
				P_0.accept(intFunctionWithIndex.apply(i, num));
				return true;
			}
			return false;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Streams$MapWithIndexSpliterator<Ljava/util/Spliterator$OfLong;TR;Lcom/google/common/collect/Streams$3Splitr;>;Ljava/util/function/LongConsumer;Ljava/util/Spliterator<TR;>;")]
	[EnclosingMethod(null, "mapWithIndex", "(Ljava.util.stream.LongStream;Lcom.google.common.collect.Streams$LongFunctionWithIndex;)Ljava.util.stream.Stream;")]
	[Implements(new string[] { "java.util.function.LongConsumer", "java.util.Spliterator" })]
	internal class _3Splitr : MapWithIndexSpliterator, LongConsumer, Spliterator
	{
		internal long holder;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LongFunctionWithIndex val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Spliterator$OfLong;J)V")]
		[LineNumberTable(new byte[] { 161, 251, 103, 106 })]
		internal _3Splitr(Spliterator.OfLong P_0, long P_1, LongFunctionWithIndex P_2)
		{
			val_0024function = P_2;
			base._002Ector(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(641)]
		internal virtual _3Splitr createSplit(Spliterator.OfLong P_0, long P_1)
		{
			_3Splitr result = new _3Splitr(P_0, P_1, val_0024function);
			_ = null;
			return result;
		}

		public virtual void accept(long P_0)
		{
			holder = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TR;>;)Z")]
		[LineNumberTable(new byte[] { 162, 6, 115, 127, 12, 130 })]
		public override bool tryAdvance(Consumer P_0)
		{
			if (((Spliterator.OfLong)fromSpliterator).tryAdvance(this))
			{
				LongFunctionWithIndex longFunctionWithIndex = val_0024function;
				long l = holder;
				long num = index;
				index = num + 1;
				P_0.accept(longFunctionWithIndex.apply(l, num));
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(617)]
		internal override MapWithIndexSpliterator createSplit(Spliterator P_0, long P_1)
		{
			_3Splitr result = createSplit((Spliterator.OfLong)P_0, P_1);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual LongConsumer andThen(LongConsumer P_0)
		{
			return LongConsumer._003Cdefault_003EandThen(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override void forEachRemaining(Consumer P_0)
		{
			Spliterator._003Cdefault_003EforEachRemaining(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override long getExactSizeIfKnown()
		{
			return Spliterator._003Cdefault_003EgetExactSizeIfKnown(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override bool hasCharacteristics(int P_0)
		{
			return Spliterator._003Cdefault_003EhasCharacteristics(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override Comparator getComparator()
		{
			return Spliterator._003Cdefault_003EgetComparator(this);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/util/Spliterators$AbstractSpliterator<TR;>;")]
	[EnclosingMethod(null, "mapWithIndex", "(Ljava.util.stream.LongStream;Lcom.google.common.collect.Streams$LongFunctionWithIndex;)Ljava.util.stream.Stream;")]
	internal class _4 : Spliterators.AbstractSpliterator
	{
		internal long index;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal PrimitiveIterator.OfLong val_0024fromIterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal LongFunctionWithIndex val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 232, 121 })]
		internal _4(long P_0, int P_1, PrimitiveIterator.OfLong P_2, LongFunctionWithIndex P_3)
		{
			val_0024fromIterator = P_2;
			val_0024function = P_3;
			base._002Ector(P_0, P_1);
			index = 0L;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TR;>;)Z")]
		[LineNumberTable(new byte[] { 161, 237, 109, 127, 17, 130 })]
		public override bool tryAdvance(Consumer P_0)
		{
			if (val_0024fromIterator.hasNext())
			{
				LongFunctionWithIndex longFunctionWithIndex = val_0024function;
				long l = val_0024fromIterator.nextLong();
				long num = index;
				index = num + 1;
				P_0.accept(longFunctionWithIndex.apply(l, num));
				return true;
			}
			return false;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Streams$MapWithIndexSpliterator<Ljava/util/Spliterator$OfDouble;TR;Lcom/google/common/collect/Streams$4Splitr;>;Ljava/util/function/DoubleConsumer;Ljava/util/Spliterator<TR;>;")]
	[EnclosingMethod(null, "mapWithIndex", "(Ljava.util.stream.DoubleStream;Lcom.google.common.collect.Streams$DoubleFunctionWithIndex;)Ljava.util.stream.Stream;")]
	[Implements(new string[] { "java.util.function.DoubleConsumer", "java.util.Spliterator" })]
	internal class _4Splitr : MapWithIndexSpliterator, DoubleConsumer, Spliterator
	{
		internal double holder;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DoubleFunctionWithIndex val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Spliterator$OfDouble;J)V")]
		[LineNumberTable(new byte[] { 162, 74, 103, 106 })]
		internal _4Splitr(Spliterator.OfDouble P_0, long P_1, DoubleFunctionWithIndex P_2)
		{
			val_0024function = P_2;
			base._002Ector(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(720)]
		internal virtual _4Splitr createSplit(Spliterator.OfDouble P_0, long P_1)
		{
			_4Splitr result = new _4Splitr(P_0, P_1, val_0024function);
			_ = null;
			return result;
		}

		public virtual void accept(double P_0)
		{
			holder = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TR;>;)Z")]
		[LineNumberTable(new byte[] { 162, 85, 115, 127, 12, 130 })]
		public override bool tryAdvance(Consumer P_0)
		{
			if (((Spliterator.OfDouble)fromSpliterator).tryAdvance(this))
			{
				DoubleFunctionWithIndex doubleFunctionWithIndex = val_0024function;
				double d = holder;
				long num = index;
				index = num + 1;
				P_0.accept(doubleFunctionWithIndex.apply(d, num));
				return true;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(696)]
		internal override MapWithIndexSpliterator createSplit(Spliterator P_0, long P_1)
		{
			_4Splitr result = createSplit((Spliterator.OfDouble)P_0, P_1);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual DoubleConsumer andThen(DoubleConsumer P_0)
		{
			return DoubleConsumer._003Cdefault_003EandThen(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override void forEachRemaining(Consumer P_0)
		{
			Spliterator._003Cdefault_003EforEachRemaining(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override long getExactSizeIfKnown()
		{
			return Spliterator._003Cdefault_003EgetExactSizeIfKnown(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override bool hasCharacteristics(int P_0)
		{
			return Spliterator._003Cdefault_003EhasCharacteristics(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override Comparator getComparator()
		{
			return Spliterator._003Cdefault_003EgetComparator(this);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/util/Spliterators$AbstractSpliterator<TR;>;")]
	[EnclosingMethod(null, "mapWithIndex", "(Ljava.util.stream.DoubleStream;Lcom.google.common.collect.Streams$DoubleFunctionWithIndex;)Ljava.util.stream.Stream;")]
	internal class _5 : Spliterators.AbstractSpliterator
	{
		internal long index;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal PrimitiveIterator.OfDouble val_0024fromIterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DoubleFunctionWithIndex val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 55, 121 })]
		internal _5(long P_0, int P_1, PrimitiveIterator.OfDouble P_2, DoubleFunctionWithIndex P_3)
		{
			val_0024fromIterator = P_2;
			val_0024function = P_3;
			base._002Ector(P_0, P_1);
			index = 0L;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TR;>;)Z")]
		[LineNumberTable(new byte[] { 162, 60, 109, 127, 17, 130 })]
		public override bool tryAdvance(Consumer P_0)
		{
			if (val_0024fromIterator.hasNext())
			{
				DoubleFunctionWithIndex doubleFunctionWithIndex = val_0024function;
				double d = val_0024fromIterator.nextDouble();
				long num = index;
				index = num + 1;
				P_0.accept(doubleFunctionWithIndex.apply(d, num));
				return true;
			}
			return false;
		}
	}

	[Signature("<R:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 13, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)13,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public interface DoubleFunctionWithIndex
	{
		[Signature("(DJ)TR;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		virtual object apply(double d, long l);
	}

	[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 14, 0, 0,
		17, 1, 0, 0, 0, 14, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)14,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public interface FunctionWithIndex
	{
		[Signature("(TT;J)TR;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		virtual object apply([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object obj, long l);
	}

	[Signature("<R:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 13, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)13,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public interface IntFunctionWithIndex
	{
		[Signature("(IJ)TR;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		virtual object apply(int i, long l);
	}

	[Signature("<R:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 13, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)13,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public interface LongFunctionWithIndex
	{
		[Signature("(JJ)TR;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		virtual object apply(long l1, long l2);
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<F::Ljava/util/Spliterator<*>;R:Ljava/lang/Object;S:Lcom/google/common/collect/Streams$MapWithIndexSpliterator<TF;TR;TS;>;>Ljava/lang/Object;Ljava/util/Spliterator<TR;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 1, 0, 0, 0, 54, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)54,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class MapWithIndexSpliterator : java.lang.Object, Spliterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TF;")]
		internal Spliterator fromSpliterator;

		internal long index;

		[Signature("(TF;J)TS;")]
		internal abstract MapWithIndexSpliterator createSplit(Spliterator P_0, long P_1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TS;")]
		[LineNumberTable(new byte[] { 162, 132, 108, 99, 162, 98, 110, 115 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual MapWithIndexSpliterator trySplit()
		{
			Spliterator spliterator = fromSpliterator.trySplit();
			if (spliterator == null)
			{
				return null;
			}
			Spliterator spliterator2 = spliterator;
			MapWithIndexSpliterator result = createSplit(spliterator2, index);
			index += spliterator2.getExactSizeIfKnown();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TF;J)V")]
		[LineNumberTable(new byte[] { 162, 122, 104, 103, 103 })]
		internal MapWithIndexSpliterator(Spliterator P_0, long P_1)
		{
			fromSpliterator = P_0;
			index = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(771)]
		public virtual long estimateSize()
		{
			long result = fromSpliterator.estimateSize();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(776)]
		public virtual int characteristics()
		{
			return fromSpliterator.characteristics() & 0x4050;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(740)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Spliterator trySplit()
		{
			MapWithIndexSpliterator result = this.trySplit();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract bool tryAdvance(Consumer P_0);

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Spliterator._003Cdefault_003EforEachRemaining(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual long getExactSizeIfKnown()
		{
			return Spliterator._003Cdefault_003EgetExactSizeIfKnown(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool hasCharacteristics(int P_0)
		{
			return Spliterator._003Cdefault_003EhasCharacteristics(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator getComparator()
		{
			return Spliterator._003Cdefault_003EgetComparator(this);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 31, 0, 0,
		17, 1, 0, 0, 0, 31, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)31,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class TemporaryPair : java.lang.Object
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TA;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object a;

		[Modifiers(Modifiers.Final)]
		[Signature("TB;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal object b;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TA;TB;)V")]
		[LineNumberTable(new byte[] { 161, 30, 104, 103, 103 })]
		internal TemporaryPair([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, [ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_1)
		{
			a = P_0;
			b = P_1;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : java.util.function.Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Spliterator result = lambda_0024concat_00240((Spliterator)P_0);
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
	private sealed class ___003C_003EAnon1 : Runnable
	{
		private readonly Stream[] arg_00241;

		internal ___003C_003EAnon1(Stream[] P_0)
		{
			arg_00241 = P_0;
		}

		public void run()
		{
			lambda_0024concat_00241(arg_00241);
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon2 : java.util.function.Function
	{
		internal ___003C_003EAnon2()
		{
		}

		public object apply(object P_0)
		{
			Spliterator.OfInt result = lambda_0024concat_00242((Spliterator.OfInt)P_0);
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
	private sealed class ___003C_003EAnon3 : Runnable
	{
		private readonly IntStream[] arg_00241;

		internal ___003C_003EAnon3(IntStream[] P_0)
		{
			arg_00241 = P_0;
		}

		public void run()
		{
			lambda_0024concat_00243(arg_00241);
			_ = null;
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
			Spliterator.OfLong result = lambda_0024concat_00244((Spliterator.OfLong)P_0);
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
	private sealed class ___003C_003EAnon5 : Runnable
	{
		private readonly LongStream[] arg_00241;

		internal ___003C_003EAnon5(LongStream[] P_0)
		{
			arg_00241 = P_0;
		}

		public void run()
		{
			lambda_0024concat_00245(arg_00241);
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon6 : java.util.function.Function
	{
		internal ___003C_003EAnon6()
		{
		}

		public object apply(object P_0)
		{
			Spliterator.OfDouble result = lambda_0024concat_00246((Spliterator.OfDouble)P_0);
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
	private sealed class ___003C_003EAnon7 : Runnable
	{
		private readonly DoubleStream[] arg_00241;

		internal ___003C_003EAnon7(DoubleStream[] P_0)
		{
			arg_00241 = P_0;
		}

		public void run()
		{
			lambda_0024concat_00247(arg_00241);
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon8 : Runnable
	{
		private readonly Stream arg_00241;

		internal ___003C_003EAnon8(Stream P_0)
		{
			arg_00241 = P_0;
		}

		public void run()
		{
			arg_00241.close();
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon9 : BiFunction
	{
		internal ___003C_003EAnon9()
		{
		}

		public object apply(object P_0, object P_1)
		{
			TemporaryPair result = new TemporaryPair(P_0, P_1);
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
	private sealed class ___003C_003EAnon10 : Consumer
	{
		private readonly BiConsumer arg_00241;

		internal ___003C_003EAnon10(BiConsumer P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			lambda_0024forEachPair_00248(arg_00241, (TemporaryPair)P_0);
			_ = null;
		}

		[SpecialName]
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon11 : Runnable
	{
		private readonly IntStream arg_00241;

		internal ___003C_003EAnon11(IntStream P_0)
		{
			arg_00241 = P_0;
		}

		public void run()
		{
			arg_00241.close();
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon12 : Runnable
	{
		private readonly LongStream arg_00241;

		internal ___003C_003EAnon12(LongStream P_0)
		{
			arg_00241 = P_0;
		}

		public void run()
		{
			arg_00241.close();
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon13 : Runnable
	{
		private readonly DoubleStream arg_00241;

		internal ___003C_003EAnon13(DoubleStream P_0)
		{
			arg_00241 = P_0;
		}

		public void run()
		{
			arg_00241.close();
			_ = null;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon14 : Consumer
	{
		private readonly _1OptionalState arg_00241;

		internal ___003C_003EAnon14(_1OptionalState P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0)
		{
			arg_00241.set(P_0);
			_ = null;
		}

		[SpecialName]
		public Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
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
			OptionalInt result = OptionalInt.of(((Integer)P_0).intValue());
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
		internal ___003C_003EAnon16()
		{
		}

		public object get()
		{
			OptionalInt result = OptionalInt.empty();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon17 : java.util.function.Function
	{
		internal ___003C_003EAnon17()
		{
		}

		public object apply(object P_0)
		{
			OptionalLong result = OptionalLong.of(((Long)P_0).longValue());
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
	private sealed class ___003C_003EAnon18 : java.util.function.Supplier
	{
		internal ___003C_003EAnon18()
		{
		}

		public object get()
		{
			OptionalLong result = OptionalLong.empty();
			_ = null;
			return result;
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
			OptionalDouble result = OptionalDouble.of(((java.lang.Double)P_0).doubleValue());
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
		internal ___003C_003EAnon20()
		{
		}

		public object get()
		{
			OptionalDouble result = OptionalDouble.empty();
			_ = null;
			return result;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;)Ljava/util/stream/Stream<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 176, 0, 0 })]
	[LineNumberTable(new byte[] { 17, 104, 109, 14 })]
	public static Stream stream(Iterable iterable)
	{
		Stream result = ((!(iterable is Collection)) ? StreamSupport.stream(iterable.spliterator(), parallel: false) : ((Collection)iterable).stream());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;R:Ljava/lang/Object;>(Ljava/util/stream/Stream<TA;>;Ljava/util/stream/Stream<TB;>;Ljava/util/function/BiFunction<-TA;-TB;TR;>;)Ljava/util/stream/Stream<TR;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 18, 0, 0, 0, 0, 176, 0, 0,
		18, 1, 0, 0, 0, 176, 0, 0, 18, 2,
		0, 0, 0, 176, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		160, 206, 103, 103, 103, 117, 103, 103, 97, 102,
		138, 104, 104, 129, 28, 231, 77, 124, 250, 50
	})]
	public static Stream zip(Stream streamA, Stream streamB, BiFunction function)
	{
		Preconditions.checkNotNull(streamA);
		Preconditions.checkNotNull(streamB);
		Preconditions.checkNotNull(function);
		int parallel = ((streamA.isParallel() || streamB.isParallel()) ? 1 : 0);
		Spliterator spliterator = streamA.spliterator();
		Spliterator spliterator2 = streamB.spliterator();
		int num = spliterator.characteristics() & spliterator2.characteristics() & 0x50;
		Iterator iterator = Spliterators.iterator(spliterator);
		Iterator iterator2 = Spliterators.iterator(spliterator2);
		Stream obj = StreamSupport.stream(new _1(java.lang.Math.min(spliterator.estimateSize(), spliterator2.estimateSize()), num, iterator, iterator2, function), (byte)parallel != 0);
		java.util.Objects.requireNonNull(streamA);
		Stream obj2 = (Stream)obj.onClose(new ___003C_003EAnon8(streamA));
		java.util.Objects.requireNonNull(streamB);
		return (Stream)obj2.onClose(new ___003C_003EAnon8(streamB));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/stream/Stream<TT;>;)Ljava/util/Optional<TT;>;")]
	[LineNumberTable(new byte[]
	{
		162, 241, 134, 102, 140, 107, 140, 106, 226, 69,
		173, 103, 109, 98, 106, 98, 130, 162, 120, 174,
		103, 141, 120, 107, 238, 69, 103, 103, 101
	})]
	public static java.util.Optional findLast(Stream stream)
	{
		_1OptionalState _1OptionalState = new _1OptionalState();
		ArrayDeque arrayDeque = new ArrayDeque();
		((Deque)arrayDeque).addLast((object)stream.spliterator());
		while (!((Collection)arrayDeque).isEmpty())
		{
			Spliterator spliterator = (Spliterator)((Deque)arrayDeque).removeLast();
			if (spliterator.getExactSizeIfKnown() == 0)
			{
				continue;
			}
			Spliterator spliterator2;
			if (spliterator.hasCharacteristics(16384))
			{
				while (true)
				{
					spliterator2 = spliterator.trySplit();
					if (spliterator2 == null || spliterator2.getExactSizeIfKnown() == 0)
					{
						break;
					}
					if (spliterator.getExactSizeIfKnown() == 0)
					{
						spliterator = spliterator2;
						break;
					}
				}
				Spliterator spliterator3 = spliterator;
				java.util.Objects.requireNonNull(_1OptionalState);
				spliterator3.forEachRemaining(new ___003C_003EAnon14(_1OptionalState));
				java.util.Optional result = java.util.Optional.of(_1OptionalState.get());
				_ = null;
				return result;
			}
			spliterator2 = spliterator.trySplit();
			if (spliterator2 == null || spliterator2.getExactSizeIfKnown() == 0)
			{
				Spliterator spliterator4 = spliterator;
				java.util.Objects.requireNonNull(_1OptionalState);
				spliterator4.forEachRemaining(new ___003C_003EAnon14(_1OptionalState));
				if (_1OptionalState.set)
				{
					java.util.Optional result2 = java.util.Optional.of(_1OptionalState.get());
					_ = null;
					return result2;
				}
			}
			else
			{
				((Deque)arrayDeque).addLast((object)spliterator2);
				((Deque)arrayDeque).addLast((object)spliterator);
			}
		}
		java.util.Optional result3 = java.util.Optional.empty();
		_ = null;
		return result3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("([Ljava/util/stream/BaseStream<**>;)V")]
	[LineNumberTable(new byte[] { 105, 143, 6, 198 })]
	private static void closeAll(BaseStream[] P_0)
	{
		int num = P_0.Length;
		for (int i = 0; i < num; i++)
		{
			BaseStream baseStream = P_0[i];
			baseStream.close();
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	private static Spliterator lambda_0024concat_00240(Spliterator P_0)
	{
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(192)]
	private static void lambda_0024concat_00241(Stream[] P_0)
	{
		closeAll(P_0);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	private static Spliterator.OfInt lambda_0024concat_00242(Spliterator.OfInt P_0)
	{
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(224)]
	private static void lambda_0024concat_00243(IntStream[] P_0)
	{
		closeAll(P_0);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	private static Spliterator.OfLong lambda_0024concat_00244(Spliterator.OfLong P_0)
	{
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(256)]
	private static void lambda_0024concat_00245(LongStream[] P_0)
	{
		closeAll(P_0);
	}

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	private static Spliterator.OfDouble lambda_0024concat_00246(Spliterator.OfDouble P_0)
	{
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(288)]
	private static void lambda_0024concat_00247(DoubleStream[] P_0)
	{
		closeAll(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(385)]
	private static void lambda_0024forEachPair_00248(BiConsumer P_0, TemporaryPair P_1)
	{
		P_0.accept(P_1.a, P_1.b);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<TT;>;)Ljava/util/stream/Stream<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 176, 0, 0 })]
	[LineNumberTable(81)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static Stream stream(Collection collection)
	{
		Stream result = collection.stream();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;)Ljava/util/stream/Stream<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 176, 0, 0 })]
	[LineNumberTable(90)]
	public static Stream stream(Iterator iterator)
	{
		Stream result = StreamSupport.stream(Spliterators.spliteratorUnknownSize(iterator, 0), parallel: false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/base/Optional<TT;>;)Ljava/util/stream/Stream<TT;>;")]
	[LineNumberTable(99)]
	public static Stream stream(com.google.common.@base.Optional optional)
	{
		Stream result = ((!optional.isPresent()) ? Stream.empty() : Stream.of(optional.get()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Optional<TT;>;)Ljava/util/stream/Stream<TT;>;")]
	[LineNumberTable(112)]
	public static Stream stream(java.util.Optional optional)
	{
		Stream result = ((!optional.isPresent()) ? Stream.empty() : Stream.of(optional.get()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(125)]
	public static IntStream stream(OptionalInt optional)
	{
		IntStream result = ((!optional.isPresent()) ? IntStream.empty() : IntStream.of(optional.getAsInt()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(138)]
	public static LongStream stream(OptionalLong optional)
	{
		LongStream result = ((!optional.isPresent()) ? LongStream.empty() : LongStream.of(optional.getAsLong()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(151)]
	public static DoubleStream stream(OptionalDouble optional)
	{
		DoubleStream result = ((!optional.isPresent()) ? DoubleStream.empty() : DoubleStream.of(optional.getAsDouble()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([Ljava/util/stream/Stream<+TT;>;)Ljava/util/stream/Stream<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 176, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		123, 98, 102, 99, 136, 120, 106, 105, 105, 106,
		238, 59, 232, 71, 129, 54, 38, 240, 71, 234,
		57
	})]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static Stream concat(params Stream[] streams)
	{
		int num = 0;
		int num2 = 336;
		long num3 = 0L;
		ImmutableList.Builder builder = new ImmutableList.Builder(streams.Length);
		int num4 = streams.Length;
		for (int i = 0; i < num4; i++)
		{
			Stream stream = streams[i];
			num |= (stream.isParallel() ? 1 : 0);
			Spliterator spliterator = stream.spliterator();
			builder.add(spliterator);
			num2 &= spliterator.characteristics();
			num3 = LongMath.saturatedAdd(num3, spliterator.estimateSize());
		}
		return (Stream)StreamSupport.stream(CollectSpliterators.flatMap(builder.build().spliterator(), new ___003C_003EAnon0(), num2, num3), (byte)num != 0).onClose(new ___003C_003EAnon1(streams));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 91, 98, 102, 99, 136, 120, 106, 105, 105,
		106, 238, 59, 232, 71, 129, 54, 38, 240, 71,
		234, 57
	})]
	public static IntStream concat(params IntStream[] streams)
	{
		int num = 0;
		int num2 = 336;
		long num3 = 0L;
		ImmutableList.Builder builder = new ImmutableList.Builder(streams.Length);
		int num4 = streams.Length;
		for (int i = 0; i < num4; i++)
		{
			IntStream intStream = streams[i];
			num |= (intStream.isParallel() ? 1 : 0);
			Spliterator.OfInt ofInt = intStream.spliterator();
			builder.add(ofInt);
			num2 &= ofInt.characteristics();
			num3 = LongMath.saturatedAdd(num3, ofInt.estimateSize());
		}
		return (IntStream)StreamSupport.intStream(CollectSpliterators.flatMapToInt(builder.build().spliterator(), new ___003C_003EAnon2(), num2, num3), (byte)num != 0).onClose(new ___003C_003EAnon3(streams));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 123, 98, 102, 99, 136, 120, 106, 105, 105,
		106, 238, 59, 232, 71, 129, 54, 38, 240, 71,
		234, 57
	})]
	public static LongStream concat(params LongStream[] streams)
	{
		int num = 0;
		int num2 = 336;
		long num3 = 0L;
		ImmutableList.Builder builder = new ImmutableList.Builder(streams.Length);
		int num4 = streams.Length;
		for (int i = 0; i < num4; i++)
		{
			LongStream longStream = streams[i];
			num |= (longStream.isParallel() ? 1 : 0);
			Spliterator.OfLong ofLong = longStream.spliterator();
			builder.add(ofLong);
			num2 &= ofLong.characteristics();
			num3 = LongMath.saturatedAdd(num3, ofLong.estimateSize());
		}
		return (LongStream)StreamSupport.longStream(CollectSpliterators.flatMapToLong(builder.build().spliterator(), new ___003C_003EAnon4(), num2, num3), (byte)num != 0).onClose(new ___003C_003EAnon5(streams));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 155, 98, 102, 99, 136, 120, 106, 105, 105,
		106, 238, 59, 232, 71, 129, 54, 38, 240, 71,
		234, 57
	})]
	public static DoubleStream concat(params DoubleStream[] streams)
	{
		int num = 0;
		int num2 = 336;
		long num3 = 0L;
		ImmutableList.Builder builder = new ImmutableList.Builder(streams.Length);
		int num4 = streams.Length;
		for (int i = 0; i < num4; i++)
		{
			DoubleStream doubleStream = streams[i];
			num |= (doubleStream.isParallel() ? 1 : 0);
			Spliterator.OfDouble ofDouble = doubleStream.spliterator();
			builder.add(ofDouble);
			num2 &= ofDouble.characteristics();
			num3 = LongMath.saturatedAdd(num3, ofDouble.estimateSize());
		}
		return (DoubleStream)StreamSupport.doubleStream(CollectSpliterators.flatMapToDouble(builder.build().spliterator(), new ___003C_003EAnon6(), num2, num3), (byte)num != 0).onClose(new ___003C_003EAnon7(streams));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<A:Ljava/lang/Object;B:Ljava/lang/Object;>(Ljava/util/stream/Stream<TA;>;Ljava/util/stream/Stream<TB;>;Ljava/util/function/BiConsumer<-TA;-TB;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 176, 0, 0,
		18, 1, 0, 0, 0, 176, 0, 0
	})]
	[LineNumberTable(new byte[] { 161, 12, 135, 112, 159, 4, 103, 103, 112, 180 })]
	public static void forEachPair(Stream streamA, Stream streamB, BiConsumer consumer)
	{
		Preconditions.checkNotNull(consumer);
		if (streamA.isParallel() || streamB.isParallel())
		{
			zip(streamA, streamB, new ___003C_003EAnon9()).forEach(new ___003C_003EAnon10(consumer));
			return;
		}
		Iterator iterator = streamA.iterator();
		Iterator iterator2 = streamB.iterator();
		while (iterator.hasNext() && iterator2.hasNext())
		{
			consumer.accept(iterator.next(), iterator2.next());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;>(Ljava/util/stream/Stream<TT;>;Lcom/google/common/collect/Streams$FunctionWithIndex<-TT;+TR;>;)Ljava/util/stream/Stream<TR;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 176, 0, 0,
		18, 1, 0, 0, 0, 176, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		161, 60, 103, 103, 103, 135, 109, 103, 129, 102,
		240, 61, 231, 80, 250, 48, 225, 113
	})]
	public static Stream mapWithIndex(Stream stream, FunctionWithIndex function)
	{
		Preconditions.checkNotNull(stream);
		Preconditions.checkNotNull(function);
		int parallel = (stream.isParallel() ? 1 : 0);
		Spliterator spliterator = stream.spliterator();
		if (!spliterator.hasCharacteristics(16384))
		{
			Iterator iterator = Spliterators.iterator(spliterator);
			Stream obj = StreamSupport.stream(new _2(spliterator.estimateSize(), spliterator.characteristics() & 0x50, iterator, function), (byte)parallel != 0);
			java.util.Objects.requireNonNull(stream);
			return (Stream)obj.onClose(new ___003C_003EAnon8(stream));
		}
		Stream obj2 = StreamSupport.stream(new _1Splitr(spliterator, 0L, function), (byte)parallel != 0);
		java.util.Objects.requireNonNull(stream);
		return (Stream)obj2.onClose(new ___003C_003EAnon8(stream));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;>(Ljava/util/stream/IntStream;Lcom/google/common/collect/Streams$IntFunctionWithIndex<TR;>;)Ljava/util/stream/Stream<TR;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 176, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		161, 143, 103, 103, 103, 135, 109, 103, 129, 102,
		240, 61, 231, 80, 250, 48, 225, 109
	})]
	public static Stream mapWithIndex(IntStream stream, IntFunctionWithIndex function)
	{
		Preconditions.checkNotNull(stream);
		Preconditions.checkNotNull(function);
		int parallel = (stream.isParallel() ? 1 : 0);
		Spliterator.OfInt ofInt = stream.spliterator();
		if (!ofInt.hasCharacteristics(16384))
		{
			PrimitiveIterator.OfInt ofInt2 = Spliterators.iterator(ofInt);
			Stream obj = StreamSupport.stream(new _3(ofInt.estimateSize(), ofInt.characteristics() & 0x50, ofInt2, function), (byte)parallel != 0);
			java.util.Objects.requireNonNull(stream);
			return (Stream)obj.onClose(new ___003C_003EAnon11(stream));
		}
		Stream obj2 = StreamSupport.stream(new _2Splitr(ofInt, 0L, function), (byte)parallel != 0);
		java.util.Objects.requireNonNull(stream);
		return (Stream)obj2.onClose(new ___003C_003EAnon11(stream));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;>(Ljava/util/stream/LongStream;Lcom/google/common/collect/Streams$LongFunctionWithIndex<TR;>;)Ljava/util/stream/Stream<TR;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 176, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		161, 222, 103, 103, 103, 135, 109, 103, 129, 102,
		240, 61, 231, 80, 250, 48, 225, 109
	})]
	public static Stream mapWithIndex(LongStream stream, LongFunctionWithIndex function)
	{
		Preconditions.checkNotNull(stream);
		Preconditions.checkNotNull(function);
		int parallel = (stream.isParallel() ? 1 : 0);
		Spliterator.OfLong ofLong = stream.spliterator();
		if (!ofLong.hasCharacteristics(16384))
		{
			PrimitiveIterator.OfLong ofLong2 = Spliterators.iterator(ofLong);
			Stream obj = StreamSupport.stream(new _4(ofLong.estimateSize(), ofLong.characteristics() & 0x50, ofLong2, function), (byte)parallel != 0);
			java.util.Objects.requireNonNull(stream);
			return (Stream)obj.onClose(new ___003C_003EAnon12(stream));
		}
		Stream obj2 = StreamSupport.stream(new _3Splitr(ofLong, 0L, function), (byte)parallel != 0);
		java.util.Objects.requireNonNull(stream);
		return (Stream)obj2.onClose(new ___003C_003EAnon12(stream));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;>(Ljava/util/stream/DoubleStream;Lcom/google/common/collect/Streams$DoubleFunctionWithIndex<TR;>;)Ljava/util/stream/Stream<TR;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 176, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		162, 45, 103, 103, 103, 135, 109, 103, 129, 102,
		240, 61, 231, 80, 250, 48, 225, 109
	})]
	public static Stream mapWithIndex(DoubleStream stream, DoubleFunctionWithIndex function)
	{
		Preconditions.checkNotNull(stream);
		Preconditions.checkNotNull(function);
		int parallel = (stream.isParallel() ? 1 : 0);
		Spliterator.OfDouble ofDouble = stream.spliterator();
		if (!ofDouble.hasCharacteristics(16384))
		{
			PrimitiveIterator.OfDouble ofDouble2 = Spliterators.iterator(ofDouble);
			Stream obj = StreamSupport.stream(new _5(ofDouble.estimateSize(), ofDouble.characteristics() & 0x50, ofDouble2, function), (byte)parallel != 0);
			java.util.Objects.requireNonNull(stream);
			return (Stream)obj.onClose(new ___003C_003EAnon13(stream));
		}
		Stream obj2 = StreamSupport.stream(new _4Splitr(ofDouble, 0L, function), (byte)parallel != 0);
		java.util.Objects.requireNonNull(stream);
		return (Stream)obj2.onClose(new ___003C_003EAnon13(stream));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 46, 108 })]
	public static OptionalInt findLast(IntStream stream)
	{
		java.util.Optional optional = findLast(stream.boxed());
		return (OptionalInt)optional.map(new ___003C_003EAnon15()).orElseGet(new ___003C_003EAnon16());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 64, 108 })]
	public static OptionalLong findLast(LongStream stream)
	{
		java.util.Optional optional = findLast(stream.boxed());
		return (OptionalLong)optional.map(new ___003C_003EAnon17()).orElseGet(new ___003C_003EAnon18());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 82, 108 })]
	public static OptionalDouble findLast(DoubleStream stream)
	{
		java.util.Optional optional = findLast(stream.boxed());
		return (OptionalDouble)optional.map(new ___003C_003EAnon19()).orElseGet(new ___003C_003EAnon20());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(968)]
	private Streams()
	{
	}
}
