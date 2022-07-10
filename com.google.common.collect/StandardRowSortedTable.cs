using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/StandardTable<TR;TC;TV;>;Lcom/google/common/collect/RowSortedTable<TR;TC;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.RowSortedTable" })]
internal class StandardRowSortedTable : StandardTable, RowSortedTable, Table
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
	[Signature("Lcom/google/common/collect/StandardTable<TR;TC;TV;>.RowMap;Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	[Implements(new string[] { "java.util.SortedMap" })]
	internal class RowSortedMap : RowMap, SortedMap, Map
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal new StandardRowSortedTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(95)]
		internal RowSortedMap(StandardRowSortedTable P_0, _1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(95)]
		private RowSortedMap(StandardRowSortedTable P_0)
		{
			this_00240 = P_0;
			base._002Ector(P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TR;>;")]
		[LineNumberTable(103)]
		internal new virtual SortedSet createKeySet()
		{
			Maps.SortedKeySet result = new Maps.SortedKeySet(this);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/SortedSet<TR;>;")]
		[LineNumberTable(98)]
		public new virtual SortedSet keySet()
		{
			return (SortedSet)base.keySet();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Comparator<-TR;>;")]
		[LineNumberTable(109)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		public virtual Comparator comparator()
		{
			Comparator result = access_0024100(this_00240).comparator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TR;")]
		[LineNumberTable(114)]
		public virtual object firstKey()
		{
			object result = access_0024100(this_00240).firstKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()TR;")]
		[LineNumberTable(119)]
		public virtual object lastKey()
		{
			object result = access_0024100(this_00240).lastKey();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;)Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;")]
		[LineNumberTable(new byte[] { 74, 103, 127, 2, 39 })]
		public virtual SortedMap headMap(object P_0)
		{
			Preconditions.checkNotNull(P_0);
			SortedMap result = new StandardRowSortedTable(access_0024100(this_00240).headMap(P_0), this_00240.factory).rowMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;TR;)Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;")]
		[LineNumberTable(new byte[] { 81, 103, 103, 127, 3, 39 })]
		public virtual SortedMap subMap(object P_0, object P_1)
		{
			Preconditions.checkNotNull(P_0);
			Preconditions.checkNotNull(P_1);
			SortedMap result = new StandardRowSortedTable(access_0024100(this_00240).subMap(P_0, P_1), this_00240.factory).rowMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;)Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;")]
		[LineNumberTable(new byte[] { 89, 103, 127, 2, 39 })]
		public virtual SortedMap tailMap(object P_0)
		{
			Preconditions.checkNotNull(P_0);
			SortedMap result = new StandardRowSortedTable(access_0024100(this_00240).tailMap(P_0), this_00240.factory).rowMap();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(94)]
		internal override Set createKeySet()
		{
			SortedSet result = createKeySet();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(94)]
		public override Set keySet()
		{
			SortedSet result = keySet();
			_ = null;
			return result;
		}

		int Map.Map_003A_003Asize()
		{
			return size();
		}

		object Map.Map_003A_003Aput(object P_0, object P_1)
		{
			return put(P_0, P_1);
		}

		void Map.Map_003A_003AputAll(Map P_0)
		{
			putAll(P_0);
		}

		object Map.Map_003A_003AputIfAbsent(object P_0, object P_1)
		{
			return putIfAbsent(P_0, P_1);
		}

		bool Map.Map_003A_003AisEmpty()
		{
			return isEmpty();
		}

		bool Map.Map_003A_003AcontainsValue(object P_0)
		{
			return containsValue(P_0);
		}

		void Map.Map_003A_003Aclear()
		{
			clear();
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

	private const long serialVersionUID = 0L;

	[Signature("()Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	[LineNumberTable(64)]
	private SortedMap sortedBackingMap()
	{
		return (SortedMap)backingMap;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	[LineNumberTable(86)]
	public new virtual SortedMap rowMap()
	{
		return (SortedMap)base.rowMap();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	[LineNumberTable(91)]
	internal new virtual SortedMap createRowMap()
	{
		RowSortedMap result = new RowSortedMap(this, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/SortedSet<TR;>;")]
	[LineNumberTable(75)]
	public new virtual SortedSet rowKeySet()
	{
		return (SortedSet)rowMap().keySet();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;Lcom/google/common/base/Supplier<+Ljava/util/Map<TC;TV;>;>;)V")]
	[LineNumberTable(new byte[] { 10, 106 })]
	internal StandardRowSortedTable(SortedMap P_0, com.google.common.@base.Supplier P_1)
		: base(P_0, P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal override Map createRowMap()
	{
		SortedMap result = createRowMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	public override Map rowMap()
	{
		SortedMap result = rowMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	public override Set rowKeySet()
	{
		SortedSet result = rowKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(50)]
	internal static SortedMap access_0024100(StandardRowSortedTable P_0)
	{
		SortedMap result = P_0.sortedBackingMap();
		_ = null;
		return result;
	}

	Map RowSortedTable.RowSortedTable_003A_003ArowMap()
	{
		return this.rowMap();
	}

	Set RowSortedTable.RowSortedTable_003A_003ArowKeySet()
	{
		return this.rowKeySet();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected StandardRowSortedTable(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
