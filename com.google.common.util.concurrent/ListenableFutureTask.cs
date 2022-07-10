using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[Signature("<V:Ljava/lang/Object;>Ljava/util/concurrent/FutureTask<TV;>;Lcom/google/common/util/concurrent/ListenableFuture<TV;>;")]
[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 17, 0, 0, 0, 0, 34, 0, 0 })]
[ConstantPool(new object[]
{
	(byte)34,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "com.google.common.util.concurrent.ListenableFuture" })]
public class ListenableFutureTask : FutureTask, ListenableFuture, Future
{
	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private ExecutionList executionList;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public new static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TV;>;)Lcom/google/common/util/concurrent/ListenableFutureTask<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 34, 0, 0 })]
	[LineNumberTable(62)]
	public static ListenableFutureTask create(Callable callable)
	{
		ListenableFutureTask result = new ListenableFutureTask(callable);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/concurrent/Callable<TV;>;)V")]
	[LineNumberTable(new byte[] { 31, 233, 35, 235, 94 })]
	internal ListenableFutureTask(Callable P_0)
		: base(P_0)
	{
		executionList = new ExecutionList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Runnable;TV;)V")]
	[LineNumberTable(new byte[] { 35, 234, 31, 235, 98 })]
	internal ListenableFutureTask(Runnable P_0, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object P_1)
		: base(P_0, P_1)
	{
		executionList = new ExecutionList();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/lang/Runnable;TV;)Lcom/google/common/util/concurrent/ListenableFutureTask<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 34, 0, 0 })]
	[LineNumberTable(77)]
	public static ListenableFutureTask create(Runnable runnable, [ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})] object result)
	{
		ListenableFutureTask result2 = new ListenableFutureTask(runnable, result);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 40, 111 })]
	public virtual void addListener(Runnable listener, Executor exec)
	{
		executionList.add(listener, exec);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.TimeoutException", "java.lang.InterruptedException", "java.util.concurrent.ExecutionException" })]
	[Signature("(JLjava/util/concurrent/TimeUnit;)TV;")]
	[LineNumberTable(new byte[] { 49, 104, 108, 171, 107, 42 })]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public override object get(long timeout, TimeUnit unit)
	{
		long num = unit.toNanos(timeout);
		if (num <= 2147483647999999999L)
		{
			object result = base.get(timeout, unit);
			_ = null;
			return result;
		}
		object result2 = base.get(Math.min(num, 2147483647999999999L), TimeUnit.NANOSECONDS);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 61, 109 })]
	protected internal override void done()
	{
		executionList.execute();
	}

	[HideFromJava]
	static ListenableFutureTask()
	{
		FutureTask.___003Cclinit_003E();
	}

	object Future.Future_003A_003Aget()
	{
		return get();
	}

	bool Future.Future_003A_003Acancel(bool P_0)
	{
		return cancel(P_0);
	}

	bool Future.Future_003A_003AisCancelled()
	{
		return isCancelled();
	}

	bool Future.Future_003A_003AisDone()
	{
		return isDone();
	}
}
