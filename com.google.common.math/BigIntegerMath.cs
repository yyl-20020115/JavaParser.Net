using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.math;
using java.util;

namespace com.google.common.math;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
public sealed class BigIntegerMath : java.lang.Object
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

		[LineNumberTable(95)]
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

	[InnerClass(null, Modifiers.Private | Modifiers.Static)]
	[Signature("Lcom/google/common/math/ToDoubleRounder<Ljava/math/BigInteger;>;")]
	internal class BigIntegerToDoubleRounder : ToDoubleRounder
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static BigIntegerToDoubleRounder INSTANCE;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(361)]
		internal virtual BigInteger minus(BigInteger P_0, BigInteger P_1)
		{
			BigInteger result = P_0.subtract(P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(356)]
		internal new virtual BigInteger toX(double P_0, RoundingMode P_1)
		{
			BigInteger result = DoubleMath.roundToBigInteger(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(351)]
		internal virtual int sign(BigInteger P_0)
		{
			int result = P_0.signum();
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(346)]
		internal virtual double roundToDoubleArbitrarily(BigInteger P_0)
		{
			double result = DoubleUtils.bigToDouble(P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(342)]
		private BigIntegerToDoubleRounder()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(338)]
		internal override Number minus(Number P_0, Number P_1)
		{
			BigInteger result = minus((BigInteger)P_0, (BigInteger)P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(338)]
		internal override Number toX(double P_0, RoundingMode P_1)
		{
			BigInteger result = toX(P_0, P_1);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(338)]
		internal override int sign(Number P_0)
		{
			int result = sign((BigInteger)P_0);
			_ = null;
			return result;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(338)]
		internal override double roundToDoubleArbitrarily(Number P_0)
		{
			double result = roundToDoubleArbitrarily((BigInteger)P_0);
			_ = null;
			return result;
		}

		[LineNumberTable(340)]
		static BigIntegerToDoubleRounder()
		{
			INSTANCE = new BigIntegerToDoubleRounder();
		}
	}

	internal const int SQRT2_PRECOMPUTE_THRESHOLD = 256;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static BigInteger SQRT2_PRECOMPUTED_BITS;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static double LN_10;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static double LN_2;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		43, 118, 105, 159, 25, 171, 194, 239, 69, 104,
		108, 102, 106, 130, 228, 71, 104, 105, 175
	})]
	public static int log2(BigInteger x, RoundingMode mode)
	{
		MathPreconditions.checkPositive("x", (BigInteger)Preconditions.checkNotNull(x));
		int num = x.bitLength() - 1;
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary(isPowerOfTwo(x));
			goto case 2;
		case 2:
		case 3:
			return num;
		case 4:
		case 5:
			return (!isPowerOfTwo(x)) ? (num + 1) : num;
		case 6:
		case 7:
		case 8:
		{
			BigInteger val;
			if (num < 256)
			{
				val = SQRT2_PRECOMPUTED_BITS.shiftRight(256 - num);
				if (x.compareTo(val) <= 0)
				{
					return num;
				}
				return num + 1;
			}
			val = x.pow(2);
			int num2 = val.bitLength() - 1;
			return (num2 >= 2 * num + 1) ? (num + 1) : num;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 29, 103 })]
	public static bool isPowerOfTwo(BigInteger x)
	{
		Preconditions.checkNotNull(x);
		return (x.signum() > 0 && x.getLowestSetBit() == x.bitLength() - 1) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(526)]
	internal static bool fitsInLong(BigInteger P_0)
	{
		return P_0.bitLength() <= 63;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 171, 108, 104, 137, 232, 69, 149, 116, 105,
		162, 98, 116, 106
	})]
	private static BigInteger sqrtFloor(BigInteger P_0)
	{
		int num = log2(P_0, RoundingMode.FLOOR);
		BigInteger bigInteger;
		if (num < 1023)
		{
			bigInteger = sqrtApproxWithDoubles(P_0);
		}
		else
		{
			int num2 = (num - 52) & -2;
			bigInteger = sqrtApproxWithDoubles(P_0.shiftRight(num2)).shiftLeft(num2 >> 1);
		}
		BigInteger bigInteger2 = bigInteger.add(P_0.divide(bigInteger)).shiftRight(1);
		if (bigInteger.equals(bigInteger2))
		{
			return bigInteger;
		}
		do
		{
			bigInteger = bigInteger2;
			bigInteger2 = bigInteger.add(P_0.divide(bigInteger)).shiftRight(1);
		}
		while (bigInteger2.compareTo(bigInteger) < 0);
		return bigInteger;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(309)]
	private static BigInteger sqrtApproxWithDoubles(BigInteger P_0)
	{
		BigInteger result = DoubleMath.roundToBigInteger(java.lang.Math.sqrt(DoubleUtils.bigToDouble(P_0)), RoundingMode.HALF_EVEN);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<Ljava/math/BigInteger;>;)Ljava/math/BigInteger;")]
	[LineNumberTable(447)]
	internal static BigInteger listProduct(List P_0)
	{
		BigInteger result = listProduct(P_0, 0, P_0.size());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("(Ljava/util/List<Ljava/math/BigInteger;>;II)Ljava/math/BigInteger;")]
	[LineNumberTable(new byte[] { 161, 81, 154, 134, 141, 159, 3, 191, 22, 102 })]
	internal static BigInteger listProduct(List P_0, int P_1, int P_2)
	{
		switch (P_2 - P_1)
		{
		case 0:
			return BigInteger.ONE;
		case 1:
			return (BigInteger)P_0.get(P_1);
		case 2:
		{
			BigInteger result3 = ((BigInteger)P_0.get(P_1)).multiply((BigInteger)P_0.get(P_1 + 1));
			_ = null;
			return result3;
		}
		case 3:
		{
			BigInteger result2 = ((BigInteger)P_0.get(P_1)).multiply((BigInteger)P_0.get(P_1 + 1)).multiply((BigInteger)P_0.get(P_1 + 2));
			_ = null;
			return result2;
		}
		default:
		{
			int num = (int)((uint)(P_2 + P_1) >> 1);
			BigInteger result = listProduct(P_0, P_1, num).multiply(listProduct(P_0, num, P_2));
			_ = null;
			return result;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(62)]
	public static BigInteger ceilingPowerOfTwo(BigInteger x)
	{
		BigInteger result = BigInteger.ZERO.setBit(log2(x, RoundingMode.CEILING));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(74)]
	public static BigInteger floorPowerOfTwo(BigInteger x)
	{
		BigInteger result = BigInteger.ZERO.setBit(log2(x, RoundingMode.FLOOR));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		102, 108, 104, 175, 126, 108, 232, 71, 228, 71,
		100, 108, 104, 134, 108, 105, 101, 100, 98, 99,
		108, 203, 99, 99, 131, 159, 25, 205, 195, 243,
		70, 105, 116, 149
	})]
	public static int log10(BigInteger x, RoundingMode mode)
	{
		MathPreconditions.checkPositive("x", x);
		if (fitsInLong(x))
		{
			int result = LongMath.log10(x.longValue(), mode);
			_ = null;
			return result;
		}
		int num = ByteCodeHelper.d2i((double)log2(x, RoundingMode.FLOOR) * LN_2 / LN_10);
		BigInteger bigInteger = BigInteger.TEN.pow(num);
		int num2 = bigInteger.compareTo(x);
		if (num2 > 0)
		{
			do
			{
				num += -1;
				bigInteger = bigInteger.divide(BigInteger.TEN);
				num2 = bigInteger.compareTo(x);
			}
			while (num2 > 0);
		}
		else
		{
			BigInteger bigInteger2 = BigInteger.TEN.multiply(bigInteger);
			for (int num3 = bigInteger2.compareTo(x); num3 <= 0; num3 = bigInteger2.compareTo(x))
			{
				num++;
				bigInteger = bigInteger2;
				num2 = num3;
				bigInteger2 = BigInteger.TEN.multiply(bigInteger);
			}
		}
		int num4 = num;
		BigInteger bigInteger3 = bigInteger;
		int num5 = num2;
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary((num5 == 0) ? true : false);
			goto case 2;
		case 2:
		case 3:
			return num4;
		case 4:
		case 5:
			return (!bigInteger3.equals(x)) ? (num4 + 1) : num4;
		case 6:
		case 7:
		case 8:
		{
			BigInteger bigInteger4 = x.pow(2);
			BigInteger val = bigInteger3.pow(2).multiply(BigInteger.TEN);
			return (bigInteger4.compareTo(val) > 0) ? (num4 + 1) : num4;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 116, 108, 104, 148, 103, 159, 25, 178, 162,
		103, 100, 105, 114, 212, 238, 70, 155
	})]
	public static BigInteger sqrt(BigInteger x, RoundingMode mode)
	{
		MathPreconditions.checkNonNegative("x", x);
		if (fitsInLong(x))
		{
			BigInteger result = BigInteger.valueOf(LongMath.sqrt(x.longValue(), mode));
			_ = null;
			return result;
		}
		BigInteger bigInteger = sqrtFloor(x);
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary(bigInteger.pow(2).equals(x));
			goto case 2;
		case 2:
		case 3:
			return bigInteger;
		case 4:
		case 5:
		{
			int num = bigInteger.intValue();
			BigInteger result3 = (((num * num != x.intValue() || !bigInteger.pow(2).equals(x)) && 0 == 0) ? bigInteger.add(BigInteger.ONE) : bigInteger);
			_ = null;
			return result3;
		}
		case 6:
		case 7:
		case 8:
		{
			BigInteger bigInteger2 = bigInteger.pow(2).add(bigInteger);
			BigInteger result2 = ((bigInteger2.compareTo(x) < 0) ? bigInteger.add(BigInteger.ONE) : bigInteger);
			_ = null;
			return result2;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(335)]
	public static double roundToDouble(BigInteger x, RoundingMode mode)
	{
		double result = BigIntegerToDoubleRounder.INSTANCE.roundToDouble(x, mode);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 4, 103, 103 })]
	public static BigInteger divide(BigInteger p, BigInteger q, RoundingMode mode)
	{
		BigDecimal bigDecimal = new BigDecimal(p);
		BigDecimal divisor = new BigDecimal(q);
		BigInteger result = bigDecimal.divide(divisor, 0, mode).toBigIntegerExact();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 22, 172, 105, 207, 122, 167, 103, 138, 104,
		168, 111, 144, 171, 141, 106, 102, 166, 105, 106,
		135, 135, 105, 109, 99, 130, 101, 239, 45, 236,
		86, 101, 173
	})]
	public static BigInteger factorial(int n)
	{
		MathPreconditions.checkNonNegative("n", n);
		if (n < (nint)LongMath.factorials.LongLength)
		{
			BigInteger result = BigInteger.valueOf(LongMath.factorials[n]);
			_ = null;
			return result;
		}
		int initialCapacity = IntMath.divide(n * IntMath.log2(n, RoundingMode.CEILING), 64, RoundingMode.CEILING);
		ArrayList arrayList = new ArrayList(initialCapacity);
		int num = LongMath.factorials.Length;
		long num2 = LongMath.factorials[num - 1];
		int num3 = Long.numberOfTrailingZeros(num2);
		num2 >>= num3;
		int num4 = LongMath.log2(num2, RoundingMode.FLOOR) + 1;
		int num5 = LongMath.log2(num, RoundingMode.FLOOR) + 1;
		int num6 = 1 << num5 - 1;
		for (long num7 = num; num7 <= n; num7++)
		{
			if ((num7 & num6) != 0)
			{
				num6 <<= 1;
				num5++;
			}
			int num8 = Long.numberOfTrailingZeros(num7);
			long num9 = num7 >> num8;
			num3 += num8;
			int num10 = num5 - num8;
			if (num10 + num4 >= 64)
			{
				arrayList.add(BigInteger.valueOf(num2));
				num2 = 1L;
				_ = 0;
			}
			num2 *= num9;
			num4 = LongMath.log2(num2, RoundingMode.FLOOR) + 1;
		}
		if (num2 > 1)
		{
			arrayList.add(BigInteger.valueOf(num2));
		}
		BigInteger result2 = listProduct(arrayList).shiftLeft(num3);
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 106, 108, 108, 115, 102, 133, 115, 175, 134,
		99, 131, 141, 131, 107, 102, 198, 168, 130, 107,
		107, 100, 100, 165, 102, 102, 230, 44, 235, 87,
		98, 107, 12
	})]
	public static BigInteger binomial(int n, int k)
	{
		MathPreconditions.checkNonNegative("n", n);
		MathPreconditions.checkNonNegative("k", k);
		Preconditions.checkArgument(k <= n, "k (%s) > n (%s)", k, n);
		if (k > n >> 1)
		{
			k = n - k;
		}
		if (k < (nint)LongMath.biggestBinomials.LongLength && n <= LongMath.biggestBinomials[k])
		{
			BigInteger result = BigInteger.valueOf(LongMath.binomial(n, k));
			_ = null;
			return result;
		}
		BigInteger bigInteger = BigInteger.ONE;
		long num = n;
		long num2 = 1L;
		int num3 = LongMath.log2(n, RoundingMode.CEILING);
		int num4 = num3;
		for (int i = 1; i < k; i++)
		{
			int num5 = n - i;
			int num6 = i + 1;
			if (num4 + num3 >= 63)
			{
				bigInteger = bigInteger.multiply(BigInteger.valueOf(num)).divide(BigInteger.valueOf(num2));
				num = num5;
				num2 = num6;
				num4 = num3;
			}
			else
			{
				num *= num5;
				num2 *= num6;
				num4 += num3;
			}
		}
		BigInteger result2 = bigInteger.multiply(BigInteger.valueOf(num)).divide(BigInteger.valueOf(num2));
		_ = null;
		return result2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(529)]
	private BigIntegerMath()
	{
	}

	[LineNumberTable(new byte[] { 89, 241, 160, 78, 116 })]
	static BigIntegerMath()
	{
		SQRT2_PRECOMPUTED_BITS = new BigInteger("16a09e667f3bcc908b2fb1366ea957d3e3adec17512775099da2f590b0667322a", 16);
		LN_10 = java.lang.Math.log(10.0);
		LN_2 = java.lang.Math.log(2.0);
	}
}
