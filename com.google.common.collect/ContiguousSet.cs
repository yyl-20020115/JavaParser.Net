using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;

namespace com.google.common.collect;

[Serializable]
[Signature("<C::Ljava/lang/Comparable;>Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public abstract class ContiguousSet : ImmutableSortedSet
{
	[Modifiers(Modifiers.Final)]
	[Signature("Lcom/google/common/collect/DiscreteDomain<TC;>;")]
	internal DiscreteDomain domain;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	protected internal new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<C::Ljava/lang/Comparable;>(Lcom/google/common/collect/Range<TC;>;Lcom/google/common/collect/DiscreteDomain<TC;>;)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(new byte[]
	{
		15, 103, 103, 130, 104, 146, 104, 223, 5, 2,
		97, 204, 104, 228, 70, 120, 152, 173, 99, 104,
		7
	})]
	public static ContiguousSet create(Range range, DiscreteDomain domain)
	{
		Preconditions.checkNotNull(range);
		Preconditions.checkNotNull(domain);
		Range range2 = range;
		NoSuchElementException ex;
		try
		{
			if (!range.hasLowerBound())
			{
				range2 = range2.intersection(Range.atLeast(domain.minValue()));
			}
			if (!range.hasUpperBound())
			{
				range2 = range2.intersection(Range.atMost(domain.maxValue()));
			}
		}
		catch (NoSuchElementException x)
		{
			ex = ByteCodeHelper.MapException<NoSuchElementException>(x, ByteCodeHelper.MapFlags.NoRemapping);
			goto IL_0053;
		}
		int num;
		if (range2.isEmpty())
		{
			num = 1;
		}
		else
		{
			IComparable comparable = (IComparable)java.util.Objects.requireNonNull(range.lowerBound.leastValueAbove(domain));
			IComparable comparable2 = (IComparable)java.util.Objects.requireNonNull(range.upperBound.greatestValueBelow(domain));
			num = ((Range.compareOrThrow(comparable, comparable2) > 0) ? 1 : 0);
		}
		return (num == 0) ? ((ContiguousSet)new RegularContiguousSet(range2, domain)) : ((ContiguousSet)new EmptyContiguousSet(domain));
		IL_0053:
		NoSuchElementException cause = ex;
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new IllegalArgumentException(cause);
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("(TC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	internal virtual ContiguousSet headSetImpl(IComparable P_0, bool P_1)
	{
		throw new AbstractMethodError("com.google.common.collect.ContiguousSet.headSetImpl(Ljava.lang.Comparable;Z)Lcom.google.common.collect.ContiguousSet;");
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("(TC;ZTC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	internal virtual ContiguousSet subSetImpl(IComparable P_0, bool P_1, IComparable P_2, bool P_3)
	{
		throw new AbstractMethodError("com.google.common.collect.ContiguousSet.subSetImpl(Ljava.lang.Comparable;ZLjava.lang.Comparable;Z)Lcom.google.common.collect.ContiguousSet;");
	}

	[Modifiers(Modifiers.Abstract)]
	[Signature("(TC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	internal virtual ContiguousSet tailSetImpl(IComparable P_0, bool P_1)
	{
		throw new AbstractMethodError("com.google.common.collect.ContiguousSet.tailSetImpl(Ljava.lang.Comparable;Z)Lcom.google.common.collect.ContiguousSet;");
	}

	[Signature("()Lcom/google/common/collect/Range<TC;>;")]
	public abstract Range range();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(197)]
	public virtual ContiguousSet tailSet(IComparable fromElement, bool inclusive)
	{
		ContiguousSet result = tailSetImpl((IComparable)Preconditions.checkNotNull(fromElement), inclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(190)]
	public virtual ContiguousSet tailSet(IComparable fromElement)
	{
		ContiguousSet result = tailSetImpl((IComparable)Preconditions.checkNotNull(fromElement), true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;ZTC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(new byte[] { 159, 97, 133, 103, 103, 120 })]
	public virtual ContiguousSet subSet(IComparable fromElement, bool fromInclusive, IComparable toElement, bool toInclusive)
	{
		Preconditions.checkNotNull(fromElement);
		Preconditions.checkNotNull(toElement);
		Preconditions.checkArgument(comparator().compare(fromElement, toElement) <= 0);
		ContiguousSet result = subSetImpl(fromElement, fromInclusive, toElement, toInclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;TC;)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(new byte[] { 121, 103, 103, 120 })]
	public virtual ContiguousSet subSet(IComparable fromElement, IComparable toElement)
	{
		Preconditions.checkNotNull(fromElement);
		Preconditions.checkNotNull(toElement);
		Preconditions.checkArgument(comparator().compare(fromElement, toElement) <= 0);
		ContiguousSet result = subSetImpl(fromElement, true, toElement, false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;Z)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(166)]
	public virtual ContiguousSet headSet(IComparable toElement, bool inclusive)
	{
		ContiguousSet result = headSetImpl((IComparable)Preconditions.checkNotNull(toElement), inclusive);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	[LineNumberTable(159)]
	public virtual ContiguousSet headSet(IComparable toElement)
	{
		ContiguousSet result = headSetImpl((IComparable)Preconditions.checkNotNull(toElement), false);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/collect/ContiguousSet<Ljava/lang/Integer;>;")]
	[LineNumberTable(108)]
	public static ContiguousSet closed(int lower, int upper)
	{
		ContiguousSet result = create(Range.closed(Integer.valueOf(lower), Integer.valueOf(upper)), DiscreteDomain.integers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(JJ)Lcom/google/common/collect/ContiguousSet<Ljava/lang/Long;>;")]
	[LineNumberTable(121)]
	public static ContiguousSet closed(long lower, long upper)
	{
		ContiguousSet result = create(Range.closed(Long.valueOf(lower), Long.valueOf(upper)), DiscreteDomain.longs());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Lcom/google/common/collect/ContiguousSet<Ljava/lang/Integer;>;")]
	[LineNumberTable(134)]
	public static ContiguousSet closedOpen(int lower, int upper)
	{
		ContiguousSet result = create(Range.closedOpen(Integer.valueOf(lower), Integer.valueOf(upper)), DiscreteDomain.integers());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(JJ)Lcom/google/common/collect/ContiguousSet<Ljava/lang/Long;>;")]
	[LineNumberTable(147)]
	public static ContiguousSet closedOpen(long lower, long upper)
	{
		ContiguousSet result = create(Range.closedOpen(Long.valueOf(lower), Long.valueOf(upper)), DiscreteDomain.longs());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/DiscreteDomain<TC;>;)V")]
	[LineNumberTable(new byte[] { 103, 109, 103 })]
	internal ContiguousSet(DiscreteDomain P_0)
		: base(Ordering.natural())
	{
		domain = P_0;
	}

	[Signature("(Lcom/google/common/collect/ContiguousSet<TC;>;)Lcom/google/common/collect/ContiguousSet<TC;>;")]
	public abstract ContiguousSet intersection(ContiguousSet cs);

	[Signature("(Lcom/google/common/collect/BoundType;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/Range<TC;>;")]
	public abstract Range range(BoundType bt1, BoundType bt2);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/ImmutableSortedSet<TC;>;")]
	[LineNumberTable(245)]
	internal override ImmutableSortedSet createDescendingSet()
	{
		DescendingImmutableSortedSet result = new DescendingImmutableSortedSet(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(251)]
	public override string toString()
	{
		string result = range().toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("<E:Ljava/lang/Object;>()Lcom/google/common/collect/ImmutableSortedSet$Builder<TE;>;")]
	[LineNumberTable(265)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public new static Builder builder()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal override ImmutableSortedSet tailSetImpl(object P_0, bool P_1)
	{
		ContiguousSet result = tailSetImpl((IComparable)P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal override ImmutableSortedSet subSetImpl(object P_0, bool P_1, object P_2, bool P_3)
	{
		ContiguousSet result = subSetImpl((IComparable)P_0, P_1, (IComparable)P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(51)]
	internal override ImmutableSortedSet headSetImpl(object P_0, bool P_1)
	{
		ContiguousSet result = headSetImpl((IComparable)P_0, P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public new virtual ImmutableSortedSet _003Cbridge_003EtailSet(object obj, bool b)
	{
		ContiguousSet result = tailSet((IComparable)obj, b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public new virtual ImmutableSortedSet _003Cbridge_003EtailSet(object obj)
	{
		ContiguousSet result = tailSet((IComparable)obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public new virtual ImmutableSortedSet _003Cbridge_003EsubSet(object obj1, bool b1, object obj2, bool b2)
	{
		ContiguousSet result = subSet((IComparable)obj1, b1, (IComparable)obj2, b2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public new virtual ImmutableSortedSet _003Cbridge_003EsubSet(object obj1, object obj2)
	{
		ContiguousSet result = subSet((IComparable)obj1, (IComparable)obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public new virtual ImmutableSortedSet _003Cbridge_003EheadSet(object obj, bool b)
	{
		ContiguousSet result = headSet((IComparable)obj, b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public new virtual ImmutableSortedSet _003Cbridge_003EheadSet(object obj)
	{
		ContiguousSet result = headSet((IComparable)obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public override SortedSet _003Cbridge_003EtailSet(object obj)
	{
		ContiguousSet result = tailSet((IComparable)obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public override SortedSet _003Cbridge_003EheadSet(object obj)
	{
		ContiguousSet result = headSet((IComparable)obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public override SortedSet _003Cbridge_003EsubSet(object obj1, object obj2)
	{
		ContiguousSet result = subSet((IComparable)obj1, (IComparable)obj2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public override NavigableSet _003Cbridge_003EtailSet(object obj, bool b)
	{
		ContiguousSet result = tailSet((IComparable)obj, b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public override NavigableSet _003Cbridge_003EheadSet(object obj, bool b)
	{
		ContiguousSet result = headSet((IComparable)obj, b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(51)]
	public override NavigableSet _003Cbridge_003EsubSet(object obj1, bool b1, object obj2, bool b2)
	{
		ContiguousSet result = subSet((IComparable)obj1, b1, (IComparable)obj2, b2);
		_ = null;
		return result;
	}

	[HideFromJava]
	static ContiguousSet()
	{
		ImmutableSortedSet.___003Cclinit_003E();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected ContiguousSet(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
