using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util;

namespace com.google.common.collect;

[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/Table<TR;TC;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 3, 17, 0, 0, 0, 0, 30, 0, 0,
	17, 1, 0, 0, 0, 30, 0, 0, 17, 2,
	0, 0, 0, 30, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)30,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.Table" })]
public interface RowSortedTable : Table
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static Map rowMap(RowSortedTable P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003ErowMap(P_0);
		}

		public unsafe static Set rowKeySet(RowSortedTable P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003ErowKeySet(P_0);
		}
	}

	[Signature("()Ljava/util/SortedMap<TR;Ljava/util/Map<TC;TV;>;>;")]
	SortedMap rowMap();

	[Signature("()Ljava/util/SortedSet<TR;>;")]
	SortedSet rowKeySet();

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Map _003Cbridge_003ErowMap();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(36)]
	static Map _003Cdefault_003E_003Cbridge_003ErowMap(RowSortedTable P_0)
	{
		SortedMap result = P_0.rowMap();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Set _003Cbridge_003ErowKeySet();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(36)]
	static Set _003Cdefault_003E_003Cbridge_003ErowKeySet(RowSortedTable P_0)
	{
		SortedSet result = P_0.rowKeySet();
		_ = null;
		return result;
	}
}
