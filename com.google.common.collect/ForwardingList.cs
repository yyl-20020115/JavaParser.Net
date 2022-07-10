using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingCollection<TE;>;Ljava/util/List<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 114, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)114,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.List" })]
public abstract class ForwardingList : ForwardingCollection, List, Collection, Iterable, IEnumerable
{
	[Signature("()Ljava/util/List<TE;>;")]
	protected internal new abstract List @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITE;)V")]
	[LineNumberTable(new byte[] { 18, 111 })]
	public virtual void add(int index, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element)
	{
		@delegate().add(index, element);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/ListIterator<TE;>;")]
	[LineNumberTable(95)]
	public virtual ListIterator listIterator()
	{
		ListIterator result = @delegate().listIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Ljava/util/ListIterator<TE;>;")]
	[LineNumberTable(100)]
	public virtual ListIterator listIterator(int index)
	{
		ListIterator result = @delegate().listIterator(index);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(61)]
	protected internal ForwardingList()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ILjava/util/Collection<+TE;>;)Z")]
	[LineNumberTable(74)]
	public virtual bool addAll(int index, Collection elements)
	{
		bool result = @delegate().addAll(index, elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TE;")]
	[LineNumberTable(80)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object get(int index)
	{
		object result = @delegate().get(index);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(85)]
	public virtual int indexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		int result = @delegate().indexOf(element);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(90)]
	public virtual int lastIndexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		int result = @delegate().lastIndexOf(element);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)TE;")]
	[LineNumberTable(107)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object remove(int index)
	{
		object result = @delegate().remove(index);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ITE;)TE;")]
	[LineNumberTable(114)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object set(int index, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element)
	{
		object result = @delegate().set(index, element);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Ljava/util/List<TE;>;")]
	[LineNumberTable(119)]
	public virtual List subList(int fromIndex, int toIndex)
	{
		List result = @delegate().subList(fromIndex, toIndex);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(124)]
	public override bool equals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		return (@object == this || @delegate().equals(@object)) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(129)]
	public override int hashCode()
	{
		int result = @delegate().hashCode();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(new byte[] { 90, 109 })]
	protected internal virtual bool standardAdd([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object element)
	{
		add(size(), element);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(ILjava/lang/Iterable<+TE;>;)Z")]
	[LineNumberTable(152)]
	protected internal virtual bool standardAddAll(int index, Iterable elements)
	{
		bool result = Lists.addAllImpl(this, index, elements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(163)]
	protected internal virtual int standardIndexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		int result = Lists.indexOfImpl(this, element);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(174)]
	protected internal virtual int standardLastIndexOf([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object element)
	{
		int result = Lists.lastIndexOfImpl(this, element);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(185)]
	protected internal virtual Iterator standardIterator()
	{
		ListIterator result = listIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/ListIterator<TE;>;")]
	[LineNumberTable(196)]
	protected internal virtual ListIterator standardListIterator()
	{
		ListIterator result = listIterator(0);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(I)Ljava/util/ListIterator<TE;>;")]
	[LineNumberTable(209)]
	protected internal virtual ListIterator standardListIterator(int start)
	{
		ListIterator result = Lists.listIteratorImpl(this, start);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(II)Ljava/util/List<TE;>;")]
	[LineNumberTable(220)]
	protected internal virtual List standardSubList(int fromIndex, int toIndex)
	{
		List result = Lists.subListImpl(this, fromIndex, toIndex);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(232)]
	protected internal virtual bool standardEquals([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object @object)
	{
		bool result = Lists.equalsImpl(this, @object);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(244)]
	protected internal virtual int standardHashCode()
	{
		int result = Lists.hashCodeImpl(this);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(54)]
	protected internal new virtual Collection _003Cbridge_003Edelegate()
	{
		List result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(54)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		List result = @delegate();
		_ = null;
		return result;
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override void forEach(Consumer P_0)
	{
		Iterable._003Cdefault_003EforEach(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public override Spliterator spliterator()
	{
		return List._003Cdefault_003Espliterator(this);
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
	public virtual void replaceAll(UnaryOperator P_0)
	{
		List._003Cdefault_003EreplaceAll(this, P_0);
	}

	[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
	public virtual void sort(Comparator P_0)
	{
		List._003Cdefault_003Esort(this, P_0);
	}

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}
}
