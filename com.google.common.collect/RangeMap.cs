using System;
using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.util;
using java.util.function;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K::Ljava/lang/Comparable;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[ConstantPool(new object[]
{
	(byte)34,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use ImmutableRangeMap or TreeRangeMap"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public interface RangeMap
{
	[Signature("(TK;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object get(IComparable c);

	[Signature("(TK;)Ljava/util/Map$Entry<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual Map.Entry getEntry(IComparable c);

	[Signature("()Lcom/google/common/collect/Range<TK;>;")]
	virtual Range span();

	[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)V")]
	virtual void put(Range r, object obj);

	[Signature("(Lcom/google/common/collect/Range<TK;>;TV;)V")]
	virtual void putCoalescing(Range r, object obj);

	[Signature("(Lcom/google/common/collect/RangeMap<TK;TV;>;)V")]
	virtual void putAll(RangeMap rm);

	virtual void clear();

	[Signature("(Lcom/google/common/collect/Range<TK;>;)V")]
	virtual void remove(Range r);

	[Signature("(Lcom/google/common/collect/Range<TK;>;TV;Ljava/util/function/BiFunction<-TV;-TV;+TV;>;)V")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 2, 22, 2, 2, 3, 1, 2, 0, 0,
		34, 0, 0, 22, 2, 2, 3, 2, 2, 0,
		0, 34, 0, 0
	})]
	virtual void merge(Range r, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj, BiFunction bf);

	[Signature("()Ljava/util/Map<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	virtual Map asMapOfRanges();

	[Signature("()Ljava/util/Map<Lcom/google/common/collect/Range<TK;>;TV;>;")]
	virtual Map asDescendingMapOfRanges();

	[Signature("(Lcom/google/common/collect/Range<TK;>;)Lcom/google/common/collect/RangeMap<TK;TV;>;")]
	virtual RangeMap subRangeMap(Range r);

	virtual bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual int hashCode();

	virtual string toString();
}
