using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.time;
using java.util.concurrent;
using java.util.concurrent.locks;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)91,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class Uninterruptibles : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException" })]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Future<TV;>;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 91, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		160, 122, 194, 237, 70, 99, 138, 230, 61, 99,
		234, 57, 100, 97, 98, 164, 99, 138
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public static object getUninterruptibly(Future future)
	{
		int num = 0;
		object result;
		while (true)
		{
			try
			{
				try
				{
					result = future.get();
				}
				catch (InterruptedException)
				{
					goto IL_001f;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_001f:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 16, 130, 104, 236, 76, 99, 138, 227, 53,
		241, 72, 99, 138, 230, 61, 99, 234, 56, 99,
		97, 98, 104, 164, 99, 138
	})]
	public static void sleepUninterruptibly(long sleepFor, TimeUnit unit)
	{
		int num = 0;
		long num2;
		long num3;
		try
		{
			num2 = unit.toNanos(sleepFor);
			num3 = java.lang.System.nanoTime() + num2;
		}
		catch
		{
			//try-fault
			if (num != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
		while (true)
		{
			try
			{
				try
				{
					TimeUnit.NANOSECONDS.sleep(num2);
				}
				catch (InterruptedException)
				{
					goto IL_0047;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_0047:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
				num2 = num3 - java.lang.System.nanoTime();
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Future<TV;>;JLjava/util/concurrent/TimeUnit;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 91, 0, 0 })]
	[LineNumberTable(new byte[]
	{
		160, 189, 130, 104, 236, 76, 99, 138, 227, 54,
		243, 71, 99, 138, 230, 61, 99, 234, 56, 102,
		97, 98, 104, 164, 99, 138
	})]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public static object getUninterruptibly(Future future, long timeout, TimeUnit unit)
	{
		int num = 0;
		long num2;
		long num3;
		try
		{
			num2 = unit.toNanos(timeout);
			num3 = java.lang.System.nanoTime() + num2;
		}
		catch
		{
			//try-fault
			if (num != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
		object result;
		while (true)
		{
			try
			{
				try
				{
					result = future.get(num2, TimeUnit.NANOSECONDS);
				}
				catch (InterruptedException)
				{
					goto IL_0049;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_0049:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
				num2 = num3 - java.lang.System.nanoTime();
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		44, 130, 104, 236, 76, 99, 138, 227, 54, 243,
		71, 99, 138, 230, 61, 99, 234, 56, 102, 97,
		98, 104, 164, 99, 138
	})]
	public static bool awaitUninterruptibly(CountDownLatch latch, long timeout, TimeUnit unit)
	{
		int num = 0;
		long num2;
		long num3;
		try
		{
			num2 = unit.toNanos(timeout);
			num3 = java.lang.System.nanoTime() + num2;
		}
		catch
		{
			//try-fault
			if (num != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
		int result;
		while (true)
		{
			try
			{
				try
				{
					result = (latch.await(num2, TimeUnit.NANOSECONDS) ? 1 : 0);
				}
				catch (InterruptedException)
				{
					goto IL_0049;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_0049:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
				num2 = num3 - java.lang.System.nanoTime();
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		85, 130, 104, 236, 75, 99, 138, 227, 54, 243,
		71, 99, 138, 230, 61, 99, 234, 56, 102, 97,
		98, 104, 164, 99, 138
	})]
	public static bool awaitUninterruptibly(Condition condition, long timeout, TimeUnit unit)
	{
		int num = 0;
		long num2;
		long num3;
		try
		{
			num2 = unit.toNanos(timeout);
			num3 = java.lang.System.nanoTime() + num2;
		}
		catch
		{
			//try-fault
			if (num != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
		int result;
		while (true)
		{
			try
			{
				try
				{
					result = (condition.await(num2, TimeUnit.NANOSECONDS) ? 1 : 0);
				}
				catch (InterruptedException)
				{
					goto IL_0049;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_0049:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
				num2 = num3 - java.lang.System.nanoTime();
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 79, 103, 130, 104, 236, 76, 99, 138, 227,
		53, 242, 72, 99, 138, 230, 61, 99, 234, 56,
		99, 97, 98, 104, 164, 99, 138
	})]
	public static void joinUninterruptibly(Thread toJoin, long timeout, TimeUnit unit)
	{
		Preconditions.checkNotNull(toJoin);
		int num = 0;
		long num2;
		long num3;
		try
		{
			num2 = unit.toNanos(timeout);
			num3 = java.lang.System.nanoTime() + num2;
		}
		catch
		{
			//try-fault
			if (num != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
		while (true)
		{
			try
			{
				try
				{
					TimeUnit.NANOSECONDS.timedJoin(toJoin, num2);
				}
				catch (InterruptedException)
				{
					goto IL_004f;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_004f:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
				num2 = num3 - java.lang.System.nanoTime();
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(428)]
	public static bool tryAcquireUninterruptibly(Semaphore semaphore, long timeout, TimeUnit unit)
	{
		bool result = tryAcquireUninterruptibly(semaphore, 1, timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 84, 130, 104, 236, 76, 99, 138, 227, 54,
		244, 71, 99, 138, 230, 61, 99, 234, 56, 102,
		97, 98, 104, 164, 99, 138
	})]
	public static bool tryAcquireUninterruptibly(Semaphore semaphore, int permits, long timeout, TimeUnit unit)
	{
		int num = 0;
		long num2;
		long num3;
		try
		{
			num2 = unit.toNanos(timeout);
			num3 = java.lang.System.nanoTime() + num2;
		}
		catch
		{
			//try-fault
			if (num != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
		int result;
		while (true)
		{
			try
			{
				try
				{
					result = (semaphore.tryAcquire(permits, num2, TimeUnit.NANOSECONDS) ? 1 : 0);
				}
				catch (InterruptedException)
				{
					goto IL_004a;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_004a:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
				num2 = num3 - java.lang.System.nanoTime();
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 125, 130, 104, 236, 75, 99, 138, 227, 54,
		243, 71, 99, 138, 230, 61, 99, 234, 56, 102,
		97, 98, 104, 164, 99, 138
	})]
	public static bool tryLockUninterruptibly(Lock @lock, long timeout, TimeUnit unit)
	{
		int num = 0;
		long num2;
		long num3;
		try
		{
			num2 = unit.toNanos(timeout);
			num3 = java.lang.System.nanoTime() + num2;
		}
		catch
		{
			//try-fault
			if (num != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
		int result;
		while (true)
		{
			try
			{
				try
				{
					result = (@lock.tryLock(num2, TimeUnit.NANOSECONDS) ? 1 : 0);
				}
				catch (InterruptedException)
				{
					goto IL_0049;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_0049:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
				num2 = num3 - java.lang.System.nanoTime();
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 179, 130, 104, 236, 75, 99, 138, 227, 54,
		243, 71, 99, 138, 230, 61, 99, 234, 56, 102,
		97, 98, 104, 164, 99, 138
	})]
	public static bool awaitTerminationUninterruptibly(ExecutorService executor, long timeout, TimeUnit unit)
	{
		int num = 0;
		long num2;
		long num3;
		try
		{
			num2 = unit.toNanos(timeout);
			num3 = java.lang.System.nanoTime() + num2;
		}
		catch
		{
			//try-fault
			if (num != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
		int result;
		while (true)
		{
			try
			{
				try
				{
					result = (executor.awaitTermination(num2, TimeUnit.NANOSECONDS) ? 1 : 0);
				}
				catch (InterruptedException)
				{
					goto IL_0049;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_0049:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
				num2 = num3 - java.lang.System.nanoTime();
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		7, 194, 236, 71, 99, 138, 230, 61, 99, 234,
		57, 99, 97, 98, 164, 99, 138
	})]
	public static void awaitUninterruptibly(CountDownLatch latch)
	{
		int num = 0;
		while (true)
		{
			try
			{
				try
				{
					latch.await();
				}
				catch (InterruptedException)
				{
					goto IL_001e;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_001e:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(83)]
	public static bool awaitUninterruptibly(CountDownLatch latch, Duration timeout)
	{
		bool result = awaitUninterruptibly(latch, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(123)]
	public static bool awaitUninterruptibly(Condition condition, Duration timeout)
	{
		bool result = awaitUninterruptibly(condition, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		108, 194, 236, 71, 99, 138, 230, 61, 99, 234,
		57, 99, 97, 98, 164, 99, 138
	})]
	public static void joinUninterruptibly(Thread toJoin)
	{
		int num = 0;
		while (true)
		{
			try
			{
				try
				{
					toJoin.join();
				}
				catch (InterruptedException)
				{
					goto IL_001e;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_001e:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 69, 115 })]
	public static void joinUninterruptibly(Thread toJoin, Duration timeout)
	{
		joinUninterruptibly(toJoin, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.util.concurrent.ExecutionException", "java.util.concurrent.TimeoutException" })]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Future<TV;>;Ljava/time/Duration;)TV;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 91, 0, 0 })]
	[LineNumberTable(276)]
	[ParametricNullness(new object[]
	{
		(byte)64,
		"Lcom/google/common/util/concurrent/ParametricNullness;"
	})]
	public static object getUninterruptibly(Future future, Duration timeout)
	{
		object uninterruptibly = getUninterruptibly(future, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return uninterruptibly;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/concurrent/BlockingQueue<TE;>;)TE;")]
	[LineNumberTable(new byte[]
	{
		160, 213, 194, 237, 70, 99, 138, 230, 61, 99,
		234, 57, 100, 97, 98, 164, 99, 138
	})]
	public static object takeUninterruptibly(BlockingQueue queue)
	{
		int num = 0;
		object result;
		while (true)
		{
			try
			{
				try
				{
					result = queue.take();
				}
				catch (InterruptedException)
				{
					goto IL_001f;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_001f:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/concurrent/BlockingQueue<TE;>;TE;)V")]
	[LineNumberTable(new byte[]
	{
		160, 239, 194, 237, 71, 99, 138, 230, 61, 99,
		234, 57, 99, 97, 98, 164, 99, 138
	})]
	public static void putUninterruptibly(BlockingQueue queue, object element)
	{
		int num = 0;
		while (true)
		{
			try
			{
				try
				{
					queue.put(element);
				}
				catch (InterruptedException)
				{
					goto IL_001f;
				}
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_001f:
			InterruptedException ex2 = null;
			try
			{
				num = 1;
			}
			catch
			{
				//try-fault
				if (num != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num != 0)
		{
			Thread.currentThread().interrupt();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 8, 114 })]
	public static void sleepUninterruptibly(Duration sleepFor)
	{
		sleepUninterruptibly(Internal.toNanosSaturated(sleepFor), TimeUnit.NANOSECONDS);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(415)]
	public static bool tryAcquireUninterruptibly(Semaphore semaphore, Duration timeout)
	{
		bool result = tryAcquireUninterruptibly(semaphore, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 70, 99, 42 })]
	public static bool tryAcquireUninterruptibly(Semaphore semaphore, int permits, Duration timeout)
	{
		bool result = tryAcquireUninterruptibly(semaphore, permits, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(483)]
	public static bool tryLockUninterruptibly(Lock @lock, Duration timeout)
	{
		bool result = tryLockUninterruptibly(@lock, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 154, 123 })]
	public static void awaitTerminationUninterruptibly(ExecutorService executor)
	{
		Verify.verify(awaitTerminationUninterruptibly(executor, long.MaxValue, TimeUnit.NANOSECONDS));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(536)]
	public static bool awaitTerminationUninterruptibly(ExecutorService executor, Duration timeout)
	{
		bool result = awaitTerminationUninterruptibly(executor, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(571)]
	private Uninterruptibles()
	{
	}
}
