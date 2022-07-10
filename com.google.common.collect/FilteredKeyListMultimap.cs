using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/FilteredKeyMultimap<TK;TV;>;Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 61, 0, 0,
	17, 1, 0, 0, 0, 61, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)61,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.ListMultimap" })]
internal sealed class FilteredKeyListMultimap : FilteredKeyMultimap, ListMultimap, Multimap
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/List<TV;>;")]
	[LineNumberTable(45)]
	public new virtual List get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		return (List)base.get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/List<TV;>;")]
	[LineNumberTable(50)]
	public new virtual List removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (List)base.removeAll(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ListMultimap<TK;TV;>;")]
	[LineNumberTable(40)]
	public new virtual ListMultimap unfiltered()
	{
		return (ListMultimap)base.unfiltered();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/List<TV;>;")]
	[LineNumberTable(55)]
	public new virtual List replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		return (List)base.replaceValues(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/ListMultimap<TK;TV;>;Lcom/google/common/base/Predicate<-TK;>;)V")]
	[LineNumberTable(new byte[] { 159, 177, 106 })]
	internal FilteredKeyListMultimap(ListMultimap P_0, com.google.common.@base.Predicate P_1)
		: base(P_0, P_1)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override Collection get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		List result = get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override Collection removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		List result = removeAll(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override Multimap unfiltered()
	{
		ListMultimap result = unfiltered();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(30)]
	public override Collection replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		List result = replaceValues(P_0, P_1);
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(BiConsumer P_0)
	{
		Multimap._003Cdefault_003EforEach(this, P_0);
	}

	Collection ListMultimap.ListMultimap_003A_003Aget(object P_0)
	{
		return this.get(P_0);
	}

	Collection ListMultimap.ListMultimap_003A_003AremoveAll(object P_0)
	{
		return this.removeAll(P_0);
	}

	Collection ListMultimap.ListMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
	{
		return this.replaceValues(P_0, P_1);
	}
}
