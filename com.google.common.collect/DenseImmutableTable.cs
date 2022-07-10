using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/RegularImmutableTable<TR;TC;TV;>;")]
[ConstantPool(new object[]
{
	(byte)67,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
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
internal sealed class DenseImmutableTable : RegularImmutableTable
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/DenseImmutableTable$ImmutableArrayMap<TR;TV;>;")]
	internal sealed class Column : ImmutableArrayMap
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int columnIndex;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DenseImmutableTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 127, 103, 112, 103 })]
		internal Column(DenseImmutableTable P_0, int P_1)
		{
			this_00240 = P_0;
			base._002Ector(access_0024500(P_0)[P_1]);
			columnIndex = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMap<TR;Ljava/lang/Integer;>;")]
		[LineNumberTable(184)]
		internal override ImmutableMap keyToIndex()
		{
			ImmutableMap result = access_0024600(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(190)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override object getValue(int P_0)
		{
			return access_0024400(this_00240)[P_0][columnIndex];
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[HideFromJava]
		static Column()
		{
			ImmutableArrayMap.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Column(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/DenseImmutableTable$ImmutableArrayMap<TC;Lcom/google/common/collect/ImmutableMap<TR;TV;>;>;")]
	internal sealed class ColumnMap : ImmutableArrayMap
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DenseImmutableTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(222)]
		internal ColumnMap(DenseImmutableTable P_0, DenseImmutableTable._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 109, 103, 111 })]
		private ColumnMap(DenseImmutableTable P_0)
		{
			this_00240 = P_0;
			base._002Ector(access_0024500(P_0).Length);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/ImmutableMap<TR;TV;>;")]
		[LineNumberTable(234)]
		internal new virtual ImmutableMap getValue(int P_0)
		{
			Column.___003Cclinit_003E();
			Column result = new Column(this_00240, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMap<TC;Ljava/lang/Integer;>;")]
		[LineNumberTable(229)]
		internal override ImmutableMap keyToIndex()
		{
			ImmutableMap result = access_0024300(this_00240);
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(221)]
		internal override object getValue(int P_0)
		{
			ImmutableMap value = getValue(P_0);
			_ = null;
			return value;
		}

		[HideFromJava]
		static ColumnMap()
		{
			ImmutableArrayMap.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ColumnMap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract)]
	[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableMap$IteratorBasedImmutableMap<TK;TV;>;")]
	internal abstract class ImmutableArrayMap : ImmutableMap.IteratorBasedImmutableMap
	{
		[SpecialName]
		[Signature("Lcom/google/common/collect/AbstractIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[EnclosingMethod(null, "entryIterator", "()Lcom.google.common.collect.UnmodifiableIterator;")]
		internal new class _1 : AbstractIterator
		{
			private int index;

			[Modifiers(Modifiers.Private | Modifiers.Final)]
			private int maxIndex;

			[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
			internal ImmutableArrayMap this_00240;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 80, 111, 103 })]
			internal _1(ImmutableArrayMap P_0)
			{
				this_00240 = P_0;
				base._002Ector();
				index = -1;
				maxIndex = this_00240.keyToIndex().size();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Signature("()Ljava/util/Map$Entry<TK;TV;>;")]
			[LineNumberTable(new byte[] { 87, 124, 114, 99, 250, 61, 240, 70 })]
			[CheckForNull(new object[]
			{
				(byte)64,
				"Ljavax/annotation/CheckForNull;"
			})]
			protected internal new virtual Map.Entry computeNext()
			{
				index++;
				while (index < maxIndex)
				{
					object value = this_00240.getValue(index);
					if (value != null)
					{
						Map.Entry result = Maps.immutableEntry(this_00240.getKey(index), value);
						_ = null;
						return result;
					}
					index++;
				}
				return (Map.Entry)endOfData();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
			[LineNumberTable(130)]
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
		private new int m_size;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		protected internal new static void ___003Cclinit_003E()
		{
		}

		[Signature("()Lcom/google/common/collect/ImmutableMap<TK;Ljava/lang/Integer;>;")]
		internal abstract ImmutableMap keyToIndex();

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(101)]
		private bool isFull()
		{
			return this.m_size == keyToIndex().size();
		}

		[Signature("(I)TV;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal abstract object getValue(int P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 43, 104, 103 })]
		internal ImmutableArrayMap(int P_0)
		{
			this.m_size = P_0;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TK;")]
		[LineNumberTable(105)]
		internal virtual object getKey(int P_0)
		{
			object result = keyToIndex().keySet().asList().get(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableSet<TK;>;")]
		[LineNumberTable(113)]
		internal override ImmutableSet createKeySet()
		{
			ImmutableSet result = ((!isFull()) ? base.createKeySet() : keyToIndex().keySet());
			_ = null;
			return result;
		}

		public override int size()
		{
			return this.m_size;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/lang/Object;)TV;")]
		[LineNumberTable(new byte[] { 74, 114 })]
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
			Integer integer = (Integer)keyToIndex().get(P_0);
			object result = ((integer != null) ? getValue(integer.intValue()) : null);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Ljava/util/Map$Entry<TK;TV;>;>;")]
		[LineNumberTable(130)]
		internal override UnmodifiableIterator entryIterator()
		{
			_1 result = new _1(this);
			_ = null;
			return result;
		}

		[HideFromJava]
		static ImmutableArrayMap()
		{
			IteratorBasedImmutableMap.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected ImmutableArrayMap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/DenseImmutableTable$ImmutableArrayMap<TC;TV;>;")]
	internal sealed class Row : ImmutableArrayMap
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int rowIndex;

		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DenseImmutableTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 102, 103, 112, 103 })]
		internal Row(DenseImmutableTable P_0, int P_1)
		{
			this_00240 = P_0;
			base._002Ector(access_0024200(P_0)[P_1]);
			rowIndex = P_1;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMap<TC;Ljava/lang/Integer;>;")]
		[LineNumberTable(159)]
		internal override ImmutableMap keyToIndex()
		{
			ImmutableMap result = access_0024300(this_00240);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)TV;")]
		[LineNumberTable(165)]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal override object getValue(int P_0)
		{
			return access_0024400(this_00240)[rowIndex][P_0];
		}

		internal override bool isPartialView()
		{
			return true;
		}

		[HideFromJava]
		static Row()
		{
			ImmutableArrayMap.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected Row(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/DenseImmutableTable$ImmutableArrayMap<TR;Lcom/google/common/collect/ImmutableMap<TC;TV;>;>;")]
	internal sealed class RowMap : ImmutableArrayMap
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal DenseImmutableTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public new static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(200)]
		internal RowMap(DenseImmutableTable P_0, DenseImmutableTable._1 P_1)
			: this(P_0)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 87, 103, 111 })]
		private RowMap(DenseImmutableTable P_0)
		{
			this_00240 = P_0;
			base._002Ector(access_0024200(P_0).Length);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(I)Lcom/google/common/collect/ImmutableMap<TC;TV;>;")]
		[LineNumberTable(212)]
		internal new virtual ImmutableMap getValue(int P_0)
		{
			Row.___003Cclinit_003E();
			Row result = new Row(this_00240, P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableMap<TR;Ljava/lang/Integer;>;")]
		[LineNumberTable(207)]
		internal override ImmutableMap keyToIndex()
		{
			ImmutableMap result = access_0024600(this_00240);
			_ = null;
			return result;
		}

		internal override bool isPartialView()
		{
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(199)]
		internal override object getValue(int P_0)
		{
			ImmutableMap value = getValue(P_0);
			_ = null;
			return value;
		}

		[HideFromJava]
		static RowMap()
		{
			ImmutableArrayMap.___003Cclinit_003E();
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected RowMap(SerializationInfo P_0, StreamingContext P_1)
			: base(P_0, P_1)
		{
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TR;Ljava/lang/Integer;>;")]
	private ImmutableMap rowKeyToIndex;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TC;Ljava/lang/Integer;>;")]
	private ImmutableMap columnKeyToIndex;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TR;Lcom/google/common/collect/ImmutableMap<TC;TV;>;>;")]
	private new ImmutableMap m_rowMap;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableMap<TC;Lcom/google/common/collect/ImmutableMap<TR;TV;>;>;")]
	private new ImmutableMap m_columnMap;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int[] rowCounts;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int[] columnCounts;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("[[TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 1, 19, 2, 0, 0, 0, 0, 0, 67,
		0, 0
	})]
	private new object[][] values;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int[] cellRowIndices;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private int[] cellColumnIndices;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ImmutableList<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;Lcom/google/common/collect/ImmutableSet<TR;>;Lcom/google/common/collect/ImmutableSet<TC;>;)V")]
	[LineNumberTable(new byte[]
	{
		7, 168, 127, 15, 103, 108, 108, 118, 118, 109,
		109, 112, 111, 105, 137, 127, 4, 127, 4, 110,
		115, 115, 114, 114, 103, 231, 51, 235, 79, 104,
		104, 109, 109
	})]
	internal DenseImmutableTable(ImmutableList P_0, ImmutableSet P_1, ImmutableSet P_2)
	{
		int num = P_1.size();
		int num2 = P_2.size();
		int[] array = new int[2];
		int num3 = (array[1] = num2);
		num3 = (array[0] = num);
		object[][] array2 = (values = (object[][])ByteCodeHelper.multianewarray(typeof(object[][]).TypeHandle, array));
		rowKeyToIndex = Maps.indexMap(P_1);
		columnKeyToIndex = Maps.indexMap(P_2);
		rowCounts = new int[rowKeyToIndex.size()];
		columnCounts = new int[columnKeyToIndex.size()];
		int[] array3 = new int[P_0.size()];
		int[] array4 = new int[P_0.size()];
		for (int i = 0; i < P_0.size(); i++)
		{
			Table.Cell cell = (Table.Cell)P_0.get(i);
			object rowKey = cell.getRowKey();
			object columnKey = cell.getColumnKey();
			int num4 = ((Integer)Objects.requireNonNull((Integer)rowKeyToIndex.get(rowKey))).intValue();
			int num5 = ((Integer)Objects.requireNonNull((Integer)columnKeyToIndex.get(columnKey))).intValue();
			object obj = values[num4][num5];
			checkNoDuplicate(rowKey, columnKey, obj, cell.getValue());
			values[num4][num5] = cell.getValue();
			int[] array5 = rowCounts;
			num3 = num4;
			array = array5;
			array[num3]++;
			int[] array6 = columnCounts;
			num3 = num5;
			array = array6;
			array[num3]++;
			array3[i] = num4;
			array4[i] = num5;
		}
		cellRowIndices = array3;
		cellColumnIndices = array4;
		this.m_rowMap = new RowMap(this, null);
		this.m_columnMap = new ColumnMap(this, null);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMap<TC;Ljava/util/Map<TR;TV;>;>;")]
	[LineNumberTable(new byte[] { 160, 132, 103 })]
	public override ImmutableMap columnMap()
	{
		ImmutableMap map = this.m_columnMap;
		ImmutableMap result = ImmutableMap.copyOf(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	[LineNumberTable(new byte[] { 160, 139, 103 })]
	public override ImmutableMap rowMap()
	{
		ImmutableMap map = this.m_rowMap;
		ImmutableMap result = ImmutableMap.copyOf(map);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 160, 146, 114, 114 })]
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
		Integer integer = (Integer)rowKeyToIndex.get(P_0);
		Integer integer2 = (Integer)columnKeyToIndex.get(P_1);
		return (integer != null && integer2 != null) ? values[integer.intValue()][integer2.intValue()] : null;
	}

	[LineNumberTable(267)]
	public override int size()
	{
		return cellRowIndices.Length;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;")]
	[LineNumberTable(new byte[] { 160, 158, 105, 105, 114, 146, 113 })]
	internal override Table.Cell getCell(int P_0)
	{
		int num = cellRowIndices[P_0];
		int num2 = cellColumnIndices[P_0];
		object obj = base.rowKeySet().asList().get(num);
		object obj2 = base.columnKeySet().asList().get(num2);
		object obj3 = Objects.requireNonNull(values[num][num2]);
		Table.Cell result = ImmutableTable.cellOf(obj, obj2, obj3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TV;")]
	[LineNumberTable(284)]
	internal override object getValue(int P_0)
	{
		object result = Objects.requireNonNull(values[cellRowIndices[P_0]][cellColumnIndices[P_0]]);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(289)]
	internal override SerializedForm createSerializedForm()
	{
		SerializedForm result = SerializedForm.create(this, cellRowIndices, cellColumnIndices);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	public new virtual Map columnMap()
	{
		ImmutableMap result = this.columnMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(28)]
	public new virtual Map rowMap()
	{
		ImmutableMap result = this.rowMap();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	internal static int[] access_0024200(DenseImmutableTable P_0)
	{
		return P_0.rowCounts;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	internal static ImmutableMap access_0024300(DenseImmutableTable P_0)
	{
		return P_0.columnKeyToIndex;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	internal static object[][] access_0024400(DenseImmutableTable P_0)
	{
		return P_0.values;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	internal static int[] access_0024500(DenseImmutableTable P_0)
	{
		return P_0.columnCounts;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	internal static ImmutableMap access_0024600(DenseImmutableTable P_0)
	{
		return P_0.rowKeyToIndex;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected DenseImmutableTable(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
