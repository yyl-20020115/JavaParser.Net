using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.collect;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)51,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.ExecutorService" })]
internal abstract class WrappingExecutorService : java.lang.Object, ExecutorService, Executor
{
	[SpecialName]
	private sealed class ___003C_003EAnon0 : Runnable
	{
		private readonly Callable arg_00241;

		internal ___003C_003EAnon0(Callable P_0)
		{
			arg_00241 = P_0;
		}

		public void run()
		{
			lambda_0024wrapTask_00240(arg_00241);
			_ = null;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private ExecutorService @delegate;

	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent/Callable<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
	protected internal abstract Callable wrapTask(Callable P_0);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 15, 110 })]
	protected internal virtual Runnable wrapTask(Runnable P_0)
	{
		Callable callable = wrapTask(Executors.callable(P_0, null));
		return new ___003C_003EAnon0(callable);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;)Lcom/google/common/collect/ImmutableList<Ljava/util/concurrent/Callable<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
	[LineNumberTable(new byte[] { 33, 102, 123, 110, 98 })]
	private ImmutableList wrapTasks(Collection P_0)
	{
		ImmutableList.Builder builder = ImmutableList.builder();
		Iterator iterator = P_0.iterator();
		while (iterator.hasNext())
		{
			Callable callable = (Callable)iterator.next();
			builder.add(wrapTask(callable));
		}
		ImmutableList result = builder.build();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(new byte[] { 18, 222, 226, 61, 97, 102, 140 })]
	private static void lambda_0024wrapTask_00240(Callable P_0)
	{
		java.lang.Exception ex2;
		try
		{
			P_0.call();
			return;
		}
		catch (System.Exception x)
		{
			java.lang.Exception ex = ByteCodeHelper.MapException<java.lang.Exception>(x, ByteCodeHelper.MapFlags.None);
			if (ex == null)
			{
				throw;
			}
			ex2 = ex;
		}
		java.lang.Exception ex3 = ex2;
		Throwables.throwIfUnchecked(ex3);
		Throwable.___003CsuppressFillInStackTrace_003E();
		throw new RuntimeException(ex3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 0, 104, 113 })]
	protected internal WrappingExecutorService(ExecutorService P_0)
	{
		@delegate = (ExecutorService)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 43, 116 })]
	public void execute(Runnable P_0)
	{
		@delegate.execute(wrapTask(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TT;>;)Ljava/util/concurrent/Future<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
	[LineNumberTable(98)]
	public Future submit(Callable P_0)
	{
		Future result = @delegate.submit(wrapTask((Callable)Preconditions.checkNotNull(P_0)));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Runnable;)Ljava/util/concurrent/Future<*>;")]
	[LineNumberTable(103)]
	public Future submit(Runnable P_0)
	{
		Future result = @delegate.submit(wrapTask(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<T:Ljava/lang/Object;>(Ljava/lang/Runnable;TT;)Ljava/util/concurrent/Future<TT;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
	[LineNumberTable(109)]
	public Future submit(Runnable P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object P_1)
	{
		Future result = @delegate.submit(wrapTask(P_0), P_1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
	[LineNumberTable(115)]
	public List invokeAll(Collection P_0)
	{
		List result = @delegate.invokeAll(wrapTasks(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;JLjava/util/concurrent/TimeUnit;)Ljava/util/List<Ljava/util/concurrent/Future<TT;>;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
	[LineNumberTable(122)]
	public List invokeAll(Collection P_0, long P_1, TimeUnit P_2)
	{
		List result = @delegate.invokeAll(wrapTasks(P_0), P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
	[LineNumberTable(128)]
	public object invokeAny(Collection P_0)
	{
		object result = @delegate.invokeAny(wrapTasks(P_0));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException", "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
	[Signature("<T:Ljava/lang/Object;>(Ljava/util/Collection<+Ljava/util/concurrent/Callable<TT;>;>;JLjava/util/concurrent/TimeUnit;)TT;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 51, 0, 0 })]
	[LineNumberTable(135)]
	public object invokeAny(Collection P_0, long P_1, TimeUnit P_2)
	{
		object result = @delegate.invokeAny(wrapTasks(P_0), P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 92, 109 })]
	public void shutdown()
	{
		@delegate.shutdown();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/List<Ljava/lang/Runnable;>;")]
	[LineNumberTable(147)]
	public List shutdownNow()
	{
		List result = @delegate.shutdownNow();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(152)]
	public bool isShutdown()
	{
		bool result = @delegate.isShutdown();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(157)]
	public bool isTerminated()
	{
		bool result = @delegate.isTerminated();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(162)]
	public bool awaitTermination(long P_0, TimeUnit P_1)
	{
		bool result = @delegate.awaitTermination(P_0, P_1);
		_ = null;
		return result;
	}
}
