using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.time;
using java.util.concurrent;
using java.util.concurrent.locks;
using java.util.function;
using javax.annotation;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
public sealed class Monitor : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, (Modifiers)0)]
	[EnclosingMethod(null, "newGuard", "(Ljava.util.function.BooleanSupplier;)Lcom.google.common.util.concurrent.Monitor$Guard;")]
	internal class _1 : Guard
	{
		[Modifiers(Modifiers.Final | Modifiers.Synthetic)]
		internal BooleanSupplier val_0024isSatisfied;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(373)]
		internal _1(Monitor P_0, Monitor P_1, BooleanSupplier P_2)
		{
			val_0024isSatisfied = P_2;
			base._002Ector(P_1);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(376)]
		public override bool isSatisfied()
		{
			bool asBoolean = val_0024isSatisfied.getAsBoolean();
			_ = null;
			return asBoolean;
		}
	}

	public abstract class Guard : java.lang.Object
	{
		[Modifiers(Modifiers.Final)]
		internal Monitor monitor;

		[Modifiers(Modifiers.Final)]
		internal Condition condition;

		internal int waiterCount;

		[CheckForNull(new object[]
		{
			(byte)64,
			"Ljavax/annotation/CheckForNull;"
		})]
		internal Guard next;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 204, 232, 56, 231, 73, 118, 113 })]
		protected internal Guard(Monitor monitor)
		{
			waiterCount = 0;
			this.monitor = (Monitor)Preconditions.checkNotNull((object)monitor, (object)"monitor");
			condition = access_0024000(monitor).newCondition();
		}

		public abstract bool isSatisfied();
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private bool fair;

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private ReentrantLock @lock;

	[CheckForNull(new object[]
	{
		(byte)64,
		"Ljavax/annotation/CheckForNull;"
	})]
	private Guard activeGuards;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 236, 105 })]
	public Monitor()
		: this(fair: false)
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 48, 105, 139, 103, 134, 130, 141, 99, 134,
		227, 61, 2
	})]
	public virtual bool enterIf(Guard guard)
	{
		if (guard.monitor != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		ReentrantLock reentrantLock = @lock;
		reentrantLock.@lock();
		int num = 0;
		try
		{
			return (byte)(num = (guard.isSatisfied() ? 1 : 0)) != 0;
		}
		finally
		{
			if (num == 0)
			{
				reentrantLock.unlock();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 46, 167, 105, 170, 102, 35, 98, 98 })]
	public virtual void leave()
	{
		ReentrantLock reentrantLock = @lock;
		try
		{
			if (reentrantLock.getHoldCount() == 1)
			{
				signalNextWaiter();
			}
		}
		finally
		{
			reentrantLock.unlock();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 199, 105, 139, 103, 103, 134, 130, 104, 136,
		134, 99, 134, 227, 61, 99, 168
	})]
	public virtual void enterWhenUninterruptibly(Guard guard)
	{
		if (guard.monitor != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		ReentrantLock reentrantLock = @lock;
		int num = (reentrantLock.isHeldByCurrentThread() ? 1 : 0);
		reentrantLock.@lock();
		int num2 = 0;
		try
		{
			if (!guard.isSatisfied())
			{
				awaitUninterruptibly(guard, (byte)num != 0);
			}
			num2 = 1;
		}
		catch
		{
			//try-fault
			if (num2 == 0)
			{
				leave();
			}
			throw;
		}
		if (num2 == 0)
		{
			leave();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 238, 104, 105, 139, 103, 99, 103, 135, 112,
		103, 233, 106, 100, 138, 232, 21, 123, 130, 233,
		101, 100, 138, 232, 61, 100, 234, 26, 135, 97,
		99, 105, 228, 96, 100, 138, 230, 33, 231, 92,
		100, 138, 227, 37, 104, 165, 101, 103, 133, 137,
		140, 246, 71, 100, 202, 100, 138, 234, 61, 100,
		234, 51, 107, 97, 99, 98, 238, 72, 100, 138,
		234, 56, 102, 134, 136, 100, 138
	})]
	public virtual bool enterWhenUninterruptibly(Guard guard, long time, TimeUnit unit)
	{
		long num = toSafeNanos(time, unit);
		if (guard.monitor != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		ReentrantLock reentrantLock = @lock;
		long num2 = 0L;
		int num3 = (reentrantLock.isHeldByCurrentThread() ? 1 : 0);
		int num4 = (Thread.interrupted() ? 1 : 0);
		long timeout;
		try
		{
			if (fair || !reentrantLock.tryLock())
			{
				num2 = initNanoTime(num);
				timeout = num;
				goto IL_006a;
			}
		}
		catch
		{
			//try-fault
			if (num4 != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
		goto IL_00e0;
		IL_006a:
		while (true)
		{
			int result;
			try
			{
				try
				{
					if (reentrantLock.tryLock(timeout, TimeUnit.NANOSECONDS))
					{
						break;
					}
				}
				catch (InterruptedException)
				{
					goto IL_009f;
				}
				result = 0;
				goto IL_00a6;
			}
			catch
			{
				//try-fault
				if (num4 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			IL_00a6:
			if (num4 != 0)
			{
				Thread.currentThread().interrupt();
			}
			return (byte)result != 0;
			IL_009f:
			InterruptedException ex2 = null;
			try
			{
				num4 = 1;
				timeout = remainingNanos(num2, num);
			}
			catch
			{
				//try-fault
				if (num4 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		goto IL_00e0;
		IL_00e0:
		int num5;
		try
		{
			num5 = 0;
		}
		catch
		{
			//try-fault
			if (num4 != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
		System.Exception ex6;
		while (true)
		{
			int result2;
			System.Exception ex4;
			try
			{
				try
				{
					try
					{
						if (guard.isSatisfied())
						{
							num5 = 1;
						}
						else
						{
							long num6;
							if (num2 == 0)
							{
								num2 = initNanoTime(num);
								num6 = num;
							}
							else
							{
								num6 = remainingNanos(num2, num);
							}
							num5 = (awaitNanos(guard, num6, (byte)num3 != 0) ? 1 : 0);
						}
						result2 = num5;
					}
					catch (InterruptedException)
					{
						goto end_IL_00f8;
					}
				}
				catch (System.Exception x)
				{
					ex4 = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
					goto IL_0161;
				}
				if (num5 == 0)
				{
					reentrantLock.unlock();
				}
				goto IL_0167;
				end_IL_00f8:;
			}
			catch
			{
				//try-fault
				if (num4 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			InterruptedException ex2 = null;
			System.Exception ex5;
			try
			{
				ex2 = ex2;
				try
				{
					num4 = 1;
					num3 = 0;
				}
				catch (System.Exception x2)
				{
					ex5 = ByteCodeHelper.MapException<System.Exception>(x2, ByteCodeHelper.MapFlags.None);
					goto IL_01a8;
				}
			}
			catch
			{
				//try-fault
				if (num4 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			continue;
			IL_0161:
			ex6 = ex4;
			break;
			IL_01a8:
			ex6 = ex5;
			break;
			IL_0167:
			if (num4 != 0)
			{
				Thread.currentThread().interrupt();
			}
			return (byte)result2 != 0;
		}
		System.Exception ex7 = ex6;
		try
		{
			if (num5 == 0)
			{
				reentrantLock.unlock();
			}
			throw Throwable.___003Cunmap_003E(ex7);
		}
		catch
		{
			//try-fault
			if (num4 != 0)
			{
				Thread.currentThread().interrupt();
			}
			throw;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 13, 109 })]
	public virtual void enter()
	{
		@lock.@lock();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(957)]
	public virtual bool isOccupiedByCurrentThread()
	{
		bool result = @lock.isHeldByCurrentThread();
		_ = null;
		return result;
	}

	[Modifiers(Modifiers.Static | Modifiers.Synthetic)]
	[LineNumberTable(205)]
	internal static ReentrantLock access_0024000(Monitor P_0)
	{
		return P_0.@lock;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 53, 162, 232, 46, 231, 83, 103, 108 })]
	public Monitor(bool fair)
	{
		activeGuards = null;
		this.fair = fair;
		@lock = new ReentrantLock(fair);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 33, 104, 103, 112, 130, 134, 102, 231, 73,
		99, 138, 227, 54, 245, 71, 99, 138, 230, 61,
		99, 234, 56, 103, 97, 98, 105, 164, 99, 138
	})]
	public virtual bool enter(long time, TimeUnit unit)
	{
		long num = toSafeNanos(time, unit);
		ReentrantLock reentrantLock = @lock;
		if (!fair && reentrantLock.tryLock())
		{
			return true;
		}
		int num2 = (Thread.interrupted() ? 1 : 0);
		long num3;
		long timeout;
		try
		{
			num3 = java.lang.System.nanoTime();
			timeout = num;
		}
		catch
		{
			//try-fault
			if (num2 != 0)
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
					result = (reentrantLock.tryLock(timeout, TimeUnit.NANOSECONDS) ? 1 : 0);
				}
				catch (InterruptedException)
				{
					goto IL_0069;
				}
			}
			catch
			{
				//try-fault
				if (num2 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			break;
			IL_0069:
			InterruptedException ex2 = null;
			try
			{
				num2 = 1;
				timeout = remainingNanos(num3, num);
			}
			catch
			{
				//try-fault
				if (num2 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num2 != 0)
		{
			Thread.currentThread().interrupt();
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 150, 104 })]
	private static long toSafeNanos(long P_0, TimeUnit P_1)
	{
		long value = P_1.toNanos(P_0);
		long result = Longs.constrainToRange(value, 0L, 6917529027641081853L);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1061)]
	private static long remainingNanos(long P_0, long P_1)
	{
		return (P_1 > 0) ? (P_1 - (java.lang.System.nanoTime() - P_0)) : 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(454)]
	public virtual bool enterInterruptibly(long time, TimeUnit unit)
	{
		bool result = @lock.tryLock(time, unit);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[]
	{
		158, 104, 98, 99, 134, 167, 107, 140, 103, 35,
		98, 98
	})]
	private void await(Guard P_0, bool P_1)
	{
		if (P_1)
		{
			signalNextWaiter();
		}
		beginWaitingFor(P_0);
		try
		{
			do
			{
				P_0.condition.await();
			}
			while (!P_0.isSatisfied());
		}
		finally
		{
			endWaitingFor(P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[]
	{
		161, 147, 104, 105, 139, 103, 103, 195, 136, 103,
		139, 104, 162, 103, 106, 194, 99, 131, 97, 169,
		16, 205, 99, 136, 164, 103, 170, 102, 35, 98,
		130, 227, 54, 164, 103, 170, 102, 35, 102, 226,
		54
	})]
	public virtual bool enterWhen(Guard guard, long time, TimeUnit unit)
	{
		long num = toSafeNanos(time, unit);
		if (guard.monitor != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		ReentrantLock reentrantLock = @lock;
		int num2 = (reentrantLock.isHeldByCurrentThread() ? 1 : 0);
		long num3 = 0L;
		if (!fair)
		{
			if (Thread.interrupted())
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new InterruptedException();
			}
			if (reentrantLock.tryLock())
			{
				goto IL_0064;
			}
		}
		num3 = initNanoTime(num);
		if (!reentrantLock.tryLock(time, unit))
		{
			return false;
		}
		goto IL_0064;
		IL_0064:
		int num4 = 0;
		int num5 = 1;
		int result;
		try
		{
			num4 = ((guard.isSatisfied() || awaitNanos(guard, (num3 != 0) ? remainingNanos(num3, num) : num, (byte)num2 != 0)) ? 1 : 0);
			num5 = 0;
			result = num4;
		}
		catch
		{
			//try-fault
			if (num4 == 0)
			{
				try
				{
					if (num5 != 0 && num2 == 0)
					{
						signalNextWaiter();
					}
				}
				finally
				{
					reentrantLock.unlock();
				}
			}
			throw;
		}
		if (num4 == 0)
		{
			try
			{
				if (num5 != 0 && num2 == 0)
				{
					signalNextWaiter();
				}
			}
			catch
			{
				//try-fault
				reentrantLock.unlock();
				throw;
			}
			reentrantLock.unlock();
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 159, 101, 131, 102 })]
	private static long initNanoTime(long P_0)
	{
		if (P_0 <= 0)
		{
			return 0L;
		}
		long num = java.lang.System.nanoTime();
		return (num != 0) ? num : 1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[]
	{
		158, 96, 98, 162, 101, 232, 77, 99, 135, 229,
		61, 99, 231, 50, 130, 99, 99, 134, 103, 130,
		110, 104, 136, 99, 135, 232, 61, 99, 231, 61
	})]
	private bool awaitNanos(Guard P_0, long P_1, bool P_2)
	{
		int num = 1;
		int result;
		while (true)
		{
			try
			{
				if (P_1 <= 0)
				{
					result = 0;
					goto IL_0020;
				}
			}
			catch
			{
				//try-fault
				if (num == 0)
				{
					endWaitingFor(P_0);
				}
				throw;
			}
			try
			{
				if (num != 0)
				{
					if (P_2)
					{
						signalNextWaiter();
					}
					beginWaitingFor(P_0);
					num = 0;
				}
				P_1 = P_0.condition.awaitNanos(P_1);
				if (P_0.isSatisfied())
				{
					result = 1;
					break;
				}
			}
			catch
			{
				//try-fault
				if (num == 0)
				{
					endWaitingFor(P_0);
				}
				throw;
			}
			continue;
			IL_0020:
			if (num == 0)
			{
				endWaitingFor(P_0);
			}
			return (byte)result != 0;
		}
		if (num == 0)
		{
			endWaitingFor(P_0);
		}
		return (byte)result != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 208, 106, 105, 107, 226, 61, 233, 70 })]
	private void signalNextWaiter()
	{
		for (Guard next = activeGuards; next != null; next = next.next)
		{
			if (isSatisfied(next))
			{
				next.condition.signal();
				break;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		158, 100, 66, 99, 134, 167, 107, 140, 103, 35,
		98, 98
	})]
	private void awaitUninterruptibly(Guard P_0, bool P_1)
	{
		if (P_1)
		{
			signalNextWaiter();
		}
		beginWaitingFor(P_0);
		try
		{
			do
			{
				P_0.condition.awaitUninterruptibly();
			}
			while (!P_0.isSatisfied());
		}
		finally
		{
			endWaitingFor(P_0);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 83, 105, 139, 106, 162, 130, 141, 99, 139,
		227, 61, 2
	})]
	public virtual bool enterIf(Guard guard, long time, TimeUnit unit)
	{
		if (guard.monitor != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		if (!enter(time, unit))
		{
			return false;
		}
		int num = 0;
		try
		{
			return (byte)(num = (guard.isSatisfied() ? 1 : 0)) != 0;
		}
		finally
		{
			if (num == 0)
			{
				@lock.unlock();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[]
	{
		162, 144, 105, 139, 103, 106, 162, 130, 141, 99,
		134, 227, 61, 2
	})]
	public virtual bool enterIfInterruptibly(Guard guard, long time, TimeUnit unit)
	{
		if (guard.monitor != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		ReentrantLock reentrantLock = @lock;
		if (!reentrantLock.tryLock(time, unit))
		{
			return false;
		}
		int num = 0;
		try
		{
			return (byte)(num = (guard.isSatisfied() ? 1 : 0)) != 0;
		}
		finally
		{
			if (num == 0)
			{
				reentrantLock.unlock();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[] { 162, 225, 104, 118, 139, 104, 130, 103, 139 })]
	public virtual bool waitFor(Guard guard, long time, TimeUnit unit)
	{
		long num = toSafeNanos(time, unit);
		if (guard.monitor != this || !@lock.isHeldByCurrentThread())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		if (guard.isSatisfied())
		{
			return true;
		}
		if (Thread.interrupted())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new InterruptedException();
		}
		bool result = awaitNanos(guard, num, true);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 14, 104, 118, 139, 104, 130, 98, 103, 134,
		131, 242, 75, 99, 138, 230, 61, 99, 234, 52,
		103, 97, 98, 104, 233, 71, 99, 138, 229, 61,
		99, 234, 56, 131, 98, 105, 164, 99, 138
	})]
	public virtual bool waitForUninterruptibly(Guard guard, long time, TimeUnit unit)
	{
		long num = toSafeNanos(time, unit);
		if (guard.monitor != this || !@lock.isHeldByCurrentThread())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		if (guard.isSatisfied())
		{
			return true;
		}
		int num2 = 1;
		long num3 = initNanoTime(num);
		int num4 = (Thread.interrupted() ? 1 : 0);
		long num5 = num;
		int result2;
		while (true)
		{
			int result;
			try
			{
				try
				{
					result = (awaitNanos(guard, num5, (byte)num2 != 0) ? 1 : 0);
				}
				catch (InterruptedException)
				{
					goto IL_0067;
				}
			}
			catch
			{
				//try-fault
				if (num4 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			if (num4 != 0)
			{
				Thread.currentThread().interrupt();
			}
			return (byte)result != 0;
			IL_0067:
			InterruptedException ex2 = null;
			try
			{
				num4 = 1;
				if (guard.isSatisfied())
				{
					result2 = 1;
					break;
				}
			}
			catch
			{
				//try-fault
				if (num4 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
			try
			{
				num2 = 0;
				num5 = remainingNanos(num3, num);
			}
			catch
			{
				//try-fault
				if (num4 != 0)
				{
					Thread.currentThread().interrupt();
				}
				throw;
			}
		}
		if (num4 != 0)
		{
			Thread.currentThread().interrupt();
		}
		return (byte)result2 != 0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 133, 105, 139, 139, 139, 107, 35, 2 })]
	public virtual int getWaitQueueLength(Guard guard)
	{
		if (guard.monitor != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		@lock.@lock();
		try
		{
			return guard.waiterCount;
		}
		finally
		{
			@lock.unlock();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 241, 124, 97, 102 })]
	private bool isSatisfied(Guard P_0)
	{
		//Discarded unreachable code: IL_0008
		System.Exception ex;
		try
		{
			return P_0.isSatisfied();
		}
		catch (System.Exception x)
		{
			ex = ByteCodeHelper.MapException<System.Exception>(x, ByteCodeHelper.MapFlags.None);
		}
		System.Exception ex2 = ex;
		signalAllWaiters();
		throw Throwable.___003Cunmap_003E(ex2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 163, 251, 106, 43, 169 })]
	private void signalAllWaiters()
	{
		for (Guard next = activeGuards; next != null; next = next.next)
		{
			next.condition.signalAll();
		}
	}

	[LineNumberTable(new byte[] { 164, 3, 116, 131, 108, 135 })]
	private void beginWaitingFor(Guard P_0)
	{
		int waiterCount = P_0.waiterCount;
		P_0.waiterCount = waiterCount + 1;
		if (waiterCount == 0)
		{
			P_0.next = activeGuards;
			activeGuards = P_0;
		}
	}

	[LineNumberTable(new byte[]
	{
		164, 14, 116, 131, 106, 100, 100, 142, 141, 103,
		226, 56, 236, 76
	})]
	private void endWaitingFor(Guard P_0)
	{
		int num = P_0.waiterCount - 1;
		P_0.waiterCount = num;
		if (num == 0)
		{
			Guard next = activeGuards;
			Guard guard = null;
			while (next != P_0)
			{
				guard = next;
				next = next.next;
			}
			if (guard == null)
			{
				activeGuards = next.next;
			}
			else
			{
				guard.next = next.next;
			}
			next.next = null;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 2, 108 })]
	public virtual Guard newGuard(BooleanSupplier isSatisfied)
	{
		Preconditions.checkNotNull((object)isSatisfied, (object)"isSatisfied");
		_1 result = new _1(this, this, isSatisfied);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(393)]
	public virtual bool enter(Duration time)
	{
		bool result = enter(Internal.toNanosSaturated(time), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[] { 161, 62, 109 })]
	public virtual void enterInterruptibly()
	{
		@lock.lockInterruptibly();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(443)]
	public virtual bool enterInterruptibly(Duration time)
	{
		bool result = enterInterruptibly(Internal.toNanosSaturated(time), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(465)]
	public virtual bool tryEnter()
	{
		bool result = @lock.tryLock();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[]
	{
		161, 104, 105, 139, 103, 103, 134, 130, 104, 136,
		134, 99, 134, 227, 61, 99, 168
	})]
	public virtual void enterWhen(Guard guard)
	{
		if (guard.monitor != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		ReentrantLock reentrantLock = @lock;
		int num = (reentrantLock.isHeldByCurrentThread() ? 1 : 0);
		reentrantLock.lockInterruptibly();
		int num2 = 0;
		try
		{
			if (!guard.isSatisfied())
			{
				await(guard, (byte)num != 0);
			}
			num2 = 1;
		}
		catch
		{
			//try-fault
			if (num2 == 0)
			{
				leave();
			}
			throw;
		}
		if (num2 == 0)
		{
			leave();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(504)]
	public virtual bool enterWhen(Guard guard, Duration time)
	{
		bool result = enterWhen(guard, Internal.toNanosSaturated(time), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(597)]
	public virtual bool enterWhenUninterruptibly(Guard guard, Duration time)
	{
		bool result = enterWhenUninterruptibly(guard, Internal.toNanosSaturated(time), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(698)]
	public virtual bool enterIf(Guard guard, Duration time)
	{
		bool result = enterIf(guard, Internal.toNanosSaturated(time), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[]
	{
		162, 108, 105, 139, 103, 134, 130, 141, 99, 134,
		227, 61, 2
	})]
	public virtual bool enterIfInterruptibly(Guard guard)
	{
		if (guard.monitor != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		ReentrantLock reentrantLock = @lock;
		reentrantLock.lockInterruptibly();
		int num = 0;
		try
		{
			return (byte)(num = (guard.isSatisfied() ? 1 : 0)) != 0;
		}
		finally
		{
			if (num == 0)
			{
				reentrantLock.unlock();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(758)]
	public virtual bool enterIfInterruptibly(Guard guard, Duration time)
	{
		bool result = enterIfInterruptibly(guard, Internal.toNanosSaturated(time), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 171, 105, 139, 103, 104, 162, 130, 141, 99,
		134, 227, 61, 2
	})]
	public virtual bool tryEnterIf(Guard guard)
	{
		if (guard.monitor != this)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		ReentrantLock reentrantLock = @lock;
		if (!reentrantLock.tryLock())
		{
			return false;
		}
		int num = 0;
		try
		{
			return (byte)(num = (guard.isSatisfied() ? 1 : 0)) != 0;
		}
		finally
		{
			if (num == 0)
			{
				reentrantLock.unlock();
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(new byte[] { 162, 196, 118, 139, 104, 138 })]
	public virtual void waitFor(Guard guard)
	{
		if (guard.monitor != this || !@lock.isHeldByCurrentThread())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		if (!guard.isSatisfied())
		{
			await(guard, true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Throws(new string[] { "java.lang.InterruptedException" })]
	[LineNumberTable(839)]
	public virtual bool waitFor(Guard guard, Duration time)
	{
		bool result = waitFor(guard, Internal.toNanosSaturated(time), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 243, 118, 139, 104, 138 })]
	public virtual void waitForUninterruptibly(Guard guard)
	{
		if (guard.monitor != this || !@lock.isHeldByCurrentThread())
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalMonitorStateException();
		}
		if (!guard.isSatisfied())
		{
			awaitUninterruptibly(guard, true);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(885)]
	public virtual bool waitForUninterruptibly(Guard guard, Duration time)
	{
		bool result = waitForUninterruptibly(guard, Internal.toNanosSaturated(time), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	public virtual bool isFair()
	{
		return fair;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(949)]
	public virtual bool isOccupied()
	{
		bool result = @lock.isLocked();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(965)]
	public virtual int getOccupiedDepth()
	{
		int holdCount = @lock.getHoldCount();
		_ = null;
		return holdCount;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(975)]
	public virtual int getQueueLength()
	{
		int queueLength = @lock.getQueueLength();
		_ = null;
		return queueLength;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(985)]
	public virtual bool hasQueuedThreads()
	{
		bool result = @lock.hasQueuedThreads();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(995)]
	public virtual bool hasQueuedThread(Thread thread)
	{
		bool result = @lock.hasQueuedThread(thread);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1005)]
	public virtual bool hasWaiters(Guard guard)
	{
		return getWaitQueueLength(guard) > 0;
	}
}
