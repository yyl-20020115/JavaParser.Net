using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.time;
using java.util;
using java.util.concurrent;

namespace com.google.common.collect;

[ConstantPool(new object[]
{
	(byte)153,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/collect/ElementTypesAreNonnullByDefault;"
})]
public sealed class Queues : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/concurrent/BlockingQueue<TE;>;Ljava/util/Collection<-TE;>;IJLjava/util/concurrent/TimeUnit;)I")]
	[LineNumberTable(new byte[]
	{
		160, 192, 231, 70, 111, 98, 164, 109, 100, 115,
		99, 130, 104, 100, 130
	})]
	public static int drain(BlockingQueue q, Collection buffer, int numElements, long timeout, TimeUnit unit)
	{
		Preconditions.checkNotNull(buffer);
		long num = java.lang.System.nanoTime() + unit.toNanos(timeout);
		int num2 = 0;
		while (num2 < numElements)
		{
			num2 += q.drainTo(buffer, numElements - num2);
			if (num2 < numElements)
			{
				object obj = q.poll(num - java.lang.System.nanoTime(), TimeUnit.NANOSECONDS);
				if (obj == null)
				{
					break;
				}
				buffer.add(obj);
				num2++;
			}
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/concurrent/BlockingQueue<TE;>;Ljava/util/Collection<-TE;>;IJLjava/util/concurrent/TimeUnit;)I")]
	[LineNumberTable(new byte[]
	{
		161, 8, 103, 111, 98, 130, 164, 109, 234, 82,
		99, 138, 232, 47, 123, 228, 77, 99, 138, 234,
		49, 97, 98, 228, 74, 99, 138, 230, 53, 99,
		130, 104, 100, 166, 99, 138, 232, 61, 99, 172
	})]
	public static int drainUninterruptibly(BlockingQueue q, Collection buffer, int numElements, long timeout, TimeUnit unit)
	{
		Preconditions.checkNotNull(buffer);
		long num = java.lang.System.nanoTime() + unit.toNanos(timeout);
		int num2 = 0;
		int num3 = 0;
		while (true)
		{
			try
			{
				while (num2 < numElements)
				{
					num2 += q.drainTo(buffer, numElements - num2);
					if (num2 >= numElements)
					{
						continue;
					}
					goto IL_004a;
				}
			}
			catch
			{
				//try-fault
				if (num3 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_004a:
			object obj;
			while (true)
			{
				try
				{
					try
					{
						obj = q.poll(num - java.lang.System.nanoTime(), TimeUnit.NANOSECONDS);
					}
					catch (InterruptedException)
					{
						goto IL_0077;
					}
				}
				catch
				{
					//try-fault
					if (num3 != 0)
					{
						Thread.currentThread().interrupt();
					}
					throw;
				}
				break;
				IL_0077:
				InterruptedException ex2 = null;
				try
				{
					num3 = 1;
				}
				catch
				{
					//try-fault
					if (num3 != 0)
					{
						Thread.currentThread().interrupt();
					}
					throw;
				}
			}
			try
			{
				if (obj == null)
				{
					break;
				}
				buffer.add(obj);
				num2++;
				continue;
			}
			catch
			{
				//try-fault
				if (num3 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num3 != 0)
		{
			Thread.currentThread().interrupt();
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(47)]
	private Queues()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Ljava/util/concurrent/ArrayBlockingQueue<TE;>;")]
	[LineNumberTable(57)]
	public static ArrayBlockingQueue newArrayBlockingQueue(int capacity)
	{
		ArrayBlockingQueue result = new ArrayBlockingQueue(capacity);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/ArrayDeque<TE;>;")]
	[LineNumberTable(68)]
	public static ArrayDeque newArrayDeque()
	{
		ArrayDeque result = new ArrayDeque();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/ArrayDeque<TE;>;")]
	[LineNumberTable(new byte[] { 28, 104, 142, 102, 104 })]
	public static ArrayDeque newArrayDeque(Iterable elements)
	{
		if (elements is Collection)
		{
			ArrayDeque result = new ArrayDeque((Collection)elements);
			_ = null;
			return result;
		}
		ArrayDeque arrayDeque = new ArrayDeque();
		Iterables.addAll(arrayDeque, elements);
		return arrayDeque;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/concurrent/ConcurrentLinkedQueue<TE;>;")]
	[LineNumberTable(91)]
	public static ConcurrentLinkedQueue newConcurrentLinkedQueue()
	{
		ConcurrentLinkedQueue result = new ConcurrentLinkedQueue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/concurrent/ConcurrentLinkedQueue<TE;>;")]
	[LineNumberTable(new byte[] { 51, 104, 147, 102, 104 })]
	public static ConcurrentLinkedQueue newConcurrentLinkedQueue(Iterable elements)
	{
		if (elements is Collection)
		{
			ConcurrentLinkedQueue.___003Cclinit_003E();
			ConcurrentLinkedQueue result = new ConcurrentLinkedQueue((Collection)elements);
			_ = null;
			return result;
		}
		ConcurrentLinkedQueue concurrentLinkedQueue = new ConcurrentLinkedQueue();
		Iterables.addAll(concurrentLinkedQueue, elements);
		return concurrentLinkedQueue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/concurrent/LinkedBlockingDeque<TE;>;")]
	[LineNumberTable(118)]
	public static LinkedBlockingDeque newLinkedBlockingDeque()
	{
		LinkedBlockingDeque result = new LinkedBlockingDeque();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Ljava/util/concurrent/LinkedBlockingDeque<TE;>;")]
	[LineNumberTable(129)]
	public static LinkedBlockingDeque newLinkedBlockingDeque(int capacity)
	{
		LinkedBlockingDeque result = new LinkedBlockingDeque(capacity);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/concurrent/LinkedBlockingDeque<TE;>;")]
	[LineNumberTable(new byte[] { 91, 104, 142, 102, 104 })]
	public static LinkedBlockingDeque newLinkedBlockingDeque(Iterable elements)
	{
		if (elements is Collection)
		{
			LinkedBlockingDeque result = new LinkedBlockingDeque((Collection)elements);
			_ = null;
			return result;
		}
		LinkedBlockingDeque linkedBlockingDeque = new LinkedBlockingDeque();
		Iterables.addAll(linkedBlockingDeque, elements);
		return linkedBlockingDeque;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/concurrent/LinkedBlockingQueue<TE;>;")]
	[LineNumberTable(154)]
	public static LinkedBlockingQueue newLinkedBlockingQueue()
	{
		LinkedBlockingQueue result = new LinkedBlockingQueue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(I)Ljava/util/concurrent/LinkedBlockingQueue<TE;>;")]
	[LineNumberTable(164)]
	public static LinkedBlockingQueue newLinkedBlockingQueue(int capacity)
	{
		LinkedBlockingQueue result = new LinkedBlockingQueue(capacity);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/concurrent/LinkedBlockingQueue<TE;>;")]
	[LineNumberTable(new byte[] { 127, 104, 142, 102, 104 })]
	public static LinkedBlockingQueue newLinkedBlockingQueue(Iterable elements)
	{
		if (elements is Collection)
		{
			LinkedBlockingQueue result = new LinkedBlockingQueue((Collection)elements);
			_ = null;
			return result;
		}
		LinkedBlockingQueue linkedBlockingQueue = new LinkedBlockingQueue();
		Iterables.addAll(linkedBlockingQueue, elements);
		return linkedBlockingQueue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable;>()Ljava/util/concurrent/PriorityBlockingQueue<TE;>;")]
	[LineNumberTable(198)]
	public static PriorityBlockingQueue newPriorityBlockingQueue()
	{
		PriorityBlockingQueue result = new PriorityBlockingQueue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/concurrent/PriorityBlockingQueue<TE;>;")]
	[LineNumberTable(new byte[] { 160, 99, 104, 147, 102, 104 })]
	public static PriorityBlockingQueue newPriorityBlockingQueue(Iterable elements)
	{
		if (elements is Collection)
		{
			PriorityBlockingQueue.___003Cclinit_003E();
			PriorityBlockingQueue result = new PriorityBlockingQueue((Collection)elements);
			_ = null;
			return result;
		}
		PriorityBlockingQueue priorityBlockingQueue = new PriorityBlockingQueue();
		Iterables.addAll(priorityBlockingQueue, elements);
		return priorityBlockingQueue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable;>()Ljava/util/PriorityQueue<TE;>;")]
	[LineNumberTable(231)]
	public static PriorityQueue newPriorityQueue()
	{
		PriorityQueue result = new PriorityQueue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E::Ljava/lang/Comparable;>(Ljava/lang/Iterable<+TE;>;)Ljava/util/PriorityQueue<TE;>;")]
	[LineNumberTable(new byte[] { 160, 131, 104, 142, 102, 104 })]
	public static PriorityQueue newPriorityQueue(Iterable elements)
	{
		if (elements is Collection)
		{
			PriorityQueue result = new PriorityQueue((Collection)elements);
			_ = null;
			return result;
		}
		PriorityQueue priorityQueue = new PriorityQueue();
		Iterables.addAll(priorityQueue, elements);
		return priorityQueue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>()Ljava/util/concurrent/SynchronousQueue<TE;>;")]
	[LineNumberTable(258)]
	public static SynchronousQueue newSynchronousQueue()
	{
		SynchronousQueue result = new SynchronousQueue();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/concurrent/BlockingQueue<TE;>;Ljava/util/Collection<-TE;>;ILjava/time/Duration;)I")]
	[LineNumberTable(280)]
	public static int drain(BlockingQueue q, Collection buffer, int numElements, Duration timeout)
	{
		int result = drain(q, buffer, numElements, timeout.toNanos(), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/concurrent/BlockingQueue<TE;>;Ljava/util/Collection<-TE;>;ILjava/time/Duration;)I")]
	[LineNumberTable(352)]
	public static int drainUninterruptibly(BlockingQueue q, Collection buffer, int numElements, Duration timeout)
	{
		int result = drainUninterruptibly(q, buffer, numElements, timeout.toNanos(), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Queue<TE;>;)Ljava/util/Queue<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 153, 0, 0 })]
	[LineNumberTable(442)]
	public static Queue synchronizedQueue(Queue queue)
	{
		Queue result = Synchronized.queue(queue, null);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("<E:Ljava/lang/Object;>(Ljava/util/Deque<TE;>;)Ljava/util/Deque<TE;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 153, 0, 0 })]
	[LineNumberTable(475)]
	public static Deque synchronizedDeque(Deque deque)
	{
		Deque result = Synchronized.deque(deque, null);
		_ = null;
		return result;
	}
}
