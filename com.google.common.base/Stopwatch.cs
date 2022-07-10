using System;
using System.Runtime.CompilerServices;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.time;
using java.util.concurrent;

namespace com.google.common.@base;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/base/ElementTypesAreNonnullByDefault;"
})]
public sealed class Stopwatch : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024java_0024util_0024concurrent_0024TimeUnit;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(261)]
		static _1()
		{
			_0024SwitchMap_0024java_0024util_0024concurrent_0024TimeUnit = new int[(nint)TimeUnit.values().LongLength];
			try
			{
				_0024SwitchMap_0024java_0024util_0024concurrent_0024TimeUnit[TimeUnit.NANOSECONDS.ordinal()] = 1;
			}
			catch (System.Exception x)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0033;
			}
			goto IL_0039;
			IL_0033:
			_ = null;
			goto IL_0039;
			IL_0039:
			try
			{
				_0024SwitchMap_0024java_0024util_0024concurrent_0024TimeUnit[TimeUnit.MICROSECONDS.ordinal()] = 2;
			}
			catch (System.Exception x2)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x2, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_005c;
			}
			goto IL_0062;
			IL_005c:
			_ = null;
			goto IL_0062;
			IL_0062:
			try
			{
				_0024SwitchMap_0024java_0024util_0024concurrent_0024TimeUnit[TimeUnit.MILLISECONDS.ordinal()] = 3;
			}
			catch (System.Exception x3)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x3, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0085;
			}
			goto IL_008b;
			IL_0085:
			_ = null;
			goto IL_008b;
			IL_008b:
			try
			{
				_0024SwitchMap_0024java_0024util_0024concurrent_0024TimeUnit[TimeUnit.SECONDS.ordinal()] = 4;
			}
			catch (System.Exception x4)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x4, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00ae;
			}
			goto IL_00b4;
			IL_00ae:
			_ = null;
			goto IL_00b4;
			IL_00b4:
			try
			{
				_0024SwitchMap_0024java_0024util_0024concurrent_0024TimeUnit[TimeUnit.MINUTES.ordinal()] = 5;
			}
			catch (System.Exception x5)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x5, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_00d7;
			}
			goto IL_00dd;
			IL_00d7:
			_ = null;
			goto IL_00dd;
			IL_00dd:
			try
			{
				_0024SwitchMap_0024java_0024util_0024concurrent_0024TimeUnit[TimeUnit.HOURS.ordinal()] = 6;
			}
			catch (System.Exception x6)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x6, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0100;
			}
			goto IL_0106;
			IL_0100:
			_ = null;
			goto IL_0106;
			IL_0106:
			try
			{
				_0024SwitchMap_0024java_0024util_0024concurrent_0024TimeUnit[TimeUnit.DAYS.ordinal()] = 7;
				return;
			}
			catch (System.Exception x7)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x7, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
			}
			_ = null;
		}

		_1()
		{
			throw null;
		}
	}

	[Modifiers(Modifiers.Private | Modifiers.Final)]
	private Ticker ticker;

	private bool m_isRunning;

	private long m_elapsedNanos;

	private long startTick;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 85, 104, 107 })]
	internal Stopwatch()
	{
		ticker = Ticker.systemTicker();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 89, 104, 118 })]
	internal Stopwatch(Ticker P_0)
	{
		ticker = (Ticker)Preconditions.checkNotNull((object)P_0, (object)"ticker");
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 109, 118, 103, 113 })]
	public virtual Stopwatch start()
	{
		Preconditions.checkState((!this.m_isRunning) ? true : false, (object)"This stopwatch is already running.");
		this.m_isRunning = true;
		startTick = ticker.read();
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(194)]
	private long elapsedNanos()
	{
		return (!this.m_isRunning) ? this.m_elapsedNanos : (ticker.read() - startTick + this.m_elapsedNanos);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 125, 116, 134, 116, 134, 116, 134, 116, 134,
		116, 134, 116, 134
	})]
	private static TimeUnit chooseUnit(long P_0)
	{
		if (TimeUnit.DAYS.convert(P_0, TimeUnit.NANOSECONDS) > 0)
		{
			return TimeUnit.DAYS;
		}
		if (TimeUnit.HOURS.convert(P_0, TimeUnit.NANOSECONDS) > 0)
		{
			return TimeUnit.HOURS;
		}
		if (TimeUnit.MINUTES.convert(P_0, TimeUnit.NANOSECONDS) > 0)
		{
			return TimeUnit.MINUTES;
		}
		if (TimeUnit.SECONDS.convert(P_0, TimeUnit.NANOSECONDS) > 0)
		{
			return TimeUnit.SECONDS;
		}
		if (TimeUnit.MILLISECONDS.convert(P_0, TimeUnit.NANOSECONDS) > 0)
		{
			return TimeUnit.MILLISECONDS;
		}
		if (TimeUnit.MICROSECONDS.convert(P_0, TimeUnit.NANOSECONDS) > 0)
		{
			return TimeUnit.MICROSECONDS;
		}
		return TimeUnit.NANOSECONDS;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 147, 159, 18, 134, 134, 134, 134, 134, 134,
		134
	})]
	private static string abbreviate(TimeUnit P_0)
	{
		switch (_1._0024SwitchMap_0024java_0024util_0024concurrent_0024TimeUnit[P_0.ordinal()])
		{
		case 1:
			return "ns";
		case 2:
			return "μs";
		case 3:
			return "ms";
		case 4:
			return "s";
		case 5:
			return "min";
		case 6:
			return "h";
		case 7:
			return "d";
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(105)]
	public static Stopwatch createUnstarted()
	{
		Stopwatch result = new Stopwatch();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(114)]
	public static Stopwatch createUnstarted(Ticker ticker)
	{
		Stopwatch result = new Stopwatch(ticker);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(123)]
	public static Stopwatch createStarted()
	{
		Stopwatch result = new Stopwatch().start();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(132)]
	public static Stopwatch createStarted(Ticker ticker)
	{
		Stopwatch result = new Stopwatch(ticker).start();
		_ = null;
		return result;
	}

	public virtual bool isRunning()
	{
		return this.m_isRunning;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 124, 108, 112, 103, 117 })]
	public virtual Stopwatch stop()
	{
		long num = ticker.read();
		Preconditions.checkState(this.m_isRunning, (object)"This stopwatch is already stopped.");
		this.m_isRunning = false;
		this.m_elapsedNanos += num - startTick;
		return this;
	}

	public virtual Stopwatch reset()
	{
		this.m_elapsedNanos = 0L;
		this.m_isRunning = false;
		return this;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(211)]
	public virtual long elapsed(TimeUnit desiredUnit)
	{
		long result = desiredUnit.convert(elapsedNanos(), TimeUnit.NANOSECONDS);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(223)]
	public virtual Duration elapsed()
	{
		Duration result = Duration.ofNanos(elapsedNanos());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 115, 135, 103, 179 })]
	public override string toString()
	{
		long num = elapsedNanos();
		TimeUnit timeUnit = chooseUnit(num);
		double num2 = (double)num / (double)TimeUnit.NANOSECONDS.convert(1L, timeUnit);
		string text = Platform.formatCompact4Digits(num2);
		string text2 = abbreviate(timeUnit);
		int num3 = 1 + java.lang.String.instancehelper_length(java.lang.String.valueOf(text)) + java.lang.String.instancehelper_length(java.lang.String.valueOf(text2));
		num3 = num3;
		string result = new StringBuilder(num3).append(text).append(" ").append(text2)
			.toString();
		_ = null;
		return result;
	}
}
