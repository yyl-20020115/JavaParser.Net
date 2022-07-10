using System;
using System.Collections;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Security.Permissions;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Serializable]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/Multisets$UnmodifiableMultiset<TE;>;Lcom/google/common/collect/SortedMultiset<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 99, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)99,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.collect.SortedMultiset" })]
internal sealed class UnmodifiableSortedMultiset : Multisets.UnmodifiableMultiset, SortedMultiset, SortedMultisetBridge, Multiset, Collection, Iterable, IEnumerable, SortedIterable
{
	[NonSerialized]
	[Signature("Lcom/google/common/collect/UnmodifiableSortedMultiset<TE;>;")]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private UnmodifiableSortedMultiset m_descendingMultiset;

	private const long serialVersionUID = 0L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Lcom/google/common/collect/SortedMultiset<TE;>;)V")]
	[LineNumberTable(new byte[] { 159, 180, 105 })]
	internal UnmodifiableSortedMultiset(SortedMultiset P_0)
		: base(P_0)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(43)]
	protected internal new virtual SortedMultiset @delegate()
	{
		return (SortedMultiset)base.@delegate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(58)]
	public new virtual NavigableSet elementSet()
	{
		return (NavigableSet)base.elementSet();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/NavigableSet<TE;>;")]
	[LineNumberTable(53)]
	internal new virtual NavigableSet createElementSet()
	{
		NavigableSet result = Sets.unmodifiableNavigableSet(@delegate().elementSet());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<-TE;>;")]
	[LineNumberTable(48)]
	public virtual Comparator comparator()
	{
		Comparator result = @delegate().comparator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 15, 103, 99, 113, 103, 141 })]
	public virtual SortedMultiset descendingMultiset()
	{
		UnmodifiableSortedMultiset unmodifiableSortedMultiset = this.m_descendingMultiset;
		if (unmodifiableSortedMultiset == null)
		{
			unmodifiableSortedMultiset = new UnmodifiableSortedMultiset(@delegate().descendingMultiset());
			unmodifiableSortedMultiset.m_descendingMultiset = this;
			UnmodifiableSortedMultiset result = unmodifiableSortedMultiset;
			this.m_descendingMultiset = result;
			return result;
		}
		return unmodifiableSortedMultiset;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(77)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry firstEntry()
	{
		Multiset.Entry result = @delegate().firstEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(83)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry lastEntry()
	{
		Multiset.Entry result = @delegate().lastEntry();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(89)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry pollFirstEntry()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Lcom/google/common/collect/Multiset$Entry<TE;>;")]
	[LineNumberTable(95)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual Multiset.Entry pollLastEntry()
	{
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new UnsupportedOperationException();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(100)]
	public virtual SortedMultiset headMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, BoundType P_1)
	{
		SortedMultiset result = Multisets.unmodifiableSortedMultiset(@delegate().headMultiset(P_0, P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(new byte[] { 59, 97, 47 })]
	public virtual SortedMultiset subMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, BoundType P_1, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_2, BoundType P_3)
	{
		SortedMultiset result = Multisets.unmodifiableSortedMultiset(@delegate().subMultiset(P_0, P_1, P_2, P_3));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;Lcom/google/common/collect/BoundType;)Lcom/google/common/collect/SortedMultiset<TE;>;")]
	[LineNumberTable(115)]
	public virtual SortedMultiset tailMultiset([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object P_0, BoundType P_1)
	{
		SortedMultiset result = Multisets.unmodifiableSortedMultiset(@delegate().tailMultiset(P_0, P_1));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	public override Set elementSet()
	{
		NavigableSet result = this.elementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	internal override Set createElementSet()
	{
		NavigableSet result = createElementSet();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	protected internal override Multiset @delegate()
	{
		SortedMultiset result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	protected internal override Collection @delegate()
	{
		SortedMultiset result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	protected internal override object @delegate()
	{
		SortedMultiset result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[LineNumberTable(33)]
	public new virtual SortedSet elementSet()
	{
		NavigableSet result = this.elementSet();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(Consumer P_0)
	{
		Multiset._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Spliterator spliterator()
	{
		return Multiset._003Cdefault_003Espliterator(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override bool removeIf(Predicate P_0)
	{
		return Collection._003Cdefault_003EremoveIf(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Stream stream()
	{
		return Collection._003Cdefault_003Estream(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Stream parallelStream()
	{
		return Collection._003Cdefault_003EparallelStream(this);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEachEntry(ObjIntConsumer P_0)
	{
		Multiset._003Cdefault_003EforEachEntry(this, P_0);
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	SortedSet SortedMultiset.SortedMultiset_003A_003AelementSet()
	{
		return this.elementSet();
	}

	Set SortedMultiset.SortedMultiset_003A_003AelementSet()
	{
		return this.elementSet();
	}

	[HideFromJava]
	[PermissionSet(SecurityAction.Demand, XML = "<PermissionSet class=\"System.Security.PermissionSet\"\r\nversion=\"1\">\r\n<IPermission class=\"System.Security.Permissions.SecurityPermission, mscorlib, Version=2.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089\"\r\nversion=\"1\"\r\nFlags=\"SerializationFormatter\"/>\r\n</PermissionSet>\r\n")]
	protected UnmodifiableSortedMultiset(SerializationInfo P_0, StreamingContext P_1)
		: base(P_0, P_1)
	{
	}
}
