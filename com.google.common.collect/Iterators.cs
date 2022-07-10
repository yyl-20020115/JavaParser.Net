using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)123,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Iterators : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[EnclosingMethod(null, "unmodifiableIterator", "(Ljava.util.Iterator;)Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _1 : UnmodifiableIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024iterator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(137)]
		internal _1(Iterator P_0)
		{
			val_0024iterator = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(140)]
		public override bool hasNext()
		{
			bool result = val_0024iterator.hasNext();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(146)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object next()
		{
			object result = val_0024iterator.next();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[EnclosingMethod(null, "forEnumeration", "(Ljava.util.Enumeration;)Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _10 : UnmodifiableIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Enumeration val_0024enumeration;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1142)]
		internal _10(Enumeration P_0)
		{
			val_0024enumeration = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1145)]
		public override bool hasNext()
		{
			bool result = val_0024enumeration.hasMoreElements();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(1151)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object next()
		{
			object result = val_0024enumeration.nextElement();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Ljava/util/Enumeration<TT;>;")]
	[EnclosingMethod(null, "asEnumeration", "(Ljava.util.Iterator;)Ljava.util.Enumeration;")]
	internal class _11 : java.lang.Object, Enumeration
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024iterator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1164)]
		internal _11(Iterator P_0)
		{
			val_0024iterator = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1167)]
		public virtual bool hasMoreElements()
		{
			bool result = val_0024iterator.hasNext();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(1173)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object nextElement()
		{
			object result = val_0024iterator.next();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
	[EnclosingMethod(null, "cycle", "(Ljava.lang.Iterable;)Ljava.util.Iterator;")]
	internal class _2 : java.lang.Object, Iterator
	{
		[Signature("Ljava/util/Iterator<TT;>;")]
		internal Iterator iterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterable val_0024iterable;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 32, 111 })]
		internal _2(Iterable P_0)
		{
			val_0024iterable = P_0;
			base._002Ector();
			iterator = emptyModifiableIterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(416)]
		public virtual bool hasNext()
		{
			return (iterator.hasNext() || val_0024iterable.iterator().hasNext()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 161, 52, 109, 113, 109, 171 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object next()
		{
			if (!iterator.hasNext())
			{
				iterator = val_0024iterable.iterator();
				if (!iterator.hasNext())
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new NoSuchElementException();
				}
			}
			object result = iterator.next();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 63, 109 })]
		public virtual void remove()
		{
			iterator.remove();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TI;>;")]
	[EnclosingMethod(null, "consumingForArray", "([Ljava.util.Iterator;)Ljava.util.Iterator;")]
	internal class _3 : UnmodifiableIterator
	{
		internal int index;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator[] val_0024elements;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 96, 111 })]
		internal _3(Iterator[] P_0)
		{
			val_0024elements = P_0;
			base._002Ector();
			index = 0;
		}

		[LineNumberTable(471)]
		public override bool hasNext()
		{
			return index < (nint)val_0024elements.LongLength;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TI;")]
		[LineNumberTable(new byte[] { 161, 106, 104, 235, 70, 120, 110, 110 })]
		public new virtual Iterator next()
		{
			if (!hasNext())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			Iterator result = (Iterator)java.util.Objects.requireNonNull(val_0024elements[index]);
			val_0024elements[index] = null;
			index++;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(466)]
		public override object next()
		{
			Iterator result = next();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/List<TT;>;>;")]
	[EnclosingMethod(null, "partitionImpl", "(Ljava.util.Iterator;IZ)Lcom.google.common.collect.UnmodifiableIterator;")]
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
		48,
		0,
		0
	})]
	[ConstantPool(new object[]
	{
		(byte)48,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _4 : UnmodifiableIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024iterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024size;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal bool val_0024pad;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(626)]
		internal _4(Iterator P_0, int P_1, bool P_2)
		{
			val_0024iterator = P_0;
			val_0024size = P_1;
			val_0024pad = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(629)]
		public override bool hasNext()
		{
			bool result = val_0024iterator.hasNext();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/List<TT;>;")]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 48, 0, 0 })]
		[LineNumberTable(new byte[]
		{
			162, 8, 104, 203, 108, 98, 118, 46, 166, 107,
			36, 198, 140, 113, 130
		})]
		public new virtual List next()
		{
			if (!hasNext())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			object[] array = new object[val_0024size];
			int i;
			for (i = 0; i < val_0024size; i++)
			{
				if (!val_0024iterator.hasNext())
				{
					break;
				}
				array[i] = val_0024iterator.next();
			}
			for (int j = i; j < val_0024size; j++)
			{
				array[j] = null;
			}
			List list = Collections.unmodifiableList(Arrays.asList(array));
			if (val_0024pad || i == val_0024size)
			{
				return list;
			}
			List result = list.subList(0, i);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 20, 1, 3, 0, 0, 48, 0, 0 })]
		[LineNumberTable(626)]
		public override object next()
		{
			List result = next();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/AbstractIterator<TT;>;")]
	[EnclosingMethod(null, "filter", "(Ljava.util.Iterator;Lcom.google.common.base.Predicate;)Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _5 : AbstractIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024unfiltered;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal com.google.common.@base.Predicate val_0024retainIfTrue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(667)]
		internal _5(Iterator P_0, com.google.common.@base.Predicate P_1)
		{
			val_0024unfiltered = P_0;
			val_0024retainIfTrue = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 162, 45, 109, 108, 110, 130, 98 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			while (val_0024unfiltered.hasNext())
			{
				object obj = val_0024unfiltered.next();
				if (val_0024retainIfTrue.apply(obj))
				{
					return obj;
				}
			}
			object result = endOfData();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/TransformedIterator<TF;TT;>;")]
	[EnclosingMethod(null, "transform", "(Ljava.util.Iterator;Lcom.google.common.base.Function;)Ljava.util.Iterator;")]
	internal class _6 : TransformedIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal com.google.common.@base.Function val_0024function;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(825)]
		internal _6(Iterator P_0, com.google.common.@base.Function P_1)
		{
			val_0024function = P_1;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TF;)TT;")]
		[LineNumberTable(829)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal override object transform([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			object result = val_0024function.apply(P_0);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
	[EnclosingMethod(null, "limit", "(Ljava.util.Iterator;I)Ljava.util.Iterator;")]
	internal class _7 : java.lang.Object, Iterator
	{
		private int count;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal int val_0024limitSize;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024iterator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(961)]
		internal _7(int P_0, Iterator P_1)
		{
			val_0024limitSize = P_0;
			val_0024iterator = P_1;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(966)]
		public virtual bool hasNext()
		{
			return (count < val_0024limitSize && val_0024iterator.hasNext()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 163, 90, 104, 139, 110 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object next()
		{
			if (!hasNext())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			count++;
			object result = val_0024iterator.next();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 99, 109 })]
		public virtual void remove()
		{
			val_0024iterator.remove();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[EnclosingMethod(null, "consumingIterator", "(Ljava.util.Iterator;)Ljava.util.Iterator;")]
	internal class _8 : UnmodifiableIterator
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024iterator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(999)]
		internal _8(Iterator P_0)
		{
			val_0024iterator = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1002)]
		public override bool hasNext()
		{
			bool result = val_0024iterator.hasNext();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 163, 126, 108, 107 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object next()
		{
			object result = val_0024iterator.next();
			val_0024iterator.remove();
			return result;
		}

		public override string toString()
		{
			return "Iterators.consumingIterator(...)";
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[EnclosingMethod(null, "singletonIterator", "(Ljava.lang.Object;)Lcom.google.common.collect.UnmodifiableIterator;")]
	internal class _9 : UnmodifiableIterator
	{
		internal bool done;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal object val_0024value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1109)]
		internal _9(object P_0)
		{
			val_0024value = P_0;
			base._002Ector();
		}

		public override bool hasNext()
		{
			return (!done) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 163, 238, 104, 139, 103 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object next()
		{
			if (done)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			done = true;
			return val_0024value;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/AbstractIndexedListIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 43, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)43,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class ArrayItr : AbstractIndexedListIterator
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/UnmodifiableListIterator<Ljava/lang/Object;>;")]
		internal static UnmodifiableListIterator EMPTY;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("[TT;")]
		private object[] array;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int offset;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("([TT;III)V")]
		[LineNumberTable(new byte[] { 163, 208, 107, 103, 103 })]
		internal ArrayItr(object[] P_0, int P_1, int P_2, int P_3)
			: base(P_2, P_3)
		{
			array = P_0;
			offset = P_1;
		}

		[Signature("(I)TT;")]
		[LineNumberTable(1098)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		protected internal override object get(int P_0)
		{
			return array[offset + P_0];
		}

		[LineNumberTable(1084)]
		static ArrayItr()
		{
			EMPTY = new ArrayItr(new object[0], 0, 0, 0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 69, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)69,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class ConcatenatedIterator : java.lang.Object, Iterator
	{
		[Signature("Ljava/util/Iterator<+TT;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Iterator toRemove;

		[Signature("Ljava/util/Iterator<+TT;>;")]
		private Iterator iterator;

		[Signature("Ljava/util/Iterator<+Ljava/util/Iterator<+TT;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Iterator topMetaIterator;

		[Signature("Ljava/util/Deque<Ljava/util/Iterator<+Ljava/util/Iterator<+TT;>;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Deque metaIterators;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+Ljava/util/Iterator<+TT;>;>;)V")]
		[LineNumberTable(new byte[] { 164, 233, 104, 107, 113 })]
		internal ConcatenatedIterator(Iterator P_0)
		{
			iterator = emptyIterator();
			topMetaIterator = (Iterator)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<+Ljava/util/Iterator<+TT;>;>;")]
		[LineNumberTable(new byte[] { 164, 241, 117, 117, 152, 162 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Iterator getTopMetaIterator()
		{
			while (topMetaIterator == null || !topMetaIterator.hasNext())
			{
				if (metaIterators != null && !metaIterators.isEmpty())
				{
					topMetaIterator = (Iterator)metaIterators.removeFirst();
					continue;
				}
				return null;
			}
			return topMetaIterator;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			164, 253, 218, 108, 104, 162, 150, 205, 108, 236,
			69, 104, 139, 113, 104, 109, 189, 108, 133
		})]
		public virtual bool hasNext()
		{
			while (!((Iterator)Preconditions.checkNotNull(iterator)).hasNext())
			{
				topMetaIterator = getTopMetaIterator();
				if (topMetaIterator == null)
				{
					return false;
				}
				iterator = (Iterator)topMetaIterator.next();
				if (!(iterator is ConcatenatedIterator))
				{
					continue;
				}
				ConcatenatedIterator concatenatedIterator = (ConcatenatedIterator)iterator;
				iterator = concatenatedIterator.iterator;
				if (metaIterators == null)
				{
					metaIterators = new ArrayDeque();
				}
				metaIterators.addFirst(topMetaIterator);
				if (concatenatedIterator.metaIterators != null)
				{
					while (!concatenatedIterator.metaIterators.isEmpty())
					{
						metaIterators.addFirst((Iterator)concatenatedIterator.metaIterators.removeLast());
					}
				}
				topMetaIterator = concatenatedIterator.topMetaIterator;
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 165, 36, 104, 108, 142 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object next()
		{
			if (hasNext())
			{
				toRemove = iterator;
				object result = iterator.next();
				_ = null;
				return result;
			}
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 165, 46, 104, 144, 107, 103 })]
		public virtual void remove()
		{
			if (toRemove == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalStateException("no calls to next() since the last call to remove()");
			}
			toRemove.remove();
			toRemove = null;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/collect/Iterators$EmptyModifiableIterator;>;Ljava/util/Iterator<Ljava/lang/Object;>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "java.util.Iterator" })]
	internal sealed class EmptyModifiableIterator : java.lang.Enum, Iterator
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static EmptyModifiableIterator INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static EmptyModifiableIterator[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(99)]
		private EmptyModifiableIterator(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(99)]
		private static EmptyModifiableIterator[] _0024values()
		{
			return new EmptyModifiableIterator[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(99)]
		public static EmptyModifiableIterator[] values()
		{
			return (EmptyModifiableIterator[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(99)]
		public static EmptyModifiableIterator valueOf(string P_0)
		{
			return (EmptyModifiableIterator)java.lang.Enum.valueOf(ClassLiteral<EmptyModifiableIterator>.Value, P_0);
		}

		public virtual bool hasNext()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(109)]
		public virtual object next()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 64, 104 })]
		public virtual void remove()
		{
			CollectPreconditions.checkRemove(false);
		}

		[LineNumberTable(new byte[] { 50, 48 })]
		static EmptyModifiableIterator()
		{
			INSTANCE = new EmptyModifiableIterator("INSTANCE", 0);
			_0024VALUES = _0024values();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 72, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)72,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class MergingIterator : UnmodifiableIterator
	{
		[SpecialName]
		private sealed class ___003C_003EAnon0 : Comparator
		{
			private readonly Comparator arg_00241;

			internal ___003C_003EAnon0(Comparator P_0)
			{
				arg_00241 = P_0;
			}

			public int compare(object P_0, object P_1)
			{
				int result = lambda_0024new_00240(arg_00241, (PeekingIterator)P_0, (PeekingIterator)P_1);
				_ = null;
				return result;
			}

			[SpecialName]
			public Comparator thenComparing(Comparator P_0)
			{
				return Comparator._003Cdefault_003EthenComparing(this, P_0);
			}

			[SpecialName]
			public bool equals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}

			[SpecialName]
			public Comparator reversed()
			{
				return Comparator._003Cdefault_003Ereversed(this);
			}

			[SpecialName]
			public Comparator thenComparing(java.util.function.Function P_0, Comparator P_1)
			{
				return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
			}

			[SpecialName]
			public Comparator thenComparing(java.util.function.Function P_0)
			{
				return Comparator._003Cdefault_003EthenComparing(this, P_0);
			}

			[SpecialName]
			public Comparator thenComparingInt(ToIntFunction P_0)
			{
				return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
			}

			[SpecialName]
			public Comparator thenComparingLong(ToLongFunction P_0)
			{
				return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
			}

			[SpecialName]
			public Comparator thenComparingDouble(ToDoubleFunction P_0)
			{
				return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Queue<Lcom/google/common/collect/PeekingIterator<TT;>;>;")]
		internal Queue queue;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<+Ljava/util/Iterator<+TT;>;>;Ljava/util/Comparator<-TT;>;)V")]
		[LineNumberTable(new byte[] { 164, 181, 168, 204, 141, 123, 104, 146, 98 })]
		public MergingIterator(Iterable P_0, Comparator P_1)
		{
			Comparator comparator = new ___003C_003EAnon0(P_1);
			queue = new PriorityQueue(2, comparator);
			Iterator iterator = P_0.iterator();
			while (iterator.hasNext())
			{
				Iterator iterator2 = (Iterator)iterator.next();
				if (iterator2.hasNext())
				{
					queue.add(peekingIterator(iterator2));
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1324)]
		private static int lambda_0024new_00240(Comparator P_0, PeekingIterator P_1, PeekingIterator P_2)
		{
			int result = P_0.compare(P_1.peek(), P_2.peek());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1337)]
		public override bool hasNext()
		{
			return (!queue.isEmpty()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TT;")]
		[LineNumberTable(new byte[] { 164, 205, 113, 103, 104, 141 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public override object next()
		{
			PeekingIterator peekingIterator = (PeekingIterator)queue.remove();
			object result = peekingIterator.next();
			if (peekingIterator.hasNext())
			{
				queue.add(peekingIterator);
			}
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/PeekingIterator<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 54, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)54,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "com.google.common.collect.PeekingIterator" })]
	internal class PeekingImpl : java.lang.Object, PeekingIterator, Iterator
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Iterator<+TE;>;")]
		private Iterator iterator;

		private bool hasPeeked;

		[Signature("TE;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private object peekedElement;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Iterator<+TE;>;)V")]
		[LineNumberTable(new byte[] { 164, 47, 104, 113 })]
		public PeekingImpl(Iterator P_0)
		{
			iterator = (Iterator)Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1191)]
		public virtual bool hasNext()
		{
			return (hasPeeked || iterator.hasNext()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 164, 59, 104, 174, 108, 103, 103 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object next()
		{
			if (!hasPeeked)
			{
				object result = iterator.next();
				_ = null;
				return result;
			}
			object result2 = NullnessCasts.uncheckedCastNullableTToT(peekedElement);
			hasPeeked = false;
			peekedElement = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 71, 118, 109 })]
		public virtual void remove()
		{
			Preconditions.checkState((!hasPeeked) ? true : false, (object)"Can't remove after you've peeked at next");
			iterator.remove();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 164, 78, 104, 113, 167 })]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public virtual object peek()
		{
			if (!hasPeeked)
			{
				peekedElement = iterator.next();
				hasPeeked = true;
			}
			object result = NullnessCasts.uncheckedCastNullableTToT(peekedElement);
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<TT;>;Ljava/util/Iterator<+TT;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 249, 103, 103, 98, 104, 145 })]
	public static bool addAll(Collection addTo, Iterator iterator)
	{
		Preconditions.checkNotNull(addTo);
		Preconditions.checkNotNull(iterator);
		int num = 0;
		while (iterator.hasNext())
		{
			num |= (addTo.add(iterator.next()) ? 1 : 0);
		}
		return (byte)num != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<*>;)V")]
	[LineNumberTable(new byte[] { 163, 157, 103, 104, 103, 136 })]
	internal static void clear(Iterator P_0)
	{
		Preconditions.checkNotNull(P_0);
		while (P_0.hasNext())
		{
			P_0.next();
			P_0.remove();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<*>;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[] { 160, 64, 99, 104, 104, 194, 104, 110, 194 })]
	public static bool contains(Iterator iterator, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		if (element == null)
		{
			while (iterator.hasNext())
			{
				if (iterator.next() == null)
				{
					return true;
				}
			}
		}
		else
		{
			while (iterator.hasNext())
			{
				if (java.lang.Object.instancehelper_equals(element, iterator.next()))
				{
					return true;
				}
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<*>;Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[] { 160, 90, 103, 98, 104, 110, 102, 164 })]
	public static bool removeAll(Iterator removeFrom, Collection elementsToRemove)
	{
		Preconditions.checkNotNull(elementsToRemove);
		int result = 0;
		while (removeFrom.hasNext())
		{
			if (elementsToRemove.contains(removeFrom.next()))
			{
				removeFrom.remove();
				result = 1;
			}
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<*>;Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[] { 160, 135, 103, 98, 104, 110, 102, 164 })]
	public static bool retainAll(Iterator removeFrom, Collection elementsToRetain)
	{
		Preconditions.checkNotNull(elementsToRetain);
		int result = 0;
		while (removeFrom.hasNext())
		{
			if (!elementsToRetain.contains(removeFrom.next()))
			{
				removeFrom.remove();
				result = 1;
			}
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(125)]
	internal static Iterator emptyModifiableIterator()
	{
		return EmptyModifiableIterator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 144, 104, 103, 102, 130 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	internal static object pollNext(Iterator P_0)
	{
		if (P_0.hasNext())
		{
			object result = P_0.next();
			P_0.remove();
			return result;
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;TT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(895)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object getNext(Iterator iterator, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object defaultValue)
	{
		return (!iterator.hasNext()) ? defaultValue : iterator.next();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;Lcom/google/common/base/Predicate<-TT;>;)Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 39, 103, 103 })]
	public static UnmodifiableIterator filter(Iterator unfiltered, com.google.common.@base.Predicate retainIfTrue)
	{
		Preconditions.checkNotNull(unfiltered);
		Preconditions.checkNotNull(retainIfTrue);
		_5 result = new _5(unfiltered, retainIfTrue);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<F:Ljava/lang/Object;T:Ljava/lang/Object;>(Ljava/util/Iterator<TF;>;Lcom/google/common/base/Function<-TF;+TT;>;)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 123, 0, 0,
		18, 1, 0, 0, 0, 123, 0, 0
	})]
	[LineNumberTable(new byte[] { 162, 198, 103 })]
	public static Iterator transform(Iterator fromIterator, com.google.common.@base.Function function)
	{
		Preconditions.checkNotNull(function);
		_6 result = new _6(fromIterator, function);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(81)]
	internal static UnmodifiableIterator emptyIterator()
	{
		UnmodifiableListIterator result = emptyListIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<*>;)I")]
	[LineNumberTable(new byte[] { 118, 99, 104, 103, 135 })]
	public static int size(Iterator iterator)
	{
		long num = 0L;
		while (iterator.hasNext())
		{
			iterator.next();
			num++;
		}
		int result = Ints.saturatedCast(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+Ljava/util/Iterator<+TT;>;>;)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(568)]
	public static Iterator concat(Iterator inputs)
	{
		ConcatenatedIterator result = new ConcatenatedIterator(inputs);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;)Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 81, 103, 136, 103, 130 })]
	public static UnmodifiableIterator unmodifiableIterator(Iterator iterator)
	{
		Preconditions.checkNotNull(iterator);
		if (iterator is UnmodifiableIterator)
		{
			return (UnmodifiableIterator)iterator;
		}
		_1 result = new _1(iterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;)Lcom/google/common/collect/PeekingIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 164, 125, 200, 103, 130 })]
	public static PeekingIterator peekingIterator(Iterator iterator)
	{
		if (iterator is PeekingImpl)
		{
			return (PeekingImpl)iterator;
		}
		PeekingImpl result = new PeekingImpl(iterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 31, 103 })]
	public static Iterator cycle(Iterable iterable)
	{
		Preconditions.checkNotNull(iterable);
		_2 result = new _2(iterable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;Lcom/google/common/base/Predicate<-TT;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 113, 103, 98, 104, 110, 102, 164 })]
	public static bool removeIf(Iterator removeFrom, com.google.common.@base.Predicate predicate)
	{
		Preconditions.checkNotNull(predicate);
		int result = 0;
		while (removeFrom.hasNext())
		{
			if (predicate.apply(removeFrom.next()))
			{
				removeFrom.remove();
				result = 1;
			}
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<*>;Ljava/util/Iterator<*>;)Z")]
	[LineNumberTable(new byte[] { 160, 156, 104, 104, 130, 103, 103, 105, 130, 98 })]
	public static bool elementsEqual(Iterator iterator1, Iterator iterator2)
	{
		while (iterator1.hasNext())
		{
			if (!iterator2.hasNext())
			{
				return false;
			}
			object a = iterator1.next();
			object b = iterator2.next();
			if (!com.google.common.@base.Objects.equal(a, b))
			{
				return false;
			}
		}
		return (!iterator2.hasNext()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<*>;)Ljava/lang/String;")]
	[LineNumberTable(new byte[] { 160, 174, 109, 98, 104, 99, 140, 98, 143 })]
	public static string toString(Iterator iterator)
	{
		StringBuilder stringBuilder = new StringBuilder().append('[');
		int num = 1;
		while (iterator.hasNext())
		{
			if (num == 0)
			{
				stringBuilder.append(", ");
			}
			num = 0;
			stringBuilder.append(iterator.next());
		}
		string result = stringBuilder.append(']').toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		160, 195, 103, 104, 162, 118, 110, 55, 166, 104,
		140, 137
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object getOnlyElement(Iterator iterator)
	{
		object obj = iterator.next();
		if (!iterator.hasNext())
		{
			return obj;
		}
		StringBuilder stringBuilder = new StringBuilder().append("expected one element but was: <").append(obj);
		for (int i = 0; i < 4; i++)
		{
			if (!iterator.hasNext())
			{
				break;
			}
			stringBuilder.append(", ").append(iterator.next());
		}
		if (iterator.hasNext())
		{
			stringBuilder.append(", ...");
		}
		stringBuilder.append('>');
		string s = stringBuilder.toString();
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(s);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;TT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(336)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object getOnlyElement(Iterator iterator, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object defaultValue)
	{
		return (!iterator.hasNext()) ? defaultValue : getOnlyElement(iterator);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<*>;Ljava/lang/Object;)I")]
	[LineNumberTable(new byte[] { 161, 9, 98, 169, 134 })]
	public static int frequency(Iterator iterator, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		int num = 0;
		while (contains(iterator, element))
		{
			num++;
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;Lcom/google/common/base/Predicate<-TT;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(698)]
	public static bool any(Iterator iterator, com.google.common.@base.Predicate predicate)
	{
		return indexOf(iterator, predicate) != -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;Lcom/google/common/base/Predicate<-TT;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 81, 103, 104, 103, 105, 130, 98 })]
	public static bool all(Iterator iterator, com.google.common.@base.Predicate predicate)
	{
		Preconditions.checkNotNull(predicate);
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (!predicate.apply(obj))
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;Lcom/google/common/base/Predicate<-TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 103, 103, 103, 104, 103, 105, 130, 98 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object find(Iterator iterator, com.google.common.@base.Predicate predicate)
	{
		Preconditions.checkNotNull(iterator);
		Preconditions.checkNotNull(predicate);
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (predicate.apply(obj))
			{
				return obj;
			}
		}
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new NoSuchElementException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;Lcom/google/common/base/Predicate<-TT;>;TT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 128, 103, 103, 104, 103, 105, 130, 98 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public static object find(Iterator iterator, com.google.common.@base.Predicate predicate, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object defaultValue)
	{
		Preconditions.checkNotNull(iterator);
		Preconditions.checkNotNull(predicate);
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (predicate.apply(obj))
			{
				return obj;
			}
		}
		return defaultValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;Lcom/google/common/base/Predicate<-TT;>;)Lcom/google/common/base/Optional<TT;>;")]
	[LineNumberTable(new byte[] { 162, 151, 103, 103, 104, 103, 105, 137, 98 })]
	public static com.google.common.@base.Optional tryFind(Iterator iterator, com.google.common.@base.Predicate predicate)
	{
		Preconditions.checkNotNull(iterator);
		Preconditions.checkNotNull(predicate);
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (predicate.apply(obj))
			{
				com.google.common.@base.Optional result = com.google.common.@base.Optional.of(obj);
				_ = null;
				return result;
			}
		}
		com.google.common.@base.Optional result2 = com.google.common.@base.Optional.absent();
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;Lcom/google/common/base/Predicate<-TT;>;)I")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 178, 108, 106, 103, 105, 226, 61, 230, 70 })]
	public static int indexOf(Iterator iterator, com.google.common.@base.Predicate predicate)
	{
		Preconditions.checkNotNull((object)predicate, (object)"predicate");
		int num = 0;
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			if (predicate.apply(obj))
			{
				return num;
			}
			num++;
		}
		return -1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;I)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		162,
		219,
		102,
		104,
		104,
		byte.MaxValue,
		38,
		71
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object get(Iterator iterator, int position)
	{
		checkNonnegative(position);
		int i = advance(iterator, position);
		if (!iterator.hasNext())
		{
			int num = 91;
			num = num;
			string s = new StringBuilder(num).append("position (").append(position).append(") must be less than the number of elements that remained (")
				.append(i)
				.append(")")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IndexOutOfBoundsException(s);
		}
		object result = iterator.next();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 253, 100, 159, 22 })]
	internal static void checkNonnegative(int P_0)
	{
		if (P_0 < 0)
		{
			int num = 43;
			num = num;
			string s = new StringBuilder(num).append("position (").append(P_0).append(") must not be negative")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IndexOutOfBoundsException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Iterator<*>;I)I")]
	[LineNumberTable(new byte[] { 163, 55, 103, 177, 110, 39, 166 })]
	public static int advance(Iterator iterator, int numberToAdvance)
	{
		Preconditions.checkNotNull(iterator);
		Preconditions.checkArgument(numberToAdvance >= 0, (object)"numberToAdvance must be nonnegative");
		int i;
		for (i = 0; i < numberToAdvance; i++)
		{
			if (!iterator.hasNext())
			{
				break;
			}
			iterator.next();
		}
		return i;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 25, 103, 104, 130 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object getLast(Iterator iterator)
	{
		object result;
		do
		{
			result = iterator.next();
		}
		while (iterator.hasNext());
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;TT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(925)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object getLast(Iterator iterator, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object defaultValue)
	{
		return (!iterator.hasNext()) ? defaultValue : getLast(iterator);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;I)Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/List<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(600)]
	public static UnmodifiableIterator partition(Iterator iterator, int size)
	{
		UnmodifiableIterator result = partitionImpl(iterator, size, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;I)Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/List<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 2, 3, 0, 3, 0, 0, 123,
		0, 0, 18, 0, 0, 0, 0, 123, 0, 0
	})]
	[LineNumberTable(619)]
	public static UnmodifiableIterator paddedPartition(Iterator iterator, int size)
	{
		UnmodifiableIterator result = partitionImpl(iterator, size, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;I)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 77, 103, 113 })]
	public static Iterator limit(Iterator iterator, int limitSize)
	{
		Preconditions.checkNotNull(iterator);
		Preconditions.checkArgument(limitSize >= 0, (object)"limit is negative");
		_7 result = new _7(limitSize, iterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 116, 103 })]
	public static Iterator consumingIterator(Iterator iterator)
	{
		Preconditions.checkNotNull(iterator);
		_8 result = new _8(iterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<+Ljava/util/Iterator<+TT;>;>;Ljava/util/Comparator<-TT;>;)Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 164, 162, 108, 140 })]
	public static UnmodifiableIterator mergeSorted(Iterable iterators, Comparator comparator)
	{
		Preconditions.checkNotNull((object)iterators, (object)"iterators");
		Preconditions.checkNotNull((object)comparator, (object)"comparator");
		MergingIterator result = new MergingIterator(iterators, comparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>()Lcom/google/common/collect/UnmodifiableListIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(92)]
	internal static UnmodifiableListIterator emptyListIterator()
	{
		return ArrayItr.EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<I::Ljava/util/Iterator<*>;>([TI;)Ljava/util/Iterator<TI;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 22, 0, 1, 0, 0, 0, 123, 0,
		0
	})]
	[LineNumberTable(466)]
	private static Iterator consumingForArray(params Iterator[] P_0)
	{
		_3 result = new _3(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([Ljava/util/Iterator<+TT;>;)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 204, 121, 39, 166 })]
	internal static Iterator concatNoDefensiveCopy(params Iterator[] P_0)
	{
		Iterator[] array = (Iterator[])Preconditions.checkNotNull(P_0);
		int num = array.Length;
		for (int i = 0; i < num; i++)
		{
			Iterator reference = array[i];
			Preconditions.checkNotNull(reference);
		}
		Iterator result = concat(consumingForArray(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;IZ)Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/List<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 2, 3, 0, 3, 0, 0, 123,
		0, 0, 18, 0, 0, 0, 0, 123, 0, 0
	})]
	[LineNumberTable(new byte[] { 158, 242, 66, 103, 105 })]
	private static UnmodifiableIterator partitionImpl(Iterator P_0, int P_1, bool P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkArgument(P_1 > 0);
		_4 result = new _4(P_0, P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;III)Lcom/google/common/collect/UnmodifiableListIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 188, 108, 164, 105, 104, 99, 136 })]
	internal static UnmodifiableListIterator forArray(object[] P_0, int P_1, int P_2, int P_3)
	{
		Preconditions.checkArgument(P_2 >= 0);
		int end = P_1 + P_2;
		Preconditions.checkPositionIndexes(P_1, end, P_0.Length);
		Preconditions.checkPositionIndex(P_3, P_2);
		if (P_2 == 0)
		{
			UnmodifiableListIterator result = emptyListIterator();
			_ = null;
			return result;
		}
		ArrayItr result2 = new ArrayItr(P_0, P_1, P_2, P_3);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	private Iterators()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/collect/UnmodifiableIterator<TT;>;)Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(160)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static UnmodifiableIterator unmodifiableIterator(UnmodifiableIterator iterator)
	{
		return (UnmodifiableIterator)Preconditions.checkNotNull(iterator);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;Ljava/lang/Class<TT;>;)[TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 20, 1, 0, 0, 0, 123, 0, 0,
		22, 0, 2, 3, 0, 2, 0, 0, 123, 0,
		0
	})]
	[LineNumberTable(new byte[] { 160, 236, 103 })]
	public static object[] toArray(Iterator iterator, Class type)
	{
		ArrayList iterable = Lists.newArrayList(iterator);
		object[] result = Iterables.toArray(iterable, type);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(452)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static Iterator cycle(params object[] elements)
	{
		Iterator result = cycle(Lists.newArrayList(elements));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;Ljava/util/Iterator<+TT;>;)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 131, 103, 103 })]
	public static Iterator concat(Iterator a, Iterator b)
	{
		Preconditions.checkNotNull(a);
		Preconditions.checkNotNull(b);
		Iterator result = concat(consumingForArray(a, b));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;Ljava/util/Iterator<+TT;>;Ljava/util/Iterator<+TT;>;)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 146, 103, 103, 103 })]
	public static Iterator concat(Iterator a, Iterator b, Iterator c)
	{
		Preconditions.checkNotNull(a);
		Preconditions.checkNotNull(b);
		Preconditions.checkNotNull(c);
		Iterator result = concat(consumingForArray(a, b, c));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;Ljava/util/Iterator<+TT;>;Ljava/util/Iterator<+TT;>;Ljava/util/Iterator<+TT;>;)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 166, 103, 103, 103, 103 })]
	public static Iterator concat(Iterator a, Iterator b, Iterator c, Iterator d)
	{
		Preconditions.checkNotNull(a);
		Preconditions.checkNotNull(b);
		Preconditions.checkNotNull(c);
		Preconditions.checkNotNull(d);
		Iterator result = concat(consumingForArray(a, b, c, d));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([Ljava/util/Iterator<+TT;>;)Ljava/util/Iterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(554)]
	public static Iterator concat(params Iterator[] inputs)
	{
		Iterator result = concatNoDefensiveCopy((Iterator[])Arrays.copyOf(inputs, inputs.Length));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<*>;Ljava/lang/Class<TT;>;)Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[LineNumberTable(689)]
	public static UnmodifiableIterator filter(Iterator unfiltered, Class desiredType)
	{
		UnmodifiableIterator result = filter(unfiltered, Predicates.instanceOf(desiredType));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<+TT;>;ITT;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 162, 247, 102, 104 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public static object get(Iterator iterator, int position, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object defaultValue)
	{
		checkNonnegative(position);
		advance(iterator, position);
		object next = getNext(iterator, defaultValue);
		_ = null;
		return next;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>([TT;)Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(1058)]
	[SafeVarargs(new object[]
	{
		(byte)64,
		"Ljava/lang/SafeVarargs;"
	})]
	public static UnmodifiableIterator forArray(params object[] array)
	{
		UnmodifiableListIterator result = forArray(array, 0, array.Length, 0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(TT;)Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(1109)]
	public static UnmodifiableIterator singletonIterator([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		_9 result = new _9(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Enumeration<TT;>;)Lcom/google/common/collect/UnmodifiableIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 164, 3, 103 })]
	public static UnmodifiableIterator forEnumeration(Enumeration enumeration)
	{
		Preconditions.checkNotNull(enumeration);
		_10 result = new _10(enumeration);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;)Ljava/util/Enumeration<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(new byte[] { 164, 25, 103 })]
	public static Enumeration asEnumeration(Iterator iterator)
	{
		Preconditions.checkNotNull(iterator);
		_11 result = new _11(iterator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<T:Ljava/lang/Object;>(Lcom/google/common/collect/PeekingIterator<TT;>;)Lcom/google/common/collect/PeekingIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(1282)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static PeekingIterator peekingIterator(PeekingIterator iterator)
	{
		return (PeekingIterator)Preconditions.checkNotNull(iterator);
	}

	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Iterator<TT;>;)Ljava/util/ListIterator<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 123, 0, 0 })]
	[LineNumberTable(1450)]
	internal static ListIterator cast(Iterator P_0)
	{
		return (ListIterator)P_0;
	}
}
