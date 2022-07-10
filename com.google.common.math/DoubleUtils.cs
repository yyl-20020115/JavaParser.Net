using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using IKVM.Runtime;
using java.lang;
using java.math;

namespace com.google.common.math;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
internal sealed class DoubleUtils : Object
{
	internal const long SIGNIFICAND_MASK = 4503599627370495L;

	internal const long EXPONENT_MASK = 9218868437227405312L;

	internal const long SIGN_MASK = long.MinValue;

	internal const int SIGNIFICAND_BITS = 52;

	internal const int EXPONENT_BIAS = 1023;

	internal const long IMPLICIT_BIT = 4503599627370496L;

	internal const long ONE_BITS = 4607182418800017408L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(41)]
	internal static double nextDown(double P_0)
	{
		return 0.0 - Math.nextUp(0.0 - P_0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		40, 103, 137, 101, 104, 104, 242, 75, 103, 109,
		101, 238, 71, 114, 110, 111, 109, 231, 71, 118
	})]
	internal static double bigToDouble(BigInteger P_0)
	{
		BigInteger bigInteger = P_0.abs();
		int num = bigInteger.bitLength() - 1;
		if (num < 63)
		{
			return P_0.longValue();
		}
		if (num > 1023)
		{
			return (double)P_0.signum() * double.PositiveInfinity;
		}
		int num2 = num - 52 - 1;
		long num3 = bigInteger.shiftRight(num2).longValue();
		long num4 = num3 >> 1;
		num4 &= 0xFFFFFFFFFFFFFL;
		long num5 = ((((num3 & 1) == 0 || ((num4 & 1) == 0 && bigInteger.getLowestSetBit() >= num2)) && 0 == 0) ? num4 : (num4 + 1));
		long num6 = (long)(num + 1023) << 52;
		num6 += num5;
		num6 |= P_0.signum() & long.MinValue;
		DoubleConverter converter = default(DoubleConverter);
		double result = DoubleConverter.ToDouble(num6, ref converter);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(72)]
	internal static bool isFinite(double P_0)
	{
		return Math.getExponent(P_0) <= 1023;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 14, 113, 104, 106, 108 })]
	internal static long getSignificand(double P_0)
	{
		Preconditions.checkArgument(isFinite(P_0), (object)"not a normal value");
		int exponent = Math.getExponent(P_0);
		DoubleConverter converter = default(DoubleConverter);
		long num = DoubleConverter.ToLong(P_0, ref converter);
		num &= 0xFFFFFFFFFFFFFL;
		return (exponent != -1023) ? (num | 0x10000000000000L) : (num << 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(76)]
	internal static bool isNormal(double P_0)
	{
		return Math.getExponent(P_0) >= -1022;
	}

	[LineNumberTable(new byte[] { 34, 116 })]
	internal static double scaleNormalize(double P_0)
	{
		DoubleConverter converter = default(DoubleConverter);
		long num = DoubleConverter.ToLong(P_0, ref converter) & 0xFFFFFFFFFFFFFL;
		double result = DoubleConverter.ToDouble(num | 0x3FF0000000000000L, ref converter);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(38)]
	private DoubleUtils()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 84, 114 })]
	internal static double ensureNonNegative(double P_0)
	{
		Preconditions.checkArgument((!Double.isNaN(P_0)) ? true : false);
		double result = Math.max(P_0, 0.0);
		_ = null;
		return result;
	}
}
