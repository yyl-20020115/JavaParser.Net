using System.Runtime.CompilerServices;
using com.google.common.math;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.util.concurrent;

namespace com.google.common.util.concurrent;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/util/concurrent/ElementTypesAreNonnullByDefault;"
})]
internal abstract class SmoothRateLimiter : RateLimiter
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : Object
	{
		_1()
		{
			throw null;
		}
	}

	internal sealed class SmoothBursty : SmoothRateLimiter
	{
		[Modifiers(Modifiers.Final)]
		internal double maxBurstSeconds;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 168, 106, 105 })]
		internal SmoothBursty(SleepingStopwatch P_0, double P_1)
			: base(P_0, null)
		{
			maxBurstSeconds = P_1;
		}

		internal override void doSetRate(double P_0, double P_1)
		{
			double num = maxPermits;
			maxPermits = maxBurstSeconds * P_0;
			if (num == double.PositiveInfinity)
			{
				storedPermits = maxPermits;
			}
			else
			{
				storedPermits = ((num != 0.0) ? (storedPermits * maxPermits / num) : 0.0);
			}
		}

		internal override long storedPermitsToWaitTime(double P_0, double P_1)
		{
			return 0L;
		}

		internal override double coolDownIntervalMicros()
		{
			return stableIntervalMicros;
		}
	}

	internal sealed class SmoothWarmingUp : SmoothRateLimiter
	{
		[Modifiers(Modifiers.Private | Modifiers.Final)]
		private long warmupPeriodMicros;

		private double slope;

		private double thresholdPermits;

		private double coldFactor;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 160, 104, 106, 109, 106 })]
		internal SmoothWarmingUp(SleepingStopwatch P_0, long P_1, TimeUnit P_2, double P_3)
			: base(P_0, null)
		{
			warmupPeriodMicros = P_2.toMicros(P_1);
			coldFactor = P_3;
		}

		private double permitsToTime(double P_0)
		{
			return stableIntervalMicros + P_0 * slope;
		}

		internal override void doSetRate(double P_0, double P_1)
		{
			double num = maxPermits;
			double num2 = P_1 * coldFactor;
			thresholdPermits = 0.5 * (double)warmupPeriodMicros / P_1;
			maxPermits = thresholdPermits + 2.0 * (double)warmupPeriodMicros / (P_1 + num2);
			slope = (num2 - P_1) / (maxPermits - thresholdPermits);
			if (num == double.PositiveInfinity)
			{
				storedPermits = 0.0;
			}
			else
			{
				storedPermits = ((num != 0.0) ? (storedPermits * maxPermits / num) : maxPermits);
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			160, 130, 107, 131, 104, 138, 98, 105, 104, 115,
			167, 113
		})]
		internal override long storedPermitsToWaitTime(double P_0, double P_1)
		{
			double num = P_0 - thresholdPermits;
			long num2 = 0L;
			if (num > 0.0)
			{
				double num3 = Math.min(num, P_1);
				double num4 = permitsToTime(num) + permitsToTime(num - num3);
				num2 = ByteCodeHelper.d2l(num3 * num4 / 2.0);
				P_1 -= num3;
			}
			return num2 + ByteCodeHelper.d2l(stableIntervalMicros * P_1);
		}

		internal override double coolDownIntervalMicros()
		{
			return (double)warmupPeriodMicros / maxPermits;
		}
	}

	internal double storedPermits;

	internal double maxPermits;

	internal double stableIntervalMicros;

	private long nextFreeTicketMicros;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 217, 233, 61, 200 })]
	private SmoothRateLimiter(SleepingStopwatch P_0)
		: base(P_0)
	{
		nextFreeTicketMicros = 0L;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 16, 105, 114, 122, 135 })]
	internal virtual void resync(long P_0)
	{
		if (P_0 > nextFreeTicketMicros)
		{
			double num = (double)(P_0 - nextFreeTicketMicros) / coolDownIntervalMicros();
			storedPermits = Math.min(maxPermits, storedPermits + num);
			nextFreeTicketMicros = P_0;
		}
	}

	internal abstract void doSetRate(double P_0, double P_1);

	internal abstract long storedPermitsToWaitTime(double P_0, double P_1);

	internal abstract double coolDownIntervalMicros();

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 222, 103, 114, 104, 107 })]
	internal sealed override void doSetRate(double P_0, long P_1)
	{
		resync(P_1);
		double num = (double)TimeUnit.SECONDS.toMicros(1L) / P_0;
		stableIntervalMicros = num;
		doSetRate(P_0, num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(346)]
	internal sealed override double doGetRate()
	{
		return (double)TimeUnit.SECONDS.toMicros(1L) / stableIntervalMicros;
	}

	internal sealed override long queryEarliestAvailable(long P_0)
	{
		return nextFreeTicketMicros;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 242, 103, 103, 111, 102, 104, 180, 114, 111 })]
	internal sealed override long reserveEarliestAvailable(int P_0, long P_1)
	{
		resync(P_1);
		long result = nextFreeTicketMicros;
		double num = Math.min(P_0, storedPermits);
		double num2 = (double)P_0 - num;
		long b = storedPermitsToWaitTime(storedPermits, num) + ByteCodeHelper.d2l(num2 * stableIntervalMicros);
		nextFreeTicketMicros = LongMath.saturatedAdd(nextFreeTicketMicros, b);
		storedPermits -= num;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Modifiers(Modifiers.Synthetic)]
	[LineNumberTable(26)]
	internal SmoothRateLimiter(SleepingStopwatch P_0, _1 P_1)
		: this(P_0)
	{
	}
}
