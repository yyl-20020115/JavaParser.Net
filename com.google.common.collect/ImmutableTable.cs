using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using ikvm.@internal;
using java.io;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractTable<TR;TC;TV;>;Ljava/io/Serializable;")]
[ConstantPool(new object[]
{
	(byte)81,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.io.Serializable" })]
public abstract class ImmutableTable : AbstractTable, Serializable.__Interface, ISerializable
{
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[DoNotMock(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/DoNotMock;"
	})]
	public sealed class Builder : java.lang.Object
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		[Signature("Ljava/util/List<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
		private List cells;

		[Signature("Ljava/util/Comparator<-TR;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Comparator rowComparator;

		[Signature("Ljava/util/Comparator<-TC;>;")]
		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		private Comparator columnComparator;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table$Cell<+TR;+TC;+TV;>;)Lcom/google/common/collect/ImmutableTable$Builder<TR;TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 113, 104, 113, 113, 145, 98, 109, 98, 153 })]
		public virtual Builder put(Table.Cell cell)
		{
			if (cell is Tables.ImmutableCell)
			{
				Preconditions.checkNotNull(cell.getRowKey(), (object)"row");
				Preconditions.checkNotNull(cell.getColumnKey(), (object)"column");
				Preconditions.checkNotNull(cell.getValue(), (object)"value");
				cells.add(cell);
			}
			else
			{
				put(cell.getRowKey(), cell.getColumnKey(), cell.getValue());
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;")]
		[LineNumberTable(270)]
		public virtual ImmutableTable build()
		{
			ImmutableTable result = buildOrThrow();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 81, 232, 56, 235, 72 })]
		public Builder()
		{
			cells = Lists.newArrayList();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(TR;TC;TV;)Lcom/google/common/collect/ImmutableTable$Builder<TR;TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 103, 116 })]
		public virtual Builder put(object rowKey, object columnKey, object value)
		{
			cells.add(cellOf(rowKey, columnKey, value));
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 167, 108, 146, 136, 152 })]
		public virtual ImmutableTable buildOrThrow()
		{
			switch (cells.size())
			{
			case 0:
			{
				ImmutableTable result3 = of();
				_ = null;
				return result3;
			}
			case 1:
			{
				SingletonImmutableTable result2 = new SingletonImmutableTable((Table.Cell)Iterables.getOnlyElement(cells));
				_ = null;
				return result2;
			}
			default:
			{
				RegularImmutableTable result = RegularImmutableTable.forCells(cells, rowComparator, columnComparator);
				_ = null;
				return result;
			}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TR;>;)Lcom/google/common/collect/ImmutableTable$Builder<TR;TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 86, 118 })]
		public virtual Builder orderRowsBy(Comparator rowComparator)
		{
			this.rowComparator = (Comparator)Preconditions.checkNotNull((object)rowComparator, (object)"rowComparator");
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Ljava/util/Comparator<-TC;>;)Lcom/google/common/collect/ImmutableTable$Builder<TR;TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 93, 118 })]
		public virtual Builder orderColumnsBy(Comparator columnComparator)
		{
			this.columnComparator = (Comparator)Preconditions.checkNotNull((object)columnComparator, (object)"columnComparator");
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)Lcom/google/common/collect/ImmutableTable$Builder<TR;TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 134, 127, 1, 104, 98 })]
		public virtual Builder putAll(Table table)
		{
			Iterator iterator = table.cellSet().iterator();
			while (iterator.hasNext())
			{
				Table.Cell cell = (Table.Cell)iterator.next();
				put(cell);
			}
			return this;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableTable$Builder<TR;TC;TV;>;)Lcom/google/common/collect/ImmutableTable$Builder<TR;TC;TV;>;")]
		[LineNumberTable(new byte[] { 160, 142, 114 })]
		internal virtual Builder combine(Builder P_0)
		{
			cells.addAll(P_0.cells);
			return this;
		}
	}

	[Serializable]
	[Implements(new string[] { "java.io.Serializable" })]
	internal sealed class SerializedForm : java.lang.Object, Serializable.__Interface, ISerializable, IObjectReference
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private object[] rowKeys;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private object[] columnKeys;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private object[] cellValues;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int[] cellRowIndices;

		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private int[] cellColumnIndices;

		private const long serialVersionUID = 0L;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/ImmutableTable<***>;[I[I)Lcom/google/common/collect/ImmutableTable$SerializedForm;")]
		[LineNumberTable(new byte[] { 161, 104, 97, 107, 107, 243, 61 })]
		internal static SerializedForm create(ImmutableTable P_0, int[] P_1, int[] P_2)
		{
			SerializedForm result = new SerializedForm(P_0.rowKeySet().toArray(), P_0.columnKeySet().toArray(), P_0.values().toArray(), P_1, P_2);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 161, 94, 104, 103, 103, 103, 104, 104 })]
		private SerializedForm(object[] P_0, object[] P_1, object[] P_2, int[] P_3, int[] P_4)
		{
			rowKeys = P_0;
			columnKeys = P_1;
			cellValues = P_2;
			cellRowIndices = P_3;
			cellColumnIndices = P_4;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			161, 113, 105, 136, 106, 159, 1, 141, 108, 127,
			8, 37, 38, 198, 97, 59
		})]
		internal virtual object readResolve()
		{
			if (cellValues.Length == 0)
			{
				ImmutableTable result = of();
				_ = null;
				return result;
			}
			if ((nint)cellValues.LongLength == 1)
			{
				ImmutableTable result2 = of(rowKeys[0], columnKeys[0], cellValues[0]);
				_ = null;
				return result2;
			}
			ImmutableList.Builder builder = new ImmutableList.Builder(cellValues.Length);
			for (int i = 0; i < (nint)cellValues.LongLength; i++)
			{
				builder.add(cellOf(rowKeys[cellRowIndices[i]], columnKeys[cellColumnIndices[i]], cellValues[i]));
			}
			RegularImmutableTable result3 = RegularImmutableTable.forOrderedComponents(builder.build(), ImmutableSet.copyOf(rowKeys), ImmutableSet.copyOf(columnKeys));
			_ = null;
			return result3;
		}

		[SecurityCritical]
		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		void ISerializable.GetObjectData(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.writeObject(this, P_0);
		}

		[HideFromJava]
		[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
		protected SerializedForm(SerializationInfo P_0, StreamingContext P_1)
		{
			ikvm.@internal.Serialization.readObject(this, P_0);
		}

		[SecurityCritical]
		[HideFromJava]
		object IObjectReference.GetRealObject(StreamingContext P_0)
		{
			return readResolve();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/lang/Iterable<+Lcom/google/common/collect/Table$Cell<+TR;+TC;+TV;>;>;)Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;")]
	[LineNumberTable(new byte[] { 83, 102, 123, 104, 98 })]
	internal static ImmutableTable copyOf(Iterable P_0)
	{
		Builder builder = ImmutableTable.builder();
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			Table.Cell cell = (Table.Cell)iterator.next();
			builder.put(cell);
		}
		ImmutableTable result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableTable$Builder<TR;TC;TV;>;")]
	[LineNumberTable(145)]
	public static Builder builder()
	{
		Builder result = new Builder();
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableMap<TC;Ljava/util/Map<TR;TV;>;>;")]
	public new abstract ImmutableMap columnMap();

	[Signature("()Lcom/google/common/collect/ImmutableMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	public new abstract ImmutableMap rowMap();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
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
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(315)]
	public new virtual ImmutableCollection values()
	{
		return (ImmutableCollection)base.values();
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual SerializedForm createSerializedForm()
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableTable.createSerializedForm()Lcom.google.common.collect.ImmutableTable$SerializedForm;");
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	internal new virtual ImmutableCollection createValues()
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableTable.createValues()Lcom.google.common.collect.ImmutableCollection;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/UnmodifiableIterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(305)]
	internal new UnmodifiableIterator cellIterator()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	internal new virtual ImmutableSet createCellSet()
	{
		throw new AbstractMethodError("com.google.common.collect.ImmutableTable.createCellSet()Lcom.google.common.collect.ImmutableSet;");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(297)]
	public new virtual ImmutableSet cellSet()
	{
		return (ImmutableSet)base.cellSet();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TC;>;")]
	[LineNumberTable(340)]
	public new virtual ImmutableSet columnKeySet()
	{
		ImmutableSet result = columnMap().keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<TR;>;")]
	[LineNumberTable(366)]
	public new virtual ImmutableSet rowKeySet()
	{
		ImmutableSet result = rowMap().keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Lcom/google/common/collect/ImmutableMap<TR;TV;>;")]
	[LineNumberTable(new byte[] { 160, 219, 108, 97, 53 })]
	public new virtual ImmutableMap column(object columnKey)
	{
		Preconditions.checkNotNull(columnKey, (object)"columnKey");
		return (ImmutableMap)MoreObjects.firstNonNull((ImmutableMap)columnMap().get(columnKey), ImmutableMap.of());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;)Lcom/google/common/collect/ImmutableMap<TC;TV;>;")]
	[LineNumberTable(new byte[] { 160, 245, 108, 97, 53 })]
	public new virtual ImmutableMap row(object rowKey)
	{
		Preconditions.checkNotNull(rowKey, (object)"rowKey");
		return (ImmutableMap)MoreObjects.firstNonNull((ImmutableMap)rowMap().get(rowKey), ImmutableMap.of());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TR;>;Ljava/util/function/Function<-TT;+TC;>;Ljava/util/function/Function<-TT;+TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 81, 0, 0 })]
	[LineNumberTable(68)]
	public static Collector toImmutableTable(java.util.function.Function rowFunction, java.util.function.Function columnFunction, java.util.function.Function valueFunction)
	{
		Collector result = TableCollectors.toImmutableTable(rowFunction, columnFunction, valueFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Ljava/util/function/Function<-TT;+TR;>;Ljava/util/function/Function<-TT;+TC;>;Ljava/util/function/Function<-TT;+TV;>;Ljava/util/function/BinaryOperator<TV;>;)Ljava/util/stream/Collector<TT;*Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 81, 0, 0 })]
	[LineNumberTable(88)]
	public static Collector toImmutableTable(java.util.function.Function rowFunction, java.util.function.Function columnFunction, java.util.function.Function valueFunction, BinaryOperator mergeFunction)
	{
		Collector result = TableCollectors.toImmutableTable(rowFunction, columnFunction, valueFunction, mergeFunction);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;")]
	[LineNumberTable(99)]
	public static ImmutableTable of()
	{
		return SparseImmutableTable.EMPTY;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(TR;TC;TV;)Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;")]
	[LineNumberTable(104)]
	public static ImmutableTable of(object rowKey, object columnKey, object value)
	{
		SingletonImmutableTable result = new SingletonImmutableTable(rowKey, columnKey, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;")]
	[LineNumberTable(new byte[] { 72, 136, 103, 130 })]
	public static ImmutableTable copyOf(Table table)
	{
		if (table is ImmutableTable)
		{
			return (ImmutableTable)table;
		}
		ImmutableTable result = copyOf(table.cellSet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>(TR;TC;TV;)Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;")]
	[LineNumberTable(new byte[] { 103, 102, 107, 107, 229, 61 })]
	internal static Table.Cell cellOf(object P_0, object P_1, object P_2)
	{
		Table.Cell result = Tables.immutableCell(Preconditions.checkNotNull(P_0, (object)"rowKey"), Preconditions.checkNotNull(P_1, (object)"columnKey"), Preconditions.checkNotNull(P_2, (object)"value"));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(293)]
	internal ImmutableTable()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(310)]
	internal sealed override Spliterator cellSpliterator()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TV;>;")]
	[LineNumberTable(323)]
	internal sealed override Iterator valuesIterator()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new AssertionError("should never be called");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(380)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		return get(rowKey, columnKey) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(385)]
	public override bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		bool result = values().contains(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(398)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override void clear()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(TR;TC;TV;)TV;")]
	[LineNumberTable(413)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public sealed override object put(object rowKey, object columnKey, object value)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)V")]
	[LineNumberTable(426)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public sealed override void putAll(Table table)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(441)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public sealed override object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(503)]
	internal object writeReplace()
	{
		SerializedForm result = createSerializedForm();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	public override string toString()
	{
		string result = base.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	public override int hashCode()
	{
		int result = base.hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
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
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal override Collection createValues()
	{
		ImmutableCollection result = createValues();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	public virtual Collection _003Cbridge_003Evalues()
	{
		ImmutableCollection result = values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal override Iterator cellIterator()
	{
		UnmodifiableIterator result = cellIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	internal override Set createCellSet()
	{
		ImmutableSet result = createCellSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	public virtual Set _003Cbridge_003EcellSet()
	{
		ImmutableSet result = cellSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
	public override bool isEmpty()
	{
		bool result = base.isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	public virtual Set _003Cbridge_003EcolumnKeySet()
	{
		ImmutableSet result = columnKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	public virtual Set _003Cbridge_003ErowKeySet()
	{
		ImmutableSet result = rowKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(48)]
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
	[LineNumberTable(48)]
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
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	public virtual Map _003Cbridge_003EcolumnMap()
	{
		ImmutableMap result = columnMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	public virtual Map _003Cbridge_003ErowMap()
	{
		ImmutableMap result = rowMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	public virtual Map _003Cbridge_003Ecolumn(object obj)
	{
		ImmutableMap result = column(obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	public virtual Map _003Cbridge_003Erow(object obj)
	{
		ImmutableMap result = row(obj);
		_ = null;
		return result;
	}

	[HideFromJava]
	public static implicit operator Serializable(ImmutableTable P_0)
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
	protected ImmutableTable(SerializationInfo P_0, StreamingContext P_1)
	{
		ikvm.@internal.Serialization.readObject(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	[NameSig("<accessstub>0|size", "()I")]
	public new int size()
	{
		return ((AbstractTable)this).size();
	}
}
