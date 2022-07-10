using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 45, 0, 0,
	17, 1, 0, 0, 0, 45, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)45,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SetMultimap" })]
public interface SortedSetMultimap : SetMultimap, Multimap
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static Set replaceValues(SortedSetMultimap P_0, object P_1, Iterable P_2)
		{
			__ldvirtftn(object.ToString);
			return SortedSetMultimap._003Cdefault_003E_003Cbridge_003EreplaceValues(P_0, P_1, P_2);
		}

		public unsafe static Set removeAll(SortedSetMultimap P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return SortedSetMultimap._003Cdefault_003E_003Cbridge_003EremoveAll(P_0, P_1);
		}

		public unsafe static Set get(SortedSetMultimap P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return SortedSetMultimap._003Cdefault_003E_003Cbridge_003Eget(P_0, P_1);
		}

		public unsafe static Collection get(SortedSetMultimap P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return SortedSetMultimap._003Cdefault_003E_003Cbridge_003Eget(P_0, P_1);
		}

		public unsafe static Collection removeAll(SortedSetMultimap P_0, object P_1)
		{
			__ldvirtftn(object.ToString);
			return SortedSetMultimap._003Cdefault_003E_003Cbridge_003EremoveAll(P_0, P_1);
		}

		public unsafe static Collection replaceValues(SortedSetMultimap P_0, object P_1, Iterable P_2)
		{
			__ldvirtftn(object.ToString);
			return SortedSetMultimap._003Cdefault_003E_003Cbridge_003EreplaceValues(P_0, P_1, P_2);
		}
	}

	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/SortedSet<TV;>;")]
	SortedSet replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i);

	[Signature("(Ljava/lang/Object;)Ljava/util/SortedSet<TV;>;")]
	SortedSet removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[Signature("(TK;)Ljava/util/SortedSet<TV;>;")]
	SortedSet get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	Map asMap();

	[Signature("()Ljava/util/Comparator<-TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual Comparator valueComparator();

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	Set _003Cbridge_003EreplaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(51)]
	static Set _003Cdefault_003E_003Cbridge_003EreplaceValues(SortedSetMultimap P_0, object P_1, Iterable P_2)
	{
		SortedSet result = P_0.replaceValues(P_1, P_2);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	Set _003Cbridge_003EremoveAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(51)]
	static Set _003Cdefault_003E_003Cbridge_003EremoveAll(SortedSetMultimap P_0, object P_1)
	{
		SortedSet result = P_0.removeAll(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	Set _003Cbridge_003Eget([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(51)]
	static Set _003Cdefault_003E_003Cbridge_003Eget(SortedSetMultimap P_0, object P_1)
	{
		SortedSet result = P_0.get(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	Collection _003Cbridge_003Eget([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(51)]
	static Collection _003Cdefault_003E_003Cbridge_003Eget(SortedSetMultimap P_0, object P_1)
	{
		SortedSet result = P_0.get(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	Collection _003Cbridge_003EremoveAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(51)]
	static Collection _003Cdefault_003E_003Cbridge_003EremoveAll(SortedSetMultimap P_0, object P_1)
	{
		SortedSet result = P_0.removeAll(P_1);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	Collection _003Cbridge_003EreplaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, Iterable i);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(51)]
	static Collection _003Cdefault_003E_003Cbridge_003EreplaceValues(SortedSetMultimap P_0, object P_1, Iterable P_2)
	{
		SortedSet result = P_0.replaceValues(P_1, P_2);
		_ = null;
		return result;
	}
}
