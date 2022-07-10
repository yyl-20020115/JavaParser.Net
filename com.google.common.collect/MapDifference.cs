using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<K:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 2, 17, 0, 0, 0, 0, 33, 0, 0,
	17, 1, 0, 0, 0, 33, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)33,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use Maps.difference"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public interface MapDifference
{
	[Signature("<V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 23, 0, 0 })]
	[ConstantPool(new object[]
	{
		(byte)23,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	[DoNotMock(new object[]
	{
		(byte)64,
		"Lcom/google/errorprone/annotations/DoNotMock;",
		"value",
		"Use Maps.difference"
	})]
	public interface ValueDifference
	{
		[Signature("()TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		virtual object leftValue();

		[Signature("()TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		virtual object rightValue();

		virtual bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object obj);

		virtual int hashCode();
	}

	virtual bool areEqual();

	[Signature("()Ljava/util/Map<TK;TV;>;")]
	virtual Map entriesOnlyOnLeft();

	[Signature("()Ljava/util/Map<TK;TV;>;")]
	virtual Map entriesOnlyOnRight();

	[Signature("()Ljava/util/Map<TK;TV;>;")]
	virtual Map entriesInCommon();

	[Signature("()Ljava/util/Map<TK;Lcom/google/common/collect/MapDifference$ValueDifference<TV;>;>;")]
	virtual Map entriesDiffering();

	virtual bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual int hashCode();
}
