using System;
using System.Runtime.CompilerServices;
using com.google.errorprone.annotations.concurrent;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/Table<TR;TC;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 3, 17, 0, 0, 0, 0, 144, 0, 0,
	17, 1, 0, 0, 0, 144, 0, 0, 17, 2,
	0, 0, 0, 144, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)144,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractTable : java.lang.Object, Table
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[Signature("Lcom/google/common/collect/TransformedIterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;TV;>;")]
	[EnclosingMethod(null, "valuesIterator", "()Ljava.util.Iterator;")]
	internal class _1 : TransformedIterator
	{
		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("(Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;)TV;")]
		[LineNumberTable(198)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal virtual object transform(Table.Cell P_0)
		{
			object value = P_0.getValue();
			_ = null;
			return value;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(194)]
		internal _1(AbstractTable P_0, Iterator P_1)
			: base(P_1)
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(194)]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		internal override object transform(object P_0)
		{
			object result = transform((Table.Cell)P_0);
			_ = null;
			return result;
		}
	}

	[Signature("Ljava/util/AbstractSet<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	internal class CellSet : AbstractSet
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(135)]
		internal CellSet(AbstractTable P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 88, 104, 103, 124, 132, 54, 43, 193 })]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Table.Cell)
			{
				Table.Cell cell = (Table.Cell)P_0;
				Map map = (Map)Maps.safeGet(this_00240.rowMap(), cell.getRowKey());
				return (map != null && Collections2.safeContains(map.entrySet(), Maps.immutableEntry(cell.getColumnKey(), cell.getValue()))) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 100, 104, 103, 124, 132, 54, 43, 193 })]
		public override bool remove([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			if (P_0 is Table.Cell)
			{
				Table.Cell cell = (Table.Cell)P_0;
				Map map = (Map)Maps.safeGet(this_00240.rowMap(), cell.getRowKey());
				return (map != null && Collections2.safeRemove(map.entrySet(), Maps.immutableEntry(cell.getColumnKey(), cell.getValue()))) ? true : false;
			}
			return false;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 112, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
		[LineNumberTable(167)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.cellIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
		[LineNumberTable(172)]
		public override Spliterator spliterator()
		{
			Spliterator result = this_00240.cellSpliterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(177)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}
	}

	[Signature("Ljava/util/AbstractCollection<TV;>;")]
	internal class Values : AbstractCollection
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal AbstractTable this_00240;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(208)]
		internal Values(AbstractTable P_0)
		{
			this_00240 = P_0;
			base._002Ector();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Iterator<TV;>;")]
		[LineNumberTable(211)]
		public override Iterator iterator()
		{
			Iterator result = this_00240.valuesIterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()Ljava/util/Spliterator<TV;>;")]
		[LineNumberTable(216)]
		public override Spliterator spliterator()
		{
			Spliterator result = this_00240.valuesSpliterator();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(221)]
		public override bool contains([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object P_0)
		{
			bool result = this_00240.containsValue(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 112, 109 })]
		public override void clear()
		{
			this_00240.clear();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(231)]
		public override int size()
		{
			int result = this_00240.size();
			_ = null;
			return result;
		}
	}

	[SpecialName]
	private sealed class ___003C_003EAnon0 : Function
	{
		internal ___003C_003EAnon0()
		{
		}

		public object apply(object P_0)
		{
			object value = ((Table.Cell)P_0).getValue();
			_ = null;
			return value;
		}

		[SpecialName]
		public Function compose(Function P_0)
		{
			return Function._003Cdefault_003Ecompose(this, P_0);
		}

		[SpecialName]
		public Function andThen(Function P_0)
		{
			return Function._003Cdefault_003EandThen(this, P_0);
		}
	}

	[NonSerialized]
	[Signature("Ljava/util/Set<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Set m_cellSet;

	[NonSerialized]
	[Signature("Ljava/util/Collection<TV;>;")]
	[LazyInit(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/concurrent/LazyInit;"
	})]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Collection m_values;

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Map rowMap();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Map columnMap();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract int size();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(new byte[] { 72, 103 })]
	public virtual Set cellSet()
	{
		Set set = this.m_cellSet;
		Set result;
		if (set == null)
		{
			Set set2 = createCellSet();
			result = set2;
			this.m_cellSet = set2;
		}
		else
		{
			result = set;
		}
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Map row(object P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;TC;TV;)TV;")]
	[LineNumberTable(108)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_2)
	{
		object result = row(P_0).put(P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(127)]
	internal virtual Set createCellSet()
	{
		CellSet result = new CellSet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(190)]
	internal virtual Collection createValues()
	{
		Values result = new Values(this);
		_ = null;
		return result;
	}

	[Signature("()Ljava/util/Spliterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	internal abstract Spliterator cellSpliterator();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(38)]
	internal AbstractTable()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(44)]
	public virtual bool containsRow([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = Maps.safeContainsKey(rowMap(), P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(49)]
	public virtual bool containsColumn([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = Maps.safeContainsKey(columnMap(), P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TR;>;")]
	[LineNumberTable(54)]
	public virtual Set rowKeySet()
	{
		Set result = rowMap().keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TC;>;")]
	[LineNumberTable(59)]
	public virtual Set columnKeySet()
	{
		Set result = columnMap().keySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 127, 6, 105, 130, 98 })]
	public virtual bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Iterator iterator = rowMap().values().iterator();
		while (iterator.hasNext())
		{
			Map map = (Map)iterator.next();
			if (map.containsValue(P_0))
			{
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 24, 114 })]
	public virtual bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		Map map = (Map)Maps.safeGet(rowMap(), P_0);
		return (map != null && Maps.safeContainsKey(map, P_1)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 31, 114 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		Map map = (Map)Maps.safeGet(rowMap(), P_0);
		object result = ((map != null) ? Maps.safeGet(map, P_1) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(87)]
	public virtual bool isEmpty()
	{
		return (size() == 0) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 42, 114 })]
	public virtual void clear()
	{
		Iterators.clear(cellSet().iterator());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(new byte[] { 49, 114 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_1)
	{
		Map map = (Map)Maps.safeGet(rowMap(), P_0);
		object result = ((map != null) ? Maps.safeRemove(map, P_1) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)V")]
	[LineNumberTable(new byte[] { 63, 127, 1, 121, 98 })]
	public virtual void putAll(Table P_0)
	{
		Iterator iterator = P_0.cellSet().iterator();
		while (iterator.hasNext())
		{
			Table.Cell cell = (Table.Cell)iterator.next();
			put(cell.getRowKey(), cell.getColumnKey(), cell.getValue());
		}
	}

	[Signature("()Ljava/util/Iterator<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	internal abstract Iterator cellIterator();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 160, 71, 103 })]
	public virtual Collection values()
	{
		Collection collection = this.m_values;
		Collection result;
		if (collection == null)
		{
			Collection collection2 = createValues();
			result = collection2;
			this.m_values = collection2;
		}
		else
		{
			result = collection;
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TV;>;")]
	[LineNumberTable(194)]
	internal virtual Iterator valuesIterator()
	{
		_1 result = new _1(this, cellSet().iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Spliterator<TV;>;")]
	[LineNumberTable(204)]
	internal virtual Spliterator valuesSpliterator()
	{
		Spliterator result = CollectSpliterators.map(cellSpliterator(), new ___003C_003EAnon0());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(237)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = Tables.equalsImpl(this, P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(242)]
	public override int hashCode()
	{
		int result = cellSet().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(248)]
	public override string toString()
	{
		string result = java.lang.Object.instancehelper_toString(rowMap());
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Map column(object P_0);
}
