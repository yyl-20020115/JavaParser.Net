using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<C::Ljava/lang/Comparable;>Ljava/lang/Object;Lcom/google/common/collect/RangeSet<TC;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
internal abstract class AbstractRangeSet : java.lang.Object, RangeSet
{
	[Signature("(TC;)Lcom/google/common/collect/Range<TC;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public abstract Range rangeContaining(IComparable P_0);

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set asRanges();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
	[LineNumberTable(51)]
	public virtual void remove(Range P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual bool enclosesAll(Iterable P_0)
	{
		return RangeSet._003Cdefault_003EenclosesAll(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void addAll(Iterable P_0)
	{
		RangeSet._003Cdefault_003EaddAll(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void removeAll(Iterable P_0)
	{
		RangeSet._003Cdefault_003EremoveAll(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract RangeSet subRangeSet(Range P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(28)]
	internal AbstractRangeSet()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TC;)Z")]
	[LineNumberTable(32)]
	public virtual bool contains(IComparable P_0)
	{
		return rangeContaining(P_0) != null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(41)]
	public virtual bool isEmpty()
	{
		bool result = asRanges().isEmpty();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)V")]
	[LineNumberTable(46)]
	public virtual void add(Range P_0)
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 6, 109 })]
	public virtual void clear()
	{
		remove(Range.all());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)Z")]
	[LineNumberTable(61)]
	public virtual bool enclosesAll(RangeSet P_0)
	{
		bool result = enclosesAll(P_0.asRanges());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)V")]
	[LineNumberTable(new byte[] { 16, 110 })]
	public virtual void addAll(RangeSet P_0)
	{
		addAll(P_0.asRanges());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/RangeSet<TC;>;)V")]
	[LineNumberTable(new byte[] { 21, 110 })]
	public virtual void removeAll(RangeSet P_0)
	{
		removeAll(P_0.asRanges());
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
	[LineNumberTable(76)]
	public virtual bool intersects(Range P_0)
	{
		return (!subRangeSet(P_0).isEmpty()) ? true : false;
	}

	[Signature("(Lcom/google/common/collect/Range<TC;>;)Z")]
	public abstract bool encloses(Range P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 100, 98, 104, 103, 148 })]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object P_0)
	{
		if (P_0 == this)
		{
			return true;
		}
		if (P_0 is RangeSet)
		{
			RangeSet rangeSet = (RangeSet)P_0;
			bool result = asRanges().equals(rangeSet.asRanges());
			_ = null;
			return result;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(95)]
	public sealed override int hashCode()
	{
		int result = asRanges().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(100)]
	public sealed override string toString()
	{
		string result = java.lang.Object.instancehelper_toString(asRanges());
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Range span();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract Set asDescendingSetOfRanges();

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public abstract RangeSet complement();
}
