using com.google.errorprone.annotations;
using IKVM.Attributes;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
[RuntimeVisibleTypeAnnotations(new byte[]
{
	0, 3, 17, 0, 0, 0, 0, 71, 0, 0,
	17, 1, 0, 0, 0, 71, 0, 0, 17, 2,
	0, 0, 0, 71, 0, 0
})]
[ConstantPool(new object[]
{
	(byte)71,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[DoNotMock(new object[]
{
	(byte)64,
	"Lcom/google/errorprone/annotations/DoNotMock;",
	"value",
	"Use ImmutableTable, HashBasedTable, or another implementation"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public interface Table
{
	[Signature("<R:Ljava/lang/Object;C:Ljava/lang/Object;V:Ljava/lang/Object;>Ljava/lang/Object;")]
	[RuntimeVisibleTypeAnnotations(new byte[]
	{
		0, 3, 17, 0, 0, 0, 0, 23, 0, 0,
		17, 1, 0, 0, 0, 23, 0, 0, 17, 2,
		0, 0, 0, 23, 0, 0
	})]
	[ConstantPool(new object[]
	{
		(byte)23,
		"Lorg/checkerframework/checker/nullness/qual/Nullable;"
	})]
	public interface Cell
	{
		[Signature("()TV;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		virtual object getValue();

		[Signature("()TR;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		virtual object getRowKey();

		[Signature("()TC;")]
		[ParametricNullness(new object[]
		{
			(byte)64,
			"Lcom/google/common/collect/ParametricNullness;"
		})]
		virtual object getColumnKey();

		virtual bool equals([CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})] object obj);

		virtual int hashCode();
	}

	virtual bool contains([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2);

	virtual bool containsRow([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual bool containsColumn([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual bool containsValue([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object get([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2);

	virtual bool isEmpty();

	virtual int size();

	virtual bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj);

	virtual int hashCode();

	virtual void clear();

	[Signature("(TR;TC;TV;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object put([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj3);

	[Signature("(Lcom/google/common/collect/Table<+TR;+TC;+TV;>;)V")]
	virtual void putAll(Table t);

	[Signature("(Ljava/lang/Object;Ljava/lang/Object;)TV;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual object remove([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj1, [CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object obj2);

	[Signature("(TR;)Ljava/util/Map<TC;TV;>;")]
	virtual Map row([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	[Signature("(TC;)Ljava/util/Map<TR;TV;>;")]
	virtual Map column([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj);

	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Table$Cell<TR;TC;TV;>;>;")]
	virtual Set cellSet();

	[Signature("()Ljava/util/Set<TR;>;")]
	virtual Set rowKeySet();

	[Signature("()Ljava/util/Set<TC;>;")]
	virtual Set columnKeySet();

	[Signature("()Ljava/util/Collection<TV;>;")]
	virtual Collection values();

	[Signature("()Ljava/util/Map<TR;Ljava/util/Map<TC;TV;>;>;")]
	virtual Map rowMap();

	[Signature("()Ljava/util/Map<TC;Ljava/util/Map<TR;TV;>;>;")]
	virtual Map columnMap();
}
