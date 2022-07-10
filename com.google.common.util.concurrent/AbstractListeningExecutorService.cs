using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)32,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.util.concurrent.ListeningExecutorService" })]
public abstract class AbstractListeningExecutorService : AbstractExecutorService, ListeningExecutorService, ExecutorService, Executor
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 32, 0, 0 })]
	[LineNumberTable(69)]
	public new virtual ListenableFuture submit(Callable task)
	{
		return (ListenableFuture)base.submit(task);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Lcom/google/common/util/concurrent/ListenableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 32, 0, 0 })]
	[LineNumberTable(64)]
	public new virtual ListenableFuture submit(Runnable task, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object result)
	{
		return (ListenableFuture)base.submit(task, result);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Runnable;)Lcom/google/common/util/concurrent/ListenableFuture<*>;")]
	[LineNumberTable(58)]
	public new virtual ListenableFuture submit(Runnable task)
	{
		return (ListenableFuture)base.submit(task);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(40)]
	public AbstractListeningExecutorService()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/RunnableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 32, 0, 0 })]
	[LineNumberTable(47)]
	protected internal sealed override RunnableFuture newTaskFor(Runnable runnable, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object value)
	{
		TrustedListenableFutureTask result = TrustedListenableFutureTask.create(runnable, value);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent/RunnableFuture<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 32, 0, 0 })]
	[LineNumberTable(53)]
	protected internal sealed override RunnableFuture newTaskFor(Callable callable)
	{
		TrustedListenableFutureTask result = TrustedListenableFutureTask.create(callable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 32, 0, 0 })]
	[LineNumberTable(36)]
	public virtual Future _003Cbridge_003Esubmit(Callable c)
	{
		ListenableFuture result = submit(c);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 32, 0, 0 })]
	[LineNumberTable(36)]
	public virtual Future _003Cbridge_003Esubmit(Runnable r, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object obj)
	{
		ListenableFuture result = submit(r, obj);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[LineNumberTable(36)]
	public virtual Future _003Cbridge_003Esubmit(Runnable r)
	{
		ListenableFuture result = submit(r);
		_ = null;
		return result;
	}

	List ListeningExecutorService.ListeningExecutorService_003A_003AinvokeAll(Collection P_0)
	{
		return invokeAll(P_0);
	}

	List ListeningExecutorService.ListeningExecutorService_003A_003AinvokeAll(Collection P_0, long P_1, TimeUnit P_2)
	{
		return invokeAll(P_0, P_1, P_2);
	}

	bool ExecutorService.ExecutorService_003A_003AisTerminated()
	{
		return isTerminated();
	}

	bool ExecutorService.ExecutorService_003A_003AawaitTermination(long P_0, TimeUnit P_1)
	{
		return awaitTermination(P_0, P_1);
	}

	void ExecutorService.ExecutorService_003A_003Ashutdown()
	{
		shutdown();
	}

	List ExecutorService.ExecutorService_003A_003AshutdownNow()
	{
		return shutdownNow();
	}

	bool ExecutorService.ExecutorService_003A_003AisShutdown()
	{
		return isShutdown();
	}

	Future ExecutorService.ExecutorService_003A_003Asubmit(Callable P_0)
	{
		return _003Cbridge_003Esubmit(P_0);
	}

	Future ExecutorService.ExecutorService_003A_003Asubmit(Runnable P_0, object P_1)
	{
		return _003Cbridge_003Esubmit(P_0, P_1);
	}

	Future ExecutorService.ExecutorService_003A_003Asubmit(Runnable P_0)
	{
		return _003Cbridge_003Esubmit(P_0);
	}

	List ExecutorService.ExecutorService_003A_003AinvokeAll(Collection P_0)
	{
		return invokeAll(P_0);
	}

	List ExecutorService.ExecutorService_003A_003AinvokeAll(Collection P_0, long P_1, TimeUnit P_2)
	{
		return invokeAll(P_0, P_1, P_2);
	}

	object ExecutorService.ExecutorService_003A_003AinvokeAny(Collection P_0)
	{
		return invokeAny(P_0);
	}

	object ExecutorService.ExecutorService_003A_003AinvokeAny(Collection P_0, long P_1, TimeUnit P_2)
	{
		return invokeAny(P_0, P_1, P_2);
	}

	void Executor.Executor_003A_003Aexecute(Runnable P_0)
	{
		execute(P_0);
	}
}
