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

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingQueue<TE;>;Ljava/util/Deque<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 79, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)79,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Deque" })]
public abstract class ForwardingDeque : ForwardingQueue, Deque, java.util.Queue, Collection, Iterable, IEnumerable
{
	[Signature("()Ljava/util/Deque<TE;>;")]
	protected internal new abstract Deque @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(49)]
	protected internal ForwardingDeque()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 6, 110 })]
	public virtual void addFirst([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		@delegate().addFirst(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 11, 110 })]
	public virtual void addLast([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		@delegate().addLast(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Iterator<TE;>;")]
	[LineNumberTable(66)]
	public virtual Iterator descendingIterator()
	{
		Iterator result = @delegate().descendingIterator();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(72)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object getFirst()
	{
		object first = @delegate().getFirst();
		_ = null;
		return first;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(78)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object getLast()
	{
		object last = @delegate().getLast();
		_ = null;
		return last;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(84)]
	public virtual bool offerFirst([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		bool result = @delegate().offerFirst(e);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(90)]
	public virtual bool offerLast([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		bool result = @delegate().offerLast(e);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(96)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object peekFirst()
	{
		object result = @delegate().peekFirst();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(102)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object peekLast()
	{
		object result = @delegate().peekLast();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(109)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object pollFirst()
	{
		object result = @delegate().pollFirst();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(116)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object pollLast()
	{
		object result = @delegate().pollLast();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(123)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object pop()
	{
		object result = @delegate().pop();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 78, 110 })]
	public virtual void push([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		@delegate().push(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(135)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object removeFirst()
	{
		object result = @delegate().removeFirst();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(142)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object removeLast()
	{
		object result = @delegate().removeLast();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(148)]
	public virtual bool removeFirstOccurrence([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object o)
	{
		bool result = @delegate().removeFirstOccurrence(o);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(154)]
	public virtual bool removeLastOccurrence([CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})] object o)
	{
		bool result = @delegate().removeLastOccurrence(o);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(43)]
	protected internal new virtual java.util.Queue _003Cbridge_003Edelegate()
	{
		Deque result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(43)]
	protected internal override Collection _003Cbridge_003Edelegate()
	{
		Deque result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(43)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		Deque result = @delegate();
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
		return Collection._003Cdefault_003Espliterator(this);
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

	[SpecialName]
	[HideFromJava]
	IEnumerator IEnumerable.GetEnumerator()
	{
		return new IterableEnumerator(this);
	}

	bool Collection.Collection_003A_003Aequals(object P_0)
	{
		return Object.instancehelper_equals(this, P_0);
	}

	int Collection.Collection_003A_003AhashCode()
	{
		return Object.instancehelper_hashCode(this);
	}
}
