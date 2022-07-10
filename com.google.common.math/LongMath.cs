using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.math;

namespace com.google.common.math;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
public sealed class LongMath : java.lang.Object
{
	[SpecialName]
	[InnerClass(null, Modifiers.Static | Modifiers.Synthetic)]
	[EnclosingMethod(null, null, null)]
	[Modifiers(Modifiers.Super | Modifiers.Synthetic)]
	internal class _1 : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		internal static int[] _0024SwitchMap_0024java_0024math_0024RoundingMode;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(124)]
		static _1()
		{
			_0024SwitchMap_0024java_0024math_0024RoundingMode = new int[(nint)RoundingMode.values().LongLength];
			try
			{
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.UNNECESSARY.ordinal()] = 1;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.DOWN.ordinal()] = 2;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.FLOOR.ordinal()] = 3;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.UP.ordinal()] = 4;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.CEILING.ordinal()] = 5;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.HALF_DOWN.ordinal()] = 6;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.HALF_UP.ordinal()] = 7;
			}
			catch (System.Exception x7)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x7, ByteCodeHelper.MapFlags.Unused) == null)
				{
					throw;
				}
				goto IL_0129;
			}
			goto IL_012f;
			IL_0129:
			_ = null;
			goto IL_012f;
			IL_012f:
			try
			{
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.HALF_EVEN.ordinal()] = 8;
				return;
			}
			catch (System.Exception x8)
			{
				if (ByteCodeHelper.MapException<NoSuchFieldError>(x8, ByteCodeHelper.MapFlags.Unused) == null)
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

	[Serializable]
	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Abstract | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/math/LongMath$MillerRabinTester;>;")]
	[Modifiers(Modifiers.Super | Modifiers.Abstract | Modifiers.Enum)]
	internal abstract class MillerRabinTester : java.lang.Enum
	{
		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _1 : MillerRabinTester
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1091)]
			internal _1(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[LineNumberTable(1100)]
			internal override long mulMod(long P_0, long P_1, long P_2)
			{
				long num = P_0 * P_1;
				return (P_2 != -1) ? (num % P_2) : 0;
			}

			[LineNumberTable(1105)]
			internal override long squareMod(long P_0, long P_1)
			{
				long num = P_0 * P_0;
				return (P_1 != -1) ? (num % P_1) : 0;
			}

			[HideFromJava]
			static _1()
			{
				MillerRabinTester.___003Cclinit_003E();
			}
		}

		[Serializable]
		[SpecialName]
		[InnerClass(null, Modifiers.Final | Modifiers.Enum)]
		[EnclosingMethod(null, null, null)]
		[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
		internal sealed class _2 : MillerRabinTester
		{
			[MethodImpl(MethodImplOptions.NoInlining)]
			[SpecialName]
			public new static void ___003Cclinit_003E()
			{
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(1109)]
			internal _2(string P_0, int P_1)
				: base(P_0, P_1, null)
			{
				GC.KeepAlive(this);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[] { 163, 235, 131, 173, 110, 100, 100 })]
			private long times2ToThe32Mod(long P_0, long P_1)
			{
				int num = 32;
				do
				{
					int num2 = java.lang.Math.min(num, Long.numberOfLeadingZeros(P_0));
					P_0 = UnsignedLongs.remainder(P_0 << num2, P_1);
					num -= num2;
				}
				while (num > 0);
				return P_0;
			}

			private long plusMod(long P_0, long P_1, long P_2)
			{
				return (P_0 < P_2 - P_1) ? (P_0 + P_1) : (P_0 + P_1 - P_2);
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				163, 248, 101, 101, 105, 233, 74, 108, 104, 102,
				170, 104, 107
			})]
			internal override long mulMod(long P_0, long P_1, long P_2)
			{
				long num = (long)((ulong)P_0 >> 32);
				long num2 = (long)((ulong)P_1 >> 32);
				long num3 = P_0 & 0xFFFFFFFFu;
				long num4 = P_1 & 0xFFFFFFFFu;
				long num5 = times2ToThe32Mod(num * num2, P_2);
				num5 += num * num4;
				if (num5 < 0)
				{
					num5 = UnsignedLongs.remainder(num5, P_2);
				}
				num5 += num3 * num2;
				num5 = times2ToThe32Mod(num5, P_2);
				long result = plusMod(num5, UnsignedLongs.remainder(num3 * num4, P_2), P_2);
				_ = null;
				return result;
			}

			[MethodImpl(MethodImplOptions.NoInlining)]
			[LineNumberTable(new byte[]
			{
				164, 18, 101, 233, 73, 107, 103, 101, 168, 100,
				105
			})]
			internal override long squareMod(long P_0, long P_1)
			{
				long num = (long)((ulong)P_0 >> 32);
				long num2 = P_0 & 0xFFFFFFFFu;
				long num3 = times2ToThe32Mod(num * num, P_1);
				long num4 = num * num2 * 2;
				if (num4 < 0)
				{
					num4 = UnsignedLongs.remainder(num4, P_1);
				}
				num3 += num4;
				num3 = times2ToThe32Mod(num3, P_1);
				long result = plusMod(num3, UnsignedLongs.remainder(num2 * num2, P_1), P_1);
				_ = null;
				return result;
			}

			[HideFromJava]
			static _2()
			{
				MillerRabinTester.___003Cclinit_003E();
			}
		}

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static MillerRabinTester SMALL;

		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static MillerRabinTester LARGE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static MillerRabinTester[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1181)]
		internal static bool test(long P_0, long P_1)
		{
			bool result = ((P_1 > 3037000499u) ? LARGE : SMALL).testWitness(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(1089)]
		private MillerRabinTester(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[]
		{
			164, 66, 106, 106, 112, 105, 162, 202, 101, 130,
			98, 103, 104, 130, 139
		})]
		private bool testWitness(long P_0, long P_1)
		{
			int num = Long.numberOfTrailingZeros(P_1 - 1);
			long num2 = P_1 - 1 >> num;
			long num3 = P_0;
			P_0 = ((P_1 != -1) ? (num3 % P_1) : 0);
			if (P_0 == 0)
			{
				return true;
			}
			long num4 = powMod(P_0, num2, P_1);
			if (num4 == 1)
			{
				return true;
			}
			int num5 = 0;
			while (num4 != P_1 - 1)
			{
				num5++;
				if (num5 == num)
				{
					return false;
				}
				num4 = squareMod(num4, P_1);
			}
			return true;
		}

		internal abstract long mulMod(long P_0, long P_1, long P_2);

		internal abstract long squareMod(long P_0, long P_1);

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 164, 54, 99, 105, 104, 138, 234, 60, 231, 70 })]
		private long powMod(long P_0, long P_1, long P_2)
		{
			long num = 1L;
			while (P_1 != 0)
			{
				if ((P_1 & 1) != 0)
				{
					num = mulMod(num, P_0, P_2);
				}
				P_0 = squareMod(P_0, P_2);
				P_1 >>= 1;
			}
			return num;
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(1089)]
		private static MillerRabinTester[] _0024values()
		{
			return new MillerRabinTester[2] { SMALL, LARGE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1089)]
		public static MillerRabinTester[] values()
		{
			return (MillerRabinTester[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(1089)]
		public static MillerRabinTester valueOf(string P_0)
		{
			return (MillerRabinTester)java.lang.Enum.valueOf(ClassLiteral<MillerRabinTester>.Value, P_0);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Synthetic)]
		[LineNumberTable(1089)]
		internal MillerRabinTester(string P_0, int P_1, LongMath._1 P_2)
			: this(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[LineNumberTable(new byte[] { 163, 209, 240, 82, 240, 44 })]
		static MillerRabinTester()
		{
			SMALL = new _1("SMALL", 0);
			LARGE = new _2("LARGE", 1);
			_0024VALUES = _0024values();
		}
	}

	internal const long MAX_SIGNED_POWER_OF_TWO = 4611686018427387904L;

	internal const long MAX_POWER_OF_SQRT2_UNSIGNED = -5402926248376769404L;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static byte[] maxLog10ForLeadingZeros;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static long[] powersOf10;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static long[] halfPowersOf10;

	internal const long FLOOR_SQRT_MAX_LONG = 3037000499L;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static long[] factorials;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static int[] biggestBinomials;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static int[] biggestSimpleBinomials;

	private const int SIEVE_30 = -545925251;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static long[][] millerRabinBaseSets;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	public static long saturatedAdd(long a, long b)
	{
		long num = a + b;
		if ((a ^ b) < 0 || (a ^ num) >= 0)
		{
			return num;
		}
		return (long)(long.MaxValue + (((ulong)num >> 63) ^ 1));
	}

	public static long saturatedSubtract(long a, long b)
	{
		long num = a - b;
		if ((a ^ b) >= 0 || (a ^ num) >= 0)
		{
			return num;
		}
		return (long)(long.MaxValue + (((ulong)num >> 63) ^ 1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 202, 97, 105, 103, 106, 231, 75, 101, 132,
		116, 127, 5, 100, 127, 9
	})]
	public static long checkedMultiply(long a, long b)
	{
		int num = Long.numberOfLeadingZeros(a) + Long.numberOfLeadingZeros(a ^ -1) + Long.numberOfLeadingZeros(b) + Long.numberOfLeadingZeros(b ^ -1);
		if (num > 65)
		{
			return a * b;
		}
		MathPreconditions.checkNoOverflow(num >= 64, "checkedMultiply", a, b);
		MathPreconditions.checkNoOverflow(a >= 0 || b != long.MinValue, "checkedMultiply", a, b);
		long num2 = a * b;
		int num3;
		if (a != 0)
		{
			if (((a != -1) ? (num2 / a) : (-num2)) != b)
			{
				num3 = 0;
				goto IL_0083;
			}
		}
		num3 = 1;
		goto IL_0083;
		IL_0083:
		MathPreconditions.checkNoOverflow((byte)num3 != 0, "checkedMultiply", a, b);
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 17, 103, 109, 134, 101, 226, 74, 138, 159,
		25, 170, 98, 133, 98, 133, 101, 133, 101, 194,
		104, 174, 102, 159, 0, 135, 130, 139
	})]
	public static long divide(long p, long q, RoundingMode mode)
	{
		Preconditions.checkNotNull(mode);
		long num = ((q != -1) ? (p / q) : (-p));
		long num2 = p - q * num;
		if (num2 == 0)
		{
			return num;
		}
		int num3 = 1 | (int)((p ^ q) >> 63);
		int num6;
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary(num2 == 0);
			goto case 2;
		case 2:
			num6 = 0;
			break;
		case 4:
			num6 = 1;
			break;
		case 5:
			num6 = ((num3 > 0) ? 1 : 0);
			break;
		case 3:
			num6 = ((num3 < 0) ? 1 : 0);
			break;
		case 6:
		case 7:
		case 8:
		{
			long num4 = java.lang.Math.abs(num2);
			long num5 = num4 - (java.lang.Math.abs(q) - num4);
			num6 = ((num5 != 0) ? ((num5 > 0) ? 1 : 0) : ((mode == RoundingMode.HALF_UP || (mode == RoundingMode.HALF_EVEN && (num & 1) != 0)) ? 1 : 0));
			break;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
		return (num6 == 0) ? num : (num + num3);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		115, 108, 103, 104, 159, 22, 201, 162, 234, 69,
		144
	})]
	public static int log10(long x, RoundingMode mode)
	{
		MathPreconditions.checkPositive("x", x);
		int num = log10Floor(x);
		long num2 = powersOf10[num];
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary(x == num2);
			goto case 2;
		case 2:
		case 3:
			return num;
		case 4:
		case 5:
			return num + lessThanBranchFree(num2, x);
		case 6:
		case 7:
		case 8:
			return num + lessThanBranchFree(halfPowersOf10[num], x);
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 201, 108, 104, 234, 81, 141, 164, 159, 22,
		105, 162, 100, 133, 162, 100, 133, 194, 104, 230,
		76, 139
	})]
	public static long sqrt(long x, RoundingMode mode)
	{
		MathPreconditions.checkNonNegative("x", x);
		if (fitsInInt(x))
		{
			return IntMath.sqrt((int)x, mode);
		}
		long num = ByteCodeHelper.d2l(java.lang.Math.sqrt(x));
		long num2 = num * num;
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary(num2 == x);
			return num;
		case 2:
		case 3:
			if (x < num2)
			{
				return num - 1;
			}
			return num;
		case 4:
		case 5:
			if (x > num2)
			{
				return num + 1;
			}
			return num;
		case 6:
		case 7:
		case 8:
		{
			long num3 = num - ((x < num2) ? 1 : 0);
			long num4 = num3 * num3 + num3;
			return num3 + lessThanBranchFree(num4, x);
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		73, 108, 159, 22, 203, 202, 237, 70, 103, 143,
		101, 170
	})]
	public static int log2(long x, RoundingMode mode)
	{
		MathPreconditions.checkPositive("x", x);
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary(isPowerOfTwo(x));
			goto case 2;
		case 2:
		case 3:
			return 63 - Long.numberOfLeadingZeros(x);
		case 4:
		case 5:
			return 64 - Long.numberOfLeadingZeros(x - 1);
		case 6:
		case 7:
		case 8:
		{
			int num = Long.numberOfLeadingZeros(x);
			long num2 = (long)(13043817825332782212uL >> num);
			int num3 = 63 - num;
			return num3 + lessThanBranchFree(num2, x);
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("impossible");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 185, 108, 108, 115, 102, 133, 146, 131, 131,
		105, 127, 4, 115, 106, 147, 104, 102, 101, 14,
		203, 130, 141, 99, 105, 132, 227, 72, 104, 136,
		103, 104, 200, 107, 100, 101, 227, 52, 240, 79
	})]
	public static long binomial(int n, int k)
	{
		MathPreconditions.checkNonNegative("n", n);
		MathPreconditions.checkNonNegative("k", k);
		Preconditions.checkArgument(k <= n, "k (%s) > n (%s)", k, n);
		if (k > n >> 1)
		{
			k = n - k;
		}
		switch (k)
		{
		case 0:
			return 1L;
		case 1:
			return n;
		default:
		{
			if (n < (nint)factorials.LongLength)
			{
				long num = factorials[n];
				long num2 = factorials[k] * factorials[n - k];
				return (num2 != -1) ? (num / num2) : (-num);
			}
			if (k >= (nint)biggestBinomials.LongLength || n > biggestBinomials[k])
			{
				return long.MaxValue;
			}
			if (k < (nint)biggestSimpleBinomials.LongLength && n <= biggestSimpleBinomials[k])
			{
				int num3 = n;
				n += -1;
				long num4 = num3;
				for (int i = 2; i <= k; i++)
				{
					num4 *= n;
					long num5 = num4;
					long num6 = i;
					num4 = ((num6 != -1) ? (num5 / num6) : (-num5));
					n += -1;
				}
				return num4;
			}
			int num7 = log2(n, RoundingMode.CEILING);
			long num8 = 1L;
			int num9 = n;
			n += -1;
			long num10 = num9;
			long num11 = 1L;
			int num12 = num7;
			int num13 = 2;
			while (num13 <= k)
			{
				if (num12 + num7 < 63)
				{
					num10 *= n;
					num11 *= num13;
					num12 += num7;
				}
				else
				{
					num8 = multiplyFraction(num8, num10, num11);
					num10 = n;
					num11 = num13;
					num12 = num7;
				}
				num13++;
				n += -1;
			}
			long result = multiplyFraction(num8, num10, num11);
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		163, 123, 101, 108, 130, 134, 234, 84, 180, 126,
		130, 127, 28, 130, 105, 162, 116, 103, 106, 109,
		2, 232, 69, 226, 57, 230, 74
	})]
	public static bool isPrime(long n)
	{
		if (n < 2)
		{
			MathPreconditions.checkNonNegative("n", n);
			return false;
		}
		if (n < 66u)
		{
			long num = 722865708377213483L;
			return ((num >> (int)n - 2) & 1) != 0;
		}
		long num2 = 30L;
		if ((0xDF75D77Du & (uint)(1 << (int)((num2 != -1) ? (n % num2) : 0))) != 0)
		{
			return false;
		}
		long num3 = 7L;
		if (((num3 != -1) ? (n % num3) : 0) != 0)
		{
			long num4 = 11L;
			if (((num4 != -1) ? (n % num4) : 0) != 0)
			{
				long num5 = 13L;
				if (((num5 != -1) ? (n % num5) : 0) != 0)
				{
					if (n < 289u)
					{
						return true;
					}
					long[][] array = millerRabinBaseSets;
					int num6 = array.Length;
					for (int i = 0; i < num6; i++)
					{
						long[] array2 = array[i];
						if (n > array2[0])
						{
							continue;
						}
						for (int j = 1; j < (nint)array2.LongLength; j++)
						{
							if (!MillerRabinTester.test(array2[j], n))
							{
								return false;
							}
						}
						return true;
					}
					Throwable.___003CsuppressFillInStackTrace_003E();
					throw new AssertionError();
				}
			}
		}
		return false;
	}

	public static bool isPowerOfTwo(long x)
	{
		return x > 0 && (x & (x - 1)) == 0;
	}

	internal static int lessThanBranchFree(long P_0, long P_1)
	{
		return (int)((ulong)((P_0 - P_1) ^ -1 ^ -1) >> 63);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 83, 237, 69 })]
	internal static int log10Floor(long P_0)
	{
		int num = maxLog10ForLeadingZeros[Long.numberOfLeadingZeros(P_0)];
		return num - lessThanBranchFree(P_0, powersOf10[num]);
	}

	internal static bool fitsInInt(long P_0)
	{
		return (int)P_0 == P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 113, 101, 144, 111 })]
	public static long mod(long x, long m)
	{
		if (m <= 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ArithmeticException("Modulus must be positive");
		}
		long num = ((m != -1) ? (x % m) : 0);
		return (num < 0) ? (num + m) : num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 64, 97, 105, 103, 106, 103, 101, 164, 113,
		154, 130, 100, 120, 130
	})]
	public static long saturatedMultiply(long a, long b)
	{
		int num = Long.numberOfLeadingZeros(a) + Long.numberOfLeadingZeros(a ^ -1) + Long.numberOfLeadingZeros(b) + Long.numberOfLeadingZeros(b ^ -1);
		if (num > 65)
		{
			return a * b;
		}
		long result = (long)(long.MaxValue + ((ulong)(a ^ b) >> 63));
		if (num < 64 || (a < 0 && b == long.MinValue))
		{
			return result;
		}
		long num2 = a * b;
		if (a != 0)
		{
			if (((a != -1) ? (num2 / a) : (-num2)) != b)
			{
				return result;
			}
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 246, 101, 141, 104, 110, 174 })]
	internal static long multiplyFraction(long P_0, long P_1, long P_2)
	{
		if (P_0 == 1)
		{
			long num = P_2;
			return (num != -1) ? (P_1 / num) : (-P_1);
		}
		long num2 = gcd(P_0, P_2);
		long num3 = P_0;
		P_0 = ((num2 != -1) ? (num3 / num2) : (-num3));
		long num4 = P_2;
		P_2 = ((num2 != -1) ? (num4 / num2) : (-num4));
		long num5 = P_0;
		long num6 = P_2;
		return num5 * ((num6 != -1) ? (P_1 / num6) : (-P_1));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 132, 108, 108, 169, 98, 105, 226, 70, 103,
		104, 103, 104, 228, 72, 132, 167, 167, 101, 109,
		98
	})]
	public static long gcd(long a, long b)
	{
		MathPreconditions.checkNonNegative("a", a);
		MathPreconditions.checkNonNegative("b", b);
		if (a == 0)
		{
			return b;
		}
		if (b == 0)
		{
			return a;
		}
		int num = Long.numberOfTrailingZeros(a);
		a >>= num;
		int num2 = Long.numberOfTrailingZeros(b);
		b >>= num2;
		while (a != b)
		{
			long num3 = a - b;
			long num4 = num3 & (num3 >> 63);
			a = num3 - num4 - num4;
			b += num4;
			a >>= Long.numberOfTrailingZeros(a);
		}
		return a << java.lang.Math.min(num, num2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 19, 108, 108, 159, 22 })]
	public static long ceilingPowerOfTwo(long x)
	{
		MathPreconditions.checkPositive("x", x);
		if (x > 4611686018427387904L)
		{
			int num = 70;
			num = num;
			string s = new StringBuilder(num).append("ceilingPowerOfTwo(").append(x).append(") is not representable as a long")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ArithmeticException(s);
		}
		return 1L << -Long.numberOfLeadingZeros(x - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 35, 204 })]
	public static long floorPowerOfTwo(long x)
	{
		MathPreconditions.checkPositive("x", x);
		return 1L << 63 - Long.numberOfLeadingZeros(x);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 157, 108, 113, 159, 1, 138, 131, 140, 145,
		101, 151, 163, 171, 99, 146, 130, 132, 109, 229,
		56
	})]
	public static long pow(long b, int k)
	{
		MathPreconditions.checkNonNegative("exponent", k);
		if (-2 <= b && b <= 2)
		{
			switch (b)
			{
			case 0L:
				return (k != 0) ? 0 : 1;
			case 1L:
				return 1L;
			case -1L:
				return (((uint)k & (true ? 1u : 0u)) != 0) ? (-1) : 1;
			case 2L:
				return (k >= 64) ? 0 : (1L << k);
			case -2L:
				if (k < 64)
				{
					return (((uint)k & (true ? 1u : 0u)) != 0) ? (-(1L << k)) : (1L << k);
				}
				return 0L;
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}
		long num = 1L;
		while (true)
		{
			switch (k)
			{
			case 0:
				return num;
			case 1:
				return num * b;
			}
			num *= ((((uint)k & (true ? 1u : 0u)) != 0) ? b : 1);
			b *= b;
			k >>= 1;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(460)]
	public static int mod(long x, int m)
	{
		return (int)mod(x, (long)m);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 178, 100, 126 })]
	public static long checkedAdd(long a, long b)
	{
		long num = a + b;
		MathPreconditions.checkNoOverflow((a ^ b) < 0 || (a ^ num) >= 0, "checkedAdd", a, b);
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 190, 100, 127, 2 })]
	public static long checkedSubtract(long a, long b)
	{
		long num = a - b;
		MathPreconditions.checkNoOverflow((a ^ b) >= 0 || (a ^ num) >= 0, "checkedSubtract", a, b);
		return num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 235, 108, 119, 159, 1, 138, 131, 140, 114,
		136, 114, 150, 171, 131, 146, 130, 138, 101, 136,
		101, 100, 159, 7
	})]
	public static long checkedPow(long b, int k)
	{
		MathPreconditions.checkNonNegative("exponent", k);
		if (b >= -2 && b <= 2)
		{
			switch (b)
			{
			case 0L:
				return (k != 0) ? 0 : 1;
			case 1L:
				return 1L;
			case -1L:
				return (((uint)k & (true ? 1u : 0u)) != 0) ? (-1) : 1;
			case 2L:
				MathPreconditions.checkNoOverflow(k < 63, "checkedPow", b, k);
				return 1L << k;
			case -2L:
				MathPreconditions.checkNoOverflow(k < 64, "checkedPow", b, k);
				return (((uint)k & (true ? 1u : 0u)) != 0) ? (-1L << k) : (1L << k);
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}
		long num = 1L;
		while (true)
		{
			switch (k)
			{
			case 0:
				return num;
			case 1:
			{
				long result = checkedMultiply(num, b);
				_ = null;
				return result;
			}
			}
			if (((uint)k & (true ? 1u : 0u)) != 0)
			{
				num = checkedMultiply(num, b);
			}
			k >>= 1;
			if (k > 0)
			{
				MathPreconditions.checkNoOverflow((-3037000499L <= b && b <= 3037000499u) ? true : false, "checkedPow", b, k);
				b *= b;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 93, 108, 119, 159, 1, 138, 131, 140, 101,
		138, 136, 101, 143, 150, 171, 131, 148, 146, 130,
		138, 101, 136, 101, 100, 120, 130
	})]
	public static long saturatedPow(long b, int k)
	{
		MathPreconditions.checkNonNegative("exponent", k);
		if (b >= -2 && b <= 2)
		{
			switch (b)
			{
			case 0L:
				return (k != 0) ? 0 : 1;
			case 1L:
				return 1L;
			case -1L:
				return (((uint)k & (true ? 1u : 0u)) != 0) ? (-1) : 1;
			case 2L:
				if (k >= 63)
				{
					return long.MaxValue;
				}
				return 1L << k;
			case -2L:
				if (k >= 64)
				{
					return long.MaxValue + (k & 1);
				}
				return (((uint)k & (true ? 1u : 0u)) != 0) ? (-1L << k) : (1L << k);
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError();
			}
		}
		long num = 1L;
		long result = (long)(long.MaxValue + (((ulong)b >> 63) & (ulong)(k & 1)));
		while (true)
		{
			switch (k)
			{
			case 0:
				return num;
			case 1:
			{
				long result2 = saturatedMultiply(num, b);
				_ = null;
				return result2;
			}
			}
			if (((uint)k & (true ? 1u : 0u)) != 0)
			{
				num = saturatedMultiply(num, b);
			}
			k >>= 1;
			if (k > 0)
			{
				if (-3037000499L > b || b > 3037000499u)
				{
					return result;
				}
				b *= b;
			}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 162, 150, 108 })]
	public static long factorial(int n)
	{
		MathPreconditions.checkNonNegative("n", n);
		return (n >= (nint)factorials.LongLength) ? long.MaxValue : factorials[n];
	}

	public static long mean(long x, long y)
	{
		return (x & y) + ((x ^ y) >> 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		164, 111, 99, 167, 236, 75, 132, 168, 159, 25,
		108, 130, 100, 99, 8, 193, 144, 101, 100, 99,
		8, 193, 176, 101, 144, 100, 99, 8, 225, 77,
		100, 98, 99, 105, 144, 99, 99, 104, 173, 102,
		134, 173, 167, 107, 101, 98, 101, 163, 159, 2,
		109, 99, 2, 193, 139, 139, 208
	})]
	public static double roundToDouble(long x, RoundingMode mode)
	{
		double num = x;
		long num2 = ByteCodeHelper.d2l(num);
		int num3 = ((num2 != long.MaxValue) ? Longs.compare(x, num2) : (-1));
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary((num3 == 0) ? true : false);
			return num;
		case 3:
		{
			double result = ((num3 < 0) ? DoubleUtils.nextDown(num) : num);
			_ = null;
			return result;
		}
		case 5:
		{
			double result6 = ((num3 > 0) ? java.lang.Math.nextUp(num) : num);
			_ = null;
			return result6;
		}
		case 2:
		{
			if (x < 0)
			{
				double result2 = ((num3 > 0) ? java.lang.Math.nextUp(num) : num);
				_ = null;
				return result2;
			}
			double result3 = ((num3 < 0) ? DoubleUtils.nextDown(num) : num);
			_ = null;
			return result3;
		}
		case 4:
		{
			if (x < 0)
			{
				double result4 = ((num3 < 0) ? DoubleUtils.nextDown(num) : num);
				_ = null;
				return result4;
			}
			double result5 = ((num3 > 0) ? java.lang.Math.nextUp(num) : num);
			_ = null;
			return result5;
		}
		case 6:
		case 7:
		case 8:
		{
			double num4;
			long num5;
			double num6;
			long num7;
			if (num3 >= 0)
			{
				num4 = num;
				num5 = num2;
				num6 = java.lang.Math.nextUp(num);
				num7 = ByteCodeHelper.d2l(java.lang.Math.ceil(num6));
			}
			else
			{
				num6 = num;
				num7 = num2;
				num4 = DoubleUtils.nextDown(num);
				num5 = ByteCodeHelper.d2l(java.lang.Math.floor(num4));
			}
			long a = x - num5;
			long num8 = num7 - x;
			if (num7 == long.MaxValue)
			{
				num8++;
			}
			int num9 = Longs.compare(a, num8);
			if (num9 < 0)
			{
				return num4;
			}
			if (num9 > 0)
			{
				return num6;
			}
			switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
			{
			case 8:
				return ((DoubleUtils.getSignificand(num4) & 1) != 0) ? num6 : num4;
			case 6:
				return (x < 0) ? num6 : num4;
			case 7:
				return (x < 0) ? num4 : num6;
			default:
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new AssertionError("impossible");
			}
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError("impossible");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(1349)]
	private LongMath()
	{
	}

	[LineNumberTable(new byte[]
	{
		160,
		93,
		byte.MaxValue,
		161,
		7,
		72,
		byte.MaxValue,
		160,
		115,
		89,
		byte.MaxValue,
		160,
		118,
		162,
		28,
		byte.MaxValue,
		160,
		120,
		160,
		106,
		byte.MaxValue,
		160,
		157,
		106,
		byte.MaxValue,
		160,
		136,
		160,
		136
	})]
	static LongMath()
	{
		maxLog10ForLeadingZeros = new byte[64]
		{
			19, 18, 18, 18, 18, 17, 17, 17, 16, 16,
			16, 15, 15, 15, 15, 14, 14, 14, 13, 13,
			13, 12, 12, 12, 12, 11, 11, 11, 10, 10,
			10, 9, 9, 9, 9, 8, 8, 8, 7, 7,
			7, 6, 6, 6, 6, 5, 5, 5, 4, 4,
			4, 3, 3, 3, 3, 2, 2, 2, 1, 1,
			1, 0, 0, 0
		};
		powersOf10 = new long[19]
		{
			1L, 10L, 100L, 1000L, 10000L, 100000L, 1000000L, 10000000L, 100000000L, 1000000000L,
			10000000000L, 100000000000L, 1000000000000L, 10000000000000L, 100000000000000L, 1000000000000000L, 10000000000000000L, 100000000000000000L, 1000000000000000000L
		};
		halfPowersOf10 = new long[19]
		{
			3L, 31L, 316L, 3162L, 31622L, 316227L, 3162277L, 31622776L, 316227766L, 3162277660L,
			31622776601L, 316227766016L, 3162277660168L, 31622776601683L, 316227766016837L, 3162277660168379L, 31622776601683793L, 316227766016837933L, 3162277660168379331L
		};
		factorials = new long[21]
		{
			1L, 1L, 2L, 6L, 24L, 120L, 720L, 5040L, 40320L, 362880L,
			3628800L, 39916800L, 479001600L, 6227020800L, 87178291200L, 1307674368000L, 20922789888000L, 355687428096000L, 6402373705728000L, 121645100408832000L,
			2432902008176640000L
		};
		biggestBinomials = new int[34]
		{
			2147483647, 2147483647, 2147483647, 3810779, 121977, 16175, 4337, 1733, 887, 534,
			361, 265, 206, 169, 143, 125, 111, 101, 94, 88,
			83, 79, 76, 74, 72, 70, 69, 68, 67, 67,
			66, 66, 66, 66
		};
		biggestSimpleBinomials = new int[31]
		{
			2147483647, 2147483647, 2147483647, 2642246, 86251, 11724, 3218, 1313, 684, 419,
			287, 214, 169, 139, 119, 105, 95, 87, 81, 76,
			73, 70, 68, 66, 64, 63, 62, 62, 61, 61,
			61
		};
		millerRabinBaseSets = new long[7][]
		{
			new long[2] { 291830L, 126401071349994536L },
			new long[3] { 885594168L, 725270293939359937L, 3569819667048198375L },
			new long[4] { 273919523040L, 15L, 7363882082L, 992620450144556L },
			new long[5] { 47636622961200L, 2L, 2570940L, 211991001L, 3749873356L },
			new long[6] { 7999252175582850L, 2L, 4130806001517L, 149795463772692060L, 186635894390467037L, 3967304179347715805L },
			new long[7] { 585226005592931976L, 2L, 123635709730000L, 9233062284813009L, 43835965440333360L, 761179012939631437L, 1263739024124850375L },
			new long[8] { 9223372036854775807L, 2L, 325L, 9375L, 28178L, 450775L, 9780504L, 1795265022L }
		};
	}
}
