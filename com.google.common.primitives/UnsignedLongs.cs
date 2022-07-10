using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.math;
using java.util;
using java.util.function;

namespace com.google.common.primitives;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
public sealed class UnsignedLongs : java.lang.Object
{
	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/primitives/UnsignedLongs$LexicographicalComparator;>;Ljava/util/Comparator<[J>;")]
	[Modifiers(Modifiers.Final | Modifiers.Super | Modifiers.Enum)]
	[Implements(new string[] { "java.util.Comparator" })]
	internal sealed class LexicographicalComparator : java.lang.Enum, Comparator
	{
		[Modifiers(Modifiers.Public | Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
		public static LexicographicalComparator INSTANCE;

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Final | Modifiers.Synthetic)]
		private static LexicographicalComparator[] _0024VALUES;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(new byte[] { 116, 106, 102, 104, 14, 230, 69 })]
		public virtual int compare(long[] P_0, long[] P_1)
		{
			int num = java.lang.Math.min(P_0.Length, P_1.Length);
			for (int i = 0; i < num; i++)
			{
				if (P_0[i] != P_1[i])
				{
					int result = UnsignedLongs.compare(P_0[i], P_1[i]);
					_ = null;
					return result;
				}
			}
			return (int)((nint)P_0.LongLength - (nint)P_1.LongLength);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(161)]
		private LexicographicalComparator(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(161)]
		private static LexicographicalComparator[] _0024values()
		{
			return new LexicographicalComparator[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(161)]
		public static LexicographicalComparator[] values()
		{
			return (LexicographicalComparator[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(161)]
		public static LexicographicalComparator valueOf(string P_0)
		{
			return (LexicographicalComparator)java.lang.Enum.valueOf(ClassLiteral<LexicographicalComparator>.Value, P_0);
		}

		public override string toString()
		{
			return "UnsignedLongs.lexicographicalComparator()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(161)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((long[])P_0, (long[])P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 112, 48 })]
		static LexicographicalComparator()
		{
			INSTANCE = new LexicographicalComparator("INSTANCE", 0);
			_0024VALUES = _0024values();
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(Comparator P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator reversed()
		{
			return Comparator._003Cdefault_003Ereversed(this);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(java.util.function.Function P_0, Comparator P_1)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0, P_1);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparing(java.util.function.Function P_0)
		{
			return Comparator._003Cdefault_003EthenComparing(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingInt(ToIntFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingInt(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingLong(ToLongFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingLong(this, P_0);
		}

		[HideFromJava(HideFromJavaFlags.Reflection | HideFromJavaFlags.StackWalk | HideFromJavaFlags.StackTrace)]
		public virtual Comparator thenComparingDouble(ToDoubleFunction P_0)
		{
			return Comparator._003Cdefault_003EthenComparingDouble(this, P_0);
		}

		bool Comparator.Comparator_003A_003Aequals(object P_0)
		{
			return equals(P_0);
		}
	}

	[InnerClass(null, Modifiers.Private | Modifiers.Static | Modifiers.Final)]
	internal sealed class ParseOverflowDetection : java.lang.Object
	{
		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static long[] maxValueDivs;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static int[] maxValueMods;

		[Modifiers(Modifiers.Static | Modifiers.Final)]
		internal static int[] maxSafeDigits;

		[MethodImpl(MethodImplOptions.NoInlining)]
		[SpecialName]
		public static void ___003Cclinit_003E()
		{
		}

		[LineNumberTable(new byte[] { 161, 51, 101, 106, 130, 106, 162, 203 })]
		internal static bool overflowInParse(long P_0, int P_1, int P_2)
		{
			if (P_0 >= 0)
			{
				if (P_0 < maxValueDivs[P_2])
				{
					return false;
				}
				if (P_0 > maxValueDivs[P_2])
				{
					return true;
				}
				return P_1 > maxValueMods[P_2];
			}
			return true;
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(398)]
		private ParseOverflowDetection()
		{
		}

		[LineNumberTable(new byte[]
		{
			161, 31, 108, 108, 172, 109, 103, 112, 113, 245,
			61, 230, 69
		})]
		static ParseOverflowDetection()
		{
			maxValueDivs = new long[37];
			maxValueMods = new int[37];
			maxSafeDigits = new int[37];
			BigInteger bigInteger = new BigInteger("10000000000000000", 16);
			for (int i = 2; i <= 36; i++)
			{
				maxValueDivs[i] = divide(-1L, i);
				maxValueMods[i] = (int)remainder(-1L, i);
				maxSafeDigits[i] = java.lang.String.instancehelper_length(bigInteger.toString(i)) - 1;
			}
		}
	}

	public const long MAX_VALUE = -1L;

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 171, 101, 106, 130, 228, 69, 101, 239, 73,
		113, 102
	})]
	public static long remainder(long dividend, long divisor)
	{
		if (divisor < 0)
		{
			if (compare(dividend, divisor) < 0)
			{
				return dividend;
			}
			return dividend - divisor;
		}
		if (dividend >= 0)
		{
			return (divisor != -1) ? (dividend % divisor) : 0;
		}
		ulong num = (ulong)dividend >> 1;
		long num2 = ((divisor != -1) ? ((long)num / divisor) : ((long)(0L - num))) << 1;
		long num3 = dividend - num2 * divisor;
		return num3 - ((compare(num3, divisor) < 0) ? 0 : divisor);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(80)]
	public static int compare(long a, long b)
	{
		int result = Longs.compare(flip(a), flip(b));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 225, 103, 104, 144, 105, 191, 12, 106, 99,
		110, 111, 101, 140, 111, 159, 20, 233, 56, 233,
		75
	})]
	public static long parseUnsignedLong(string @string, int radix)
	{
		Preconditions.checkNotNull(@string);
		if (java.lang.String.instancehelper_length(@string) == 0)
		{
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NumberFormatException("empty string");
		}
		if (radix < 2 || radix > 36)
		{
			int num = 26;
			num = num;
			string s = new StringBuilder(num).append("illegal radix: ").append(radix).toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NumberFormatException(s);
		}
		int num2 = ParseOverflowDetection.maxSafeDigits[radix] - 1;
		long num3 = 0L;
		for (int i = 0; i < java.lang.String.instancehelper_length(@string); i++)
		{
			int num4 = Character.digit(java.lang.String.instancehelper_charAt(@string, i), radix);
			if (num4 == -1)
			{
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NumberFormatException(@string);
			}
			if (i > num2 && ParseOverflowDetection.overflowInParse(num3, num4, radix))
			{
				string text = java.lang.String.valueOf(@string);
				string s2;
				if (java.lang.String.instancehelper_length(text) != 0)
				{
					s2 = java.lang.String.instancehelper_concat("Too large for unsigned long: ", text);
				}
				else
				{
					string text2 = "Too large for unsigned long: ";
					text2 = text2;
					s2 = java.lang.String.newhelper(text2);
				}
				Throwable.___003CsuppressFillInStackTrace_003E();
				throw new NumberFormatException(s2);
			}
			num3 = num3 * radix + num4;
		}
		return num3;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 135, 101, 106, 131, 227, 69, 101, 237, 73,
		113, 102
	})]
	public static long divide(long dividend, long divisor)
	{
		if (divisor < 0)
		{
			if (compare(dividend, divisor) < 0)
			{
				return 0L;
			}
			return 1L;
		}
		if (dividend >= 0)
		{
			return (divisor != -1) ? (dividend / divisor) : (-dividend);
		}
		ulong num = (ulong)dividend >> 1;
		long num2 = ((divisor != -1) ? ((long)num / divisor) : ((long)(0L - num))) << 1;
		long a = dividend - num2 * divisor;
		return num2 + ((compare(a, divisor) >= 0) ? 1 : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(443)]
	public static string toString(long x)
	{
		string result = toString(x, 10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		161, 88, 216, 137, 102, 101, 138, 104, 99, 135,
		103, 132, 113, 104, 105, 197, 133, 149, 138, 105,
		112, 132, 101, 125, 209
	})]
	public static string toString(long x, int radix)
	{
		Preconditions.checkArgument((radix >= 2 && radix <= 36) ? true : false, "radix (%s) must be between Character.MIN_RADIX and Character.MAX_RADIX", radix);
		if (x == 0)
		{
			return "0";
		}
		if (x > 0)
		{
			string result = Long.toString(x, radix);
			_ = null;
			return result;
		}
		char[] array = new char[64];
		int num = array.Length;
		if ((radix & (radix - 1)) == 0)
		{
			int num2 = Integer.numberOfTrailingZeros(radix);
			int num3 = radix - 1;
			do
			{
				num += -1;
				array[num] = Character.forDigit((int)x & num3, radix);
				x = (long)((ulong)x >> num2);
			}
			while (x != 0);
		}
		else
		{
			long num6;
			if ((radix & 1) == 0)
			{
				ulong num4 = (ulong)x >> 1;
				long num5 = (int)((uint)radix >> 1);
				num6 = ((num5 != -1) ? ((long)num4 / num5) : ((long)(0L - num4)));
			}
			else
			{
				num6 = divide(x, radix);
			}
			long num7 = x - num6 * radix;
			num += -1;
			array[num] = Character.forDigit((int)num7, radix);
			x = num6;
			while (x > 0)
			{
				num += -1;
				int num8 = num;
				long num9 = x;
				long num10 = radix;
				array[num8] = Character.forDigit((int)((num10 != -1) ? (num9 % num10) : 0), radix);
				long num11 = x;
				long num12 = radix;
				x = ((num12 != -1) ? (num11 / num12) : (-num11));
			}
		}
		string result2 = java.lang.String.newhelper(array, num, (int)((nint)array.LongLength - num));
		_ = null;
		return result2;
	}

	private static long flip(long P_0)
	{
		return P_0 ^ long.MinValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 84, 103, 105, 102, 43, 166, 104, 102, 43,
		166
	})]
	public static void sort(long[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		for (int i = fromIndex; i < toIndex; i++)
		{
			array[i] = flip(array[i]);
		}
		Arrays.sort(array, fromIndex, toIndex);
		for (int i = fromIndex; i < toIndex; i++)
		{
			array[i] = flip(array[i]);
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 113, 103, 105, 102, 52, 166, 104, 102, 52,
		166
	})]
	public static void sortDescending(long[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		for (int i = fromIndex; i < toIndex; i++)
		{
			int num = i;
			long[] array2 = array;
			array2[num] ^= long.MaxValue;
		}
		Arrays.sort(array, fromIndex, toIndex);
		for (int i = fromIndex; i < toIndex; i++)
		{
			int num = i;
			long[] array2 = array;
			array2[num] ^= long.MaxValue;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(55)]
	private UnsignedLongs()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 42, 106, 105, 103, 105, 100, 226, 61, 230, 70 })]
	public static long min(params long[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		long num = flip(array[0]);
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			long num2 = flip(array[i]);
			if (num2 < num)
			{
				num = num2;
			}
		}
		long result = flip(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 62, 106, 105, 103, 105, 100, 226, 61, 230, 70 })]
	public static long max(params long[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		long num = flip(array[0]);
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			long num2 = flip(array[i]);
			if (num2 > num)
			{
				num = num2;
			}
		}
		long result = flip(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 82, 103, 100, 198, 106, 111, 103, 53, 166 })]
	public static string join(string separator, params long[] array)
	{
		Preconditions.checkNotNull(separator);
		if (array.Length == 0)
		{
			return "";
		}
		StringBuilder stringBuilder = new StringBuilder((int)((nint)array.LongLength * 5));
		stringBuilder.append(toString(array[0]));
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			stringBuilder.append(separator).append(toString(array[i]));
		}
		string result = stringBuilder.toString();
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[Signature("()Ljava/util/Comparator<[J>;")]
	[LineNumberTable(158)]
	public static Comparator lexicographicalComparator()
	{
		return LexicographicalComparator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 73, 103, 107 })]
	public static void sort(long[] array)
	{
		Preconditions.checkNotNull(array);
		sort(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 102, 103, 107 })]
	public static void sortDescending(long[] array)
	{
		Preconditions.checkNotNull(array);
		sortDescending(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(321)]
	public static long parseUnsignedLong(string @string)
	{
		long result = parseUnsignedLong(@string, 10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 11, 167, 127, 8, 97, 159, 16, 105 })]
	public static long decode(string stringValue)
	{
		//Discarded unreachable code: IL_001a
		ParseRequest parseRequest = ParseRequest.fromString(stringValue);
		NumberFormatException ex;
		try
		{
			return parseUnsignedLong(parseRequest.rawValue, parseRequest.radix);
		}
		catch (NumberFormatException x)
		{
			ex = ByteCodeHelper.MapException<NumberFormatException>(x, ByteCodeHelper.MapFlags.NoRemapping);
		}
		NumberFormatException cause = ex;
		string text = java.lang.String.valueOf(stringValue);
		string s;
		if (java.lang.String.instancehelper_length(text) != 0)
		{
			s = java.lang.String.instancehelper_concat("Error parsing value: ", text);
		}
		else
		{
			string text2 = "Error parsing value: ";
			text2 = text2;
			s = java.lang.String.newhelper(text2);
		}
		NumberFormatException ex2 = new NumberFormatException(s);
		Throwable.instancehelper_initCause(ex2, cause);
		throw Throwable.___003Cunmap_003E(ex2);
	}
}
