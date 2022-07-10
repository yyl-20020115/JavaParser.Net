using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using java.util;

namespace com.google.common.collect;

[Serializable]
[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableTable<TR;TC;TV;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal class SingletonImmutableTable : ImmutableTable
{
	[Modifiers(Modifiers.Final)]
	[Signature("TR;")]
	internal object singleRowKey;

	[Modifiers(Modifiers.Final)]
	[Signature("TC;")]
	internal object singleColumnKey;

	[Modifiers(Modifiers.Final)]
	[Signature("TV;")]
	internal object singleValue;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TR;TC;TV;)V")]
	[LineNumberTable(new byte[] { 159, 178, 104, 108, 108, 108 })]
	internal SingletonImmutableTable(object P_0, object P_1, object P_2)
	{
		singleRowKey = Preconditions.checkNotNull(P_0);
		singleColumnKey = Preconditions.checkNotNull(P_1);
		singleValue = Preconditions.checkNotNull(P_2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;)V")]
	[LineNumberTable(new byte[] { 159, 185, 122 })]
	internal SingletonImmutableTable(Table.Cell P_0)
		: this(P_0.getRowKey(), P_0.getColumnKey(), P_0.getValue())
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableCollection<TV;>;")]
	[LineNumberTable(76)]
	internal override ImmutableCollection createValues()
	{
		ImmutableSet result = ImmutableSet.of(singleValue);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSet<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	[LineNumberTable(71)]
	internal override ImmutableSet createCellSet()
	{
		ImmutableSet result = ImmutableSet.of(ImmutableTable.cellOf(singleRowKey, singleColumnKey, singleValue));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMap<TC;Ljava/util/Map<TR;TV;>;>;")]
	[LineNumberTable(56)]
	public override ImmutableMap columnMap()
	{
		ImmutableMap result = ImmutableMap.of(singleColumnKey, ImmutableMap.of(singleRowKey, singleValue));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	[LineNumberTable(61)]
	public override ImmutableMap rowMap()
	{
		ImmutableMap result = ImmutableMap.of(singleRowKey, ImmutableMap.of(singleColumnKey, singleValue));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Lcom/google/common/collect/ImmutableMap<TR;TV;>;")]
	[LineNumberTable(new byte[] { 159, 190, 103, 105, 115, 7 })]
	public override ImmutableMap column(object P_0)
	{
		Preconditions.checkNotNull(P_0);
		ImmutableMap result = ((!containsColumn(P_0)) ? ImmutableMap.of() : ImmutableMap.of(singleRowKey, singleValue));
		_ = null;
		return result;
	}

	public override int size()
	{
		return 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(81)]
	internal override SerializedForm createSerializedForm()
	{
		SerializedForm result = SerializedForm.create(this, new int[1] { 0 }, new int[1] { 0 });
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	internal override Collection createValues()
	{
		ImmutableCollection result = this.createValues();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	internal override Set createCellSet()
	{
		ImmutableSet result = this.createCellSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public new virtual Map columnMap()
	{
		ImmutableMap result = this.columnMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public new virtual Map rowMap()
	{
		ImmutableMap result = this.rowMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(29)]
	public new virtual Map column(object P_0)
	{
		ImmutableMap result = this.column(P_0);
		_ = null;
		return result;
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected SingletonImmutableTable(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
