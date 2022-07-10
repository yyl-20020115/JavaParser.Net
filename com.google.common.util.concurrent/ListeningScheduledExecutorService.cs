using System.ComponentModel;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.time;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ConstantPool(new object[]
{
	(byte)29,
	"Lorg/checkerframework/checker/nullness/qual/Nullable;"
})]
[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
[Implements(new string[] { "java.util.concurrent.ScheduledExecutorService", "com.google.common.util.concurrent.ListeningExecutorService" })]
public interface ListeningScheduledExecutorService : ScheduledExecutorService, ExecutorService, Executor, ListeningExecutorService
{
	[HideFromJava]
	public new static class __DefaultMethods
	{
		public unsafe static ListenableScheduledFuture schedule(ListeningScheduledExecutorService P_0, Runnable P_1, Duration P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eschedule(P_0, P_1, P_2);
		}

		public unsafe static ListenableScheduledFuture schedule(ListeningScheduledExecutorService P_0, Callable P_1, Duration P_2)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003Eschedule(P_0, P_1, P_2);
		}

		public unsafe static ListenableScheduledFuture scheduleAtFixedRate(ListeningScheduledExecutorService P_0, Runnable P_1, Duration P_2, Duration P_3)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EscheduleAtFixedRate(P_0, P_1, P_2, P_3);
		}

		public unsafe static ListenableScheduledFuture scheduleWithFixedDelay(ListeningScheduledExecutorService P_0, Runnable P_1, Duration P_2, Duration P_3)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003EscheduleWithFixedDelay(P_0, P_1, P_2, P_3);
		}

		public unsafe static ScheduledFuture scheduleWithFixedDelay(ListeningScheduledExecutorService P_0, Runnable P_1, long P_2, long P_3, TimeUnit P_4)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EscheduleWithFixedDelay(P_0, P_1, P_2, P_3, P_4);
		}

		public unsafe static ScheduledFuture scheduleAtFixedRate(ListeningScheduledExecutorService P_0, Runnable P_1, long P_2, long P_3, TimeUnit P_4)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003EscheduleAtFixedRate(P_0, P_1, P_2, P_3, P_4);
		}

		public unsafe static ScheduledFuture schedule(ListeningScheduledExecutorService P_0, Callable P_1, long P_2, TimeUnit P_3)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Eschedule(P_0, P_1, P_2, P_3);
		}

		public unsafe static ScheduledFuture schedule(ListeningScheduledExecutorService P_0, Runnable P_1, long P_2, TimeUnit P_3)
		{
			__ldvirtftn(object.ToString);
			return _003Cdefault_003E_003Cbridge_003Eschedule(P_0, P_1, P_2, P_3);
		}
	}

	[Signature("(Ljava/lang/Runnable;JLjava/util/concurrent/TimeUnit;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<*>;")]
	ListenableScheduledFuture schedule(Runnable r, long l, TimeUnit tu);

	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TV;>;JLjava/util/concurrent/TimeUnit;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 29, 0, 0 })]
	ListenableScheduledFuture schedule(Callable c, long l, TimeUnit tu);

	[Signature("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<*>;")]
	ListenableScheduledFuture scheduleAtFixedRate(Runnable r, long l1, long l2, TimeUnit tu);

	[Signature("(Ljava/lang/Runnable;JJLjava/util/concurrent/TimeUnit;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<*>;")]
	ListenableScheduledFuture scheduleWithFixedDelay(Runnable r, long l1, long l2, TimeUnit tu);

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/lang/Runnable;Ljava/time/Duration;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<*>;")]
	virtual ListenableScheduledFuture schedule(Runnable command, Duration delay);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(50)]
	static ListenableScheduledFuture _003Cdefault_003Eschedule(ListeningScheduledExecutorService P_0, Runnable P_1, Duration P_2)
	{
		ListenableScheduledFuture result = P_0.schedule(P_1, Internal.toNanosSaturated(P_2), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public)]
	[Signature("<V:Ljava/lang/Object;>(Ljava/util/concurrent/Callable<TV;>;Ljava/time/Duration;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<TV;>;")]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 29, 0, 0 })]
	virtual ListenableScheduledFuture schedule(Callable callable, Duration delay);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(65)]
	static ListenableScheduledFuture _003Cdefault_003Eschedule(ListeningScheduledExecutorService P_0, Callable P_1, Duration P_2)
	{
		ListenableScheduledFuture result = P_0.schedule(P_1, Internal.toNanosSaturated(P_2), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/lang/Runnable;Ljava/time/Duration;Ljava/time/Duration;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<*>;")]
	virtual ListenableScheduledFuture scheduleAtFixedRate(Runnable command, Duration initialDelay, Duration period);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 30, 99, 48 })]
	static ListenableScheduledFuture _003Cdefault_003EscheduleAtFixedRate(ListeningScheduledExecutorService P_0, Runnable P_1, Duration P_2, Duration P_3)
	{
		ListenableScheduledFuture result = P_0.scheduleAtFixedRate(P_1, Internal.toNanosSaturated(P_2), Internal.toNanosSaturated(P_3), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public)]
	[Signature("(Ljava/lang/Runnable;Ljava/time/Duration;Ljava/time/Duration;)Lcom/google/common/util/concurrent/ListenableScheduledFuture<*>;")]
	virtual ListenableScheduledFuture scheduleWithFixedDelay(Runnable command, Duration initialDelay, Duration delay);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(new byte[] { 46, 99, 48 })]
	static ListenableScheduledFuture _003Cdefault_003EscheduleWithFixedDelay(ListeningScheduledExecutorService P_0, Runnable P_1, Duration P_2, Duration P_3)
	{
		ListenableScheduledFuture result = P_0.scheduleWithFixedDelay(P_1, Internal.toNanosSaturated(P_2), Internal.toNanosSaturated(P_3), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual ScheduledFuture _003Cbridge_003EscheduleWithFixedDelay(Runnable r, long l1, long l2, TimeUnit tu);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(35)]
	static ScheduledFuture _003Cdefault_003E_003Cbridge_003EscheduleWithFixedDelay(ListeningScheduledExecutorService P_0, Runnable P_1, long P_2, long P_3, TimeUnit P_4)
	{
		ListenableScheduledFuture result = P_0.scheduleWithFixedDelay(P_1, P_2, P_3, P_4);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual ScheduledFuture _003Cbridge_003EscheduleAtFixedRate(Runnable r, long l1, long l2, TimeUnit tu);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(35)]
	static ScheduledFuture _003Cdefault_003E_003Cbridge_003EscheduleAtFixedRate(ListeningScheduledExecutorService P_0, Runnable P_1, long P_2, long P_3, TimeUnit P_4)
	{
		ListenableScheduledFuture result = P_0.scheduleAtFixedRate(P_1, P_2, P_3, P_4);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	[RuntimeVisibleTypeAnnotations(new byte[] { 0, 1, 18, 0, 0, 0, 0, 29, 0, 0 })]
	virtual ScheduledFuture _003Cbridge_003Eschedule(Callable c, long l, TimeUnit tu);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(35)]
	static ScheduledFuture _003Cdefault_003E_003Cbridge_003Eschedule(ListeningScheduledExecutorService P_0, Callable P_1, long P_2, TimeUnit P_3)
	{
		ListenableScheduledFuture result = P_0.schedule(P_1, P_2, P_3);
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
	[EditorBrowsable(EditorBrowsableState.Never)]
	virtual ScheduledFuture _003Cbridge_003Eschedule(Runnable r, long l, TimeUnit tu);

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	[LineNumberTable(35)]
	static ScheduledFuture _003Cdefault_003E_003Cbridge_003Eschedule(ListeningScheduledExecutorService P_0, Runnable P_1, long P_2, TimeUnit P_3)
	{
		ListenableScheduledFuture result = P_0.schedule(P_1, P_2, P_3);
		_ = null;
		return result;
	}
}
