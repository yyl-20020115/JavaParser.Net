using System.Runtime.CompilerServices;
using IKVM.Attributes;
using java.lang;
using java.math;

namespace com.google.common.math;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/math/ElementTypesAreNonnullByDefault;"
})]
internal sealed class MathPreconditions : Object
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 122, 98, 99, 144 })]
	internal static void checkRoundingUnnecessary(bool P_0)
	{
		if (!P_0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ArithmeticException("mode was UNNECESSARY, but rounding was necessary");
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 188, 105, 159, 59 })]
	internal static BigInteger checkPositive(string P_0, BigInteger P_1)
	{
		if (P_1.signum() <= 0)
		{
			string text = String.valueOf(P_1);
			int num = 15 + String.instancehelper_length(String.valueOf(P_0)) + String.instancehelper_length(String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append(P_0).append(" (").append(text)
				.append(") must be > 0")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 17, 105, 159, 59 })]
	internal static BigInteger checkNonNegative(string P_0, BigInteger P_1)
	{
		if (P_1.signum() < 0)
		{
			string text = String.valueOf(P_1);
			int num = 16 + String.instancehelper_length(String.valueOf(P_0)) + String.instancehelper_length(String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append(P_0).append(" (").append(text)
				.append(") must be >= 0")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 3, 100, 159, 40 })]
	internal static int checkNonNegative(string P_0, int P_1)
	{
		if (P_1 < 0)
		{
			int num = 27 + String.instancehelper_length(String.valueOf(P_0));
			num = num;
			string s = new StringBuilder(num).append(P_0).append(" (").append(P_1)
				.append(") must be >= 0")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 121, 162, 99, 191, 48 })]
	internal static void checkInRangeForRoundingInputs(bool P_0, double P_1, RoundingMode P_2)
	{
		if (!P_0)
		{
			string text = String.valueOf(P_2);
			int num = 83 + String.instancehelper_length(String.valueOf(text));
			num = num;
			string s = new StringBuilder(num).append("rounded value is out of range for input ").append(P_1).append(" and rounding mode ")
				.append(text)
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ArithmeticException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 24, 105, 159, 41 })]
	internal static double checkNonNegative(string P_0, double P_1)
	{
		if (!(P_1 >= 0.0))
		{
			int num = 40 + String.instancehelper_length(String.valueOf(P_0));
			num = num;
			string s = new StringBuilder(num).append(P_0).append(" (").append(P_1)
				.append(") must be >= 0")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 174, 100, 159, 40 })]
	internal static int checkPositive(string P_0, int P_1)
	{
		if (P_1 <= 0)
		{
			int num = 26 + String.instancehelper_length(String.valueOf(P_0));
			num = num;
			string s = new StringBuilder(num).append(P_0).append(" (").append(P_1)
				.append(") must be > 0")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 119, 130, 99, 159, 66 })]
	internal static void checkNoOverflow(bool P_0, string P_1, int P_2, int P_3)
	{
		if (!P_0)
		{
			int num = 36 + String.instancehelper_length(String.valueOf(P_1));
			num = num;
			string s = new StringBuilder(num).append("overflow: ").append(P_1).append("(")
				.append(P_2)
				.append(", ")
				.append(P_3)
				.append(")")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ArithmeticException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 181, 101, 159, 40 })]
	internal static long checkPositive(string P_0, long P_1)
	{
		if (P_1 <= 0)
		{
			int num = 35 + String.instancehelper_length(String.valueOf(P_0));
			num = num;
			string s = new StringBuilder(num).append(P_0).append(" (").append(P_1)
				.append(") must be > 0")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 10, 101, 159, 40 })]
	internal static long checkNonNegative(string P_0, long P_1)
	{
		if (P_1 < 0)
		{
			int num = 36 + String.instancehelper_length(String.valueOf(P_0));
			num = num;
			string s = new StringBuilder(num).append(P_0).append(" (").append(P_1)
				.append(") must be >= 0")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new IllegalArgumentException(s);
		}
		return P_1;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 159, 117, 66, 99, 159, 66 })]
	internal static void checkNoOverflow(bool P_0, string P_1, long P_2, long P_3)
	{
		if (!P_0)
		{
			int num = 54 + String.instancehelper_length(String.valueOf(P_1));
			num = num;
			string s = new StringBuilder(num).append("overflow: ").append(P_1).append("(")
				.append(P_2)
				.append(", ")
				.append(P_3)
				.append(")")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new ArithmeticException(s);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(105)]
	private MathPreconditions()
	{
	}
}
