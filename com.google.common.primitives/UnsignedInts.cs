using System;
using System.Runtime.CompilerServices;
using com.google.common.@base;
using IKVM.Attributes;
using ikvm.@internal;
using IKVM.Runtime;
using java.lang;
using java.util;
using java.util.function;

namespace com.google.common.primitives;

[ElementTypesAreNonnullByDefault(new object[]
{
	(byte)64,
	"Lcom/google/common/primitives/ElementTypesAreNonnullByDefault;"
})]
public sealed class UnsignedInts : java.lang.Object
{
	[Serializable]
	[InnerClass(null, Modifiers.Static | Modifiers.Final | Modifiers.Enum)]
	[Signature("Ljava/lang/Enum<Lcom/google/common/primitives/UnsignedInts$LexicographicalComparator;>;Ljava/util/Comparator<[I>;")]
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
		[LineNumberTable(new byte[] { 160, 86, 106, 102, 104, 14, 230, 69 })]
		public virtual int compare(int[] P_0, int[] P_1)
		{
			int num = java.lang.Math.min(P_0.Length, P_1.Length);
			for (int i = 0; i < num; i++)
			{
				if (P_0[i] != P_1[i])
				{
					int result = UnsignedInts.compare(P_0[i], P_1[i]);
					_ = null;
					return result;
				}
			}
			return (int)((nint)P_0.LongLength - (nint)P_1.LongLength);
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Signature("()V")]
		[LineNumberTable(195)]
		private LexicographicalComparator(string P_0, int P_1)
			: base(P_0, P_1)
		{
			GC.KeepAlive(this);
		}

