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
	(byte)57,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class CollectSpliterators : Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Ljava/util/Spliterator<TOutElementT;>;")]
	[EnclosingMethod(null, "map", "(Ljava.util.Spliterator;Ljava.util.function.Function;)Ljava.util.Spliterator;")]
	internal class _1 : Object, Spliterator
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly Consumer arg_00241;

			private readonly java.util.function.Function arg_00242;

			internal ___003C_003EAnon0(Consumer P_0, java.util.function.Function P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				lambda_0024tryAdvance_00240(arg_00241, arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon1 : Consumer
		{
			private readonly Consumer arg_00241;

			private readonly java.util.function.Function arg_00242;

			internal ___003C_003EAnon1(Consumer P_0, java.util.function.Function P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				lambda_0024forEachRemaining_00241(arg_00241, arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Spliterator val_0024fromSpliterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal java.util.function.Function val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(123)]
		private static void lambda_0024tryAdvance_00240(Consumer P_0, java.util.function.Function P_1, object P_2)
		{
			P_0.accept(P_1.apply(P_2));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(128)]
		private static void lambda_0024forEachRemaining_00241(Consumer P_0, java.util.function.Function P_1, object P_2)
		{
			P_0.accept(P_1.apply(P_2));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(118)]
		internal _1(Spliterator P_0, java.util.function.Function P_1)
		{
			val_0024fromSpliterator = P_0;
			val_0024function = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TOutElementT;>;)Z")]
		[LineNumberTable(122)]
		public virtual bool tryAdvance(Consumer P_0)
		{
			bool result = val_0024fromSpliterator.tryAdvance(new ___003C_003EAnon0(P_0, val_0024function));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TOutElementT;>;)V")]
		[LineNumberTable(new byte[] { 78, 126 })]
		public virtual void forEachRemaining(Consumer P_0)
		{
			val_0024fromSpliterator.forEachRemaining(new ___003C_003EAnon1(P_0, val_0024function));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TOutElementT;>;")]
		[LineNumberTable(new byte[] { 84, 108 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Spliterator trySplit()
		{
			Spliterator spliterator = val_0024fromSpliterator.trySplit();
			return (spliterator == null) ? null : map(spliterator, val_0024function);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(140)]
		public virtual long estimateSize()
		{
			long result = val_0024fromSpliterator.estimateSize();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(145)]
		public virtual int characteristics()
		{
			return val_0024fromSpliterator.characteristics() & -262;
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

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Ljava/util/Spliterator<TT;>;Ljava/util/function/Consumer<TT;>;")]
	[EnclosingMethod(null, "filter", "(Ljava.util.Spliterator;Ljava.util.function.Predicate;)Ljava.util.Spliterator;")]
	[Implements(new string[] { "java.util.Spliterator", "java.util.function.Consumer" })]
	internal class _1Splitr : Object, Spliterator, Consumer
	{
		[Signature("TT;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object holder;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Spliterator val_0024fromSpliterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal java.util.function.Predicate val_0024predicate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(new byte[] { 106, 118 })]
		internal _1Splitr(Spliterator P_0, java.util.function.Predicate P_1)
		{
			val_0024fromSpliterator = P_0;
			val_0024predicate = P_1;
			base._002Ector();
			holder = null;
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
		[Signature("(Ljava/util/function/Consumer<-TT;>;)Z")]
		[LineNumberTable(new byte[]
		{
			116, 174, 108, 110, 103, 168, 103, 37, 231, 61,
			162, 103, 132
		})]
		public virtual bool tryAdvance(Consumer P_0)
		{
			while (val_0024fromSpliterator.tryAdvance(this))
			{
				int result;
				try
				{
					object t = NullnessCasts.uncheckedCastNullableTToT(holder);
					if (val_0024predicate.test(t))
					{
						P_0.accept(t);
						result = 1;
						goto IL_0043;
					}
				}
				catch
				{
					//try-fault
					holder = null;
					throw;
				}
				holder = null;
				continue;
				IL_0043:
				holder = null;
				return (byte)result != 0;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TT;>;")]
		[LineNumberTable(new byte[] { 160, 70, 108 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Spliterator trySplit()
		{
			Spliterator spliterator = val_0024fromSpliterator.trySplit();
			Spliterator result = ((spliterator != null) ? filter(spliterator, val_0024predicate) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(190)]
		public virtual long estimateSize()
		{
			return val_0024fromSpliterator.estimateSize() / 2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TT;>;")]
		[LineNumberTable(196)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator getComparator()
		{
			Comparator comparator = val_0024fromSpliterator.getComparator();
			_ = null;
			return comparator;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(201)]
		public virtual int characteristics()
		{
			return val_0024fromSpliterator.characteristics() & 0x115;
		}

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
		public virtual Consumer andThen(Consumer P_0)
		{
			return Consumer._003Cdefault_003EandThen(this, P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Ljava/util/Spliterator<TT;>;")]
	[EnclosingMethod(null, "indexed", "(IILjava.util.function.IntFunction;Ljava.util.Comparator;)Ljava.util.Spliterator;")]
	internal class _1WithCharacteristics : Object, Spliterator
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : IntConsumer
		{
			private readonly Consumer arg_00241;

			private readonly IntFunction arg_00242;

			internal ___003C_003EAnon0(Consumer P_0, IntFunction P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(int P_0)
			{
				lambda_0024tryAdvance_00240(arg_00241, arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public IntConsumer andThen(IntConsumer P_0)
			{
				return IntConsumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon1 : IntConsumer
		{
			private readonly Consumer arg_00241;

			private readonly IntFunction arg_00242;

			internal ___003C_003EAnon1(Consumer P_0, IntFunction P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(int P_0)
			{
				lambda_0024forEachRemaining_00241(arg_00241, arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public IntConsumer andThen(IntConsumer P_0)
			{
				return IntConsumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private Spliterator.OfInt @delegate;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal IntFunction val_0024function;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024extraCharacteristics;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Comparator val_0024comparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Spliterator$OfInt;)V")]
		[LineNumberTable(new byte[] { 11, 126, 103 })]
		internal _1WithCharacteristics(Spliterator.OfInt P_0, IntFunction P_1, int P_2, Comparator P_3)
		{
			val_0024function = P_1;
			val_0024extraCharacteristics = P_2;
			val_0024comparator = P_3;
			base._002Ector();
			@delegate = P_0;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual bool hasCharacteristics(int P_0)
		{
			return Spliterator._003Cdefault_003EhasCharacteristics(this, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(67)]
		private static void lambda_0024tryAdvance_00240(Consumer P_0, IntFunction P_1, int P_2)
		{
			P_0.accept(P_1.apply(P_2));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(72)]
		private static void lambda_0024forEachRemaining_00241(Consumer P_0, IntFunction P_1, int P_2)
		{
			P_0.accept(P_1.apply(P_2));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TT;>;)Z")]
		[LineNumberTable(67)]
		public virtual bool tryAdvance(Consumer P_0)
		{
			bool result = @delegate.tryAdvance(new ___003C_003EAnon0(P_0, val_0024function));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TT;>;)V")]
		[LineNumberTable(new byte[] { 22, 126 })]
		public virtual void forEachRemaining(Consumer P_0)
		{
			@delegate.forEachRemaining(new ___003C_003EAnon1(P_0, val_0024function));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TT;>;")]
		[LineNumberTable(new byte[] { 28, 108 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Spliterator trySplit()
		{
			Spliterator.OfInt ofInt = @delegate.trySplit();
			_1WithCharacteristics result = ((ofInt != null) ? new _1WithCharacteristics(ofInt, val_0024function, val_0024extraCharacteristics, val_0024comparator) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(84)]
		public virtual long estimateSize()
		{
			long result = @delegate.estimateSize();
			_ = null;
			return result;
		}

		public virtual int characteristics()
		{
			return 0x4050 | val_0024extraCharacteristics;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TT;>;")]
		[LineNumberTable(new byte[] { 48, 105, 135 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator getComparator()
		{
			if (hasCharacteristics(4))
			{
				return val_0024comparator;
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalStateException();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual long getExactSizeIfKnown()
		{
			return Spliterator._003Cdefault_003EgetExactSizeIfKnown(this);
		}
	}

	[Signature("<InElementT:Ljava/lang/Object;OutElementT:Ljava/lang/Object;OutSpliteratorT::Ljava/util/Spliterator<TOutElementT;>;>Ljava/lang/Object;Ljava/util/Spliterator<TOutElementT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 93, 0, 0,
		17, 1, 0, 0, 0, 93, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)93,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class FlatMapSpliterator : Object, Spliterator
	{
		[Signature("<InElementT:Ljava/lang/Object;OutSpliteratorT::Ljava/util/Spliterator<*>;>Ljava/lang/Object;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 15, 0, 0 })]
		[ConstantPool(new object[]
		{
			(byte)15,
			"Lorg/checkerframework/checker/nullness/qual/Nullable;"
		})]
		[FunctionalInterface(new object[]
		{
			(byte)64,
			"Ljava/lang/FunctionalInterface;"
		})]
		internal interface Factory
		{
			[Signature("(TOutSpliteratorT;Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;TOutSpliteratorT;>;IJ)TOutSpliteratorT;")]
			virtual Spliterator newFlatMapSpliterator([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] Spliterator P_0, Spliterator P_1, java.util.function.Function P_2, int P_3, long P_4);
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly FlatMapSpliterator arg_00241;

			internal ___003C_003EAnon0(FlatMapSpliterator P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024tryAdvance_00240(P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon1 : Consumer
		{
			private readonly FlatMapSpliterator arg_00241;

			private readonly Consumer arg_00242;

			internal ___003C_003EAnon1(FlatMapSpliterator P_0, Consumer P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024forEachRemaining_00241(arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[Signature("TOutSpliteratorT;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Spliterator prefix;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Spliterator<TInElementT;>;")]
		internal Spliterator from;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/function/Function<-TInElementT;TOutSpliteratorT;>;")]
		internal java.util.function.Function function;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/CollectSpliterators$FlatMapSpliterator$Factory<TInElementT;TOutSpliteratorT;>;")]
		internal Factory factory;

		internal int characteristics;

		internal long estimatedSize;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 42, 104, 156 })]
		public long estimateSize()
		{
			if (prefix != null)
			{
				estimatedSize = Math.max(estimatedSize, prefix.estimateSize());
			}
			long result = Math.max(estimatedSize, 0L);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(362)]
		private void lambda_0024tryAdvance_00240(object P_0)
		{
			prefix = (Spliterator)function.apply(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(new byte[] { 161, 6, 114, 99, 137 })]
		private void lambda_0024forEachRemaining_00241(Consumer P_0, object P_1)
		{
			((Spliterator)function.apply(P_1))?.forEachRemaining(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TOutSpliteratorT;Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;TOutSpliteratorT;>;Lcom/google/common/collect/CollectSpliterators$FlatMapSpliterator$Factory<TInElementT;TOutSpliteratorT;>;IJ)V")]
		[LineNumberTable(new byte[] { 160, 221, 104, 103, 103, 103, 104, 104, 104 })]
		internal FlatMapSpliterator([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Spliterator P_0, Spliterator P_1, java.util.function.Function P_2, Factory P_3, int P_4, long P_5)
		{
			prefix = P_0;
			from = P_1;
			function = P_2;
			factory = P_3;
			this.characteristics = P_4;
			estimatedSize = P_5;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TOutElementT;>;)Z")]
		[LineNumberTable(new byte[] { 160, 240, 118, 113, 143, 130, 135, 120 })]
		public bool tryAdvance(Consumer P_0)
		{
			do
			{
				if (prefix != null && prefix.tryAdvance(P_0))
				{
					if (estimatedSize != long.MaxValue)
					{
						estimatedSize--;
					}
					return true;
				}
				prefix = null;
			}
			while (from.tryAdvance(new ___003C_003EAnon0(this)));
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/function/Consumer<-TOutElementT;>;)V")]
		[LineNumberTable(new byte[] { 161, 0, 104, 108, 135, 247, 71, 104 })]
		public void forEachRemaining(Consumer P_0)
		{
			if (prefix != null)
			{
				prefix.forEachRemaining(P_0);
				prefix = null;
			}
			from.forEachRemaining(new ___003C_003EAnon1(this, P_0));
			estimatedSize = 0L;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TOutSpliteratorT;")]
		[LineNumberTable(new byte[]
		{
			161, 17, 108, 102, 106, 103, 108, 101, 110, 135,
			117, 134, 103, 98, 104, 104, 103, 131
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public Spliterator trySplit()
		{
			Spliterator spliterator = from.trySplit();
			if (spliterator != null)
			{
				int num = this.characteristics & -65;
				long num2 = estimateSize();
				if (num2 < long.MaxValue)
				{
					num2 /= 2;
					estimatedSize -= num2;
					this.characteristics = num;
				}
				Spliterator result = factory.newFlatMapSpliterator(prefix, spliterator, function, num, num2);
				prefix = null;
				return result;
			}
			if (prefix != null)
			{
				Spliterator result2 = prefix;
				prefix = null;
				return result2;
			}
			return null;
		}

		public int characteristics()
		{
			return this.characteristics;
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

	[Signature("<InElementT:Ljava/lang/Object;>Lcom/google/common/collect/CollectSpliterators$FlatMapSpliteratorOfPrimitive<TInElementT;Ljava/lang/Double;Ljava/util/function/DoubleConsumer;Ljava/util/Spliterator$OfDouble;>;Ljava/util/Spliterator$OfDouble;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 49, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)49,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Spliterator$OfDouble" })]
	internal sealed class FlatMapSpliteratorOfDouble : FlatMapSpliteratorOfPrimitive, Spliterator.OfDouble, Spliterator.OfPrimitive, Spliterator
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Factory
		{
			internal ___003C_003EAnon0()
			{
			}

			public Spliterator newFlatMapSpliterator(Spliterator P_0, Spliterator P_1, java.util.function.Function P_2, int P_3, long P_4)
			{
				Spliterator.OfDouble result = new FlatMapSpliteratorOfDouble((Spliterator.OfDouble)P_0, P_1, P_2, P_3, P_4);
				_ = null;
				return result;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Spliterator$OfDouble;Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;Ljava/util/Spliterator$OfDouble;>;IJ)V")]
		[LineNumberTable(new byte[] { 161, 179, 153 })]
		internal FlatMapSpliteratorOfDouble([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Spliterator.OfDouble P_0, Spliterator P_1, java.util.function.Function P_2, int P_3, long P_4)
			: base(P_0, P_1, P_2, new ___003C_003EAnon0(), P_3, P_4)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(539)]
		public virtual void forEachRemaining(DoubleConsumer P_0)
		{
			forEachRemaining((object)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(539)]
		public virtual bool tryAdvance(DoubleConsumer P_0)
		{
			bool result = tryAdvance((object)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(539)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Spliterator.OfDouble trySplit()
		{
			return (Spliterator.OfDouble)((FlatMapSpliterator)this).trySplit();
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

		Spliterator.OfPrimitive Spliterator.OfDouble.Spliterator_0024OfDouble_003A_003AtrySplit()
		{
			return ((FlatMapSpliteratorOfPrimitive)this).trySplit();
		}

		Spliterator Spliterator.OfDouble.Spliterator_0024OfDouble_003A_003AtrySplit()
		{
			return ((FlatMapSpliterator)this).trySplit();
		}

		Spliterator Spliterator.OfPrimitive.Spliterator_0024OfPrimitive_003A_003AtrySplit()
		{
			return ((FlatMapSpliterator)this).trySplit();
		}
	}

	[Signature("<InElementT:Ljava/lang/Object;>Lcom/google/common/collect/CollectSpliterators$FlatMapSpliteratorOfPrimitive<TInElementT;Ljava/lang/Integer;Ljava/util/function/IntConsumer;Ljava/util/Spliterator$OfInt;>;Ljava/util/Spliterator$OfInt;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 49, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)49,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Spliterator$OfInt" })]
	internal sealed class FlatMapSpliteratorOfInt : FlatMapSpliteratorOfPrimitive, Spliterator.OfInt, Spliterator.OfPrimitive, Spliterator
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Factory
		{
			internal ___003C_003EAnon0()
			{
			}

			public Spliterator newFlatMapSpliterator(Spliterator P_0, Spliterator P_1, java.util.function.Function P_2, int P_3, long P_4)
			{
				Spliterator.OfInt result = new FlatMapSpliteratorOfInt((Spliterator.OfInt)P_0, P_1, P_2, P_3, P_4);
				_ = null;
				return result;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Spliterator$OfInt;Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;Ljava/util/Spliterator$OfInt;>;IJ)V")]
		[LineNumberTable(new byte[] { 161, 150, 121 })]
		internal FlatMapSpliteratorOfInt([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Spliterator.OfInt P_0, Spliterator P_1, java.util.function.Function P_2, int P_3, long P_4)
			: base(P_0, P_1, P_2, new ___003C_003EAnon0(), P_3, P_4)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(511)]
		public virtual void forEachRemaining(IntConsumer P_0)
		{
			forEachRemaining((object)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(511)]
		public virtual bool tryAdvance(IntConsumer P_0)
		{
			bool result = tryAdvance((object)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(511)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Spliterator.OfInt trySplit()
		{
			return (Spliterator.OfInt)((FlatMapSpliterator)this).trySplit();
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

		Spliterator.OfPrimitive Spliterator.OfInt.Spliterator_0024OfInt_003A_003AtrySplit()
		{
			return ((FlatMapSpliteratorOfPrimitive)this).trySplit();
		}

		Spliterator Spliterator.OfInt.Spliterator_0024OfInt_003A_003AtrySplit()
		{
			return ((FlatMapSpliterator)this).trySplit();
		}

		Spliterator Spliterator.OfPrimitive.Spliterator_0024OfPrimitive_003A_003AtrySplit()
		{
			return ((FlatMapSpliterator)this).trySplit();
		}
	}

	[Signature("<InElementT:Ljava/lang/Object;>Lcom/google/common/collect/CollectSpliterators$FlatMapSpliteratorOfPrimitive<TInElementT;Ljava/lang/Long;Ljava/util/function/LongConsumer;Ljava/util/Spliterator$OfLong;>;Ljava/util/Spliterator$OfLong;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 49, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)49,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Spliterator$OfLong" })]
	internal sealed class FlatMapSpliteratorOfLong : FlatMapSpliteratorOfPrimitive, Spliterator.OfLong, Spliterator.OfPrimitive, Spliterator
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Factory
		{
			internal ___003C_003EAnon0()
			{
			}

			public Spliterator newFlatMapSpliterator(Spliterator P_0, Spliterator P_1, java.util.function.Function P_2, int P_3, long P_4)
			{
				Spliterator.OfLong result = new FlatMapSpliteratorOfLong((Spliterator.OfLong)P_0, P_1, P_2, P_3, P_4);
				_ = null;
				return result;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Spliterator$OfLong;Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;Ljava/util/Spliterator$OfLong;>;IJ)V")]
		[LineNumberTable(new byte[] { 161, 164, 121 })]
		internal FlatMapSpliteratorOfLong([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Spliterator.OfLong P_0, Spliterator P_1, java.util.function.Function P_2, int P_3, long P_4)
			: base(P_0, P_1, P_2, new ___003C_003EAnon0(), P_3, P_4)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(525)]
		public virtual void forEachRemaining(LongConsumer P_0)
		{
			forEachRemaining((object)P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(525)]
		public virtual bool tryAdvance(LongConsumer P_0)
		{
			bool result = tryAdvance((object)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(525)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Spliterator.OfLong trySplit()
		{
			return (Spliterator.OfLong)((FlatMapSpliterator)this).trySplit();
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

		Spliterator.OfPrimitive Spliterator.OfLong.Spliterator_0024OfLong_003A_003AtrySplit()
		{
			return ((FlatMapSpliteratorOfPrimitive)this).trySplit();
		}

		Spliterator Spliterator.OfLong.Spliterator_0024OfLong_003A_003AtrySplit()
		{
			return ((FlatMapSpliterator)this).trySplit();
		}

		Spliterator Spliterator.OfPrimitive.Spliterator_0024OfPrimitive_003A_003AtrySplit()
		{
			return ((FlatMapSpliterator)this).trySplit();
		}
	}

	[Signature("<InElementT:Ljava/lang/Object;OutElementT:Ljava/lang/Object;>Lcom/google/common/collect/CollectSpliterators$FlatMapSpliterator<TInElementT;TOutElementT;Ljava/util/Spliterator<TOutElementT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 37, 0, 0,
		17, 1, 0, 0, 0, 37, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)37,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class FlatMapSpliteratorOfObject : FlatMapSpliterator
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Factory
		{
			internal ___003C_003EAnon0()
			{
			}

			public Spliterator newFlatMapSpliterator(Spliterator P_0, Spliterator P_1, java.util.function.Function P_2, int P_3, long P_4)
			{
				Spliterator result = new FlatMapSpliteratorOfObject(P_0, P_1, P_2, P_3, P_4);
				_ = null;
				return result;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Spliterator<TOutElementT;>;Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;Ljava/util/Spliterator<TOutElementT;>;>;IJ)V")]
		[LineNumberTable(new byte[] { 161, 74, 153 })]
		internal FlatMapSpliteratorOfObject([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Spliterator P_0, Spliterator P_1, java.util.function.Function P_2, int P_3, long P_4)
			: base(P_0, P_1, P_2, new ___003C_003EAnon0(), P_3, P_4)
		{
		}
	}

	[Signature("<InElementT:Ljava/lang/Object;OutElementT:Ljava/lang/Object;OutConsumerT:Ljava/lang/Object;OutSpliteratorT::Ljava/util/Spliterator$OfPrimitive<TOutElementT;TOutConsumerT;TOutSpliteratorT;>;>Lcom/google/common/collect/CollectSpliterators$FlatMapSpliterator<TInElementT;TOutElementT;TOutSpliteratorT;>;Ljava/util/Spliterator$OfPrimitive<TOutElementT;TOutConsumerT;TOutSpliteratorT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 17, 0, 0, 0, 0, 78, 0, 0,
		17, 1, 0, 0, 0, 78, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)78,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.util.Spliterator$OfPrimitive" })]
	internal abstract class FlatMapSpliteratorOfPrimitive : FlatMapSpliterator, Spliterator.OfPrimitive, Spliterator
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Consumer
		{
			private readonly FlatMapSpliteratorOfPrimitive arg_00241;

			internal ___003C_003EAnon0(FlatMapSpliteratorOfPrimitive P_0)
			{
				arg_00241 = P_0;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024tryAdvance_00240(P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon1 : Consumer
		{
			private readonly FlatMapSpliteratorOfPrimitive arg_00241;

			private readonly object arg_00242;

			internal ___003C_003EAnon1(FlatMapSpliteratorOfPrimitive P_0, object P_1)
			{
				arg_00241 = P_0;
				arg_00242 = P_1;
			}

			public void accept(object P_0)
			{
				arg_00241.lambda_0024forEachRemaining_00241(arg_00242, P_0);
				_ = null;
			}

			[SpecialName]
			public Consumer andThen(Consumer P_0)
			{
				return Consumer._003Cdefault_003EandThen(this, P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(487)]
		private void lambda_0024tryAdvance_00240(object P_0)
		{
			prefix = (Spliterator)function.apply(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Synthetic)]
		[LineNumberTable(new byte[] { 161, 131, 114, 99, 137 })]
		private void lambda_0024forEachRemaining_00241(object P_0, object P_1)
		{
			((Spliterator.OfPrimitive)function.apply(P_1))?.forEachRemaining(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TOutSpliteratorT;Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;TOutSpliteratorT;>;Lcom/google/common/collect/CollectSpliterators$FlatMapSpliterator$Factory<TInElementT;TOutSpliteratorT;>;IJ)V")]
		[LineNumberTable(new byte[] { 161, 103, 113 })]
		internal FlatMapSpliteratorOfPrimitive([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] Spliterator.OfPrimitive P_0, Spliterator P_1, java.util.function.Function P_2, Factory P_3, int P_4, long P_5)
			: base(P_0, P_1, P_2, P_3, P_4, P_5)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TOutConsumerT;)Z")]
		[LineNumberTable(new byte[] { 161, 109, 123, 113, 143, 130, 135, 120 })]
		public bool tryAdvance(object P_0)
		{
			do
			{
				if (prefix != null && ((Spliterator.OfPrimitive)prefix).tryAdvance(P_0))
				{
					if (estimatedSize != long.MaxValue)
					{
						estimatedSize--;
					}
					return true;
				}
				prefix = null;
			}
			while (from.tryAdvance(new ___003C_003EAnon0(this)));
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TOutConsumerT;)V")]
		[LineNumberTable(new byte[] { 161, 125, 104, 113, 135, 247, 71, 104 })]
		public void forEachRemaining(object P_0)
		{
			if (prefix != null)
			{
				((Spliterator.OfPrimitive)prefix).forEachRemaining(P_0);
				prefix = null;
			}
			from.forEachRemaining(new ___003C_003EAnon1(this, P_0));
			estimatedSize = 0L;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(457)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Spliterator.OfPrimitive trySplit()
		{
			return (Spliterator.OfPrimitive)base.trySplit();
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

		Spliterator Spliterator.OfPrimitive.Spliterator_0024OfPrimitive_003A_003AtrySplit()
		{
			return ((FlatMapSpliterator)this).trySplit();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<InElementT:Ljava/lang/Object;OutElementT:Ljava/lang/Object;>(Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;Ljava/util/Spliterator<TOutElementT;>;>;IJ)Ljava/util/Spliterator<TOutElementT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 57, 0, 0,
		18, 1, 0, 0, 0, 57, 0, 0
	})]
	[LineNumberTable(new byte[] { 160, 107, 183, 179, 103, 103 })]
	internal static Spliterator flatMap(Spliterator P_0, java.util.function.Function P_1, int P_2, long P_3)
	{
		Preconditions.checkArgument(((P_2 & 0x4000) == 0) ? true : false, (object)"flatMap does not support SUBSIZED characteristic");
		Preconditions.checkArgument(((P_2 & 4) == 0) ? true : false, (object)"flatMap does not support SORTED characteristic");
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		FlatMapSpliteratorOfObject result = new FlatMapSpliteratorOfObject(null, P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<InElementT:Ljava/lang/Object;OutElementT:Ljava/lang/Object;>(Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;+TOutElementT;>;)Ljava/util/Spliterator<TOutElementT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 57, 0, 0,
		18, 1, 0, 0, 0, 57, 0, 0
	})]
	[LineNumberTable(new byte[] { 66, 103, 103 })]
	internal static Spliterator map(Spliterator P_0, java.util.function.Function P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		_1 result = new _1(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(IILjava/util/function/IntFunction<TT;>;)Ljava/util/Spliterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(47)]
	internal static Spliterator indexed(int P_0, int P_1, IntFunction P_2)
	{
		Spliterator result = indexed(P_0, P_1, P_2, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(IILjava/util/function/IntFunction<TT;>;Ljava/util/Comparator<-TT;>;)Ljava/util/Spliterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(new byte[] { 5, 99, 238, 113 })]
	internal static Spliterator indexed(int P_0, int P_1, IntFunction P_2, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Comparator P_3)
	{
		if (P_3 != null)
		{
			Preconditions.checkArgument((((uint)P_1 & 4u) != 0) ? true : false);
		}
		_1WithCharacteristics result = new _1WithCharacteristics(IntStream.range(0, P_0).spliterator(), P_2, P_1, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(43)]
	private CollectSpliterators()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Spliterator<TT;>;Ljava/util/function/Predicate<-TT;>;)Ljava/util/Spliterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(new byte[] { 104, 103, 231, 117 })]
	internal static Spliterator filter(Spliterator P_0, java.util.function.Predicate P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		_1Splitr result = new _1Splitr(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<InElementT:Ljava/lang/Object;>(Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;Ljava/util/Spliterator$OfInt;>;IJ)Ljava/util/Spliterator$OfInt;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 129, 183, 179, 103, 103 })]
	internal static Spliterator.OfInt flatMapToInt(Spliterator P_0, java.util.function.Function P_1, int P_2, long P_3)
	{
		Preconditions.checkArgument(((P_2 & 0x4000) == 0) ? true : false, (object)"flatMap does not support SUBSIZED characteristic");
		Preconditions.checkArgument(((P_2 & 4) == 0) ? true : false, (object)"flatMap does not support SORTED characteristic");
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		FlatMapSpliteratorOfInt result = new FlatMapSpliteratorOfInt(null, P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<InElementT:Ljava/lang/Object;>(Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;Ljava/util/Spliterator$OfLong;>;IJ)Ljava/util/Spliterator$OfLong;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 151, 183, 179, 103, 103 })]
	internal static Spliterator.OfLong flatMapToLong(Spliterator P_0, java.util.function.Function P_1, int P_2, long P_3)
	{
		Preconditions.checkArgument(((P_2 & 0x4000) == 0) ? true : false, (object)"flatMap does not support SUBSIZED characteristic");
		Preconditions.checkArgument(((P_2 & 4) == 0) ? true : false, (object)"flatMap does not support SORTED characteristic");
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		FlatMapSpliteratorOfLong result = new FlatMapSpliteratorOfLong(null, P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<InElementT:Ljava/lang/Object;>(Ljava/util/Spliterator<TInElementT;>;Ljava/util/function/Function<-TInElementT;Ljava/util/Spliterator$OfDouble;>;IJ)Ljava/util/Spliterator$OfDouble;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 57, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 173, 183, 179, 103, 103 })]
	internal static Spliterator.OfDouble flatMapToDouble(Spliterator P_0, java.util.function.Function P_1, int P_2, long P_3)
	{
		Preconditions.checkArgument(((P_2 & 0x4000) == 0) ? true : false, (object)"flatMap does not support SUBSIZED characteristic");
		Preconditions.checkArgument(((P_2 & 4) == 0) ? true : false, (object)"flatMap does not support SORTED characteristic");
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		FlatMapSpliteratorOfDouble result = new FlatMapSpliteratorOfDouble(null, P_0, P_1, P_2, P_3);
		_ = null;
		return result;
	}
}
