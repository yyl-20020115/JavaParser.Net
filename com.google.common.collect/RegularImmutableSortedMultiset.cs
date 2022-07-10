using System;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal sealed class RegularImmutableSortedMultiset : ImmutableSortedMultiset
{
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static long[] ZERO_CUMULATIVE_COUNTS;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	[Signature("Lcom/google/common/collect/ImmutableSortedMultiset<Ljava/lang/Comparable;>;")]
	internal static ImmutableSortedMultiset NATURAL_EMPTY_MULTISET;

	[NonSerialized]
	[Modifiers(Modifiers.Final | Modifiers.Transient)]
	[Signature("Lcom/google/common/collect/RegularImmutableSortedSet<TE;>;")]
	internal new RegularImmutableSortedSet elementSet;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private long[] cumulativeCounts;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private int offset;

	[NonSerialized]
	[Modifiers(Modifiers.Private | Modifiers.Final | Modifiers.Transient)]
	private int length;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/RegularImmutableSortedSet<TE;>;[JII)V")]
	[LineNumberTable(new byte[] { 5, 104, 103, 103, 103, 104 })]
	internal RegularImmutableSortedMultiset(RegularImmutableSortedSet P_0, long[] P_1, int P_2, int P_3)
	{
		this.elementSet = P_0;
		cumulativeCounts = P_1;
		offset = P_2;
		length = P_3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Comparator<-TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 189, 104, 108, 107, 103, 103 })]
	internal RegularImmutableSortedMultiset(Comparator P_0)
	{
		this.elementSet = ImmutableSortedSet.emptySet(P_0);
		cumulativeCounts = ZERO_CUMULATIVE_COUNTS;
		offset = 0;
		length = 0;
	}

	[LineNumberTable(63)]
	private int getCount(int P_0)
	{
		return (int)(cumulativeCounts[offset + P_0 + 1] - cumulativeCounts[offset + P_0]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(68)]
	internal override Multiset.Entry getEntry(int P_0)
	{
		Multiset.Entry result = Multisets.immutableEntry(this.elementSet.asList().get(P_0), getCount(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 70, 109, 100, 110, 108, 130, 110 })]
	internal virtual ImmutableSortedMultiset getSubMultiset(int P_0, int P_1)
	{
		Preconditions.checkPositionIndexes(P_0, P_1, length);
		if (P_0 == P_1)
		{
			ImmutableSortedMultiset result = ImmutableSortedMultiset.emptyMultiset(comparator());
			_ = null;
			return result;
		}
		if (P_0 == 0 && P_1 == length)
		{
			return this;
		}
		RegularImmutableSortedSet subSet = this.elementSet.getSubSet(P_0, P_1);
		RegularImmutableSortedMultiset result2 = new RegularImmutableSortedMultiset(subSet, cumulativeCounts, offset + P_0, P_1 - P_0);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 65, 105, 55 })]
	public override ImmutableSortedMultiset tailMultiset(object P_0, BoundType P_1)
	{
		ImmutableSortedMultiset result = getSubMultiset(this.elementSet.tailIndex(P_0, Preconditions.checkNotNull(P_1) == BoundType.___003C_003ECLOSED), length);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/ImmutableSortedMultiset<TE;>;")]
	[LineNumberTable(110)]
	public override ImmutableSortedMultiset headMultiset(object P_0, BoundType P_1)
	{
		ImmutableSortedMultiset result = getSubMultiset(0, this.elementSet.headIndex(P_0, Preconditions.checkNotNull(P_1) == BoundType.___003C_003ECLOSED));
		_ = null;
		return result;
	}

	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TE;>;")]
	public override ImmutableSortedSet elementSet()
	{
		return this.elementSet;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/function/ObjIntConsumer<-TE;>;)V")]
	[LineNumberTable(new byte[] { 23, 103, 107, 62, 166 })]
	public override void forEachEntry(ObjIntConsumer P_0)
	{
		Preconditions.checkNotNull(P_0);
		for (int i = 0; i < length; i++)
		{
			P_0.accept(this.elementSet.asList().get(i), getCount(i));
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(82)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override Multiset.Entry firstEntry()
	{
		Multiset.Entry result = ((!base.isEmpty()) ? getEntry(0) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(88)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public override Multiset.Entry lastEntry()
	{
		Multiset.Entry result = ((!base.isEmpty()) ? getEntry(length - 1) : null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 43, 109 })]
	public override int count([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		int num = this.elementSet.indexOf(P_0);
		return (num >= 0) ? getCount(num) : 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 49, 127, 4 })]
	public override int size()
	{
		long value = cumulativeCounts[offset + length] - cumulativeCounts[offset];
		int result = Ints.saturatedCast(value);
		_ = null;
		return result;
	}

	[LineNumberTable(134)]
	internal override bool isPartialView()
	{
		return (offset > 0 || length < (nint)cumulativeCounts.LongLength - 1) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	public new virtual SortedMultiset tailMultiset(object P_0, BoundType P_1)
	{
		ImmutableSortedMultiset result = this.tailMultiset(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	public new virtual SortedMultiset headMultiset(object P_0, BoundType P_1)
	{
		ImmutableSortedMultiset result = this.headMultiset(P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	public new virtual NavigableSet elementSet()
	{
		ImmutableSortedSet result = this.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	public new virtual SortedSet elementSet()
	{
		ImmutableSortedSet result = this.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	public new virtual Set elementSet()
	{
		ImmutableSortedSet result = this.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	public new virtual ImmutableSet elementSet()
	{
		ImmutableSortedSet result = this.elementSet();
		_ = null;
		return result;
	}

	[LineNumberTable(new byte[] { 159, 133, 101, 176, 47 })]
	static RegularImmutableSortedMultiset()
	{
		ImmutableSortedMultiset.___003Cclinit_003E();
		ZERO_CUMULATIVE_COUNTS = new long[1] { 0L };
		NATURAL_EMPTY_MULTISET = new RegularImmutableSortedMultiset(Ordering.natural());
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected RegularImmutableSortedMultiset(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
