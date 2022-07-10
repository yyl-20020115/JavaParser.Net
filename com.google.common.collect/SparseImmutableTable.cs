using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;

namespace com.google.common.collect;

[Serializable]
[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/RegularImmutableTable<TR;TC;TV;>;")]
[Immutable(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/Immutable;",
	"containerOf",
	new object[]
	{
		(byte)91,
		"R",
		"C",
		"V"
	}
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class SparseImmutableTable : RegularImmutableTable
{
	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableTable<Ljava/lang/Object;Ljava/lang/Object;Ljava/lang/Object;>;")]
	internal static ImmutableTable EMPTY;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TR;Lcom/google/common/collect/ImmutableMap<TC;TV;>;>;")]
	private new ImmutableMap m_rowMap;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TC;Lcom/google/common/collect/ImmutableMap<TR;TV;>;>;")]
	private new ImmutableMap m_columnMap;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int[] cellRowIndices;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int[] cellColumnInRowIndices;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;Lcom/google/common/collect/ImmutableSet<TR;>;Lcom/google/common/collect/ImmutableSet<TC;>;)V")]
	[LineNumberTable(new byte[]
	{
		159,
		191,
		104,
		103,
		102,
		119,
		110,
		98,
		103,
		122,
		111,
		98,
		109,
		109,
		112,
		111,
		105,
		105,
		233,
		70,
		127,
		2,
		121,
		108,
		109,
		110,
		byte.MaxValue,
		3,
		49,
		235,
		81,
		104,
		104,
		97,
		108,
		127,
		5,
		127,
		1,
		98,
		141,
		98,
		108,
		127,
		6,
		127,
		1,
		98,
		109
	})]
	internal SparseImmutableTable(ImmutableList P_0, ImmutableSet P_1, ImmutableSet P_2)
	{
		ImmutableMap immutableMap = Maps.indexMap(P_1);
		LinkedHashMap linkedHashMap = Maps.newLinkedHashMap();
		UnmodifiableIterator unmodifiableIterator = P_1.iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			object key = ((Iterator)unmodifiableIterator).next();
			((Map)linkedHashMap).put(key, (object)new LinkedHashMap());
		}
		LinkedHashMap linkedHashMap2 = Maps.newLinkedHashMap();
		UnmodifiableIterator unmodifiableIterator2 = P_2.iterator();
		while (((Iterator)unmodifiableIterator2).hasNext())
		{
			object key2 = ((Iterator)unmodifiableIterator2).next();
			((Map)linkedHashMap2).put(key2, (object)new LinkedHashMap());
		}
		int[] array = new int[P_0.size()];
		int[] array2 = new int[P_0.size()];
		for (int i = 0; i < P_0.size(); i++)
		{
			Table.Cell cell = (Table.Cell)P_0.get(i);
			object rowKey = cell.getRowKey();
			object columnKey = cell.getColumnKey();
			object value = cell.getValue();
			array[i] = ((Integer)Objects.requireNonNull((Integer)((Map)immutableMap).get(rowKey))).intValue();
			Map map = (Map)Objects.requireNonNull((Map)((Map)linkedHashMap).get(rowKey));
			array2[i] = map.size();
			object obj = map.put(columnKey, value);
			checkNoDuplicate(rowKey, columnKey, obj, value);
			((Map)Objects.requireNonNull((Map)((Map)linkedHashMap2).get(columnKey))).put(rowKey, value);
		}
		cellRowIndices = array;
		cellColumnInRowIndices = array2;
		ImmutableMap.Builder builder = new ImmutableMap.Builder(((Map)linkedHashMap).size());
		Iterator iterator = ((Map)linkedHashMap).entrySet().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			builder.put(entry.getKey(), ImmutableMap.copyOf((Map)entry.getValue()));
		}
		this.m_rowMap = builder.buildOrThrow();
		ImmutableMap.Builder builder2 = new ImmutableMap.Builder(((Map)linkedHashMap2).size());
		Iterator iterator2 = ((Map)linkedHashMap2).entrySet().iterator();
		while (iterator2.hasNext())
		{
			Map.Entry entry2 = (Map.Entry)iterator2.next();
			builder2.put(entry2.getKey(), ImmutableMap.copyOf((Map)entry2.getValue()));
		}
		this.m_columnMap = builder2.buildOrThrow();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMap<TC;Ljava/util/Map<TR;TV;>;>;")]
	[LineNumberTable(new byte[] { 48, 103 })]
	public override ImmutableMap columnMap()
	{
		ImmutableMap map = this.m_columnMap;
		ImmutableMap result = ImmutableMap.copyOf(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	[LineNumberTable(new byte[] { 55, 103 })]
	public override ImmutableMap rowMap()
	{
		ImmutableMap map = this.m_rowMap;
		ImmutableMap result = ImmutableMap.copyOf(map);
		_ = null;
		return result;
	}

	[LineNumberTable(111)]
	public override int size()
	{
		return cellRowIndices.Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;")]
	[LineNumberTable(new byte[] { 66, 105, 124, 108, 105, 120 })]
	internal override Table.Cell getCell(int P_0)
	{
		int num = cellRowIndices[P_0];
		Map.Entry entry = (Map.Entry)this.m_rowMap.entrySet().asList().get(num);
		ImmutableMap immutableMap = (ImmutableMap)entry.getValue();
		int num2 = cellColumnInRowIndices[P_0];
		Map.Entry entry2 = (Map.Entry)immutableMap.entrySet().asList().get(num2);
		Table.Cell result = ImmutableTable.cellOf(entry.getKey(), entry2.getKey(), entry2.getValue());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TV;")]
	[LineNumberTable(new byte[] { 76, 105, 124, 105 })]
	internal override object getValue(int P_0)
	{
		int num = cellRowIndices[P_0];
		ImmutableMap immutableMap = (ImmutableMap)this.m_rowMap.values().asList().get(num);
		int num2 = cellColumnInRowIndices[P_0];
		object result = immutableMap.values().asList().get(num2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 84, 108, 113, 98, 159, 2, 127, 9, 98 })]
	internal override SerializedForm createSerializedForm()
	{
		ImmutableMap immutableMap = Maps.indexMap(base.columnKeySet());
		int[] array = new int[base.cellSet().size()];
		int num = 0;
		UnmodifiableIterator unmodifiableIterator = base.cellSet().iterator();
		while (((Iterator)unmodifiableIterator).hasNext())
		{
			Table.Cell cell = (Table.Cell)((Iterator)unmodifiableIterator).next();
			int num2 = num;
			num++;
			array[num2] = ((Integer)Objects.requireNonNull((Integer)((Map)immutableMap).get(cell.getColumnKey()))).intValue();
		}
		SerializedForm result = SerializedForm.create(this, cellRowIndices, array);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public new virtual Map columnMap()
	{
		ImmutableMap result = this.columnMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(26)]
	public new virtual Map rowMap()
	{
		ImmutableMap result = this.rowMap();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 159, 174, 25 })]
	static SparseImmutableTable()
	{
		EMPTY = new SparseImmutableTable(ImmutableList.of(), ImmutableSet.of(), ImmutableSet.of());
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected SparseImmutableTable(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
