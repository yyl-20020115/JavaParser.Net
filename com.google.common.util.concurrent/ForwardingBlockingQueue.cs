using System.Collections;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.collect;
using IKVM.Attributes;
using ikvm.lang;
using java.lang;
using java.util;
using java.util.concurrent;
using java.util.function;
using java.util.stream;
using javax.annotation;

namespace com.google.common.util.concurrent;

[Signature("<E:Ljava/lang/Object;>Lcom/google/common/collect/ForwardingQueue<TE;>;Ljava/util/concurrent/BlockingQueue<TE;>;")]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.BlockingQueue" })]
public abstract class ForwardingBlockingQueue : ForwardingQueue, BlockingQueue, java.util.Queue, Collection, Iterable, IEnumerable
{
	[Signature("()Ljava/util/concurrent/BlockingQueue<TE;>;")]
	protected internal new abstract BlockingQueue @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(46)]
	protected internal ForwardingBlockingQueue()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<-TE;>;I)I")]
	[LineNumberTable(53)]
	public virtual int drainTo(Collection c, int maxElements)
	{
		int result = @delegate().drainTo(c, maxElements);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/Collection<-TE;>;)I")]
	[LineNumberTable(58)]
	public virtual int drainTo(Collection c)
	{
		int result = @delegate().drainTo(c);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(TE;JLjava/util/concurrent/TimeUnit;)Z")]
	[LineNumberTable(63)]
	public virtual bool offer(object e, long timeout, TimeUnit unit)
	{
		bool result = @delegate().offer(e, timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(JLjava/util/concurrent/TimeUnit;)TE;")]
	[LineNumberTable(69)]
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
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("(TE;)V")]
	[LineNumberTable(new byte[] { 24, 110 })]
	public virtual void put(object e)
	{
		@delegate().put(e);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(79)]
	public virtual int remainingCapacity()
	{
		int result = @delegate().remainingCapacity();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("()TE;")]
	[LineNumberTable(84)]
	public virtual object take()
	{
		object result = @delegate().take();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(39)]
	protected internal new virtual java.util.Queue _003Cbridge_003Edelegate()
	{
		BlockingQueue result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(39)]
	protected internal override Collection _003Cbridge_003Edelegate()
	{
		BlockingQueue result = @delegate();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(39)]
	protected internal override object _003Cbridge_003Edelegate()
	{
		BlockingQueue result = @delegate();
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
