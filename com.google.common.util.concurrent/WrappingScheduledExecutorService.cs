using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)38,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.ScheduledExecutorService" })]
internal abstract class WrappingScheduledExecutorService : WrappingExecutorService, ScheduledExecutorService, ExecutorService, Executor
{
	[Modifiers(Modifiers.Final)]
	internal ScheduledExecutorService @delegate;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 183, 105, 103 })]
	protected internal WrappingScheduledExecutorService(ScheduledExecutorService P_0)
		: base(P_0)
	{
		@delegate = P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture<*>;")]
	[LineNumberTable(47)]
	public ScheduledFuture schedule(Runnable P_0, long P_1, TimeUnit P_2)
	{
		ScheduledFuture result = @delegate.schedule(wrapTask(P_0), P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TV;>;JLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 38, 0, 0 })]
	[LineNumberTable(53)]
	public ScheduledFuture schedule(Callable P_0, long P_1, TimeUnit P_2)
	{
		ScheduledFuture result = @delegate.schedule(wrapTask(P_0), P_1, P_2);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture<*>;")]
	[LineNumberTable(59)]
	public ScheduledFuture scheduleAtFixedRate(Runnable P_0, long P_1, long P_2, TimeUnit P_3)
	{
		ScheduledFuture result = @delegate.scheduleAtFixedRate(wrapTask(P_0), P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Ljava/util/concurrent/ScheduledFuture<*>;")]
	[LineNumberTable(65)]
	public ScheduledFuture scheduleWithFixedDelay(Runnable P_0, long P_1, long P_2, TimeUnit P_3)
	{
		ScheduledFuture result = @delegate.scheduleWithFixedDelay(wrapTask(P_0), P_1, P_2, P_3);
		_ = null;
		return result;
	}
}
