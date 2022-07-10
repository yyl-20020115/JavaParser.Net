using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/FilteredEntryMultimap<TK;TV;>;Lcom/google/common/collect/FilteredSetMultimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 76, 0, 0,
	17, 1, 0, 0, 0, 76, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)76,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.FilteredSetMultimap" })]
internal sealed class FilteredEntrySetMultimap : FilteredEntryMultimap, FilteredSetMultimap, FilteredMultimap, Multimap, SetMultimap
{
	[Signature("()Lcom/google/common/collect/SetMultimap<TK;TV;>;")]
	[LineNumberTable(42)]
	public new virtual SetMultimap unfiltered()
	{
		return (SetMultimap)base.unfiltered;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(62)]
	internal new virtual Set createEntries()
	{
		Set result = Sets.filter(unfiltered().entries(), base.entryPredicate());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/Set<TV;>;")]
	[LineNumberTable(47)]
	public new virtual Set get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		return (Set)base.get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/Set<TV;>;")]
	[LineNumberTable(52)]
	public new virtual Set removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (Set)base.removeAll(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Set<Ljava/util/Map$Entry<TK;TV;>;>;")]
	[LineNumberTable(67)]
	public new virtual Set entries()
	{
		return (Set)base.entries();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/Set<TV;>;")]
	[LineNumberTable(57)]
	public new virtual Set replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		return (Set)base.replaceValues(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/SetMultimap<TK;TV;>;Lcom/google/common/base/Predicate<-Ljava/util/Map$Entry<TK;TV;>;>;)V")]
	[LineNumberTable(new byte[] { 159, 179, 106 })]
	internal FilteredEntrySetMultimap(SetMultimap P_0, com.google.common.@base.Predicate P_1)
		: base(P_0, P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	internal override Collection createEntries()
	{
		Set result = createEntries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override Collection get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		Set result = get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override Collection removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Set result = removeAll(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override Multimap unfiltered()
	{
		SetMultimap result = unfiltered();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override Collection entries()
	{
		Set result = entries();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(31)]
	public override Collection replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		Set result = replaceValues(P_0, P_1);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(BiConsumer P_0)
	{
		Multimap._003Cdefault_003EforEach(this, P_0);
	}

	Collection SetMultimap.SetMultimap_003A_003Aentries()
	{
		return this.entries();
	}

	Collection SetMultimap.SetMultimap_003A_003Aget(object P_0)
	{
		return this.get(P_0);
	}

	Collection SetMultimap.SetMultimap_003A_003AremoveAll(object P_0)
	{
		return this.removeAll(P_0);
	}

	Collection SetMultimap.SetMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
	{
		return this.replaceValues(P_0, P_1);
	}
}
