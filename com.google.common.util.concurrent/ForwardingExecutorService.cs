using System.ComponentModel;
using System.Runtime.CompilerServices;
using com.google.common.collect;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)45,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.ExecutorService" })]
public abstract class ForwardingExecutorService : ForwardingObject, ExecutorService, Executor
{
	protected internal new abstract ExecutorService @delegate();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(44)]
	protected internal ForwardingExecutorService()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(51)]
	public virtual bool awaitTermination(long timeout, TimeUnit unit)
	{
		bool result = @delegate().awaitTermination(timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
	[LineNumberTable(57)]
	public virtual List invokeAll(Collection tasks)
	{
		List result = @delegate().invokeAll(tasks);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;JLjava/util/concurrent/TimeUnit;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
	[LineNumberTable(64)]
	public virtual List invokeAll(Collection tasks, long timeout, TimeUnit unit)
	{
		List result = @delegate().invokeAll(tasks, timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
	[LineNumberTable(70)]
	public virtual object invokeAny(Collection tasks)
	{
		object result = @delegate().invokeAny(tasks);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
	[LineNumberTable(77)]
	public virtual object invokeAny(Collection tasks, long timeout, TimeUnit unit)
	{
		object result = @delegate().invokeAny(tasks, timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(82)]
	public virtual bool isShutdown()
	{
		bool result = @delegate().isShutdown();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(87)]
	public virtual bool isTerminated()
	{
		bool result = @delegate().isTerminated();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 42, 109 })]
	public virtual void shutdown()
	{
		@delegate().shutdown();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<Ljava/lang/Runnable;>;")]
	[LineNumberTable(97)]
	public virtual List shutdownNow()
	{
		List result = @delegate().shutdownNow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 52, 110 })]
	public virtual void execute(Runnable command)
	{
		@delegate().execute(command);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent/Future<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
	[LineNumberTable(107)]
	public virtual Future submit(Callable task)
	{
		Future result = @delegate().submit(task);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Runnable;)Ljava/util/concurrent/Future<*>;")]
	[LineNumberTable(112)]
	public virtual Future submit(Runnable task)
	{
		Future result = @delegate().submit(task);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Future<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 45, 0, 0 })]
	[LineNumberTable(118)]
	public virtual Future submit(Runnable task, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object result)
	{
		Future result2 = @delegate().submit(task, result);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Protected | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(38)]
	protected internal virtual object _003Cbridge_003Edelegate()
	{
		ExecutorService result = @delegate();
		_ = null;
		return result;
	}
}
