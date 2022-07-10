using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using com.google.common.primitives;
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
public sealed class IntMath : java.lang.Object
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

		[LineNumberTable(121)]
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

	internal const int MAX_SIGNED_POWER_OF_TWO = 1073741824;

	internal const int MAX_POWER_OF_SQRT2_UNSIGNED = -1257966797;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static byte[] maxLog10ForLeadingZeros;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static int[] powersOf10;

	[Modifiers(Modifiers.Static | Modifiers.Final)]
	internal static int[] halfPowersOf10;

	internal const int FLOOR_SQRT_MAX_INT = 46340;

	[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	private static int[] factorials;

	internal static int[] biggestBinomials;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[SpecialName]
	public static void ___003Cclinit_003E()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 108, 102, 114 })]
	public static int checkedMultiply(int a, int b)
	{
		long num = (long)a * (long)b;
		MathPreconditions.checkNoOverflow(num == (int)num, "checkedMultiply", a, b);
		return (int)num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		162, 25, 108, 108, 115, 102, 133, 115, 134, 146,
		130, 130, 99, 102, 103, 16, 198
	})]
	public static int binomial(int n, int k)
	{
		MathPreconditions.checkNonNegative("n", n);
		MathPreconditions.checkNonNegative("k", k);
		Preconditions.checkArgument(k <= n, "k (%s) > n (%s)", k, n);
		if (k > n >> 1)
		{
			k = n - k;
		}
		if (k >= (nint)biggestBinomials.LongLength || n > biggestBinomials[k])
		{
			return int.MaxValue;
		}
		switch (k)
		{
		case 0:
			return 1;
		case 1:
			return n;
		default:
		{
			long num = 1L;
			for (int i = 0; i < k; i++)
			{
				num *= n - i;
				long num2 = num;
				long num3 = i + 1;
				num = ((num3 != -1) ? (num2 / num3) : (-num2));
			}
			return (int)num;
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(559)]
	public static int saturatedMultiply(int a, int b)
	{
		int result = Ints.saturatedCast((long)a * (long)b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 254, 108 })]
	public static int factorial(int n)
	{
		MathPreconditions.checkNonNegative("n", n);
		return (n >= (nint)factorials.LongLength) ? int.MaxValue : factorials[n];
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 86, 102, 114 })]
	public static int checkedAdd(int a, int b)
	{
		long num = (long)a + (long)b;
		MathPreconditions.checkNoOverflow(num == (int)num, "checkedAdd", a, b);
		return (int)num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 157, 108, 103, 159, 22, 171, 162, 204, 230,
		76, 138
	})]
	public static int sqrt(int x, RoundingMode mode)
	{
		MathPreconditions.checkNonNegative("x", x);
		int num = sqrtFloor(x);
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary(num * num == x);
			goto case 2;
		case 2:
		case 3:
			return num;
		case 4:
		case 5:
			return num + lessThanBranchFree(num * num, x);
		case 6:
		case 7:
		case 8:
		{
			int num2 = num * num + num;
			return num + lessThanBranchFree(num2, x);
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		70, 108, 159, 22, 203, 202, 236, 70, 103, 139,
		101, 170
	})]
	public static int log2(int x, RoundingMode mode)
	{
		MathPreconditions.checkPositive("x", x);
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary(isPowerOfTwo(x));
			goto case 2;
		case 2:
		case 3:
			return 31 - Integer.numberOfLeadingZeros(x);
		case 4:
		case 5:
			return 32 - Integer.numberOfLeadingZeros(x - 1);
		case 6:
		case 7:
		case 8:
		{
			int num = Integer.numberOfLeadingZeros(x);
			int num2 = (int)(3037000499u >> num);
			int num3 = 31 - num;
			return num3 + lessThanBranchFree(num2, x);
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(537)]
	public static int saturatedAdd(int a, int b)
	{
		int result = Ints.saturatedCast((long)a + (long)b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 204, 103, 99, 144, 108, 134, 99, 226, 74,
		137, 159, 25, 172, 98, 133, 98, 133, 101, 133,
		101, 197, 104, 174, 100, 159, 4, 134, 130, 139
	})]
	public static int divide(int p, int q, RoundingMode mode)
	{
		Preconditions.checkNotNull(mode);
		if (q == 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ArithmeticException("/ by zero");
		}
		int num = ((q != -1) ? (p / q) : (-p));
		int num2 = p - q * num;
		if (num2 == 0)
		{
			return num;
		}
		int num3 = 1 | ((p ^ q) >> 31);
		int num6;
		switch (_1._0024SwitchMap_0024java_0024math_0024RoundingMode[mode.ordinal()])
		{
		case 1:
			MathPreconditions.checkRoundingUnnecessary((num2 == 0) ? true : false);
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
			int num4 = java.lang.Math.abs(num2);
			int num5 = num4 - (java.lang.Math.abs(q) - num4);
			num6 = ((num5 != 0) ? ((num5 > 0) ? 1 : 0) : ((mode == RoundingMode.HALF_UP || (mode == RoundingMode.HALF_EVEN && ((((uint)num & (true ? 1u : 0u)) != 0) ? true : false))) ? 1 : 0));
			break;
		}
		default:
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new AssertionError();
		}
		return (num6 == 0) ? num : (num + num3);
	}

	public static bool isPowerOfTwo(int x)
	{
		return x > 0 && (((x & (x - 1)) == 0) ? true : false);
	}

	internal static int lessThanBranchFree(int P_0, int P_1)
	{
		return (int)((uint)((P_0 - P_1) ^ -1 ^ -1) >> 31);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 78, 237, 69 })]
	private static int log10Floor(int P_0)
	{
		int num = maxLog10ForLeadingZeros[Integer.numberOfLeadingZeros(P_0)];
		return num - lessThanBranchFree(P_0, powersOf10[num]);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(306)]
	private static int sqrtFloor(int P_0)
	{
		return ByteCodeHelper.d2i(java.lang.Math.sqrt(P_0));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 18, 108, 104, 159, 22 })]
	public static int ceilingPowerOfTwo(int x)
	{
		MathPreconditions.checkPositive("x", x);
		if (x > 1073741824)
		{
			int num = 58;
			num = num;
			string s = new StringBuilder(num).append("ceilingPowerOfTwo(").append(x).append(") not representable as an int")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ArithmeticException(s);
		}
		return 1 << -Integer.numberOfLeadingZeros(x - 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 34, 108 })]
	public static int floorPowerOfTwo(int x)
	{
		MathPreconditions.checkPositive("x", x);
		int result = Integer.highestOneBit(x);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		111, 108, 103, 104, 159, 22, 201, 162, 234, 69,
		144
	})]
	public static int log10(int x, RoundingMode mode)
	{
		MathPreconditions.checkPositive("x", x);
		int num = log10Floor(x);
		int num2 = powersOf10[num];
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
		160, 115, 108, 159, 0, 136, 130, 138, 143, 101,
		149, 226, 69, 98, 146, 130, 132, 108, 229, 56
	})]
	public static int pow(int b, int k)
	{
		MathPreconditions.checkNonNegative("exponent", k);
		switch (b)
		{
		case 0:
			return (k == 0) ? 1 : 0;
		case 1:
			return 1;
		case -1:
			return ((k & 1) == 0) ? 1 : (-1);
		case 2:
			return (k < 32) ? (1 << k) : 0;
		case -2:
			if (k < 32)
			{
				return (((uint)k & (true ? 1u : 0u)) != 0) ? (-(1 << k)) : (1 << k);
			}
			return 0;
		default:
		{
			int num = 1;
			while (true)
			{
				switch (k)
				{
				case 0:
					return num;
				case 1:
					return b * num;
				}
				num *= (((k & 1) == 0) ? 1 : b);
				b *= b;
				k >>= 1;
			}
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 22, 100, 159, 22, 109 })]
	public static int mod(int x, int m)
	{
		if (m <= 0)
		{
			int num = 31;
			num = num;
			string s = new StringBuilder(num).append("Modulus ").append(m).append(" must be > 0")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new java.lang.ArithmeticException(s);
		}
		int num2 = ((m != -1) ? (x % m) : 0);
		return (num2 < 0) ? (num2 + m) : num2;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 41, 108, 108, 163, 98, 99, 226, 70, 103,
		104, 103, 104, 228, 72, 132, 167, 167, 101, 109,
		98
	})]
	public static int gcd(int a, int b)
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
		int num = Integer.numberOfTrailingZeros(a);
		a >>= num;
		int num2 = Integer.numberOfTrailingZeros(b);
		b >>= num2;
		while (a != b)
		{
			int num3 = a - b;
			int num4 = num3 & (num3 >> 31);
			a = num3 - num4 - num4;
			b += num4;
			a >>= Integer.numberOfTrailingZeros(a);
		}
		return a << java.lang.Math.min(num, num2);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 97, 102, 114 })]
	public static int checkedSubtract(int a, int b)
	{
		long num = (long)a - (long)b;
		MathPreconditions.checkNoOverflow(num == (int)num, "checkedSubtract", a, b);
		return (int)num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 122, 108, 159, 0, 136, 130, 138, 113, 135,
		113, 212, 130, 146, 130, 138, 101, 136, 101, 100,
		127, 4
	})]
	public static int checkedPow(int b, int k)
	{
		MathPreconditions.checkNonNegative("exponent", k);
		switch (b)
		{
		case 0:
			return (k == 0) ? 1 : 0;
		case 1:
			return 1;
		case -1:
			return ((k & 1) == 0) ? 1 : (-1);
		case 2:
			MathPreconditions.checkNoOverflow(k < 31, "checkedPow", b, k);
			return 1 << k;
		case -2:
			MathPreconditions.checkNoOverflow(k < 32, "checkedPow", b, k);
			return (((uint)k & (true ? 1u : 0u)) != 0) ? (-1 << k) : (1 << k);
		default:
		{
			int num = 1;
			while (true)
			{
				switch (k)
				{
				case 0:
					return num;
				case 1:
				{
					int result = checkedMultiply(num, b);
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
					MathPreconditions.checkNoOverflow(-46340 <= b && b <= 46340, "checkedPow", b, k);
					b *= b;
				}
			}
		}
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(548)]
	public static int saturatedSubtract(int a, int b)
	{
		int result = Ints.saturatedCast((long)a - (long)b);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 200, 108, 159, 0, 136, 130, 138, 101, 134,
		135, 101, 138, 212, 130, 143, 146, 130, 138, 101,
		136, 101, 100, 115, 130
	})]
	public static int saturatedPow(int b, int k)
	{
		MathPreconditions.checkNonNegative("exponent", k);
		switch (b)
		{
		case 0:
			return (k == 0) ? 1 : 0;
		case 1:
			return 1;
		case -1:
			return ((k & 1) == 0) ? 1 : (-1);
		case 2:
			if (k >= 31)
			{
				return int.MaxValue;
			}
			return 1 << k;
		case -2:
			if (k >= 32)
			{
				return int.MaxValue + (k & 1);
			}
			return (((uint)k & (true ? 1u : 0u)) != 0) ? (-1 << k) : (1 << k);
		default:
		{
			int num = 1;
			int result = (int)(int.MaxValue + (((uint)b >> 31) & (uint)(k & 1)));
			while (true)
			{
				switch (k)
				{
				case 0:
					return num;
				case 1:
				{
					int result2 = saturatedMultiply(num, b);
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
					if (-46340 > b || b > 46340)
					{
						return result;
					}
					b *= b;
				}
			}
		}
		}
	}

	public static int mean(int x, int y)
	{
		return (x & y) + ((x ^ y) >> 1);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(725)]
	public static bool isPrime(int n)
	{
		bool result = LongMath.isPrime(n);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(728)]
	private IntMath()
	{
	}

	[LineNumberTable(new byte[]
	{
		160,
		88,
		byte.MaxValue,
		160,
		76,
		70,
		byte.MaxValue,
		52,
		70,
		byte.MaxValue,
		55,
		161,
		158,
		byte.MaxValue,
		67,
		113
	})]
	static IntMath()
	{
		maxLog10ForLeadingZeros = new byte[33]
		{
			9, 9, 9, 8, 8, 8, 7, 7, 7, 6,
			6, 6, 6, 5, 5, 5, 4, 4, 4, 3,
			3, 3, 3, 2, 2, 2, 1, 1, 1, 0,
			0, 0, 0
		};
		powersOf10 = new int[10] { 1, 10, 100, 1000, 10000, 100000, 1000000, 10000000, 100000000, 1000000000 };
		halfPowersOf10 = new int[10] { 3, 31, 316, 3162, 31622, 316227, 3162277, 31622776, 316227766, 2147483647 };
		factorials = new int[13]
		{
			1, 1, 2, 6, 24, 120, 720, 5040, 40320, 362880,
			3628800, 39916800, 479001600
		};
		biggestBinomials = new int[17]
		{
			2147483647, 2147483647, 65536, 2345, 477, 193, 110, 75, 58, 49,
			43, 39, 37, 35, 34, 34, 33
		};
	}
}
