using System;
using System.ComponentModel;
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
[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/StandardRowSortedTable<TR;TC;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public class TreeBasedTable : StandardRowSortedTable
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/AbstractIterator<TC;>;")]
	[EnclosingMethod(null, "createColumnKeyIterator", "()Ljava.util.Iterator;")]
	internal new class _1 : AbstractIterator
	{
		[Signature("TC;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object lastValue;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Iterator val_0024merged;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal Comparator val_0024comparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(323)]
		internal _1(TreeBasedTable P_0, Iterator P_1, Comparator P_2)
		{
			val_0024merged = P_1;
			val_0024comparator = P_2;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TC;")]
		[LineNumberTable(new byte[]
		{
			160, 215, 109, 108, 191, 2, 99, 103, 135, 130,
			103
		})]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		protected internal override object computeNext()
		{
			while (val_0024merged.hasNext())
			{
				object o = val_0024merged.next();
				if ((lastValue == null || val_0024comparator.compare(o, lastValue) != 0) && 0 == 0)
				{
					lastValue = o;
					return lastValue;
				}
			}
			lastValue = null;
			object result = endOfData();
			_ = null;
			return result;
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("<C:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/base/Supplier<Ljava/util/TreeMap<TC;TV;>;>;Ljava/io/Serializable;")]
	[Implements(new string[] { "com.google.common.base.Supplier", "java.io.Serializable" })]
	internal class Factory : java.lang.Object, com.google.common.@base.Supplier, java.util.function.Supplier, Serializable.__Interface, ISerializable
	{
		[Modifiers(Modifiers.Final)]
		[Signature("Ljava/util/Comparator<-TC;>;")]
		internal Comparator comparator;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TC;>;)V")]
		[LineNumberTable(new byte[] { 26, 104, 103 })]
		internal Factory(Comparator P_0)
		{
			comparator = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/TreeMap<TC;TV;>;")]
		[LineNumberTable(82)]
		public virtual TreeMap get()
		{
			TreeMap.___003Cclinit_003E();
			TreeMap result = new TreeMap(comparator);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(73)]
		public virtual object get()
		{
			TreeMap result = this.get();
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
		protected Factory(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}
	}

	[InnerClass(null, Modifiers.Private)]
	[Signature("Lcom/google/common/collect/StandardTable<TR;TC;TV;>.Row;Ljava/util/SortedMap<TC;TV;>;")]
	[Implements(new string[] { "java.util.SortedMap" })]
	internal class TreeRow : Row, SortedMap, Map
	{
		[Modifiers(Modifiers.Final)]
		[Signature("TC;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object lowerBound;

		[Modifiers(Modifiers.Final)]
		[Signature("TC;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal object upperBound;

		[NonSerialized]
		[Signature("Ljava/util/SortedMap<TC;TV;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal SortedMap wholeRow;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new TreeBasedTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;)V")]
		[LineNumberTable(new byte[] { 160, 67, 108 })]
		internal TreeRow(TreeBasedTable P_0, object P_1)
			: this(P_0, P_1, null, null)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;TC;TC;)V")]
		[LineNumberTable(new byte[] { 160, 70, 103, 106, 103, 104, 107, 44, 135 })]
		internal TreeRow(TreeBasedTable P_0, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_1, [CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_2, object P_3)
		{
			this_00240 = P_0;
			base._002Ector(P_0, P_1);
			lowerBound = P_2;
			upperBound = P_3;
			Preconditions.checkArgument((P_2 == null || P_3 == null || compare(P_2, P_3) <= 0) ? true : false);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 91, 103 })]
		internal virtual int compare(object P_0, object P_1)
		{
			Comparator comparator = this.comparator();
			int result = comparator.compare(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TC;>;")]
		[LineNumberTable(199)]
		public virtual Comparator comparator()
		{
			Comparator result = this_00240.columnComparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 96, 115, 120, 12 })]
		internal virtual bool rangeContains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (P_0 != null && (lowerBound == null || compare(lowerBound, P_0) <= 0) && (upperBound == null || compare(upperBound, P_0) > 0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 141, 127, 14, 159, 2 })]
		internal virtual void updateWholeRowField()
		{
			if (wholeRow == null || (wholeRow.isEmpty() && this_00240.backingMap.containsKey(rowKey)))
			{
				wholeRow = (SortedMap)this_00240.backingMap.get(rowKey);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedMap<TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 149, 102, 103, 99, 104, 141, 104, 141, 130 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal new virtual SortedMap computeBackingRowMap()
		{
			updateWholeRowField();
			SortedMap sortedMap = wholeRow;
			if (sortedMap != null)
			{
				if (lowerBound != null)
				{
					sortedMap = sortedMap.tailMap(lowerBound);
				}
				if (upperBound != null)
				{
					sortedMap = sortedMap.headMap(upperBound);
				}
				return sortedMap;
			}
			return null;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TC;>;")]
		[LineNumberTable(194)]
		public new virtual SortedSet keySet()
		{
			Maps.SortedKeySet result = new Maps.SortedKeySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;TC;)Ljava/util/SortedMap<TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 103, 127, 6 })]
		public virtual SortedMap subMap(object P_0, object P_1)
		{
			Preconditions.checkArgument((rangeContains(Preconditions.checkNotNull(P_0)) && rangeContains(Preconditions.checkNotNull(P_1))) ? true : false);
			TreeRow result = new TreeRow(this_00240, rowKey, P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Ljava/util/SortedMap<TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 109, 113 })]
		public virtual SortedMap headMap(object P_0)
		{
			Preconditions.checkArgument(rangeContains(Preconditions.checkNotNull(P_0)));
			TreeRow result = new TreeRow(this_00240, rowKey, lowerBound, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;)Ljava/util/SortedMap<TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 115, 113 })]
		public virtual SortedMap tailMap(object P_0)
		{
			Preconditions.checkArgument(rangeContains(Preconditions.checkNotNull(P_0)));
			TreeRow result = new TreeRow(this_00240, rowKey, P_0, upperBound);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TC;")]
		[LineNumberTable(new byte[] { 160, 121, 102, 104, 139 })]
		public virtual object firstKey()
		{
			updateBackingRowMapField();
			if (backingRowMap == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			object result = ((SortedMap)backingRowMap).firstKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TC;")]
		[LineNumberTable(new byte[] { 160, 130, 102, 104, 139 })]
		public virtual object lastKey()
		{
			updateBackingRowMapField();
			if (backingRowMap == null)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NoSuchElementException();
			}
			object result = ((SortedMap)backingRowMap).lastKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 165, 102, 117, 119, 103, 135 })]
		internal override void maintainEmptyInvariant()
		{
			updateWholeRowField();
			if (wholeRow != null && wholeRow.isEmpty())
			{
				this_00240.backingMap.remove(rowKey);
				wholeRow = null;
				backingRowMap = null;
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(289)]
		public override bool containsKey([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			return (rangeContains(P_0) && base.containsKey(P_0)) ? true : false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TC;TV;)TV;")]
		[LineNumberTable(new byte[] { 160, 181, 113 })]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public override object put(object P_0, object P_1)
		{
			Preconditions.checkArgument(rangeContains(Preconditions.checkNotNull(P_0)));
			object result = base.put(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(176)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override Map computeBackingRowMap()
		{
			SortedMap result = computeBackingRowMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(176)]
		public override Set keySet()
		{
			SortedSet result = keySet();
			_ = null;
			return result;
		}

		Collection SortedMap.SortedMap_003A_003Avalues()
		{
			return values();
		}

		void Map.Map_003A_003AputAll(Map P_0)
		{
			putAll(P_0);
		}

		object Map.Map_003A_003AputIfAbsent(object P_0, object P_1)
		{
			return putIfAbsent(P_0, P_1);
		}

		Collection Map.Map_003A_003Avalues()
		{
			return values();
		}

		bool Map.Map_003A_003AisEmpty()
		{
			return isEmpty();
		}

		bool Map.Map_003A_003AcontainsValue(object P_0)
		{
			return containsValue(P_0);
		}

		bool Map.Map_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}

		int Map.Map_003A_003AhashCode()
		{
			return hashCode();
		}

		object Map.Map_003A_003AgetOrDefault(object P_0, object P_1)
		{
			return getOrDefault(P_0, P_1);
		}

		void Map.Map_003A_003AforEach(BiConsumer P_0)
		{
			forEach(P_0);
		}

		void Map.Map_003A_003AreplaceAll(BiFunction P_0)
		{
			replaceAll(P_0);
		}

		bool Map.Map_003A_003Aremove(object P_0, object P_1)
		{
			return remove(P_0, P_1);
		}

		bool Map.Map_003A_003Areplace(object P_0, object P_1, object P_2)
		{
			return replace(P_0, P_1, P_2);
		}

		object Map.Map_003A_003Areplace(object P_0, object P_1)
		{
			return replace(P_0, P_1);
		}

		object Map.Map_003A_003AcomputeIfAbsent(object P_0, java.util.function.Function P_1)
		{
			return computeIfAbsent(P_0, P_1);
		}

		object Map.Map_003A_003AcomputeIfPresent(object P_0, BiFunction P_1)
		{
			return computeIfPresent(P_0, P_1);
		}

		object Map.Map_003A_003Acompute(object P_0, BiFunction P_1)
		{
			return compute(P_0, P_1);
		}

		object Map.Map_003A_003Amerge(object P_0, object P_1, BiFunction P_2)
		{
			return merge(P_0, P_1, P_2);
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : com.google.common.@base.Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			Iterator result = lambda_0024createColumnKeyIterator_00240((Map)P_0);
			_ = null;
			return result;
		}

		[SpecialName]
		public bool equals(object P_0)
		{
			return java.lang.Object.instancehelper_equals(this, P_0);
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

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Ljava/util/Comparator<-TC;>;")]
	private Comparator m_columnComparator;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TR;>;Ljava/util/Comparator<-TC;>;)V")]
	[LineNumberTable(new byte[] { 75, 116, 103 })]
	internal TreeBasedTable(Comparator P_0, Comparator P_1)
		: base(new TreeMap(P_0), new Factory(P_1))
	{
		this.m_columnComparator = P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("()Ljava/util/Comparator<-TR;>;")]
	[LineNumberTable(143)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual Comparator rowComparator()
	{
		return (Comparator)java.util.Objects.requireNonNull(rowKeySet().comparator());
	}

	[Obsolete]
	[Signature("()Ljava/util/Comparator<-TC;>;")]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public virtual Comparator columnComparator()
	{
		return this.m_columnComparator;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override void putAll(Table t)
	{
		base.putAll(t);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/SortedSet<TR;>;")]
	[LineNumberTable(304)]
	public override SortedSet rowKeySet()
	{
		SortedSet result = base.rowKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	[LineNumberTable(309)]
	public override SortedMap rowMap()
	{
		SortedMap result = base.rowMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;)Ljava/util/SortedMap<TC;TV;>;")]
	[LineNumberTable(173)]
	public new virtual SortedMap row(object rowKey)
	{
		TreeRow result = new TreeRow(this, rowKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(320)]
	private static Iterator lambda_0024createColumnKeyIterator_00240(Map P_0)
	{
		Iterator result = P_0.keySet().iterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R::Ljava/lang/Comparable;C::Ljava/lang/Comparable;V:Ljava/lang/Object;>()Lcom/google/common/collect/TreeBasedTable<TR;TC;TV;>;")]
	[LineNumberTable(97)]
	public static TreeBasedTable create()
	{
		TreeBasedTable result = new TreeBasedTable(Ordering.natural(), Ordering.natural());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/Comparator<-TR;>;Ljava/util/Comparator<-TC;>;)Lcom/google/common/collect/TreeBasedTable<TR;TC;TV;>;")]
	[LineNumberTable(new byte[] { 58, 103, 103 })]
	public static TreeBasedTable create(Comparator rowComparator, Comparator columnComparator)
	{
		Preconditions.checkNotNull(rowComparator);
		Preconditions.checkNotNull(columnComparator);
		TreeBasedTable result = new TreeBasedTable(rowComparator, columnComparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/TreeBasedTable<TR;TC;+TV;>;)Lcom/google/common/collect/TreeBasedTable<TR;TC;TV;>;")]
	[LineNumberTable(new byte[] { 68, 97, 113, 103 })]
	public static TreeBasedTable create(TreeBasedTable table)
	{
		TreeBasedTable treeBasedTable = new TreeBasedTable(table.rowComparator(), table.columnComparator());
		treeBasedTable.putAll(table);
		return treeBasedTable;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TC;>;")]
	[LineNumberTable(new byte[] { 160, 201, 135, 166, 47, 38, 230, 69 })]
	internal override Iterator createColumnKeyIterator()
	{
		Comparator comparator = columnComparator();
		UnmodifiableIterator unmodifiableIterator = Iterators.mergeSorted(Iterables.transform(backingMap.values(), new ___003C_003EAnon0()), comparator);
		_1 result = new _1(this, unmodifiableIterator, comparator);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(68)]
	public virtual Map _003Cbridge_003ErowMap()
	{
		SortedMap result = rowMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(68)]
	public virtual Set _003Cbridge_003ErowKeySet()
	{
		SortedSet result = rowKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(68)]
	public virtual Map _003Cbridge_003Erow(object obj)
	{
		SortedMap result = row(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override Map columnMap()
	{
		Map result = base.columnMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override Collection values()
	{
		Collection result = base.values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override Set columnKeySet()
	{
		Set result = base.columnKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override Map column(object obj)
	{
		Map result = base.column(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override Set cellSet()
	{
		Set result = base.cellSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2)
	{
		object result = base.remove(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object put(object obj1, object obj2, object obj3)
	{
		object result = base.put(obj1, obj2, obj3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override void clear()
	{
		base.clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override int size()
	{
		int result = base.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override bool isEmpty()
	{
		bool result = base.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2)
	{
		object result = base.get(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.containsValue(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override bool containsRow([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.containsRow(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override bool containsColumn([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		bool result = base.containsColumn(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2)
	{
		bool result = base.contains(obj1, obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override string toString()
	{
		string result = base.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
	public override int hashCode()
	{
		int result = base.hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(68)]
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

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected TreeBasedTable(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
