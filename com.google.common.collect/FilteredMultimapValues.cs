using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/util/AbstractCollection<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 86, 0, 0,
	17, 1, 0, 0, 0, 86, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)86,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class FilteredMultimapValues : AbstractCollection
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/FilteredMultimap<TK;TV;>;")]
	private FilteredMultimap multimap;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/FilteredMultimap<TK;TV;>;)V")]
	[LineNumberTable(new byte[] { 159, 184, 104, 113 })]
	internal FilteredMultimapValues(FilteredMultimap P_0)
	{
		multimap = (FilteredMultimap)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TV;>;")]
	[LineNumberTable(48)]
	public override Iterator iterator()
	{
		Iterator result = Maps.valueIterator(multimap.entries().iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(53)]
	public override bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		bool result = multimap.containsValue(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(58)]
	public override int size()
	{
		int result = multimap.size();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 13, 108, 118, 104, 108, 119, 102, 130, 98 })]
	public override bool remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		Predicate predicate = multimap.entryPredicate();
		Iterator iterator = multimap.unfiltered().entries().iterator();
		while (iterator.hasNext())
		{
			Map.Entry entry = (Map.Entry)iterator.next();
			if (predicate.apply(entry) && com.google.common.@base.Objects.equal(entry.getValue(), P_0))
			{
				iterator.remove();
				return true;
			}
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[] { 27, 102, 176, 48, 229, 61 })]
	public override bool removeAll(Collection P_0)
	{
		bool result = Iterables.removeIf(multimap.unfiltered().entries(), Predicates.and(multimap.entryPredicate(), Maps.valuePredicateOnEntries(Predicates.@in(P_0))));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<*>;)Z")]
	[LineNumberTable(new byte[] { 36, 102, 176, 102, 15, 229, 61 })]
	public override bool retainAll(Collection P_0)
	{
		bool result = Iterables.removeIf(multimap.unfiltered().entries(), Predicates.and(multimap.entryPredicate(), Maps.valuePredicateOnEntries(Predicates.not(Predicates.@in(P_0)))));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 46, 109 })]
	public override void clear()
	{
		multimap.clear();
	}
}
