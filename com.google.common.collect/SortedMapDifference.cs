using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.util;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/MapDifference<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 35, 0, 0,
	17, 1, 0, 0, 0, 35, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)35,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.MapDifference" })]
public interface SortedMapDifference : MapDifference
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static Map entriesDiffering(SortedMapDifference P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EentriesDiffering(P_0);
		}

		public unsafe static Map entriesInCommon(SortedMapDifference P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EentriesInCommon(P_0);
		}

		public unsafe static Map entriesOnlyOnRight(SortedMapDifference P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EentriesOnlyOnRight(P_0);
		}

		public unsafe static Map entriesOnlyOnLeft(SortedMapDifference P_0)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EentriesOnlyOnLeft(P_0);
		}
	}

	[Signature("()Ljava/util/SortedMap<TK;Lcom/google/common/collect/MapDifference$ValueDifference<TV;>;>;")]
	SortedMap entriesDiffering();

	[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
	SortedMap entriesInCommon();

	[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
	SortedMap entriesOnlyOnRight();

	[Signature("()Ljava/util/SortedMap<TK;TV;>;")]
	SortedMap entriesOnlyOnLeft();

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Map _003Cbridge_003EentriesDiffering();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(29)]
	static Map _003Cdefault_003E_003Cbridge_003EentriesDiffering(SortedMapDifference P_0)
	{
		SortedMap result = P_0.entriesDiffering();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Map _003Cbridge_003EentriesInCommon();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(29)]
	static Map _003Cdefault_003E_003Cbridge_003EentriesInCommon(SortedMapDifference P_0)
	{
		SortedMap result = P_0.entriesInCommon();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Map _003Cbridge_003EentriesOnlyOnRight();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(29)]
	static Map _003Cdefault_003E_003Cbridge_003EentriesOnlyOnRight(SortedMapDifference P_0)
	{
		SortedMap result = P_0.entriesOnlyOnRight();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Map _003Cbridge_003EentriesOnlyOnLeft();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(29)]
	static Map _003Cdefault_003E_003Cbridge_003EentriesOnlyOnLeft(SortedMapDifference P_0)
	{
		SortedMap result = P_0.entriesOnlyOnLeft();
		_ = null;
		return result;
	}
}
