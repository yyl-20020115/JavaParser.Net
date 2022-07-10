using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Lcom/google/common/collect/AbstractSetMultimap<TK;TV;>;Lcom/google/common/collect/SortedSetMultimap<TK;TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 55, 0, 0,
	17, 1, 0, 0, 0, 55, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)55,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SortedSetMultimap" })]
internal abstract class AbstractSortedSetMultimap : AbstractSetMultimap, SortedSetMultimap, SetMultimap, Multimap
{
	private const long serialVersionUID = 430848587173315748L;

	[Signature("()Ljava/util/SortedSet<TV;>;")]
	internal new abstract SortedSet createCollection();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Collection<TE;>;)Ljava/util/SortedSet<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 55, 0, 0 })]
	[LineNumberTable(new byte[] { 10, 104, 142 })]
	internal new virtual SortedSet unmodifiableCollectionSubclass(Collection P_0)
	{
		if (P_0 is NavigableSet)
		{
			NavigableSet result = Sets.unmodifiableNavigableSet((NavigableSet)P_0);
			_ = null;
			return result;
		}
		SortedSet result2 = Collections.unmodifiableSortedSet((SortedSet)P_0);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/lang/Iterable<+TV;>;)Ljava/util/SortedSet<TV;>;")]
	[LineNumberTable(119)]
	public new virtual SortedSet replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		return (SortedSet)base.replaceValues(P_0, P_1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Object;)Ljava/util/SortedSet<TV;>;")]
	[LineNumberTable(103)]
	public new virtual SortedSet removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		return (SortedSet)base.removeAll(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;)Ljava/util/SortedSet<TV;>;")]
	[LineNumberTable(90)]
	public new virtual SortedSet get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		return (SortedSet)base.get(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/SortedSet<TV;>;")]
	[LineNumberTable(54)]
	internal new virtual SortedSet createUnmodifiableEmptyCollection()
	{
		SortedSet result = unmodifiableCollectionSubclass(createCollection());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;)V")]
	[LineNumberTable(new byte[] { 159, 188, 105 })]
	protected internal AbstractSortedSetMultimap(Map P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TK;Ljava/util/Collection<TV;>;)Ljava/util/Collection<TV;>;")]
	[LineNumberTable(new byte[] { 19, 104, 145 })]
	internal override Collection wrapCollection([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Collection P_1)
	{
		if (P_1 is NavigableSet)
		{
			WrappedNavigableSet result = new WrappedNavigableSet(this, P_0, (NavigableSet)P_1, null);
			_ = null;
			return result;
		}
		WrappedSortedSet result2 = new WrappedSortedSet(this, P_0, (SortedSet)P_1, null);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Map<TK;Ljava/util/Collection<TV;>;>;")]
	[LineNumberTable(136)]
	public override Map asMap()
	{
		Map result = base.asMap();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Collection<TV;>;")]
	[LineNumberTable(147)]
	public override Collection values()
	{
		Collection result = base.values();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Set replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		SortedSet result = replaceValues(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Set removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		SortedSet result = removeAll(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Set get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		SortedSet result = get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 55, 0, 0 })]
	[LineNumberTable(36)]
	internal override Collection unmodifiableCollectionSubclass(Collection P_0)
	{
		SortedSet result = unmodifiableCollectionSubclass(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal override Set createUnmodifiableEmptyCollection()
	{
		SortedSet result = createUnmodifiableEmptyCollection();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal override Set createCollection()
	{
		SortedSet result = createCollection();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Collection get([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0)
	{
		SortedSet result = get(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Collection removeAll([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		SortedSet result = removeAll(P_0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	public override Collection replaceValues([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, Iterable P_1)
	{
		SortedSet result = replaceValues(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal override Collection createCollection()
	{
		SortedSet result = createCollection();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(36)]
	internal override Collection createUnmodifiableEmptyCollection()
	{
		SortedSet result = createUnmodifiableEmptyCollection();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Comparator valueComparator();

	Set SortedSetMultimap.SortedSetMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
	{
		return this.replaceValues(P_0, P_1);
	}

	Set SortedSetMultimap.SortedSetMultimap_003A_003AremoveAll(object P_0)
	{
		return this.removeAll(P_0);
	}

	Set SortedSetMultimap.SortedSetMultimap_003A_003Aget(object P_0)
	{
		return this.get(P_0);
	}

	Collection SortedSetMultimap.SortedSetMultimap_003A_003Aget(object P_0)
	{
		return this.get(P_0);
	}

	Collection SortedSetMultimap.SortedSetMultimap_003A_003AremoveAll(object P_0)
	{
		return this.removeAll(P_0);
	}

	Collection SortedSetMultimap.SortedSetMultimap_003A_003AreplaceValues(object P_0, Iterable P_1)
	{
		return this.replaceValues(P_0, P_1);
	}

	Collection SetMultimap.SetMultimap_003A_003Aentries()
	{
		return ((AbstractSetMultimap)this).entries();
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

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected AbstractSortedSetMultimap(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
