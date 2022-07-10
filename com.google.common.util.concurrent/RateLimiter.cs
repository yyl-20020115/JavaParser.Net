using System.Runtime.CompilerServices;
using System.Threading;
using com.google.common.@base;
using IKVM.Attributes;
using java.lang;
using java.time;
using java.util;
using java.util.concurrent;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public abstract class RateLimiter : Object
{
	internal abstract class SleepingStopwatch : Object
	{
		[SpecialName]
		[InnerClass(null, (Modifiers)0)]
		[EnclosingMethod(null, "createFromSystemTimer", "()Lcom.google.common.util.concurrent.RateLimiter$SleepingStopwatch;")]
		internal class _1 : SleepingStopwatch
		{
			[Modifiers(Modifiers.Final)]
			internal Stopwatch stopwatch;

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 105, 104 })]
			internal _1()
			{
				stopwatch = Stopwatch.createStarted();
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(480)]
			protected internal override long readMicros()
			{
				long result = stopwatch.elapsed(TimeUnit.MICROSECONDS);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 161, 115, 101, 141 })]
			protected internal override void sleepMicrosUninterruptibly(long P_0)
			{
				if (P_0 > 0)
				{
					Uninterruptibles.sleepUninterruptibly(P_0, TimeUnit.MICROSECONDS);
				}
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(463)]
		protected internal SleepingStopwatch()
		{
		}

		protected internal abstract long readMicros();

		protected internal abstract void sleepMicrosUninterruptibly(long P_0);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(475)]
		public static SleepingStopwatch createFromSystemTimer()
		{
			_1 result = new _1();
			_ = null;
			return result;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private SleepingStopwatch stopwatch;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private volatile object mutexDoNotUseDirectly;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 85, 108, 104 })]
	internal static RateLimiter create(double P_0, SleepingStopwatch P_1)
	{
		SmoothRateLimiter.SmoothBursty smoothBursty = new SmoothRateLimiter.SmoothBursty(P_1, 1.0);
		smoothBursty.setRate(P_0);
		return smoothBursty;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 142, 107, 48, 133, 109, 115, 111 })]
	public void setRate(double permitsPerSecond)
	{
		Preconditions.checkArgument((permitsPerSecond > 0.0 && !Double.isNaN(permitsPerSecond)) ? true : false, (object)"rate must be positive");
		lock (mutex())
		{
			doSetRate(permitsPerSecond, stopwatch.readMicros());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 80, 115, 109, 37 })]
	public static RateLimiter create(double permitsPerSecond, long warmupPeriod, TimeUnit unit)
	{
		Preconditions.checkArgument(warmupPeriod >= 0, "warmupPeriod must not be negative: %s", warmupPeriod);
		RateLimiter result = create(permitsPerSecond, warmupPeriod, unit, 3.0, SleepingStopwatch.createFromSystemTimer());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 92, 108, 104 })]
	internal static RateLimiter create(double P_0, long P_1, TimeUnit P_2, double P_3, SleepingStopwatch P_4)
	{
		SmoothRateLimiter.SmoothWarmingUp smoothWarmingUp = new SmoothRateLimiter.SmoothWarmingUp(P_4, P_1, P_2, P_3);
		smoothWarmingUp.setRate(P_0);
		return smoothWarmingUp;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 107, 105, 99, 104, 105, 99, 148, 143 })]
	private object mutex()
	{
		object obj = mutexDoNotUseDirectly;
		if (obj == null)
		{
			lock (this)
			{
				obj = mutexDoNotUseDirectly;
				if (obj != null)
				{
					return obj;
				}
				obj = (mutexDoNotUseDirectly = new Object());
				System.Threading.Thread.MemoryBarrier();
				return obj;
			}
		}
		return obj;
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual void doSetRate(double P_0, long P_1)
	{
		throw new AbstractMethodError("com.google.common.util.concurrent.RateLimiter.doSetRate(DJ)V");
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual double doGetRate()
	{
		throw new AbstractMethodError("com.google.common.util.concurrent.RateLimiter.doGetRate()D");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 190, 104, 108 })]
	public virtual double acquire(int permits)
	{
		long num = reserve(permits);
		stopwatch.sleepMicrosUninterruptibly(num);
		return 1.0 * (double)num / (double)TimeUnit.SECONDS.toMicros(1L);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 202, 102, 109, 120 })]
	internal long reserve(int P_0)
	{
		//Discarded unreachable code: IL_0027
		checkPermits(P_0);
		lock (mutex())
		{
			return reserveAndGetWaitLength(P_0, stopwatch.readMicros());
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 124, 113 })]
	private static void checkPermits(int P_0)
	{
		Preconditions.checkArgument(P_0 > 0, "Requested permits (%s) must be positive", P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 65, 105 })]
	internal long reserveAndGetWaitLength(int P_0, long P_1)
	{
		long num = reserveEarliestAvailable(P_0, P_1);
		long result = Math.max(num - P_1, 0L);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 40, 111, 134, 109, 108, 106, 138, 138, 119,
		109
	})]
	public virtual bool tryAcquire(int permits, long timeout, TimeUnit unit)
	{
		long num = Math.max(unit.toMicros(timeout), 0L);
		checkPermits(permits);
		object obj;
		System.Threading.Monitor.Enter(obj = mutex());
		long num3;
		try
		{
			long num2 = stopwatch.readMicros();
			if (!canAcquire(num2, num))
			{
				System.Threading.Monitor.Exit(obj);
				return false;
			}
			num3 = reserveAndGetWaitLength(permits, num2);
			System.Threading.Monitor.Exit(obj);
		}
		catch
		{
			//try-fault
			System.Threading.Monitor.Exit(obj);
			throw;
		}
		stopwatch.sleepMicrosUninterruptibly(num3);
		return true;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(426)]
	private bool canAcquire(long P_0, long P_1)
	{
		return queryEarliestAvailable(P_0) - P_1 <= P_0;
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual long queryEarliestAvailable(long P_0)
	{
		throw new AbstractMethodError("com.google.common.util.concurrent.RateLimiter.queryEarliestAvailable(J)J");
	}

	[Modifiers(Modifiers.Abstract)]
	internal virtual long reserveEarliestAvailable(int P_0, long P_1)
	{
		throw new AbstractMethodError("com.google.common.util.concurrent.RateLimiter.reserveEarliestAvailable(IJ)J");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 158, 109, 108 })]
	public double getRate()
	{
		//Discarded unreachable code: IL_0015
		lock (mutex())
		{
			return doGetRate();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(130)]
	public static RateLimiter create(double permitsPerSecond)
	{
		RateLimiter result = create(permitsPerSecond, SleepingStopwatch.createFromSystemTimer());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(165)]
	public static RateLimiter create(double permitsPerSecond, Duration warmupPeriod)
	{
		RateLimiter result = create(permitsPerSecond, Internal.toNanosSaturated(warmupPeriod), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 119, 104, 113 })]
	internal RateLimiter(SleepingStopwatch P_0)
	{
		stopwatch = (SleepingStopwatch)Preconditions.checkNotNull(P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(290)]
	public virtual double acquire()
	{
		double result = acquire(1);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(335)]
	public virtual bool tryAcquire(Duration timeout)
	{
		bool result = tryAcquire(1, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(352)]
	public virtual bool tryAcquire(long timeout, TimeUnit unit)
	{
		bool result = tryAcquire(1, timeout, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(366)]
	public virtual bool tryAcquire(int permits)
	{
		bool result = tryAcquire(permits, 0L, TimeUnit.MICROSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(379)]
	public virtual bool tryAcquire()
	{
		bool result = tryAcquire(1, 0L, TimeUnit.MICROSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(394)]
	public virtual bool tryAcquire(int permits, Duration timeout)
	{
		bool result = tryAcquire(permits, Internal.toNanosSaturated(timeout), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(458)]
	public override string toString()
	{
		string result = String.format(Locale.ROOT, "RateLimiter[stableRate=%3.1fqps]", Double.valueOf(getRate()));
		_ = null;
		return result;
	}
}
