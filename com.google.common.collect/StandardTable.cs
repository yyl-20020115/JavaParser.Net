using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractTable<TR;TC;TV;>;Ljava/io/Serializable;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
internal class StandardTable : AbstractTable, Serializable.__Interface, ISerializable
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal new class _1 : java.lang.Object
	{
		_1()
		{
			throw null;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Ljava/lang/Object;Ljava/util/Iterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	internal class CellIterator : java.lang.Object, Iterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Iterator<Ljava/util/Map$Entry<TR;Ljava/util/Map<TC;TV;>;>;>;")]
		internal Iterator rowIterator;

		[Signature("Ljava/util/Map$Entry<TR;Ljava/util/Map<TC;TV;>;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Map.Entry rowEntry;

		[Signature("Ljava/util/Iterator<Ljava/util/Map$Entry<TC;TV;>;>;")]
		internal Iterator columnIterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal StandardTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(243)]
		internal CellIterator(StandardTable P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 129, 111, 155 })]
		private CellIterator(StandardTable P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			rowIterator = this_00240.backingMap.entrySet().iterator();
			columnIterator = Iterators.emptyModifiableIterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;")]
		[LineNumberTable(new byte[]
		{
			160,
			141,
			109,
			118,
			byte.MaxValue,
			1,
			79,
			108,
			113
		})]
		public virtual Table.Cell next()
		{
			if (!columnIterator.hasNext())
			{
				rowEntry = (Map.Entry)rowIterator.next();
				columnIterator = ((Map)rowEntry.getValue()).entrySet().iterator();
			}
			java.util.Objects.requireNonNull(rowEntry);
			Map.Entry entry = (Map.Entry)columnIterator.next();
			Table.Cell result = Tables.immutableCell(rowEntry.getKey(), entry.getKey(), entry.getValue());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(250)]
		public virtual bool hasNext()
		{
			return (rowIterator.hasNext() || columnIterator.hasNext()) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 165, 235, 75, 127, 2, 107, 135 })]
		public virtual void remove()
		{
			columnIterator.remove();
			if (((Map)((Map.Entry)java.util.Objects.requireNonNull(rowEntry)).getValue()).isEmpty())
			{
				rowIterator.remove();
				rowEntry = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(243)]
		public virtual object next()
		{
			Table.Cell result = this.next();
			_ = null;
			return result;
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual void forEachRemaining(Consumer P_0)
		{
			Iterator._003Cdefault_003EforEachRemaining(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/Maps$ViewCachingAbstractMap<TR;TV;>;")]
	internal class Column : Maps.ViewCachingAbstractMap
	{
		[InnerClass(null, Modifiers.Private)]
		[Signature("Lcom/google/common/collect/Sets$ImprovedAbstractSet<Ljava/util/Map$Entry<TR;TV;>;>;")]
		internal class EntrySet : Sets.ImprovedAbstractSet
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Column this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(518)]
			private EntrySet(Column P_0)
			{
				this_00241 = P_0;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TR;TV;>;>;")]
			[LineNumberTable(521)]
			public override Iterator iterator()
			{
				EntrySetIterator result = new EntrySetIterator(this_00241, null);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 156, 98, 127, 16, 115, 132, 98 })]
			public override int size()
			{
				int num = 0;
				Iterator iterator = this_00241.this_00240.backingMap.values().iterator();
				while (iterator.hasNext())
				{
					Map map = (Map)iterator.next();
					if (map.containsKey(this_00241.columnKey))
					{
						num++;
					}
				}
				return num;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(537)]
			public override bool isEmpty()
			{
				return (!this_00241.this_00240.containsColumn(this_00241.columnKey)) ? true : false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 172, 113 })]
			public override void clear()
			{
				this_00241.removeFromColumnIf(Predicates.alwaysTrue());
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 177, 104, 103, 159, 11 })]
			public override bool contains([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (P_0 is Map.Entry)
				{
					Map.Entry entry = (Map.Entry)P_0;
					bool result = access_0024300(this_00241.this_00240, entry.getKey(), this_00241.columnKey, entry.getValue());
					_ = null;
					return result;
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 186, 104, 103, 159, 11 })]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (P_0 is Map.Entry)
				{
					Map.Entry entry = (Map.Entry)P_0;
					bool result = access_0024400(this_00241.this_00240, entry.getKey(), this_00241.columnKey, entry.getValue());
					_ = null;
					return result;
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(565)]
			public override bool retainAll(Collection P_0)
			{
				bool result = this_00241.removeFromColumnIf(Predicates.not(Predicates.@in(P_0)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Synthetic)]
			[LineNumberTable(518)]
			internal EntrySet(Column P_0, _1 P_1)
				: this(P_0)
			{
			}
		}

		[InnerClass(null, Modifiers.Private)]
		[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<TR;TV;>;>;")]
		internal class EntrySetIterator : AbstractIterator
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Lcom/google/common/collect/AbstractMapEntry<TR;TV;>;")]
			[EnclosingMethod(null, "computeNext", "()Ljava.util.Map$Entry;")]
			internal class _1EntryImpl : AbstractMapEntry
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal Map.Entry val_0024entry;

				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal EntrySetIterator this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()V")]
				[LineNumberTable(579)]
				internal _1EntryImpl(EntrySetIterator P_0, Map.Entry P_1)
				{
					this_00242 = P_0;
					val_0024entry = P_1;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()TR;")]
				[LineNumberTable(582)]
				public override object getKey()
				{
					object key = val_0024entry.getKey();
					_ = null;
					return key;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("()TV;")]
				[LineNumberTable(587)]
				public override object getValue()
				{
					object result = ((Map)val_0024entry.getValue()).get(this_00242.this_00241.columnKey);
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(TV;)TV;")]
				[LineNumberTable(new byte[] { 161, 236, 102, 63, 6 })]
				public override object setValue(object P_0)
				{
					object result = NullnessCasts.uncheckedCastNullableTToT(((Map)val_0024entry.getValue()).put(this_00242.this_00241.columnKey, Preconditions.checkNotNull(P_0)));
					_ = null;
					return result;
				}
			}

			[Modifiers(Modifiers.Final)]
			[Signature("Ljava/util/Iterator<Ljava/util/Map$Entry<TR;Ljava/util/Map<TC;TV;>;>;>;")]
			internal Iterator iterator;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Column this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Synthetic)]
			[LineNumberTable(569)]
			internal EntrySetIterator(Column P_0, StandardTable._1 P_1)
				: this(P_0)
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 199, 111 })]
			private EntrySetIterator(Column P_0)
			{
				this_00241 = P_0;
				base._002Ector();
				iterator = this_00241.this_00240.backingMap.entrySet().iterator();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<TR;TV;>;")]
			[LineNumberTable(new byte[] { 161, 205, 109, 113, 253, 97, 138, 98 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Map.Entry computeNext()
			{
				while (iterator.hasNext())
				{
					Map.Entry entry = (Map.Entry)iterator.next();
					if (((Map)entry.getValue()).containsKey(this_00241.columnKey))
					{
						_1EntryImpl result = new _1EntryImpl(this, entry);
						_ = null;
						return result;
					}
				}
				return (Map.Entry)endOfData();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(569)]
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

		[InnerClass(null, Modifiers.Private)]
		[Signature("Lcom/google/common/collect/Maps$KeySet<TR;TV;>;")]
		internal class KeySet : Maps.KeySet
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Column this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 254, 103, 105 })]
			internal KeySet(Column P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(630)]
			public override bool contains([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				bool result = this_00241.this_00240.contains(P_0, this_00241.columnKey);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(635)]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				return this_00241.this_00240.remove(P_0, this_00241.columnKey) != null;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(640)]
			public override bool retainAll(Collection P_0)
			{
				bool result = this_00241.removeFromColumnIf(Maps.keyPredicateOnEntries(Predicates.not(Predicates.@in(P_0))));
				_ = null;
				return result;
			}
		}

		[InnerClass(null, Modifiers.Private)]
		[Signature("Lcom/google/common/collect/Maps$Values<TR;TV;>;")]
		internal class Values : Maps.Values
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Column this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 25, 103, 105 })]
			internal Values(Column P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(657)]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				return (P_0 != null && this_00241.removeFromColumnIf(Maps.valuePredicateOnEntries(Predicates.equalTo(P_0)))) ? true : false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(662)]
			public override bool removeAll(Collection P_0)
			{
				bool result = this_00241.removeFromColumnIf(Maps.valuePredicateOnEntries(Predicates.@in(P_0)));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(667)]
			public override bool retainAll(Collection P_0)
			{
				bool result = this_00241.removeFromColumnIf(Maps.valuePredicateOnEntries(Predicates.not(Predicates.@in(P_0))));
				_ = null;
				return result;
			}
		}

		[Modifiers(Modifiers.Final)]
		[Signature("TC;")]
		internal object columnKey;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal StandardTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)V")]
		[LineNumberTable(new byte[] { 161, 95, 111, 108 })]
		internal Column(StandardTable P_0, object P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			columnKey = Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TR;TV;>;>;)Z")]
		[LineNumberTable(new byte[]
		{
			161, 125, 98, 118, 107, 108, 108, 110, 121, 109,
			98, 104, 166, 101
		})]
		internal virtual bool removeFromColumnIf(com.google.common.@base.Predicate P_0)
		{
			int result = 0;
			Iterator iterator = this_00240.backingMap.entrySet().iterator();
			while (iterator.hasNext())
			{
				Map.Entry entry = (Map.Entry)iterator.next();
				Map map = (Map)entry.getValue();
				object obj = map.get(columnKey);
				if (obj != null && P_0.apply(Maps.immutableEntry(entry.getKey(), obj)))
				{
					map.remove(columnKey);
					result = 1;
					if (map.isEmpty())
					{
						iterator.remove();
					}
				}
			}
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;TV;)TV;")]
		[LineNumberTable(472)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object put(object P_0, object P_1)
		{
			object result = this_00240.put(P_0, columnKey, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(478)]
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
			object result = this_00240.get(P_0, columnKey);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(483)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = this_00240.contains(P_0, columnKey);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(489)]
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
			object result = this_00240.remove(P_0, columnKey);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TR;TV;>;>;")]
		[LineNumberTable(514)]
		internal override Set createEntrySet()
		{
			EntrySet result = new EntrySet(this, null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TR;>;")]
		[LineNumberTable(619)]
		internal override Set createKeySet()
		{
			KeySet result = new KeySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<TV;>;")]
		[LineNumberTable(646)]
		internal override Collection createValues()
		{
			Values result = new Values(this);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/AbstractIterator<TC;>;")]
	internal class ColumnKeyIterator : AbstractIterator
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Map<TC;TV;>;")]
		internal Map seen;

		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Iterator<Ljava/util/Map<TC;TV;>;>;")]
		internal Iterator mapIterator;

		[Signature("Ljava/util/Iterator<Ljava/util/Map$Entry<TC;TV;>;>;")]
		internal Iterator entryIterator;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal StandardTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(771)]
		internal ColumnKeyIterator(StandardTable P_0, StandardTable._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 162, 145, 175, 123, 123 })]
		private ColumnKeyIterator(StandardTable P_0)
		{
			this_00240 = P_0;
			base._002Ector();
			seen = (Map)this_00240.factory.get();
			mapIterator = this_00240.backingMap.values().iterator();
			entryIterator = Iterators.emptyIterator();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TC;")]
		[LineNumberTable(new byte[] { 162, 156, 109, 113, 115, 120, 137, 111, 159, 6 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			while (true)
			{
				if (entryIterator.hasNext())
				{
					Map.Entry entry = (Map.Entry)entryIterator.next();
					if (!seen.containsKey(entry.getKey()))
					{
						seen.put(entry.getKey(), entry.getValue());
						object key = entry.getKey();
						_ = null;
						return key;
					}
				}
				else
				{
					if (!mapIterator.hasNext())
					{
						break;
					}
					entryIterator = ((Map)mapIterator.next()).entrySet().iterator();
				}
			}
			object result = endOfData();
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/StandardTable<TR;TC;TV;>.TableSet<TC;>;")]
	internal class ColumnKeySet : TableSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new StandardTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(694)]
		internal ColumnKeySet(StandardTable P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(694)]
		private ColumnKeySet(StandardTable P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0, null);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TC;>;")]
		[LineNumberTable(697)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.createColumnKeyIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(702)]
		public override int size()
		{
			int result = Iterators.size(iterator());
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			162, 81, 99, 130, 98, 118, 104, 108, 110, 98,
			104, 166, 98
		})]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 == null)
			{
				return false;
			}
			int result = 0;
			Iterator iterator = this_00240.backingMap.values().iterator();
			while (iterator.hasNext())
			{
				Map map = (Map)iterator.next();
				if (map.keySet().remove(P_0))
				{
					result = 1;
					if (map.isEmpty())
					{
						iterator.remove();
					}
				}
			}
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[]
		{
			162, 100, 103, 98, 118, 104, 172, 115, 98, 104,
			166, 98
		})]
		public override bool removeAll(Collection P_0)
		{
			Preconditions.checkNotNull(P_0);
			int result = 0;
			Iterator iterator = this_00240.backingMap.values().iterator();
			while (iterator.hasNext())
			{
				Map map = (Map)iterator.next();
				if (Iterators.removeAll(map.keySet().iterator(), P_0))
				{
					result = 1;
					if (map.isEmpty())
					{
						iterator.remove();
					}
				}
			}
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Collection<*>;)Z")]
		[LineNumberTable(new byte[]
		{
			162, 119, 103, 98, 118, 104, 108, 110, 98, 104,
			166, 98
		})]
		public override bool retainAll(Collection P_0)
		{
			Preconditions.checkNotNull(P_0);
			int result = 0;
			Iterator iterator = this_00240.backingMap.values().iterator();
			while (iterator.hasNext())
			{
				Map map = (Map)iterator.next();
				if (map.keySet().retainAll(P_0))
				{
					result = 1;
					if (map.isEmpty())
					{
						iterator.remove();
					}
				}
			}
			return (byte)result != 0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(762)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = this_00240.containsColumn(P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/Maps$ViewCachingAbstractMap<TC;Ljava/util/Map<TR;TV;>;>;")]
	internal class ColumnMap : Maps.ViewCachingAbstractMap
	{
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/StandardTable<TR;TC;TV;>.TableSet<Ljava/util/Map$Entry<TC;Ljava/util/Map<TR;TV;>;>;>;")]
		internal class ColumnMapEntrySet : TableSet
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<TC;Ljava/util/Map<TR;TV;>;>;")]
			[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
			[Implements(new string[] { "com.google.common.base.Function" })]
			internal class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal ColumnMapEntrySet this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(TC;)Ljava/util/Map<TR;TV;>;")]
				[LineNumberTable(945)]
				public virtual Map apply(object P_0)
				{
					Map result = this_00242.this_00241.this_00240.column(P_0);
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(942)]
				internal _1(ColumnMapEntrySet P_0)
				{
					this_00242 = P_0;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(942)]
				public virtual object apply(object P_0)
				{
					Map result = this.apply(P_0);
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

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ColumnMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 163, 75, 104, 103, 152, 191, 10 })]
			public override bool contains([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (P_0 is Map.Entry)
				{
					Map.Entry entry = (Map.Entry)P_0;
					if (this_00241.this_00240.containsColumn(entry.getKey()))
					{
						bool result = ((Map)java.util.Objects.requireNonNull(this_00241.get(entry.getKey()))).equals(entry.getValue());
						_ = null;
						return result;
					}
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(937)]
			internal ColumnMapEntrySet(ColumnMap P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0.this_00240, null);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TC;Ljava/util/Map<TR;TV;>;>;>;")]
			[LineNumberTable(new byte[] { 163, 58, 107, 43 })]
			public override Iterator iterator()
			{
				Iterator result = Maps.asMapEntryIterator(this_00241.this_00240.columnKeySet(), new _1(this));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(952)]
			public override int size()
			{
				int result = this_00241.this_00240.columnKeySet().size();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 163, 91, 113, 103, 119, 130 })]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (contains(P_0) && P_0 is Map.Entry)
				{
					Map.Entry entry = (Map.Entry)P_0;
					access_0024900(this_00241.this_00240, entry.getKey());
					return true;
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(new byte[] { 163, 107, 103 })]
			public override bool removeAll(Collection P_0)
			{
				Preconditions.checkNotNull(P_0);
				bool result = Sets.removeAllImpl(this, P_0.iterator());
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(new byte[]
			{
				163, 113, 103, 98, 127, 16, 127, 0, 114, 130,
				98
			})]
			public override bool retainAll(Collection P_0)
			{
				Preconditions.checkNotNull(P_0);
				int result = 0;
				Iterator iterator = Lists.newArrayList(this_00241.this_00240.columnKeySet().iterator()).iterator();
				while (iterator.hasNext())
				{
					object obj = iterator.next();
					if (!P_0.contains(Maps.immutableEntry(obj, this_00241.this_00240.column(obj))))
					{
						access_0024900(this_00241.this_00240, obj);
						result = 1;
					}
				}
				return (byte)result != 0;
			}
		}

		[InnerClass(null, Modifiers.Private)]
		[Signature("Lcom/google/common/collect/Maps$Values<TC;Ljava/util/Map<TR;TV;>;>;")]
		internal class ColumnMapValues : Maps.Values
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ColumnMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 163, 127, 103, 105 })]
			internal ColumnMapValues(ColumnMap P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 163, 133, 127, 6, 115, 119, 130, 98 })]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				Iterator iterator = this_00241.entrySet().iterator();
				while (iterator.hasNext())
				{
					Map.Entry entry = (Map.Entry)iterator.next();
					if (((Map)entry.getValue()).equals(P_0))
					{
						access_0024900(this_00241.this_00240, entry.getKey());
						return true;
					}
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(new byte[] { 163, 144, 103, 98, 127, 16, 121, 114, 130, 98 })]
			public override bool removeAll(Collection P_0)
			{
				Preconditions.checkNotNull(P_0);
				int result = 0;
				Iterator iterator = Lists.newArrayList(this_00241.this_00240.columnKeySet().iterator()).iterator();
				while (iterator.hasNext())
				{
					object obj = iterator.next();
					if (P_0.contains(this_00241.this_00240.column(obj)))
					{
						access_0024900(this_00241.this_00240, obj);
						result = 1;
					}
				}
				return (byte)result != 0;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(Ljava/util/Collection<*>;)Z")]
			[LineNumberTable(new byte[] { 163, 157, 103, 98, 127, 16, 121, 114, 130, 98 })]
			public override bool retainAll(Collection P_0)
			{
				Preconditions.checkNotNull(P_0);
				int result = 0;
				Iterator iterator = Lists.newArrayList(this_00241.this_00240.columnKeySet().iterator()).iterator();
				while (iterator.hasNext())
				{
					object obj = iterator.next();
					if (!P_0.contains(this_00241.this_00240.column(obj)))
					{
						access_0024900(this_00241.this_00240, obj);
						result = 1;
					}
				}
				return (byte)result != 0;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal StandardTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(899)]
		internal ColumnMap(StandardTable P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Map<TR;TV;>;")]
		[LineNumberTable(907)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Map get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (!this_00240.containsColumn(P_0)) ? null : this_00240.column(java.util.Objects.requireNonNull(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(899)]
		private ColumnMap(StandardTable P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Map<TR;TV;>;")]
		[LineNumberTable(918)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Map remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (!this_00240.containsColumn(P_0)) ? null : access_0024900(this_00240, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(912)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = this_00240.containsColumn(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TC;Ljava/util/Map<TR;TV;>;>;>;")]
		[LineNumberTable(923)]
		public override Set createEntrySet()
		{
			ColumnMapEntrySet result = new ColumnMapEntrySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<TC;>;")]
		[LineNumberTable(928)]
		public override Set keySet()
		{
			Set result = this_00240.columnKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Collection<Ljava/util/Map<TR;TV;>;>;")]
		[LineNumberTable(933)]
		internal override Collection createValues()
		{
			ColumnMapValues result = new ColumnMapValues(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(898)]
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
			Map result = remove(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(898)]
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
			Map result = get(P_0);
			_ = null;
			return result;
		}
	}

	[Signature("Lcom/google/common/collect/Maps$IteratorBasedAbstractMap<TC;TV;>;")]
	internal class Row : Maps.IteratorBasedAbstractMap
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Ljava/lang/Object;Ljava/util/Iterator<Ljava/util/Map$Entry<TC;TV;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Ljava.util.Iterator;")]
		internal new class _1 : java.lang.Object, Iterator
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Iterator val_0024iterator;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Row this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<TC;TV;>;")]
			[LineNumberTable(411)]
			public virtual Map.Entry next()
			{
				Map.Entry result = this_00241.wrapEntry((Map.Entry)val_0024iterator.next());
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(403)]
			internal _1(Row P_0, Iterator P_1)
			{
				this_00241 = P_0;
				val_0024iterator = P_1;
				base._002Ector();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(406)]
			public virtual bool hasNext()
			{
				bool result = val_0024iterator.hasNext();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 46, 107, 109 })]
			public virtual void remove()
			{
				val_0024iterator.remove();
				this_00241.maintainEmptyInvariant();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(403)]
			public virtual object next()
			{
				Map.Entry result = this.next();
				_ = null;
				return result;
			}

			[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
			public virtual void forEachRemaining(Consumer P_0)
			{
				Iterator._003Cdefault_003EforEachRemaining(this, P_0);
			}
		}

		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/ForwardingMapEntry<TC;TV;>;")]
		[EnclosingMethod(null, "wrapEntry", "(Ljava.util.Map$Entry;)Ljava.util.Map$Entry;")]
		internal class _2 : ForwardingMapEntry
		{
			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal Map.Entry val_0024entry;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(432)]
			internal _2(Row P_0, Map.Entry P_1)
			{
				val_0024entry = P_1;
				base._002Ector();
			}

			[Signature("()Ljava/util/Map$Entry<TC;TV;>;")]
			protected internal override Map.Entry @delegate()
			{
				return val_0024entry;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("(TV;)TV;")]
			[LineNumberTable(440)]
			public override object setValue(object P_0)
			{
				object result = base.setValue(Preconditions.checkNotNull(P_0));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(446)]
			public override bool equals([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				bool result = standardEquals(P_0);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(432)]
			protected internal new virtual object @delegate()
			{
				Map.Entry result = this.@delegate();
				_ = null;
				return result;
			}
		}

		[SpecialName]
		private sealed class ___003C_003EAnon0 : java.util.function.Function
		{
			private readonly Row arg_00241;

			internal ___003C_003EAnon0(Row P_0)
			{
				arg_00241 = P_0;
			}

			public object apply(object P_0)
			{
				Map.Entry result = arg_00241.wrapEntry((Map.Entry)P_0);
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

		[Modifiers(Modifiers.Final)]
		[Signature("TR;")]
		internal object rowKey;

		[Signature("Ljava/util/Map<TC;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Map backingRowMap;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal StandardTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;)V")]
		[LineNumberTable(new byte[] { 160, 205, 111, 108 })]
		internal Row(StandardTable P_0, object P_1)
		{
			this_00240 = P_0;
			base._002Ector();
			rowKey = Preconditions.checkNotNull(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Map$Entry<TC;TV;>;)Ljava/util/Map$Entry<TC;TV;>;")]
		[LineNumberTable(432)]
		internal virtual Map.Entry wrapEntry(Map.Entry P_0)
		{
			_2 result = new _2(this, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 224, 102, 117, 119, 135 })]
		internal virtual void maintainEmptyInvariant()
		{
			updateBackingRowMapField();
			if (backingRowMap != null && backingRowMap.isEmpty())
			{
				this_00240.backingMap.remove(rowKey);
				backingRowMap = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Map<TC;TV;>;")]
		[LineNumberTable(333)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal virtual Map computeBackingRowMap()
		{
			return (Map)this_00240.backingMap.get(rowKey);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 212, 127, 14, 140 })]
		internal void updateBackingRowMapField()
		{
			if (backingRowMap == null || (backingRowMap.isEmpty() && this_00240.backingMap.containsKey(rowKey)))
			{
				backingRowMap = computeBackingRowMap();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 233, 102 })]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			updateBackingRowMapField();
			return (P_0 != null && backingRowMap != null && Maps.safeContainsKey(backingRowMap, P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 160, 240, 102 })]
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
			updateBackingRowMapField();
			return (P_0 == null || backingRowMap == null) ? null : Maps.safeGet(backingRowMap, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;TV;)TV;")]
		[LineNumberTable(new byte[] { 160, 247, 103, 103, 117, 144 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object put(object P_0, object P_1)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkNotNull(P_1);
			if (backingRowMap != null && !backingRowMap.isEmpty())
			{
				object result = backingRowMap.put(P_0, P_1);
				_ = null;
				return result;
			}
			object result2 = this_00240.put(rowKey, P_0, P_1);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 161, 2, 102, 104, 130, 109, 102 })]
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
			updateBackingRowMapField();
			if (backingRowMap == null)
			{
				return null;
			}
			object result = Maps.safeRemove(backingRowMap, P_0);
			maintainEmptyInvariant();
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 13, 102, 104, 139, 104 })]
		public override void clear()
		{
			updateBackingRowMapField();
			if (backingRowMap != null)
			{
				backingRowMap.clear();
			}
			maintainEmptyInvariant();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 22, 102 })]
		public override int size()
		{
			updateBackingRowMapField();
			int result = ((backingRowMap != null) ? backingRowMap.size() : 0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TC;TV;>;>;")]
		[LineNumberTable(new byte[] { 161, 28, 102, 104, 136, 113 })]
		internal override Iterator entryIterator()
		{
			updateBackingRowMapField();
			if (backingRowMap == null)
			{
				Iterator result = Iterators.emptyModifiableIterator();
				_ = null;
				return result;
			}
			Iterator iterator = backingRowMap.entrySet().iterator();
			_1 result2 = new _1(this, iterator);
			_ = null;
			return result2;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Ljava/util/Map$Entry<TC;TV;>;>;")]
		[LineNumberTable(new byte[] { 161, 54, 102, 104, 136 })]
		internal override Spliterator entrySpliterator()
		{
			updateBackingRowMapField();
			if (backingRowMap == null)
			{
				Spliterator result = Spliterators.emptySpliterator();
				_ = null;
				return result;
			}
			Spliterator result2 = CollectSpliterators.map(backingRowMap.entrySet().spliterator(), new ___003C_003EAnon0(this));
			_ = null;
			return result2;
		}
	}

	[Signature("Lcom/google/common/collect/Maps$ViewCachingAbstractMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	internal class RowMap : Maps.ViewCachingAbstractMap
	{
		[InnerClass(null, (Modifiers)0)]
		[Signature("Lcom/google/common/collect/StandardTable<TR;TC;TV;>.TableSet<Ljava/util/Map$Entry<TR;Ljava/util/Map<TC;TV;>;>;>;")]
		internal class EntrySet : TableSet
		{
			[SpecialName]
			[InnerClass(null, (Modifiers)0)]
			[Signature("Ljava/lang/Object;Lcom/google/common/base/Function<TR;Ljava/util/Map<TC;TV;>;>;")]
			[EnclosingMethod(null, "iterator", "()Ljava.util.Iterator;")]
			[Implements(new string[] { "com.google.common.base.Function" })]
			internal class _1 : java.lang.Object, com.google.common.@base.Function, java.util.function.Function
			{
				[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
				internal EntrySet this_00242;

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Signature("(TR;)Ljava/util/Map<TC;TV;>;")]
				[LineNumberTable(856)]
				public virtual Map apply(object P_0)
				{
					Map result = this_00242.this_00241.this_00240.row(P_0);
					_ = null;
					return result;
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[LineNumberTable(853)]
				internal _1(EntrySet P_0)
				{
					this_00242 = P_0;
					base._002Ector();
				}

				[MethodImpl(MethodImplOptions.NoInlining)]
				[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
				[LineNumberTable(853)]
				public virtual object apply(object P_0)
				{
					Map result = this.apply(P_0);
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

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal RowMap this_00241;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(848)]
			internal EntrySet(RowMap P_0)
			{
				this_00241 = P_0;
				base._002Ector(P_0.this_00240, null);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Iterator<Ljava/util/Map$Entry<TR;Ljava/util/Map<TC;TV;>;>;>;")]
			[LineNumberTable(new byte[] { 162, 225, 112, 43 })]
			public override Iterator iterator()
			{
				Iterator result = Maps.asMapEntryIterator(this_00241.this_00240.backingMap.keySet(), new _1(this));
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(863)]
			public override int size()
			{
				int result = this_00241.this_00240.backingMap.size();
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 242, 104, 103, 105, 124, 17, 193 })]
			public override bool contains([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (P_0 is Map.Entry)
				{
					Map.Entry entry = (Map.Entry)P_0;
					return (entry.getKey() != null && entry.getValue() is Map && Collections2.safeContains(this_00241.this_00240.backingMap.entrySet(), entry)) ? true : false;
				}
				return false;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 162, 253, 104, 103, 105, 124, 17, 193 })]
			public override bool remove([CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})] object P_0)
			{
				if (P_0 is Map.Entry)
				{
					Map.Entry entry = (Map.Entry)P_0;
					return (entry.getKey() != null && entry.getValue() is Map && this_00241.this_00240.backingMap.entrySet().remove(entry)) ? true : false;
				}
				return false;
			}
		}

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal StandardTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(821)]
		internal RowMap(StandardTable P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Map<TC;TV;>;")]
		[LineNumberTable(839)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Map remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (P_0 != null) ? ((Map)this_00240.backingMap.remove(P_0)) : null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)Ljava/util/Map<TC;TV;>;")]
		[LineNumberTable(833)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public new virtual Map get([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (!this_00240.containsRow(P_0)) ? null : this_00240.row(java.util.Objects.requireNonNull(P_0));
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(824)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = this_00240.containsRow(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TR;Ljava/util/Map<TC;TV;>;>;>;")]
		[LineNumberTable(844)]
		protected internal override Set createEntrySet()
		{
			EntrySet result = new EntrySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(820)]
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
			Map result = remove(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(820)]
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
			Map result = get(P_0);
			_ = null;
			return result;
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Abstract)]
	[Signature("<T:Ljava/lang/Object;>Lcom/google/common/collect/Sets$ImprovedAbstractSet<TT;>;")]
	internal abstract class TableSet : Sets.ImprovedAbstractSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal StandardTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(212)]
		private TableSet(StandardTable P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(215)]
		public override bool isEmpty()
		{
			bool result = this_00240.backingMap.isEmpty();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 106, 114 })]
		public override void clear()
		{
			this_00240.backingMap.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(212)]
		internal TableSet(StandardTable P_0, _1 P_1)
			: this(P_0)
		{
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
			Spliterator result = lambda_0024cellSpliterator_00241((Map.Entry)P_0);
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
	private sealed class ___003C_003EAnon1 : java.util.function.Function
	{
		private readonly Map.Entry arg_00241;

		internal ___003C_003EAnon1(Map.Entry P_0)
		{
			arg_00241 = P_0;
		}

		public object apply(object P_0)
		{
			Table.Cell result = lambda_0024cellSpliterator_00240(arg_00241, (Map.Entry)P_0);
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

	[Modifiers(Modifiers.Final)]
	[Signature("Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;")]
	[GwtTransient(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/GwtTransient;"
	})]
	internal Map backingMap;

	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/base/Supplier<+Ljava/util/Map<TC;TV;>;>;")]
	[GwtTransient(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/GwtTransient;"
	})]
	internal com.google.common.@base.Supplier factory;

	[NonSerialized]
	[Signature("Ljava/util/Set<TC;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new Set m_columnKeySet;

	[NonSerialized]
	[Signature("Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new Map m_rowMap;

	[NonSerialized]
	[Signature("Lcom/google/common/collect/StandardTable<TR;TC;TV;>.ColumnMap;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private new ColumnMap m_columnMap;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/Map<TR;TV;>;")]
	[LineNumberTable(new byte[]
	{
		125, 102, 113, 104, 108, 114, 99, 110, 114, 166,
		98
	})]
	private Map removeColumn([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		LinkedHashMap linkedHashMap = new LinkedHashMap();
		Iterator iterator = backingMap.entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			object obj = ((Map)entry.getValue()).remove(P_0);
			if (obj != null)
			{
				((Map)linkedHashMap).put(entry.getKey(), obj);
				if (((Map)entry.getValue()).isEmpty())
				{
					iterator.remove();
				}
			}
		}
		return linkedHashMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 84, 107, 105, 130 })]
	private bool removeMapping([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_2)
	{
		if (containsMapping(P_0, P_1, P_2))
		{
			remove(P_0, P_1);
			return true;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(192)]
	private bool containsMapping([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_2)
	{
		return (P_2 != null && java.lang.Object.instancehelper_equals(P_2, get(P_0, P_1))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;)Ljava/util/Map<TC;TV;>;")]
	[LineNumberTable(new byte[] { 87, 114, 99, 113, 142 })]
	private Map getOrCreate(object P_0)
	{
		Map map = (Map)backingMap.get(P_0);
		if (map == null)
		{
			map = (Map)factory.get();
			backingMap.put(P_0, map);
		}
		return map;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(112)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		object result = ((P_0 != null && P_1 != null) ? base.get(P_0, P_1) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 109, 102, 130, 114, 99, 130, 104, 104, 141 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		if (P_0 == null || P_1 == null)
		{
			return null;
		}
		Map map = (Map)Maps.safeGet(backingMap, P_0);
		if (map == null)
		{
			return null;
		}
		object result = map.remove(P_1);
		if (map.isEmpty())
		{
			backingMap.remove(P_0);
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 72, 98, 127, 6, 105, 98 })]
	public override int size()
	{
		int num = 0;
		Iterator iterator = backingMap.values().iterator();
		while (iterator.hasNext())
		{
			Map map = (Map)iterator.next();
			num += map.size();
		}
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;")]
	[LineNumberTable(new byte[] { 162, 186, 103 })]
	public override Map rowMap()
	{
		Map map = this.m_rowMap;
		Map result;
		if (map == null)
		{
			Map map2 = createRowMap();
			result = map2;
			this.m_rowMap = map2;
		}
		else
		{
			result = map;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;")]
	[LineNumberTable(817)]
	internal virtual Map createRowMap()
	{
		RowMap result = new RowMap(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 160, 188, 97, 63, 0 })]
	private static Spliterator lambda_0024cellSpliterator_00241(Map.Entry P_0)
	{
		Spliterator result = CollectSpliterators.map(((Map)P_0.getValue()).entrySet().spliterator(), new ___003C_003EAnon1(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 160, 191, 97, 49 })]
	private static Table.Cell lambda_0024cellSpliterator_00240(Map.Entry P_0, Map.Entry P_1)
	{
		Table.Cell result = Tables.immutableCell(P_0.getKey(), P_1.getKey(), P_1.getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/Map<TC;TV;>;>;)V")]
	[LineNumberTable(new byte[] { 24, 104, 103, 103 })]
	internal StandardTable(Map P_0, com.google.common.@base.Supplier P_1)
	{
		backingMap = P_0;
		factory = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(83)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		return (P_0 != null && P_1 != null && base.contains(P_0, P_1)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 38, 99, 130, 127, 6, 105, 130, 98 })]
	public override bool containsColumn([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 == null)
		{
			return false;
		}
		Iterator iterator = backingMap.values().iterator();
		while (iterator.hasNext())
		{
			Map map = (Map)iterator.next();
			if (Maps.safeContainsKey(map, P_0))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(101)]
	public override bool containsRow([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (P_0 != null && Maps.safeContainsKey(backingMap, P_0)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(106)]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (P_0 != null && base.containsValue(P_0)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(117)]
	public override bool isEmpty()
	{
		bool result = backingMap.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 83, 109 })]
	public override void clear()
	{
		backingMap.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;TC;TV;)TV;")]
	[LineNumberTable(new byte[] { 99, 103, 103, 103 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object put(object P_0, object P_1, object P_2)
	{
		Preconditions.checkNotNull(P_0);
		Preconditions.checkNotNull(P_1);
		Preconditions.checkNotNull(P_2);
		object result = getOrCreate(P_0).put(P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(235)]
	public override Set cellSet()
	{
		Set result = base.cellSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(240)]
	internal override Iterator cellIterator()
	{
		CellIterator result = new CellIterator(this, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(new byte[] { 160, 185, 102, 247, 72, 230, 55 })]
	internal override Spliterator cellSpliterator()
	{
		Spliterator result = CollectSpliterators.flatMap(backingMap.entrySet().spliterator(), new ___003C_003EAnon0(), 65, size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;)Ljava/util/Map<TC;TV;>;")]
	[LineNumberTable(313)]
	public override Map row(object P_0)
	{
		Row result = new Row(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Ljava/util/Map<TR;TV;>;")]
	[LineNumberTable(459)]
	public override Map column(object P_0)
	{
		Column result = new Column(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TR;>;")]
	[LineNumberTable(674)]
	public override Set rowKeySet()
	{
		Set result = rowMap().keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TC;>;")]
	[LineNumberTable(new byte[] { 162, 63, 103 })]
	public override Set columnKeySet()
	{
		Set set = this.m_columnKeySet;
		object set2;
		if (set == null)
		{
			ColumnKeySet columnKeySet = new ColumnKeySet(this, null);
			set2 = columnKeySet;
			this.m_columnKeySet = columnKeySet;
		}
		else
		{
			set2 = set;
		}
		return (set2 == null) ? null : ((set2 as Set) ?? throw new java.lang.IncompatibleClassChangeError());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TC;>;")]
	[LineNumberTable(768)]
	internal virtual Iterator createColumnKeyIterator()
	{
		ColumnKeyIterator result = new ColumnKeyIterator(this, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(805)]
	public override Collection values()
	{
		Collection result = base.values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TC;Ljava/util/Map<TR;TV;>;>;")]
	[LineNumberTable(new byte[] { 163, 12, 103 })]
	public override Map columnMap()
	{
		ColumnMap columnMap = this.m_columnMap;
		ColumnMap result;
		if (columnMap == null)
		{
			ColumnMap columnMap2 = new ColumnMap(this, null);
			result = columnMap2;
			this.m_columnMap = columnMap2;
		}
		else
		{
			result = columnMap;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(70)]
	internal static bool access_0024300(StandardTable P_0, object P_1, object P_2, object P_3)
	{
		bool result = P_0.containsMapping(P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(70)]
	internal static bool access_0024400(StandardTable P_0, object P_1, object P_2, object P_3)
	{
		bool result = P_0.removeMapping(P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(70)]
	internal static Map access_0024900(StandardTable P_0, object P_1)
	{
		Map result = P_0.removeColumn(P_1);
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
	protected StandardTable(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}
}
