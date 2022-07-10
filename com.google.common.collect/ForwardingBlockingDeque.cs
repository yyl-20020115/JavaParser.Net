using System;
using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.collect;

[Obsolete]
[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingDeque<TE;>;Ljava/util/concurrent/BlockingDeque<TE;>;")]
[Deprecated(new object[]
{
	(byte)64,
	"Ljava/lang/Deprecated;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.BlockingDeque" })]
public abstract class ForwardingBlockingDeque : ForwardingDeque, BlockingDeque, BlockingQueue, java.util.Queue, Collection, Iterable, IEnumerable, Deque
{
	[Signature("()Ljava/util/concurrent/BlockingDeque<TE;>;")]
	protected internal new abstract BlockingDeque @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	protected internal ForwardingBlockingDeque()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(62)]
	public virtual int remainingCapacity()
	{
		int result = @delegate().remainingCapacity();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 17, 110 })]
	public virtual void putFirst(object e)
	{
		@delegate().putFirst(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 22, 110 })]
	public virtual void putLast(object e)
	{
		@delegate().putLast(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(TE;JLjava/util/concurrent/TimeUnit;)Z")]
	[LineNumberTable(77)]
	public virtual bool offerFirst(object e, long timeout, TimeUnit unit)
	{
		bool result = @delegate().offerFirst(e, timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(TE;JLjava/util/concurrent/TimeUnit;)Z")]
	[LineNumberTable(82)]
	public virtual bool offerLast(object e, long timeout, TimeUnit unit)
	{
		bool result = @delegate().offerLast(e, timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("()TE;")]
	[LineNumberTable(87)]
	public virtual object takeFirst()
	{
		object result = @delegate().takeFirst();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("()TE;")]
	[LineNumberTable(92)]
	public virtual object takeLast()
	{
		object result = @delegate().takeLast();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(JLjava/util/concurrent/TimeUnit;)TE;")]
	[LineNumberTable(98)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object pollFirst(long timeout, TimeUnit unit)
	{
		object result = @delegate().pollFirst(timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(JLjava/util/concurrent/TimeUnit;)TE;")]
	[LineNumberTable(104)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object pollLast(long timeout, TimeUnit unit)
	{
		object result = @delegate().pollLast(timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 59, 110 })]
	public virtual void put(object e)
	{
		@delegate().put(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(TE;JLjava/util/concurrent/TimeUnit;)Z")]
	[LineNumberTable(114)]
	public virtual bool offer(object e, long timeout, TimeUnit unit)
	{
		bool result = @delegate().offer(e, timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("()TE;")]
	[LineNumberTable(119)]
	public virtual object take()
	{
		object result = @delegate().take();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(JLjava/util/concurrent/TimeUnit;)TE;")]
	[LineNumberTable(125)]
	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	public virtual object poll(long timeout, TimeUnit unit)
	{
		object result = @delegate().poll(timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<-TE;>;)I")]
	[LineNumberTable(130)]
	public virtual int drainTo(Collection c)
	{
		int result = @delegate().drainTo(c);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<-TE;>;I)I")]
	[LineNumberTable(135)]
	public virtual int drainTo(Collection c, int maxElements)
	{
		int result = @delegate().drainTo(c, maxElements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	protected internal new virtual Deque _003Cbridge_003Edelegate()
	{
		BlockingDeque result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	protected internal override java.util.Queue _003Cbridge_003Edelegate()
	{
		BlockingDeque result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	protected internal override Collection _003Cbridge_003Edelegate()
	{
		BlockingDeque result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(48)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		BlockingDeque result = @delegate();
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
		return java.lang.Object.instancehelper_equals(this, P_0);
	}

	int Collection.Collection_003A_003AhashCode()
	{
		return java.lang.Object.instancehelper_hashCode(this);
	}
}
