using System;
using System.Runtime.CompilerServices;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<C::Ljava/lang/Comparable;>Ljava/lang/Object;")]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use ImmutableRangeSet or TreeRangeSet"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public interface RangeSet
{
	[HideFromJava]
	public static class __DefaultMethods
	{
		public unsafe static bool enclosesAll(RangeSet P_0, Iterable P_1)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EenclosesAll(P_0, P_1);
		}

		public unsafe static void addAll(RangeSet P_0, Iterable P_1)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003EaddAll(P_0, P_1);
		}

		public unsafe static void removeAll(RangeSet P_0, Iterable P_1)
		{
			__ldvirtftn(object.ToString);
			_003Cdefault_003EremoveAll(P_0, P_1);
		}
	}

	[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
	virtual bool encloses(Range r);

	[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
	virtual void add(Range r);

	[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
	virtual void remove(Range r);

	[Signature("(TC;)Z")]
	virtual bool contains(IComparable c);

	[Signature("(TC;)Lcom/google/common/collect/Range<TC;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual Range rangeContaining(IComparable c);

	[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
	virtual bool intersects(Range r);

	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)Z")]
	virtual bool enclosesAll(RangeSet rs);

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/lang/Iterable<Lcom/google/common/collect/Range<TC;>;>;)Z")]
	virtual bool enclosesAll(Iterable other);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 58, 123, 105, 130, 98 })]
	static bool _003Cdefault_003EenclosesAll(RangeSet P_0, Iterable P_1)
	{
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			Range r = (Range)iterator.next();
			if (!P_0.encloses(r))
			{
				return false;
			}
		}
		return true;
	}

	virtual bool isEmpty();

	[Signature("()Lcom/google/common/collect/Range<TC;>;")]
	virtual Range span();

	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Range<TC;>;>;")]
	virtual Set asRanges();

	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Range<TC;>;>;")]
	virtual Set asDescendingSetOfRanges();

	[Signature("()Lcom/google/common/collect/RangeSet<TC;>;")]
	virtual RangeSet complement();

	[Signature("(Lcom/google/common/collect/Range<TC;>;)Lcom/google/common/collect/RangeSet<TC;>;")]
	virtual RangeSet subRangeSet(Range r);

	virtual void clear();

	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)V")]
	virtual void addAll(RangeSet rs);

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/lang/Iterable<Lcom/google/common/collect/Range<TC;>;>;)V")]
	virtual void addAll(Iterable ranges);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 160, 112, 123, 103, 98 })]
	static void _003Cdefault_003EaddAll(RangeSet P_0, Iterable P_1)
	{
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			Range r = (Range)iterator.next();
			P_0.add(r);
		}
	}

	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)V")]
	virtual void removeAll(RangeSet rs);

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/lang/Iterable<Lcom/google/common/collect/Range<TC;>;>;)V")]
	virtual void removeAll(Iterable ranges);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 160, 141, 123, 103, 98 })]
	static void _003Cdefault_003EremoveAll(RangeSet P_0, Iterable P_1)
	{
		Iterator iterator = P_1.iterator();
		while (iterator.hasNext())
		{
			Range r = (Range)iterator.next();
			P_0.remove(r);
		}
	}

	virtual bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual int hashCode();

	virtual string toString();
}
