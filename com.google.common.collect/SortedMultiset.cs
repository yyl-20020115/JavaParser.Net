using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Ljava/lang/Object;Lcom/google/common/collect/SortedMultisetBridge<TE;>;Lcom/google/common/collect/SortedIterable<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 59, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)59,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SortedMultisetBridge", "com.google.common.collect.SortedIterable" })]
public interface SortedMultiset : SortedMultisetBridge, Multiset, Collection, Iterable, SortedIterable
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static SortedSet elementSet(SortedMultiset P_0)
		{
			__ldvirtftn(object.ToString);
			return SortedMultiset._003Cdefault_003E_003Cbridge_003EelementSet(P_0);
		}

		public unsafe static Set elementSet(SortedMultiset P_0)
		{
			__ldvirtftn(object.ToString);
			return SortedMultiset._003Cdefault_003E_003Cbridge_003EelementSet(P_0);
		}
	}

	[Signature("()Ljava/util/NavigableSet<TE;>;")]
	NavigableSet elementSet();

	[Signature("()Ljava/util/Comparator<-TE;>;")]
	Comparator comparator();

	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual Entry firstEntry();

	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual Entry lastEntry();

	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual Entry pollFirstEntry();

	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	virtual Entry pollLastEntry();

	[Signature("()Ljava/util/Set<Lcom/google/common/collect/Multiset$Entry<TE;>;>;")]
	Set entrySet();

	[Signature("()Ljava/util/Iterator<TE;>;")]
	Iterator iterator();

	[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
	virtual SortedMultiset descendingMultiset();

	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	virtual SortedMultiset headMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, BoundType bt);

	[Signature("(TE;Lcom/google/common/collect/BoundType;TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	virtual SortedMultiset subMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj1, BoundType bt1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj2, BoundType bt2);

	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	virtual SortedMultiset tailMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object obj, BoundType bt);

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual SortedSet _003Cbridge_003EelementSet();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(45)]
	static SortedSet _003Cdefault_003E_003Cbridge_003EelementSet(SortedMultiset P_0)
	{
		NavigableSet result = P_0.elementSet();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual Set _003Cbridge_003EelementSet();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(45)]
	static Set _003Cdefault_003E_003Cbridge_003EelementSet(SortedMultiset P_0)
	{
		NavigableSet result = P_0.elementSet();
		_ = null;
		return result;
	}
}
