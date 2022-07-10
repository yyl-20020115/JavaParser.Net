using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K::Ljava/lang/Comparable;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/RangeMap<TK;TV;>;")]
[ConstantPool(new object[]
{
	(byte)193,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class TreeRangeMap : java.lang.Object, RangeMap
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Ljava/lang/Object;Lcom/google/common/collect/RangeMap<Ljava/lang/Comparable<*>;Ljava/lang/Object;>;")]
	[EnclosingMethod(null, null, null)]
	[ConstantPool(new object[]
	{
		(byte)76,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class _1 : java.lang.Object, RangeMap
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(387)]
		internal _1()
		{
		}

		[Signature("(Ljava/lang/Comparable<*>;)Ljava/lang/Object;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object get(IComparable P_0)
		{
			return null;
		}

		[Signature("(Ljava/lang/Comparable<*>;)Ljava/util/Map$Entry<Lcom/google/common/collect/Range<Ljava/lang/Comparable<*>;>;Ljava/lang/Object;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry getEntry(IComparable P_0)
		{
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Range<Ljava/lang/Comparable<*>;>;")]
		[LineNumberTable(402)]
		public virtual Range span()
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<Ljava/lang/Comparable<*>;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 161, 37, 103 })]
		public virtual void put(Range P_0, object P_1)
		{
			Preconditions.checkNotNull(P_0);
			string text = java.lang.String.valueOf(P_0);
			int num = 46 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("Cannot insert range ").append(text).append(" into an empty subRangeMap")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<Ljava/lang/Comparable<*>;>;Ljava/lang/Object;)V")]
		[LineNumberTable(new byte[] { 161, 44, 103 })]
		public virtual void putCoalescing(Range P_0, object P_1)
		{
			Preconditions.checkNotNull(P_0);
			string text = java.lang.String.valueOf(P_0);
			int num = 46 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("Cannot insert range ").append(text).append(" into an empty subRangeMap")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/RangeMap<Ljava/lang/Comparable<*>;Ljava/lang/Object;>;)V")]
		[LineNumberTable(new byte[] { 161, 51, 109, 176 })]
		public virtual void putAll(RangeMap P_0)
		{
			if (!P_0.asMapOfRanges().isEmpty())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new IllegalArgumentException("Cannot putAll(nonEmptyRangeMap) into an empty subRangeMap");
			}
		}

		public virtual void clear()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<Ljava/lang/Comparable<*>;>;)V")]
		[LineNumberTable(new byte[] { 161, 62, 103 })]
		public virtual void remove(Range P_0)
		{
			Preconditions.checkNotNull(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<Ljava/lang/Comparable<*>;>;Ljava/lang/Object;Ljava/util/function/BiFunction<-Ljava/lang/Object;-Ljava/lang/Object;+Ljava/lang/Object;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 22, 2, 2, 3, 1, 2, 0, 0,
			76, 0, 0, 22, 2, 2, 3, 2, 2, 0,
			0, 76, 0, 0
		})]
		[LineNumberTable(new byte[] { 161, 71, 103 })]
		public virtual void merge(Range P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1, BiFunction P_2)
		{
			Preconditions.checkNotNull(P_0);
			string text = java.lang.String.valueOf(P_0);
			int num = 45 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("Cannot merge range ").append(text).append(" into an empty subRangeMap")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<Lcom/google/common/collect/Range<Ljava/lang/Comparable<*>;>;Ljava/lang/Object;>;")]
		[LineNumberTable(448)]
		public virtual Map asMapOfRanges()
		{
			Map result = Collections.emptyMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<Lcom/google/common/collect/Range<Ljava/lang/Comparable<*>;>;Ljava/lang/Object;>;")]
		[LineNumberTable(453)]
		public virtual Map asDescendingMapOfRanges()
		{
			Map result = Collections.emptyMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<Ljava/lang/Comparable<*>;>;)Lcom/google/common/collect/RangeMap<Ljava/lang/Comparable<*>;Ljava/lang/Object;>;")]
		[LineNumberTable(new byte[] { 161, 88, 103 })]
		public virtual RangeMap subRangeMap(Range P_0)
		{
			Preconditions.checkNotNull(P_0);
			return this;
		}

		bool RangeMap.RangeMap_003A_003Aequals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
		}

		int RangeMap.RangeMap_003A_003AhashCode()
		{
			return java.lang.Object.instancehelper_hashCode(this);
		}

		string RangeMap.RangeMap_003A_003AtoString()
		{
			return java.lang.Object.instancehelper_toString(this);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/Maps$IteratorBasedAbstractMap<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	internal sealed class AsMapOfRanges : Maps.IteratorBasedAbstractMap
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/lang/Iterable<Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;>;")]
		internal Iterable entryIterable;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeRangeMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Iterable<Lcom/google/common/collect/TreeRangeMap$RangeMapEntry<TK;TV;>;>;)V")]
		[LineNumberTable(new byte[] { 160, 224, 111, 103 })]
		internal AsMapOfRanges(TreeRangeMap P_0, Iterable P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			entryIterable = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 160, 236, 104, 103, 124, 113, 169 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Range)
			{
				Range range = (Range)P_0;
				RangeMapEntry rangeMapEntry = (RangeMapEntry)access_0024000(this_00240).get(range.lowerBound);
				if (rangeMapEntry != null && rangeMapEntry.getKey().equals(range))
				{
					object value = rangeMapEntry.getValue();
					_ = null;
					return value;
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(344)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return get(P_0) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(362)]
		public override int size()
		{
			int result = access_0024000(this_00240).size();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;>;")]
		[LineNumberTable(367)]
		internal override Iterator entryIterator()
		{
			Iterator result = entryIterable.iterator();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<K::Ljava/lang/Comparable;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractMapEntry<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	internal sealed class RangeMapEntry : AbstractMapEntry
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Range<TK;>;")]
		private Range range;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("TV;")]
		private object value;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Z")]
		[LineNumberTable(94)]
		public virtual bool contains(IComparable P_0)
		{
			bool result = range.contains(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)V")]
		[LineNumberTable(new byte[] { 28, 104, 103, 103 })]
		internal RangeMapEntry(Range P_0, object P_1)
		{
			range = P_0;
			value = P_1;
		}

		[Signature("()Lcom/google/common/collect/Range<TK;>;")]
		public new virtual Range getKey()
		{
			return range;
		}

		[Signature("()TV;")]
		public override object getValue()
		{
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Cut<TK;>;Lcom/google/common/collect/Cut<TK;>;TV;)V")]
		[LineNumberTable(new byte[] { 25, 112 })]
		internal RangeMapEntry(Cut P_0, Cut P_1, object P_2)
			: this(Range.create(P_0, P_1), P_2)
		{
		}

		[Signature("()Lcom/google/common/collect/Cut<TK;>;")]
		[LineNumberTable(102)]
		internal virtual Cut getUpperBound()
		{
			return range.upperBound;
		}

		[Signature("()Lcom/google/common/collect/Cut<TK;>;")]
		[LineNumberTable(98)]
		internal virtual Cut getLowerBound()
		{
			return range.lowerBound;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(69)]
		public override object getKey()
		{
			Range key = getKey();
			_ = null;
			return key;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Ljava/lang/Object;Lcom/google/common/collect/RangeMap<TK;TV;>;")]
	[ConstantPool(new object[]
	{
		(byte)128,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	internal class SubRangeMap : java.lang.Object, RangeMap
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/TreeRangeMap<TK;TV;>.SubRangeMap.SubRangeMapAsMap;")]
		[EnclosingMethod(null, "asDescendingMapOfRanges", "()Ljava.util.Map;")]
		internal class _1 : SubRangeMapAsMap
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;>;")]
			[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
			internal new class _1 : AbstractIterator
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal Iterator val_0024backingItr;

				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal SubRangeMap._1 this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;")]
				[LineNumberTable(new byte[] { 161, 239, 109, 113, 127, 4, 140, 159, 10 })]
				[CheckForNull(new object[]
				{
					(byte)64,
					"Ljavax/annotation/CheckForNull;"
				})]
				protected internal new virtual Map.Entry computeNext()
				{
					if (val_0024backingItr.hasNext())
					{
						RangeMapEntry rangeMapEntry = (RangeMapEntry)val_0024backingItr.next();
						if (rangeMapEntry.getUpperBound().compareTo(access_0024300(this_00242.this_00241).lowerBound) <= 0)
						{
							return (Map.Entry)endOfData();
						}
						Map.Entry result = Maps.immutableEntry(rangeMapEntry.getKey().intersection(access_0024300(this_00242.this_00241)), rangeMapEntry.getValue());
						_ = null;
						return result;
					}
					return (Map.Entry)endOfData();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(604)]
				internal _1(SubRangeMap._1 P_0, Iterator P_1)
				{
					this_00242 = P_0;
					val_0024backingItr = P_1;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(604)]
				[CheckForNull(new object[]
				{
					(byte)64,
					"Ljavax/annotation/CheckForNull;"
				})]
				protected internal override object computeNext()
				{
					Map.Entry result = computeNext();
					_ = null;
					return result;
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal new SubRangeMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(591)]
			internal _1(SubRangeMap P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;>;")]
			[LineNumberTable(new byte[] { 161, 225, 114, 136, 107, 107, 112, 101, 101, 102 })]
			internal override Iterator entryIterator()
			{
				if (access_0024300(this_00241).isEmpty())
				{
					UnmodifiableIterator result = Iterators.emptyIterator();
					_ = null;
					return result;
				}
				Iterator iterator = access_0024000(this_00241.this_00240).headMap(access_0024300(this_00241).upperBound, inclusive: false).descendingMap().values()
					.iterator();
				_1 result2 = new _1(this, iterator);
				_ = null;
				return result2;
			}
		}

		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/util/AbstractMap<Lcom/google/common/collect/Range<TK;>;TV;>;")]
		internal class SubRangeMapAsMap : AbstractMap
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/Maps$KeySet<Lcom/google/common/collect/Range<TK;>;TV;>;")]
			[EnclosingMethod(null, "keySet", "()Ljava.util.Set;")]
			internal class _1 : Maps.KeySet
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal SubRangeMapAsMap this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(717)]
				internal _1(SubRangeMapAsMap P_0, Map P_1)
				{
					this_00242 = P_0;
					base._002Ector(P_1);
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(720)]
				public override bool remove([CheckForNull(new object[]
				{
					(byte)64,
					"Ljavax/annotation/CheckForNull;"
				})] object P_0)
				{
					return this_00242.remove(P_0) != null;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(Ljava/util/Collection<*>;)Z")]
				[LineNumberTable(725)]
				public override bool retainAll(Collection P_0)
				{
					bool result = access_0024400(this_00242, Predicates.compose(Predicates.not(Predicates.@in(P_0)), Maps.keyFunction()));
					_ = null;
					return result;
				}
			}

			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/Maps$EntrySet<Lcom/google/common/collect/Range<TK;>;TV;>;")]
			[EnclosingMethod(null, "entrySet", "()Ljava.util.Set;")]
			internal class _2 : Maps.EntrySet
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal SubRangeMapAsMap this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(732)]
				internal _2(SubRangeMapAsMap P_0)
				{
					this_00242 = P_0;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;>;")]
				[LineNumberTable(740)]
				public override Iterator iterator()
				{
					Iterator result = this_00242.entryIterator();
					_ = null;
					return result;
				}

				[Signature("()Ljava/util/Map<Lcom/google/common/collect/Range<TK;>;TV;>;")]
				internal override Map map()
				{
					return this_00242;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(Ljava/util/Collection<*>;)Z")]
				[LineNumberTable(745)]
				public override bool retainAll(Collection P_0)
				{
					bool result = access_0024400(this_00242, Predicates.not(Predicates.@in(P_0)));
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(750)]
				public override int size()
				{
					int result = Iterators.size(iterator());
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(755)]
				public override bool isEmpty()
				{
					return (!iterator().hasNext()) ? true : false;
				}
			}

			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;>;")]
			[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
			internal class _3 : AbstractIterator
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal Iterator val_0024backingItr;

				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal SubRangeMapAsMap this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(769)]
				internal _3(SubRangeMapAsMap P_0, Iterator P_1)
				{
					this_00242 = P_0;
					val_0024backingItr = P_1;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;")]
				[LineNumberTable(new byte[]
				{
					162, 148, 112, 113, 127, 4, 108, 159, 4, 159,
					10, 101
				})]
				[CheckForNull(new object[]
				{
					(byte)64,
					"Ljavax/annotation/CheckForNull;"
				})]
				protected internal new virtual Map.Entry computeNext()
				{
					while (val_0024backingItr.hasNext())
					{
						RangeMapEntry rangeMapEntry = (RangeMapEntry)val_0024backingItr.next();
						if (rangeMapEntry.getLowerBound().compareTo(access_0024300(this_00242.this_00241).upperBound) >= 0)
						{
							return (Map.Entry)endOfData();
						}
						if (rangeMapEntry.getUpperBound().compareTo(access_0024300(this_00242.this_00241).lowerBound) > 0)
						{
							Map.Entry result = Maps.immutableEntry(rangeMapEntry.getKey().intersection(access_0024300(this_00242.this_00241)), rangeMapEntry.getValue());
							_ = null;
							return result;
						}
					}
					return (Map.Entry)endOfData();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(769)]
				[CheckForNull(new object[]
				{
					(byte)64,
					"Ljavax/annotation/CheckForNull;"
				})]
				protected internal override object computeNext()
				{
					Map.Entry result = computeNext();
					_ = null;
					return result;
				}
			}

			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/Maps$Values<Lcom/google/common/collect/Range<TK;>;TV;>;")]
			[EnclosingMethod(null, "values", "()Ljava.util.Collection;")]
			internal class _4 : Maps.Values
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal SubRangeMapAsMap this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(790)]
				internal _4(SubRangeMapAsMap P_0, Map P_1)
				{
					this_00242 = P_0;
					base._002Ector(P_1);
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(Ljava/util/Collection<*>;)Z")]
				[LineNumberTable(793)]
				public override bool removeAll(Collection P_0)
				{
					bool result = access_0024400(this_00242, Predicates.compose(Predicates.@in(P_0), Maps.valueFunction()));
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(Ljava/util/Collection<*>;)Z")]
				[LineNumberTable(798)]
				public override bool retainAll(Collection P_0)
				{
					bool result = access_0024400(this_00242, Predicates.compose(Predicates.not(Predicates.@in(P_0)), Maps.valueFunction()));
					_ = null;
					return result;
				}
			}

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal SubRangeMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;>;)Z")]
			[LineNumberTable(new byte[]
			{
				162, 77, 102, 127, 1, 105, 146, 98, 123, 113,
				98
			})]
			private bool removeEntryIf(com.google.common.@base.Predicate P_0)
			{
				ArrayList arrayList = Lists.newArrayList();
				Iterator iterator = entrySet().iterator();
				while (iterator.hasNext())
				{
					Map.Entry entry = (Map.Entry)iterator.next();
					if (P_0.apply(entry))
					{
						((List)arrayList).add((object)(Range)entry.getKey());
					}
				}
				iterator = ((List)arrayList).iterator();
				while (iterator.hasNext())
				{
					Range rangeToRemove = (Range)iterator.next();
					this_00241.this_00240.remove(rangeToRemove);
				}
				return (!((List)arrayList).isEmpty()) ? true : false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/Object;)TV;")]
			[LineNumberTable(new byte[]
			{
				162,
				27,
				139,
				103,
				123,
				135,
				98,
				157,
				107,
				113,
				99,
				140,
				98,
				191,
				2,
				100,
				120,
				125,
				byte.MaxValue,
				6,
				69,
				2,
				97,
				130
			})]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public override object get([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				//Discarded unreachable code: IL_00e4
				try
				{
					if (P_0 is Range)
					{
						Range range = (Range)P_0;
						if (!access_0024300(this_00241).encloses(range) || range.isEmpty())
						{
							return null;
						}
						RangeMapEntry rangeMapEntry = null;
						if (range.lowerBound.compareTo(access_0024300(this_00241).lowerBound) == 0)
						{
							Map.Entry entry = access_0024000(this_00241.this_00240).floorEntry(range.lowerBound);
							if (entry != null)
							{
								rangeMapEntry = (RangeMapEntry)entry.getValue();
							}
						}
						else
						{
							rangeMapEntry = (RangeMapEntry)access_0024000(this_00241.this_00240).get(range.lowerBound);
						}
						if (rangeMapEntry != null && rangeMapEntry.getKey().isConnected(access_0024300(this_00241)) && rangeMapEntry.getKey().intersection(access_0024300(this_00241)).equals(range))
						{
							return rangeMapEntry.getValue();
						}
					}
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
					goto IL_00fb;
				}
				return null;
				IL_00fb:
				_ = null;
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;>;")]
			[LineNumberTable(732)]
			public override Set entrySet()
			{
				_2 result = new _2(this);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(642)]
			internal SubRangeMapAsMap(SubRangeMap P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(646)]
			public override bool containsKey([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				return get(P_0) != null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/lang/Object;)TV;")]
			[LineNumberTable(new byte[] { 162, 60, 104, 163, 108, 113, 130 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			public override object remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				object obj = get(P_0);
				if (obj != null)
				{
					Range rangeToRemove = (Range)java.util.Objects.requireNonNull(P_0);
					this_00241.this_00240.remove(rangeToRemove);
					return obj;
				}
				return null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 73, 109 })]
			public override void clear()
			{
				this_00241.clear();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Set<Lcom/google/common/collect/Range<TK;>;>;")]
			[LineNumberTable(717)]
			public override Set keySet()
			{
				_1 result = new _1(this, this);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;>;")]
			[LineNumberTable(new byte[] { 162, 135, 114, 136, 139, 63, 16, 139, 107, 119 })]
			internal virtual Iterator entryIterator()
			{
				if (access_0024300(this_00241).isEmpty())
				{
					UnmodifiableIterator result = Iterators.emptyIterator();
					_ = null;
					return result;
				}
				Cut fromKey = (Cut)MoreObjects.firstNonNull((Cut)access_0024000(this_00241.this_00240).floorKey(access_0024300(this_00241).lowerBound), access_0024300(this_00241).lowerBound);
				Iterator iterator = access_0024000(this_00241.this_00240).tailMap(fromKey, inclusive: true).values().iterator();
				_3 result2 = new _3(this, iterator);
				_ = null;
				return result2;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Collection<TV;>;")]
			[LineNumberTable(790)]
			public override Collection values()
			{
				_4 result = new _4(this, this);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
			[LineNumberTable(642)]
			internal static bool access_0024400(SubRangeMapAsMap P_0, com.google.common.@base.Predicate P_1)
			{
				bool result = P_0.removeEntryIf(P_1);
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Range<TK;>;")]
		private Range subRange;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeRangeMap this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TK;>;)V")]
		[LineNumberTable(new byte[] { 161, 97, 111, 103 })]
		internal SubRangeMap(TreeRangeMap P_0, Range P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			subRange = P_1;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(463)]
		internal static Range access_0024300(SubRangeMap P_0)
		{
			return P_0.subRange;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 182, 115 })]
		public virtual void clear()
		{
			this_00240.remove(subRange);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)V")]
		[LineNumberTable(new byte[] { 161, 149, 103, 49, 133, 111 })]
		public virtual void put(Range P_0, object P_1)
		{
			Preconditions.checkArgument(subRange.encloses(P_0), "Cannot put range %s into a subRangeMap(%s)", P_0, subRange);
			this_00240.put(P_0, P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<Lcom/google/common/collect/Range<TK;>;TV;>;")]
		[LineNumberTable(586)]
		public virtual Map asMapOfRanges()
		{
			SubRangeMapAsMap result = new SubRangeMapAsMap(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)TV;")]
		[LineNumberTable(474)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual object get(IComparable P_0)
		{
			return (!subRange.contains(P_0)) ? null : this_00240.get(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TK;)Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;")]
		[LineNumberTable(new byte[] { 161, 110, 110, 109, 99, 191, 5 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Map.Entry getEntry(IComparable P_0)
		{
			if (subRange.contains(P_0))
			{
				Map.Entry entry = this_00240.getEntry(P_0);
				if (entry != null)
				{
					Map.Entry result = Maps.immutableEntry(((Range)entry.getKey()).intersection(subRange), entry.getValue());
					_ = null;
					return result;
				}
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Range<TK;>;")]
		[LineNumberTable(new byte[]
		{
			161, 122, 102, 118, 100, 127, 3, 142, 127, 2,
			119, 235, 69, 102, 118, 99, 107, 127, 4, 142,
			145
		})]
		public virtual Range span()
		{
			Map.Entry entry = access_0024000(this_00240).floorEntry(subRange.lowerBound);
			Cut cut;
			if (entry != null && ((RangeMapEntry)entry.getValue()).getUpperBound().compareTo(subRange.lowerBound) > 0)
			{
				cut = subRange.lowerBound;
			}
			else
			{
				cut = (Cut)access_0024000(this_00240).ceilingKey(subRange.lowerBound);
				if (cut == null || cut.compareTo(subRange.upperBound) >= 0)
				{
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new NoSuchElementException();
				}
			}
			Map.Entry entry2 = access_0024000(this_00240).lowerEntry(subRange.upperBound);
			if (entry2 == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			Cut cut2 = ((((RangeMapEntry)entry2.getValue()).getUpperBound().compareTo(subRange.upperBound) < 0) ? ((RangeMapEntry)entry2.getValue()).getUpperBound() : subRange.upperBound);
			Range result = Range.create(cut, cut2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)V")]
		[LineNumberTable(new byte[] { 161, 156, 127, 1, 106, 161, 147, 117 })]
		public virtual void putCoalescing(Range P_0, object P_1)
		{
			if (access_0024000(this_00240).isEmpty() || !subRange.encloses(P_0))
			{
				put(P_0, P_1);
				return;
			}
			Range range = access_0024100(this_00240, P_0, Preconditions.checkNotNull(P_1));
			put(range.intersection(subRange), P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/RangeMap<TK;TV;>;)V")]
		[LineNumberTable(new byte[] { 161, 168, 109, 129, 103, 103, 49, 229, 69, 110 })]
		public virtual void putAll(RangeMap P_0)
		{
			if (!P_0.asMapOfRanges().isEmpty())
			{
				Range range = P_0.span();
				Preconditions.checkArgument(subRange.encloses(range), "Cannot putAll rangeMap with span %s into a subRangeMap(%s)", range, subRange);
				this_00240.putAll(P_0);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TK;>;)V")]
		[LineNumberTable(new byte[] { 161, 187, 110, 153 })]
		public virtual void remove(Range P_0)
		{
			if (P_0.isConnected(subRange))
			{
				this_00240.remove(P_0.intersection(subRange));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TK;>;TV;Ljava/util/function/BiFunction<-TV;-TV;+TV;>;)V")]
		[RuntimeVisibleTypeAnnotations(new byte[]
		{
			0, 2, 22, 2, 2, 3, 1, 2, 0, 0,
			128, 0, 0, 22, 2, 2, 3, 2, 2, 0,
			0, 128, 0, 0
		})]
		[LineNumberTable(new byte[] { 161, 197, 103, 49, 229, 69, 112 })]
		public virtual void merge(Range P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1, BiFunction P_2)
		{
			Preconditions.checkArgument(subRange.encloses(P_0), "Cannot merge range %s into a subRangeMap(%s)", P_0, subRange);
			this_00240.merge(P_0, P_1, P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TK;>;)Lcom/google/common/collect/RangeMap<TK;TV;>;")]
		[LineNumberTable(new byte[] { 161, 207, 110, 142 })]
		public virtual RangeMap subRangeMap(Range P_0)
		{
			if (!P_0.isConnected(subRange))
			{
				RangeMap result = access_0024200(this_00240);
				_ = null;
				return result;
			}
			RangeMap result2 = this_00240.subRangeMap(P_0.intersection(subRange));
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<Lcom/google/common/collect/Range<TK;>;TV;>;")]
		[LineNumberTable(591)]
		public virtual Map asDescendingMapOfRanges()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161,
			byte.MaxValue,
			104,
			103,
			148
		})]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is RangeMap)
			{
				RangeMap rangeMap = (RangeMap)P_0;
				bool result = asMapOfRanges().equals(rangeMap.asMapOfRanges());
				_ = null;
				return result;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(634)]
		public override int hashCode()
		{
			int result = asMapOfRanges().hashCode();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(639)]
		public override string toString()
		{
			string result = java.lang.Object.instancehelper_toString(asMapOfRanges());
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TK;>;Lcom/google/common/collect/TreeRangeMap$RangeMapEntry<TK;TV;>;>;")]
	private NavigableMap entriesByLowerBound;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/RangeMap<Ljava/lang/Comparable<*>;Ljava/lang/Object;>;")]
	private static RangeMap EMPTY_SUB_RANGE_MAP;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[Signature("()Lcom/google/common/collect/RangeMap<TK;TV;>;")]
	private RangeMap emptySubRangeMap()
	{
		return EMPTY_SUB_RANGE_MAP;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)Lcom/google/common/collect/Range<TK;>;")]
	[LineNumberTable(new byte[] { 98, 98, 108, 102, 137, 108, 102, 137 })]
	private Range coalescedRange(Range P_0, object P_1)
	{
		Range range = P_0;
		Map.Entry entry = entriesByLowerBound.lowerEntry(P_0.lowerBound);
		range = coalesce(range, P_1, entry);
		Map.Entry entry2 = entriesByLowerBound.floorEntry(P_0.upperBound);
		return coalesce(range, P_1, entry2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 15, 104, 107 })]
	private TreeRangeMap()
	{
		entriesByLowerBound = Maps.newTreeMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	[LineNumberTable(new byte[] { 66, 103, 107, 118, 140 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Map.Entry getEntry(IComparable key)
	{
		Map.Entry entry = entriesByLowerBound.floorEntry(Cut.belowValue(key));
		if (entry != null && ((RangeMapEntry)entry.getValue()).contains(key))
		{
			return (Map.Entry)entry.getValue();
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TK;>;)V")]
	[LineNumberTable(new byte[]
	{
		160, 87, 104, 225, 71, 108, 102, 134, 108, 148,
		180, 136, 102, 239, 61, 229, 70, 98, 140, 239,
		61, 229, 71, 108, 102, 131, 108, 180, 136, 102,
		239, 61, 229, 70, 126
	})]
	public virtual void remove(Range rangeToRemove)
	{
		if (rangeToRemove.isEmpty())
		{
			return;
		}
		Map.Entry entry = entriesByLowerBound.lowerEntry(rangeToRemove.lowerBound);
		if (entry != null)
		{
			RangeMapEntry rangeMapEntry = (RangeMapEntry)entry.getValue();
			if (rangeMapEntry.getUpperBound().compareTo(rangeToRemove.lowerBound) > 0)
			{
				if (rangeMapEntry.getUpperBound().compareTo(rangeToRemove.upperBound) > 0)
				{
					putRangeMapEntry(rangeToRemove.upperBound, rangeMapEntry.getUpperBound(), ((RangeMapEntry)entry.getValue()).getValue());
				}
				putRangeMapEntry(rangeMapEntry.getLowerBound(), rangeToRemove.lowerBound, ((RangeMapEntry)entry.getValue()).getValue());
			}
		}
		Map.Entry entry2 = entriesByLowerBound.lowerEntry(rangeToRemove.upperBound);
		if (entry2 != null)
		{
			RangeMapEntry rangeMapEntry2 = (RangeMapEntry)entry2.getValue();
			if (rangeMapEntry2.getUpperBound().compareTo(rangeToRemove.upperBound) > 0)
			{
				putRangeMapEntry(rangeToRemove.upperBound, rangeMapEntry2.getUpperBound(), ((RangeMapEntry)entry2.getValue()).getValue());
			}
		}
		entriesByLowerBound.subMap(rangeToRemove.lowerBound, rangeToRemove.upperBound).clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)V")]
	[LineNumberTable(new byte[] { 77, 104, 103, 103, 153 })]
	public virtual void put(Range range, object value)
	{
		if (!range.isEmpty())
		{
			Preconditions.checkNotNull(value);
			remove(range);
			entriesByLowerBound.put(range.lowerBound, new RangeMapEntry(range, value));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable;V:Ljava/lang/Object;>(Lcom/google/common/collect/Range<TK;>;TV;Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TK;>;Lcom/google/common/collect/TreeRangeMap$RangeMapEntry<TK;TV;>;>;)Lcom/google/common/collect/Range<TK;>;")]
	[LineNumberTable(new byte[] { 113, 100, 120, 119, 153 })]
	private static Range coalesce(Range P_0, object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] Map.Entry P_2)
	{
		if (P_2 != null && ((RangeMapEntry)P_2.getValue()).getKey().isConnected(P_0) && java.lang.Object.instancehelper_equals(((RangeMapEntry)P_2.getValue()).getValue(), P_1))
		{
			Range result = P_0.span(((RangeMapEntry)P_2.getValue()).getKey());
			_ = null;
			return result;
		}
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Cut<TK;>;Lcom/google/common/collect/Cut<TK;>;TV;)V")]
	[LineNumberTable(new byte[] { 160, 82, 117 })]
	private void putRangeMapEntry(Cut P_0, Cut P_1, object P_2)
	{
		entriesByLowerBound.put(P_0, new RangeMapEntry(P_0, P_1, P_2));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Cut<TK;>;)V")]
	[LineNumberTable(new byte[] { 160, 140, 109, 99, 161, 108, 111, 161, 115, 117 })]
	private void split(Cut P_0)
	{
		Map.Entry entry = entriesByLowerBound.lowerEntry(P_0);
		if (entry != null)
		{
			RangeMapEntry rangeMapEntry = (RangeMapEntry)entry.getValue();
			if (rangeMapEntry.getUpperBound().compareTo(P_0) > 0)
			{
				putRangeMapEntry(rangeMapEntry.getLowerBound(), P_0, rangeMapEntry.getValue());
				putRangeMapEntry(P_0, rangeMapEntry.getUpperBound(), rangeMapEntry.getValue());
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	[LineNumberTable(325)]
	public virtual Map asMapOfRanges()
	{
		AsMapOfRanges result = new AsMapOfRanges(this, entriesByLowerBound.values());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<K::Ljava/lang/Comparable;V:Ljava/lang/Object;>()Lcom/google/common/collect/TreeRangeMap<TK;TV;>;")]
	[LineNumberTable(62)]
	public static TreeRangeMap create()
	{
		TreeRangeMap result = new TreeRangeMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)TV;")]
	[LineNumberTable(new byte[] { 59, 104 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object get(IComparable key)
	{
		object result = getEntry(key)?.getValue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)V")]
	[LineNumberTable(new byte[] { 87, 109, 106, 161, 110, 106 })]
	public virtual void putCoalescing(Range range, object value)
	{
		if (entriesByLowerBound.isEmpty())
		{
			put(range, value);
			return;
		}
		Range range2 = coalescedRange(range, Preconditions.checkNotNull(value));
		put(range2, value);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/RangeMap<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 123, 127, 6, 119, 98 })]
	public virtual void putAll(RangeMap rangeMap)
	{
		Iterator iterator = rangeMap.asMapOfRanges().entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			put((Range)entry.getKey(), entry.getValue());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 66, 109 })]
	public virtual void clear()
	{
		entriesByLowerBound.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Range<TK;>;")]
	[LineNumberTable(new byte[] { 160, 71, 108, 140, 102, 139, 97, 63, 10 })]
	public virtual Range span()
	{
		Map.Entry entry = entriesByLowerBound.firstEntry();
		Map.Entry entry2 = entriesByLowerBound.lastEntry();
		if (entry == null || entry2 == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		Range result = Range.create(((RangeMapEntry)entry.getValue()).getKey().lowerBound, ((RangeMapEntry)entry2.getValue()).getKey().upperBound);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TK;>;TV;Ljava/util/function/BiFunction<-TV;-TV;+TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 22, 2, 2, 3, 1, 2, 0, 0,
		193, 0, 0, 22, 2, 2, 3, 2, 2, 0,
		0, 193, 0, 0
	})]
	[LineNumberTable(new byte[]
	{
		160, 159, 103, 135, 104, 129, 108, 204, 114, 171,
		102, 102, 97, 102, 103, 104, 119, 105, 106, 145,
		104, 98, 110, 245, 69, 103, 107, 109, 122, 100,
		136, 132, 31, 8, 198, 133, 115
	})]
	public virtual void merge(Range range, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value, BiFunction remappingFunction)
	{
		Preconditions.checkNotNull(range);
		Preconditions.checkNotNull(remappingFunction);
		if (range.isEmpty())
		{
			return;
		}
		split(range.lowerBound);
		split(range.upperBound);
		Set set = entriesByLowerBound.subMap(range.lowerBound, range.upperBound).entrySet();
		ImmutableMap.Builder builder = ImmutableMap.builder();
		Iterator iterator;
		if (value != null)
		{
			iterator = set.iterator();
			Cut cut = range.lowerBound;
			while (iterator.hasNext())
			{
				RangeMapEntry rangeMapEntry = (RangeMapEntry)((Map.Entry)iterator.next()).getValue();
				Cut lowerBound = rangeMapEntry.getLowerBound();
				if (!cut.equals(lowerBound))
				{
					builder.put(cut, new RangeMapEntry(cut, lowerBound, value));
				}
				cut = rangeMapEntry.getUpperBound();
			}
			if (!cut.equals(range.upperBound))
			{
				builder.put(cut, new RangeMapEntry(cut, range.upperBound, value));
			}
		}
		iterator = set.iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			object obj = remappingFunction.apply(((RangeMapEntry)entry.getValue()).getValue(), value);
			if (obj == null)
			{
				iterator.remove();
			}
			else
			{
				entry.setValue(new RangeMapEntry(((RangeMapEntry)entry.getValue()).getLowerBound(), ((RangeMapEntry)entry.getValue()).getUpperBound(), obj));
			}
		}
		entriesByLowerBound.putAll(builder.build());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	[LineNumberTable(330)]
	public virtual Map asDescendingMapOfRanges()
	{
		AsMapOfRanges result = new AsMapOfRanges(this, entriesByLowerBound.descendingMap().values());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TK;>;)Lcom/google/common/collect/RangeMap<TK;TV;>;")]
	[LineNumberTable(new byte[] { 161, 3, 109, 130 })]
	public virtual RangeMap subRangeMap(Range subRange)
	{
		if (subRange.equals(Range.all()))
		{
			return this;
		}
		SubRangeMap result = new SubRangeMap(this, subRange);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 181, 104, 103, 148 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object o)
	{
		if (o is RangeMap)
		{
			RangeMap rangeMap = (RangeMap)o;
			bool result = asMapOfRanges().equals(rangeMap.asMapOfRanges());
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(816)]
	public override int hashCode()
	{
		int result = asMapOfRanges().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(821)]
	public override string toString()
	{
		string result = java.lang.Object.instancehelper_toString(entriesByLowerBound.values());
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(57)]
	internal static NavigableMap access_0024000(TreeRangeMap P_0)
	{
		return P_0.entriesByLowerBound;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(57)]
	internal static Range access_0024100(TreeRangeMap P_0, Range P_1, object P_2)
	{
		Range result = P_0.coalescedRange(P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(57)]
	internal static RangeMap access_0024200(TreeRangeMap P_0)
	{
		RangeMap result = P_0.emptySubRangeMap();
		_ = null;
		return result;
	}

	[LineNumberTable(386)]
	static TreeRangeMap()
	{
		EMPTY_SUB_RANGE_MAP = new _1();
	}
}