		[Modifiers(Modifiers.Private | Modifiers.Static | Modifiers.Synthetic)]
		[LineNumberTable(195)]
		private static LexicographicalComparator[] _0024values()
		{
			return new LexicographicalComparator[1] { INSTANCE };
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(195)]
		public static LexicographicalComparator[] values()
		{
			return (LexicographicalComparator[])_0024VALUES.Clone();
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[LineNumberTable(195)]
		public static LexicographicalComparator valueOf(string P_0)
		{
			return (LexicographicalComparator)java.lang.Enum.valueOf(ClassLiteral<LexicographicalComparator>.Value, P_0);
		}

		public override string toString()
		{
			return "UnsignedInts.lexicographicalComparator()";
		}

		[MethodImpl(MethodImplOptions.NoInlining)]
		[Modifiers(Modifiers.Public | Modifiers.Volatile | Modifiers.Synthetic)]
		[LineNumberTable(195)]
		public virtual int compare(object P_0, object P_1)
		{
			int result = compare((int[])P_0, (int[])P_1);
			_ = null;
			return result;
		}

		[LineNumberTable(new byte[] { 160, 82, 48 })]
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

	internal const long INT_MASK = 4294967295L;

	public static long toLong(int value)
	{
		return value & 0xFFFFFFFFu;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 244, 103, 104, 107, 191, 50 })]
	public static int parseUnsignedInt(string @string, int radix)
	{
		Preconditions.checkNotNull(@string);
		long num = Long.parseLong(@string, radix);
		if ((num & 0xFFFFFFFFu) != num)
		{
			int num2 = 69 + java.lang.String.instancehelper_length(java.lang.String.valueOf(@string));
			num2 = num2;
			string s = new StringBuilder(num2).append("Input ").append(@string).append(" in base ")
				.append(radix)
				.append(" is not in the range of an unsigned integer")
				.toString();
			Throwable.___003CsuppressFillInStackTrace_003E();
			throw new NumberFormatException(s);
		}
		return (int)num;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(283)]
	public static int divide(int dividend, int divisor)
	{
		long num = toLong(dividend);
		long num2 = toLong(divisor);
		return (int)((num2 != -1) ? (num / num2) : (-num));
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(297)]
	public static int remainder(int dividend, int divisor)
	{
		long num = toLong(dividend);
		long num2 = toLong(divisor);
		return (int)((num2 != -1) ? (num % num2) : 0);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(72)]
	public static int compare(int a, int b)
	{
		int result = Ints.compare(flip(a), flip(b));
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 161, 18, 106 })]
	public static string toString(int x, int radix)
	{
		long i = x & 0xFFFFFFFFu;
		string result = Long.toString(i, radix);
		_ = null;
		return result;
	}

	internal static int flip(int P_0)
	{
		return P_0 ^ int.MinValue;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(373)]
	public static string toString(int x)
	{
		string result = toString(x, 10);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[]
	{
		160, 118, 103, 105, 102, 43, 166, 104, 102, 43,
		166
	})]
	public static void sort(int[] array, int fromIndex, int toIndex)
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
		160, 147, 103, 105, 102, 48, 166, 104, 102, 48,
		166
	})]
	public static void sortDescending(int[] array, int fromIndex, int toIndex)
	{
		Preconditions.checkNotNull(array);
		Preconditions.checkPositionIndexes(fromIndex, toIndex, array.Length);
		for (int i = fromIndex; i < toIndex; i++)
		{
			int num = i;
			int[] array2 = array;
			array2[num] ^= int.MaxValue;
		}
		Arrays.sort(array, fromIndex, toIndex);
		for (int i = fromIndex; i < toIndex; i++)
		{
			int num = i;
			int[] array2 = array;
			array2[num] ^= int.MaxValue;
		}
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(54)]
	private UnsignedInts()
	{
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 45, 115 })]
	public static int checkedCast(long value)
	{
		Preconditions.checkArgument(value >> 32 == 0, "out of range: %s", value);
		return (int)value;
	}

	public static int saturatedCast(long value)
	{
		if (value <= 0)
		{
			return 0;
		}
		if (value >= 4294967296L)
		{
			return -1;
		}
		return (int)value;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 77, 106, 105, 103, 105, 100, 226, 61, 230, 70 })]
	public static int min(params int[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		int num = flip(array[0]);
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			int num2 = flip(array[i]);
			if (num2 < num)
			{
				num = num2;
			}
		}
		int result = flip(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 97, 106, 105, 103, 105, 100, 226, 61, 230, 70 })]
	public static int max(params int[] array)
	{
		Preconditions.checkArgument((nint)array.LongLength > 0);
		int num = flip(array[0]);
		for (int i = 1; i < (nint)array.LongLength; i++)
		{
			int num2 = flip(array[i]);
			if (num2 > num)
			{
				num = num2;
			}
		}
		int result = flip(num);
		_ = null;
		return result;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 117, 103, 100, 198, 106, 111, 103, 53, 166 })]
	public static string join(string separator, params int[] array)
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
	[Signature("()Ljava/util/Comparator<[I>;")]
	[LineNumberTable(192)]
	public static Comparator lexicographicalComparator()
	{
		return LexicographicalComparator.INSTANCE;
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 107, 103, 107 })]
	public static void sort(int[] array)
	{
		Preconditions.checkNotNull(array);
		sort(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 136, 103, 107 })]
	public static void sortDescending(int[] array)
	{
		Preconditions.checkNotNull(array);
		sortDescending(array, 0, array.Length);
	}

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(new byte[] { 160, 203, 167, 127, 8, 97, 159, 16, 105 })]
	public static int decode(string stringValue)
	{
		//Discarded unreachable code: IL_001a
		ParseRequest parseRequest = ParseRequest.fromString(stringValue);
		NumberFormatException ex;
		try
		{
			return parseUnsignedInt(parseRequest.rawValue, parseRequest.radix);
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

	[MethodImpl(MethodImplOptions.NoInlining)]
	[LineNumberTable(340)]
	public static int parseUnsignedInt(string s)
	{
		int result = parseUnsignedInt(s, 10);
		_ = null;
		return result;
	}
}
