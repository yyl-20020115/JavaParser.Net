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
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)117,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Multisets : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Multisets$ViewMultiset<TE;>;")]
	[EnclosingMethod(null, "union", "(Lcom.google.common.collect.Multiset;Lcom.google.common.collect.Multiset;)Lcom.google.common.collect.Multiset;")]
	internal class _1 : ViewMultiset
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024iterator1;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024iterator2;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Multisets._1 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
			[LineNumberTable(new byte[]
			{
				161, 85, 109, 113, 103, 125, 138, 109, 113, 103,
				115, 143, 98
			})]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Multiset.Entry computeNext()
			{
				if (val_0024iterator1.hasNext())
				{
					Multiset.Entry entry = (Multiset.Entry)val_0024iterator1.next();
					object element = entry.getElement();
					int n = java.lang.Math.max(entry.getCount(), this_00240.val_0024multiset2.count(element));
					Multiset.Entry result = immutableEntry(element, n);
					_ = null;
					return result;
				}
				while (val_0024iterator2.hasNext())
				{
					Multiset.Entry entry = (Multiset.Entry)val_0024iterator2.next();
					object element = entry.getElement();
					if (!this_00240.val_0024multiset1.contains(element))
					{
						Multiset.Entry result2 = immutableEntry(element, entry.getCount());
						_ = null;
						return result2;
					}
				}
				return (Multiset.Entry)endOfData();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(451)]
			internal _1(Multisets._1 P_0, Iterator P_1, Iterator P_2)
			{
				this_00240 = P_0;
				val_0024iterator1 = P_1;
				val_0024iterator2 = P_2;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(451)]
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

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Multiset val_0024multiset1;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Multiset val_0024multiset2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(420)]
		internal _1(Multiset P_0, Multiset P_1)
		{
			val_0024multiset1 = P_0;
			val_0024multiset2 = P_1;
			base._002Ector(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(423)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (val_0024multiset1.contains(P_0) || val_0024multiset2.contains(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(428)]
		public override bool isEmpty()
		{
			return (val_0024multiset1.isEmpty() && val_0024multiset2.isEmpty()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(433)]
		public override int count([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int result = java.lang.Math.max(val_0024multiset1.count(P_0), val_0024multiset2.count(P_0));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TE;>;")]
		[LineNumberTable(438)]
		internal override Set createElementSet()
		{
			Sets.SetView result = Sets.union(val_0024multiset1.elementSet(), val_0024multiset2.elementSet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(443)]
		internal override Iterator elementIterator()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("should never be called");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(new byte[] { 161, 78, 113, 145 })]
		internal override Iterator entryIterator()
		{
			Iterator iterator = val_0024multiset1.entrySet().iterator();
			Iterator iterator2 = val_0024multiset2.entrySet().iterator();
			_1 result = new _1(this, iterator, iterator2);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Multisets$ViewMultiset<TE;>;")]
	[EnclosingMethod(null, "intersection", "(Lcom.google.common.collect.Multiset;Lcom.google.common.collect.Multiset;)Lcom.google.common.collect.Multiset;")]
	internal class _2 : ViewMultiset
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024iterator1;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _2 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
			[LineNumberTable(new byte[] { 161, 147, 109, 113, 103, 125, 100, 138, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Multiset.Entry computeNext()
			{
				while (val_0024iterator1.hasNext())
				{
					Multiset.Entry entry = (Multiset.Entry)val_0024iterator1.next();
					object element = entry.getElement();
					int num = java.lang.Math.min(entry.getCount(), this_00240.val_0024multiset2.count(element));
					if (num > 0)
					{
						Multiset.Entry result = immutableEntry(element, num);
						_ = null;
						return result;
					}
				}
				return (Multiset.Entry)endOfData();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(513)]
			internal _1(_2 P_0, Iterator P_1)
			{
				this_00240 = P_0;
				val_0024iterator1 = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(513)]
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

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Multiset val_0024multiset1;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Multiset val_0024multiset2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(492)]
		internal _2(Multiset P_0, Multiset P_1)
		{
			val_0024multiset1 = P_0;
			val_0024multiset2 = P_1;
			base._002Ector(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 125, 109 })]
		public override int count([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int num = val_0024multiset1.count(P_0);
			int result = ((num != 0) ? java.lang.Math.min(num, val_0024multiset2.count(P_0)) : 0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TE;>;")]
		[LineNumberTable(501)]
		internal override Set createElementSet()
		{
			Sets.SetView result = Sets.intersection(val_0024multiset1.elementSet(), val_0024multiset2.elementSet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(506)]
		internal override Iterator elementIterator()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("should never be called");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(new byte[] { 161, 141, 145 })]
		internal override Iterator entryIterator()
		{
			Iterator iterator = val_0024multiset1.entrySet().iterator();
			_1 result = new _1(this, iterator);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Multisets$ViewMultiset<TE;>;")]
	[EnclosingMethod(null, "sum", "(Lcom.google.common.collect.Multiset;Lcom.google.common.collect.Multiset;)Lcom.google.common.collect.Multiset;")]
	internal class _3 : ViewMultiset
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024iterator1;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024iterator2;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _3 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
			[LineNumberTable(new byte[]
			{
				161, 220, 109, 113, 103, 121, 138, 109, 113, 103,
				115, 143, 98
			})]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Multiset.Entry computeNext()
			{
				if (val_0024iterator1.hasNext())
				{
					Multiset.Entry entry = (Multiset.Entry)val_0024iterator1.next();
					object element = entry.getElement();
					int n = entry.getCount() + this_00240.val_0024multiset2.count(element);
					Multiset.Entry result = immutableEntry(element, n);
					_ = null;
					return result;
				}
				while (val_0024iterator2.hasNext())
				{
					Multiset.Entry entry = (Multiset.Entry)val_0024iterator2.next();
					object element = entry.getElement();
					if (!this_00240.val_0024multiset1.contains(element))
					{
						Multiset.Entry result2 = immutableEntry(element, entry.getCount());
						_ = null;
						return result2;
					}
				}
				return (Multiset.Entry)endOfData();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(586)]
			internal _1(_3 P_0, Iterator P_1, Iterator P_2)
			{
				this_00240 = P_0;
				val_0024iterator1 = P_1;
				val_0024iterator2 = P_2;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(586)]
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

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Multiset val_0024multiset1;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Multiset val_0024multiset2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(551)]
		internal _3(Multiset P_0, Multiset P_1)
		{
			val_0024multiset1 = P_0;
			val_0024multiset2 = P_1;
			base._002Ector(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(554)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (val_0024multiset1.contains(P_0) || val_0024multiset2.contains(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(559)]
		public override bool isEmpty()
		{
			return (val_0024multiset1.isEmpty() && val_0024multiset2.isEmpty()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(564)]
		public override int size()
		{
			int result = IntMath.saturatedAdd(val_0024multiset1.size(), val_0024multiset2.size());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(569)]
		public override int count([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return val_0024multiset1.count(P_0) + val_0024multiset2.count(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TE;>;")]
		[LineNumberTable(574)]
		internal override Set createElementSet()
		{
			Sets.SetView result = Sets.union(val_0024multiset1.elementSet(), val_0024multiset2.elementSet());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(579)]
		internal override Iterator elementIterator()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("should never be called");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(new byte[] { 161, 214, 113, 113 })]
		internal override Iterator entryIterator()
		{
			Iterator iterator = val_0024multiset1.entrySet().iterator();
			Iterator iterator2 = val_0024multiset2.entrySet().iterator();
			_1 result = new _1(this, iterator, iterator2);
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/Multisets$ViewMultiset<TE;>;")]
	[EnclosingMethod(null, "difference", "(Lcom.google.common.collect.Multiset;Lcom.google.common.collect.Multiset;)Lcom.google.common.collect.Multiset;")]
	internal class _4 : ViewMultiset
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<TE;>;")]
		[EnclosingMethod(null, "elementIterator", "()Ljava.util.Iterator;")]
		internal class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024iterator1;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _4 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(644)]
			internal _1(_4 P_0, Iterator P_1)
			{
				this_00240 = P_0;
				val_0024iterator1 = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()TE;")]
			[LineNumberTable(new byte[] { 162, 22, 109, 113, 103, 121, 130, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal override object computeNext()
			{
				while (val_0024iterator1.hasNext())
				{
					Multiset.Entry entry = (Multiset.Entry)val_0024iterator1.next();
					object element = entry.getElement();
					if (entry.getCount() > this_00240.val_0024multiset2.count(element))
					{
						return element;
					}
				}
				object result = endOfData();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal class _2 : AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024iterator1;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal _4 this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(663)]
			internal _2(_4 P_0, Iterator P_1)
			{
				this_00240 = P_0;
				val_0024iterator1 = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
			[LineNumberTable(new byte[] { 162, 41, 109, 113, 103, 121, 100, 138, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Multiset.Entry computeNext()
			{
				while (val_0024iterator1.hasNext())
				{
					Multiset.Entry entry = (Multiset.Entry)val_0024iterator1.next();
					object element = entry.getElement();
					int num = entry.getCount() - this_00240.val_0024multiset2.count(element);
					if (num > 0)
					{
						Multiset.Entry result = immutableEntry(element, num);
						_ = null;
						return result;
					}
				}
				return (Multiset.Entry)endOfData();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(663)]
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

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Multiset val_0024multiset1;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Multiset val_0024multiset2;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(629)]
		internal _4(Multiset P_0, Multiset P_1)
		{
			val_0024multiset1 = P_0;
			val_0024multiset2 = P_1;
			base._002Ector(null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(new byte[] { 162, 36, 113 })]
		internal override Iterator entryIterator()
		{
			Iterator iterator = val_0024multiset1.entrySet().iterator();
			_2 result = new _2(this, iterator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 6, 109 })]
		public override int count([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int num = val_0024multiset1.count(P_0);
			int result = ((num != 0) ? java.lang.Math.max(0, num - val_0024multiset2.count(P_0)) : 0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(638)]
		public override void clear()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(new byte[] { 162, 17, 113 })]
		internal override Iterator elementIterator()
		{
			Iterator iterator = val_0024multiset1.entrySet().iterator();
			_1 result = new _1(this, iterator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(682)]
		internal override int distinctElements()
		{
			int result = Iterators.size(entryIterator());
			_ = null;
			return result;
		}
	}

	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/TransformedIterator<Lcom/google/common/collect/Multiset$Entry<TE;>;TE;>;")]
	[EnclosingMethod(null, "elementIterator", "(Ljava.util.Iterator;)Ljava.util.Iterator;")]
	internal class _5 : TransformedIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(980)]
		internal _5(Iterator P_0)
			: base(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multiset$Entry<TE;>;)TE;")]
		[LineNumberTable(984)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal virtual object transform(Multiset.Entry P_0)
		{
			object element = P_0.getElement();
			_ = null;
			return element;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(980)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal override object transform(object P_0)
		{
			object result = transform((Multiset.Entry)P_0);
			_ = null;
			return result;
		}
	}

	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 57, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)57,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class AbstractEntry : java.lang.Object, Multiset.Entry
	{
		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract int getCount();

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public abstract object getElement();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(837)]
		internal AbstractEntry()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 218, 104, 103, 111, 54, 161 })]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Multiset.Entry)
			{
				Multiset.Entry entry = (Multiset.Entry)P_0;
				return (getCount() == entry.getCount() && com.google.common.@base.Objects.equal(getElement(), entry.getElement())) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 232, 103 })]
		public override int hashCode()
		{
			object element = getElement();
			return ((element != null) ? java.lang.Object.instancehelper_hashCode(element) : 0) ^ getCount();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 244, 108, 103 })]
		public override string toString()
		{
			string text = java.lang.String.valueOf(getElement());
			int count = getCount();
			string result;
			if (count == 1)
			{
				result = text;
			}
			else
			{
				int num = 14 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
				num = num;
				result = new StringBuilder(num).append(text).append(" x ").append(count)
					.toString();
			}
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Ljava/lang/Object;Ljava/util/Comparator<Lcom/google/common/collect/Multiset$Entry<*>;>;")]
	internal sealed class DecreasingCount : java.lang.Object, Comparator
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static DecreasingCount INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multiset$Entry<*>;Lcom/google/common/collect/Multiset$Entry<*>;)I")]
		[LineNumberTable(1179)]
		public virtual int compare(Multiset.Entry P_0, Multiset.Entry P_1)
		{
			return P_1.getCount() - P_0.getCount();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1174)]
		private DecreasingCount()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(1174)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((Multiset.Entry)P_0, (Multiset.Entry)P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(1175)]
		static DecreasingCount()
		{
			INSTANCE = new DecreasingCount();
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

	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Sets$ImprovedAbstractSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 56, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)56,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class ElementSet : Sets.ImprovedAbstractSet
	{
		[Signature("()Lcom/google/common/collect/Multiset<TE;>;")]
		internal abstract Multiset multiset();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(989)]
		internal ElementSet()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 112, 109 })]
		public override void clear()
		{
			multiset().clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(999)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = multiset().contains(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(1004)]
		public override bool containsAll(Collection P_0)
		{
			bool result = multiset().containsAll(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1009)]
		public override bool isEmpty()
		{
			bool result = multiset().isEmpty();
			_ = null;
			return result;
		}

		[Signature("()Ljava/util/Iterator<TE;>;")]
		public abstract override Iterator iterator();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1017)]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return multiset().remove(P_0, int.MaxValue) > 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1022)]
		public override int size()
		{
			int result = multiset().entrySet().size();
			_ = null;
			return result;
		}
	}

	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Sets$ImprovedAbstractSet<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 46, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)46,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class EntrySet : Sets.ImprovedAbstractSet
	{
		[Signature("()Lcom/google/common/collect/Multiset<TE;>;")]
		internal abstract Multiset multiset();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1026)]
		internal EntrySet()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 150, 232, 69, 103, 105, 130, 114, 138 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Multiset.Entry)
			{
				Multiset.Entry entry = (Multiset.Entry)P_0;
				if (entry.getCount() <= 0)
				{
					return false;
				}
				int num = multiset().count(entry.getElement());
				return num == entry.getCount();
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 169, 104, 103, 103, 103, 195, 103, 172 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Multiset.Entry)
			{
				Multiset.Entry entry = (Multiset.Entry)P_0;
				object element = entry.getElement();
				int count = entry.getCount();
				if (count != 0)
				{
					Multiset multiset = this.multiset();
					bool result = multiset.setCount(element, count, 0);
					_ = null;
					return result;
				}
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 186, 109 })]
		public override void clear()
		{
			multiset().clear();
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Multisets$ViewMultiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 86, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)86,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class FilteredMultiset : ViewMultiset
	{
		[SpecialName]
		[Signature("Ljava/lang/Object;Lcom/google/common/base/Predicate<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[EnclosingMethod(null, "createEntrySet", "()Ljava.util.Set;")]
		[Implements(new string[] { "com.google.common.base.Predicate" })]
		internal class _1 : java.lang.Object, com.google.common.@base.Predicate, java.util.function.Predicate
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal FilteredMultiset this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/collect/Multiset$Entry<TE;>;)Z")]
			[LineNumberTable(351)]
			public virtual bool apply(Multiset.Entry P_0)
			{
				bool result = this_00240.predicate.apply(P_0.getElement());
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(348)]
			internal _1(FilteredMultiset P_0)
			{
				this_00240 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(348)]
			public virtual bool apply(object P_0)
			{
				bool result = apply((Multiset.Entry)P_0);
				_ = null;
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual bool test(object P_0)
			{
				return com.google.common.@base.Predicate._003Cdefault_003Etest(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Predicate and(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eand(this, P_0);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Predicate negate()
			{
				return java.util.function.Predicate._003Cdefault_003Enegate(this);
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual java.util.function.Predicate or(java.util.function.Predicate P_0)
			{
				return java.util.function.Predicate._003Cdefault_003Eor(this, P_0);
			}

			bool com.google.common.@base.Predicate.Predicate_003A_003Aequals(object P_0)
			{
				return java.lang.Object.instancehelper_equals(this, P_0);
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multiset<TE;>;")]
		internal Multiset unfiltered;

		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/base/Predicate<-TE;>;")]
		internal com.google.common.@base.Predicate predicate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multiset<TE;>;Lcom/google/common/base/Predicate<-TE;>;)V")]
		[LineNumberTable(new byte[] { 160, 210, 105, 113, 113 })]
		internal FilteredMultiset(Multiset P_0, com.google.common.@base.Predicate P_1)
			: base(null)
		{
			unfiltered = (Multiset)Preconditions.checkNotNull(P_0);
			predicate = (com.google.common.@base.Predicate)Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 249, 109, 132, 98, 147 })]
		public override int count([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			int num = unfiltered.count(P_0);
			if (num > 0)
			{
				return predicate.apply(P_0) ? num : 0;
			}
			return 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<TE;>;")]
		[LineNumberTable(331)]
		public new virtual UnmodifiableIterator iterator()
		{
			UnmodifiableIterator result = Iterators.filter(unfiltered.iterator(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TE;>;")]
		[LineNumberTable(336)]
		internal override Set createElementSet()
		{
			Set result = Sets.filter(unfiltered.elementSet(), predicate);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(341)]
		internal override Iterator elementIterator()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("should never be called");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(new byte[] { 160, 232, 102, 43 })]
		internal override Set createEntrySet()
		{
			Set result = Sets.filter(unfiltered.entrySet(), new _1(this));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(358)]
		internal override Iterator entryIterator()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("should never be called");
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)I")]
		[LineNumberTable(new byte[] { 161, 4, 103, 49, 133 })]
		public override int add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, int P_1)
		{
			Preconditions.checkArgument(predicate.apply(P_0), "Element %s does not match predicate %s", P_0, predicate);
			int result = unfiltered.add(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 11, 108, 99, 138 })]
		public override int remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, int P_1)
		{
			CollectPreconditions.checkNonnegative(P_1, "occurrences");
			if (P_1 == 0)
			{
				int result = count(P_0);
				_ = null;
				return result;
			}
			return contains(P_0) ? unfiltered.remove(P_0, P_1) : 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(320)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = iterator();
			_ = null;
			return result;
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Multisets$AbstractEntry<TE;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 49, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)49,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class ImmutableEntry : AbstractEntry, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TE;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		private object element;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int count;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)V")]
		[LineNumberTable(new byte[] { 160, 143, 104, 103, 103, 108 })]
		internal ImmutableEntry([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, int P_1)
		{
			element = P_0;
			count = P_1;
			CollectPreconditions.checkNonnegative(P_1, "count");
		}

		[Signature("()TE;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		public sealed override object getElement()
		{
			return element;
		}

		public sealed override int getCount()
		{
			return count;
		}

		[Signature("()Lcom/google/common/collect/Multisets$ImmutableEntry<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual ImmutableEntry nextInBucket()
		{
			return null;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ImmutableEntry(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Ljava/util/Iterator<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 66, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)66,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal sealed class MultisetIteratorImpl : java.lang.Object, Iterator
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multiset<TE;>;")]
		private Multiset multiset;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		private Iterator entryIterator;

		[Signature("Lcom/google/common/collect/Multiset$Entry<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Multiset.Entry currentEntry;

		private int laterCount;

		private int totalCount;

		private bool canRemove;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multiset<TE;>;Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;)V")]
		[LineNumberTable(new byte[] { 163, 208, 104, 103, 103 })]
		internal MultisetIteratorImpl(Multiset P_0, Iterator P_1)
		{
			multiset = P_0;
			entryIterator = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1097)]
		public virtual bool hasNext()
		{
			return (laterCount > 0 || entryIterator.hasNext()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TE;")]
		[LineNumberTable(new byte[] { 163, 221, 104, 139, 104, 118, 156, 110, 231, 69 })]
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
			if (laterCount == 0)
			{
				currentEntry = (Multiset.Entry)entryIterator.next();
				int count = currentEntry.getCount();
				laterCount = count;
				totalCount = count;
			}
			laterCount--;
			canRemove = true;
			object element = ((Multiset.Entry)java.util.Objects.requireNonNull(currentEntry)).getElement();
			_ = null;
			return element;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 239, 107, 105, 237, 70, 159, 2, 110, 103 })]
		public virtual void remove()
		{
			CollectPreconditions.checkRemove(canRemove);
			if (totalCount == 1)
			{
				entryIterator.remove();
			}
			else
			{
				multiset.remove(((Multiset.Entry)java.util.Objects.requireNonNull(currentEntry)).getElement());
			}
			totalCount--;
			canRemove = false;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[Serializable]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingMultiset<TE;>;Ljava/io/Serializable;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 98, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)98,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[Implements(new string[] { "java.io.Serializable" })]
	internal class UnmodifiableMultiset : ForwardingMultiset, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Multiset<+TE;>;")]
		internal new Multiset @delegate;

		[NonSerialized]
		[Signature("Ljava/util/Set<TE;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal new Set elementSet;

		[NonSerialized]
		[Signature("Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal new Set entrySet;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Multiset<+TE;>;)V")]
		[LineNumberTable(new byte[] { 77, 104, 103 })]
		internal UnmodifiableMultiset(Multiset P_0)
		{
			this.@delegate = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TE;>;")]
		[LineNumberTable(141)]
		internal virtual Set createElementSet()
		{
			Set result = Collections.unmodifiableSet(this.@delegate.elementSet());
			_ = null;
			return result;
		}

		[Signature("()Lcom/google/common/collect/Multiset<TE;>;")]
		protected internal override Multiset @delegate()
		{
			return this.@delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TE;>;")]
		[LineNumberTable(new byte[] { 96, 103 })]
		public override Set elementSet()
		{
			Set set = this.elementSet;
			Set result;
			if (set == null)
			{
				Set set2 = createElementSet();
				result = set2;
				this.elementSet = set2;
			}
			else
			{
				result = set;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
		[LineNumberTable(new byte[] { 105, 103, 163, 125, 225, 60 })]
		public override Set entrySet()
		{
			Set set = this.entrySet;
			Set result;
			if (set == null)
			{
				Set set2 = Collections.unmodifiableSet(this.@delegate.entrySet());
				result = set2;
				this.entrySet = set2;
			}
			else
			{
				result = set;
			}
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(165)]
		public override Iterator iterator()
		{
			UnmodifiableIterator result = Iterators.unmodifiableIterator(this.@delegate.iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;)Z")]
		[LineNumberTable(170)]
		public override bool add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)I")]
		[LineNumberTable(175)]
		public override int add([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, int P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<+TE;>;)Z")]
		[LineNumberTable(180)]
		public override bool addAll(Collection P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(185)]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(190)]
		public override int remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0, int P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(195)]
		public override bool removeAll(Collection P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(200)]
		public override bool retainAll(Collection P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(205)]
		public override void clear()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;I)I")]
		[LineNumberTable(210)]
		public override int setCount([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, int P_1)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TE;II)Z")]
		[LineNumberTable(215)]
		public override bool setCount([ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})] object P_0, int P_1, int P_2)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new UnsupportedOperationException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(123)]
		protected internal new virtual Collection @delegate()
		{
			Multiset result = this.@delegate();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(123)]
		protected internal new virtual object @delegate()
		{
			Multiset result = this.@delegate();
			_ = null;
			return result;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected virtual void GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
		}

		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			//ILSpy generated this explicit interface implementation from .override directive in GetObjectData
			this.GetObjectData(P_0, P_1);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected UnmodifiableMultiset(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMultiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 37, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)37,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal abstract class ViewMultiset : AbstractMultiset
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1187)]
		private ViewMultiset()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1191)]
		public override int size()
		{
			int result = linearTimeSizeImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 58, 109 })]
		public override void clear()
		{
			elementSet().clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TE;>;")]
		[LineNumberTable(1201)]
		public override Iterator iterator()
		{
			Iterator result = iteratorImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1206)]
		internal override int distinctElements()
		{
			int result = elementSet().size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1187)]
		internal ViewMultiset(_1 P_0)
			: this()
		{
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : ObjIntConsumer
	{
		private readonly Multiset arg_00241;

		internal ___003C_003EAnon0(Multiset P_0)
		{
			arg_00241 = P_0;
		}

		public void accept(object P_0, int P_1)
		{
			arg_00241.add(P_0, P_1);
			_ = null;
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
			Spliterator result = lambda_0024spliteratorImpl_00240((Multiset.Entry)P_0);
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
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;)Ljava/util/Spliterator<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		163,
		byte.MaxValue,
		108,
		206,
		141,
		230,
		58
	})]
	internal static Spliterator spliteratorImpl(Multiset P_0)
	{
		Spliterator spliterator = P_0.entrySet().spliterator();
		Spliterator result = CollectSpliterators.flatMap(spliterator, new ___003C_003EAnon1(), 0x40 | (spliterator.characteristics() & 0x510), P_0.size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;TE;I)I")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 68, 140, 136, 100, 100, 107, 100, 170 })]
	internal static int setCountImpl(Multiset P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, int P_2)
	{
		CollectPreconditions.checkNonnegative(P_2, "count");
		int num = P_0.count(P_1);
		int num2 = P_2 - num;
		if (num2 > 0)
		{
			P_0.add(P_1, num2);
		}
		else if (num2 < 0)
		{
			P_0.remove(P_1, -num2);
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;TE;II)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 85, 108, 140, 106, 105, 130 })]
	internal static bool setCountImpl(Multiset P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, int P_2, int P_3)
	{
		CollectPreconditions.checkNonnegative(P_2, "oldCount");
		CollectPreconditions.checkNonnegative(P_3, "newCount");
		if (P_0.count(P_1) == P_2)
		{
			P_0.setCount(P_1, P_3);
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;Ljava/util/Collection<+TE;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 23, 103, 103, 104, 111, 104, 130 })]
	internal static bool addAllImpl(Multiset P_0, Collection P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		if (P_1 is Multiset)
		{
			bool result = addAllImpl(P_0, cast(P_1));
			_ = null;
			return result;
		}
		if (P_1.isEmpty())
		{
			return false;
		}
		bool result2 = Iterators.addAll(P_0, P_1.iterator());
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multiset<*>;Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[] { 163, 47, 104, 109, 130 })]
	internal static bool removeAllImpl(Multiset P_0, Collection P_1)
	{
		object obj = ((!(P_1 is Multiset)) ? P_1 : ((Multiset)P_1).elementSet());
		bool result = P_0.elementSet().removeAll((obj == null) ? null : ((obj as Collection) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multiset<*>;Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[] { 163, 56, 135, 104, 109, 130 })]
	internal static bool retainAllImpl(Multiset P_0, Collection P_1)
	{
		Preconditions.checkNotNull(P_1);
		object obj = ((!(P_1 is Multiset)) ? P_1 : ((Multiset)P_1).elementSet());
		bool result = P_0.elementSet().retainAll((obj == null) ? null : ((obj as Collection) ?? throw new java.lang.IncompatibleClassChangeError()));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multiset<*>;Ljava/lang/Object;)Z")]
	[LineNumberTable(new byte[]
	{
		162, 252, 100, 130, 107, 231, 71, 127, 7, 130,
		127, 1, 116, 130, 98, 130
	})]
	internal static bool equalsImpl(Multiset P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_1 == P_0)
		{
			return true;
		}
		if (P_1 is Multiset)
		{
			Multiset multiset = (Multiset)P_1;
			if (P_0.size() != multiset.size() || P_0.entrySet().size() != multiset.entrySet().size())
			{
				return false;
			}
			Iterator iterator = multiset.entrySet().iterator();
			while (iterator.hasNext())
			{
				Multiset.Entry entry = (Multiset.Entry)iterator.next();
				if (P_0.count(entry.getElement()) != entry.getCount())
				{
					return false;
				}
			}
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;)Ljava/util/Iterator<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(1074)]
	internal static Iterator iteratorImpl(Multiset P_0)
	{
		MultisetIteratorImpl result = new MultisetIteratorImpl(P_0, P_0.entrySet().iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multiset<*>;)I")]
	[LineNumberTable(new byte[] { 164, 11, 99, 127, 1, 106, 98 })]
	internal static int linearTimeSizeImpl(Multiset P_0)
	{
		long num = 0L;
		Iterator iterator = P_0.entrySet().iterator();
		while (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			num += entry.getCount();
		}
		int result = Ints.saturatedCast(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(TE;I)Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(249)]
	public static Multiset.Entry immutableEntry([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e, int n)
	{
		ImmutableEntry result = new ImmutableEntry(e, n);
		_ = null;
		return result;
	}

	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Iterable<TT;>;)Lcom/google/common/collect/Multiset<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(1158)]
	internal static Multiset cast(Iterable P_0)
	{
		return (Multiset)P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;Lcom/google/common/base/Predicate<-TE;>;)Lcom/google/common/collect/Multiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[] { 160, 196, 168, 103, 109, 143 })]
	public static Multiset filter(Multiset unfiltered, com.google.common.@base.Predicate predicate)
	{
		if (unfiltered is FilteredMultiset)
		{
			FilteredMultiset filteredMultiset = (FilteredMultiset)unfiltered;
			com.google.common.@base.Predicate predicate2 = Predicates.and(filteredMultiset.predicate, predicate);
			FilteredMultiset result = new FilteredMultiset(filteredMultiset.unfiltered, predicate2);
			_ = null;
			return result;
		}
		FilteredMultiset result2 = new FilteredMultiset(unfiltered, predicate);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Iterator<Lcom/google/common/collect/Multiset$Entry<TE;>;>;)Ljava/util/Iterator<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(980)]
	internal static Iterator elementIterator(Iterator P_0)
	{
		_5 result = new _5(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Iterable<*>;)I")]
	[LineNumberTable(new byte[] { 161, 26, 104, 147 })]
	internal static int inferDistinctElements(Iterable P_0)
	{
		if (P_0 is Multiset)
		{
			int result = ((Multiset)P_0).elementSet().size();
			_ = null;
			return result;
		}
		return 11;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<+TE;>;)Lcom/google/common/collect/Multiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[] { 54, 144, 98, 130 })]
	public static Multiset unmodifiableMultiset(Multiset multiset)
	{
		if (multiset is UnmodifiableMultiset || multiset is ImmutableMultiset)
		{
			return multiset;
		}
		UnmodifiableMultiset result = new UnmodifiableMultiset((Multiset)Preconditions.checkNotNull(multiset));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;Lcom/google/common/collect/Multiset<*>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		162, 105, 103, 135, 108, 98, 104, 108, 109, 99,
		102, 100, 105, 110, 130, 98
	})]
	private static bool retainOccurrencesImpl(Multiset P_0, Multiset P_1)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Iterator iterator = P_0.entrySet().iterator();
		int result = 0;
		while (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			int num = P_1.count(entry.getElement());
			if (num == 0)
			{
				iterator.remove();
				result = 1;
			}
			else if (num < entry.getCount())
			{
				P_0.setCount(entry.getElement(), num);
				result = 1;
			}
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multiset<*>;Lcom/google/common/collect/Multiset<*>;)Z")]
	[LineNumberTable(new byte[]
	{
		162, 188, 103, 135, 98, 108, 104, 108, 109, 105,
		102, 100, 100, 110, 130, 98
	})]
	public static bool removeOccurrences(Multiset multisetToModify, Multiset occurrencesToRemove)
	{
		Preconditions.checkNotNull(multisetToModify);
		Preconditions.checkNotNull(occurrencesToRemove);
		int result = 0;
		Iterator iterator = multisetToModify.entrySet().iterator();
		while (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			int num = occurrencesToRemove.count(entry.getElement());
			if (num >= entry.getCount())
			{
				iterator.remove();
				result = 1;
			}
			else if (num > 0)
			{
				multisetToModify.remove(entry.getElement(), num);
				result = 1;
			}
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;Lcom/google/common/collect/Multiset<+TE;>;)Z")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[] { 163, 37, 104, 130, 120 })]
	private static bool addAllImpl(Multiset P_0, Multiset P_1)
	{
		if (P_1.isEmpty())
		{
			return false;
		}
		java.util.Objects.requireNonNull(P_0);
		P_1.forEachEntry(new ___003C_003EAnon0(P_0));
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(1140)]
	private static Spliterator lambda_0024spliteratorImpl_00240(Multiset.Entry P_0)
	{
		Spliterator result = Collections.nCopies(P_0.getCount(), P_0.getElement()).spliterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(65)]
	private Multisets()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;E:Ljava/lang/Object;M::Lcom/google/common/collect/Multiset<TE;>;>(Ljava/util/function/Function<-TT;TE;>;Ljava/util/function/ToIntFunction<-TT;>;Ljava/util/function/Supplier<TM;>;)Ljava/util/stream/Collector<TT;*TM;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 18, 0, 0, 0, 0, 117, 0, 0,
		18, 1, 0, 0, 0, 117, 0, 0
	})]
	[LineNumberTable(89)]
	public static Collector toMultiset(java.util.function.Function elementFunction, ToIntFunction countFunction, java.util.function.Supplier multisetSupplier)
	{
		Collector result = CollectCollectors.toMultiset(elementFunction, countFunction, multisetSupplier);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/ImmutableMultiset<TE;>;)Lcom/google/common/collect/Multiset<TE;>;")]
	[LineNumberTable(120)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static Multiset unmodifiableMultiset(ImmutableMultiset multiset)
	{
		return (Multiset)Preconditions.checkNotNull(multiset);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/SortedMultiset<TE;>;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(236)]
	public static SortedMultiset unmodifiableSortedMultiset(SortedMultiset sortedMultiset)
	{
		UnmodifiableSortedMultiset result = new UnmodifiableSortedMultiset((SortedMultiset)Preconditions.checkNotNull(sortedMultiset));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<+TE;>;Lcom/google/common/collect/Multiset<+TE;>;)Lcom/google/common/collect/Multiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 47, 103, 135 })]
	public static Multiset union(Multiset multiset1, Multiset multiset2)
	{
		Preconditions.checkNotNull(multiset1);
		Preconditions.checkNotNull(multiset2);
		_1 result = new _1(multiset1, multiset2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;Lcom/google/common/collect/Multiset<*>;)Lcom/google/common/collect/Multiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 119, 103, 135 })]
	public static Multiset intersection(Multiset multiset1, Multiset multiset2)
	{
		Preconditions.checkNotNull(multiset1);
		Preconditions.checkNotNull(multiset2);
		_2 result = new _2(multiset1, multiset2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<+TE;>;Lcom/google/common/collect/Multiset<+TE;>;)Lcom/google/common/collect/Multiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[] { 161, 177, 103, 167 })]
	public static Multiset sum(Multiset multiset1, Multiset multiset2)
	{
		Preconditions.checkNotNull(multiset1);
		Preconditions.checkNotNull(multiset2);
		_3 result = new _3(multiset1, multiset2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;Lcom/google/common/collect/Multiset<*>;)Lcom/google/common/collect/Multiset<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 117, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		161,
		byte.MaxValue,
		103,
		167
	})]
	public static Multiset difference(Multiset multiset1, Multiset multiset2)
	{
		Preconditions.checkNotNull(multiset1);
		Preconditions.checkNotNull(multiset2);
		_4 result = new _4(multiset1, multiset2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multiset<*>;Lcom/google/common/collect/Multiset<*>;)Z")]
	[LineNumberTable(new byte[] { 162, 69, 103, 103, 127, 1, 109, 105, 130, 98 })]
	public static bool containsOccurrences(Multiset superMultiset, Multiset subMultiset)
	{
		Preconditions.checkNotNull(superMultiset);
		Preconditions.checkNotNull(subMultiset);
		Iterator iterator = subMultiset.entrySet().iterator();
		while (iterator.hasNext())
		{
			Multiset.Entry entry = (Multiset.Entry)iterator.next();
			int num = superMultiset.count(entry.getElement());
			if (num < entry.getCount())
			{
				return false;
			}
		}
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multiset<*>;Lcom/google/common/collect/Multiset<*>;)Z")]
	[LineNumberTable(725)]
	public static bool retainOccurrences(Multiset multisetToModify, Multiset multisetToRetain)
	{
		bool result = retainOccurrencesImpl(multisetToModify, multisetToRetain);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Multiset<*>;Ljava/lang/Iterable<*>;)Z")]
	[LineNumberTable(new byte[] { 162, 150, 104, 143, 103, 103, 98, 118, 106, 98 })]
	public static bool removeOccurrences(Multiset multisetToModify, Iterable occurrencesToRemove)
	{
		if (occurrencesToRemove is Multiset)
		{
			bool result = removeOccurrences(multisetToModify, (Multiset)occurrencesToRemove);
			_ = null;
			return result;
		}
		Preconditions.checkNotNull(multisetToModify);
		Preconditions.checkNotNull(occurrencesToRemove);
		int num = 0;
		Iterator iterator = occurrencesToRemove.iterator();
		while (iterator.hasNext())
		{
			object obj = iterator.next();
			num |= (multisetToModify.remove(obj) ? 1 : 0);
		}
		return (byte)num != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Lcom/google/common/collect/Multiset<TE;>;)Lcom/google/common/collect/ImmutableMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 164, 31, 119, 107 })]
	public static ImmutableMultiset copyHighestCountFirst(Multiset multiset)
	{
		Multiset.Entry[] a = (Multiset.Entry[])multiset.entrySet().toArray(new Multiset.Entry[0]);
		Arrays.sort(a, DecreasingCount.INSTANCE);
		ImmutableMultiset result = ImmutableMultiset.copyFromEntries(Arrays.asList(a));
		_ = null;
		return result;
	}
}
