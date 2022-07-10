using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingObject;Lcom/google/common/collect/Table<TR;TC;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 3, 17, 0, 0, 0, 0, 111, 0, 0,
	17, 1, 0, 0, 0, 111, 0, 0, 17, 2,
	0, 0, 0, 111, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)111,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.Table" })]
public abstract class ForwardingTable : ForwardingObject, Table
{
	[Signature("()Lcom/google/common/collect/Table<TR;TC;TV;>;")]
	protected internal new abstract Table @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(41)]
	protected internal ForwardingTable()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(48)]
	public virtual Set cellSet()
	{
		Set result = @delegate().cellSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 3, 109 })]
	public virtual void clear()
	{
		@delegate().clear();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Ljava/util/Map<TR;TV;>;")]
	[LineNumberTable(58)]
	public virtual Map column([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object columnKey)
	{
		Map result = @delegate().column(columnKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TC;>;")]
	[LineNumberTable(63)]
	public virtual Set columnKeySet()
	{
		Set result = @delegate().columnKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TC;Ljava/util/Map<TR;TV;>;>;")]
	[LineNumberTable(68)]
	public virtual Map columnMap()
	{
		Map result = @delegate().columnMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(73)]
	public virtual bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		bool result = @delegate().contains(rowKey, columnKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(78)]
	public virtual bool containsColumn([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		bool result = @delegate().containsColumn(columnKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(83)]
	public virtual bool containsRow([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey)
	{
		bool result = @delegate().containsRow(rowKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(88)]
	public virtual bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object value)
	{
		bool result = @delegate().containsValue(value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(94)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		object result = @delegate().get(rowKey, columnKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(99)]
	public virtual bool isEmpty()
	{
		bool result = @delegate().isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;TC;TV;)TV;")]
	[LineNumberTable(107)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object rowKey, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object columnKey, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object value)
	{
		object result = @delegate().put(rowKey, columnKey, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)V")]
	[LineNumberTable(new byte[] { 62, 110 })]
	public virtual void putAll(Table table)
	{
		@delegate().putAll(table);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[LineNumberTable(119)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object rowKey, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object columnKey)
	{
		object result = @delegate().remove(rowKey, columnKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;)Ljava/util/Map<TC;TV;>;")]
	[LineNumberTable(124)]
	public virtual Map row([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object rowKey)
	{
		Map result = @delegate().row(rowKey);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<TR;>;")]
	[LineNumberTable(129)]
	public virtual Set rowKeySet()
	{
		Set result = @delegate().rowKeySet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;")]
	[LineNumberTable(134)]
	public virtual Map rowMap()
	{
		Map result = @delegate().rowMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(139)]
	public virtual int size()
	{
		int result = @delegate().size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(144)]
	public virtual Collection values()
	{
		Collection result = @delegate().values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(149)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj)
	{
		return (obj == this || @delegate().equals(obj)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(154)]
	public override int hashCode()
	{
		int result = @delegate().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(35)]
	protected internal virtual object _003Cbridge_003Edelegate()
	{
		Table result = @delegate();
		_ = null;
		return result;
	}
}
