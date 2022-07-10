using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using ikvm.lang;
using IKVM.Runtime;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<C::Ljava/lang/Comparable<*>;>Lcom/google/common/collect/AbstractRangeSet<TC;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public class TreeRangeSet : AbstractRangeSet, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ForwardingCollection<Lcom/google/common/collect/Range<TC;>;>;Ljava/util/Set<Lcom/google/common/collect/Range<TC;>;>;")]
	[Implements(new string[] { "java.util.Set" })]
	internal sealed class AsRanges : ForwardingCollection, Set, Collection, Iterable, IEnumerable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Collection<Lcom/google/common/collect/Range<TC;>;>;")]
		internal new Collection @delegate;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<Lcom/google/common/collect/Range<TC;>;>;)V")]
		[LineNumberTable(new byte[] { 51, 104, 103 })]
		internal AsRanges(TreeRangeSet P_0, Collection P_1)
		{
			this.@delegate = P_1;
		}

		[Signature("()Ljava/util/Collection<Lcom/google/common/collect/Range<TC;>;>;")]
		protected internal override Collection @delegate()
		{
			return this.@delegate;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(112)]
		public override int hashCode()
		{
			int result = Sets.hashCodeImpl(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(117)]
		public override bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = Sets.equalsImpl(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(97)]
		protected internal new virtual object @delegate()
		{
			Collection result = this.@delegate();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override void forEach(Consumer P_0)
		{
			Iterable._003Cdefault_003EforEach(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override Spliterator spliterator()
		{
			return Set._003Cdefault_003Espliterator(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override bool removeIf(java.util.function.Predicate P_0)
		{
			return Collection._003Cdefault_003EremoveIf(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override Stream stream()
		{
			return Collection._003Cdefault_003Estream(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public override Stream parallelStream()
		{
			return Collection._003Cdefault_003EparallelStream(this);
		}

		[SpecialName]
		[HideFromJava]
		IEnumerator IEnumerable.GetEnumerator()
		{
			return new IterableEnumerator(this);
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/TreeRangeSet<TC;>;")]
	internal sealed class Complement : TreeRangeSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeRangeSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 34, 103, 116 })]
		internal Complement(TreeRangeSet P_0)
		{
			this_00240 = P_0;
			base._002Ector(new ComplementRangesByLowerBound(P_0.rangesByLowerBound), null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
		[LineNumberTable(new byte[] { 162, 40, 110 })]
		public override void add(Range P_0)
		{
			this_00240.remove(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
		[LineNumberTable(new byte[] { 162, 45, 110 })]
		public override void remove(Range P_0)
		{
			this_00240.add(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Z")]
		[LineNumberTable(676)]
		public override bool contains(IComparable P_0)
		{
			return (!this_00240.contains(P_0)) ? true : false;
		}

		[Signature("()Lcom/google/common/collect/RangeSet<TC;>;")]
		public override RangeSet complement()
		{
			return this_00240;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Complement(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<C::Ljava/lang/Comparable<*>;>Lcom/google/common/collect/AbstractNavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
	internal sealed class ComplementRangesByLowerBound : AbstractNavigableMap
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal new class _1 : AbstractIterator
		{
			[Signature("Lcom/google/common/collect/Cut<TC;>;")]
			internal Cut nextComplementRangeLowerBound;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Cut val_0024firstComplementRangeLowerBound;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal PeekingIterator val_0024positiveItr;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ComplementRangesByLowerBound this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
			[LineNumberTable(new byte[]
			{
				161, 178, 127, 4, 103, 172, 109, 113, 114, 108,
				98, 113, 139
			})]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Map.Entry computeNext()
			{
				if (access_0024100(this_00240).upperBound.isLessThan(nextComplementRangeLowerBound) || nextComplementRangeLowerBound == Cut.aboveAll())
				{
					return (Map.Entry)endOfData();
				}
				Range range2;
				if (val_0024positiveItr.hasNext())
				{
					Range range = (Range)val_0024positiveItr.next();
					range2 = Range.create(nextComplementRangeLowerBound, range.lowerBound);
					nextComplementRangeLowerBound = range.upperBound;
				}
				else
				{
					range2 = Range.create(nextComplementRangeLowerBound, Cut.aboveAll());
					nextComplementRangeLowerBound = Cut.aboveAll();
				}
				Map.Entry result = Maps.immutableEntry(range2.lowerBound, range2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 172, 125 })]
			internal _1(ComplementRangesByLowerBound P_0, Cut P_1, PeekingIterator P_2)
			{
				this_00240 = P_0;
				val_0024firstComplementRangeLowerBound = P_1;
				val_0024positiveItr = P_2;
				base._002Ector();
				nextComplementRangeLowerBound = val_0024firstComplementRangeLowerBound;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(542)]
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
		[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[EnclosingMethod(null, "descendingEntryIterator", "()Ljava.util.Iterator;")]
		internal class _2 : AbstractIterator
		{
			[Signature("Lcom/google/common/collect/Cut<TC;>;")]
			internal Cut nextComplementRangeUpperBound;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Cut val_0024firstComplementRangeUpperBound;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal PeekingIterator val_0024positiveItr;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ComplementRangesByLowerBound this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 233, 125 })]
			internal _2(ComplementRangesByLowerBound P_0, Cut P_1, PeekingIterator P_2)
			{
				this_00240 = P_0;
				val_0024firstComplementRangeUpperBound = P_1;
				val_0024positiveItr = P_2;
				base._002Ector();
				nextComplementRangeUpperBound = val_0024firstComplementRangeUpperBound;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
			[LineNumberTable(new byte[]
			{
				161, 239, 109, 108, 109, 113, 108, 102, 108, 125,
				143, 126, 113, 107, 142
			})]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Map.Entry computeNext()
			{
				if (nextComplementRangeUpperBound == Cut.belowAll())
				{
					return (Map.Entry)endOfData();
				}
				if (val_0024positiveItr.hasNext())
				{
					Range range = (Range)val_0024positiveItr.next();
					Range range2 = Range.create(range.upperBound, nextComplementRangeUpperBound);
					nextComplementRangeUpperBound = range.lowerBound;
					if (access_0024100(this_00240).lowerBound.isLessThan(range2.lowerBound))
					{
						Map.Entry result = Maps.immutableEntry(range2.lowerBound, range2);
						_ = null;
						return result;
					}
				}
				else if (access_0024100(this_00240).lowerBound.isLessThan(Cut.belowAll()))
				{
					Range range = Range.create(Cut.belowAll(), nextComplementRangeUpperBound);
					nextComplementRangeUpperBound = Cut.belowAll();
					Map.Entry result2 = Maps.immutableEntry(Cut.belowAll(), range);
					_ = null;
					return result2;
				}
				return (Map.Entry)endOfData();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(603)]
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

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		private NavigableMap positiveRangesByLowerBound;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		private NavigableMap positiveRangesByUpperBound;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Range<Lcom/google/common/collect/Cut<TC;>;>;")]
		private Range complementLowerBoundWindow;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;)V")]
		[LineNumberTable(new byte[] { 161, 97, 110 })]
		internal ComplementRangesByLowerBound(NavigableMap P_0)
			: this(P_0, Range.all())
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(454)]
		internal static Range access_0024100(ComplementRangesByLowerBound P_0)
		{
			return P_0.complementLowerBoundWindow;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;Lcom/google/common/collect/Range<Lcom/google/common/collect/Cut<TC;>;>;)V")]
		[LineNumberTable(new byte[] { 161, 101, 104, 103, 108, 103 })]
		private ComplementRangesByLowerBound(NavigableMap P_0, Range P_1)
		{
			positiveRangesByLowerBound = P_0;
			positiveRangesByUpperBound = new RangesByUpperBound(P_0);
			complementLowerBoundWindow = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<Lcom/google/common/collect/Cut<TC;>;>;)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(new byte[] { 161, 108, 110, 136, 110 })]
		private NavigableMap subMap(Range P_0)
		{
			if (!complementLowerBoundWindow.isConnected(P_0))
			{
				ImmutableSortedMap result = ImmutableSortedMap.of();
				_ = null;
				return result;
			}
			P_0 = P_0.intersection(complementLowerBoundWindow);
			ComplementRangesByLowerBound result2 = new ComplementRangesByLowerBound(positiveRangesByLowerBound, P_0);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[LineNumberTable(new byte[]
		{
			161, 152, 109, 172, 112, 12, 165, 136, 140, 140,
			115, 126, 104, 104, 147, 136
		})]
		internal override Iterator entryIterator()
		{
			Collection collection = ((!complementLowerBoundWindow.hasLowerBound()) ? positiveRangesByUpperBound.values() : positiveRangesByUpperBound.tailMap((Cut)complementLowerBoundWindow.lowerEndpoint(), complementLowerBoundWindow.lowerBoundType() == BoundType.___003C_003ECLOSED).values());
			PeekingIterator peekingIterator = Iterators.peekingIterator(collection.iterator());
			Cut cut;
			if (complementLowerBoundWindow.contains(Cut.belowAll()) && (!peekingIterator.hasNext() || ((Range)peekingIterator.peek()).lowerBound != Cut.belowAll()))
			{
				cut = Cut.belowAll();
			}
			else
			{
				if (!peekingIterator.hasNext())
				{
					UnmodifiableIterator result = Iterators.emptyIterator();
					_ = null;
					return result;
				}
				cut = ((Range)peekingIterator.next()).upperBound;
			}
			_1 result2 = new _1(this, cut, peekingIterator);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Cut<TC;>;Z)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(502)]
		public virtual NavigableMap tailMap(Cut P_0, bool P_1)
		{
			NavigableMap result = subMap(Range.downTo(P_0, BoundType.forBoolean(P_1)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Lcom/google/common/collect/Range<TC;>;")]
		[LineNumberTable(new byte[]
		{
			162, 11, 171, 135, 110, 118, 223, 9, 2, 97,
			162
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Range get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_0045
			if (P_0 is Cut)
			{
				try
				{
					Cut cut = (Cut)P_0;
					Map.Entry entry = tailMap(cut, true).firstEntry();
					if (entry != null && ((Cut)entry.getKey()).equals(cut))
					{
						return (Range)entry.getValue();
					}
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
					goto IL_005a;
				}
			}
			return null;
			IL_005a:
			_ = null;
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Cut<TC;>;Z)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(497)]
		public virtual NavigableMap headMap(Cut P_0, bool P_1)
		{
			NavigableMap result = subMap(Range.upTo(P_0, BoundType.forBoolean(P_1)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Cut<TC;>;ZLcom/google/common/collect/Cut<TC;>;Z)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(new byte[] { 159, 20, 101, 131, 103, 5, 37 })]
		public virtual NavigableMap subMap(Cut P_0, bool P_1, Cut P_2, bool P_3)
		{
			NavigableMap result = subMap(Range.range(P_0, BoundType.forBoolean(P_1), P_2, BoundType.forBoolean(P_3)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-Lcom/google/common/collect/Cut<TC;>;>;")]
		[LineNumberTable(507)]
		public override Comparator comparator()
		{
			Ordering result = Ordering.natural();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[LineNumberTable(new byte[]
		{
			161, 207, 109, 114, 102, 102, 109, 113, 168, 101,
			101, 101, 229, 59, 230, 71, 136, 119, 114, 127,
			4, 120, 108, 136, 150, 114
		})]
		internal override Iterator descendingEntryIterator()
		{
			Cut toKey = ((!complementLowerBoundWindow.hasUpperBound()) ? Cut.aboveAll() : ((Cut)complementLowerBoundWindow.upperEndpoint()));
			int inclusive = ((complementLowerBoundWindow.hasUpperBound() && complementLowerBoundWindow.upperBoundType() == BoundType.___003C_003ECLOSED) ? 1 : 0);
			PeekingIterator peekingIterator = Iterators.peekingIterator(positiveRangesByUpperBound.headMap(toKey, (byte)inclusive != 0).descendingMap().values()
				.iterator());
			Cut first;
			if (peekingIterator.hasNext())
			{
				first = ((((Range)peekingIterator.peek()).upperBound != Cut.aboveAll()) ? ((Cut)positiveRangesByLowerBound.higherKey(((Range)peekingIterator.peek()).upperBound)) : ((Range)peekingIterator.next()).lowerBound);
			}
			else
			{
				if (!complementLowerBoundWindow.contains(Cut.belowAll()) || positiveRangesByLowerBound.containsKey(Cut.belowAll()))
				{
					UnmodifiableIterator result = Iterators.emptyIterator();
					_ = null;
					return result;
				}
				first = (Cut)positiveRangesByLowerBound.higherKey(Cut.belowAll());
			}
			Cut cut = (Cut)MoreObjects.firstNonNull(first, Cut.aboveAll());
			_2 result2 = new _2(this, cut, peekingIterator);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(631)]
		public override int size()
		{
			int result = Iterators.size(entryIterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(655)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return get(P_0) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(454)]
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
			Range result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(454)]
		public override NavigableMap tailMap(object P_0, bool P_1)
		{
			NavigableMap result = tailMap((Cut)P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(454)]
		public override NavigableMap headMap(object P_0, bool P_1)
		{
			NavigableMap result = headMap((Cut)P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(454)]
		public override NavigableMap subMap(object P_0, bool P_1, object P_2, bool P_3)
		{
			NavigableMap result = subMap((Cut)P_0, P_1, (Cut)P_2, P_3);
			_ = null;
			return result;
		}
	}

	[Signature("<C::Ljava/lang/Comparable<*>;>Lcom/google/common/collect/AbstractNavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
	internal sealed class RangesByUpperBound : AbstractNavigableMap
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal new class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024backingItr;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal RangesByUpperBound this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
			[LineNumberTable(new byte[] { 161, 23, 109, 140, 113, 125, 140 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Map.Entry computeNext()
			{
				if (!val_0024backingItr.hasNext())
				{
					return (Map.Entry)endOfData();
				}
				Range range = (Range)val_0024backingItr.next();
				if (access_0024000(this_00240).upperBound.isLessThan(range.upperBound))
				{
					return (Map.Entry)endOfData();
				}
				Map.Entry result = Maps.immutableEntry(range.upperBound, range);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(389)]
			internal _1(RangesByUpperBound P_0, Iterator P_1)
			{
				this_00240 = P_0;
				val_0024backingItr = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(389)]
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
		[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[EnclosingMethod(null, "descendingEntryIterator", "()Ljava.util.Iterator;")]
		internal class _2 : AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal PeekingIterator val_0024backingItr;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal RangesByUpperBound this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(423)]
			internal _2(RangesByUpperBound P_0, PeekingIterator P_1)
			{
				this_00240 = P_0;
				val_0024backingItr = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
			[LineNumberTable(new byte[] { 161, 57, 109, 140, 113, 125, 110, 11 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Map.Entry computeNext()
			{
				if (!val_0024backingItr.hasNext())
				{
					return (Map.Entry)endOfData();
				}
				Range range = (Range)val_0024backingItr.next();
				return (!access_0024000(this_00240).lowerBound.isLessThan(range.upperBound)) ? ((Map.Entry)endOfData()) : Maps.immutableEntry(range.upperBound, range);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(423)]
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

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		private NavigableMap rangesByLowerBound;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Range<Lcom/google/common/collect/Cut<TC;>;>;")]
		private Range upperBoundWindow;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;)V")]
		[LineNumberTable(new byte[] { 160, 182, 104, 103, 107 })]
		internal RangesByUpperBound(NavigableMap P_0)
		{
			rangesByLowerBound = P_0;
			upperBoundWindow = Range.all();
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(286)]
		internal static Range access_0024000(RangesByUpperBound P_0)
		{
			return P_0.upperBoundWindow;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;Lcom/google/common/collect/Range<Lcom/google/common/collect/Cut<TC;>;>;)V")]
		[LineNumberTable(new byte[] { 160, 188, 104, 103, 103 })]
		private RangesByUpperBound(NavigableMap P_0, Range P_1)
		{
			rangesByLowerBound = P_0;
			upperBoundWindow = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<Lcom/google/common/collect/Cut<TC;>;>;)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(new byte[] { 160, 194, 110, 154 })]
		private NavigableMap subMap(Range P_0)
		{
			if (P_0.isConnected(upperBoundWindow))
			{
				RangesByUpperBound result = new RangesByUpperBound(rangesByLowerBound, P_0.intersection(upperBoundWindow));
				_ = null;
				return result;
			}
			ImmutableSortedMap result2 = ImmutableSortedMap.of();
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Lcom/google/common/collect/Range<TC;>;")]
		[LineNumberTable(new byte[]
		{
			160, 233, 171, 103, 110, 132, 109, 123, 223, 11,
			2, 97, 162
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Range get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_005b
			if (P_0 is Cut)
			{
				try
				{
					Cut cut = (Cut)P_0;
					if (!upperBoundWindow.contains(cut))
					{
						return null;
					}
					Map.Entry entry = rangesByLowerBound.lowerEntry(cut);
					if (entry != null && ((Range)entry.getValue()).upperBound.equals(cut))
					{
						return (Range)entry.getValue();
					}
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
					goto IL_0072;
				}
			}
			return null;
			IL_0072:
			_ = null;
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[LineNumberTable(new byte[]
		{
			161, 2, 109, 150, 108, 112, 99, 118, 127, 3,
			159, 5, 140, 112, 101, 166
		})]
		internal override Iterator entryIterator()
		{
			Iterator iterator;
			if (!upperBoundWindow.hasLowerBound())
			{
				iterator = rangesByLowerBound.values().iterator();
			}
			else
			{
				Map.Entry entry = rangesByLowerBound.lowerEntry((Cut)upperBoundWindow.lowerEndpoint());
				iterator = ((entry == null) ? rangesByLowerBound.values().iterator() : ((!upperBoundWindow.lowerBound.isLessThan(((Range)entry.getValue()).upperBound)) ? rangesByLowerBound.tailMap((Cut)upperBoundWindow.lowerEndpoint(), inclusive: true).values().iterator() : rangesByLowerBound.tailMap((Cut)entry.getKey(), inclusive: true).values().iterator()));
			}
			_1 result = new _1(this, iterator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Cut<TC;>;Z)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(331)]
		public virtual NavigableMap tailMap(Cut P_0, bool P_1)
		{
			NavigableMap result = subMap(Range.downTo(P_0, BoundType.forBoolean(P_1)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Cut<TC;>;Z)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(326)]
		public virtual NavigableMap headMap(Cut P_0, bool P_1)
		{
			NavigableMap result = subMap(Range.upTo(P_0, BoundType.forBoolean(P_1)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Cut<TC;>;ZLcom/google/common/collect/Cut<TC;>;Z)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(new byte[] { 159, 63, 133, 131, 103, 5, 37 })]
		public virtual NavigableMap subMap(Cut P_0, bool P_1, Cut P_2, bool P_3)
		{
			NavigableMap result = subMap(Range.range(P_0, BoundType.forBoolean(P_1), P_2, BoundType.forBoolean(P_3)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-Lcom/google/common/collect/Cut<TC;>;>;")]
		[LineNumberTable(336)]
		public override Comparator comparator()
		{
			Ordering result = Ordering.natural();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(341)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return get(P_0) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[LineNumberTable(new byte[]
		{
			161, 39, 109, 140, 112, 101, 136, 145, 108, 116,
			118, 135
		})]
		internal override Iterator descendingEntryIterator()
		{
			Collection collection = ((!upperBoundWindow.hasUpperBound()) ? rangesByLowerBound.descendingMap().values() : rangesByLowerBound.headMap((Cut)upperBoundWindow.upperEndpoint(), inclusive: false).descendingMap().values());
			PeekingIterator peekingIterator = Iterators.peekingIterator(collection.iterator());
			if (peekingIterator.hasNext() && upperBoundWindow.upperBound.isLessThan(((Range)peekingIterator.peek()).upperBound))
			{
				peekingIterator.next();
			}
			_2 result = new _2(this, peekingIterator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 70, 114, 142 })]
		public override int size()
		{
			if (upperBoundWindow.equals(Range.all()))
			{
				int result = rangesByLowerBound.size();
				_ = null;
				return result;
			}
			int result2 = Iterators.size(entryIterator());
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 78, 114, 109, 17 })]
		public override bool isEmpty()
		{
			return upperBoundWindow.equals(Range.all()) ? rangesByLowerBound.isEmpty() : ((!entryIterator().hasNext()) ? true : false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(285)]
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
			Range result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(285)]
		public override NavigableMap tailMap(object P_0, bool P_1)
		{
			NavigableMap result = tailMap((Cut)P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(285)]
		public override NavigableMap headMap(object P_0, bool P_1)
		{
			NavigableMap result = headMap((Cut)P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(285)]
		public override NavigableMap subMap(object P_0, bool P_1, object P_2, bool P_3)
		{
			NavigableMap result = subMap((Cut)P_0, P_1, (Cut)P_2, P_3);
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/TreeRangeSet<TC;>;")]
	internal sealed class SubRangeSet : TreeRangeSet
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Range<TC;>;")]
		private Range restriction;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal TreeRangeSet this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
		[LineNumberTable(new byte[] { 162, 250, 103, 129, 19, 167, 103 })]
		internal SubRangeSet(TreeRangeSet P_0, Range P_1)
		{
			this_00240 = P_0;
			base._002Ector(new SubRangeSetRangesByLowerBound(Range.all(), P_1, P_0.rangesByLowerBound, null), null);
			restriction = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
		[LineNumberTable(new byte[] { 163, 3, 123, 109, 155 })]
		public override bool encloses(Range P_0)
		{
			if (!restriction.isEmpty() && restriction.encloses(P_0))
			{
				Range range = access_0024600(this_00240, P_0);
				return (range != null && !range.intersection(restriction).isEmpty()) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Lcom/google/common/collect/Range<TC;>;")]
		[LineNumberTable(new byte[] { 163, 13, 110, 130, 109 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override Range rangeContaining(IComparable P_0)
		{
			if (!restriction.contains(P_0))
			{
				return null;
			}
			Range result = this_00240.rangeContaining(P_0)?.intersection(restriction);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
		[LineNumberTable(new byte[] { 163, 22, 103, 49, 229, 69, 110 })]
		public override void add(Range P_0)
		{
			Preconditions.checkArgument(restriction.encloses(P_0), "Cannot add range %s to subRangeSet(%s)", P_0, restriction);
			this_00240.add(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
		[LineNumberTable(new byte[] { 163, 32, 110, 153 })]
		public override void remove(Range P_0)
		{
			if (P_0.isConnected(restriction))
			{
				this_00240.remove(P_0.intersection(restriction));
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Z")]
		[LineNumberTable(921)]
		public override bool contains(IComparable P_0)
		{
			return (restriction.contains(P_0) && this_00240.contains(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 163, 44, 115 })]
		public override void clear()
		{
			this_00240.remove(restriction);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/RangeSet<TC;>;")]
		[LineNumberTable(new byte[] { 163, 49, 110, 98, 110, 149 })]
		public override RangeSet subRangeSet(Range P_0)
		{
			if (P_0.encloses(restriction))
			{
				return this;
			}
			if (P_0.isConnected(restriction))
			{
				SubRangeSet result = new SubRangeSet(this, restriction.intersection(P_0));
				_ = null;
				return result;
			}
			ImmutableRangeSet result2 = ImmutableRangeSet.of();
			_ = null;
			return result2;
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SubRangeSet(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	[Signature("<C::Ljava/lang/Comparable<*>;>Lcom/google/common/collect/AbstractNavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
	internal sealed class SubRangeSetRangesByLowerBound : AbstractNavigableMap
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal new class _1 : AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024completeRangeItr;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Cut val_0024upperBoundOnLowerBounds;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal SubRangeSetRangesByLowerBound this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
			[LineNumberTable(new byte[] { 162, 185, 109, 140, 113, 115, 140, 114 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Map.Entry computeNext()
			{
				if (!val_0024completeRangeItr.hasNext())
				{
					return (Map.Entry)endOfData();
				}
				Range range = (Range)val_0024completeRangeItr.next();
				if (val_0024upperBoundOnLowerBounds.isLessThan(range.lowerBound))
				{
					return (Map.Entry)endOfData();
				}
				range = range.intersection(access_0024300(this_00240));
				Map.Entry result = Maps.immutableEntry(range.lowerBound, range);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(807)]
			internal _1(SubRangeSetRangesByLowerBound P_0, Iterator P_1, Cut P_2)
			{
				this_00240 = P_0;
				val_0024completeRangeItr = P_1;
				val_0024upperBoundOnLowerBounds = P_2;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(807)]
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
		[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[EnclosingMethod(null, "descendingEntryIterator", "()Ljava.util.Iterator;")]
		internal class _2 : AbstractIterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024completeRangeItr;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal SubRangeSetRangesByLowerBound this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(841)]
			internal _2(SubRangeSetRangesByLowerBound P_0, Iterator P_1)
			{
				this_00240 = P_0;
				val_0024completeRangeItr = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
			[LineNumberTable(new byte[] { 162, 219, 109, 140, 113, 126, 140, 114, 120, 143 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Map.Entry computeNext()
			{
				if (!val_0024completeRangeItr.hasNext())
				{
					return (Map.Entry)endOfData();
				}
				Range range = (Range)val_0024completeRangeItr.next();
				if (access_0024300(this_00240).lowerBound.compareTo(range.upperBound) >= 0)
				{
					return (Map.Entry)endOfData();
				}
				range = range.intersection(access_0024300(this_00240));
				if (access_0024400(this_00240).contains(range.lowerBound))
				{
					Map.Entry result = Maps.immutableEntry(range.lowerBound, range);
					_ = null;
					return result;
				}
				return (Map.Entry)endOfData();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(841)]
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

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Range<Lcom/google/common/collect/Cut<TC;>;>;")]
		private Range lowerBoundWindow;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Lcom/google/common/collect/Range<TC;>;")]
		private Range restriction;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		private NavigableMap rangesByLowerBound;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		private NavigableMap rangesByUpperBound;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(685)]
		internal SubRangeSetRangesByLowerBound(Range P_0, Range P_1, NavigableMap P_2, TreeRangeSet._1 P_3)
			: this(P_0, P_1, P_2)
		{
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(685)]
		internal static Range access_0024300(SubRangeSetRangesByLowerBound P_0)
		{
			return P_0.restriction;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<Lcom/google/common/collect/Cut<TC;>;>;Lcom/google/common/collect/Range<TC;>;Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;)V")]
		[LineNumberTable(new byte[] { 162, 79, 104, 113, 113, 113, 108 })]
		private SubRangeSetRangesByLowerBound(Range P_0, Range P_1, NavigableMap P_2)
		{
			lowerBoundWindow = (Range)Preconditions.checkNotNull(P_0);
			restriction = (Range)Preconditions.checkNotNull(P_1);
			rangesByLowerBound = (NavigableMap)Preconditions.checkNotNull(P_2);
			rangesByUpperBound = new RangesByUpperBound(P_2);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Range<Lcom/google/common/collect/Cut<TC;>;>;)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(new byte[] { 162, 87, 110, 136, 103, 56 })]
		private NavigableMap subMap(Range P_0)
		{
			if (!P_0.isConnected(lowerBoundWindow))
			{
				ImmutableSortedMap result = ImmutableSortedMap.of();
				_ = null;
				return result;
			}
			SubRangeSetRangesByLowerBound result2 = new SubRangeSetRangesByLowerBound(lowerBoundWindow.intersection(P_0), restriction, rangesByLowerBound);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Lcom/google/common/collect/Range<TC;>;")]
		[LineNumberTable(new byte[]
		{
			162,
			129,
			171,
			103,
			122,
			116,
			104,
			103,
			147,
			119,
			124,
			143,
			98,
			114,
			99,
			byte.MaxValue,
			14,
			69,
			2,
			97,
			162
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Range get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			//Discarded unreachable code: IL_00cb
			if (P_0 is Cut)
			{
				try
				{
					Cut cut = (Cut)P_0;
					if (!lowerBoundWindow.contains(cut) || cut.compareTo(restriction.lowerBound) < 0 || cut.compareTo(restriction.upperBound) >= 0)
					{
						return null;
					}
					if (cut.equals(restriction.lowerBound))
					{
						Range range = (Range)Maps.valueOrNull(rangesByLowerBound.floorEntry(cut));
						if (range != null && range.upperBound.compareTo(restriction.lowerBound) > 0)
						{
							return range.intersection(restriction);
						}
					}
					else
					{
						Range range = (Range)rangesByLowerBound.get(cut);
						if (range != null)
						{
							return range.intersection(restriction);
						}
					}
				}
				catch (System.Exception x)
				{
					if (ByteCodeHelper.MapException<ClassCastException>(x, ByteCodeHelper.MapFlags.Unused) == null)
					{
						throw;
					}
					goto IL_00e4;
				}
			}
			return null;
			IL_00e4:
			_ = null;
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[LineNumberTable(new byte[]
		{
			162, 158, 109, 168, 125, 104, 157, 114, 178, 177,
			112, 12, 165, 101, 166, 123, 112
		})]
		internal override Iterator entryIterator()
		{
			if (restriction.isEmpty())
			{
				UnmodifiableIterator result = Iterators.emptyIterator();
				_ = null;
				return result;
			}
			if (lowerBoundWindow.upperBound.isLessThan(restriction.lowerBound))
			{
				UnmodifiableIterator result2 = Iterators.emptyIterator();
				_ = null;
				return result2;
			}
			Iterator iterator = ((!lowerBoundWindow.lowerBound.isLessThan(restriction.lowerBound)) ? rangesByLowerBound.tailMap((Cut)lowerBoundWindow.lowerBound.endpoint(), lowerBoundWindow.lowerBoundType() == BoundType.___003C_003ECLOSED).values().iterator() : rangesByUpperBound.tailMap(restriction.lowerBound, inclusive: false).values().iterator());
			Cut cut = (Cut)Ordering.natural().min(lowerBoundWindow.upperBound, Cut.belowValue(restriction.upperBound));
			_1 result3 = new _1(this, iterator, cut);
			_ = null;
			return result3;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Cut<TC;>;Z)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(739)]
		public virtual NavigableMap tailMap(Cut P_0, bool P_1)
		{
			NavigableMap result = subMap(Range.downTo(P_0, BoundType.forBoolean(P_1)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Cut<TC;>;Z)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(734)]
		public virtual NavigableMap headMap(Cut P_0, bool P_1)
		{
			NavigableMap result = subMap(Range.upTo(P_0, BoundType.forBoolean(P_1)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Cut<TC;>;ZLcom/google/common/collect/Cut<TC;>;Z)Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
		[LineNumberTable(new byte[] { 158, 217, 69, 163, 135, 229, 60, 37 })]
		public virtual NavigableMap subMap(Cut P_0, bool P_1, Cut P_2, bool P_3)
		{
			NavigableMap result = subMap(Range.range(P_0, BoundType.forBoolean(P_1), P_2, BoundType.forBoolean(P_3)));
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-Lcom/google/common/collect/Cut<TC;>;>;")]
		[LineNumberTable(744)]
		public override Comparator comparator()
		{
			Ordering result = Ordering.natural();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(749)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return get(P_0) != null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;>;")]
		[LineNumberTable(new byte[]
		{
			162, 201, 109, 168, 123, 112, 167, 107, 12, 165,
			101, 101, 102
		})]
		internal override Iterator descendingEntryIterator()
		{
			if (restriction.isEmpty())
			{
				UnmodifiableIterator result = Iterators.emptyIterator();
				_ = null;
				return result;
			}
			Cut cut = (Cut)Ordering.natural().min(lowerBoundWindow.upperBound, Cut.belowValue(restriction.upperBound));
			Iterator iterator = rangesByLowerBound.headMap((Cut)cut.endpoint(), cut.typeAsUpperBound() == BoundType.___003C_003ECLOSED).descendingMap().values()
				.iterator();
			_2 result2 = new _2(this, iterator);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(864)]
		public override int size()
		{
			int result = Iterators.size(entryIterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(685)]
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
			Range result = get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(685)]
		public override NavigableMap tailMap(object P_0, bool P_1)
		{
			NavigableMap result = tailMap((Cut)P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(685)]
		public override NavigableMap headMap(object P_0, bool P_1)
		{
			NavigableMap result = headMap((Cut)P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(685)]
		public override NavigableMap subMap(object P_0, bool P_1, object P_2, bool P_3)
		{
			NavigableMap result = subMap((Cut)P_0, P_1, (Cut)P_2, P_3);
			_ = null;
			return result;
		}

		[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(685)]
		internal static Range access_0024400(SubRangeSetRangesByLowerBound P_0)
		{
			return P_0.lowerBoundWindow;
		}
	}

	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;")]
	internal NavigableMap rangesByLowerBound;

	[NonSerialized]
	[Signature("Ljava/util/Set<Lcom/google/common/collect/Range<TC;>;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new Set m_asRanges;

	[NonSerialized]
	[Signature("Ljava/util/Set<Lcom/google/common/collect/Range<TC;>;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new Set m_asDescendingSetOfRanges;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/RangeSet<TC;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new RangeSet m_complement;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(Ljava/lang/Iterable<Lcom/google/common/collect/Range<TC;>;>;)Lcom/google/common/collect/TreeRangeSet<TC;>;")]
	[LineNumberTable(new byte[] { 21, 102, 103 })]
	public static TreeRangeSet create(Iterable ranges)
	{
		TreeRangeSet treeRangeSet = create();
		((AbstractRangeSet)treeRangeSet).addAll(ranges);
		return treeRangeSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>(Lcom/google/common/collect/RangeSet<TC;>;)Lcom/google/common/collect/TreeRangeSet<TC;>;")]
	[LineNumberTable(new byte[] { 6, 102, 103 })]
	public static TreeRangeSet create(RangeSet rangeSet)
	{
		TreeRangeSet treeRangeSet = create();
		treeRangeSet.addAll(rangeSet);
		return treeRangeSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[] { 108, 103, 114, 118, 109, 1 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Range rangeEnclosing(Range P_0)
	{
		Preconditions.checkNotNull(P_0);
		Map.Entry entry = rangesByLowerBound.floorEntry(P_0.lowerBound);
		return (entry == null || !((Range)entry.getValue()).encloses(P_0)) ? null : ((Range)entry.getValue());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/NavigableMap<Lcom/google/common/collect/Cut<TC;>;Lcom/google/common/collect/Range<TC;>;>;)V")]
	[LineNumberTable(new byte[] { 26, 104, 103 })]
	private TreeRangeSet(NavigableMap P_0)
	{
		rangesByLowerBound = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable<*>;>()Lcom/google/common/collect/TreeRangeSet<TC;>;")]
	[LineNumberTable(51)]
	public static TreeRangeSet create()
	{
		TreeRangeSet result = new TreeRangeSet(new TreeMap());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override void addAll(RangeSet rs)
	{
		base.addAll(rs);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
	[LineNumberTable(new byte[] { 160, 156, 104, 148, 147 })]
	private void replaceRangeWithSameLowerBound(Range P_0)
	{
		if (P_0.isEmpty())
		{
			rangesByLowerBound.remove(P_0.lowerBound);
		}
		else
		{
			rangesByLowerBound.put(P_0.lowerBound, P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Range<TC;>;>;")]
	[LineNumberTable(new byte[] { 35, 103 })]
	public override Set asRanges()
	{
		Set set = this.m_asRanges;
		object set2;
		if (set == null)
		{
			AsRanges asRanges = new AsRanges(this, rangesByLowerBound.values());
			set2 = asRanges;
			this.m_asRanges = asRanges;
		}
		else
		{
			set2 = set;
		}
		return (set2 == null) ? null : ((set2 as Set) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Range<TC;>;>;")]
	[LineNumberTable(new byte[] { 41, 103, 99, 127, 4, 1 })]
	public override Set asDescendingSetOfRanges()
	{
		Set set = this.m_asDescendingSetOfRanges;
		object set2;
		if (set == null)
		{
			AsRanges asRanges = new AsRanges(this, rangesByLowerBound.descendingMap().values());
			set2 = asRanges;
			this.m_asDescendingSetOfRanges = asRanges;
		}
		else
		{
			set2 = set;
		}
		return (set2 == null) ? null : ((set2 as Set) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[] { 74, 103, 114, 118, 172 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override Range rangeContaining(IComparable value)
	{
		Preconditions.checkNotNull(value);
		Map.Entry entry = rangesByLowerBound.floorEntry(Cut.belowValue(value));
		if (entry != null && ((Range)entry.getValue()).contains(value))
		{
			return (Range)entry.getValue();
		}
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
	[LineNumberTable(new byte[]
	{
		86, 103, 114, 100, 115, 119, 130, 114, 100, 115,
		27
	})]
	public override bool intersects(Range range)
	{
		Preconditions.checkNotNull(range);
		Map.Entry entry = rangesByLowerBound.ceilingEntry(range.lowerBound);
		if (entry != null && ((Range)entry.getValue()).isConnected(range) && !((Range)entry.getValue()).intersection(range).isEmpty())
		{
			return true;
		}
		Map.Entry entry2 = rangesByLowerBound.lowerEntry(range.lowerBound);
		return (entry2 != null && ((Range)entry2.getValue()).isConnected(range) && !((Range)entry2.getValue()).intersection(range).isEmpty()) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
	[LineNumberTable(new byte[] { 101, 103, 114 })]
	public override bool encloses(Range range)
	{
		Preconditions.checkNotNull(range);
		Map.Entry entry = rangesByLowerBound.floorEntry(range.lowerBound);
		return (entry != null && ((Range)entry.getValue()).encloses(range)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Range<TC;>;")]
	[LineNumberTable(new byte[] { 117, 108, 108, 230, 69, 139 })]
	public override Range span()
	{
		Map.Entry entry = rangesByLowerBound.firstEntry();
		Map.Entry entry2 = rangesByLowerBound.lastEntry();
		if (entry == null || entry2 == null)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NoSuchElementException();
		}
		Range result = Range.create(((Range)entry.getValue()).lowerBound, ((Range)entry2.getValue()).upperBound);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
	[LineNumberTable(new byte[]
	{
		160, 67, 135, 104, 225, 69, 103, 135, 109, 131,
		108, 143, 143, 231, 70, 199, 110, 132, 110, 144,
		232, 69, 146, 111
	})]
	public override void add(Range rangeToAdd)
	{
		Preconditions.checkNotNull(rangeToAdd);
		if (rangeToAdd.isEmpty())
		{
			return;
		}
		Cut lowerBound = rangeToAdd.lowerBound;
		Cut upperBound = rangeToAdd.upperBound;
		Map.Entry entry = rangesByLowerBound.lowerEntry(lowerBound);
		if (entry != null)
		{
			Range range = (Range)entry.getValue();
			if (range.upperBound.compareTo(lowerBound) >= 0)
			{
				if (range.upperBound.compareTo(upperBound) >= 0)
				{
					upperBound = range.upperBound;
				}
				lowerBound = range.lowerBound;
			}
		}
		Map.Entry entry2 = rangesByLowerBound.floorEntry(upperBound);
		if (entry2 != null)
		{
			Range range2 = (Range)entry2.getValue();
			if (range2.upperBound.compareTo(upperBound) >= 0)
			{
				upperBound = range2.upperBound;
			}
		}
		rangesByLowerBound.subMap(lowerBound, upperBound).clear();
		replaceRangeWithSameLowerBound(Range.create(lowerBound, upperBound));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
	[LineNumberTable(new byte[]
	{
		160, 114, 135, 104, 225, 70, 114, 134, 108, 148,
		116, 136, 109, 37, 165, 109, 37, 229, 69, 114,
		131, 108, 116, 136, 109, 37, 229, 69, 126
	})]
	public override void remove(Range rangeToRemove)
	{
		Preconditions.checkNotNull(rangeToRemove);
		if (rangeToRemove.isEmpty())
		{
			return;
		}
		Map.Entry entry = rangesByLowerBound.lowerEntry(rangeToRemove.lowerBound);
		if (entry != null)
		{
			Range range = (Range)entry.getValue();
			if (range.upperBound.compareTo(rangeToRemove.lowerBound) >= 0)
			{
				if (rangeToRemove.hasUpperBound() && range.upperBound.compareTo(rangeToRemove.upperBound) >= 0)
				{
					replaceRangeWithSameLowerBound(Range.create(rangeToRemove.upperBound, range.upperBound));
				}
				replaceRangeWithSameLowerBound(Range.create(range.lowerBound, rangeToRemove.lowerBound));
			}
		}
		Map.Entry entry2 = rangesByLowerBound.floorEntry(rangeToRemove.upperBound);
		if (entry2 != null)
		{
			Range range2 = (Range)entry2.getValue();
			if (rangeToRemove.hasUpperBound() && range2.upperBound.compareTo(rangeToRemove.upperBound) >= 0)
			{
				replaceRangeWithSameLowerBound(Range.create(rangeToRemove.upperBound, range2.upperBound));
			}
		}
		rangesByLowerBound.subMap(rangeToRemove.lowerBound, rangeToRemove.upperBound).clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/RangeSet<TC;>;")]
	[LineNumberTable(new byte[] { 160, 167, 103 })]
	public override RangeSet complement()
	{
		RangeSet rangeSet = this.m_complement;
		object rangeSet2;
		if (rangeSet == null)
		{
			Complement complement = new Complement(this);
			rangeSet2 = complement;
			this.m_complement = complement;
		}
		else
		{
			rangeSet2 = rangeSet;
		}
		return (rangeSet2 == null) ? null : ((rangeSet2 as RangeSet) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/RangeSet<TC;>;")]
	[LineNumberTable(870)]
	public override RangeSet subRangeSet(Range view)
	{
		TreeRangeSet result = ((!view.equals(Range.all())) ? new SubRangeSet(this, view) : this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.equals(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override void removeAll(RangeSet rs)
	{
		base.removeAll(rs);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override bool enclosesAll(RangeSet rs)
	{
		bool result = base.enclosesAll(rs);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override void clear()
	{
		base.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override bool isEmpty()
	{
		bool result = base.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(41)]
	public override bool contains(IComparable c)
	{
		bool result = base.contains(c);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(44)]
	internal TreeRangeSet(NavigableMap P_0, _1 P_1)
		: this(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(44)]
	internal static Range access_0024600(TreeRangeSet P_0, Range P_1)
	{
		Range result = P_0.rangeEnclosing(P_1);
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(TreeRangeSet P_0)
	{
		Serializable result = default(Serializable);
		result.___003Cref_003E = P_0;
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
	protected TreeRangeSet(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|hashCode", "()I")]
	public new int hashCode()
	{
		return ((AbstractRangeSet)this).hashCode();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>1|toString", "()Ljava.lang.String;")]
	public new string toString()
	{
		return ((AbstractRangeSet)this).toString();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>2|enclosesAll", "(Ljava.lang.Iterable;)Z")]
	public new bool enclosesAll(Iterable P_0)
	{
		return ((AbstractRangeSet)this).enclosesAll(P_0);
	}

	[HideFromJava]
	protected internal bool _003Cnonvirtual_003E2(Iterable P_0)
	{
		return base.enclosesAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>3|addAll", "(Ljava.lang.Iterable;)V")]
	public new void addAll(Iterable P_0)
	{
		((AbstractRangeSet)this).addAll(P_0);
	}

	[HideFromJava]
	protected internal void _003Cnonvirtual_003E3(Iterable P_0)
	{
		base.addAll(P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>4|removeAll", "(Ljava.lang.Iterable;)V")]
	public new void removeAll(Iterable P_0)
	{
		((AbstractRangeSet)this).removeAll(P_0);
	}

	[HideFromJava]
	protected internal void _003Cnonvirtual_003E4(Iterable P_0)
	{
		base.removeAll(P_0);
	}
}
