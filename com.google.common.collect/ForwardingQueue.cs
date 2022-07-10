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

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingCollection<TE;>;Ljava/util/Queue<TE;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 62, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)62,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.Queue" })]
public abstract class ForwardingQueue : ForwardingCollection, java.util.Queue, Collection, Iterable, IEnumerable
{
	[Signature("()Ljava/util/Queue<TE;>;")]
	protected internal new abstract java.util.Queue @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(88)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object element()
	{
		object result = @delegate().element();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(76)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})]
	public virtual object remove()
	{
		object result = @delegate().remove();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(54)]
	protected internal ForwardingQueue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(62)]
	public virtual bool offer([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object o)
	{
		bool result = @delegate().offer(o);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(69)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object poll()
	{
		object result = @delegate().poll();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(82)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object peek()
	{
		object result = @delegate().peek();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(TE;)Z")]
	[LineNumberTable(new byte[] { 49, 118, 97 })]
	protected internal virtual bool standardOffer([ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/collect/ParametricNullness;"
	})] object e)
	{
		//Discarded unreachable code: IL_0009
		try
		{
			return add(e);
		}
		catch (IllegalStateException)
		{
		}
		_ = null;
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(new byte[] { 64, 117, 97 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardPeek()
	{
		//Discarded unreachable code: IL_0008
		try
		{
			return element();
		}
		catch (NoSuchElementException)
		{
		}
		_ = null;
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()TE;")]
	[LineNumberTable(new byte[] { 79, 117, 97 })]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	protected internal virtual object standardPoll()
	{
		//Discarded unreachable code: IL_0008
		try
		{
			return remove();
		}
		catch (NoSuchElementException)
		{
		}
		_ = null;
		return null;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	protected internal new virtual Collection _003Cbridge_003Edelegate()
	{
		java.util.Queue result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		java.util.Queue result = @delegate();
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
