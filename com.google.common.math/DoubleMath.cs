using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
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
public sealed class DoubleMath : java.lang.Object
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

		[LineNumberTable(60)]
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.FLOOR.ordinal()] = 2;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.CEILING.ordinal()] = 3;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.DOWN.ordinal()] = 4;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.UP.ordinal()] = 5;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.HALF_EVEN.ordinal()] = 6;
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
				_0024SwitchMap_0024java_0024math_0024RoundingMode[RoundingMode.HALF_DOWN.ordinal()] = 8;
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

	private const double MIN_INT_AS_DOUBLE = -2147483648.0;

	private const double MAX_INT_AS_DOUBLE = 2147483647.0;

	private const double MIN_LONG_AS_DOUBLE = -9.223372036854776E+18;

	private const double MAX_LONG_AS_DOUBLE_PLUS_ONE = 9.223372036854776E+18;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static double LN_2;

	internal const int MAX_FACTORIAL = 170;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static double[] everySixteenthFactorial;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 108, 106, 159, 8 })]
	public static long roundToLong(double x, RoundingMode mode)
	{
		double num = roundIntermediate(x, mode);
		MathPreconditions.checkInRangeForRoundingInputs(-9.223372036854776E+18 - num < 1.0 && num < 9.223372036854776E+18, x, mode);
		return ByteCodeHelper.d2l(num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 71, 107, 127, 4, 143, 104, 104, 112 })]
	public static BigInteger roundToBigInteger(double x, RoundingMode mode)
	{
		x = roundIntermediate(x, mode);
		if (-9.223372036854776E+18 - x < 1.0 && x < 9.223372036854776E+18)
		{
			BigInteger result = BigInteger.valueOf(ByteCodeHelper.d2l(x));
			_ = null;
			return result;
		}
		int exponent = java.lang.Math.getExponent(x);
		long significand = DoubleUtils.getSignificand(x);
		BigInteger bigInteger = BigInteger.valueOf(significand).shiftLeft(exponent - 52);
		return (!(x < 0.0)) ? bigInteger : bigInteger.negate();
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 174, 150, 24 })]
	public static bool isMathematicalInteger(double x)
	{
		return (DoubleUtils.isFinite(x) && (x == 0.0 || 52 - Long.numberOfTrailingZeros(DoubleUtils.getSignificand(x)) <= java.lang.Math.getExponent(x))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		7, 105, 144, 159, 25, 108, 163, 114, 131, 204,
		114, 131, 204, 163, 105, 131, 216, 202, 105, 116,
		148, 226, 70, 105, 116, 131, 226, 69
	})]
	internal static double roundIntermediate(double P_0, RoundingMode P_1)
	{
		if (!DoubleUtils.isFinite(P_0))
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ArithmeticException("input is infinite or NaN");
		}
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[P_1.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary(isMathematicalInteger(P_0));
			return P_0;
		case 2:
			if (P_0 >= 0.0 || isMathematicalInteger(P_0))
			{
				return P_0;
			}
			return ByteCodeHelper.d2l(P_0) - 1;
		case 3:
			if (P_0 <= 0.0 || isMathematicalInteger(P_0))
			{
				return P_0;
			}
			return ByteCodeHelper.d2l(P_0) + 1;
		case 4:
			return P_0;
		case 5:
			if (isMathematicalInteger(P_0))
			{
				return P_0;
			}
			return ByteCodeHelper.d2l(P_0) + ((P_0 > 0.0) ? 1 : (-1));
		case 6:
		{
			double result = java.lang.Math.rint(P_0);
			_ = null;
			return result;
		}
		case 7:
		{
			double num = java.lang.Math.rint(P_0);
			if (java.lang.Math.abs(P_0 - num) == 0.5)
			{
				return P_0 + java.lang.Math.copySign(0.5, P_0);
			}
			return num;
		}
		case 8:
		{
			double num = java.lang.Math.rint(P_0);
			if (java.lang.Math.abs(P_0 - num) == 0.5)
			{
				return P_0;
			}
			return num;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 126, 127, 1, 104, 105, 246, 69, 159, 25,
		172, 98, 133, 110, 133, 115, 130, 118, 194, 169,
		111, 130, 139
	})]
	public static int log2(double x, RoundingMode mode)
	{
		Preconditions.checkArgument((x > 0.0 && DoubleUtils.isFinite(x)) ? true : false, (object)"x must be positive and finite");
		int exponent = java.lang.Math.getExponent(x);
		if (!DoubleUtils.isNormal(x))
		{
			return log2(x * 4503599627370496.0, mode) - 52;
		}
		int num2;
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary(isPowerOfTwo(x));
			goto case 2;
		case 2:
			num2 = 0;
			break;
		case 3:
			num2 = ((!isPowerOfTwo(x)) ? 1 : 0);
			break;
		case 4:
			num2 = ((exponent < 0) ? 1 : 0) & ((!isPowerOfTwo(x)) ? 1 : 0);
			break;
		case 5:
			num2 = ((exponent >= 0) ? 1 : 0) & ((!isPowerOfTwo(x)) ? 1 : 0);
			break;
		case 6:
		case 7:
		case 8:
		{
			double num = DoubleUtils.scaleNormalize(x);
			num2 = ((num * num > 2.0) ? 1 : 0);
			break;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
		return (num2 == 0) ? exponent : (exponent + 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 87, 114, 104, 139 })]
	public static bool isPowerOfTwo(double x)
	{
		if (x > 0.0 && DoubleUtils.isFinite(x))
		{
			long significand = DoubleUtils.getSignificand(x);
			return (significand & (significand - 1)) == 0;
		}
		return false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 247, 109, 187, 244, 61 })]
	public static bool fuzzyEquals(double a, double b, double tolerance)
	{
		MathPreconditions.checkNonNegative("tolerance", tolerance);
		return (java.lang.Math.copySign(a - b, 1.0) <= tolerance || a == b || (java.lang.Double.isNaN(a) && java.lang.Double.isNaN(b))) ? true : false;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 154, 108 })]
	private static double checkFinite(double P_0)
	{
		Preconditions.checkArgument(DoubleUtils.isFinite(P_0));
		return P_0;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/util/Iterator<+Ljava/lang/Number;>;)D")]
	[LineNumberTable(new byte[] { 161, 139, 112, 99, 119, 104, 119, 133, 106, 98 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static double mean(Iterator values)
	{
		Preconditions.checkArgument(values.hasNext(), (object)"Cannot take mean of 0 values");
		long num = 1L;
		double num2 = checkFinite(((Number)values.next()).doubleValue());
		while (values.hasNext())
		{
			double num3 = checkFinite(((Number)values.next()).doubleValue());
			num++;
			num2 += (num3 - num2) / (double)num;
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 83, 106, 159, 2 })]
	public static int roundToInt(double x, RoundingMode mode)
	{
		double num = roundIntermediate(x, mode);
		MathPreconditions.checkInRangeForRoundingInputs(num > -2147483649.0 && num < 2147483648.0, x, mode);
		return ByteCodeHelper.d2i(num);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(225)]
	public static double log2(double x)
	{
		return java.lang.Math.log(x) / LN_2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 189, 108, 104, 202, 102, 107, 38, 166 })]
	public static double factorial(int n)
	{
		MathPreconditions.checkNonNegative("n", n);
		if (n > 170)
		{
			return double.PositiveInfinity;
		}
		double num = 1.0;
		for (int i = 1 + (n & -16); i <= n; i++)
		{
			num *= (double)i;
		}
		return num * everySixteenthFactorial[n >> 4];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 12, 109, 98, 102, 98, 102, 130 })]
	public static int fuzzyCompare(double a, double b, double tolerance)
	{
		if (fuzzyEquals(a, b, tolerance))
		{
			return 0;
		}
		if (a < b)
		{
			return -1;
		}
		if (a > b)
		{
			return 1;
		}
		int result = Booleans.compare(java.lang.Double.isNaN(a), java.lang.Double.isNaN(b));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(new byte[]
	{
		161, 39, 111, 99, 106, 103, 105, 133, 236, 60,
		230, 70
	})]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static double mean(params double[] values)
	{
		Preconditions.checkArgument((nint)values.LongLength > 0, (object)"Cannot take mean of 0 values");
		long num = 1L;
		double num2 = checkFinite(values[0]);
		for (int i = 1; i < (nint)values.LongLength; i++)
		{
			checkFinite(values[i]);
			num++;
			num2 += (values[i] - num2) / (double)num;
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(new byte[] { 161, 65, 207, 99, 103, 39, 166 })]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static double mean(params int[] values)
	{
		Preconditions.checkArgument((nint)values.LongLength > 0, (object)"Cannot take mean of 0 values");
		long num = 0L;
		for (int i = 0; i < (nint)values.LongLength; i++)
		{
			num += values[i];
		}
		return (double)num / (double)(nint)values.LongLength;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[LineNumberTable(new byte[]
	{
		161, 91, 111, 99, 101, 103, 133, 237, 61, 230,
		69
	})]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static double mean(params long[] values)
	{
		Preconditions.checkArgument((nint)values.LongLength > 0, (object)"Cannot take mean of 0 values");
		long num = 1L;
		double num2 = values[0];
		for (int i = 1; i < (nint)values.LongLength; i++)
		{
			num++;
			num2 += ((double)values[i] - num2) / (double)num;
		}
		return num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Obsolete]
	[Signature("(Ljava/lang/Iterable<+Ljava/lang/Number;>;)D")]
	[LineNumberTable(489)]
	[Deprecated(new object[]
	{
		(byte)64,
		"Ljava/lang/Deprecated;"
	})]
	public static double mean(Iterable values)
	{
		double result = mean(values.iterator());
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(528)]
	private DoubleMath()
	{
	}

	[LineNumberTable(new byte[] { 160, 164, 244, 106 })]
	static DoubleMath()
	{
		LN_2 = java.lang.Math.log(2.0);
		everySixteenthFactorial = new double[11]
		{
			1.0, 20922789888000.0, 2.631308369336935E+35, 1.2413915592536073E+61, 1.2688693218588417E+89, 7.156945704626381E+118, 9.916779348709496E+149, 1.974506857221074E+182, 3.856204823625804E+215, 5.5502938327393044E+249,
			4.7147236359920616E+284
		};
	}
}
